// using System;
//
// namespace MyApp
// {
//     public delegate void ShowLog(string message);
//
//     class test
//     {
//         public delegate void ShowLog(string message);
//         public void InfoT(String s)
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine(s);
//             Console.ResetColor();
//         }
//         public void Info(String s)
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine(s);
//             Console.ResetColor();
//         }
//     }
//
//     static class Program
//     {
//         static void Info(String s)
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine(s);
//             Console.ResetColor();
//         }
//         
//         static void Infom(String s)
//         {
//             Console.ForegroundColor = ConsoleColor.Blue;
//             Console.WriteLine(s);
//             Console.ResetColor();
//         }
//         static double sum(int a, int b) => a + b + 1.2;
//
//         static void Main(string[] args)
//         {
//             // Action action; // tuong duong voi delegate void Action();
//             // Action<string, int> action1; // tuong duong voi delegate void Action(string, int);
//             // Action<string> action2 = Info; // tuong duong voi delegate void Action(string);
//             // action2.Invoke("hello");
//             // action2 += Info;
//             // action2.Invoke("Thong bao tu action");
//             
//             // Func<int, int, int> func = (a, b) => a + b;
//             // func phai co kieu tra ve
//             // Func<int> func = () => 1;
//             Func<int, int, double> func = sum;
//             Console.WriteLine(func.Invoke(4, 5));
//             
//         }
//     }
// }