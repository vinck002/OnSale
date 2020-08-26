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

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener menos de {1} caractereres.")]
        [Required]
        public String Name { get; set; }
        public ICollection<Department> Departments { get; set; }

        [DisplayName("Numero de departamentos")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;

        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }


    }
}
