﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexWebAPI.Models
{
    public partial class Privilege
    {
        public Privilege()
        {
            fk_Levels = new HashSet<MembershipLevel>();
        }

        public int PrivilegeId { get; set; }
        public string PrivilegeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MembershipLevel> fk_Levels { get; set; }
    }
}