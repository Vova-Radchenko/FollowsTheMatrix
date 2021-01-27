using Microsoft.VisualStudio.TestTools.UnitTesting;
using FollowsTheMatrix;
using System;

namespace MatrixTests
{
    [TestClass]
    public class MatrixTest
    {
        private Matrix _matrix;
        
        [TestMethod]
        public void TestMethodMatrix2x2()
        {            
            var mas = new int[2, 2] { { 1, 1 }, { 1, 1 } };
            _matrix = new Matrix(mas);
            var expected = 2;
            Assert.AreEqual(expected, _matrix.GetMatrixTrace());
        }
        [TestMethod]
        public void TestMethodMatrix2x3()
        {
            var mas = new int[2, 3] { { 1, 2, 1 }, { 1, 4, 1 } };
            _matrix = new Matrix(mas);
            var expected = 5;
            Assert.AreEqual(expected, _matrix.GetMatrixTrace());
        }
        [TestMethod]
        public void TestMethodMatrix4x3()
        {
            var mas = new int[4, 3] { { 8, 2, 1 }, { 1, 4, 1 }, { 1, 4, 6 }, { 7, 9, 3 } };
            _matrix = new Matrix(mas);
            var expected = 18;
            Assert.AreEqual(expected, _matrix.GetMatrixTrace());
        }
        [TestMethod]
        public void TestMethodMatrix3x4()
        {
            var mas = new int[3, 4] { { 8, 2, 1, 7 }, { 1, 4, 1, 10 }, { 1, 4, 6, 15 } };
            _matrix = new Matrix(mas);
            var expected = 18;
            Assert.AreEqual(expected, _matrix.GetMatrixTrace());
        }
        [TestMethod]
        public void TestMethodMatrix5x4()
        {
            var mas = new int[5, 4] { { 8, 2, 1, 7 }, { 1, 4, 1, 10 }, { 1, 4, 6, 15 }, { 1, 4, 1, 10 }, { 1, 4, 6, 15 } };
            _matrix = new Matrix(mas);
            var expected = 28;
            Assert.AreEqual(expected, _matrix.GetMatrixTrace());
        }
        [TestMethod]
        public void TestMethodMatrix0x1()
        {
            var mas = new int[0, 1] {  };
            Assert.ThrowsException<Exception>(() => new Matrix(mas));
        }
        [TestMethod]
        public void TestMethodMatrix0x1_2()
        {
            Assert.ThrowsException<Exception>(() => new Matrix(0, 1));
        }
        [TestMethod]
        public void TestMethodMatrix1x0()
        {
            var mas = new int[1, 0] { {  } };
            Assert.ThrowsException<Exception>(() => new Matrix(mas));
        }
        [TestMethod]
        public void TestMethodMatrix1x0_2()
        {
            Assert.ThrowsException<Exception>(() => new Matrix(1, 0));
        }
        [TestMethod]
        public void TestMethodMatrixNull()
        {
            Assert.ThrowsException<Exception>(() => new Matrix(null));
        }
    }
}
