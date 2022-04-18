using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;




namespace plugintask
{
    public class Class1 : IPlugin
    {
        public void Create(IOrganizationService serviceProvider)
        {
            //throw new NotImplementedException();
            try
            {
                Entity TaskEntity = new Entity("task");
                TaskEntity["subject"] = "Test subject";
                TaskEntity["regardingobjectid"] = new EntityReference("shka_room").Id;
                serviceProvider.Create(TaskEntity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Execute(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }
    }
}