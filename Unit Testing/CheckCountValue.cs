using aspnet_core_unit_1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Unit_Testing
{
   
    public class CheckCountValue
    {
        [Fact]
        public void If_Else_ConditionCheck_Count_Value()
        {
            var controller = new HomeController();
            Assert.Throws<Exception>(() => controller.CheckCountValue(500)); // should throw
         
            controller.CheckCountValue(2); // should not throw
           
        }
    }
}
