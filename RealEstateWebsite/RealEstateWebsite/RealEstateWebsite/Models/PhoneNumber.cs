
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
    
public partial class PhoneNumber
{

    public int Customer_ID { get; set; }

    public string PhoneNumber1 { get; set; }

    public Nullable<System.DateTime> ModifiedDate { get; set; }



    public virtual Customer Customer { get; set; }

}

}
