using System.Collections.Generic;
using System.Linq;
using System;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name  { get; set; }   
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

    }
}
