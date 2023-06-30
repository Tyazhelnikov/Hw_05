// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int checkArr(int[] arg){
    int count = 0;
    for(int i = 0;i<arg.Length;i++){        
        if((arg[i] % 2) == 0 ){          
           count = count + 1;
        } 
    }   
    System.Console.WriteLine(count);
    return count;    
}

int[] arr = new int[] {345, 897, 568, 234};

//checkArr(arr);

int[] createRndArr(int lenght){
    Random rnd = new Random();
    int[] arr = new int[lenght];
    for(int i = 0; i< lenght;i++ ){
        arr[i] = rnd.Next(100,1000);
        System.Console.WriteLine(arr[i]);
    }

    return arr;

}

checkArr(createRndArr(8));