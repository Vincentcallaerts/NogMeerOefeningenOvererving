using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogMeerOefeningenOvererving
{
    class TextBook : Book
    {
        public int GradeLevel { get; set; }
        public override double Price
        {
            get => base.Price;

            set
            {
                if (Price >= 20 && Price <= 80)
                {
                    Price = value;
                }

            }
        }
    }
}
