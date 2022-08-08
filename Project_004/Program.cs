//Написали программу которая генерирует данные в массив, выводит массив в консоль и выполняет поиск по этому массиву

void FillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int[] col){
    int count = col.Length;
    int position = 0;
    while (position < count) {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf (int[] collection, int find) {
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count) {
        if (collection[index] == find) {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int position = IndexOf(array, 4);
Console.WriteLine(position);