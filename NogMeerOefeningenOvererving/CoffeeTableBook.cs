using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogMeerOefeningenOvererving
{
    class CoffeeTableBook : Book
    {
        public override double Price 
        { 
            get => base.Price;
            
            set {
                if (Price >= 35 && Price <= 100)
                {
                    Price = value;
                }
                
                }
        }
    }
}
