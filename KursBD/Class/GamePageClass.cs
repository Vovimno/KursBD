using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursBD.Class
{
    internal class GamePageClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string YearOfRelease { get; set; }
        public decimal Price { get; set; }
        public int IdDevelopers { get; set; }
        public int IdPublishers { get; set; }
    }
}
