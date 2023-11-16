using System;
class Calculator{
    public int Add(int a, int b){
        return a + b;
    }
    public int Subtract(int a, int b){
        return a - b;
    }
    public int Multiply(int a, int b){
        return a * b;
    }
    public int Divide(int a, int b){
        if (b == 0){
            Console.Write("Не можна ділити на 0");
            return 0;
        }
        return a / b;
    }
    public double Power(int a, int b){
        return Math.Pow(a, b);
    }
    public int Modulus(int a, int b){
        return a % b;
    }
}
class UserInterface{
    public double GetOperand(string abc){
        Console.Write("Введіть {0} число: ", abc);
        return Convert.ToDouble(Console.ReadLine());
        // if (double.TryParse(s, out _)){
        //     x = Convert.ToDouble(s);
        // } else {
        //     Console.Clear();
        //     Console.WriteLine("Ви ввели не число!\n");
        //     GetOperand(abc);
        // }
        // return x;
        //Тут я пробував зробити перевірку чи то число але помилка: Use of unassigned local variable 'x'
    }
    public int GetChoice(){
        Console.Write("\nВведіть номер операції для взаємодії між числами: ");
        Console.Write("\n1. Додавання\n2. Віднімання\n3. Множення\n4. Ділення\n5. Підносити до степеня\n6. Остача\n");
        Console.Write("Ваш вибір: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice < 0 || choice > 6){
            Console.Clear();
            Console.Write("Неправильний вибір!\n");
            GetChoice();
        }
        return choice;
    }
    public void ShowRes(double f, double s, int c){
        Console.Clear();
        switch (c){
            case 1: 
                Console.Write($"{f} + {s} = {f + s}");
                break;
            case 2:
                Console.Write($"{f} - {s} = {f - s}");
                break;
            case 3:
                Console.Write($"{f} * {s} = {f * s}");
                break;
            case 4:
                Console.Write($"{f} / {s} = {f / s}");
                break;
            case 5:
                Console.Write($"{f} ^ {s} = {Math.Pow(f, s)}");
                break;
            case 6:
                Console.Write($"{f} % {s} = {f % s}");
                break;
        }
    }
}
class Program{
    static void Main(){
        Calculator calc = new Calculator();
        UserInterface us = new UserInterface();
        double a, b;
        int choice;
        a = us.GetOperand("перше");
        b = us.GetOperand("друге");
        choice = us.GetChoice();
        us.ShowRes(a, b, choice);
        
        Console.ReadKey();
    }
}