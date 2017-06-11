using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyHealthBlog.Data;
using MyHealthBlog.Domain;

namespace MyHealthBlog.Data.Migrations
{
    [DbContext(typeof(MyHealthBlogContext))]
    partial class MyHealthBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyHealthBlog.Domain.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Content");

                    b.Property<int>("FoodCategoryId");

                    b.Property<string>("HeadLine");

                    b.Property<string>("NotesAndLinks");

                    b.Property<DateTime>("ReleaseTime");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("MyHealthBlog.Domain.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FoodType");

                    b.Property<string>("ImgUrl");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("MyHealthBlog.Domain.FoodObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CaloriesPer100g");

                    b.Property<int>("Carb");

                    b.Property<string>("Description");

                    b.Property<int>("Fat");

                    b.Property<int>("FoodCategoryId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Links");

                    b.Property<string>("Name");

                    b.Property<int>("Protein");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("FoodObjects");
                });

            modelBuilder.Entity("MyHealthBlog.Domain.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<int>("FoodCategoryId");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Ingredients");

                    b.Property<string>("MakingDescription");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("MyHealthBlog.Domain.Article", b =>
                {
                    b.HasOne("MyHealthBlog.Domain.FoodCategory")
                        .WithMany("Articles")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyHealthBlog.Domain.FoodObject", b =>
                {
                    b.HasOne("MyHealthBlog.Domain.FoodCategory")
                        .WithMany("FoodObjects")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyHealthBlog.Domain.Recipe", b =>
                {
                    b.HasOne("MyHealthBlog.Domain.FoodCategory")
                        .WithMany("Recipes")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
