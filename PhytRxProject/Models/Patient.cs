//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhytRxProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.RXes = new HashSet<RX>();
        }

        public int PID { get; set; }
        public string UserID { get; set; }
        [Display(Name = "Patient Image")]
        public string PPic { get; set; }
        [Display(Name = "DPT Name")]
        public Nullable<int>
        PhID
        { get; set; }
        public Nullable<int>
        LogID
        { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Log Log { get; set; }
        public virtual Physician Physician { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RX> RXes { get; set; }
    }
}
