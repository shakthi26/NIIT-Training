using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plugintask
{
    public class loyalty : IPlugin
    {
        IOrganizationService service;
        ITracingService tracingService;
        IPluginExecutionContext context;
        Entity entity;
        public void Execute(IServiceProvider serviceProvider)
        {
            context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                entity = (Entity)context.InputParameters["Target"];
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                service = serviceFactory.CreateOrganizationService(context.UserId);
                tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

                try
                {
                    if (entity.LogicalName == "shka_purchase")
                    {
                        switch (context.Stage)
                        {
                            case 40://post-operation

                                switch (context.MessageName)
                                {
                                    case "Create":
                                        CalculateSpendAnalyzer();
                                        CalculateRedeemPoints();
                                        break;
                                }
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        private void CalculateSpendAnalyzer()
        {
            try
            {
                if (entity.Attributes.Contains("shka_customer"))
                {
                    Guid contactname = entity.GetAttributeValue<EntityReference>("shka_customer").Id;
                    Entity contact = service.Retrieve("contact", contactname, new ColumnSet("cr207_spendanalyzer"));


                    if (contact.Attributes.Contains("cr207_spendanalyzer"))
                    {
                      contact["cr207_spendanalyzer"] = contact.GetAttributeValue<Int32>("cr207_spendanalyzer") + (Int32)entity.GetAttributeValue<Int32>("shka_total_price");
                    }
                    else
                    {
                        contact["cr207_spendanalyzer"] = 0 + (Int32)(entity.GetAttributeValue<Int32>("shka_total_price"));
                    }

                    service.Update(contact);
                    tracingService.Trace("3");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        private void CalculateRedeemPoints()
        {
            try
            {
                if (entity.Attributes.Contains("shka_customer"))
                {
                    Guid contactname = entity.GetAttributeValue<EntityReference>("shka_customer").Id;
                    Guid cardname = entity.GetAttributeValue<EntityReference>("shka_customer").Id;//  cr3ea_typeofcard
                    Entity contact = service.Retrieve("contact", contactname, new ColumnSet("cr207_redemptionpoint"));
                    Entity card = service.Retrieve("contact", cardname, new ColumnSet("cr207_cardtype"));

                    if (contact.Attributes.Contains("cr207_redemptionpoint"))
                    {
                        contact["cr207_redemptionpoint"] = contact.GetAttributeValue<Int32>("cr207_redemptionpoint") + (Int32)entity.GetAttributeValue<Int32>("shka_pointsearned");
                        Int32 totalredeempoints = (Int32)contact["cr207_redemptionpoint"];
                        if (totalredeempoints >= 1001 && totalredeempoints <= 2500)
                        {
                            contact["cr207_cardtype"] = "Gold";
                        }
                        else if (totalredeempoints >= 2501)
                        {
                            contact["cr207_cardtype"] = "Platinum";
                        }
                        else
                        {
                            contact["cr207_cardtype"] = "Silver";
                        }
                    }
                    else
                    {
                        contact["cr207_redemptionpoint"] = 0 + (Int32)(entity.GetAttributeValue<Int32>("shka_pointsearned"));
                    }

                    service.Update(contact);
                    tracingService.Trace("3");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}

