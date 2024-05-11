using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Curso_Net_2.Models
{
    public class VendaDeserialize
    {
        public int Id { get; set; }

        //como vendasDeseialize.json tiene nombre de variable Product_Name diferente a ProductName de la declaracion de este archivo
        // con el paquete Newtonsoft.Json; podemos hacer la siguiente declaracion para la variable ProductName reciba de la variable Product_Name
        [JsonProperty("Product_Name")]
        
        public string ProductName { get; set; }
        public decimal Preco { get; set; }
        public DateTime dataDeVenda { get; set; }

    }
}