using IntroOOP;


var bldg1 = new Building();

bldg1.BuildingHeight = 45;
bldg1.FloorQty = 10;
bldg1.EntranceQty = 6;
bldg1.ApartmentQty = 240;

double fl_height = bldg1.FloorsHeight();
int b1_apps_entr = bldg1.AppsPerEntrance();
int b1_apps_floor = bldg1.AppsPerFloor();

var bldg2 = new Building(1, 12,48, 4);



=======
﻿using System.Text;
using IntroOOP;
using IntroOOP.BankAccount;
using IntroOOP.FunWithStrings;

Header.HwHeader("ООП", 3, "Алимов Филипп");

string path = @"D:\Phil_docs\GB\HomeWork\IntroOOP\IntroOOP\DataFile.txt"; 
string emailsfile = @"D:\Phil_docs\GB\HomeWork\IntroOOP\IntroOOP\Mails.txt";

using (StreamReader reader = new(path))
using (StreamWriter writer = new(emailsfile))
{
    //string? line;
    //while ((line = reader.ReadLine()) != null)
    while (reader.ReadLine() is { } line)
    {
        DataExtraction.SearchMail(ref line);
        writer.WriteLine(line);
    }
}

Console.WriteLine("Программа выполнена.");