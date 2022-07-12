using IntroOOP;


//1. Реализовать класс для описания здания(уникальный номер здания, высота, этажность, количество квартир, подъездов).+
//Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.+
//Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
//Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
//Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания,
//и предусмотреть метод, который увеличивал бы значение этого поля.

var building1 = new Building();
building1.BuildingHeight = 40;
building1.FloorQty = 10;
building1.EntranceQty = 6;
building1.ApartmentQty = 38*6;

var bldg2 = new Building(56, 12, 4 * 12, 4);
var bldg3 = new Building(20, 5, 5*8, 8);
var bldg4 = new Building(110, 27, 2*27, 2);
var bldg5 = new Building(16, 4, 4 * 10, 10);
building1.FloorsHeight(out int b1_fheight);
building1.AppsPerFloor(out int b1_appperfloor);
Console.WriteLine(b1_fheight);
Console.WriteLine(b1_appperfloor);




Console.ReadLine();
