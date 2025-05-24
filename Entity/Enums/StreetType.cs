using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Enums
{
    /// <summary>
    /// Representa los tipos de calle para direcciones.
    /// </summary>
    public enum StreetType
    {
        [Display(Name = "Calle (Cl)")]
        Calle = 1,

        [Display(Name = "Carrera (Cr)")]
        Carrera = 2,

        [Display(Name = "Avenida (Av)")]
        Avenida = 3,

        [Display(Name = "Transversal (Tv)")]
        Transversal = 4,

        [Display(Name = "Diagonal (Dg)")]
        Diagonal = 5,

        [Display(Name = "Circular (Cir)")]
        Circular = 6,

        [Display(Name = "Autopista (Aut)")]
        Autopista = 7,

        [Display(Name = "Vía (Vía)")]
        Via = 8,

        [Display(Name = "Pasaje (Psj)")]
        Pasaje = 9,

        [Display(Name = "Callejón (Cjn)")]
        Callejon = 10,

        [Display(Name = "Bulevar (Blvr)")]
        Bulevar = 11,

        [Display(Name = "Paseo (Pso)")]
        Paseo = 12,

        [Display(Name = "Carretera (Crr)")]
        Carretera = 13,

        [Display(Name = "Camino (Cno)")]
        Camino = 14,

        [Display(Name = "Glorieta (Glo)")]
        Glorieta = 15,

        [Display(Name = "Otro")]
        Otro = 99
    }
}
