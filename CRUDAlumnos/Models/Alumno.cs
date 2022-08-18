using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUDAlumnos.Models
{
    public partial class Alumno
    {
        public int Id_Alumno { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Sexo { get; set; }
        [Display(Name = "Grado de estudios")]
        public int? Id_GradoEstudios { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
    }
}
