namespace IntroOOP.BuildingClass;

public class Building
{
    #region Fields
    private int _BuildingNumber;      // Номер здания
    private double _BuildingHeight;      // Высота здания
    private int _FloorQty;            // Количество этажей
    private int _ApartmentQty;        // Количество квартир
    private int _EntranceQty;         // Количество подъездов
    private static int lastBuildingNumber; // Переменная для генерации номера здания
    #endregion


    public int BuildingNumber
    {
        get => _BuildingNumber;
        private set => _BuildingNumber = value;
    }
    public double BuildingHeight
    {
        get => _BuildingHeight;
        set
        {
            if (value <= 0)
                throw new InvalidDataException("Высота здания не может быть меньше либо равна 0!");
            _BuildingHeight = value;
        }
    }
    public int FloorQty
    {
        get => _FloorQty;
        set
        {
            if (value < 1)
                throw new InvalidDataException("Кол-во этажей в здании не может быть меньше 1!");
            _FloorQty = value;
        }
    }
    public int EntranceQty
    {
        get => _EntranceQty;
        set
        {
            if (value < 1)
                throw new InvalidDataException("Количество подъездов не может быть меньше 1!");
            _EntranceQty = value;
        }
    }
    public int ApartmentQty
    {
        get => _ApartmentQty;
        set
        {
            if (value < 1)
                throw new InvalidDataException("Количество квартир не может быть меньше 1!");
            _ApartmentQty = value;
        }
    }
    private int SetBuildingNumber()
    {
        lastBuildingNumber++;
        _BuildingNumber = lastBuildingNumber;
        return lastBuildingNumber;
    }

    public Building() => _BuildingNumber = SetBuildingNumber(); // Конструктор по-умолчанию

    public Building(double bldg_height, int floorsQty, int aptsQty, int entranceQty)
    {
        BuildingNumber = SetBuildingNumber();
        BuildingHeight = bldg_height;
        FloorQty = floorsQty;
        ApartmentQty = aptsQty;
        EntranceQty = entranceQty;
    }

    public double FloorsHeight()
    {
        double fl_height = BuildingHeight / FloorQty;
        return fl_height;
    }

    public int AppsPerEntrance()
    {
        int value = ApartmentQty / EntranceQty;
        return value;
    }
    public int AppsPerFloor()
    {
        int value = AppsPerEntrance() / FloorQty;
        return value;
    }
}