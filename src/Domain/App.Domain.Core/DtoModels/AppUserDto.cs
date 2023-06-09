﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class AppUserDto
    {
        public string Id { get; set; } = null!;

        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTimeOffset CreatAt { get; set; }

        public bool IsDeleted { get; set; }

        public int? BuyerMedalId { get; set; }

        public string? CountOfBuy { get; set; }

        public int? UserProfileImageId { get; set; }

        public bool IsSeller { get; set; }

        public bool IsCreated { get; set; }

        public int Wallet { get; set; }

        public virtual ICollection<BoothDto> Booths { get; set; } = new List<BoothDto>();

        public virtual BuyerMedalDto? BuyerMedal { get; set; }

        public virtual ICollection<CommentDto> Comments { get; set; } = new List<CommentDto>();

        public virtual ICollection<MessagesUserDto> MessagesUsers { get; set; } = new List<MessagesUserDto>();

        public virtual ICollection<OrderDto> Orders { get; set; } = new List<OrderDto>();

        public virtual ICollection<SellerInformationDto> SellerInformations { get; set; } = new List<SellerInformationDto>();

        public virtual ImageDto? UserProfileImage { get; set; }
    }
}
