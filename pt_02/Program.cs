// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] createRndArr(int lenght){
    Random rnd = new Random();
    int[] arr = new int[lenght];
    for(int i = 0; i< lenght;i++ ){
        arr[i] = rnd.Next(100,1000);
        System.Console.WriteLine(arr[i]);
    }

    return arr;

}

int checkSum(int[] arg){
    int sum = 0;
    for(int i = 0;i < arg.Length;i++){
        if((i % 2) > 0){
            sum = sum + arg[i];
        }
    }
    System.Console.WriteLine(sum);
    return sum;
}

checkSum(createRndArr(5));
