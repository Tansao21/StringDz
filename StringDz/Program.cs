// Дано название футбольного клубаю. Определить количество символов в немю

string str = "Зенит";
Console.WriteLine(str.Length);

Console.WriteLine("-------------------------------");

// Дано слово. Вывести на экран его третий символ.
Console.WriteLine(str[2]);
Console.WriteLine("-------------------------------");

// Дано слово. Вывести на экран его последнее символ.
Console.WriteLine(str[4]);
Console.WriteLine("-------------------------------");

// Из слова яблоко путем "вырезок" и "склеек" его букв получить слово блок и око.
string fruits = "яблоко";

string fruitsOne = fruits.Substring(1, 4);
Console.WriteLine(fruitsOne);
Console.WriteLine("-------------------------------");
string fruitsTwoo = fruits.Substring(3); 
Console.WriteLine(fruitsTwoo);
Console.WriteLine("-------------------------------");

// Из слова курсор путем замены его букв получить слово танцор.
string word = "курсор";

word = word.Replace("курс", "танц");
Console.WriteLine(word);

Console.WriteLine("-------------------------------");

//Дано название футбольного клубаю.Напичатать его в столбик
for (int i = 0; i < str.Length; i++)
{
	Console.WriteLine(str[i]);
}
Console.WriteLine("-------------------------------");

//Составить программу, которая печатает заданное слово, начиная с последней буквы.
char[] chrArr = str.ToCharArray();
Array.Reverse(chrArr);
Console.WriteLine(chrArr);
Console.WriteLine("-------------------------------");

//Получить строку, состоящую из пяти звездочек(*)
string star = "*";

for (int i = 0; i < 5; i++)
{
	
	Console.Write(star);
}
Console.WriteLine();
Console.WriteLine("-------------------------------");

//дана строка - определить сколько в строке есть букв "о" ???

int count = 0;

for (int i = 0; i < fruits.Length; i++)
{
	if (fruits[i] == 'о')
	{
		count++;
	}
}
	Console.WriteLine(count);

