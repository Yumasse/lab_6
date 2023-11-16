using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Calculator<T>
    {
        //додавання
        public delegate T AdditionDelegate(T a, T b);

        // віднімання
        public delegate T SubtractionDelegate(T a, T b);

        // множення
        public delegate T MultiplicationDelegate(T a, T b);

        // ділення
        public delegate T DivisionDelegate(T a, T b);

       
        public AdditionDelegate Add { get; set; }
        public SubtractionDelegate Subtract { get; set; }
        public MultiplicationDelegate Multiply { get; set; }
        public DivisionDelegate Divide { get; set; }


        public Calculator()
        {

            Add = (a, b) => (dynamic)a + b;
            Subtract = (a, b) => (dynamic)a - b;
            Multiply = (a, b) => (dynamic)a * b;
            Divide = (a, b) => (dynamic)a / b;
        }


        public T PerformOperation(char operation, T a, T b)
        {
            switch (operation)
            {
                case '+':
                    return Add(a, b);
                case '-':
                    return Subtract(a, b);
                case '*':
                    return Multiply(a, b);
                case '/':
                    return Divide(a, b);
                default:
                    throw new ArgumentException("Непідтримувана операція");
            }
        }
    }
}
