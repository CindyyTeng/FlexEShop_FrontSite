﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexWebAPI.Models
{
    public partial class ProductComment
    {
        public int Id { get; set; }
        public int fk_MemberId { get; set; }
        public int fk_ProductGroupId { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        public bool Status { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual Member fk_Member { get; set; }
        public virtual ProductGroup fk_ProductGroup { get; set; }
    }
}