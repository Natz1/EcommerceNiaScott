using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace EcommerceNiaScott.Classes
{
    //DropCreateDatabaseIfModelChanges<InventoryDBContext>
    public class InventoryRepository
    {
        //Generate list of all products
        public List<FurnitureInventory> GetStorage()
        {
            InventoryDBContext context = new InventoryDBContext();
            return context.Furnishings.ToList();
        }

        //Add to database
        public List<FurnitureInventory> AddFurnishing(FurnitureInventory inv)
        {
            InventoryDBContext context = new InventoryDBContext();
            context.Furnishings.Add(inv);
            context.SaveChanges();
            return context.Furnishings.ToList();
        }

        //Update database
        public List<FurnitureInventory> UpdateFurnishing(FurnitureInventory edit)
        {
            InventoryDBContext context = new InventoryDBContext();

            var editItem =
                from items in context.Furnishings
                where items.InventoryID == edit.InventoryID
                select items;

            //Updating product details
            foreach (var item in editItem)
            {
                item.FurnitureID = edit.FurnitureID;
                item.Name = edit.Name;
                item.Description = edit.Description;
                item.Category = edit.Category;
                item.Price = edit.Price;
            }

            context.SaveChanges();
            return context.Furnishings.ToList();
        }

        //Delete from database
        public List<FurnitureInventory> DeleteFurnishing(FurnitureInventory inv)
        {
            InventoryDBContext context = new InventoryDBContext();
            
            var deleteItem =
                from items in context.Furnishings
                where items.InventoryID == inv.InventoryID
                select items;

            foreach (var item in deleteItem)
            {
                context.Furnishings.Remove(item);
            }

            context.SaveChanges();
            return context.Furnishings.ToList();
        }
    }
}