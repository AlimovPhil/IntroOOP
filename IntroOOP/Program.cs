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



Console.ReadLine();
