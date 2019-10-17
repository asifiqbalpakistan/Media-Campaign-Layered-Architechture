using OMG_Annalect_DAL_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;
using OMG_Annalect_DAL_Core.Repositories;
using OMG_Annalect_DAL_Core.Interface;
using OMG_Annalect_DomainModels;

namespace OMG_Annalect_DAL_Core.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        

        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CampaignChannel> CampaignChannels { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<AdvertisementSupplier> AdvertisementSuppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CampaignChannel>()
            .HasKey(x => new { x.CampaignId, x.ChannelId, x.Id });

            //If you name your foreign keys correctly, then you don't need this.
            builder.Entity<CampaignChannel>()
                .HasOne(pt => pt.Campaign)
                .WithMany(p => p.CampaignChannels)
                .HasForeignKey(pt => pt.CampaignId);

            builder.Entity<CampaignChannel>()
                .HasOne(pt => pt.Channel)
                .WithMany(t => t.CampaignChannels)
                .HasForeignKey(pt => pt.ChannelId);

            builder.Entity<Campaign>()
                .HasOne(pt => pt.Client)
                .WithMany(t => t.Campaigns)
                .HasForeignKey(pt => pt.ClientId);


            builder.Entity<Country>().HasData(
             new Country { Id = 1, Name = "United Arab Emirates", Code = "UAE", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now },
             new Country { Id = 2, Name = "Pakistan", Code = "PK", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now }
         );
            builder.Entity<DocumentType>().HasData(
            new DocumentType { Id = 1, DocumentTypeName = "Ads Broucher", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now ,IsRequired=false,AddedBy="Admin"},
            new DocumentType { Id = 2, DocumentTypeName = "Wish List", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now, IsRequired = false, AddedBy = "Admin" }
        );
            builder.Entity<Channel>().HasData(
             new Channel { Id = 1, Name = "Social", Code = "Social", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now },
             new Channel { Id = 2, Name = "Offline", Code = "Offline", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now },
             new Channel { Id = 3, Name = "OOH", Code = "OOH", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now },
             new Channel { Id = 4, Name = "Direct Buys", Code = "Direct Buys", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now }
         );

            builder.Entity<Supplier>().HasData(
            new Supplier { Id = 1, Name = "Facebook", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now, ChannelId=1 },
            new Supplier { Id = 2, Name = "Twitter", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now , ChannelId =1},
            new Supplier { Id = 3, Name = "Television", IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now, ChannelId = 2},
            new Supplier { Id = 4, Name = "Billboard",  IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now , ChannelId = 3},
            new Supplier { Id =5, Name = "Gulf News",  IsDeleted = false, AddedTime = DateTime.Now, ModifiedTime = DateTime.Now, ChannelId = 4 }
        );

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() },
                new IdentityRole { Name = "Manager", NormalizedName = "Manager".ToUpper() },
                new IdentityRole { Name = "Client", NormalizedName = "Client".ToUpper() },
                new IdentityRole { Name = "Planner", NormalizedName = "Planner".ToUpper() }
                );

           
            

        }
    }
}
