
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
    
public partial class Post_Status
{

    public int Post_Status_ID { get; set; }

    public Nullable<System.DateTime> CensorshipTime { get; set; }

    public string Reason { get; set; }



    public virtual Employee Employee { get; set; }

    public virtual Post Post { get; set; }

    public virtual Status Status { get; set; }

}

}
