// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double showValue(double[] arg){
    System.Console.WriteLine(arg.Max()- arg.Min());
   // System.Console.WriteLine();
    return  arg.Max() - arg.Min();
}

double[] arr = new double[] {3.22, 4.2, 1.15, 77.15, 65.2};

showValue(arr);