using Microsoft.VisualStudio.TestTools.UnitTesting;
using dog_race_assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dog_race_assignment.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            RaceResult instance = new RaceResult();
            int y = instance.jump();
            if (y >1)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void TestBudget()
        {
            RaceResult instance = new RaceResult();
            int y = instance.Budget(1,12,100,1);
            if (y==112)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}