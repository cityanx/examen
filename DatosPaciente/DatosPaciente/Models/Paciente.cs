using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatosPaciente.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteID { get; set; }

        [Required]
        [Display(Name = "Nombres y Apellidos del Paciente")]
        public string PacienteName { get; set; }

        [Required]
        [Display(Name = "Segundo Nombre")]
        public string SecondName { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string ApellidoPaciente { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string CorreoPaciente { get; set; }

        
        [Display(Name = "Nombre del Acompañante")]
        public string AcompaName { get; set; }


        [Display(Name = "Apellido del Acompañante")]
        public string AcompaApellido { get; set; }

        [Required]
        [Display(Name = "Dirección")]
        public string DireccionPrimera { get; set; }

        [Required]
        public string DireccionSegunda { get; set; }

        [Required]
        [Display(Name = "Ciudad")]
        public string CiudadPaciente { get; set; }

        [Required]
        [Display(Name = "Estado / Provincia")]
        public string EstadoPaciente { get; set; }

        [Required]
        [Display(Name = "Código Postal")]
        public string PostalPaciente { get; set; }

        [Required]
        [Display(Name = "Telefono del Paciente")]
        public string AreaTelefono { get; set; }

        [Required]
        public string NumeroTelefono { get; set; }

        [Display(Name = "WhatsApp del Paciente")]

        public string AreaWhats { get; set; }

        public string NumeroWhats { get; set; }



    }
}
