using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EcommerceNiaScott.Classes
{
    public class InventoryInitializer : DropCreateDatabaseIfModelChanges<InventoryDBContext>
    {
        //Sample values
        protected override void Seed(InventoryDBContext context)
        {
            List<FurnitureInventory> inv = new List<FurnitureInventory>
            {
                new FurnitureInventory{FurnitureID=8796, Name="Sunset Bed Frame",
                Description="Queen sized bed frame", Category="Bedding", Price=80000.00},

                new FurnitureInventory{FurnitureID=9983, Name="Moon Dining Table",
                Description="Seven piece dining set", Category="Dining", Price=75000.00},

                new FurnitureInventory{FurnitureID=3943, Name="Ocean Living Room Suite",
                Description="Three piece living room suite", Category="Living Room", Price=85000.00},

                new FurnitureInventory{FurnitureID=1235, Name="Riptide Fridge",
                Description="26 cu. ft. black refridgerator", Category="Kitchen Appliances", Price=200000.00},

                new FurnitureInventory{FurnitureID=5486, Name="Maple Floor Lamp",
                Description="Black floor lamp with LED lighting", Category="Lighting", Price=12000.00},

                new FurnitureInventory{FurnitureID=9990, Name="Midnight Standing Fan",
                Description="Tall, quiet, black pedastal fan with oscillation", Category="Cooling Devices", Price=10000.00}
            };

            //Add to grid view
            foreach (FurnitureInventory invItem in inv)
            {
                context.Furnishings.Add(invItem);
            }
            context.SaveChanges();
        }
    }
}