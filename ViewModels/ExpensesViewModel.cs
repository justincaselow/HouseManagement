using HouseManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HouseManagement.ViewModels
{
    public class ExpensesViewModel
    {
        private static HouseModelContainer context = new HouseModelContainer();

        public int ItemTypeId { get; set; }
        public string Description { get; set; }
        public decimal GbpAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Quantity { get; set; }

        public IQueryable<ItemType> ItemTypes
        {
            get
            {
                return context.ItemTypes.AsNoTracking();
            }
        }

        public ItemType ItemType
        {
            get
            {
                return this.ItemTypes.AsNoTracking().SingleOrDefault(p => p.Id == this.ItemTypeId);
            }
        }

        public Person Payer
        {
            get
            {
                return context.People.AsNoTracking().Single(p => p.Name == "Justin Low");
            }
        }
    }
}