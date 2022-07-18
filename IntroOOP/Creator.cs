namespace IntroOOP;


//2. * Для реализованного класса создать новый класс Creator, который будет являться фабрикой объектов класса здания.
//Для этого изменить модификатор доступа к конструкторам класса, в новый созданный класс добавить перегруженные фабричные методы CreateBuild для создания объектов класса здания.
//В классе Creator все методы сделать статическими, конструктор класса сделать закрытым.
//Для хранения объектов класса здания в классе Creator использовать хеш-таблицу.
//Предусмотреть возможность удаления объекта здания по его уникальному номеру из хеш-таблицы.
//Создать тестовый пример, работающий с созданными классами.
public class Creator
{
    // Имя строителя
    public string Name {get; set;}

    // Создать новый экземпляр строителя.
    public Creator(string name)
    {
        // Проверяем входные данные на корректность.
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        Name = name;
    }

    // Построить новый дом
    public Building CreateBuild(double height, int floors, int apps, int entrances)
    {
        Building building = new ();
        building.BuildingHeight = height;
        building.FloorQty = floors;
        building.ApartmentQty = apps;
        building.EntranceQty = entrances;
        return building;
    }

    // Приведение объекта к строке.
    public override string ToString()
    {
        return Name;
    }
}

