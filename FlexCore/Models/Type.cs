﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class Type
    {
        public Type()
        {
            CartItems = new HashSet<CartItem>();
            PointHistories = new HashSet<PointHistory>();
            PointManages = new HashSet<PointManage>();
            orderItems = new HashSet<orderItem>();
            orders = new HashSet<order>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<PointHistory> PointHistories { get; set; }
        public virtual ICollection<PointManage> PointManages { get; set; }
        public virtual ICollection<orderItem> orderItems { get; set; }
        public virtual ICollection<order> orders { get; set; }
    }
}