using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCore6Routine.Infra.Data.Interfaces;
using NetCore6Routine.Services;
using NetCore6Routine.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6Routine.Services.Tests
{
    [TestClass()]
    public class BaseServiceTests
    {
        private readonly IBaseService _service;

        public BaseServiceTests(IBaseService service)
        {
            _service = service;
        }

        [TestMethod()]
        public void SetMessageTest()
        {
            string message = _service.SetMessage();
            Assert.IsNotNull(message);
        }
    }
}