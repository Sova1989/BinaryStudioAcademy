using System;

namespace BinaryStudio.Calculator
{
    public class CalculatorEngine
    {
        private IOutputServise outputServise;
        public CalculatorEngine(IOutputServise outpurServise)
        {
            throw new NotImplementedException();
        }
        public string correctResult { get; set; }
        public void Add(double leftOperand, double rightOperand)
        {
            correctResult = (leftOperand + rightOperand).ToString("0.0000");
            outputServise.Output(correctResult);
        }
        public void Substract(double leftOperand, double rightOperand)
        {
            correctResult = (leftOperand - rightOperand).ToString("0.0000");
            outputServise.Output(correctResult);
        }
        public void Multiply(double leftOperand, double rightOperand)
        {
            correctResult = (leftOperand * rightOperand).ToString("0.0000");
            outputServise.Output(correctResult);
        }
        public void Devide(double leftOperand, double rightOperand)
        {
            if (rightOperand == 0)
                correctResult="Devid on 0!";
            else
                correctResult = (leftOperand / rightOperand).ToString("0.0000");
            outputServise.Output(correctResult);
        }
    }
}
