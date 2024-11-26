using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixPKAspNetUSerTokensName4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");


            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPet_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserPet");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPet_Pets_PetId",
                table: "ApplicationUserPet");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorBookings_Bookings_BookingId",
                table: "DoctorBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserPet",
                table: "ApplicationUserPet");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00b4f6f3-ceee-4ad5-bb7f-3dfdd873b7a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02195124-54ea-4b29-85ec-325545cc91c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02e2caca-cd31-4e54-8692-151dcf93c7b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04c4b78d-7d54-4dfe-8672-036777c79271"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04ca313b-9d26-4d5b-b3b7-68d9a87061bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06a3868c-c8dc-4849-8781-4d4e850a22c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06d6f964-3ae0-4889-b905-633ede8ab60a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("09175d65-aca8-4ebb-a4b7-dd8442b47e03"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0966427c-e239-43b1-9c94-deed2a8bc708"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a11bd07-3717-46af-9d74-ebbe8d58ad47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0aadbd12-2c3a-4d1b-8fb4-9fa85d3ec43f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0df1d424-34cb-4d2d-81b6-f8d889f0395d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0fb8f43f-3b5c-4c0a-9779-fef6e6ffe65f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0fe4bee7-e3f5-4b5c-84d9-48a900c6d2b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("118376bf-4ce6-4afd-888b-0b0e2e607323"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1228ecba-91f8-425a-87d1-9aa0231f5538"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12b4ac84-19c6-49ce-aae3-11d0b2b2ef6e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1410fee4-edbe-4fa5-9f56-fa4d4eb8a387"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("178a2ce7-7dcd-4671-bc38-368fd31dba3f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19f89c1c-7215-495c-b6a6-f723dfbaec70"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a07e66f-13a3-4a79-a77b-6167d0c30221"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1aa677a1-9501-4b1e-aeb3-817bf7b969bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1da20df5-ccb9-4e5a-bd39-8a3154ad5b18"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1da80bc4-16ee-4a03-84f4-d045bb394cbc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("217499ca-4b1c-4f40-892c-96094042d574"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("22ef3f2e-e90d-47e8-85f9-537b8ed5e7f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23024fce-7538-46fe-81dc-677cd3cccf49"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24044db5-428f-49b9-ab94-c180cc291113"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26712ae4-2c06-42b8-a826-10d46008a53f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26a7e230-93bb-4feb-8d92-c43949660917"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26c25263-3520-44a1-864d-7ecaab7f3375"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26f2de4f-b200-499b-9120-caa325b5e79b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2780fbd3-6cb0-4e55-a111-f9481ad160c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27b89f5a-620b-4b39-a7a7-9cb4f7cb54d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29348c4e-37b7-47a1-8196-fe7913b5de43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ac2678e-3ce9-459e-9c98-b93514c06d07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d477deb-fec1-4353-8b24-16c0f134954d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d9078f2-35df-49f8-8195-228ddfd4ae42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f8b1b13-ca44-4191-9ff0-600627c2532d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("306ff630-56e0-4305-8234-82f52c1572aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30930852-86ec-4489-b021-8c2842322539"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30b54065-1fb0-427b-94d1-c69b3840d70c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("314aac3b-f0fe-4b73-a330-3d72058f4c4f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32773020-6d12-43e9-9793-58ab35386bf5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3414c610-5493-4b74-9a55-9dc24f73fc14"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("362210b0-7af3-427d-8452-369ec3855a92"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("380413b5-6ff4-4e67-817f-ec287a36adb7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3831392d-513d-4fe2-8a9b-777458aafe67"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("397b0e80-eeb1-47c3-bdd0-1ede9331758e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c5096db-3173-42dd-af93-b12b2c8dadcf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3cb1595a-2e56-4683-94b5-3fcda7771be9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3cf083cd-28bd-4929-bd0e-5f315d75d1e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e89414b-8c8d-4606-8560-1801ba80a418"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3feb4193-4f5b-4c9f-9060-dfe6b4d37ac7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("400deecd-0e10-4d28-972b-345625fb5b0e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43dd8bec-a151-49d2-9e8a-148acd965569"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("44e34932-3055-47fa-8594-b07e20afcd99"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45440c27-edc4-4b0b-96fc-8fe0546d8da2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46f23381-7ef2-41c8-9cca-4a69b120fcb1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46f839d1-f571-413c-9114-58c9b8f51f9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47756479-7590-4096-92b7-f7561cc91cac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4990102b-3207-4595-b0ed-b6544983eaaa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b5c8aea-c714-46aa-ae35-9ff004495610"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f2b11ea-0027-471a-86f6-392acb41803a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5203e4fe-7029-42b0-b752-ca016679a5b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("551c0672-001e-487e-a5d7-9c1bd5c24ffa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56493af5-f818-4868-bb62-53cbd4152a6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("569c43b5-e6ba-497b-8e49-18e03bc2429f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5789c0d0-caf5-4448-be11-833a9a3c9c2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5aa8add0-5635-4bb4-b6a4-ec0b9e640123"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c52f8c5-57f1-470b-9a66-ae91063be25b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e0fe1ba-902a-4ed7-b418-399b06600c0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fb190a6-30e1-48ff-9f6b-a6c177ce64c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fcbe5e2-a213-43e0-9317-521facc9c0cf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60fd7e93-6c69-4ab3-b6c9-c5ab95d6f147"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("621370c7-b507-40ce-a78a-01709371d905"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63a5c340-c1df-4b02-b236-d8acb610d3b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63e9f890-fcce-4a35-95c2-4fcb8c752db4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640f8b16-e1d5-4baa-bfc3-d1244df93689"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6481f682-b0d9-4eca-bebc-6241fdd7b694"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("68146c3e-caa8-49a2-b9b8-b105277da81b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69d39c22-a938-4780-8360-47d3d934fccc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6c961ea6-fefe-4d56-86b9-303b8c31da13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6d0849c7-d9ea-46fd-8184-807bc89d157a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6d315aab-653d-49ec-82ba-4256632b00e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6d419b58-058f-4ce7-b77a-a594ba83e50d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6d5d08a9-d52a-4c37-b92c-bdf111da8722"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6d646dca-6def-45ee-86f2-a66c630db785"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f524d83-6c56-45a0-a3d2-d23cd0944263"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70b5208b-5b4b-4563-beaf-b7b827935494"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71c6108a-6e6e-483d-8b76-a4fe4b0d22d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72783edb-b5b4-43c4-943a-b7584fcd5ae6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("731c99df-2d4b-414e-a514-114c582b08e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78ad5942-e86c-456e-8420-8a4bba7afb82"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78eddda0-d4f0-4e8a-9c5a-128852acede4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7912b508-e0e2-43ae-a5f9-68add7b62912"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b5a3ea0-07f9-4eef-9a5d-27e6bbc164b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b6336d1-714d-41f7-9101-b1536a4c9653"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ea5ed88-1ccf-4758-b612-86f898b53cc5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7fa39f71-87f6-4d81-b86e-c60683516062"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("802df591-da6e-49bc-a22b-86ee751c5d7b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80d6ae79-3c6a-4965-8c3b-fb5819f6b3c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81b6fe8b-8c70-4d8e-b733-de252448d03e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("827cd30f-5959-49e6-8384-5bd9173045d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("853d0bca-333f-4f07-8808-8dcc00e625a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8581f65d-ce2a-4bc9-82aa-60baafb15386"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85c4f086-4227-4df4-ba9f-76f1718e9172"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87cacd33-6b83-4650-8860-747e80172886"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8cab9da3-827b-4735-af75-d95f7d13a575"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d06de32-c10b-4d60-baec-f83620ffc055"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e51c5eb-8ddf-4585-ba34-f50333242891"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91604462-37cb-465f-ae1b-591532854ce6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91b94077-197d-41a9-91d8-991b8e898911"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93b6d581-8a0d-4b09-874b-07f86f3ab48a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("94a49ccf-8168-4d8a-8ac0-6412a1de66cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98fa1319-0ffb-402b-b429-afcd750a35a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a19488e-81d0-48a0-affa-d1edca515c2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a870d65-4937-4584-a886-97f5784ab231"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b39e866-ad81-4787-a783-25d415525655"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c2b28ca-3818-4269-9e16-6648bbe42a4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9da59233-c49f-4d88-a47a-64b05834274f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2149d36-9dc8-48d2-907f-062627abaf82"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a30ed16a-3a7a-4f27-824f-396ff86db85c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a42c93ad-09e1-4b70-8ff4-0671d284fcc7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a45e578a-a39e-44dd-aa6b-358d08f353b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a46533fd-0a31-439e-bffd-5ea8f4d98698"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a6796e79-6cc8-4158-9099-0a12c7e32743"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a80882ef-2480-41b3-9c3a-e33481e847d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ab029d6c-deda-4faa-a353-8e01244d3fd2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ab30ae68-7155-41ce-b8fd-7b7f5706015f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("abc3773a-6749-4631-a5eb-453b3d877d45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae0731d0-3f98-4d5b-af76-be6da02a1b04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b004d825-e39c-4163-9c45-b2c46902dc40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b05d54d1-8246-4d87-aa69-3f000255e037"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b12b2666-0e62-4906-af2f-2fc714f33ea3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b17eb8a2-60e5-40a3-aa20-49d452d2917b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b41b015c-e4df-4eca-90bc-94c297e3bb9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b438715a-99f2-4ee3-916f-7bf5c84a1062"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b62f3821-fbc7-4fd0-9910-a600870abfd6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b761af04-2aeb-465b-a296-20533bdcdc6e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b996324a-44ef-4fe7-bc61-46758d8f392c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b9bcb402-ee5b-4b86-bb98-6ad83dd0173b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc04d34d-496b-4da0-b959-6d5bcf50ff10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf7dffd5-ca6a-4e7d-92f2-f2540104b729"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bfe0c77a-2196-418d-80e8-589a6106991a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0046155-b993-40c4-97ea-72498a604dd2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c284b9a7-7cdc-4c85-93fe-2de8b3d29ab6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3927daf-dba2-4a41-aef8-6271027aceda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3dc0f54-a182-4525-b7ad-795a76382bfa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c422741f-1089-4df0-acdd-ce5e393b29e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c58f210b-5d21-4e01-83bc-4e6f63b7cb1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5ec3d88-be39-41fb-9c8d-982020a63cd2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c66fad34-4f0d-4060-bc29-7c237bbdb0cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7ee220d-7291-449d-a99c-db9e7a475a6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cab15b7c-1e6e-4c69-827e-ce23398819d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce6ce431-bd69-44a5-9dc8-cdfad14ee5f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1139ebe-6c7e-439a-a1bc-fe6e1f3258d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1b7c637-e1f5-4bb5-8087-e38a06efb3d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d2284249-a46a-4aa9-ad88-5aef4be17e91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d2500a12-22e4-42be-9704-08a76ce7acb4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3e94d1f-1c92-456c-9f79-45314262f2d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d4140024-a8e9-4453-b617-7baa68dd53af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d4ed9f5d-e296-401c-bc7d-8eba7dc6d6eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6cc532c-3815-4c7c-9df2-405d6f8ab740"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d70dbe9e-b423-433c-9bae-24a296ce1b4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7166be7-eefc-48d1-8e1e-09532c242714"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d877fd7f-800d-4799-8541-dd8030d65161"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc756d14-697e-4f91-9c69-cda74b272fd7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0b3ff19-bcbd-4b0d-a8f7-aa357e96c28d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e3385935-141a-49af-b63c-46bf6ea80978"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4187873-bdaa-4366-9f5a-0e552611fcc2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e419745a-57f5-430f-a98e-15fa3ce9e044"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4a0bcf2-cc1e-480c-b9af-9f675acffc9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e53d8d0c-7a86-4950-bae2-b07eff5fbe52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e570dcfe-9860-4526-a7d7-d1eddec99b7e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6f28481-0a75-42c2-9202-82d5f20cafaa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8521bec-273d-473a-9528-b69bd0b4a9be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec218713-f9c6-42a8-8421-45e2807b7259"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed62b74a-d457-4c19-b0e5-c09f3f684a6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee1c1faa-3bd9-44e5-bc82-ca90843efa7d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee477f30-d41d-47fe-943e-896a6c3fe562"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee9e5703-783a-4f5e-90da-f8a2c27d7b4d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef975c6a-577d-433d-a6d2-86389d7ac7fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1b14328-9368-46ad-a420-46cfdf9fa5db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2078abe-60da-4617-8ca4-ec2342ae313e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f34a26d6-5e97-4eb9-9668-7e22deeb7fac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3e2d14e-4190-4e12-a9d0-133b2a8e40ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f7d37ac3-e5b6-4df3-bc3d-a64846d2426e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f88f81f3-7ebb-45eb-9827-bb5379679a1d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f8dfe5e0-7f64-4ef1-be61-5ca0a16aca47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc34d555-a51f-4357-81c3-23e550004d53"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd63047e-e280-498a-ad35-865a4f8d452e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("feea4bc1-fba1-4df6-a437-2dc9b9af412e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ffa3fed0-1757-4e4d-975d-e537c28d1646"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("2d540796-0858-40c7-9420-32a3b3635c48"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("cbab8113-b87f-473d-91d0-2a43a6419f04"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("2652850a-2345-4e9c-9de1-3b102ee21ddd"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("2d3125d1-2fcb-4ee0-aed1-601392bae72d"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3c879d79-53f0-4dab-8660-974685ddc674"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("81e0a02e-7b87-4280-9c0a-bb7941c8ed06"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("85f749b1-21cf-446a-b2f3-0f65a9c2fd9a"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("df520a79-d47e-4327-a914-153127e43d76"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("edd5f12c-d522-4934-a9b1-a57797db7495"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f4b18120-e730-4d2b-ab96-e62e462cb121"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("fbb999d5-e430-4ab5-950f-8f715f0ad6c0"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("ff821c3e-a78f-492a-ae9a-196917ddcc59"));

            migrationBuilder.RenameTable(
                name: "ApplicationUserPet",
                newName: "ApplicationUserPets");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserPet_PetId",
                table: "ApplicationUserPets",
                newName: "IX_ApplicationUserPets_PetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserPets",
                table: "ApplicationUserPets",
                columns: new[] { "ApplicationUserId", "PetId" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("016a26be-792f-4274-beb4-a5841de2d207"), "SZ", "Eswatini" },
                    { new Guid("01bdf992-cfb5-4943-b449-b8323789c940"), "KP", "North Korea" },
                    { new Guid("03943805-9412-491f-80e4-811a8a6555b5"), "LS", "Lesotho" },
                    { new Guid("0509ad46-e26b-4df6-b993-e149e4ce23f3"), "HR", "Croatia" },
                    { new Guid("059cdf04-7cdc-45b9-8ed7-25b709a6417d"), "MD", "Moldova" },
                    { new Guid("0657000b-37d4-4b90-a9c9-9702a2d01a7e"), "AR", "Argentina" },
                    { new Guid("07f53028-c85d-49cd-83b2-9b0994746358"), "GQ", "Equatorial Guinea" },
                    { new Guid("07f656ed-b881-4566-8a6d-72624051b6b2"), "SK", "Slovakia" },
                    { new Guid("0aaf80dd-3686-4e39-a535-829f611354ab"), "TZ", "Tanzania" },
                    { new Guid("0aba2559-3068-4858-ad3d-a2bfc9673fa9"), "HN", "Honduras" },
                    { new Guid("0bf729f2-b8a1-426b-931e-4018f5085487"), "BE", "Belgium" },
                    { new Guid("0c8a9712-ee07-4635-a0c8-9164c03f0c83"), "IN", "India" },
                    { new Guid("0cf77a92-750c-47d2-b23d-5d63b58d7228"), "ZA", "South Africa" },
                    { new Guid("0f0e43ee-7abe-40b3-98dd-30a7551f891a"), "KR", "South Korea" },
                    { new Guid("0f821deb-4aab-41ce-bcf1-58d2ce72cef8"), "LV", "Latvia" },
                    { new Guid("129e2e1f-36e9-48c0-9689-118a1adba5a7"), "NR", "Nauru" },
                    { new Guid("166fed2b-cbef-45a9-af47-9a44f3e1753a"), "AF", "Afghanistan" },
                    { new Guid("177be822-8a41-431e-b6bd-41f256a82934"), "LY", "Libya" },
                    { new Guid("17c85bd5-3dbc-4482-9f52-b87b0c4813b8"), "AG", "Antigua and Barbuda" },
                    { new Guid("1a8fe28b-1ae3-450d-90f9-98a368adc40a"), "SN", "Senegal" },
                    { new Guid("1b7982e3-5fa0-4a59-9e81-1cde486ce975"), "YE", "Yemen" },
                    { new Guid("21eec1e8-d7d0-4054-9c21-0ced7a0e7e81"), "FM", "Micronesia" },
                    { new Guid("225fa102-5bb3-4362-ad8a-05b4b056010b"), "BT", "Bhutan" },
                    { new Guid("22b6ab38-0628-4818-9435-6912e83139c6"), "IT", "Italy" },
                    { new Guid("23c381d6-e5f8-4b45-ad04-022b7257db69"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("23de2132-0532-414a-b93b-cf526f26819b"), "GR", "Greece" },
                    { new Guid("23fef78e-d37a-4d17-a87f-b2e2ab9da0df"), "ID", "Indonesia" },
                    { new Guid("251e03a5-852b-458d-b9c2-f32921636aec"), "MV", "Maldives" },
                    { new Guid("2630c28d-30d2-44c5-ab41-751374b9d7c6"), "SC", "Seychelles" },
                    { new Guid("279255c4-8700-47d4-a5f3-9de785c262ef"), "UA", "Ukraine" },
                    { new Guid("27b70873-341d-4931-aae5-422bc0717468"), "SE", "Sweden" },
                    { new Guid("28d022ec-9f07-49e5-95e1-09343d5c617d"), "DO", "Dominican Republic" },
                    { new Guid("29b02f2b-2956-4c22-9051-704dbf688393"), "FR", "France" },
                    { new Guid("29ea6f5a-940b-4e03-a8a2-ff25c3c893a1"), "BS", "Bahamas" },
                    { new Guid("2b1c259a-c706-4116-a5aa-80191202ac11"), "GD", "Grenada" },
                    { new Guid("2b42c2b7-c23c-42d9-b293-3e15b235948a"), "CR", "Costa Rica" },
                    { new Guid("2d1aacb5-d79f-4edd-b12d-bc2bb331d4db"), "NZ", "New Zealand" },
                    { new Guid("2f39eeb3-3698-4032-8a20-e3b5eb51f45b"), "LR", "Liberia" },
                    { new Guid("2fb67b6d-23ee-4be5-bb56-a135f60914ec"), "PL", "Poland" },
                    { new Guid("30337df0-d71e-4441-b700-617ed644d5fd"), "AU", "Australia" },
                    { new Guid("31405a7d-bbaa-4bad-afe5-33e6e6cf0a9b"), "ZM", "Zambia" },
                    { new Guid("32b772df-92f1-4612-bc46-68f528eb3f6e"), "NP", "Nepal" },
                    { new Guid("36d8f095-4a44-4598-b43e-0ac46b8d25df"), "CV", "Cabo Verde" },
                    { new Guid("373d516a-6597-4038-bf66-937387675678"), "VU", "Vanuatu" },
                    { new Guid("3bc3735e-bd8d-48ea-999a-0dbee2a31c2f"), "SA", "Saudi Arabia" },
                    { new Guid("3c9b61a7-9f15-4217-a605-f57c0a4b69ac"), "NL", "Netherlands" },
                    { new Guid("3ca7a621-448e-488d-ae5e-f8711ac41ff4"), "GH", "Ghana" },
                    { new Guid("3cf063e2-2ab7-421a-a00c-a4e3fccb803e"), "KE", "Kenya" },
                    { new Guid("3f70e670-f216-4903-baef-e759e4fd14d5"), "SD", "Sudan" },
                    { new Guid("401f7e76-8443-46f7-bbc9-84630303354e"), "CH", "Switzerland" },
                    { new Guid("40752f56-b6bf-4052-ba15-feee97e881f7"), "IR", "Iran" },
                    { new Guid("408ea540-0130-446b-bd32-c180704ef538"), "NA", "Namibia" },
                    { new Guid("40d743d9-da1e-4b5e-a288-2151e63007e4"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("40e56e7c-8956-4d98-abd6-803df3b1de2f"), "GM", "Gambia" },
                    { new Guid("4162c0f8-957e-484d-872b-3a4582b708ce"), "BF", "Burkina Faso" },
                    { new Guid("42d89aa4-f46f-407b-8d9f-ea974822405c"), "RU", "Russia" },
                    { new Guid("435a39c7-124e-41fc-a770-9eb8183c990a"), "GW", "Guinea-Bissau" },
                    { new Guid("43c9bfdb-804b-4ab7-bf6b-4d63e6985a52"), "MG", "Madagascar" },
                    { new Guid("45e7417b-47e3-4038-b1fe-ce9bdd302849"), "DK", "Denmark" },
                    { new Guid("4757488b-d1d1-410f-ab6b-cc882111466c"), "BD", "Bangladesh" },
                    { new Guid("49181935-4370-4a7b-8319-f29ccabe500f"), "GA", "Gabon" },
                    { new Guid("4927670b-2f0a-4db1-8d29-3fd0627ad3fb"), "MC", "Monaco" },
                    { new Guid("4bd480af-d24a-4375-8e98-5248ed06d405"), "LT", "Lithuania" },
                    { new Guid("4c5511a0-7029-49be-951c-2add5afa6480"), "FI", "Finland" },
                    { new Guid("4c6d8866-4a95-4a79-8a2b-e609b4f8c4e3"), "ES", "Spain" },
                    { new Guid("4da15f05-c684-490a-9c5f-94b2cc439858"), "TT", "Trinidad and Tobago" },
                    { new Guid("4edd98e5-bf4f-489b-b99f-a3b545e74f3e"), "VE", "Venezuela" },
                    { new Guid("4ef6a3f0-306c-46a0-bbad-911436df742d"), "US", "United States of America" },
                    { new Guid("524f1ac1-e7bb-43f1-b74e-936468fe59cd"), "KH", "Cambodia" },
                    { new Guid("5258c13e-0c9e-49db-bd9a-0f2e37810e0b"), "AO", "Angola" },
                    { new Guid("54cfcb90-93fe-4b16-8c63-1924bee7ed98"), "UY", "Uruguay" },
                    { new Guid("586446fa-c033-4542-8c07-9e7da17336e3"), "IS", "Iceland" },
                    { new Guid("59065848-ca22-4ebe-8869-7791d9f592de"), "JO", "Jordan" },
                    { new Guid("5b3d504c-6a05-40e4-b6ed-cdfc487b57ea"), "CO", "Colombia" },
                    { new Guid("5f8ed060-70bb-43f5-9426-ca1ca752b9df"), "SV", "El Salvador" },
                    { new Guid("5f915081-dad6-4769-8892-4aa67dffea25"), "MH", "Marshall Islands" },
                    { new Guid("6098f85e-96ca-4e74-aedb-c5997594e589"), "TN", "Tunisia" },
                    { new Guid("61a09170-344b-46f8-bac4-ab9f59318825"), "BJ", "Benin" },
                    { new Guid("6259f1ae-0ee0-4366-b112-52e74535e2e7"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("64962c69-f30f-4a82-8fb8-e5e02b71cff0"), "KI", "Kiribati" },
                    { new Guid("67e242ba-819a-478e-810b-39a07eb106d2"), "VN", "Vietnam" },
                    { new Guid("6aad9b20-73fb-4b9d-8e12-323282e08e4e"), "BH", "Bahrain" },
                    { new Guid("6b6a586f-f180-4422-ad10-e82f9a12e5a8"), "IE", "Ireland" },
                    { new Guid("6b6d80fe-ac4a-4db4-8aea-d6d14bedf076"), "PA", "Panama" },
                    { new Guid("6c250da3-3e6a-4363-b259-2e297b908f9a"), "LU", "Luxembourg" },
                    { new Guid("6e441267-3f7f-4aee-ac9c-a98a7383611a"), "SO", "Somalia" },
                    { new Guid("6fc1e372-9425-4c3b-bb13-2c0eb42d31ed"), "DZ", "Algeria" },
                    { new Guid("70ad4f11-4956-4923-ba4a-2243ab508411"), "LB", "Lebanon" },
                    { new Guid("71925c66-b98b-4037-83a7-8f6a7a7c2a64"), "GT", "Guatemala" },
                    { new Guid("72d12f58-98f2-4a2c-8494-8bfd17f9a695"), "PT", "Portugal" },
                    { new Guid("761573e0-39d6-41d1-ad7d-2c81ee651236"), "OM", "Oman" },
                    { new Guid("7744ccb4-b1ac-414b-a961-b0cb84bf66a5"), "VA", "Vatican City" },
                    { new Guid("77e3711c-21e3-4dc9-a5d9-d403e3eaf161"), "UG", "Uganda" },
                    { new Guid("7803c4ab-ecb1-4b22-ac95-4b2328ab7a59"), "BO", "Bolivia" },
                    { new Guid("78bac397-77e0-4a83-84b8-33f5a269d1ba"), "ZW", "Zimbabwe" },
                    { new Guid("7a537953-5db3-4b76-a012-da0e1ec6c736"), "AD", "Andorra" },
                    { new Guid("7b5402ca-04b1-4792-9080-0412b1d5e738"), "MA", "Morocco" },
                    { new Guid("7d290747-9b36-4b70-b8b0-170a2fe748c9"), "MK", "North Macedonia" },
                    { new Guid("7eee0788-3204-4621-9739-b8681412b24a"), "MM", "Myanmar" },
                    { new Guid("7f3480fd-cd5c-4a45-b02a-8aeb064b5c3b"), "TO", "Tonga" },
                    { new Guid("7fbf52c5-b2ad-486d-bf90-c49a31fdaf9c"), "CA", "Canada" },
                    { new Guid("8020d854-1f6d-4e25-bbd5-0fa658e03003"), "ST", "Sao Tome and Principe" },
                    { new Guid("840fb012-2ff0-4031-bfc8-c85e416c42a9"), "EE", "Estonia" },
                    { new Guid("847f5e31-1be9-41b2-9ee2-ac82b9ff9958"), "MW", "Malawi" },
                    { new Guid("847fbe8a-149e-4579-a413-d8c8b95b76d2"), "EG", "Egypt" },
                    { new Guid("85565d69-13eb-49dd-afc3-4195285b74c5"), "CM", "Cameroon" },
                    { new Guid("86209805-e805-40ba-a945-8e3e691042da"), "SY", "Syria" },
                    { new Guid("88c99207-db4e-4044-9231-8d95733af29b"), "CL", "Chile" },
                    { new Guid("89136ea2-7d62-49c8-97b5-a02de047076e"), "MX", "Mexico" },
                    { new Guid("89d7259a-ae9b-4aed-b651-6da747ca839d"), "NG", "Nigeria" },
                    { new Guid("89e29624-4cf3-4971-b962-d8fb36040c67"), "CN", "China" },
                    { new Guid("8cfe1e60-2a94-4d2c-b79a-71dfa9e11a01"), "NE", "Niger" },
                    { new Guid("8d5f6bc2-5bbf-49e2-aeff-af4ee37ae330"), "LI", "Liechtenstein" },
                    { new Guid("8da91921-39e1-432f-a425-9eedc450ee48"), "AE", "United Arab Emirates" },
                    { new Guid("90afd949-5af8-4ae5-a0aa-2da7eaafca0e"), "PH", "Philippines" },
                    { new Guid("9186d451-a4fe-4f7f-81ea-7d788b08cc73"), "BI", "Burundi" },
                    { new Guid("941cdb08-5152-4c10-9ce9-f22b8d385171"), "TG", "Togo" },
                    { new Guid("95457cd2-9a8f-4358-95f8-05bfd26059a6"), "SR", "Suriname" },
                    { new Guid("958d4bf3-de23-474a-929e-4a815c8ced4b"), "MN", "Mongolia" },
                    { new Guid("96971593-88d9-4230-b709-94fae0652ad5"), "VA", "Holy See" },
                    { new Guid("970d1ef8-f4e8-40ef-a797-24875e9a0e6c"), "SL", "Sierra Leone" },
                    { new Guid("97e0f007-8893-43ed-8844-a8a309a7aebd"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("9b926031-a0ca-40bf-b76c-c644901dd994"), "SG", "Singapore" },
                    { new Guid("9b9bd379-04d9-49b4-819b-fe2869d8f464"), "WS", "Samoa" },
                    { new Guid("9d7c6121-949e-42c4-b695-4a892d796750"), "GY", "Guyana" },
                    { new Guid("9d80487e-ed32-4abe-9c10-932d1e22a3ac"), "JP", "Japan" },
                    { new Guid("a217f48b-bdad-4404-afe0-2e24aad29445"), "TM", "Turkmenistan" },
                    { new Guid("a32218b3-119c-46b7-a4dd-d23b7347598b"), "RW", "Rwanda" },
                    { new Guid("a5ed07b4-96d7-4f6d-a8d3-e1fa78d50ac0"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("a8d51a89-b010-44e9-a66d-9f67c8dc68aa"), "TJ", "Tajikistan" },
                    { new Guid("a92caee6-13c0-4bd2-bda7-20b4ea51d291"), "UZ", "Uzbekistan" },
                    { new Guid("a9370a91-ce46-4c5f-9982-40f1a8941a86"), "KM", "Comoros" },
                    { new Guid("ad4da736-844e-4285-a754-5271e7b9f2a3"), "TD", "Chad" },
                    { new Guid("afae50fb-bea1-4808-ad5c-bbede909eed1"), "AL", "Albania" },
                    { new Guid("afebc678-a25a-4f11-984e-ae4dc7f8f416"), "IQ", "Iraq" },
                    { new Guid("b0459072-188c-4f2f-b703-ea33d7f8ce58"), "PG", "Papua New Guinea" },
                    { new Guid("b3afb1ef-6d34-44c2-ad53-6e9781e7f3ea"), "ET", "Ethiopia" },
                    { new Guid("b4aec1e8-0a38-4bd5-a4bd-9064f72f7769"), "NO", "Norway" },
                    { new Guid("b5e953a9-8c71-4cc8-a12a-a038e23509b1"), "LK", "Sri Lanka" },
                    { new Guid("b74120b2-666b-4ffe-b59f-1091b7a3f4a3"), "RO", "Romania" },
                    { new Guid("b8f01056-6b28-4290-beb4-3be8ce4b6473"), "SI", "Slovenia" },
                    { new Guid("ba13bc32-eb65-42b1-bcb7-aab122fde70d"), "DJ", "Djibouti" },
                    { new Guid("bb36e79b-ab97-4c87-91cf-de227e16e327"), "NI", "Nicaragua" },
                    { new Guid("bb62c243-ec3e-4aa4-8158-9735b5c50daf"), "AT", "Austria" },
                    { new Guid("bb9cfce5-3b74-454c-b2da-5418e3af956f"), "SB", "Solomon Islands" },
                    { new Guid("bd06d834-1555-41b8-9c6a-d93096b417cf"), "PY", "Paraguay" },
                    { new Guid("bd745b88-8e52-40f4-88c2-3b5178eb0dbe"), "CF", "Central African Republic" },
                    { new Guid("bf765c63-329f-4fcf-92cd-b6f6fc7d46c3"), "ER", "Eritrea" },
                    { new Guid("bfb709bf-7790-4ce8-a7b7-dad719d3545c"), "JM", "Jamaica" },
                    { new Guid("c41befd0-f1af-4a4d-b006-05521e4efdd2"), "TL", "Timor-Leste" },
                    { new Guid("c6314840-ddfa-4a94-b47b-6b33f254b052"), "BG", "Bulgaria" },
                    { new Guid("c67c7612-a23a-4398-9106-4e477ed590f5"), "SM", "San Marino" },
                    { new Guid("ca28ff49-dde5-4069-a34f-0af9938c9db5"), "QA", "Qatar" },
                    { new Guid("ca6f9f4e-914b-45c9-8f32-a8c3b41af8f1"), "TH", "Thailand" },
                    { new Guid("cc061e73-d2ba-4fc9-bc4d-fc473075601d"), "PK", "Pakistan" },
                    { new Guid("cd4ef5c6-e5f3-40be-9d9b-2a6867371d98"), "LA", "Laos" },
                    { new Guid("cea1e59c-c87a-433b-9b95-b3b5603716cb"), "DM", "Dominica" },
                    { new Guid("cefedc66-e144-4d61-853d-f1548de3b72c"), "FJ", "Fiji" },
                    { new Guid("d05886be-ffdc-4da6-82cf-83605e9f40c8"), "KG", "Kyrgyzstan" },
                    { new Guid("d05a21fe-5325-4cb1-9405-25169831f04b"), "ME", "Montenegro" },
                    { new Guid("d150363b-64d9-4e15-9fe1-af68a8f29e1f"), "MT", "Malta" },
                    { new Guid("d1b54d1b-0284-40da-88ef-73e31f780ae2"), "LC", "Saint Lucia" },
                    { new Guid("d2711e5f-c32b-485b-913c-9c5bcb4b14d1"), "AZ", "Azerbaijan" },
                    { new Guid("d5573645-a3d5-44d9-a0f6-4590ff2b5bfe"), "KW", "Kuwait" },
                    { new Guid("d620334e-af1b-4fa9-9e82-92a37c119dc9"), "MR", "Mauritania" },
                    { new Guid("d7bb1732-0f2c-45dd-b373-0a73c5b7e029"), "KZ", "Kazakhstan" },
                    { new Guid("d7f3c58c-aec6-483c-b3ee-d29c3b2d9bef"), "CY", "Cyprus" },
                    { new Guid("d7f5402e-7cf7-4485-9ab4-80e0be789031"), "GE", "Georgia" },
                    { new Guid("d9aaad2b-b5c1-41d0-92a9-3451c93723f4"), "MZ", "Mozambique" },
                    { new Guid("da2be77a-762a-4041-8020-0e1f528de9ec"), "TR", "Turkey" },
                    { new Guid("dbc70e41-5701-486d-8582-85d250d3bf4f"), "DE", "Germany" },
                    { new Guid("dcdbba4f-cbbb-4591-829c-2a160f2f9e80"), "BB", "Barbados" },
                    { new Guid("dd9b0bde-cdd8-42bc-b726-4e3f518993e2"), "EC", "Ecuador" },
                    { new Guid("df4b9330-8f41-48db-87a4-d2cdfb87639f"), "BY", "Belarus" },
                    { new Guid("e002a13a-93be-4018-a813-c263b76c70d3"), "RS", "Serbia" },
                    { new Guid("e1bea498-c0aa-4756-ad02-985af5040dba"), "CU", "Cuba" },
                    { new Guid("e3fa1a71-4329-48b7-a2b7-6d395e9d1675"), "MY", "Malaysia" },
                    { new Guid("e7172e53-0b60-424f-8474-679f4e87b3b2"), "PE", "Peru" },
                    { new Guid("e741de9f-8ec5-4a54-a77d-014f6f55d7f7"), "BZ", "Belize" },
                    { new Guid("e8acb144-e6f2-4c61-8dd0-925e22bc09ee"), "GN", "Guinea" },
                    { new Guid("eb20ad01-8c33-4334-bf44-bda4772cac23"), "IL", "Israel" },
                    { new Guid("ed368fee-f8b7-41a8-9b88-b105bfec0b99"), "BW", "Botswana" },
                    { new Guid("edaae6e5-3e32-4a90-9340-c9fe9f8f5fd8"), "SS", "South Sudan" },
                    { new Guid("efdc4ddc-631a-4637-b1b8-c0d03fb42434"), "TV", "Tuvalu" },
                    { new Guid("f0affb5b-59c4-423d-8f15-bd9ef1823996"), "HT", "Haiti" },
                    { new Guid("f35d8460-5277-43f1-b494-09eace69e8d0"), "BR", "Brazil" },
                    { new Guid("f586367a-f8f5-4369-9892-f045a0955068"), "PW", "Palau" },
                    { new Guid("f64ff3a7-64dc-4bad-afac-b357bce3f503"), "BN", "Brunei" },
                    { new Guid("f73b7e0a-4b11-452c-8e25-b527c93c09d3"), "GB", "United Kingdom" },
                    { new Guid("fa46b7c1-3457-4731-a4d8-706a9a7dc696"), "MU", "Mauritius" },
                    { new Guid("fa8a2e80-ea57-4cc9-87a4-0a6fa42b6bab"), "ML", "Mali" },
                    { new Guid("fcbac5ae-6490-4dad-9978-ebb301f96705"), "PS", "Palestine" },
                    { new Guid("ff3472b9-d083-4ac2-8f9f-20ae4d9ebc69"), "HU", "Hungary" },
                    { new Guid("ff7ce81f-a617-4414-aa6f-43bb0ef91dbc"), "AM", "Armenia" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("57c5d388-1146-4c08-8204-ac12e4d9474e"), "Male" },
                    { new Guid("d74d006b-54bf-4ee7-9155-695979c144f1"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("079441cd-ca57-47fd-bdbd-ddc912cdb3c3"), "Postoperative Care" },
                    { new Guid("1d6fa4ed-23a9-4503-8f94-9b96a33b66d2"), "Diagnostic Interventions" },
                    { new Guid("62183bab-ec2b-410d-8c41-defb6d1a5ee7"), "Preventive Interventions" },
                    { new Guid("68f6adb7-3826-44b6-8081-80793b2f178d"), "Emergency" },
                    { new Guid("864a073c-83bb-4b88-ac68-3f615f18c97b"), "Obstetric and Reproductive Interventions" },
                    { new Guid("c09efd54-5499-4bb4-9364-9adc2077fdaa"), "Dental Interventions" },
                    { new Guid("cb3a2618-a0cb-4041-ae4a-bff604a61c73"), "Oncological Interventions" },
                    { new Guid("d0d0ab1b-9916-4283-a55c-8730831e91e9"), "Surgical Interventions" },
                    { new Guid("d3f0d2a8-947c-4459-b134-0f4e148558a5"), "Exotic and Specialized Interventions" },
                    { new Guid("f614e890-bb7c-4d54-8dc0-cc2a9452d403"), "Therapeutic Interventions" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserPets_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserPets",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserPets_Pets_PetId",
                table: "ApplicationUserPets",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorBookings_Bookings_BookingId",
                table: "DoctorBookings",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");


            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(max)",
                nullable: false);


            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPets_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserPets");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPets_Pets_PetId",
                table: "ApplicationUserPets");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorBookings_Bookings_BookingId",
                table: "DoctorBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserPets",
                table: "ApplicationUserPets");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("016a26be-792f-4274-beb4-a5841de2d207"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01bdf992-cfb5-4943-b449-b8323789c940"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03943805-9412-491f-80e4-811a8a6555b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0509ad46-e26b-4df6-b993-e149e4ce23f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("059cdf04-7cdc-45b9-8ed7-25b709a6417d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0657000b-37d4-4b90-a9c9-9702a2d01a7e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07f53028-c85d-49cd-83b2-9b0994746358"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07f656ed-b881-4566-8a6d-72624051b6b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0aaf80dd-3686-4e39-a535-829f611354ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0aba2559-3068-4858-ad3d-a2bfc9673fa9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0bf729f2-b8a1-426b-931e-4018f5085487"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c8a9712-ee07-4635-a0c8-9164c03f0c83"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0cf77a92-750c-47d2-b23d-5d63b58d7228"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f0e43ee-7abe-40b3-98dd-30a7551f891a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f821deb-4aab-41ce-bcf1-58d2ce72cef8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("129e2e1f-36e9-48c0-9689-118a1adba5a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("166fed2b-cbef-45a9-af47-9a44f3e1753a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("177be822-8a41-431e-b6bd-41f256a82934"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17c85bd5-3dbc-4482-9f52-b87b0c4813b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a8fe28b-1ae3-450d-90f9-98a368adc40a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b7982e3-5fa0-4a59-9e81-1cde486ce975"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21eec1e8-d7d0-4054-9c21-0ced7a0e7e81"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("225fa102-5bb3-4362-ad8a-05b4b056010b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("22b6ab38-0628-4818-9435-6912e83139c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23c381d6-e5f8-4b45-ad04-022b7257db69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23de2132-0532-414a-b93b-cf526f26819b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23fef78e-d37a-4d17-a87f-b2e2ab9da0df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("251e03a5-852b-458d-b9c2-f32921636aec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2630c28d-30d2-44c5-ab41-751374b9d7c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("279255c4-8700-47d4-a5f3-9de785c262ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27b70873-341d-4931-aae5-422bc0717468"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28d022ec-9f07-49e5-95e1-09343d5c617d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29b02f2b-2956-4c22-9051-704dbf688393"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29ea6f5a-940b-4e03-a8a2-ff25c3c893a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2b1c259a-c706-4116-a5aa-80191202ac11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2b42c2b7-c23c-42d9-b293-3e15b235948a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d1aacb5-d79f-4edd-b12d-bc2bb331d4db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f39eeb3-3698-4032-8a20-e3b5eb51f45b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fb67b6d-23ee-4be5-bb56-a135f60914ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30337df0-d71e-4441-b700-617ed644d5fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31405a7d-bbaa-4bad-afe5-33e6e6cf0a9b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32b772df-92f1-4612-bc46-68f528eb3f6e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("36d8f095-4a44-4598-b43e-0ac46b8d25df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("373d516a-6597-4038-bf66-937387675678"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3bc3735e-bd8d-48ea-999a-0dbee2a31c2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c9b61a7-9f15-4217-a605-f57c0a4b69ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ca7a621-448e-488d-ae5e-f8711ac41ff4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3cf063e2-2ab7-421a-a00c-a4e3fccb803e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f70e670-f216-4903-baef-e759e4fd14d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("401f7e76-8443-46f7-bbc9-84630303354e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("40752f56-b6bf-4052-ba15-feee97e881f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("408ea540-0130-446b-bd32-c180704ef538"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("40d743d9-da1e-4b5e-a288-2151e63007e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("40e56e7c-8956-4d98-abd6-803df3b1de2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4162c0f8-957e-484d-872b-3a4582b708ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("42d89aa4-f46f-407b-8d9f-ea974822405c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("435a39c7-124e-41fc-a770-9eb8183c990a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43c9bfdb-804b-4ab7-bf6b-4d63e6985a52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45e7417b-47e3-4038-b1fe-ce9bdd302849"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4757488b-d1d1-410f-ab6b-cc882111466c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49181935-4370-4a7b-8319-f29ccabe500f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4927670b-2f0a-4db1-8d29-3fd0627ad3fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4bd480af-d24a-4375-8e98-5248ed06d405"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c5511a0-7029-49be-951c-2add5afa6480"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c6d8866-4a95-4a79-8a2b-e609b4f8c4e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4da15f05-c684-490a-9c5f-94b2cc439858"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4edd98e5-bf4f-489b-b99f-a3b545e74f3e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ef6a3f0-306c-46a0-bbad-911436df742d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("524f1ac1-e7bb-43f1-b74e-936468fe59cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5258c13e-0c9e-49db-bd9a-0f2e37810e0b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("54cfcb90-93fe-4b16-8c63-1924bee7ed98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("586446fa-c033-4542-8c07-9e7da17336e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59065848-ca22-4ebe-8869-7791d9f592de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b3d504c-6a05-40e4-b6ed-cdfc487b57ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f8ed060-70bb-43f5-9426-ca1ca752b9df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f915081-dad6-4769-8892-4aa67dffea25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6098f85e-96ca-4e74-aedb-c5997594e589"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61a09170-344b-46f8-bac4-ab9f59318825"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6259f1ae-0ee0-4366-b112-52e74535e2e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64962c69-f30f-4a82-8fb8-e5e02b71cff0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67e242ba-819a-478e-810b-39a07eb106d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6aad9b20-73fb-4b9d-8e12-323282e08e4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b6a586f-f180-4422-ad10-e82f9a12e5a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b6d80fe-ac4a-4db4-8aea-d6d14bedf076"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6c250da3-3e6a-4363-b259-2e297b908f9a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e441267-3f7f-4aee-ac9c-a98a7383611a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fc1e372-9425-4c3b-bb13-2c0eb42d31ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70ad4f11-4956-4923-ba4a-2243ab508411"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71925c66-b98b-4037-83a7-8f6a7a7c2a64"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72d12f58-98f2-4a2c-8494-8bfd17f9a695"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("761573e0-39d6-41d1-ad7d-2c81ee651236"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7744ccb4-b1ac-414b-a961-b0cb84bf66a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77e3711c-21e3-4dc9-a5d9-d403e3eaf161"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7803c4ab-ecb1-4b22-ac95-4b2328ab7a59"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78bac397-77e0-4a83-84b8-33f5a269d1ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a537953-5db3-4b76-a012-da0e1ec6c736"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b5402ca-04b1-4792-9080-0412b1d5e738"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d290747-9b36-4b70-b8b0-170a2fe748c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7eee0788-3204-4621-9739-b8681412b24a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f3480fd-cd5c-4a45-b02a-8aeb064b5c3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7fbf52c5-b2ad-486d-bf90-c49a31fdaf9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8020d854-1f6d-4e25-bbd5-0fa658e03003"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("840fb012-2ff0-4031-bfc8-c85e416c42a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("847f5e31-1be9-41b2-9ee2-ac82b9ff9958"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("847fbe8a-149e-4579-a413-d8c8b95b76d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85565d69-13eb-49dd-afc3-4195285b74c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86209805-e805-40ba-a945-8e3e691042da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("88c99207-db4e-4044-9231-8d95733af29b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89136ea2-7d62-49c8-97b5-a02de047076e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89d7259a-ae9b-4aed-b651-6da747ca839d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89e29624-4cf3-4971-b962-d8fb36040c67"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8cfe1e60-2a94-4d2c-b79a-71dfa9e11a01"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d5f6bc2-5bbf-49e2-aeff-af4ee37ae330"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8da91921-39e1-432f-a425-9eedc450ee48"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("90afd949-5af8-4ae5-a0aa-2da7eaafca0e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9186d451-a4fe-4f7f-81ea-7d788b08cc73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("941cdb08-5152-4c10-9ce9-f22b8d385171"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95457cd2-9a8f-4358-95f8-05bfd26059a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("958d4bf3-de23-474a-929e-4a815c8ced4b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96971593-88d9-4230-b709-94fae0652ad5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("970d1ef8-f4e8-40ef-a797-24875e9a0e6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97e0f007-8893-43ed-8844-a8a309a7aebd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b926031-a0ca-40bf-b76c-c644901dd994"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b9bd379-04d9-49b4-819b-fe2869d8f464"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d7c6121-949e-42c4-b695-4a892d796750"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d80487e-ed32-4abe-9c10-932d1e22a3ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a217f48b-bdad-4404-afe0-2e24aad29445"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a32218b3-119c-46b7-a4dd-d23b7347598b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a5ed07b4-96d7-4f6d-a8d3-e1fa78d50ac0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a8d51a89-b010-44e9-a66d-9f67c8dc68aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a92caee6-13c0-4bd2-bda7-20b4ea51d291"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9370a91-ce46-4c5f-9982-40f1a8941a86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad4da736-844e-4285-a754-5271e7b9f2a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afae50fb-bea1-4808-ad5c-bbede909eed1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afebc678-a25a-4f11-984e-ae4dc7f8f416"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0459072-188c-4f2f-b703-ea33d7f8ce58"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3afb1ef-6d34-44c2-ad53-6e9781e7f3ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4aec1e8-0a38-4bd5-a4bd-9064f72f7769"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5e953a9-8c71-4cc8-a12a-a038e23509b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b74120b2-666b-4ffe-b59f-1091b7a3f4a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8f01056-6b28-4290-beb4-3be8ce4b6473"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ba13bc32-eb65-42b1-bcb7-aab122fde70d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb36e79b-ab97-4c87-91cf-de227e16e327"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb62c243-ec3e-4aa4-8158-9735b5c50daf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb9cfce5-3b74-454c-b2da-5418e3af956f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd06d834-1555-41b8-9c6a-d93096b417cf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd745b88-8e52-40f4-88c2-3b5178eb0dbe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf765c63-329f-4fcf-92cd-b6f6fc7d46c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bfb709bf-7790-4ce8-a7b7-dad719d3545c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c41befd0-f1af-4a4d-b006-05521e4efdd2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6314840-ddfa-4a94-b47b-6b33f254b052"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c67c7612-a23a-4398-9106-4e477ed590f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca28ff49-dde5-4069-a34f-0af9938c9db5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca6f9f4e-914b-45c9-8f32-a8c3b41af8f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc061e73-d2ba-4fc9-bc4d-fc473075601d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd4ef5c6-e5f3-40be-9d9b-2a6867371d98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cea1e59c-c87a-433b-9b95-b3b5603716cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cefedc66-e144-4d61-853d-f1548de3b72c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d05886be-ffdc-4da6-82cf-83605e9f40c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d05a21fe-5325-4cb1-9405-25169831f04b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d150363b-64d9-4e15-9fe1-af68a8f29e1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1b54d1b-0284-40da-88ef-73e31f780ae2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d2711e5f-c32b-485b-913c-9c5bcb4b14d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d5573645-a3d5-44d9-a0f6-4590ff2b5bfe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d620334e-af1b-4fa9-9e82-92a37c119dc9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7bb1732-0f2c-45dd-b373-0a73c5b7e029"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7f3c58c-aec6-483c-b3ee-d29c3b2d9bef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7f5402e-7cf7-4485-9ab4-80e0be789031"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9aaad2b-b5c1-41d0-92a9-3451c93723f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da2be77a-762a-4041-8020-0e1f528de9ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dbc70e41-5701-486d-8582-85d250d3bf4f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dcdbba4f-cbbb-4591-829c-2a160f2f9e80"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd9b0bde-cdd8-42bc-b726-4e3f518993e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df4b9330-8f41-48db-87a4-d2cdfb87639f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e002a13a-93be-4018-a813-c263b76c70d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e1bea498-c0aa-4756-ad02-985af5040dba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e3fa1a71-4329-48b7-a2b7-6d395e9d1675"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7172e53-0b60-424f-8474-679f4e87b3b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e741de9f-8ec5-4a54-a77d-014f6f55d7f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8acb144-e6f2-4c61-8dd0-925e22bc09ee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb20ad01-8c33-4334-bf44-bda4772cac23"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed368fee-f8b7-41a8-9b88-b105bfec0b99"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("edaae6e5-3e32-4a90-9340-c9fe9f8f5fd8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efdc4ddc-631a-4637-b1b8-c0d03fb42434"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0affb5b-59c4-423d-8f15-bd9ef1823996"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f35d8460-5277-43f1-b494-09eace69e8d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f586367a-f8f5-4369-9892-f045a0955068"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f64ff3a7-64dc-4bad-afac-b357bce3f503"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f73b7e0a-4b11-452c-8e25-b527c93c09d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa46b7c1-3457-4731-a4d8-706a9a7dc696"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa8a2e80-ea57-4cc9-87a4-0a6fa42b6bab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fcbac5ae-6490-4dad-9978-ebb301f96705"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff3472b9-d083-4ac2-8f9f-20ae4d9ebc69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff7ce81f-a617-4414-aa6f-43bb0ef91dbc"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("57c5d388-1146-4c08-8204-ac12e4d9474e"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("d74d006b-54bf-4ee7-9155-695979c144f1"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("079441cd-ca57-47fd-bdbd-ddc912cdb3c3"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("1d6fa4ed-23a9-4503-8f94-9b96a33b66d2"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("62183bab-ec2b-410d-8c41-defb6d1a5ee7"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("68f6adb7-3826-44b6-8081-80793b2f178d"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("864a073c-83bb-4b88-ac68-3f615f18c97b"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("c09efd54-5499-4bb4-9364-9adc2077fdaa"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("cb3a2618-a0cb-4041-ae4a-bff604a61c73"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("d0d0ab1b-9916-4283-a55c-8730831e91e9"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("d3f0d2a8-947c-4459-b134-0f4e148558a5"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f614e890-bb7c-4d54-8dc0-cc2a9452d403"));

            migrationBuilder.RenameTable(
                name: "ApplicationUserPets",
                newName: "ApplicationUserPet");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserPets_PetId",
                table: "ApplicationUserPet",
                newName: "IX_ApplicationUserPet_PetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserPet",
                table: "ApplicationUserPet",
                columns: new[] { "ApplicationUserId", "PetId" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("00b4f6f3-ceee-4ad5-bb7f-3dfdd873b7a0"), "ZA", "South Africa" },
                    { new Guid("02195124-54ea-4b29-85ec-325545cc91c0"), "PS", "Palestine" },
                    { new Guid("02e2caca-cd31-4e54-8692-151dcf93c7b8"), "SV", "El Salvador" },
                    { new Guid("04c4b78d-7d54-4dfe-8672-036777c79271"), "GW", "Guinea-Bissau" },
                    { new Guid("04ca313b-9d26-4d5b-b3b7-68d9a87061bd"), "AM", "Armenia" },
                    { new Guid("06a3868c-c8dc-4849-8781-4d4e850a22c8"), "MY", "Malaysia" },
                    { new Guid("06d6f964-3ae0-4889-b905-633ede8ab60a"), "SK", "Slovakia" },
                    { new Guid("09175d65-aca8-4ebb-a4b7-dd8442b47e03"), "NL", "Netherlands" },
                    { new Guid("0966427c-e239-43b1-9c94-deed2a8bc708"), "MK", "North Macedonia" },
                    { new Guid("0a11bd07-3717-46af-9d74-ebbe8d58ad47"), "TL", "Timor-Leste" },
                    { new Guid("0aadbd12-2c3a-4d1b-8fb4-9fa85d3ec43f"), "QA", "Qatar" },
                    { new Guid("0df1d424-34cb-4d2d-81b6-f8d889f0395d"), "AZ", "Azerbaijan" },
                    { new Guid("0fb8f43f-3b5c-4c0a-9779-fef6e6ffe65f"), "VE", "Venezuela" },
                    { new Guid("0fe4bee7-e3f5-4b5c-84d9-48a900c6d2b9"), "BN", "Brunei" },
                    { new Guid("118376bf-4ce6-4afd-888b-0b0e2e607323"), "MR", "Mauritania" },
                    { new Guid("1228ecba-91f8-425a-87d1-9aa0231f5538"), "SM", "San Marino" },
                    { new Guid("12b4ac84-19c6-49ce-aae3-11d0b2b2ef6e"), "LB", "Lebanon" },
                    { new Guid("1410fee4-edbe-4fa5-9f56-fa4d4eb8a387"), "PG", "Papua New Guinea" },
                    { new Guid("178a2ce7-7dcd-4671-bc38-368fd31dba3f"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("19f89c1c-7215-495c-b6a6-f723dfbaec70"), "GE", "Georgia" },
                    { new Guid("1a07e66f-13a3-4a79-a77b-6167d0c30221"), "TZ", "Tanzania" },
                    { new Guid("1aa677a1-9501-4b1e-aeb3-817bf7b969bc"), "NZ", "New Zealand" },
                    { new Guid("1da20df5-ccb9-4e5a-bd39-8a3154ad5b18"), "KZ", "Kazakhstan" },
                    { new Guid("1da80bc4-16ee-4a03-84f4-d045bb394cbc"), "ER", "Eritrea" },
                    { new Guid("217499ca-4b1c-4f40-892c-96094042d574"), "SC", "Seychelles" },
                    { new Guid("22ef3f2e-e90d-47e8-85f9-537b8ed5e7f7"), "BH", "Bahrain" },
                    { new Guid("23024fce-7538-46fe-81dc-677cd3cccf49"), "LV", "Latvia" },
                    { new Guid("24044db5-428f-49b9-ab94-c180cc291113"), "BW", "Botswana" },
                    { new Guid("26712ae4-2c06-42b8-a826-10d46008a53f"), "IE", "Ireland" },
                    { new Guid("26a7e230-93bb-4feb-8d92-c43949660917"), "PY", "Paraguay" },
                    { new Guid("26c25263-3520-44a1-864d-7ecaab7f3375"), "KR", "South Korea" },
                    { new Guid("26f2de4f-b200-499b-9120-caa325b5e79b"), "AE", "United Arab Emirates" },
                    { new Guid("2780fbd3-6cb0-4e55-a111-f9481ad160c4"), "LI", "Liechtenstein" },
                    { new Guid("27b89f5a-620b-4b39-a7a7-9cb4f7cb54d3"), "MA", "Morocco" },
                    { new Guid("29348c4e-37b7-47a1-8196-fe7913b5de43"), "CM", "Cameroon" },
                    { new Guid("2ac2678e-3ce9-459e-9c98-b93514c06d07"), "VU", "Vanuatu" },
                    { new Guid("2d477deb-fec1-4353-8b24-16c0f134954d"), "LS", "Lesotho" },
                    { new Guid("2d9078f2-35df-49f8-8195-228ddfd4ae42"), "SN", "Senegal" },
                    { new Guid("2f8b1b13-ca44-4191-9ff0-600627c2532d"), "DK", "Denmark" },
                    { new Guid("306ff630-56e0-4305-8234-82f52c1572aa"), "ZM", "Zambia" },
                    { new Guid("30930852-86ec-4489-b021-8c2842322539"), "GM", "Gambia" },
                    { new Guid("30b54065-1fb0-427b-94d1-c69b3840d70c"), "BY", "Belarus" },
                    { new Guid("314aac3b-f0fe-4b73-a330-3d72058f4c4f"), "BF", "Burkina Faso" },
                    { new Guid("32773020-6d12-43e9-9793-58ab35386bf5"), "SO", "Somalia" },
                    { new Guid("3414c610-5493-4b74-9a55-9dc24f73fc14"), "LU", "Luxembourg" },
                    { new Guid("362210b0-7af3-427d-8452-369ec3855a92"), "KH", "Cambodia" },
                    { new Guid("380413b5-6ff4-4e67-817f-ec287a36adb7"), "TV", "Tuvalu" },
                    { new Guid("3831392d-513d-4fe2-8a9b-777458aafe67"), "SA", "Saudi Arabia" },
                    { new Guid("397b0e80-eeb1-47c3-bdd0-1ede9331758e"), "BZ", "Belize" },
                    { new Guid("3c5096db-3173-42dd-af93-b12b2c8dadcf"), "PH", "Philippines" },
                    { new Guid("3cb1595a-2e56-4683-94b5-3fcda7771be9"), "SS", "South Sudan" },
                    { new Guid("3cf083cd-28bd-4929-bd0e-5f315d75d1e7"), "VA", "Holy See" },
                    { new Guid("3e89414b-8c8d-4606-8560-1801ba80a418"), "FM", "Micronesia" },
                    { new Guid("3feb4193-4f5b-4c9f-9060-dfe6b4d37ac7"), "DO", "Dominican Republic" },
                    { new Guid("400deecd-0e10-4d28-972b-345625fb5b0e"), "HT", "Haiti" },
                    { new Guid("43dd8bec-a151-49d2-9e8a-148acd965569"), "TD", "Chad" },
                    { new Guid("44e34932-3055-47fa-8594-b07e20afcd99"), "KP", "North Korea" },
                    { new Guid("45440c27-edc4-4b0b-96fc-8fe0546d8da2"), "KW", "Kuwait" },
                    { new Guid("46f23381-7ef2-41c8-9cca-4a69b120fcb1"), "KE", "Kenya" },
                    { new Guid("46f839d1-f571-413c-9114-58c9b8f51f9e"), "IR", "Iran" },
                    { new Guid("47756479-7590-4096-92b7-f7561cc91cac"), "CR", "Costa Rica" },
                    { new Guid("4990102b-3207-4595-b0ed-b6544983eaaa"), "PK", "Pakistan" },
                    { new Guid("4b5c8aea-c714-46aa-ae35-9ff004495610"), "GQ", "Equatorial Guinea" },
                    { new Guid("4f2b11ea-0027-471a-86f6-392acb41803a"), "MG", "Madagascar" },
                    { new Guid("5203e4fe-7029-42b0-b752-ca016679a5b8"), "LA", "Laos" },
                    { new Guid("551c0672-001e-487e-a5d7-9c1bd5c24ffa"), "TH", "Thailand" },
                    { new Guid("56493af5-f818-4868-bb62-53cbd4152a6d"), "JM", "Jamaica" },
                    { new Guid("569c43b5-e6ba-497b-8e49-18e03bc2429f"), "MM", "Myanmar" },
                    { new Guid("5789c0d0-caf5-4448-be11-833a9a3c9c2f"), "AG", "Antigua and Barbuda" },
                    { new Guid("5aa8add0-5635-4bb4-b6a4-ec0b9e640123"), "CO", "Colombia" },
                    { new Guid("5c52f8c5-57f1-470b-9a66-ae91063be25b"), "ST", "Sao Tome and Principe" },
                    { new Guid("5e0fe1ba-902a-4ed7-b418-399b06600c0d"), "IQ", "Iraq" },
                    { new Guid("5fb190a6-30e1-48ff-9f6b-a6c177ce64c2"), "EG", "Egypt" },
                    { new Guid("5fcbe5e2-a213-43e0-9317-521facc9c0cf"), "ID", "Indonesia" },
                    { new Guid("60fd7e93-6c69-4ab3-b6c9-c5ab95d6f147"), "AR", "Argentina" },
                    { new Guid("621370c7-b507-40ce-a78a-01709371d905"), "YE", "Yemen" },
                    { new Guid("63a5c340-c1df-4b02-b236-d8acb610d3b4"), "AO", "Angola" },
                    { new Guid("63e9f890-fcce-4a35-95c2-4fcb8c752db4"), "JO", "Jordan" },
                    { new Guid("640f8b16-e1d5-4baa-bfc3-d1244df93689"), "AT", "Austria" },
                    { new Guid("6481f682-b0d9-4eca-bebc-6241fdd7b694"), "IT", "Italy" },
                    { new Guid("68146c3e-caa8-49a2-b9b8-b105277da81b"), "BR", "Brazil" },
                    { new Guid("69d39c22-a938-4780-8360-47d3d934fccc"), "MZ", "Mozambique" },
                    { new Guid("6c961ea6-fefe-4d56-86b9-303b8c31da13"), "VA", "Vatican City" },
                    { new Guid("6d0849c7-d9ea-46fd-8184-807bc89d157a"), "LR", "Liberia" },
                    { new Guid("6d315aab-653d-49ec-82ba-4256632b00e7"), "GR", "Greece" },
                    { new Guid("6d419b58-058f-4ce7-b77a-a594ba83e50d"), "KI", "Kiribati" },
                    { new Guid("6d5d08a9-d52a-4c37-b92c-bdf111da8722"), "BG", "Bulgaria" },
                    { new Guid("6d646dca-6def-45ee-86f2-a66c630db785"), "TT", "Trinidad and Tobago" },
                    { new Guid("6f524d83-6c56-45a0-a3d2-d23cd0944263"), "SY", "Syria" },
                    { new Guid("70b5208b-5b4b-4563-beaf-b7b827935494"), "LY", "Libya" },
                    { new Guid("71c6108a-6e6e-483d-8b76-a4fe4b0d22d0"), "CY", "Cyprus" },
                    { new Guid("72783edb-b5b4-43c4-943a-b7584fcd5ae6"), "BS", "Bahamas" },
                    { new Guid("731c99df-2d4b-414e-a514-114c582b08e0"), "TJ", "Tajikistan" },
                    { new Guid("78ad5942-e86c-456e-8420-8a4bba7afb82"), "CF", "Central African Republic" },
                    { new Guid("78eddda0-d4f0-4e8a-9c5a-128852acede4"), "SB", "Solomon Islands" },
                    { new Guid("7912b508-e0e2-43ae-a5f9-68add7b62912"), "BB", "Barbados" },
                    { new Guid("7b5a3ea0-07f9-4eef-9a5d-27e6bbc164b7"), "EC", "Ecuador" },
                    { new Guid("7b6336d1-714d-41f7-9101-b1536a4c9653"), "PW", "Palau" },
                    { new Guid("7ea5ed88-1ccf-4758-b612-86f898b53cc5"), "BJ", "Benin" },
                    { new Guid("7fa39f71-87f6-4d81-b86e-c60683516062"), "GB", "United Kingdom" },
                    { new Guid("802df591-da6e-49bc-a22b-86ee751c5d7b"), "CH", "Switzerland" },
                    { new Guid("80d6ae79-3c6a-4965-8c3b-fb5819f6b3c0"), "AF", "Afghanistan" },
                    { new Guid("81b6fe8b-8c70-4d8e-b733-de252448d03e"), "NR", "Nauru" },
                    { new Guid("827cd30f-5959-49e6-8384-5bd9173045d6"), "MW", "Malawi" },
                    { new Guid("853d0bca-333f-4f07-8808-8dcc00e625a0"), "JP", "Japan" },
                    { new Guid("8581f65d-ce2a-4bc9-82aa-60baafb15386"), "TG", "Togo" },
                    { new Guid("85c4f086-4227-4df4-ba9f-76f1718e9172"), "MV", "Maldives" },
                    { new Guid("87cacd33-6b83-4650-8860-747e80172886"), "NG", "Nigeria" },
                    { new Guid("8cab9da3-827b-4735-af75-d95f7d13a575"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("8d06de32-c10b-4d60-baec-f83620ffc055"), "EE", "Estonia" },
                    { new Guid("8e51c5eb-8ddf-4585-ba34-f50333242891"), "IS", "Iceland" },
                    { new Guid("91604462-37cb-465f-ae1b-591532854ce6"), "HU", "Hungary" },
                    { new Guid("91b94077-197d-41a9-91d8-991b8e898911"), "RU", "Russia" },
                    { new Guid("93b6d581-8a0d-4b09-874b-07f86f3ab48a"), "MD", "Moldova" },
                    { new Guid("94a49ccf-8168-4d8a-8ac0-6412a1de66cb"), "LT", "Lithuania" },
                    { new Guid("98fa1319-0ffb-402b-b429-afcd750a35a8"), "MX", "Mexico" },
                    { new Guid("9a19488e-81d0-48a0-affa-d1edca515c2f"), "PT", "Portugal" },
                    { new Guid("9a870d65-4937-4584-a886-97f5784ab231"), "ES", "Spain" },
                    { new Guid("9b39e866-ad81-4787-a783-25d415525655"), "GH", "Ghana" },
                    { new Guid("9c2b28ca-3818-4269-9e16-6648bbe42a4e"), "HN", "Honduras" },
                    { new Guid("9da59233-c49f-4d88-a47a-64b05834274f"), "TR", "Turkey" },
                    { new Guid("a2149d36-9dc8-48d2-907f-062627abaf82"), "TN", "Tunisia" },
                    { new Guid("a30ed16a-3a7a-4f27-824f-396ff86db85c"), "BE", "Belgium" },
                    { new Guid("a42c93ad-09e1-4b70-8ff4-0671d284fcc7"), "NE", "Niger" },
                    { new Guid("a45e578a-a39e-44dd-aa6b-358d08f353b1"), "GT", "Guatemala" },
                    { new Guid("a46533fd-0a31-439e-bffd-5ea8f4d98698"), "UY", "Uruguay" },
                    { new Guid("a6796e79-6cc8-4158-9099-0a12c7e32743"), "CV", "Cabo Verde" },
                    { new Guid("a80882ef-2480-41b3-9c3a-e33481e847d9"), "IN", "India" },
                    { new Guid("ab029d6c-deda-4faa-a353-8e01244d3fd2"), "UA", "Ukraine" },
                    { new Guid("ab30ae68-7155-41ce-b8fd-7b7f5706015f"), "RW", "Rwanda" },
                    { new Guid("abc3773a-6749-4631-a5eb-453b3d877d45"), "CL", "Chile" },
                    { new Guid("ae0731d0-3f98-4d5b-af76-be6da02a1b04"), "KM", "Comoros" },
                    { new Guid("b004d825-e39c-4163-9c45-b2c46902dc40"), "GY", "Guyana" },
                    { new Guid("b05d54d1-8246-4d87-aa69-3f000255e037"), "BD", "Bangladesh" },
                    { new Guid("b12b2666-0e62-4906-af2f-2fc714f33ea3"), "AD", "Andorra" },
                    { new Guid("b17eb8a2-60e5-40a3-aa20-49d452d2917b"), "BI", "Burundi" },
                    { new Guid("b41b015c-e4df-4eca-90bc-94c297e3bb9e"), "RO", "Romania" },
                    { new Guid("b438715a-99f2-4ee3-916f-7bf5c84a1062"), "ET", "Ethiopia" },
                    { new Guid("b62f3821-fbc7-4fd0-9910-a600870abfd6"), "CN", "China" },
                    { new Guid("b761af04-2aeb-465b-a296-20533bdcdc6e"), "RS", "Serbia" },
                    { new Guid("b996324a-44ef-4fe7-bc61-46758d8f392c"), "TM", "Turkmenistan" },
                    { new Guid("b9bcb402-ee5b-4b86-bb98-6ad83dd0173b"), "VN", "Vietnam" },
                    { new Guid("bc04d34d-496b-4da0-b959-6d5bcf50ff10"), "KG", "Kyrgyzstan" },
                    { new Guid("bf7dffd5-ca6a-4e7d-92f2-f2540104b729"), "ME", "Montenegro" },
                    { new Guid("bfe0c77a-2196-418d-80e8-589a6106991a"), "SI", "Slovenia" },
                    { new Guid("c0046155-b993-40c4-97ea-72498a604dd2"), "NA", "Namibia" },
                    { new Guid("c284b9a7-7cdc-4c85-93fe-2de8b3d29ab6"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("c3927daf-dba2-4a41-aef8-6271027aceda"), "PE", "Peru" },
                    { new Guid("c3dc0f54-a182-4525-b7ad-795a76382bfa"), "CU", "Cuba" },
                    { new Guid("c422741f-1089-4df0-acdd-ce5e393b29e0"), "DE", "Germany" },
                    { new Guid("c58f210b-5d21-4e01-83bc-4e6f63b7cb1f"), "SR", "Suriname" },
                    { new Guid("c5ec3d88-be39-41fb-9c8d-982020a63cd2"), "PL", "Poland" },
                    { new Guid("c66fad34-4f0d-4060-bc29-7c237bbdb0cc"), "AL", "Albania" },
                    { new Guid("c7ee220d-7291-449d-a99c-db9e7a475a6c"), "SZ", "Eswatini" },
                    { new Guid("cab15b7c-1e6e-4c69-827e-ce23398819d9"), "GD", "Grenada" },
                    { new Guid("ce6ce431-bd69-44a5-9dc8-cdfad14ee5f1"), "FR", "France" },
                    { new Guid("d1139ebe-6c7e-439a-a1bc-fe6e1f3258d6"), "LK", "Sri Lanka" },
                    { new Guid("d1b7c637-e1f5-4bb5-8087-e38a06efb3d6"), "WS", "Samoa" },
                    { new Guid("d2284249-a46a-4aa9-ad88-5aef4be17e91"), "DZ", "Algeria" },
                    { new Guid("d2500a12-22e4-42be-9704-08a76ce7acb4"), "LC", "Saint Lucia" },
                    { new Guid("d3e94d1f-1c92-456c-9f79-45314262f2d5"), "US", "United States of America" },
                    { new Guid("d4140024-a8e9-4453-b617-7baa68dd53af"), "FI", "Finland" },
                    { new Guid("d4ed9f5d-e296-401c-bc7d-8eba7dc6d6eb"), "UZ", "Uzbekistan" },
                    { new Guid("d6cc532c-3815-4c7c-9df2-405d6f8ab740"), "ZW", "Zimbabwe" },
                    { new Guid("d70dbe9e-b423-433c-9bae-24a296ce1b4e"), "GN", "Guinea" },
                    { new Guid("d7166be7-eefc-48d1-8e1e-09532c242714"), "SG", "Singapore" },
                    { new Guid("d877fd7f-800d-4799-8541-dd8030d65161"), "MH", "Marshall Islands" },
                    { new Guid("dc756d14-697e-4f91-9c69-cda74b272fd7"), "GA", "Gabon" },
                    { new Guid("e0b3ff19-bcbd-4b0d-a8f7-aa357e96c28d"), "IL", "Israel" },
                    { new Guid("e3385935-141a-49af-b63c-46bf6ea80978"), "BO", "Bolivia" },
                    { new Guid("e4187873-bdaa-4366-9f5a-0e552611fcc2"), "PA", "Panama" },
                    { new Guid("e419745a-57f5-430f-a98e-15fa3ce9e044"), "TO", "Tonga" },
                    { new Guid("e4a0bcf2-cc1e-480c-b9af-9f675acffc9c"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("e53d8d0c-7a86-4950-bae2-b07eff5fbe52"), "NI", "Nicaragua" },
                    { new Guid("e570dcfe-9860-4526-a7d7-d1eddec99b7e"), "BT", "Bhutan" },
                    { new Guid("e6f28481-0a75-42c2-9202-82d5f20cafaa"), "HR", "Croatia" },
                    { new Guid("e8521bec-273d-473a-9528-b69bd0b4a9be"), "CA", "Canada" },
                    { new Guid("ec218713-f9c6-42a8-8421-45e2807b7259"), "MU", "Mauritius" },
                    { new Guid("ed62b74a-d457-4c19-b0e5-c09f3f684a6a"), "UG", "Uganda" },
                    { new Guid("ee1c1faa-3bd9-44e5-bc82-ca90843efa7d"), "SE", "Sweden" },
                    { new Guid("ee477f30-d41d-47fe-943e-896a6c3fe562"), "DJ", "Djibouti" },
                    { new Guid("ee9e5703-783a-4f5e-90da-f8a2c27d7b4d"), "SD", "Sudan" },
                    { new Guid("ef975c6a-577d-433d-a6d2-86389d7ac7fc"), "ML", "Mali" },
                    { new Guid("f1b14328-9368-46ad-a420-46cfdf9fa5db"), "AU", "Australia" },
                    { new Guid("f2078abe-60da-4617-8ca4-ec2342ae313e"), "OM", "Oman" },
                    { new Guid("f34a26d6-5e97-4eb9-9668-7e22deeb7fac"), "DM", "Dominica" },
                    { new Guid("f3e2d14e-4190-4e12-a9d0-133b2a8e40ef"), "MC", "Monaco" },
                    { new Guid("f7d37ac3-e5b6-4df3-bc3d-a64846d2426e"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("f88f81f3-7ebb-45eb-9827-bb5379679a1d"), "MT", "Malta" },
                    { new Guid("f8dfe5e0-7f64-4ef1-be61-5ca0a16aca47"), "NP", "Nepal" },
                    { new Guid("fc34d555-a51f-4357-81c3-23e550004d53"), "NO", "Norway" },
                    { new Guid("fd63047e-e280-498a-ad35-865a4f8d452e"), "MN", "Mongolia" },
                    { new Guid("feea4bc1-fba1-4df6-a437-2dc9b9af412e"), "SL", "Sierra Leone" },
                    { new Guid("ffa3fed0-1757-4e4d-975d-e537c28d1646"), "FJ", "Fiji" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2d540796-0858-40c7-9420-32a3b3635c48"), "Female" },
                    { new Guid("cbab8113-b87f-473d-91d0-2a43a6419f04"), "Male" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2652850a-2345-4e9c-9de1-3b102ee21ddd"), "Emergency" },
                    { new Guid("2d3125d1-2fcb-4ee0-aed1-601392bae72d"), "Preventive Interventions" },
                    { new Guid("3c879d79-53f0-4dab-8660-974685ddc674"), "Exotic and Specialized Interventions" },
                    { new Guid("81e0a02e-7b87-4280-9c0a-bb7941c8ed06"), "Oncological Interventions" },
                    { new Guid("85f749b1-21cf-446a-b2f3-0f65a9c2fd9a"), "Diagnostic Interventions" },
                    { new Guid("df520a79-d47e-4327-a914-153127e43d76"), "Obstetric and Reproductive Interventions" },
                    { new Guid("edd5f12c-d522-4934-a9b1-a57797db7495"), "Postoperative Care" },
                    { new Guid("f4b18120-e730-4d2b-ab96-e62e462cb121"), "Dental Interventions" },
                    { new Guid("fbb999d5-e430-4ab5-950f-8f715f0ad6c0"), "Therapeutic Interventions" },
                    { new Guid("ff821c3e-a78f-492a-ae9a-196917ddcc59"), "Surgical Interventions" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserPet_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserPet",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserPet_Pets_PetId",
                table: "ApplicationUserPet",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorBookings_Bookings_BookingId",
                table: "DoctorBookings",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
