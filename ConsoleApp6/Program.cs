int a = 0;
char[] mas = new char[10];
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine($"Введите элемент массива с индексом {i}: ");
    mas[i] = char.Parse(Console.ReadLine());
}

for (int i = 0; i < mas.Length; i++)
{
    for (int j = 1; j < mas.Length; j++)
    {
        if (mas[i] == mas[j] && i != j)
        {
            Console.WriteLine($"Одинаковые элементы с индексами {i} и {j}: {mas[i]} == {mas[j]}.");
            a = 1;
        }

    }

}
if (a == 0) Console.WriteLine("В массиве нет одинаковых элементов.");



//////using System.Text;
//////Console.Write("Введите текст: ");
//////StringBuilder text = new StringBuilder(Console.ReadLine());
//////Console.WriteLine($"Исходный текст: {text}");
//////for (int i = 0; i < text.Length; i++)
//////{

    
//////    text[i] = (char)((int)text[i] - 1);

//////}
//////Console.WriteLine($"Преобразованный текст: {text}.");
