using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Web;
using System.Xml.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceNiaScott.Classes
{
    public class FurnitureCart
    {
        //default
        public FurnitureCart()
        {
        }

        //primary
        public FurnitureCart(string id, string name, string desc, string cat, string pri, int quan, double subtotal)
        {
            FurnitureID = id;
            Name = name;
            Desc = desc;
            Cat = cat;
            Price = pri;
            Quan = quan;
            Subtotal = subtotal;
        }

        //copy
        public FurnitureCart(FurnitureCart data)
        {
            FurnitureID = data.FurnitureID;
            Name = data.Name;
            Desc = data.Desc;
            Cat = data.Cat;
            Price = data.Price;
            Quan = data.Quan;
            Subtotal = data.Subtotal;
        }

        //Getters and setters
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartID { get; set; }
        public string FurnitureID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Cat { get; set; }
        public string Price { get; set; }
        public int Quan { get; set; }
        public double Subtotal { get; set; }

        public void CreateCookies(string ID, string Name, string Desc, string Cat, string Price)
        {
            HttpCookie productInfo = new HttpCookie("productInfo");
            productInfo["ID"] = ID;
            productInfo["Name"] = Name;
            productInfo["Desc"] = Desc;
            productInfo["Cat"] = Cat;
            productInfo["Price"] = Price;
            productInfo.Expires.AddDays(3);
            HttpContext.Current.Response.Cookies.Add(productInfo);
        }

        public void SubtotalCookies(string Quan, double Subtotal)
        {
            HttpCookie productInfo = new HttpCookie("productInfo");
            productInfo["Quan"] = Quan;
            productInfo["Subtotal"] = Subtotal.ToString();
            productInfo.Expires.AddDays(3);
            HttpContext.Current.Response.Cookies.Add(productInfo);
        }

        public void DeleteCookie()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["productInfo"];
            HttpContext.Current.Response.Cookies.Remove("productInfo");
            cookie.Expires = DateTime.Now.AddDays(-10);
            cookie.Value = null;
            HttpContext.Current.Response.SetCookie(cookie);
        }

        public override string ToString()
       {
            return string.Format("ID: {0}<br/>Name: {1}<br/>Description: {2}<br/>Category: {3}<br/>Quantity: {4}<br/>Subtotal: J${5}",
                    FurnitureID, Name, Desc, Cat, Quan, Subtotal);
       }
    }
}