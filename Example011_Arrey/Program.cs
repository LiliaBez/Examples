void FillArray(int[] collection) //FillArray - наименование метода, collection - имя нового массива
{
    int length = collection.Length; // определяем длину массива
    int index = 0; // индекс текущего элемента массива
    while (index < length)  //пока текущий индекс меньше длины массива
    {
        collection[index] = new Random().Next(1, 10); //в массив collection на позицию index положить новое целое число от 1 до 10
        index++; //index = index+1
    }
}  // создали массив со случайно выбранными числами

void PrintArray(int[] col) //void - метод не возвращает результат
{
    int count = col.Length; // длина массива
    int position = 0; // индекс текущего элемента
    while (position < count) // пока индекс меньше длины
    {
        Console.WriteLine(col[position]); // выводим значение текущего элемента
        position++; // следующий элемент
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index =0;
    int position = -1; // чтобы, если не окажется нужного элемента в массиве, то выйдет индекс -1
    while (index< count)
    {
        if(collection[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] arrey = new int[10]; //создать новый массив с 10 элементами

FillArray(arrey);
arrey[4] = 4;
arrey[6] = 4;
PrintArray(arrey);
Console.WriteLine();

int pos = IndexOf(arrey, 444);
Console.WriteLine(pos);
