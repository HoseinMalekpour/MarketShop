using System;
using System.Collections.Generic;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructures.Db.SqlServer.Ef.Database;

public partial class MarketDbContext : IdentityDbContext<AppUser , IdentityRole<int> , int>
{

    public MarketDbContext(DbContextOptions<MarketDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AllProduct> AllProducts { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }

    public virtual DbSet<Bid> Bids { get; set; }

    public virtual DbSet<Booth> Booths { get; set; }

    public virtual DbSet<BuyerMedal> BuyerMedals { get; set; }

    public virtual DbSet<Category> Categorys { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MessagesUser> MessagesUsers { get; set; }

    public virtual DbSet<MothersCategory> MothersCategorys { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductBid> ProductBids { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<SellerInformation> SellerInformations { get; set; }

    public virtual DbSet<SellerMedal> SellerMedals { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;Initial Catalog=MarketDb;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<AllProduct>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(35)
                .IsFixedLength();

            entity.HasOne(d => d.Category).WithMany(p => p.AllProducts)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AllProducts_Categorys");
        });

        //modelBuilder.Entity<AppUser>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK_AspNetUsers");

        //    entity.ToTable("AppUser");

        //    entity.Property(e => e.CountOfBuy)
        //        .HasMaxLength(10)
        //        .IsFixedLength();
        //    entity.Property(e => e.CreatAt).HasColumnName("CreatAT");

        //    entity.HasOne(d => d.BuyerMedal).WithMany(p => p.AppUsers)
        //        .HasForeignKey(d => d.BuyerMedalId)
        //        .HasConstraintName("FK_AspNetUsers_BuyerMedals");

        //    entity.HasOne(d => d.UserProfileImage).WithMany(p => p.AppUsers)
        //        .HasForeignKey(d => d.UserProfileImageId)
        //        .HasConstraintName("FK_AspNetUsers_Images");
        //});

        modelBuilder.Entity<Bid>(entity =>
        {
            entity.Property(e => e.BuyerUserId).HasMaxLength(450);
        });

        modelBuilder.Entity<Booth>(entity =>
        {
            entity.ToTable("Booth");

            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .IsFixedLength();
            entity.Property(e => e.OwnerUserId).HasMaxLength(450);

            entity.HasOne(d => d.BoothImage).WithMany(p => p.Booths)
                .HasForeignKey(d => d.BoothImageId)
                .HasConstraintName("FK_Booth_Images");

            entity.HasOne(d => d.City).WithMany(p => p.Booths)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Booth_Cities");

            entity.HasOne(d => d.OwnerUser).WithMany(p => p.Booths)
                .HasForeignKey(d => d.OwnerUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Booth_AspNetUsers");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Category");

            entity.Property(e => e.Title)
                .HasMaxLength(25)
                .IsFixedLength();

            entity.HasOne(d => d.MotherCategory).WithMany(p => p.Categories)
                .HasForeignKey(d => d.MotherCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Categorys_MothersCategorys");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsFixedLength();

            entity.HasOne(d => d.Provinces).WithMany(p => p.Cities)
                .HasForeignKey(d => d.ProvincesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cities_provinces");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.Property(e => e.Comment1)
                .HasMaxLength(250)
                .IsFixedLength()
                .HasColumnName("comment");
            entity.Property(e => e.UserId)
                .HasMaxLength(450)
                .HasColumnName("User_Id");

            entity.HasOne(d => d.Booth).WithMany(p => p.Comments)
                .HasForeignKey(d => d.BoothId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_Booth");

            entity.HasOne(d => d.Order).WithMany(p => p.Comments)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_Orders");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_AspNetUsers");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.Property(e => e.Path)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.Property(e => e.CreateBy).HasMaxLength(450);
            entity.Property(e => e.Text)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<MessagesUser>(entity =>
        {
            entity.ToTable("MessagesUSers");

            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.Message).WithMany(p => p.MessagesUsers)
                .HasForeignKey(d => d.MessageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessagesUSers_Messages");

            entity.HasOne(d => d.User).WithMany(p => p.MessagesUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessagesUSers_AspNetUsers");
        });

        modelBuilder.Entity<MothersCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MothersCategory");

            entity.Property(e => e.Title)
                .HasMaxLength(25)
                .IsFixedLength();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.BuyerUserId).HasMaxLength(450);

            entity.HasOne(d => d.Booth).WithMany(p => p.Orders)
                .HasForeignKey(d => d.BoothId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Booth");

            entity.HasOne(d => d.BuyerUser).WithMany(p => p.Orders)
                .HasForeignKey(d => d.BuyerUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_AspNetUsers");

            entity.HasOne(d => d.Status).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Status");
        });

        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity.HasOne(d => d.Order).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderProducts_Orders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderProducts_Products1");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasOne(d => d.AllProduct).WithMany(p => p.Products)
                .HasForeignKey(d => d.AllProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Products_AllProducts");
        });

        modelBuilder.Entity<ProductBid>(entity =>
        {
            entity.HasOne(d => d.Bid).WithMany(p => p.ProductBids)
                .HasForeignKey(d => d.BidId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductBids_Bids");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductBids)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductBids_Products");
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasOne(d => d.Image).WithMany(p => p.ProductImages)
                .HasForeignKey(d => d.ImageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductImages_Images");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductImages)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductImages_Products");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.ToTable("provinces");

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<SellerInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SellerInformation_1");

            entity.ToTable("SellerInformation");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.NationalCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SellerMedalId).HasColumnName("SellerMedalID");
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.City).WithMany(p => p.SellerInformations)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SellerInformation_Cities");

            entity.HasOne(d => d.SellerMedal).WithMany(p => p.SellerInformations)
                .HasForeignKey(d => d.SellerMedalId)
                .HasConstraintName("FK_SellerInformation_SellerMedals");

            entity.HasOne(d => d.User).WithMany(p => p.SellerInformations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SellerInformation_AspNetUsers");
        });

        modelBuilder.Entity<SellerMedal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Medals");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
