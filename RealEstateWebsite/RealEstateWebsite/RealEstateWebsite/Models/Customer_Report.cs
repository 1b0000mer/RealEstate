
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
    
public partial class Customer_Report
{

    public int Customer_Report_ID { get; set; }

    public string Reason { get; set; }

    public Nullable<System.DateTime> ReportDate { get; set; }

    public Nullable<int> Status { get; set; }



    public virtual Customer Customer { get; set; }

    public virtual Customer Customer1 { get; set; }

    public virtual Employee Employee { get; set; }

}

}
