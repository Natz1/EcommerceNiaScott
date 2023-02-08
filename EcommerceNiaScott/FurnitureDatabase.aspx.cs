using EcommerceNiaScott.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EcommerceNiaScott
{
    public partial class FurnitureDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //Adding item to inventory
        protected void Add_Click(object sender, EventArgs e)
        {
            InventoryRepository addition = new InventoryRepository();

            //Conversion
            double.TryParse(price.Text, out double cost);
            int.TryParse(id.Text, out int identity);

            //Store values
            var furnishing = new FurnitureInventory
            {
                FurnitureID = identity, Name = name.Text, Description = desc.Text, Category = cat.Text, Price = cost
            };
            //Pass values to be added
            addition.AddFurnishing(furnishing);
        }

        //Updating item in inventory
        protected void Edit_Click(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditRowStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            InventoryRepository update = new InventoryRepository();

            //Get the inventory id for updating
            int.TryParse(GridView1.Rows[e.NewEditIndex].Cells[0].Text, out int invID);

            //Getting user input
            var editItem = new FurnitureInventory();
            editItem.InventoryID = invID;
            int.TryParse(GridView1.Rows[e.NewEditIndex].Cells[1].Text, out int furID);
            editItem.FurnitureID = furID;
            editItem.Name = GridView1.Rows[e.NewEditIndex].Cells[2].Text;
            editItem.Description = GridView1.Rows[e.NewEditIndex].Cells[3].Text;
            editItem.Category = GridView1.Rows[e.NewEditIndex].Cells[4].Text;
            double.TryParse(GridView1.Rows[e.NewEditIndex].Cells[5].Text, out double cost);
            editItem.Price = cost;

            //Pass values
            update.UpdateFurnishing(editItem);

        }

        //Deleting item from inventory
        protected void Delete_Click(object sender, GridViewDeleteEventArgs e)
        {
            
            InventoryRepository deletion = new InventoryRepository();

            //Get the inventory id for deletion
            int.TryParse(GridView1.Rows[e.RowIndex].Cells[0].Text, out int invID);

            //Store the id and name in a variable
            var deleteItem = new FurnitureInventory();
            deleteItem.InventoryID = invID;
            deleteItem.Name = GridView1.Rows[e.RowIndex].Cells[2].Text;

            //Pass values
            deletion.DeleteFurnishing(deleteItem);
            
        }

        
    }
}