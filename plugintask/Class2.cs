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
    class Class2 : CodeActivity

    {
       
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                Entity OrderProductEntity = new Entity("shka_c_orderproduct");


                OrderProductEntity["shka_status"] = 780710001;
                 
               
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
            
        }
    }
}