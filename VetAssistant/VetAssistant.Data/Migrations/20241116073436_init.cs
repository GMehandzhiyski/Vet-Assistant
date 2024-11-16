using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_TypeInspections_TypeInspectionId",
                        column: x => x.TypeInspectionId,
                        principalTable: "TypeInspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorPets_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetailsPets_UserDetails_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetBookings_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorInterventions_Interventions_InterventionId",
                        column: x => x.InterventionId,
                        principalTable: "Interventions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetInterventions_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("02451861-d3f0-4911-b24e-835fc3e6982e"), "MW", "Malawi" },
                    { new Guid("02657e8f-69ba-4297-8232-dd719597f651"), "BN", "Brunei" },
                    { new Guid("08e0537c-ccc2-4e36-9321-6f078604d6a3"), "AG", "Antigua and Barbuda" },
                    { new Guid("0925b76b-c1cc-438d-8f8f-d6841ae1d3f0"), "ST", "Sao Tome and Principe" },
                    { new Guid("09443c03-1667-43d2-8ace-7ccd963bd5ae"), "AZ", "Azerbaijan" },
                    { new Guid("09bec1cd-a208-4008-81a6-5ebede87dd70"), "CO", "Colombia" },
                    { new Guid("0a686465-af16-4ea4-9420-df710fe2302d"), "KG", "Kyrgyzstan" },
                    { new Guid("0b13a496-93b2-408d-b97c-db0ca5dc9f40"), "LA", "Laos" },
                    { new Guid("0ebfeeb6-0721-4047-a16a-f113e02f0cf1"), "KR", "South Korea" },
                    { new Guid("109a80af-df4a-4971-a9ce-36179f3141da"), "GM", "Gambia" },
                    { new Guid("11297a24-8d79-47ef-b07f-900a220f4b3c"), "UG", "Uganda" },
                    { new Guid("114a7b1c-efce-4053-aade-82ed8d5f60be"), "WS", "Samoa" },
                    { new Guid("1174a7f1-3c74-4c66-a688-095507beefe4"), "BB", "Barbados" },
                    { new Guid("11c41f2e-3afb-4565-b500-10538253455c"), "SL", "Sierra Leone" },
                    { new Guid("138f5c4e-fbd5-4dde-8ff3-0a54883a0f25"), "BG", "Bulgaria" },
                    { new Guid("14741fee-eefc-4faa-8ed0-d84b43fa7ceb"), "MT", "Malta" },
                    { new Guid("148bd731-2c0d-4d59-a3e7-71cb6300b944"), "JP", "Japan" },
                    { new Guid("1529e974-589d-43d7-91f3-21a842cd49bc"), "IN", "India" },
                    { new Guid("15f0b79b-7351-458b-8018-248f840d6b20"), "DZ", "Algeria" },
                    { new Guid("164865ed-98fb-44f6-b1d6-003ad08ed1a2"), "MC", "Monaco" },
                    { new Guid("16605065-7181-4cfe-983e-b51f2c02487d"), "ML", "Mali" },
                    { new Guid("16a8bb9f-a780-454a-80ee-fc09e3f1e337"), "NE", "Niger" },
                    { new Guid("174c9ef4-e7ab-4d08-b0d8-c55ffe9e47a3"), "MV", "Maldives" },
                    { new Guid("17557e8f-abb5-4252-9303-17aea8d7f9f9"), "YE", "Yemen" },
                    { new Guid("18540598-4956-4dab-b2b3-69581333f3c0"), "CH", "Switzerland" },
                    { new Guid("192c73f9-35ca-4cf4-8661-c58dad8a0b93"), "GB", "United Kingdom" },
                    { new Guid("195c9e25-11ba-47a4-8715-2b2dd1d9057d"), "BD", "Bangladesh" },
                    { new Guid("1a3d210c-3e54-4905-85f9-8566132c493c"), "MM", "Myanmar" },
                    { new Guid("1bf7ea6a-fccb-4341-b8ce-ee107981e426"), "GA", "Gabon" },
                    { new Guid("1c3979f7-f48d-45e2-9594-ffc259ead5f8"), "GT", "Guatemala" },
                    { new Guid("1ced3173-937e-4a2b-8a21-24e3e6246608"), "SV", "El Salvador" },
                    { new Guid("1cf1c4eb-72e7-4464-bc68-6cd006a7f8ed"), "ZW", "Zimbabwe" },
                    { new Guid("222814eb-b5a1-4226-beb4-52d61baf931e"), "PG", "Papua New Guinea" },
                    { new Guid("22e879c5-23fe-4ee3-bbff-af2e2e025a7a"), "LK", "Sri Lanka" },
                    { new Guid("24e614b0-d9ab-44dc-805d-5dfbe8bc5c66"), "VA", "Vatican City" },
                    { new Guid("2764b0c3-2817-4afe-8540-2f3b9bc89698"), "AE", "United Arab Emirates" },
                    { new Guid("2a3a652c-cbb8-4dca-93de-7cadccdb1d7f"), "UY", "Uruguay" },
                    { new Guid("2b4a3835-0961-4249-ae12-1180d323af14"), "EE", "Estonia" },
                    { new Guid("2cd0fa17-f971-4568-b7fb-42e41920d494"), "LT", "Lithuania" },
                    { new Guid("2eb2fb7d-882f-47f6-b2b3-3c889af48db5"), "FR", "France" },
                    { new Guid("30d39c1f-f1d7-45b6-bd56-61826c0a27f3"), "SO", "Somalia" },
                    { new Guid("30fe27c5-a2e0-4439-9d4f-54063f7d29e1"), "NP", "Nepal" },
                    { new Guid("3290885f-b68e-4436-96cb-9b3cccdf4e53"), "PS", "Palestine" },
                    { new Guid("32ae764d-3d18-4e1d-a043-5c1e26fc5e6f"), "VN", "Vietnam" },
                    { new Guid("34df2be5-a0f0-4281-a7f3-38488d20c870"), "PL", "Poland" },
                    { new Guid("3533679b-0701-4458-bbae-bb406c83f750"), "AT", "Austria" },
                    { new Guid("35cad6a5-0e66-4a14-8b21-c584bd64612b"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("35f7577f-33e3-4599-a03d-bb590a2e4bd4"), "BH", "Bahrain" },
                    { new Guid("3634b41f-75c5-411e-af59-64a3bff4264d"), "GW", "Guinea-Bissau" },
                    { new Guid("37563ff2-0e3a-4648-971e-1614b4d6df1f"), "IS", "Iceland" },
                    { new Guid("3765d8e4-8267-4621-9aec-c249b54aa646"), "IT", "Italy" },
                    { new Guid("39f792e5-1f06-4042-9605-9cd6025e67bd"), "US", "United States of America" },
                    { new Guid("3b72bf62-b857-4628-8d2e-af4630963b43"), "UZ", "Uzbekistan" },
                    { new Guid("3ba7ca05-4e93-49e4-a6b5-1d954e144650"), "MZ", "Mozambique" },
                    { new Guid("3bbe9151-baa1-4b69-855c-783ecd5525ea"), "RS", "Serbia" },
                    { new Guid("3c63a9f6-bfb3-4873-baac-f548716b5a39"), "ER", "Eritrea" },
                    { new Guid("3c932ed6-6c6c-4fe1-8fb4-c5decb18e148"), "GH", "Ghana" },
                    { new Guid("3d30826c-9f76-4413-8f41-f5e7535e0788"), "AM", "Armenia" },
                    { new Guid("3d38ce12-ba82-44c1-9389-e2a29455c8bb"), "JO", "Jordan" },
                    { new Guid("3dba0def-99f8-42a6-8e40-fa007feca127"), "HU", "Hungary" },
                    { new Guid("3dce028c-ee8d-48e4-9421-eb516b42296d"), "SD", "Sudan" },
                    { new Guid("3ec191ce-4f89-45f0-b0e9-3095d66bb32f"), "PT", "Portugal" },
                    { new Guid("3ef879a9-1ff0-474d-b9f1-df8a2f385d8c"), "MD", "Moldova" },
                    { new Guid("41398e89-d1a5-4a7c-b715-b7f257fa37ba"), "LB", "Lebanon" },
                    { new Guid("4221a12d-4c7d-4545-ae25-b836c8f0b0bc"), "ID", "Indonesia" },
                    { new Guid("430666fe-5763-4b9f-bdab-78d71348b37a"), "MY", "Malaysia" },
                    { new Guid("47356710-4eaf-4c44-adbf-de9b29d32d74"), "CN", "China" },
                    { new Guid("474017da-9b99-45cd-aa30-a45b0c402391"), "CM", "Cameroon" },
                    { new Guid("481dfe3a-42f1-4137-9e61-f2b4b52e910c"), "BI", "Burundi" },
                    { new Guid("496779aa-8fcf-4192-9bdd-4bc95d34b7db"), "SM", "San Marino" },
                    { new Guid("49d74ef7-1452-4e5e-a8d5-6a45b0c3b37a"), "HT", "Haiti" },
                    { new Guid("4a752a83-07dc-4fc7-b33a-11c6c3e9011a"), "EC", "Ecuador" },
                    { new Guid("4a778691-816e-443b-ae5c-84a7c5e747d9"), "DM", "Dominica" },
                    { new Guid("4d33bc44-339c-4d43-a1ce-ed4758ee9952"), "AU", "Australia" },
                    { new Guid("4e5e1e62-cf1a-4501-b632-fdbf69f79237"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("537c1db8-b38d-49d9-874f-96aeb57d6c50"), "TH", "Thailand" },
                    { new Guid("545ab6c5-0930-4099-8f1f-bf5e52fa0274"), "DE", "Germany" },
                    { new Guid("5479f3fc-4df9-4e22-88f9-89b298860959"), "TZ", "Tanzania" },
                    { new Guid("56b1e71d-a6a9-4250-9768-09a218f7441b"), "NZ", "New Zealand" },
                    { new Guid("56fa0021-2705-4d0f-9a42-e023bc17f1dc"), "AF", "Afghanistan" },
                    { new Guid("5887fd86-3d86-4ea9-ac79-602692c9d251"), "TO", "Tonga" },
                    { new Guid("595242fa-81fb-4bb2-a19c-11c1e519c569"), "BJ", "Benin" },
                    { new Guid("599c2dde-dc51-4160-956e-21539a2ad6b8"), "SI", "Slovenia" },
                    { new Guid("5f03d52d-0372-4c5d-a3c3-2e06df6a8a07"), "PK", "Pakistan" },
                    { new Guid("5fb0b710-65c8-4015-b285-7c8844471c8c"), "VU", "Vanuatu" },
                    { new Guid("6289d8a0-3124-4b7e-bcca-6ec8b5862077"), "BS", "Bahamas" },
                    { new Guid("629a5ca5-cb4d-44e6-b04b-875d69b865d4"), "IE", "Ireland" },
                    { new Guid("62a7a4e3-0f1e-4af6-ad17-34d519b0b0f0"), "SY", "Syria" },
                    { new Guid("62dbd864-1bbc-46de-8165-39dd0e80d8b9"), "BF", "Burkina Faso" },
                    { new Guid("637faf45-0512-408a-ba2f-ac832750f87b"), "OM", "Oman" },
                    { new Guid("6400d6e4-c582-4b84-b4d5-55eb25666144"), "LY", "Libya" },
                    { new Guid("698519ce-9675-490a-8172-5c08844a03f4"), "DO", "Dominican Republic" },
                    { new Guid("69d3138a-1141-4e60-ab1a-6192f1ed4240"), "LI", "Liechtenstein" },
                    { new Guid("69db1776-b799-47de-a75f-aed055ad892a"), "JM", "Jamaica" },
                    { new Guid("6ad317d9-acaf-4609-9d92-42c9c672b186"), "SR", "Suriname" },
                    { new Guid("6ae8ed11-5dea-4af5-978d-547133cb704d"), "NL", "Netherlands" },
                    { new Guid("6b58ff3a-3fcd-4df5-a59a-e0c65def2a15"), "CR", "Costa Rica" },
                    { new Guid("6bb7a5e2-6708-4d55-ac62-f5b614fc3000"), "NO", "Norway" },
                    { new Guid("6d2c10cf-db7a-45d2-bf72-88762ea205b9"), "MH", "Marshall Islands" },
                    { new Guid("6da882f3-942e-4cc3-b8bb-683b60d34c05"), "CY", "Cyprus" },
                    { new Guid("6e3b65f0-ec50-4c5c-8f4a-841a3e1229d1"), "SA", "Saudi Arabia" },
                    { new Guid("6ee91291-2bf9-46f9-8a48-0952493ce2ee"), "TR", "Turkey" },
                    { new Guid("7130107a-2f1b-4150-91ca-d37e6573fc0d"), "ET", "Ethiopia" },
                    { new Guid("7191c31e-14c8-41f2-9454-7cfd48691dca"), "NA", "Namibia" },
                    { new Guid("72217836-88e6-45f0-9d29-aca4b18669e8"), "FI", "Finland" },
                    { new Guid("741023dc-8f1b-41f8-b042-df41369ebbd4"), "VA", "Holy See" },
                    { new Guid("74a89a0f-44ff-467b-a1c6-c9019b1fa3e4"), "ZM", "Zambia" },
                    { new Guid("75433732-362f-4b3e-bb2a-d8bdadceb961"), "IR", "Iran" },
                    { new Guid("79bff4d1-b663-4ac6-b4ac-bfe0a61072df"), "TD", "Chad" },
                    { new Guid("7da0fda9-9efe-452d-8758-e9032f3fb07a"), "TT", "Trinidad and Tobago" },
                    { new Guid("803b140c-01d1-4fbb-8aab-90203392bdee"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("82c49a83-3e1e-4ebf-9445-2a8496321b87"), "KI", "Kiribati" },
                    { new Guid("849efc01-113c-4f8a-bc52-719d3c9362f5"), "SS", "South Sudan" },
                    { new Guid("859b5b1a-72f0-415c-a320-fb29ffc0d359"), "CA", "Canada" },
                    { new Guid("88198bb5-c784-4287-9a04-22f55d04c972"), "BO", "Bolivia" },
                    { new Guid("8857d6e9-a70e-488c-a471-3eed0ad6968e"), "RO", "Romania" },
                    { new Guid("8880278e-b051-49f2-8c78-bd73ea610e2d"), "KW", "Kuwait" },
                    { new Guid("88be5c0c-951d-4b3a-8d30-1c9e3d2da037"), "BW", "Botswana" },
                    { new Guid("8a2c647f-f216-4937-b75b-6d1355653da0"), "BT", "Bhutan" },
                    { new Guid("8b5887b7-f003-4c39-aad8-83165f3ea13e"), "SG", "Singapore" },
                    { new Guid("8b6611b6-2411-4d64-bd1d-bdf9adc56f96"), "SZ", "Eswatini" },
                    { new Guid("8eaa1fa5-adaf-43c6-8453-185610fb3a15"), "SN", "Senegal" },
                    { new Guid("8f1d0024-9d78-452a-b741-21add21cde86"), "KP", "North Korea" },
                    { new Guid("8f6ea078-d5f0-4a8d-b0f3-3ddabfe59b9e"), "QA", "Qatar" },
                    { new Guid("92f3b7e5-d874-49b7-922d-6b6e00b683b0"), "PW", "Palau" },
                    { new Guid("953249fc-17ae-4eb7-80f7-98a9b56dfab5"), "NR", "Nauru" },
                    { new Guid("97b89d32-bcdc-4d27-9cbc-2ff7bd98d5cb"), "GY", "Guyana" },
                    { new Guid("993bc1c5-5b5e-4fc1-8feb-62e10639ff55"), "AO", "Angola" },
                    { new Guid("9a756351-8e09-4391-953e-3576d46cb8c8"), "TG", "Togo" },
                    { new Guid("9bae68a8-3ddb-44d4-aa13-f6e98139d251"), "VE", "Venezuela" },
                    { new Guid("9e1d632d-ff36-4935-8e03-cecaafbc6a50"), "UA", "Ukraine" },
                    { new Guid("9eee9a50-e009-4882-9be8-bcb524f2df0c"), "SE", "Sweden" },
                    { new Guid("a033aa47-fbf5-45da-9367-ea06ef348c62"), "LU", "Luxembourg" },
                    { new Guid("a125f5af-3b89-4c36-a389-557eff868631"), "SK", "Slovakia" },
                    { new Guid("a1cd49bd-8f3a-4a11-8295-75565ddde180"), "CF", "Central African Republic" },
                    { new Guid("a270f2e7-e19f-4834-bf8e-01a3df8ad7ff"), "KM", "Comoros" },
                    { new Guid("a356a2e6-6946-430d-9455-082d3b69854d"), "DK", "Denmark" },
                    { new Guid("a38124bf-5431-4cd3-b6df-f94afc9c47b6"), "SB", "Solomon Islands" },
                    { new Guid("a5f115b6-2e47-4bf1-89f4-e2b337445ff7"), "TM", "Turkmenistan" },
                    { new Guid("a6793ce0-0c37-48f1-ae93-fb8e57eaf4d5"), "IL", "Israel" },
                    { new Guid("a8d132f4-49b7-4392-a36b-93be299a5240"), "MA", "Morocco" },
                    { new Guid("ad87c332-e7cb-4bc1-8356-21d5a68e98b4"), "EG", "Egypt" },
                    { new Guid("af6c4409-05ed-4151-8c52-875ec9ee536a"), "BZ", "Belize" },
                    { new Guid("b084608e-df46-4f0d-a9db-53a8e683ba4b"), "HR", "Croatia" },
                    { new Guid("b0b1a7f1-9a11-489b-84a3-7d215ffde813"), "MX", "Mexico" },
                    { new Guid("b18bca68-95f3-4944-874d-d4b37284208a"), "TL", "Timor-Leste" },
                    { new Guid("b23a87bc-24f6-49c9-8a9a-12a64bc371ca"), "FJ", "Fiji" },
                    { new Guid("b4610657-f449-4bf7-9c8a-284221c2af41"), "NI", "Nicaragua" },
                    { new Guid("b4805d94-50b2-466e-8455-d234d498b0c2"), "MN", "Mongolia" },
                    { new Guid("b4f01db7-676b-4ce1-a06a-0bd67a8ad6de"), "ME", "Montenegro" },
                    { new Guid("b60b78f8-8fd5-43df-b49a-c6310919057d"), "GD", "Grenada" },
                    { new Guid("b740fddb-bb89-4498-8de9-9c986082f2f0"), "TJ", "Tajikistan" },
                    { new Guid("bb8be9b3-db6a-4fb5-a712-6b5d1de762f1"), "RU", "Russia" },
                    { new Guid("bc665db1-9164-46f7-b453-b89779fb3f26"), "RW", "Rwanda" },
                    { new Guid("c646aafc-92b7-4c87-8a82-2b2cc4802d4d"), "AD", "Andorra" },
                    { new Guid("ca1dbe9a-647b-4839-9e4b-87482924ccc0"), "GN", "Guinea" },
                    { new Guid("ca2ad41f-65a5-46d8-9264-d50223e9ca52"), "CU", "Cuba" },
                    { new Guid("cb7f88d0-570b-4bcf-aa72-b7452c010b60"), "PA", "Panama" },
                    { new Guid("cbdc3d74-3c53-47a0-b23e-0bffd0f6f136"), "BY", "Belarus" },
                    { new Guid("cd6cd2c3-0493-45a7-9a96-74ba21762f4c"), "CL", "Chile" },
                    { new Guid("ce97869e-9028-499a-be98-da7cf21fe595"), "KH", "Cambodia" },
                    { new Guid("d0356873-685f-456f-aba4-0ce59ce89a5e"), "LC", "Saint Lucia" },
                    { new Guid("d1003ea4-cd8e-4803-9b72-5bd73b12d0da"), "CV", "Cabo Verde" },
                    { new Guid("d542f409-898c-4d4e-b85c-505429cae765"), "GR", "Greece" },
                    { new Guid("d54e44bf-36d8-41b2-a840-e11e86866a0c"), "AR", "Argentina" },
                    { new Guid("d5ca7c77-1232-4f01-ada4-a30feabab9bb"), "LV", "Latvia" },
                    { new Guid("d881e8ad-e603-4fbb-ac69-638ac6770345"), "MK", "North Macedonia" },
                    { new Guid("da938431-1bbb-4358-a880-6792a297902d"), "NG", "Nigeria" },
                    { new Guid("db7d67a1-2b35-41b7-95aa-6f7f8ac1f13c"), "KZ", "Kazakhstan" },
                    { new Guid("dc95c988-3281-4af6-8c3f-9b81a6c9ed57"), "LR", "Liberia" },
                    { new Guid("dd7069ef-5c40-4096-9e74-faae8c169c45"), "GQ", "Equatorial Guinea" },
                    { new Guid("dd7ff212-d859-4d87-93e3-e0088f0a0c7e"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("de7f363f-123f-4a08-9b97-e7216bbe4358"), "PY", "Paraguay" },
                    { new Guid("deebdfce-ea25-4d5a-a50f-d188dfcb05c4"), "PE", "Peru" },
                    { new Guid("df8add1e-5f61-4b11-9cd6-d2eff51d5226"), "GE", "Georgia" },
                    { new Guid("e1361f53-1791-434c-85ca-2c1fea1ef282"), "PH", "Philippines" },
                    { new Guid("e16574fc-036d-44a0-a9cd-24e8535e6f27"), "MG", "Madagascar" },
                    { new Guid("e28aac77-6178-4084-9b53-95c66a7b3a31"), "BR", "Brazil" },
                    { new Guid("e4240aa2-69d2-4c8a-86c2-a280fd34073a"), "BE", "Belgium" },
                    { new Guid("e52a4fb9-9493-4f86-a5a3-cbd87207aefb"), "TV", "Tuvalu" },
                    { new Guid("e99e6c9e-1fd8-4e26-ac96-045b610abd56"), "HN", "Honduras" },
                    { new Guid("eabdf0f2-0f7a-44fa-bc3b-7b71e7c8be0f"), "KE", "Kenya" },
                    { new Guid("ee106a15-79bf-4e55-bb1b-8797880b6a4a"), "MU", "Mauritius" },
                    { new Guid("f0e3d6db-05bb-41ca-b31b-d7d1eede6e34"), "LS", "Lesotho" },
                    { new Guid("f2588ea3-a2a1-4150-8a19-72e9f1fdf257"), "AL", "Albania" },
                    { new Guid("f36adaac-ee8c-4659-a75a-2b60bcb5a65f"), "ES", "Spain" },
                    { new Guid("f4813003-d79d-4049-8b34-162c307a2152"), "ZA", "South Africa" },
                    { new Guid("f560dff2-471a-4e78-8c1e-7635200f0d2f"), "TN", "Tunisia" },
                    { new Guid("f5e3c239-b365-4008-b9fc-3e2fdecb947c"), "IQ", "Iraq" },
                    { new Guid("f695f193-b12f-49df-991c-6bd2a99ff9f7"), "MR", "Mauritania" },
                    { new Guid("fbf6252c-9c16-47ce-a481-e9f9f2995052"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("fde81b3b-9d08-41f6-8515-4859c551b7bc"), "SC", "Seychelles" },
                    { new Guid("fe431ce5-ff9b-4346-b37a-f21387a4730a"), "DJ", "Djibouti" },
                    { new Guid("fefb7c79-6b2f-4596-a551-d4737bc6d2f2"), "FM", "Micronesia" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("69d8ac97-5f41-45f1-9a4b-5bc8c295f5f5"), "Female" },
                    { new Guid("9e0d5a9d-f309-42c0-b28c-7e0894872a76"), "Male" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0328baa7-e6b7-44fa-b860-8d1c6e04fa28"), "Therapeutic Interventions" },
                    { new Guid("0bb78d20-b2ea-4f1e-bbee-6d16c59868f1"), "Preventive Interventions" },
                    { new Guid("236031c5-8e8d-4c1a-8325-29935d5e5343"), "Diagnostic Interventions" },
                    { new Guid("2e63b0da-2414-457d-9776-6c742c24edef"), "Exotic and Specialized Interventions" },
                    { new Guid("434223c4-92f3-4814-9332-b8ed02cc0333"), "Emergency" },
                    { new Guid("4a40036d-f0e8-4660-8ac1-e78a57243587"), "Oncological Interventions" },
                    { new Guid("54223189-1619-4fe4-97a6-5bd9f6150b42"), "Dental Interventions" },
                    { new Guid("834fce2c-c900-40ba-9401-a65d8a0e8477"), "Surgical Interventions" },
                    { new Guid("eed0abdb-4769-4c23-bf3b-8a4c3915a990"), "Obstetric and Reproductive Interventions" },
                    { new Guid("fec5534e-5769-4172-a9da-c52e016587e1"), "Postoperative Care" }
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
