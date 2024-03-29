﻿using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public int ShoppingCartViewModelId { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}