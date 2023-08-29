Vehicle Tucson = new("Tucson", 5, "Silver", true);

Vehicle Tesla = new("Model S", "White");

Vehicle Jeep = new("Raptor", 5, "Black", true);

Vehicle Ducati = new("Monster", 1, "Red", true);

List<Vehicle> AllVehicles = new List<Vehicle>(){Tucson,Tesla,Jeep,Ducati};

static List<Vehicle> VehicleInfo(List<Vehicle> VehicleList)
{
   foreach (Vehicle i in VehicleList)
   {
     i.ShowInfo();
   }

    return VehicleList;
}

VehicleInfo(AllVehicles);

Ducati.Travel(100);
Ducati.ShowInfo();