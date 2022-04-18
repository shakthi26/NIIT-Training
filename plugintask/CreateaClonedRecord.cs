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
    public class CreateaClonedRecord : CodeActivity
    {
        [Input("RoomNumber")]

        public InArgument<string> RoomNumber{ get; set;}

        ITracingService tracingservice;
        IOrganizationService service;
        IWorkflowContext context;

        string base64XML = string.Empty, docId = string.Empty;
        Guid scanActivityGuid = Guid.Empty;
        Guid prescriptionGuid = Guid.Empty;

        protected override void Execute(CodeActivityContext executionContext)
        {
            tracingservice = executionContext.GetExtension<ITracingService>();
            context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                CreateClonedRecord(RoomNumber.Get(executionContext));
            }
            catch(Exception ex)
            {
                throw ex;
            }

          }

        private void CreateClonedRecord(string roomnumber)
        {
            Entity Room = new Entity("shka_room");
            Room["shka_roomnumber"] = roomnumber;
            Room["shka_floornumber"] = 13;
            Room["shka_rtype"] = new OptionSetValue(780710001);
            Room["shka_checkindate"] = DateTime.Now;
            Room["shka_plannedcheckoutdate"] = DateTime.Now;
            Room["shka_actualcheckoutdate"] = DateTime.Now;
            service.Create(Room);

            //throw new NotImplementedException();
        }
    } 
}
