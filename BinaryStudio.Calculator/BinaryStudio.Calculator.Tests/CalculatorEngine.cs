using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using BinaryStudio.Calculator;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryStudio.Calculator.Tests
{
    [TestFixture]
    public class CalculatorEngineTests
    {
        [Test]
        public void Should_Return5Poin2_WhenDoind2Point1Add3Point1()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);
            string expectedResult = "5,2000";

            //act
            calculator.Add(2.1, 3.1);

            //assert
            Assert.AreEqual(calculator.correctResult, expectedResult);            
        }

        [Test]
        public void Should_Return1Point1_WhenDoind3Point3Substract2Point2()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);
            string expectedResult = "1,1000";

            //act
            calculator.Substract(3.3, 2.2);

            //assert
            Assert.AreEqual(calculator.correctResult, expectedResult); 
        }

        [Test]
        public void Should_Return1Point21_WhenDoind1Point1Multyply1Point1()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);
            string expectedResult = "1,21000";

            //act
            calculator.Multiply(1.1, 1.1);

            //assert
            Assert.AreEqual(calculator.correctResult, expectedResult); 
        }

        [Test]
        public void Should_Return2Point2_WhenDoind6Point82Devide3Point1()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);
            string expectedResult = "2,2000";

            //act
            calculator.Devide(6.82, 3.1);

            //assert
            Assert.AreEqual(calculator.correctResult, expectedResult); 
        }

        [Test]
        public void ShouldNot_ThrowException_WhenDoindDevideBy0()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);

            //act
            calculator.Devide(1.1, 0);

            //assert
            Assert.Pass();
        }

        [Test]
        public void Should_ReturnDevideBy0_WhenDoind1Point2Devide0()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);
            string expectedResult = "Devide by 0!";

            //act
            calculator.Devide(1.2, 0);

            //assert
            Assert.AreEqual(calculator.correctResult, expectedResult);
        }

        [Test]
        public void Should_Output5Point2_WhenDoind2Point1Add3Point1()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);

            //act
            calculator.Add(2.1, 3.1);

            //assert
            outputServise.Verify(x => x.Output(5.2), Times.Once());
        }

        [Test]
        public void Should_Output1Point1_WhenDoind3Point3Substract2Point2()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);

            //act
            calculator.Substract(3.3, 2.2);

            //assert
            outputServise.Verify(x => x.Output(1.1), Times.Once());
        }

        [Test]
        public void Should_Output1Point21_WhenDoind1Point1Multyply1Point1()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);

            //act
            calculator.Multiply(1.1, 1.1);

            //assert
            outputServise.Verify(x => x.Output(1.21), Times.Once());
        }

        [Test]
        public void Should_Output2Point2_WhenDoind6Point82Devide3Point1()
        {
            //arrange
            var outputServise = new Mock<IOutputServise>();
            var calculator = new CalculatorEngine(outputServise.Object);

            //act
            calculator.Devide(6.82, 3.1);

            //assert
            outputServise.Verify(x => x.Output(2.2), Times.Once());
        }
    }
}
