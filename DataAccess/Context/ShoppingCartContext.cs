using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context
{

    //Requirement: ensure that we have the right connection string set up in place.

    //add-migration <name> ShoppingCartContext
    //update-database

    public class ShoppingCartContext : IdentityDbContext
    {
        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set;}  //An abstraction of the tables therefore plural name
        public DbSet<Category> Categories { get; set; }
    }
}
