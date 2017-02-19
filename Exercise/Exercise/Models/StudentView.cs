using Exercise.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise.Models
{
    public class StudentView
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "El campo es {0} requerido")]
        [Display(Name ="Nombre")]
        [StringLength(50, 
            ErrorMessage = "El campo requeire como maximo {1} caracteres y como minimo {2} caracteres", 
            MinimumLength =3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "El campo es {0} requerido")]
        [Display(Name = "Apellidos")]
        [StringLength(50,
            ErrorMessage = "El campo requeire como maximo {1} caracteres y como minimo {2} caracteres",
            MinimumLength = 3)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "El campo es {0} requerido")]
        [Display(Name = "Fecha de inscripcion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public System.DateTime EnrollmentDate { get; set; }
    }
}