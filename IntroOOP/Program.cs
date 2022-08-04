using IntroOOP;
using IntroOOP.Coder;

/*Определить интерфейс IСoder, который полагает методы поддержки шифрования
строк.В интерфейсе объявляются два метода Encode() и Decode(),
используемые для шифрования и дешифрования строк. Создать класс ACoder,
реализующий интерфейс ICoder.Класс шифрует строку посредством сдвига
каждого символа на одну «алфавитную» позицию выше. (В результате такого
сдвига буква А становится буквой Б). Создать класс BCoder, реализующий
интерфейс ICoder.Класс шифрует строку, выполняя замену каждой буквы,
стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в
алфавите на i-й позиции с конца алфавита. (Например, буква В заменяется на букву Э).
Написать программу, демонстрирующую функционирование классов).*/

Header.HwHeader("ООП", 7, "Алимов Филипп");

ACoder aCoder = new ();
BCoder bCoder = new ();

string input = "АБВГД ABCDE Зашифруй меня скорее!";
string output = aCoder.Encode(input);

Console.WriteLine($"Оригинальная строка: {input}\n");
Console.WriteLine($"Шифрование: {output}\n");
Console.WriteLine($"Дешифровка: {aCoder.Decode(output)}\n");

int key = 5;
output = bCoder.Encode(input, key);
Console.WriteLine(output);
Console.WriteLine(bCoder.Decode(output, key));

Console.ReadLine();