﻿using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace PizzaOrderApp.Models
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public ICollection<OrderEntity> Orders { get; set; } = [];


    }
}
