using System;

namespace ProGitForProgrammers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This line was added in VSCode!");
        }
    }

    public class Calculator {
        public int Add(int left, int right) {
            return left + right;
        }
        public int Substract(int left, int right) {
            return left - right;
        }
        public int Multiply(int left, int right) {
            return left * right;
        }
        public int Divide(int left, int right) {
            return left / right;
        }
    }
}