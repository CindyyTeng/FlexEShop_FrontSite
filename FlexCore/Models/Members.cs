﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class Members
    {
        public Members()
        {
            CouponSendings = new HashSet<CouponSendings>();
            CustomizedOrders = new HashSet<CustomizedOrders>();
            OneToOneReservations = new HashSet<OneToOneReservations>();
            PointHistories = new HashSet<PointHistories>();
            PointTradeIn = new HashSet<PointTradeIn>();
            ShoppingCarts = new HashSet<ShoppingCarts>();
            orders = new HashSet<orders>();
        }

        public int MemberId { get; set; }
        public string Name { get; set; }
        public byte? Age { get; set; }
        public bool? Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string CommonAddress { get; set; }
        public string Account { get; set; }
        public string EncryptedPassword { get; set; }
        public DateTime? Registration { get; set; }
        public bool? IsConfirmed { get; set; }
        public string ConfirmCode { get; set; }
        public int fk_LevelId { get; set; }
        public int? fk_BlackListId { get; set; }

        public virtual BlackLists fk_BlackList { get; set; }
        public virtual MembershipLevels fk_Level { get; set; }
        public virtual AlternateAddresses AlternateAddresses { get; set; }
        public virtual MemberPoints MemberPoints { get; set; }
        public virtual ICollection<CouponSendings> CouponSendings { get; set; }
        public virtual ICollection<CustomizedOrders> CustomizedOrders { get; set; }
        public virtual ICollection<OneToOneReservations> OneToOneReservations { get; set; }
        public virtual ICollection<PointHistories> PointHistories { get; set; }
        public virtual ICollection<PointTradeIn> PointTradeIn { get; set; }
        public virtual ICollection<ShoppingCarts> ShoppingCarts { get; set; }
        public virtual ICollection<orders> orders { get; set; }
    }
}