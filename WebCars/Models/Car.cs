using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCars.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Cor { get; set; }
        public string Categoria { get; set; }
    }
}
