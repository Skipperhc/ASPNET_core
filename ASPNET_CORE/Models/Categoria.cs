using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_CORE.Models {
    public class Categoria {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString() {
            return $"ID: {this.Id}  Nome: {this.Nome}";
        }
    }
}
