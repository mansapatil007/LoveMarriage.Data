using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LoveMarriage.Data.Models
{
    public partial class LoveMarriageDBContext : DbContext
    {
        public LoveMarriageDBContext()
        {
        }

        public LoveMarriageDBContext(DbContextOptions<LoveMarriageDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoveMarriageUsers> LoveMarriageUsers { get; set; }
        public virtual DbSet<XAffluenceLevel> XAffluenceLevel { get; set; }
        public virtual DbSet<XBloodGroup> XBloodGroup { get; set; }
        public virtual DbSet<XChildrenStatus> XChildrenStatus { get; set; }
        public virtual DbSet<XCommunity> XCommunity { get; set; }
        public virtual DbSet<XCountries> XCountries { get; set; }
        public virtual DbSet<XDesignation> XDesignation { get; set; }
        public virtual DbSet<XDietType> XDietType { get; set; }
        public virtual DbSet<XEducationFields> XEducationFields { get; set; }
        public virtual DbSet<XEducationLevel> XEducationLevel { get; set; }
        public virtual DbSet<XFamilyType> XFamilyType { get; set; }
        public virtual DbSet<XFamilyValues> XFamilyValues { get; set; }
        public virtual DbSet<XGender> XGender { get; set; }
        public virtual DbSet<XHealthIssues> XHealthIssues { get; set; }
        public virtual DbSet<XHeight> XHeight { get; set; }
        public virtual DbSet<XIncomeRange> XIncomeRange { get; set; }
        public virtual DbSet<XMaritalStatus> XMaritalStatus { get; set; }
        public virtual DbSet<XMotherTongue> XMotherTongue { get; set; }
        public virtual DbSet<XNakshatra> XNakshatra { get; set; }
        public virtual DbSet<XParentStatus> XParentStatus { get; set; }
        public virtual DbSet<XProfileCreatedBy> XProfileCreatedBy { get; set; }
        public virtual DbSet<XRashiMoonSign> XRashiMoonSign { get; set; }
        public virtual DbSet<XReligion> XReligion { get; set; }
        public virtual DbSet<XResidencyStatus> XResidencyStatus { get; set; }
        public virtual DbSet<XStates> XStates { get; set; }
        public virtual DbSet<XSubCommunity> XSubCommunity { get; set; }
        public virtual DbSet<XWorkingWith> XWorkingWith { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DDTF1HQ2;Initial Catalog=LoveMarriageDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoveMarriageUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("LoveMarriage_Users");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserEmailId)
                    .IsRequired()
                    .HasColumnName("User_Email_Id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("User_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("User_Password")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XAffluenceLevel>(entity =>
            {
                entity.ToTable("X_Affluence_Level");

                entity.Property(e => e.XAffluenceLevelId).HasColumnName("X_Affluence_Level_Id");

                entity.Property(e => e.XAffluenceLevel1)
                    .IsRequired()
                    .HasColumnName("X_Affluence_Level")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XBloodGroup>(entity =>
            {
                entity.HasKey(e => e.BloodGroupId);

                entity.ToTable("X_Blood_Group");

                entity.Property(e => e.BloodGroupId).HasColumnName("Blood_Group_Id");

                entity.Property(e => e.BloodGroup)
                    .IsRequired()
                    .HasColumnName("Blood_Group")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XChildrenStatus>(entity =>
            {
                entity.HasKey(e => e.ChildrenStatusId);

                entity.ToTable("X_Children_Status");

                entity.Property(e => e.ChildrenStatusId).HasColumnName("Children_Status_Id");

                entity.Property(e => e.ChildrenStatus)
                    .IsRequired()
                    .HasColumnName("Children_Status")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XCommunity>(entity =>
            {
                entity.HasKey(e => e.CommunityTypeId);

                entity.ToTable("X_Community");

                entity.Property(e => e.CommunityTypeId).HasColumnName("Community_Type_Id");

                entity.Property(e => e.CommunityType)
                    .IsRequired()
                    .HasColumnName("Community_Type")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__X_Countr__8036CBAECDADC786");

                entity.ToTable("X_Countries");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("Country_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CountryPhoneCode).HasColumnName("Country_PhoneCode");

                entity.Property(e => e.CountryShortName)
                    .IsRequired()
                    .HasColumnName("Country_Short_Name")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XDesignation>(entity =>
            {
                entity.HasKey(e => e.DesignationId);

                entity.ToTable("X_Designation");

                entity.Property(e => e.DesignationId).HasColumnName("Designation_Id");

                entity.Property(e => e.DesignationType)
                    .IsRequired()
                    .HasColumnName("Designation_Type")
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XDietType>(entity =>
            {
                entity.HasKey(e => e.DietId);

                entity.ToTable("X_Diet_Type");

                entity.Property(e => e.DietId).HasColumnName("Diet_Id");

                entity.Property(e => e.DietType)
                    .IsRequired()
                    .HasColumnName("Diet_Type")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XEducationFields>(entity =>
            {
                entity.HasKey(e => e.EducationFieldId);

                entity.ToTable("X_Education_Fields");

                entity.Property(e => e.EducationFieldId).HasColumnName("Education_Field_Id");

                entity.Property(e => e.EducationField)
                    .IsRequired()
                    .HasColumnName("Education_Field")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XEducationLevel>(entity =>
            {
                entity.HasKey(e => e.EducationLevelId);

                entity.ToTable("X_Education_Level");

                entity.Property(e => e.EducationLevelId).HasColumnName("Education_Level_id");

                entity.Property(e => e.EducationLevel)
                    .IsRequired()
                    .HasColumnName("Education_Level")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XFamilyType>(entity =>
            {
                entity.HasKey(e => e.FamilyTypeId);

                entity.ToTable("X_Family_Type");

                entity.Property(e => e.FamilyTypeId).HasColumnName("Family_Type_Id");

                entity.Property(e => e.FamilyType)
                    .IsRequired()
                    .HasColumnName("Family_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XFamilyValues>(entity =>
            {
                entity.HasKey(e => e.FamilyValueId);

                entity.ToTable("X_Family_Values");

                entity.Property(e => e.FamilyValueId).HasColumnName("Family_Value_Id");

                entity.Property(e => e.FamilyValueType)
                    .IsRequired()
                    .HasColumnName("Family_Value_Type")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XGender>(entity =>
            {
                entity.HasKey(e => e.GenderId);

                entity.ToTable("X_Gender");

                entity.Property(e => e.GenderId).HasColumnName("Gender_Id");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XHealthIssues>(entity =>
            {
                entity.HasKey(e => e.HealthIssueId);

                entity.ToTable("X_Health_Issues");

                entity.Property(e => e.HealthIssueId).HasColumnName("Health_Issue_Id");

                entity.Property(e => e.HealthIssueType)
                    .IsRequired()
                    .HasColumnName("Health_Issue_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XHeight>(entity =>
            {
                entity.HasKey(e => e.HeightId);

                entity.ToTable("X_Height");

                entity.Property(e => e.HeightId).HasColumnName("Height_Id");

                entity.Property(e => e.Height)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XIncomeRange>(entity =>
            {
                entity.HasKey(e => e.IncomeRangeId);

                entity.ToTable("X_Income_Range");

                entity.Property(e => e.IncomeRangeId).HasColumnName("Income_Range_Id");

                entity.Property(e => e.IncomeRange)
                    .IsRequired()
                    .HasColumnName("Income_Range")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XMaritalStatus>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId);

                entity.ToTable("X_Marital_Status");

                entity.Property(e => e.MaritalStatusId).HasColumnName("Marital_Status_Id");

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasColumnName("Marital_Status")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XMotherTongue>(entity =>
            {
                entity.HasKey(e => e.MotherTongueId)
                    .HasName("PK_X_Mothertongue");

                entity.ToTable("X_Mother_Tongue");

                entity.Property(e => e.MotherTongueId).HasColumnName("Mother_Tongue_Id");

                entity.Property(e => e.MotherTongue)
                    .IsRequired()
                    .HasColumnName("Mother_Tongue")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XNakshatra>(entity =>
            {
                entity.HasKey(e => e.NakshatraId);

                entity.ToTable("X_Nakshatra");

                entity.Property(e => e.NakshatraId).HasColumnName("Nakshatra_Id");

                entity.Property(e => e.NakshatraName)
                    .IsRequired()
                    .HasColumnName("Nakshatra_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XParentStatus>(entity =>
            {
                entity.HasKey(e => e.ParentStatusId)
                    .HasName("PK_X_Fathers_Status");

                entity.ToTable("X_Parent_Status");

                entity.Property(e => e.ParentStatusId).HasColumnName("Parent_Status_Id");

                entity.Property(e => e.ParentStatus)
                    .IsRequired()
                    .HasColumnName("Parent_Status")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XProfileCreatedBy>(entity =>
            {
                entity.HasKey(e => e.ProfileCreatedById);

                entity.ToTable("X_Profile_Created_By");

                entity.Property(e => e.ProfileCreatedById).HasColumnName("Profile_Created_By_Id");

                entity.Property(e => e.ProfileCreatedBy)
                    .IsRequired()
                    .HasColumnName("Profile_Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XRashiMoonSign>(entity =>
            {
                entity.HasKey(e => e.RashiMoonSignId);

                entity.ToTable("X_Rashi_MoonSign");

                entity.Property(e => e.RashiMoonSignId).HasColumnName("Rashi_MoonSign_Id");

                entity.Property(e => e.RashiMoonSign)
                    .IsRequired()
                    .HasColumnName("Rashi_MoonSign")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XReligion>(entity =>
            {
                entity.HasKey(e => e.ReligionId);

                entity.ToTable("X_Religion");

                entity.Property(e => e.ReligionId).HasColumnName("Religion_Id");

                entity.Property(e => e.Religion)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XResidencyStatus>(entity =>
            {
                entity.HasKey(e => e.ResidencyStatusId)
                    .HasName("PK_X_Residency_Type");

                entity.ToTable("X_Residency_Status");

                entity.Property(e => e.ResidencyStatusId).HasColumnName("Residency_Status_Id");

                entity.Property(e => e.ResidencyStatus)
                    .IsRequired()
                    .HasColumnName("Residency_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XStates>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK__X_States__AF9338F73C3CD5E9");

                entity.ToTable("X_States");

                entity.Property(e => e.StateId)
                    .HasColumnName("State_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasColumnName("State_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XSubCommunity>(entity =>
            {
                entity.HasKey(e => e.SubCommunityTypeId);

                entity.ToTable("X_Sub_Community");

                entity.Property(e => e.SubCommunityTypeId).HasColumnName("SubCommunity_Type_Id");

                entity.Property(e => e.SubCommunityType)
                    .IsRequired()
                    .HasColumnName("SubCommunity_Type")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XWorkingWith>(entity =>
            {
                entity.HasKey(e => e.WorkingWithId);

                entity.ToTable("X_Working_With");

                entity.Property(e => e.WorkingWithId).HasColumnName("Working_With_Id");

                entity.Property(e => e.WorkingWithOrg)
                    .IsRequired()
                    .HasColumnName("Working_With_Org")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
