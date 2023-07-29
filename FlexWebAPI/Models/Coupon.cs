﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexWebAPI.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            CouponSendings = new HashSet<CouponSending>();
        }

        public int CouponId { get; set; }
        public int fk_CouponCategoryId { get; set; }
        public string CouponName { get; set; }
        public string CouponDescription { get; set; }
        public string CouponCode { get; set; }
        public int MinimumPurchaseAmount { get; set; }
        public int DiscountType { get; set; }
        public int DiscountValue { get; set; }
        public DateTime StartDate { get; set; }
        public bool? EndType { get; set; }
        public int? EndDays { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PersonMaxUsage { get; set; }
        public int? RequirementType { get; set; }
        public int? Requirement { get; set; }
        public int? fk_RequiredProjectTagID { get; set; }
        public bool? Status { get; set; }

        public virtual CouponCategory fk_CouponCategory { get; set; }
        public virtual ProjectTag fk_RequiredProjectTag { get; set; }
        public virtual ICollection<CouponSending> CouponSendings { get; set; }
    }
}