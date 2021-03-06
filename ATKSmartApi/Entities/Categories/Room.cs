﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATKSmartApi.Entities.Categories
{
    public class Room : BaseEntity
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string RoomName { get; set; }

        [Required]
        public int RoomType { get; set; }

        [Required]
        public decimal RoomPrice { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string Description { get; set; }

        public Nullable<int> Status { get; set; }
    }
}
