using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using O1MaxAndInt;

namespace O1MaxAndIntTests
{
    [TestClass]
    public class IntStackTests
    {
        [TestMethod]
        public void NoValuesGetMax()
        {
            IntMaxStack i = new IntMaxStack();
            int n = i.GetMax();
            Assert.AreEqual(n, -1);
        }

        [TestMethod]
        public void OneValueGetMax()
        {
            IntMaxStack i = new IntMaxStack();
            i.Push(5);
            int n = i.GetMax();
            Assert.AreEqual(n, 5);
        }

        [TestMethod]
        public void TwoValuesGetMax()
        {
            IntMaxStack i = new IntMaxStack();
            i.Push(5);
            i.Push(4);
            int n = i.GetMax();
            Assert.AreEqual(n, 5);
        }

        [TestMethod]
        public void MultValueRemoveGetMax()
        {
            IntMaxStack i = new IntMaxStack();
            i.Push(5);
            i.Push(4);
            i.Push(9);
            i.Push(12);
            i.Remove();
            int n = i.GetMax();
            Assert.AreEqual(n, 9);
        }

        [TestMethod]
        public void MoreRemoveThanPushGetMax()
        {
            IntMaxStack i = new IntMaxStack();
            i.Push(5);
            i.Push(4);
            i.Push(9);
            i.Push(12);
            i.Remove();
            int n = i.GetMax();
            Assert.AreEqual(n, 9);
            i.Remove();
            n = i.GetMax();
            Assert.AreEqual(n, 5);
            i.Remove();
            n = i.GetMax();
            Assert.AreEqual(n, 5);
            i.Remove();
            n = i.GetMax();
            Assert.AreEqual(n, -1);
            i.Remove();
            n = i.GetMax();
            Assert.AreEqual(n, -1);
        }
    }
}
