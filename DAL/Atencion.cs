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
    
    public partial class Atencion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Atencion()
        {
            this.Recetas = new HashSet<Receta>();
        }
    
        public int Id_Atencion { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public int Consulta_Id { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
    
        public virtual Consulta Consulta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta> Recetas { get; set; }
    }
}