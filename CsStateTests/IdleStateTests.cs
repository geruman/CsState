using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsState.Tests
{
    [TestClass()]
    public class IdleStateTests
    {
        private Enemy enemy;
        [TestInitialize()]
        public void Initialize()
        {
            enemy = new Enemy();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            enemy = null;
        }
        [TestMethod()]
        public void ExecuteTest()
        {
            Assert.AreEqual("Idle, thinking...", enemy.Execute());
        }
    }
}