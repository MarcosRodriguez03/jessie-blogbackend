using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


public class DataContext : DbContext
{
    public DbSet<userModel> UserInfo { get; set; }
    public DbSet<blogItemModel> BlogInfo { get; set; }
    public DataContext(DbContextOptions options) : base(options) { }

    //this function will build out our table in database
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

}
