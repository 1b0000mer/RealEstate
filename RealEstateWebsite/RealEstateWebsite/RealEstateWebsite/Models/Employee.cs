//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstateWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Blocks = new HashSet<Block>();
            this.Customer_Report = new HashSet<Customer_Report>();
            this.Block1 = new HashSet<Block1>();
            this.Employee1 = new HashSet<Employee>();
            this.Posts = new HashSet<Post>();
            this.Post_Report = new HashSet<Post_Report>();
            this.Post_Status = new HashSet<Post_Status>();
            this.Quits = new HashSet<Quit>();
        }

        [Required]
        public int Employee_ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FullName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 9)]
        public string IDNumber { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Address { get; set; }
        public string Avatar_URL { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Block> Blocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Report> Customer_Report { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Block1> Block1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee1 { get; set; }
        public virtual Employee Employee2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post_Report> Post_Report { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post_Status> Post_Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quit> Quits { get; set; }
    }
}
