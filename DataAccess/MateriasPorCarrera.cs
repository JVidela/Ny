//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class MateriasPorCarrera
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MateriasPorCarrera()
        {
            this.CorrelativaPorMateria = new HashSet<CorrelativaPorMateria>();
            this.CorrelativaPorMateria1 = new HashSet<CorrelativaPorMateria>();
        }
    
        public int IdMateriaPorCarrera { get; set; }
        public int IdMateria { get; set; }
        public int IdCarrera { get; set; }
    
        public virtual Materia Materia { get; set; }
        public virtual Carrera Carrera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CorrelativaPorMateria> CorrelativaPorMateria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CorrelativaPorMateria> CorrelativaPorMateria1 { get; set; }
    }
}
