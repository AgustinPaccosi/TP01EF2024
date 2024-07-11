using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01EF2024.Entidades.Dtos
{
    public class ShoeDto
    {
        public int ShoeId { get; set; }
        public string Brand { get; set; } = null!;
        public string Sport { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string Colour { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
