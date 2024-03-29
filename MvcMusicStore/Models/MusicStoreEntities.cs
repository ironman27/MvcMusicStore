﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }


        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public System.Data.Entity.DbSet<MvcMusicStore.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }

    
}