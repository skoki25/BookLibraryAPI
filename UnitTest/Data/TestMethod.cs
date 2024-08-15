using BookLibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Data
{
    public class TestMethod
    {
        static public void CheckIfIsBadRequest(IActionResult result)
        {
            if (result is BadRequestObjectResult)
            {
                BadRequestObjectResult badRequestObjectResult = (BadRequestObjectResult)result;
                string error = JsonConvert.SerializeObject(badRequestObjectResult.Value);
                Assert.Fail(error);
            }
        }
        
        static public void IsBadRequest(IActionResult result)
        {
            if (result is not OkObjectResult)
            {
                Assert.Fail("Zly request");
            }
        }


    }
}
