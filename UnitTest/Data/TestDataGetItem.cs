using BookLibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Data
{
    public class TestDataGetItem
    {
        public static T ConvertItem<T>(IActionResult result)
        {
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);
            OkObjectResult resultOk = (OkObjectResult)result;
            return (T)resultOk.Value;
        }

        public static void IsObjectNull<T>(T testObject)
        {
            if (testObject == null)
            {
                Assert.Fail($"{testObject.GetType()} is null ");
            }
        }
    }
}
