﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexWebAPI.Models
{
    public partial class ShoesPicture
    {
        public int ShoesPicture_Id { get; set; }
        public string ShoesPictureUrl { get; set; }
        public int fk_ShoesPictureProduct_Id { get; set; }

        public virtual CustomizedShoesPo fk_ShoesPictureProduct { get; set; }
    }
}