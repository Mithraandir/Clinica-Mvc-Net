//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class EspecialidadXProfesional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EspecialidadXProfesional()
        {
            this.Agenda = new HashSet<Agendum>();
            this.Turnoes = new HashSet<Turno>();
        }
    
        public int Usuario_Id { get; set; }
        public decimal Especialidad_Id { get; set; }
        public bool Eliminado { get; set; }
        public string Motivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agendum> Agenda { get; set; }
        public virtual Especialidad Especialidad { get; set; }
        public virtual Profesional Profesional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turnoes { get; set; }
    }
}