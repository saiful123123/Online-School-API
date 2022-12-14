// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineSchool.Models;

namespace OnlineSchool.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200627111517_DatabaseFile4")]
    partial class DatabaseFile4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineSchool.Models.Admin", b =>
                {
                    b.Property<int>("ADID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("AuthID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Profile_Image_Path")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("ADID");

                    b.HasIndex("AuthID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("OnlineSchool.Models.Admin_Course", b =>
                {
                    b.Property<int>("AC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ADID")
                        .HasColumnType("int");

                    b.Property<int>("CID")
                        .HasColumnType("int");

                    b.HasKey("AC");

                    b.HasIndex("ADID");

                    b.HasIndex("CID");

                    b.ToTable("Admin_Courses");
                });

            modelBuilder.Entity("OnlineSchool.Models.Authorization", b =>
                {
                    b.Property<int>("AuthID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company_Name")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("JWT_Token")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("AuthID");

                    b.ToTable("Authorizations");
                });

            modelBuilder.Entity("OnlineSchool.Models.Comment", b =>
                {
                    b.Property<int>("ComID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("OnlineSchool.Models.Course", b =>
                {
                    b.Property<int>("CID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_Path")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("CID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("OnlineSchool.Models.Like", b =>
                {
                    b.Property<int>("LID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.HasKey("LID");

                    b.ToTable("Like");
                });

            modelBuilder.Entity("OnlineSchool.Models.Student", b =>
                {
                    b.Property<int>("SID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("AuthID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Profile_Image_Path")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("SID");

                    b.HasIndex("AuthID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("OnlineSchool.Models.Student_Tutorial_Comment", b =>
                {
                    b.Property<int>("STC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComID")
                        .HasColumnType("int");

                    b.Property<int>("SID")
                        .HasColumnType("int");

                    b.Property<int>("TID")
                        .HasColumnType("int");

                    b.HasKey("STC");

                    b.HasIndex("ComID");

                    b.HasIndex("SID");

                    b.HasIndex("TID");

                    b.ToTable("Student_Tutorial_Comment");
                });

            modelBuilder.Entity("OnlineSchool.Models.Student_Tutorial_Like", b =>
                {
                    b.Property<int>("STL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LID")
                        .HasColumnType("int");

                    b.Property<int>("SID")
                        .HasColumnType("int");

                    b.Property<int>("TID")
                        .HasColumnType("int");

                    b.HasKey("STL");

                    b.HasIndex("LID");

                    b.HasIndex("SID");

                    b.HasIndex("TID");

                    b.ToTable("Student_Tutorial_Like");
                });

            modelBuilder.Entity("OnlineSchool.Models.Teacher", b =>
                {
                    b.Property<int>("TeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("AuthID")
                        .HasColumnType("int");

                    b.Property<string>("CV_Path")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Profile_Image_Path")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("TeID");

                    b.HasIndex("AuthID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("OnlineSchool.Models.Teacher_Course_Tutorial", b =>
                {
                    b.Property<int>("TeCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CID")
                        .HasColumnType("int");

                    b.Property<int>("TID")
                        .HasColumnType("int");

                    b.Property<int>("TeID")
                        .HasColumnType("int");

                    b.HasKey("TeCT");

                    b.HasIndex("CID");

                    b.HasIndex("TID");

                    b.HasIndex("TeID");

                    b.ToTable("Teacher_Course_Tutorial");
                });

            modelBuilder.Entity("OnlineSchool.Models.Teacher_Tutorial_Comment", b =>
                {
                    b.Property<int>("TTC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComID")
                        .HasColumnType("int");

                    b.Property<int>("TID")
                        .HasColumnType("int");

                    b.Property<int>("TeID")
                        .HasColumnType("int");

                    b.HasKey("TTC");

                    b.HasIndex("ComID");

                    b.HasIndex("TID");

                    b.HasIndex("TeID");

                    b.ToTable("Teacher_Tutorial_Comment");
                });

            modelBuilder.Entity("OnlineSchool.Models.Teacher_Tutorial_Like", b =>
                {
                    b.Property<int>("TeTL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LID")
                        .HasColumnType("int");

                    b.Property<int>("TID")
                        .HasColumnType("int");

                    b.Property<int>("TeID")
                        .HasColumnType("int");

                    b.HasKey("TeTL");

                    b.HasIndex("LID");

                    b.HasIndex("TID");

                    b.HasIndex("TeID");

                    b.ToTable("Teacher_Tutorial_Like");
                });

            modelBuilder.Entity("OnlineSchool.Models.Tutorial", b =>
                {
                    b.Property<int>("TID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Video_Path")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("TID");

                    b.ToTable("Tutorial");
                });

            modelBuilder.Entity("OnlineSchool.Models.Admin", b =>
                {
                    b.HasOne("OnlineSchool.Models.Authorization", "Authorization")
                        .WithMany("admin")
                        .HasForeignKey("AuthID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineSchool.Models.Admin_Course", b =>
                {
                    b.HasOne("OnlineSchool.Models.Admin", "Admin")
                        .WithMany("admin_Courses")
                        .HasForeignKey("ADID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Course", "Course")
                        .WithMany("admin_Courses")
                        .HasForeignKey("CID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineSchool.Models.Student", b =>
                {
                    b.HasOne("OnlineSchool.Models.Authorization", "Authorization")
                        .WithMany("students")
                        .HasForeignKey("AuthID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineSchool.Models.Student_Tutorial_Comment", b =>
                {
                    b.HasOne("OnlineSchool.Models.Comment", "Comment")
                        .WithMany("Student_Tutorial_Comments")
                        .HasForeignKey("ComID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Student", "Student")
                        .WithMany("Student_Tutorial_Comments")
                        .HasForeignKey("SID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Tutorial", "Tutorial")
                        .WithMany("Student_Tutorial_Comments")
                        .HasForeignKey("TID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineSchool.Models.Student_Tutorial_Like", b =>
                {
                    b.HasOne("OnlineSchool.Models.Like", "Like")
                        .WithMany("Student_Tutorial_Like")
                        .HasForeignKey("LID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Student", "Student")
                        .WithMany("Student_Tutorial_Like")
                        .HasForeignKey("SID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Tutorial", "Tutorial")
                        .WithMany("Student_Tutorial_Like")
                        .HasForeignKey("TID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineSchool.Models.Teacher", b =>
                {
                    b.HasOne("OnlineSchool.Models.Authorization", "Authorization")
                        .WithMany("teachers")
                        .HasForeignKey("AuthID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineSchool.Models.Teacher_Course_Tutorial", b =>
                {
                    b.HasOne("OnlineSchool.Models.Course", "Course")
                        .WithMany("teacher_course_tutorials")
                        .HasForeignKey("CID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Tutorial", "Tutorial")
                        .WithMany("teacher_course_tutorials")
                        .HasForeignKey("TID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Course_Tutorials")
                        .HasForeignKey("TeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineSchool.Models.Teacher_Tutorial_Comment", b =>
                {
                    b.HasOne("OnlineSchool.Models.Comment", "Comment")
                        .WithMany("Teacher_Tutorial_Comments")
                        .HasForeignKey("ComID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Tutorial", "Tutorial")
                        .WithMany("Teacher_Tutorial_Comments")
                        .HasForeignKey("TID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Tutorial_Comments")
                        .HasForeignKey("TeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineSchool.Models.Teacher_Tutorial_Like", b =>
                {
                    b.HasOne("OnlineSchool.Models.Like", "Like")
                        .WithMany("Teacher_Tutorial_Like")
                        .HasForeignKey("LID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Tutorial", "Tutorial")
                        .WithMany("Teacher_Tutorial_Like")
                        .HasForeignKey("TID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSchool.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Tutorial_Like")
                        .HasForeignKey("TeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
