void FillArray(int[] collection)//метод void не возвращает значение - слово return не пишем
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; // кол-во эл-ов
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);//выводим значение текущего элемента
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //отрицательное значение на случай, если поиск не даст результатов

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //на случай генерации нескольких одинаковых элементов
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создай новый массив, в котором будет 10 элементов. 

FillArray(array);//метод заполняет массив элементами
array[3] = 4;//добавляем несколько одинаковых эл-в
array[6] = 4; //чтобы посмотреть, как метод поиска себя проявит

PrintArray(array);// метод распечатывает
Console.WriteLine(); //пустая строка, чтобы отграничить вывод массива

int pos = IndexOf(array, 4);// ищем эл-т равный 4, просто из любопытства
Console.WriteLine(pos);
