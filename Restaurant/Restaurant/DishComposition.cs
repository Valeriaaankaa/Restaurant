using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class DishComposition
    {
        /// <summary>
        /// Information about dish amount and  of which ingredients dish consist of
        /// </summary>
        public int CompositionId { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public decimal DishAmount { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CompositionId:{0}\n DishAmount:{1}\n", CompositionId, DishAmount);
            foreach (Ingredient i in Ingredients)
            {
                sb.AppendFormat(i.ToString(), i);
            }
            return sb.ToString();
        }

    }
}
