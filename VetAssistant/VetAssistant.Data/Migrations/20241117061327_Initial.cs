using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "CountryId"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "CountryName"),
                    Code = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, comment: "CountryISOCode")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "PetGenderId"),
                    Name = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false, comment: "GenderName")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeInspections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "TypeInspectionId"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "TypeInterventionName")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeInspections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "ClinicId"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "ClinicName"),
                    Town = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "ClinicTown"),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "ClinicAddress"),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "CountryId"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "ClinicEmail"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "ClinicPhone"),
                    WorkingTime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "ClinicWorkingTime"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "ClinicSoftDeleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clinics_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "DoctorId"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "DoctorFirstName"),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "DoctorLastName"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "DoctorDateOfBirth"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "DoctorEmailAddress"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "PhoneNumber"),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "CountryId"),
                    Town = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "DoctorTown"),
                    Education = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "DoctorEducation"),
                    Specialty = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "DoctorSpecialty"),
                    Experience = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "DoctorExperience"),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "DoctorDetails"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "DoctorImage"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "DoctorSoftDelete")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "UserId"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "FirstName"),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "LastName"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "PhoneNumber"),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "CountryId"),
                    Town = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "Town"),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Address"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "ImageUrl"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "UserDetailsSoftDeleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetails_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "PetId"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "PetName"),
                    Species = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "PetSpecies"),
                    Breed = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "PetBreed"),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "GenderId"),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "CountryId"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "PetDateOfBirth"),
                    PassportNumber = table.Column<int>(type: "int", nullable: false, comment: "PetNumberOfPassport"),
                    TransponderCode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "PetTransponderAlphanumericCode"),
                    TransponderLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "PetLocationOfTheTransponder"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "PetImage"),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "PetAdditionalDetails"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "PetSoftDeleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pets_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClinicDoctors",
                columns: table => new
                {
                    ClinicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "ClinicId"),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "DoctorId")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicDoctors", x => new { x.ClinicId, x.DoctorId });
                    table.ForeignKey(
                        name: "FK_ClinicDoctors_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClinicDoctors_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDetailsApplicationUsers",
                columns: table => new
                {
                    UserDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "UserId"),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "ApplicationUser")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetailsApplicationUsers", x => new { x.UserDetailsId, x.ApplicationUserId });
                    table.ForeignKey(
                        name: "FK_UserDetailsApplicationUsers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetailsApplicationUsers_UserDetails_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "BookingInterventionId"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "DateOfIntervention"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "UserId"),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "PetId"),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "DoctorId"),
                    TypeInspectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "TypeOfInspection"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Description"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "BookingInterventionSoftDeleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_TypeInspections_TypeInspectionId",
                        column: x => x.TypeInspectionId,
                        principalTable: "TypeInspections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_UserDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorPets",
                columns: table => new
                {
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "DoctorId"),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "PetId")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPets", x => new { x.DoctorId, x.PetId });
                    table.ForeignKey(
                        name: "FK_DoctorPets_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DoctorPets_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Interventions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "InterventionId"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "DateOfIntervention"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "UserId"),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "PetId"),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "DoctorId"),
                    TypeInspectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "TypeOfInspection"),
                    DescriptionFromDoctor = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Description"),
                    Price = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false, comment: "PriceForIntervention"),
                    DescriptionFromUSer = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Description"),
                    IsInterventionDone = table.Column<bool>(type: "bit", nullable: false, comment: "InterventionStatus"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "BookingInterventionSoftDeleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interventions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interventions_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interventions_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interventions_TypeInspections_TypeInspectionId",
                        column: x => x.TypeInspectionId,
                        principalTable: "TypeInspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interventions_UserDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetailsPets",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "UserDetailsId"),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "PetId"),
                    UserDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetailsPets", x => new { x.UserId, x.PetId });
                    table.ForeignKey(
                        name: "FK_UserDetailsPets_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetailsPets_UserDetails_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "UserDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DoctorBookings",
                columns: table => new
                {
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "DoctorId"),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "BookingId")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorBookings", x => new { x.DoctorId, x.BookingId });
                    table.ForeignKey(
                        name: "FK_DoctorBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorBookings_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PetBookings",
                columns: table => new
                {
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "PetId"),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Booking")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetBookings", x => new { x.PetId, x.BookingId });
                    table.ForeignKey(
                        name: "FK_PetBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PetBookings_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserBookings",
                columns: table => new
                {
                    UserDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "UserId"),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "BookingId")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBookings", x => new { x.UserDetailsId, x.BookingId });
                    table.ForeignKey(
                        name: "FK_UserBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBookings_UserDetails_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "UserDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DoctorInterventions",
                columns: table => new
                {
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "DoctorId"),
                    InterventionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "InterventionId")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorInterventions", x => new { x.DoctorId, x.InterventionId });
                    table.ForeignKey(
                        name: "FK_DoctorInterventions_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DoctorInterventions_Interventions_InterventionId",
                        column: x => x.InterventionId,
                        principalTable: "Interventions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PetInterventions",
                columns: table => new
                {
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "PetId"),
                    InterventionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "InterventionId")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetInterventions", x => new { x.PetId, x.InterventionId });
                    table.ForeignKey(
                        name: "FK_PetInterventions_Interventions_InterventionId",
                        column: x => x.InterventionId,
                        principalTable: "Interventions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PetInterventions_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0051f113-a1a5-48af-b8af-f8db23555a74"), "US", "United States of America" },
                    { new Guid("02836724-cb7c-4693-a6bf-ebf7e95ae492"), "ES", "Spain" },
                    { new Guid("05291f28-f94a-43e7-a8ee-cbdccb4612ec"), "CN", "China" },
                    { new Guid("073b314e-7ae3-437f-9487-e21dd6ff2f5a"), "PL", "Poland" },
                    { new Guid("077d9dc1-3253-46dd-92f7-ba21e6641bc8"), "SB", "Solomon Islands" },
                    { new Guid("08e632ea-fa25-4ddc-abfd-83d78d914c52"), "DJ", "Djibouti" },
                    { new Guid("09d28c8f-d25f-4dee-9f70-8d38e3e6b0fc"), "MY", "Malaysia" },
                    { new Guid("0a5eda74-2560-4b77-a4d0-cf6c7c5ad1ed"), "SM", "San Marino" },
                    { new Guid("0c09b2be-0ac1-4ff1-98ba-fdb76741dbd1"), "VE", "Venezuela" },
                    { new Guid("0c85448e-0fa9-47ac-9d6f-4b8a8f4e7127"), "LS", "Lesotho" },
                    { new Guid("0f81fc8c-0fcb-4ddd-801a-32086e8179f2"), "CR", "Costa Rica" },
                    { new Guid("0fec4761-42bb-4fd4-904e-d27bcfce58ae"), "MM", "Myanmar" },
                    { new Guid("10fdb21a-1cd4-434d-97a1-cc0e0d27a91f"), "BY", "Belarus" },
                    { new Guid("119c5258-7183-4136-8852-94787ce132c9"), "AM", "Armenia" },
                    { new Guid("11d85c0a-505d-4431-91ca-365d31192c3d"), "FR", "France" },
                    { new Guid("132612f9-9565-497e-8dbc-ac76ffdeb40e"), "BJ", "Benin" },
                    { new Guid("136afb49-77bd-4956-a41e-91ee90240297"), "NL", "Netherlands" },
                    { new Guid("13fdcc96-4d53-40e4-93e7-a49b1eecddba"), "JO", "Jordan" },
                    { new Guid("146532d5-7040-480a-b60c-e9de5e80876b"), "CM", "Cameroon" },
                    { new Guid("1495a151-bdcf-4ed5-9c36-a21466c5921f"), "NO", "Norway" },
                    { new Guid("14e1b457-6061-47a6-88fb-5e3b243cfc3d"), "NG", "Nigeria" },
                    { new Guid("15630223-4eb5-4d2b-affa-8db775d7d7bf"), "EC", "Ecuador" },
                    { new Guid("163293ee-c020-4617-b01e-3b7a23e79aa5"), "TM", "Turkmenistan" },
                    { new Guid("176efd02-42fe-48d0-b234-90c45c2922b6"), "KG", "Kyrgyzstan" },
                    { new Guid("1813979c-f909-4af4-aac4-2b1d788566dc"), "KE", "Kenya" },
                    { new Guid("1b3da3e2-f4a8-4fb9-94bc-4614979f1e27"), "LC", "Saint Lucia" },
                    { new Guid("1bbf61c8-f4b0-4d76-a503-1638a22f7ed0"), "AR", "Argentina" },
                    { new Guid("1c16edf0-c587-4e62-8d0e-6fdaf52eeebe"), "LI", "Liechtenstein" },
                    { new Guid("1ce6105a-58fa-4257-929a-7b0877c4474d"), "SO", "Somalia" },
                    { new Guid("1e22b379-a0c3-4b0e-9402-7bf4b13630ff"), "BT", "Bhutan" },
                    { new Guid("1f01d674-acf8-4cd0-b1f9-917ceb44dccb"), "TJ", "Tajikistan" },
                    { new Guid("201ac6c1-1827-49fe-b3e1-ec0df7c1aeda"), "MG", "Madagascar" },
                    { new Guid("206c55b9-95fe-4866-a757-5ad2796682c4"), "PW", "Palau" },
                    { new Guid("2316b3f8-44e9-43e5-b6bb-d12b1d2cf5cc"), "DE", "Germany" },
                    { new Guid("24decf1a-6412-41da-969a-551845a915c0"), "JM", "Jamaica" },
                    { new Guid("25032991-7088-4990-a171-15b660155d6b"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("2829332c-3876-4765-92b3-cb2964f876e1"), "SD", "Sudan" },
                    { new Guid("28e45857-9421-4156-94f1-1ef1d658488c"), "AO", "Angola" },
                    { new Guid("2a4aa46a-3fd2-4a5e-bf2d-976e534b3e2d"), "ZA", "South Africa" },
                    { new Guid("2fb2a4da-2869-4843-8b9c-6332b082acdd"), "BD", "Bangladesh" },
                    { new Guid("30fc9582-4387-4aae-9e88-d48b014fcf61"), "KM", "Comoros" },
                    { new Guid("31afe637-3abe-4a3b-b1a9-dbfe8c39f8ff"), "LR", "Liberia" },
                    { new Guid("32e173a6-08cc-4f7e-afb4-1f16334d95cc"), "GY", "Guyana" },
                    { new Guid("347f1b47-298c-48ea-a87a-f48022b94d5d"), "NZ", "New Zealand" },
                    { new Guid("359838fa-5981-4dc0-ae97-9fbd25cd89bd"), "QA", "Qatar" },
                    { new Guid("39f7910c-37e9-4f5d-acd3-359536809113"), "BW", "Botswana" },
                    { new Guid("3a881136-b0bb-4f71-89e7-81c45dc69b97"), "EE", "Estonia" },
                    { new Guid("3ad6c3c8-8183-40c2-b5cf-3a71a804843a"), "TZ", "Tanzania" },
                    { new Guid("3c2da900-62e8-40ef-9231-af31198b607b"), "NI", "Nicaragua" },
                    { new Guid("3c7afba9-91a3-4cd2-a623-b12f79229a92"), "TD", "Chad" },
                    { new Guid("3e57f7b6-239f-499b-b440-7ec4f115d4b0"), "DO", "Dominican Republic" },
                    { new Guid("4060e374-1097-4d67-baf0-57b594195d5e"), "PE", "Peru" },
                    { new Guid("40d13bd8-9fe5-455c-a270-d711345efab2"), "GR", "Greece" },
                    { new Guid("41b94640-a568-4ee1-8a47-729f308a964a"), "GW", "Guinea-Bissau" },
                    { new Guid("451a9b01-7c36-46d3-a02c-47eadafbc13c"), "LA", "Laos" },
                    { new Guid("48d26e13-98dc-4deb-882b-f613bfe41f4b"), "YE", "Yemen" },
                    { new Guid("48df0827-19f1-4009-9c2f-edab7fe5fa07"), "ID", "Indonesia" },
                    { new Guid("4a1a0f09-de39-4cde-92b0-db0668826f7d"), "NR", "Nauru" },
                    { new Guid("4a9a6ab6-d0a2-4296-8957-6a37f305b236"), "NA", "Namibia" },
                    { new Guid("4cdcbfb1-e048-4571-a1c0-0e6065dbbf95"), "BE", "Belgium" },
                    { new Guid("4d72db03-c3a9-4a05-9da5-5f5afc52a63b"), "CV", "Cabo Verde" },
                    { new Guid("4f24a16d-6872-4257-b1da-28c14d447e4e"), "MZ", "Mozambique" },
                    { new Guid("4fe54c00-8f2f-4588-8bf8-09a08afce1f0"), "SK", "Slovakia" },
                    { new Guid("50eeaf44-3e9c-4652-b0a6-b3e84b1b213e"), "BF", "Burkina Faso" },
                    { new Guid("50f550a8-68de-4355-9920-fadc3e2f1b2d"), "AT", "Austria" },
                    { new Guid("51771d54-865d-436f-bdfb-b4815012e9cd"), "BS", "Bahamas" },
                    { new Guid("58275c70-1c07-4804-b8d3-7caacf7e79c4"), "BH", "Bahrain" },
                    { new Guid("58a6c442-69ef-43d8-ae40-f9859be0f062"), "KP", "North Korea" },
                    { new Guid("58edc076-3fa5-4c30-aa1f-0429411c2c27"), "LB", "Lebanon" },
                    { new Guid("59bcbb14-c5ee-4b6b-9fa0-63ae6fd9d438"), "CF", "Central African Republic" },
                    { new Guid("59bf3b03-2e4f-4b52-b787-f74a52af62c5"), "MD", "Moldova" },
                    { new Guid("5ab74f46-e801-4a86-99b3-672e2389829d"), "TO", "Tonga" },
                    { new Guid("5be00c29-3f00-4fac-b861-c68b56a4e6fc"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("5ce75b9e-515b-4062-86d4-8931d5765e38"), "GD", "Grenada" },
                    { new Guid("5d43df3d-b57d-4224-b36d-6be80b13e772"), "CY", "Cyprus" },
                    { new Guid("5db13f45-4e44-4357-953f-04319b3f8bd9"), "SC", "Seychelles" },
                    { new Guid("5e2dabe3-c775-475f-a647-9e0a19713bd5"), "PS", "Palestine" },
                    { new Guid("5ff0f3fd-a689-4c2d-844c-f2b5abb7a8e6"), "IL", "Israel" },
                    { new Guid("60412d76-a846-40f8-aa2f-0ed2cbbd720b"), "SR", "Suriname" },
                    { new Guid("60577866-c9f0-4f77-a83b-c9a8888d63fd"), "FJ", "Fiji" },
                    { new Guid("60b903c9-a4b5-4e2e-937a-1ee7b1c80268"), "SY", "Syria" },
                    { new Guid("60ed4d77-30c4-4bb4-b3b3-242919e013ee"), "TH", "Thailand" },
                    { new Guid("614fd4a4-70df-4c28-b44d-5f5085aa5c83"), "EG", "Egypt" },
                    { new Guid("62313145-330a-44dc-b8a0-0b1f85a4ff4f"), "DK", "Denmark" },
                    { new Guid("642728c8-0606-4ba4-a806-466c42ecf9d8"), "GM", "Gambia" },
                    { new Guid("647d9843-9add-4d20-8888-756e8ff518d4"), "CO", "Colombia" },
                    { new Guid("65ab4f61-57be-43fc-a71e-73fcc175fb1a"), "IR", "Iran" },
                    { new Guid("6602c48a-0ae0-449c-8f8b-173101b80965"), "WS", "Samoa" },
                    { new Guid("6726ec48-cfe2-4fd3-a4d2-edd958060943"), "HR", "Croatia" },
                    { new Guid("68bfaf34-467f-4321-82c0-09c21d9f90b7"), "LU", "Luxembourg" },
                    { new Guid("696defad-f44f-429a-9e01-8fd8dc4e6227"), "TT", "Trinidad and Tobago" },
                    { new Guid("6c255709-7e2f-4f3f-b69f-5dea1f3e7aa2"), "BI", "Burundi" },
                    { new Guid("6d329cc1-7d5d-4a65-8924-599c7f87429e"), "MA", "Morocco" },
                    { new Guid("6e12b56d-4f85-4f1c-9713-6593b7100686"), "HT", "Haiti" },
                    { new Guid("6efbbcfd-6d5e-401c-a157-febe82fe349e"), "KR", "South Korea" },
                    { new Guid("7533c6e0-fe48-45c2-bac0-996d14308bf6"), "BG", "Bulgaria" },
                    { new Guid("75aee484-2190-4370-8d48-cc70df8a737a"), "RO", "Romania" },
                    { new Guid("760b8024-1b4b-4d2d-a32f-374486e5009f"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("7661611c-5c4c-4f3e-8153-56e0334ed55b"), "PG", "Papua New Guinea" },
                    { new Guid("7815b654-b074-46ab-9e3f-efb94403e361"), "IT", "Italy" },
                    { new Guid("78752889-5b28-4ac0-a59b-575fe0eac1c3"), "ER", "Eritrea" },
                    { new Guid("78e065ee-9501-42d6-b4d1-ad2a12aaa341"), "PT", "Portugal" },
                    { new Guid("79076b71-b4f9-410c-860f-1f9132f3c81e"), "ST", "Sao Tome and Principe" },
                    { new Guid("790a2d97-ebe9-4c22-b053-a920ca15fb75"), "MK", "North Macedonia" },
                    { new Guid("79d988cc-fe31-4255-ac16-1f00aded37f9"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("7bb012a6-5f3b-4c84-ab86-db6e9dc063cf"), "RU", "Russia" },
                    { new Guid("7ed95e03-2c7e-4439-b084-e21d59885292"), "MH", "Marshall Islands" },
                    { new Guid("7ee586db-a771-41a3-a755-1faaca7ef4b3"), "ET", "Ethiopia" },
                    { new Guid("7f44fb24-a47b-444e-942d-d5078a51c40f"), "KW", "Kuwait" },
                    { new Guid("82cf3171-cbda-4077-91a4-4847bf4b8d44"), "CA", "Canada" },
                    { new Guid("84c33aac-41ee-4524-a084-595c70aea921"), "TL", "Timor-Leste" },
                    { new Guid("84e6f1d8-dc43-4879-8570-de4c016be04a"), "DZ", "Algeria" },
                    { new Guid("85872c43-85f1-4bb5-a3c3-5fec09149fe0"), "LV", "Latvia" },
                    { new Guid("8899043a-879a-43d9-b918-cb01a6bfb847"), "TV", "Tuvalu" },
                    { new Guid("8db9d55c-5061-4ee3-a727-2944ad70baed"), "FM", "Micronesia" },
                    { new Guid("8dfdd401-e1c7-4289-8825-a8d00a1b1114"), "VN", "Vietnam" },
                    { new Guid("8e83bbfd-9950-4fbd-bd86-63c59f1c1b81"), "GN", "Guinea" },
                    { new Guid("8ecc3741-9cdc-4edf-b1bd-8b206e8b4831"), "MV", "Maldives" },
                    { new Guid("8f0e1dd1-6dc9-4c00-8ad4-3b5e5bebc695"), "AU", "Australia" },
                    { new Guid("8fb79544-1e1e-48a1-88e1-57a4a6530ce3"), "GA", "Gabon" },
                    { new Guid("900174b1-1f0c-45de-be15-ac5e44e60acd"), "MN", "Mongolia" },
                    { new Guid("903a3477-942d-498d-8ad7-f2f9424d2f93"), "MX", "Mexico" },
                    { new Guid("932f6641-0d78-4ffe-97b7-2aa02320b95e"), "TN", "Tunisia" },
                    { new Guid("938cec65-f319-4b61-8f84-c0bc47637c16"), "SI", "Slovenia" },
                    { new Guid("98429dc9-46a1-444e-a810-6a075a89de9a"), "KZ", "Kazakhstan" },
                    { new Guid("9b111ed7-d066-4e73-8f94-48724983db82"), "SL", "Sierra Leone" },
                    { new Guid("9c38eb99-d4c8-4398-8619-434a046cc736"), "HU", "Hungary" },
                    { new Guid("9e553e29-6298-4377-8932-dfc5d7c8cd2a"), "IQ", "Iraq" },
                    { new Guid("9f8b4935-1412-4ba5-93f3-959c65caf031"), "GQ", "Equatorial Guinea" },
                    { new Guid("a367122a-b431-4155-bca9-2e193630544d"), "AZ", "Azerbaijan" },
                    { new Guid("a4cdc4f2-3e7a-49cd-9ba6-c3a784fc648f"), "AG", "Antigua and Barbuda" },
                    { new Guid("a6ddec4c-6d6b-44bf-b921-16a24864be83"), "SG", "Singapore" },
                    { new Guid("a7c47761-8ee6-45c7-9370-4f5dccd18343"), "SN", "Senegal" },
                    { new Guid("a7fb82fd-8f82-42d4-850a-1ca5274500af"), "GH", "Ghana" },
                    { new Guid("a947676a-9195-4db2-b9e3-ed7ffd35bf46"), "UY", "Uruguay" },
                    { new Guid("aab630ce-8a65-410b-9f0f-5ec42107ae38"), "SS", "South Sudan" },
                    { new Guid("aaf689e1-f84a-4072-86a9-e4419f92800f"), "UG", "Uganda" },
                    { new Guid("ad7f38b1-f083-47f2-974f-9a723c5a6886"), "TR", "Turkey" },
                    { new Guid("af6656b4-04da-4210-a836-346abb0f05c2"), "KH", "Cambodia" },
                    { new Guid("b055064b-c728-4abb-8ef3-b0d7728969e4"), "SA", "Saudi Arabia" },
                    { new Guid("b1eea1ce-a799-4015-a3dd-a318d894d555"), "KI", "Kiribati" },
                    { new Guid("b451730d-5a8a-43f4-86fa-cadfe9992994"), "LY", "Libya" },
                    { new Guid("b4a30250-672f-4270-88c5-a3ac06026049"), "TG", "Togo" },
                    { new Guid("b6dca6d0-8e3f-41eb-b3ae-4ef07c7ea0c6"), "JP", "Japan" },
                    { new Guid("b6e6bd19-39cb-42ab-8692-eb082730c753"), "FI", "Finland" },
                    { new Guid("b8d006d8-85f9-4cdf-bf9f-4906a17d2575"), "AE", "United Arab Emirates" },
                    { new Guid("b9523c39-cd32-4379-8367-530bbcb07172"), "IN", "India" },
                    { new Guid("b99fd527-7a56-406d-988f-dd6410fd8512"), "UA", "Ukraine" },
                    { new Guid("baafb8a1-439a-4f6d-910d-71e3b6a3ae71"), "GB", "United Kingdom" },
                    { new Guid("bb3e2052-aa2a-4b77-af24-0dc579ec27f8"), "SZ", "Eswatini" },
                    { new Guid("bce54b8f-e552-4d08-94c0-257c33c35bf0"), "NP", "Nepal" },
                    { new Guid("c0d11139-7158-4200-a70a-dc8cd1a40340"), "VU", "Vanuatu" },
                    { new Guid("c1c99e44-5db0-42c8-89bd-ba7e599c71bd"), "CU", "Cuba" },
                    { new Guid("c466e06b-491e-4a08-84e4-4308991668d3"), "SV", "El Salvador" },
                    { new Guid("c847efec-7cc9-4ca6-ad20-801d9574218c"), "BR", "Brazil" },
                    { new Guid("c968c7aa-a1bd-408a-b99c-dd27e5606392"), "OM", "Oman" },
                    { new Guid("cb213f3a-6b32-4afa-8cc8-c3b0d5974ba9"), "IE", "Ireland" },
                    { new Guid("cba90152-bbb2-4457-8556-6491246c14e7"), "BZ", "Belize" },
                    { new Guid("cdc9f6e7-3a75-4376-8dbb-deb61aa82bb9"), "UZ", "Uzbekistan" },
                    { new Guid("cec3d8d0-5ac8-4512-b7fd-d39f2c7ec41b"), "DM", "Dominica" },
                    { new Guid("d13beaa4-41ce-4ac6-9a69-e44786f0113a"), "PY", "Paraguay" },
                    { new Guid("d1cf637b-f93b-4489-b347-fa4f83b512ab"), "RS", "Serbia" },
                    { new Guid("d3827c2a-e8f9-4463-b852-d8af8a806404"), "MW", "Malawi" },
                    { new Guid("d4d76580-abb6-4a3f-be6d-eea3b3c74d0f"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("d57bb1fb-68d7-41ec-89a8-0f8184a6de78"), "GE", "Georgia" },
                    { new Guid("d759fd9f-3e8a-42b1-942d-8447f285c25d"), "CL", "Chile" },
                    { new Guid("da1e00fc-ebcf-4507-8923-e354230fa761"), "LT", "Lithuania" },
                    { new Guid("df365ef0-3a00-46d9-a478-cada5a77d126"), "LK", "Sri Lanka" },
                    { new Guid("df9cec09-955c-440f-95ac-8c076d733b75"), "IS", "Iceland" },
                    { new Guid("e1174b5f-3e91-4f0c-a14e-e4cd0b251e6c"), "NE", "Niger" },
                    { new Guid("e11a5c45-e4f7-4366-9aa2-9c30a7f196f4"), "MC", "Monaco" },
                    { new Guid("e15d6cd5-b7ed-474a-a389-a8d19554973d"), "MR", "Mauritania" },
                    { new Guid("e165f06f-24ba-4663-b09a-107b66433e25"), "SE", "Sweden" },
                    { new Guid("e166486d-ac92-482d-8cf9-c68e83de26e3"), "GT", "Guatemala" },
                    { new Guid("e1bbde39-9ed3-45f3-81d0-864cd6f64a22"), "AL", "Albania" },
                    { new Guid("e6e5e5c2-0c81-475d-ac6d-8e5118acfd08"), "PA", "Panama" },
                    { new Guid("e9862297-0998-4c66-ad0e-4b3abf316b8d"), "HN", "Honduras" },
                    { new Guid("ea6f8da4-e12e-42dd-883d-25e679b8ee74"), "ZM", "Zambia" },
                    { new Guid("eb221aab-b113-45f1-abed-4bfbd46b60b8"), "BB", "Barbados" },
                    { new Guid("ec274e23-55d3-4c32-92ad-b59b8f89ca2e"), "MU", "Mauritius" },
                    { new Guid("edea5920-4dbf-45a3-a74f-7bac8a58cba6"), "MT", "Malta" },
                    { new Guid("ee07a86f-7494-4c6f-885f-43253d9ee007"), "BO", "Bolivia" },
                    { new Guid("ee4d562b-1f53-4002-b96f-7b70c238e279"), "PH", "Philippines" },
                    { new Guid("eee4d292-f906-4208-a42a-f62f59ebf4d5"), "RW", "Rwanda" },
                    { new Guid("ef564c8f-dae6-426c-a7c9-1e7f929060e2"), "BN", "Brunei" },
                    { new Guid("ef9fcc24-7845-4e0c-9de5-26e5e36eff56"), "PK", "Pakistan" },
                    { new Guid("f0cb0f47-71f3-44fb-8c90-c94decbe3a20"), "AF", "Afghanistan" },
                    { new Guid("f21288ed-9c3a-463b-baaf-5fe214508798"), "VA", "Holy See" },
                    { new Guid("f5986a0d-43a5-4578-b850-40aade4701a1"), "VA", "Vatican City" },
                    { new Guid("f9071618-703a-40b9-abac-2d5172507966"), "ML", "Mali" },
                    { new Guid("fae189ba-03ce-4072-bbad-b2f4fc896aed"), "CH", "Switzerland" },
                    { new Guid("fb430e86-40bf-44a3-93ff-a544d96b2bd0"), "AD", "Andorra" },
                    { new Guid("fd91ee6a-1f15-4897-ba99-fdbe4d71079b"), "ZW", "Zimbabwe" },
                    { new Guid("ff6c9841-5c86-4c87-a63a-61ff48c163ed"), "ME", "Montenegro" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4ecf606f-a512-44a9-a29d-5a92cfc6584d"), "Female" },
                    { new Guid("53df8532-0f02-4044-9a82-72a788f77ac0"), "Male" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3c0fe220-c4bd-470e-909b-e487090b9872"), "Diagnostic Interventions" },
                    { new Guid("40c908fa-9356-4e66-9adf-e798e9677903"), "Obstetric and Reproductive Interventions" },
                    { new Guid("7180472c-91d2-417b-be77-c3cd984a3c78"), "Postoperative Care" },
                    { new Guid("8e534223-6105-41c1-8a08-11aec3218178"), "Therapeutic Interventions" },
                    { new Guid("9cd917e8-1a74-4a8d-9521-45aabfaf400a"), "Oncological Interventions" },
                    { new Guid("af379a78-da2b-4703-a03f-d2082f433eb7"), "Dental Interventions" },
                    { new Guid("b83dd9df-8bcc-4be9-a1b7-7fe97a9ee93e"), "Surgical Interventions" },
                    { new Guid("bb31a26a-2cdf-4866-b10a-dd97fabe06c3"), "Emergency" },
                    { new Guid("ca2c8d0e-414e-4083-8f67-a1cab6dc3afa"), "Exotic and Specialized Interventions" },
                    { new Guid("f7d187ef-ae55-4914-80a4-41ae9f7abac0"), "Preventive Interventions" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DoctorId",
                table: "Bookings",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PetId",
                table: "Bookings",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TypeInspectionId",
                table: "Bookings",
                column: "TypeInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicDoctors_DoctorId",
                table: "ClinicDoctors",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_CountryId",
                table: "Clinics",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorBookings_BookingId",
                table: "DoctorBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorInterventions_InterventionId",
                table: "DoctorInterventions",
                column: "InterventionId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPets_PetId",
                table: "DoctorPets",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CountryId",
                table: "Doctors",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_DoctorId",
                table: "Interventions",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_PetId",
                table: "Interventions",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_TypeInspectionId",
                table: "Interventions",
                column: "TypeInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_UserId",
                table: "Interventions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PetBookings_BookingId",
                table: "PetBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_PetInterventions_InterventionId",
                table: "PetInterventions",
                column: "InterventionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_CountryId",
                table: "Pets",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_GenderId",
                table: "Pets",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBookings_BookingId",
                table: "UserBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_CountryId",
                table: "UserDetails",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailsApplicationUsers_ApplicationUserId",
                table: "UserDetailsApplicationUsers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailsPets_PetId",
                table: "UserDetailsPets",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailsPets_UserDetailsId",
                table: "UserDetailsPets",
                column: "UserDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClinicDoctors");

            migrationBuilder.DropTable(
                name: "DoctorBookings");

            migrationBuilder.DropTable(
                name: "DoctorInterventions");

            migrationBuilder.DropTable(
                name: "DoctorPets");

            migrationBuilder.DropTable(
                name: "PetBookings");

            migrationBuilder.DropTable(
                name: "PetInterventions");

            migrationBuilder.DropTable(
                name: "UserBookings");

            migrationBuilder.DropTable(
                name: "UserDetailsApplicationUsers");

            migrationBuilder.DropTable(
                name: "UserDetailsPets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Interventions");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "TypeInspections");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
