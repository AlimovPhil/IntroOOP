namespace IntroOOP;

public static class Header
{
    /// <summary>
    /// Шапка для домашней работы.
    /// </summary>
    /// <param name="lesson"> Номер урока</param>
    /// <param name="name"> ФИО студента</param>
    public static void HwHeader(string course, int lesson, string name)
    {
        Console.WriteLine($"Домашняя работа.\nКурс {course}, урок {lesson}.\nВыполнил студент: {name}.");
        Console.WriteLine("******************************************\n");
    }
}