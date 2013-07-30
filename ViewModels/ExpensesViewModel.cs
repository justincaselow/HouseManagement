using HouseManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web;

namespace HouseManagement.ViewModels
{
    public class ExpensesViewModel
    {
        private HouseModelContainer context = new HouseModelContainer();

        public ObjectSet<ItemType> ItemTypes
        {
            get
            {
                return context.ItemTypes;
            }
        }

        public string Description { get; set; }
        public decimal GbpAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Quantity { get; set; }

        public Person Payee
        {
            get
            {
                return context.People.Single(p => p.Name == "Justin Low");
            }
        }
    }
}