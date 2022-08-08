//Программа получает в консоль слово для поиска и выдает индекс искомого изначения если находит его в массиве

string[] array = {"Ivan", "Andrey", "Michail", "Natalia", "Maria", "Sergey", "Dmitry"};

Console.Write("Введите имя: ");
string find = Console.ReadLine();

int n = array.Length;
int index = 0;

while (index < n) {
    if (array[index] == find) {
        Console.WriteLine($"Индекс имени {find} в массиве {index}");
        break;
    }
    index++;
}
