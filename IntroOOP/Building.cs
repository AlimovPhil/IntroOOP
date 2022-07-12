namespace IntroOOP;

public class Building
{
    #region Fields
    private int _BuildingNumber;      // Номер здания
    private int _BuildingHeight;   // Высота здания
    private int _FloorQty;            // Количество этажей
    private int _ApartmentQty;        // Количество квартир
    private int _EntranceQty;         // Количество подъездов
    #endregion
    private static int lastBuildingNumber = 0; // Переменная для генерации номера здания

    public int BuildingNumber
    {
        get => _BuildingNumber;
        private set => _BuildingNumber = value;
    }
    public int BuildingHeight
    {
        get => _BuildingHeight;
        set => _BuildingHeight = value;
    }
    public int FloorQty
    {
        get => _FloorQty;
        set => _FloorQty = value;
    }
    public int EntranceQty
    {
        get => _EntranceQty;
        set => _EntranceQty = value;
    }
    public int ApartmentQty
    {
        get => _ApartmentQty;
        set => _ApartmentQty = value;
    }
    private int SetBuildingNumber()
    {
        lastBuildingNumber++;
        _BuildingNumber = lastBuildingNumber;
        return lastBuildingNumber;
    }

    public Building() => _BuildingNumber = SetBuildingNumber(); // Конструктор по-умолчанию

    public Building(int bldg_height, int floorsQty, int aptsQty, int entranceQty)
    {
        BuildingNumber = SetBuildingNumber();
        BuildingHeight = bldg_height;
        FloorQty = floorsQty;
        ApartmentQty = aptsQty;
        EntranceQty = entranceQty;
    }

    public void FloorsHeight(out int floor_height)
    {
        floor_height = BuildingHeight / FloorQty;
    }

    public void AppsPerEntrance(out int apps_per_entrns )
    {
        apps_per_entrns = ApartmentQty / EntranceQty;
    }
    public void AppsPerFloor(out int apps_per_floor )
    {
        apps_per_floor = (ApartmentQty / EntranceQty) / FloorQty;
    }
}