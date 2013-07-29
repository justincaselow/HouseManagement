using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web;

namespace HouseManagement.Models
{
    public class ExpensesViewModel : Expense
    {
        public ObjectSet<ItemType> ItemTypes { get; set; }

        public ExpensesViewModel()
        {
            var context = new HouseModelContainer();
            this.ItemTypes = context.ItemTypes;
        }
    }
}