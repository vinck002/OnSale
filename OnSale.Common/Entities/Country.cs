using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnSale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe contener menos de {1} caractereres.")]
        [Required]
         public String Name { get; set; }

        [DisplayName("Provincias")]
        public ICollection<Department> Departments { get; set; }

        [DisplayName("Cantidad de provincias")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;

        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }


    }
}
