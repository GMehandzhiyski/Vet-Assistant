using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserDetailsWithOutProblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Countries_CountryId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Interventions_AspNetUsers_UserId",
                table: "Interventions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBookings_AspNetUsers_UserDetailsId",
                table: "UserBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailsApplicationUsers_ApplicationUsers_ApplicationUserId",
                table: "UserDetailsApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailsApplicationUsers_AspNetUsers_UserDetailsId",
                table: "UserDetailsApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailsPets_AspNetUsers_UserDetailsId",
                table: "UserDetailsPets");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("001a8880-3a86-4662-9700-fed0efbdfc18"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("019ea4a7-97bf-4b32-a4d0-585ada74d5f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("026e6c04-7538-48d4-8672-1b5f29f9d5c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("027d7f27-43ef-42dd-9fac-993c0ac66246"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("069eaa5b-09fc-4f2a-b892-a3feaa4011c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06f89017-2a24-44f6-9767-b51a376fc8f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07199ab7-325a-4a8e-a2a6-58e1eaed24bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b1ca580-e4bf-4aca-909b-10241207b7ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c59c08f-9676-4409-9195-b8d411264d45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f17842e-5305-482c-94bc-bf8179eb5a8f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f91a6c4-2e89-45fb-b198-2eed4f143eef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("117f7de1-6b9b-457f-a43b-42664a1c6f91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11d7438e-5906-4562-911f-761b72a1d5df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1336d3fb-2302-40ee-922b-1fd38e202296"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("144ab89e-265f-4d32-ac79-306ca985b5e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a46a0bb-5819-4180-8588-9f63cc0c5e8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1afcc9a1-6d97-429c-a328-9a64198c4abc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b552f57-4aa5-4d3d-80fe-8f9a2fa0e196"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1bd98bd6-d701-49c6-a6b2-51dca24daabc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c0bc965-dc20-4e4b-899c-8f42b4e6d1f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c5ccb34-9430-40d9-ab19-dda456075abf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c972d87-3712-4033-aa24-dcc06c54e2f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1dee34a6-3702-4b2b-90ee-3edbf0f3f885"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ee3a3bb-8191-4a43-99b9-edf6b10e8662"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1fa55c61-c48e-4cce-9882-bf1297a73d25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("202b1fee-fd4b-4971-babd-a41808692dbd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("211cda1a-5d26-4a12-92a0-6caed9b2a16e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("217491c1-0fa6-424f-8ce6-83e53d106008"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("22dd845f-2e66-4c7a-89af-0d09635f661e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2332d96c-5909-484a-a3e4-c5d140031854"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24e3b88c-7339-41e1-8863-d50f5df494af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24e6e5fe-6310-495d-89ed-d902c229778c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("261515d3-0ea0-4641-8179-88a42ed2a5c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26aeb05a-22d3-4621-a2c9-e4c75877cfb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26b0bc35-0e89-41e1-8997-ccef00310f45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29058c5c-aeef-4fd8-8e38-614bab43cff1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ca9a516-1084-4ba8-9886-69e2602be19f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d647d1c-c6ec-43e2-a5c2-4af609270042"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2da7dd2f-35cf-40df-a1e9-51856b99eccb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31c56b95-f994-4636-bcae-b0cb12af0b06"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34d54fe0-cb92-4f30-9796-817e1e22e725"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34f28d89-7eb2-45f3-987b-82b80670f1a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("351c302f-390c-4101-9976-c17d190e25b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3637bc31-cad9-4819-ac3c-2b96cdf0fa4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("368ef340-a460-4528-ba57-3a39c2bc94d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3884919f-f8e9-4f26-ac95-b63aa4c8b6ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("38d4adff-7943-47c0-b905-3e546b7af640"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("38df4665-8ef5-467b-a2e5-6308f1bc8582"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("390b2bdd-52ca-4462-976c-1fc45026d1b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a0cc9b3-cdfb-4223-8e57-7c3915ca2d08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a50bdf4-5d98-4d3b-a69d-c7ff7d3cb5ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3acd4d11-62ff-4b85-a09f-323a6b13bf57"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3dfd3ade-485e-4a0f-b707-e9bec778788c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e8a1907-4099-4037-8439-5fe2c1f622df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ebb4011-d5d4-4133-b2d2-fd13d7626117"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f06cecb-e45e-4bc2-87e5-8a1a4afaa16e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f0f3fbf-e870-48ec-bf41-987f1771df6b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f862269-9706-463c-ab93-6e0163556fc6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3fc3fb86-c417-4b32-a04f-72a61ad1ffb0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41c14f08-1031-4ebe-81bf-bfc90b15193c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4374401a-9e91-434a-92db-772b337222ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("440996a1-d9c7-433b-9d61-8b1a6c14f6a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("44749bd1-6ffd-40a9-bb1d-2199adceae5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45888f1b-fb4d-4e98-8232-4fbe62e4b78d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47624dfb-4da2-4417-a19e-87ee5f72a214"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47d3d1c0-de91-48aa-8758-fb8d1f884ee7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("486ba6b6-829e-4cfb-a17f-70d03e735567"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("486bcdcb-30c9-4d7a-a3df-33e0fff0a441"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49406440-4ab5-4ef4-ba1b-c8363f39a248"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49851770-52a5-4b6c-a585-a30b51eecf13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b55432f-116d-41bd-864a-55e4f0ed1442"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4cfb7e2c-1053-40de-83cf-f545597fc74f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d22af2b-a549-4fc8-920b-c59e1fb7904e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5039518f-4b71-4b66-8309-750932389f76"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("510c1b8a-38d5-4a79-b0c0-7e35aeb2f849"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("52cf840a-fa31-419c-a4d0-c99c04488236"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("540549a8-75f7-4929-8fae-9a089b4644de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5468d832-cf8f-44b2-a986-992225de6ba5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5510d9c8-87c6-4bce-8f08-7a551078b183"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55c88be5-7313-466c-9add-5a4401519655"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("568a9991-25e8-4ed3-b2fb-49169bf5b655"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5716d749-acb7-4d66-a644-e740c03a607b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5bff4d13-ec23-45e9-8b44-8dc779fcc8ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5cc572f6-177e-4f86-9962-0d595215d75a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e88ec47-d340-4372-87d3-935c1e03293c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ff9bf47-bc62-4a02-b08a-4d18528d3eba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65d6bbf6-ff83-4fc6-86c0-053b15fb4baf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("669ebf58-8389-4b04-979a-0fa190079a61"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6706ebc4-5d07-445b-b171-0fac1252210b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67a49f59-e442-4fd2-8118-34a68109fde9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a633955-fb31-4d7e-9371-8fb25691c20e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a9ca749-a489-4bcf-8440-845a260bd023"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6bd2e193-70cf-475e-8f07-d590e29cc35e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6bd9c307-3988-4709-b64c-2e3212a9f6c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6be53929-5c9b-42f4-89a8-ecfe25d78b4f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6dd474df-6eab-4720-ad44-44b54faed462"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f11bdbe-ef52-4766-9694-cadc7eb34913"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("713844ed-ba9a-491a-8999-0495b50577f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72986f4c-7946-4c2b-8a9d-ebcd2e9dedc4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("745ec8e6-ba71-492b-af50-6f9a8b911faa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("74f9e291-6b4f-4627-9471-4af6fc7baeee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7696088a-3d64-423e-be63-36c85bb59939"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("769d7eb6-28c5-4ceb-83d6-b17f579c21eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79912503-47b5-4e4b-a3fa-7f3815c75f9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7c0d69b2-5092-4a44-b86a-78622a0fb994"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7c8f62c9-2216-48a4-99ad-c69112207e63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f12851f-a744-4963-9297-51a8b9012eeb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80e97538-0f2a-4a61-939d-5c342d244f7e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("826021a1-70e5-44cf-8335-09bd9e4d42f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("850f34da-0666-4e17-b53e-ce6c5f405c06"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8916a39b-0e03-420f-a2a0-af53bffffbb0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8970d5f6-0501-4307-a0ba-0f75538125ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89d04e77-be76-4b0c-be23-76b78a4ab2ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b24ee85-b036-4132-b1a9-50bf877b172d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b30d322-e903-45e7-9ec2-c5d78bdb68be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93d87527-398e-4286-90b0-bef57f2d5b0a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("979e37f6-2b0f-47e1-b41a-f230393e1abb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9aa7af95-a421-4a4e-844a-63f086de014c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c13d193-2693-44b0-92cc-34b3520de082"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c7db7e4-e893-4b95-b620-e795223056a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ca20b73-03db-4be7-b5c0-ccb204f44e40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d795d48-4a0a-4857-9795-4fc40cfb1bfc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d7f7541-f071-46b8-9b28-44d5a701d394"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e9734f6-86e4-4d39-ab0a-85fbe609b770"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ff05672-47a9-45fd-9520-b451e18ff305"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0495bd2-110c-4e1b-b15e-cf8036de8c10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a248757a-8d35-49b1-b4f8-cbc16ee07d41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a59f501d-aac9-4f84-b3dc-7d4f1938b40d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a64e2909-7ffd-43fa-a359-17618e62d488"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a6b86d1e-5cc1-428d-9ef2-fe05257dc651"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a71c4359-37ac-4de1-85ff-14dbf4bf2d74"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a8bc6882-1433-494a-93b7-7fd25916bcd2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a91beb74-41a6-4163-a376-9cb6ee51a4c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa5adb28-3aab-4e7d-9b10-d27bea7b8c07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ace5d174-6019-439f-802b-828f2e1b0913"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("add562dd-86f6-480e-8724-e2f2f2b3de1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af98abd4-72a6-44ef-8468-daa26e554d0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b15ba8ec-2ed3-4863-9221-a897e8fde1d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2f31bc1-c43c-437d-b22c-4c92fb8ccbfa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5e528c2-f351-4b6c-9e79-0ac6efc776bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5ed5a3d-9631-4bf0-9344-77c54287116a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b65e6c04-d4a6-4ba3-b004-722d9bfdf382"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b9df90d6-b22d-4942-9a29-c6ebf0174576"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb6cbc67-66f2-4b8a-9690-07035521f9ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be3d8666-6154-4115-886f-edc0ca6b3de9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c1412c8c-66f3-41e0-be8e-049f2e74c05d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c20a0db1-dc47-4de7-a7c4-7c4cc7980994"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3c06a64-53ef-46ec-8934-dd0a86d4e4b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c75b334a-95a1-432e-b645-a045cd6f3d9a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cbdb4508-874e-47fd-b2a6-0b5f626eccf8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc4458cf-6c44-4684-aa59-15360266151f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd789399-87a7-4d85-9cc6-134b87312e10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce2bf619-a957-450f-84b5-117939af046b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce2c5bdf-b0e0-4ae9-aa2f-cc2be81de80e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce33e505-ffe6-4e13-b421-cc15e954bef5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1b1f36a-fca6-493a-a026-36abfa20a9a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3744a05-d30b-4f59-afa3-2eec1e0b632a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d5b0ab8c-83b0-4fcd-adae-241aeac25de3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d753af1e-79d6-4ece-bcec-ae19ab987f17"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9bdb07d-5e3e-43dd-86fc-7faa6d320043"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da468dc7-6734-425c-bc90-bafcb943b326"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddabb73a-fcab-47ff-aad1-9809cbbb47a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de879b39-735a-4d68-a95d-b6f43f3b530b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df0f9bfd-9bb6-4876-9c8b-6686653cc773"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df66a0b8-ea0e-4c46-94f0-ac79d63035a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e01cedb4-9990-46fb-83c4-c42268b67e7c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0f5fb10-b3aa-48bb-a300-3e84db187c90"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e10139e3-a1e2-4913-9801-9038f3cf844d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e363c141-6d1b-46d9-a054-a5f6b932f7fe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4027efa-2f43-4ec9-994b-02021724b896"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e41be010-049e-4cf7-888a-968cddc8dcaf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4db4241-c5b0-42e8-bf2c-367a975d1480"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4e4ae3c-dff9-40d4-9cb0-fd203dac568e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e775829c-1205-49ef-b806-f409d656e502"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7bcd677-0b16-4103-afe1-3ccd9e2f9445"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e90d0b37-6123-4859-a221-73e93a60cafb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea0abebb-8472-4265-bb1c-48fada4025cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb4f3f73-3dcf-459e-b805-e2dddee2d03b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ebe30489-b663-4be8-8168-5eb40cf08210"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed00984a-2cb2-4fb7-87e4-a7721bf55b13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1a25a7b-dec3-4dfb-bdec-d1aeebd40c4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2bb8f44-420b-41fe-855f-872c6b460bee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f35b67c9-9f7b-4841-b960-ed5454c05a95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f405bc72-76b6-40dc-8928-5a416710ed6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f566afd7-2578-4412-a5b5-2034ada1ac32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5d328a4-98c9-43d2-8bda-2371a0cc8e48"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f639a470-b16c-413a-9e24-7fbc765d3fda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f63df191-ff93-45bf-b845-2ab294a53ddb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f6b9409b-9768-4a8d-80aa-a8561252874f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f798c880-1367-4984-91f0-945eaf0e1af1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9b5bcae-0a4e-4da9-9f46-5e5402e8afd7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fba0729f-1367-40e5-91a9-a0dd6a8c3254"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc069785-84a9-4cbc-8b52-84c14789eb24"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ffdf2174-a986-4bdf-83ce-28747d150642"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("02f3799e-194f-48dc-9344-b821233486c3"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("d931b9fb-23a4-48a7-96cd-8995aeef6c40"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("14db295e-cdd8-4595-9e65-9a87272ccc75"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3696b1b4-ba89-4c97-add3-dfcd2ed27deb"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("499b816b-e364-4154-92a7-1cade1413415"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("65f90c23-7ccf-4e3a-920f-1278d45b953a"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("776f5a58-28cb-403e-8418-ae3768d5a3fd"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("80247486-4447-4711-af55-19e214043d4b"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("a86bfd5c-9767-4459-b79e-ad7451bc1b91"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("bb9f72e7-9708-484b-87ab-46cf48f05b0b"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("d98a1284-90c4-4f9c-8036-a903c35ebd9d"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f493526d-e4c9-43a5-904e-129fdb4fcc04"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Town",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "PhoneNumber");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "UserId");

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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("051f08a0-7ab5-45de-ba6e-62e5109ba6a6"), "JO", "Jordan" },
                    { new Guid("0b0f223d-95ea-411a-bb28-b338892682c6"), "HU", "Hungary" },
                    { new Guid("0b427d43-10d5-4d19-bd72-0aa4aeb8d9a9"), "MU", "Mauritius" },
                    { new Guid("0bbf8962-2ae8-4213-9f4c-6aaa0aee467b"), "BZ", "Belize" },
                    { new Guid("0d8c6231-feb5-4a4a-847f-5be684220c96"), "AM", "Armenia" },
                    { new Guid("0dfaa6dc-7fb2-4fe8-bba8-0a9dcf46240e"), "TD", "Chad" },
                    { new Guid("10a7a79c-d40b-4207-a7ba-215229955eb7"), "SC", "Seychelles" },
                    { new Guid("113103b8-0959-4fd0-9110-080425841582"), "PG", "Papua New Guinea" },
                    { new Guid("114ba59b-4216-4224-a68e-05bfefe7c889"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("171d2f29-3711-4ebc-a198-6f45402e4cac"), "SS", "South Sudan" },
                    { new Guid("17e2b084-2f7b-482a-baf7-14c5484c6191"), "CR", "Costa Rica" },
                    { new Guid("18c3052f-adfb-4d41-969a-95d6a1e77e4b"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("1b09df4d-6323-40dd-b512-895e21c5dc74"), "KM", "Comoros" },
                    { new Guid("1b54a447-33e4-4eae-9a20-e847031dd4d3"), "UA", "Ukraine" },
                    { new Guid("1bf9d35b-c511-4922-bbac-552d7f63d11c"), "PK", "Pakistan" },
                    { new Guid("1c5afb35-fd2f-45c0-b5cf-9ad1653d1c81"), "WS", "Samoa" },
                    { new Guid("1d9c5873-2db3-4590-ae7d-b434b223db14"), "SK", "Slovakia" },
                    { new Guid("1f0f8ada-0bfa-432a-83e3-8d3023fb59bf"), "KZ", "Kazakhstan" },
                    { new Guid("20a62c13-8f76-4e13-a4a6-86b03b940576"), "AU", "Australia" },
                    { new Guid("2219ef9b-3780-4587-87f9-4980444cc757"), "PY", "Paraguay" },
                    { new Guid("2336fa1d-6175-4c2d-9e92-79a5b6c67130"), "IE", "Ireland" },
                    { new Guid("24d04ca7-83b3-424c-be43-2413c03285ea"), "IR", "Iran" },
                    { new Guid("26a62cda-398c-4340-84b0-38e226eab685"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("26b7d21e-ccf8-4ab6-9b0f-99c37a0c600f"), "MT", "Malta" },
                    { new Guid("287ca53a-d3c3-44ec-86ac-67f991647208"), "SL", "Sierra Leone" },
                    { new Guid("2c6c5421-de83-452a-8f31-d7895cfb970c"), "NR", "Nauru" },
                    { new Guid("2c9d10df-50ba-4ba4-9362-68d346de6639"), "SR", "Suriname" },
                    { new Guid("2d48d9c0-a545-4dff-9877-784a64b80bd6"), "TG", "Togo" },
                    { new Guid("3252aea1-ec1e-490b-ab05-ce313c89c098"), "JM", "Jamaica" },
                    { new Guid("33b76bbc-78c4-4561-8274-222ac9379c6d"), "NO", "Norway" },
                    { new Guid("33dc2b78-eace-448f-98b9-cbb352affeca"), "PT", "Portugal" },
                    { new Guid("34b027aa-d624-4afb-bb9c-43f6412f4c19"), "FJ", "Fiji" },
                    { new Guid("362793ad-e8c8-456b-928b-0706a782fc8c"), "SI", "Slovenia" },
                    { new Guid("364447af-335f-438e-9cad-35779b6c6fec"), "DO", "Dominican Republic" },
                    { new Guid("38d1ed8b-ce2d-4c9f-b2bd-439487063a1d"), "RO", "Romania" },
                    { new Guid("390057b9-e443-40a4-b630-0b849ce2a98b"), "IN", "India" },
                    { new Guid("396f19d8-527c-4b2d-a832-0c860fbd831c"), "ES", "Spain" },
                    { new Guid("3a2fbf20-97fe-4c65-a1e1-d8dfe51d0de0"), "SM", "San Marino" },
                    { new Guid("3bab6a2b-0969-40cb-b6cd-84207f3092d0"), "UY", "Uruguay" },
                    { new Guid("3cad1b14-98a7-4c5c-93f9-baa9fb2b7277"), "BS", "Bahamas" },
                    { new Guid("41b3b9a8-8986-4569-aafc-340926b9920a"), "HT", "Haiti" },
                    { new Guid("421db52c-b8e9-42ed-b883-a2f6f5c20ffb"), "GN", "Guinea" },
                    { new Guid("45974480-b2c5-4b36-9389-a9ab29a4b2a8"), "HN", "Honduras" },
                    { new Guid("46d9ca6b-cc23-42f4-be00-adabba4071d2"), "NI", "Nicaragua" },
                    { new Guid("46e9aad2-2f9e-4737-bb5e-98fb2dba8e50"), "TZ", "Tanzania" },
                    { new Guid("47da6326-ae48-4f7b-9846-7938d26389c3"), "UZ", "Uzbekistan" },
                    { new Guid("47f0a36b-99c4-4759-b494-02005dfc7b22"), "IL", "Israel" },
                    { new Guid("49857670-4f44-4ede-9903-b56924f1ef88"), "SA", "Saudi Arabia" },
                    { new Guid("4d44d03f-0d51-40b1-a397-78112364165d"), "MV", "Maldives" },
                    { new Guid("4e2050c9-40a1-4338-80b9-4f6ae7d3980c"), "VA", "Vatican City" },
                    { new Guid("50db5966-a9d7-4de4-a638-abc7d17cf1a5"), "GB", "United Kingdom" },
                    { new Guid("517ea330-5fad-4f99-a204-c705892582f2"), "GD", "Grenada" },
                    { new Guid("51db5986-c5aa-4901-b787-e188eae5a779"), "ID", "Indonesia" },
                    { new Guid("51ec4440-4202-4fc5-b820-5afcf21684ae"), "PE", "Peru" },
                    { new Guid("52d5ed53-6455-425b-8b51-c23874ca7873"), "PH", "Philippines" },
                    { new Guid("53a03445-3492-4e37-9c42-47cebd8efb73"), "PA", "Panama" },
                    { new Guid("57443e03-6da6-4c39-8853-0acdfecd3adf"), "DJ", "Djibouti" },
                    { new Guid("58169776-710e-4153-8110-11900c6182ae"), "PL", "Poland" },
                    { new Guid("596cf380-7d51-4f33-8d3a-eeed937f4721"), "KH", "Cambodia" },
                    { new Guid("5a5f85c4-a00c-49d0-afb8-282e46e253ff"), "ER", "Eritrea" },
                    { new Guid("5c22082e-c009-4f5f-acaf-e34719e837ef"), "AT", "Austria" },
                    { new Guid("5da98222-f223-470b-a788-57a86512a70c"), "BI", "Burundi" },
                    { new Guid("5debbdbd-85f5-4e1b-a0ee-6172fb5e3839"), "RW", "Rwanda" },
                    { new Guid("5f504172-e1a2-47df-a156-017cb51d6f4d"), "MR", "Mauritania" },
                    { new Guid("603203f9-3375-4b27-976b-d775c5d7a06f"), "IT", "Italy" },
                    { new Guid("6075b28f-bb3b-4ce6-b7c1-f2feafa30741"), "LU", "Luxembourg" },
                    { new Guid("63a9adb2-4f92-4ebb-bb9d-dc73f12baf2b"), "BT", "Bhutan" },
                    { new Guid("66a99efc-1b85-4449-a24b-8fbaf208e7b5"), "TR", "Turkey" },
                    { new Guid("672810f3-b149-45b4-bb25-5b9786ddf618"), "TO", "Tonga" },
                    { new Guid("67338ae5-67a1-4a94-9937-6f2513057320"), "DZ", "Algeria" },
                    { new Guid("673fc462-3536-4af2-b7b7-c12d15a31932"), "LC", "Saint Lucia" },
                    { new Guid("67b10ced-e2d0-47af-8e2a-020a721d228c"), "VU", "Vanuatu" },
                    { new Guid("69fa3b26-dbc6-4406-8dbd-205bcc15983b"), "BY", "Belarus" },
                    { new Guid("6a34438a-37ee-4550-884d-08b298b5cbbc"), "CH", "Switzerland" },
                    { new Guid("6ab68092-44b2-4fb3-a953-d0d60bf01182"), "BN", "Brunei" },
                    { new Guid("6ba1f494-e082-4a22-a03c-6a163070ea0b"), "SB", "Solomon Islands" },
                    { new Guid("6ba44f75-43e8-4f05-a8f3-c4bd04757153"), "KP", "North Korea" },
                    { new Guid("6d198c27-e767-4d05-94b2-13147d953e01"), "HR", "Croatia" },
                    { new Guid("6dbfa659-0b12-4ea7-8610-fc2b24a53723"), "NZ", "New Zealand" },
                    { new Guid("6ea2df45-1128-4719-b036-f039fbad7731"), "GM", "Gambia" },
                    { new Guid("6f8b1783-6ada-4ff1-b1e4-9efd07eea09a"), "AD", "Andorra" },
                    { new Guid("6fd1315e-7a09-4302-a2e0-1e39d5c9fdb0"), "GY", "Guyana" },
                    { new Guid("6feeebb4-ab69-4d49-9776-1646d905f4e9"), "BD", "Bangladesh" },
                    { new Guid("722011c3-632e-45e9-93c7-c1fa708c8a4c"), "IQ", "Iraq" },
                    { new Guid("748dda03-14f3-453f-a2ee-f2e459d452c4"), "SY", "Syria" },
                    { new Guid("74c929d4-ccd5-4c9d-9e18-9253b63f1ebf"), "DE", "Germany" },
                    { new Guid("78a3306c-5fac-4bd1-8630-4cd92e397aae"), "TL", "Timor-Leste" },
                    { new Guid("7cac18f1-9b67-4ced-9890-db4019635de7"), "OM", "Oman" },
                    { new Guid("7de1cfea-b320-4b26-91f0-5ff04bedcf12"), "LT", "Lithuania" },
                    { new Guid("7e88b549-3bf8-4cb8-8766-cf4a1c641ffe"), "CV", "Cabo Verde" },
                    { new Guid("80de2c46-455b-472c-a4f3-e2b3328d8fd7"), "BF", "Burkina Faso" },
                    { new Guid("81b989cc-a912-4d7e-83c0-2d4acf0aab1f"), "BR", "Brazil" },
                    { new Guid("87774d93-86aa-43ac-b8e1-3a20a34d2200"), "GW", "Guinea-Bissau" },
                    { new Guid("888d3d32-8d82-45b7-8aa0-a87469b8449f"), "MH", "Marshall Islands" },
                    { new Guid("89e4be32-b4b7-4662-8ab7-403f4c979d5e"), "SV", "El Salvador" },
                    { new Guid("8a08f8e4-d078-41f6-8917-54a32244650a"), "GA", "Gabon" },
                    { new Guid("8be8dcca-c7cf-4471-a6fb-181b73cdd070"), "CO", "Colombia" },
                    { new Guid("8d32eef5-057d-4aed-9fe5-6025f3654b0b"), "LY", "Libya" },
                    { new Guid("8f9b1c49-12a5-4ade-8686-7f35f66a6e79"), "AL", "Albania" },
                    { new Guid("924552d2-97d9-4333-9853-ae6cd9eb6af7"), "TH", "Thailand" },
                    { new Guid("94f157f2-1ccd-447b-8c11-b1790b663579"), "ZM", "Zambia" },
                    { new Guid("95643ff7-ab01-42e7-80b5-0668c8f14a86"), "MW", "Malawi" },
                    { new Guid("95dd899d-47f6-4934-b314-70f001275d4a"), "KW", "Kuwait" },
                    { new Guid("963b3ab0-7ef5-45e4-8010-dc817d91c502"), "SG", "Singapore" },
                    { new Guid("97152ac1-d5ba-40c5-bd0e-5d7d4b587a89"), "CM", "Cameroon" },
                    { new Guid("9a373c65-a8d2-454c-ab5a-251783e8bde2"), "QA", "Qatar" },
                    { new Guid("9c87f51f-e6e6-4f98-b64b-b261a38bf587"), "CL", "Chile" },
                    { new Guid("9d261e52-48f5-4884-98c0-6808cade9140"), "ZW", "Zimbabwe" },
                    { new Guid("9e446595-993d-44b7-9da7-8102c0f274c1"), "CU", "Cuba" },
                    { new Guid("9e787f4b-51d9-439c-b012-1f55e4a564ab"), "MX", "Mexico" },
                    { new Guid("a03d01c7-3982-412b-9c9f-2dd0fe7a206c"), "KE", "Kenya" },
                    { new Guid("a07396f9-97e0-49d3-bb56-bdf07bd16e71"), "GH", "Ghana" },
                    { new Guid("a2f7c7ca-5bd6-41eb-b3ad-5c109715531b"), "KG", "Kyrgyzstan" },
                    { new Guid("a3372725-83a6-4a7c-bea4-790049bb0ec6"), "KI", "Kiribati" },
                    { new Guid("a361edf7-7969-4e72-b050-4701c3bb9624"), "BB", "Barbados" },
                    { new Guid("a59bee1f-d19f-435f-8823-498b4d148487"), "MD", "Moldova" },
                    { new Guid("a60a495d-c13e-48db-b885-f4b8a538a5f6"), "EE", "Estonia" },
                    { new Guid("a6395c42-c554-473a-8d6d-318d5117c71a"), "SZ", "Eswatini" },
                    { new Guid("a9b42942-33ff-4450-947a-e0f09ea1563f"), "CY", "Cyprus" },
                    { new Guid("aa2db52b-5e54-49db-b520-b340f78bb272"), "MN", "Mongolia" },
                    { new Guid("aa30b1bb-2561-4154-a8ce-9a63676285ff"), "MZ", "Mozambique" },
                    { new Guid("aaeb0899-f9c7-425e-b772-2fc8a0cd6e6a"), "EG", "Egypt" },
                    { new Guid("ab3e1f65-fdc4-4369-8352-f36556680c13"), "TV", "Tuvalu" },
                    { new Guid("abe69d9a-2d00-4506-9320-ad2e1393fbcd"), "BE", "Belgium" },
                    { new Guid("acd3137a-a300-42b1-ab9f-7e3c66f1e240"), "DK", "Denmark" },
                    { new Guid("ad1655e9-6a63-4c63-8555-58f9d20a7413"), "VA", "Holy See" },
                    { new Guid("afdde494-a3c2-4ecb-854b-f134a03fec1a"), "YE", "Yemen" },
                    { new Guid("afe4bb99-f8cc-4d5b-9c8d-3ccff7dfb38d"), "NP", "Nepal" },
                    { new Guid("b0ae6732-e5b0-446a-b2e5-3febf86fe5b8"), "LA", "Laos" },
                    { new Guid("b0c3de2d-7add-47eb-9767-9b413008745e"), "PS", "Palestine" },
                    { new Guid("b116494e-d14e-419c-863e-66cb793a43e3"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("b175c335-f1b8-4e4b-8f88-53cfdc3234fd"), "LK", "Sri Lanka" },
                    { new Guid("b1a2b89d-4427-4255-b88c-62c958d47245"), "NA", "Namibia" },
                    { new Guid("b1c3bb45-f361-4002-9a74-247805536dc4"), "CN", "China" },
                    { new Guid("b1e6bb19-25a9-4258-8582-f6147e92b658"), "BG", "Bulgaria" },
                    { new Guid("b34879c9-0b72-4bd2-8363-91f6e406f254"), "GR", "Greece" },
                    { new Guid("b3da325c-6189-45c5-bfea-83f72feba709"), "TM", "Turkmenistan" },
                    { new Guid("b93502d7-6ba5-4a0c-9595-664bb21900a6"), "DM", "Dominica" },
                    { new Guid("bad004cb-926b-4f54-8ac6-aaaacc1e8f09"), "LS", "Lesotho" },
                    { new Guid("bbf925db-c66c-49ce-8c48-4d33a7223535"), "LR", "Liberia" },
                    { new Guid("bc722ccc-0b99-4df2-b6b0-98e76ccbf1c7"), "FM", "Micronesia" },
                    { new Guid("bd4e15f7-9bd8-44c6-8869-43f4494665e6"), "RS", "Serbia" },
                    { new Guid("be6b7711-af64-4431-b5c9-3c35257a173b"), "CA", "Canada" },
                    { new Guid("bef1c61f-7a70-4332-b72f-b442fae545be"), "SO", "Somalia" },
                    { new Guid("bf460290-6304-43fb-b41d-398fb35601da"), "AF", "Afghanistan" },
                    { new Guid("bf512eb7-35e9-4b59-a3c5-4e7efa712e4f"), "AR", "Argentina" },
                    { new Guid("c0773799-f320-4f73-b8fe-710820d8b277"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("c35a3b86-fa77-42b2-817f-560fef30ea52"), "TT", "Trinidad and Tobago" },
                    { new Guid("c4be1343-214d-4843-8a63-852727a60e18"), "BJ", "Benin" },
                    { new Guid("c5cdaf96-a3f4-4502-ab8f-dad216a611e1"), "LV", "Latvia" },
                    { new Guid("c66baee6-c9b6-4cab-aa5f-59c580f0ec29"), "JP", "Japan" },
                    { new Guid("ca297afe-dcf5-4e00-8bf5-9104002bf6be"), "RU", "Russia" },
                    { new Guid("ca58c5c0-a147-4bea-bbef-8addcad8e6bb"), "KR", "South Korea" },
                    { new Guid("ca9f4245-869a-4ab1-bce5-130412333298"), "VE", "Venezuela" },
                    { new Guid("cabcf657-a516-442f-93d1-0f3577d19b9f"), "PW", "Palau" },
                    { new Guid("cc82ab29-689b-4827-b59e-89ba7d76f99a"), "TN", "Tunisia" },
                    { new Guid("ccfaf070-2b7b-4751-9e3f-5ca55d0ee40f"), "ET", "Ethiopia" },
                    { new Guid("cda8b27f-8022-4931-8c2a-3ae54066955a"), "MM", "Myanmar" },
                    { new Guid("cdf604c2-9f12-4622-9c66-5865c536ad6a"), "US", "United States of America" },
                    { new Guid("ce105847-88be-422f-b0df-565b836fabb6"), "AE", "United Arab Emirates" },
                    { new Guid("d1e85da8-d2e4-4cbf-9e8e-cca361183aac"), "NG", "Nigeria" },
                    { new Guid("d298346a-e21d-4819-a860-23cf21958b87"), "BW", "Botswana" },
                    { new Guid("d2c2d1bd-4f67-4eb3-853f-c802ac9f7f08"), "BH", "Bahrain" },
                    { new Guid("d6126cb8-8824-418b-b93e-3916dd3294b4"), "UG", "Uganda" },
                    { new Guid("d859bd06-42f3-4415-9a9b-e6de7305f18f"), "BO", "Bolivia" },
                    { new Guid("d9e4d1e8-ef37-405e-a0ec-cb23d0e6edf4"), "AZ", "Azerbaijan" },
                    { new Guid("dc56c650-bc25-4c20-8251-30d3917b1ea5"), "GQ", "Equatorial Guinea" },
                    { new Guid("dc6feeee-d2f2-4672-874a-7622acf1b6ca"), "SD", "Sudan" },
                    { new Guid("de1fc633-7727-4946-9b7a-b45ed941c7e9"), "FR", "France" },
                    { new Guid("e0b2c607-1a63-468b-b510-d8ed6eda3e22"), "IS", "Iceland" },
                    { new Guid("e1f34a42-4910-4a24-8125-c45c010899b9"), "SN", "Senegal" },
                    { new Guid("e2bda067-ede5-4ce2-9bb7-893091db8b5a"), "MG", "Madagascar" },
                    { new Guid("e4d297c2-2cd3-47f1-9a06-956878d99fdb"), "ST", "Sao Tome and Principe" },
                    { new Guid("e4d4752b-60c0-4ded-b933-3d9a99c881f8"), "ML", "Mali" },
                    { new Guid("e5534727-8103-42b3-b479-7d816ed6897f"), "GE", "Georgia" },
                    { new Guid("e60873f6-478c-4104-8a6c-d21f38204a59"), "LB", "Lebanon" },
                    { new Guid("e6850ebc-5ded-475f-aa45-65ec4cc9e514"), "NE", "Niger" },
                    { new Guid("e7106164-d00d-478a-8b3e-99dad78a3b12"), "NL", "Netherlands" },
                    { new Guid("ed1d2d0c-0390-45e5-b11e-ea94a185efaf"), "MA", "Morocco" },
                    { new Guid("ed6d4f21-b281-4fb0-a6f2-1189f6b008bd"), "ZA", "South Africa" },
                    { new Guid("edb9fa7f-a51d-48ca-a2a7-680d2b170dfa"), "ME", "Montenegro" },
                    { new Guid("f0125358-a9ee-4e50-a99d-6a053d8d4f38"), "SE", "Sweden" },
                    { new Guid("f064f8e8-560c-44d1-871a-7f92bb67d4c8"), "MY", "Malaysia" },
                    { new Guid("f0c19ab3-6a66-407b-98a3-30aef72bcc50"), "TJ", "Tajikistan" },
                    { new Guid("f22b7f0c-c316-4c48-b1da-192591cd329b"), "MC", "Monaco" },
                    { new Guid("f855b6ff-18e4-4c74-8ebc-868237ef93c4"), "AG", "Antigua and Barbuda" },
                    { new Guid("f85a2a41-7892-4eaa-9689-146a3ee63a3a"), "FI", "Finland" },
                    { new Guid("fb2f24cb-44d1-43bb-b4ae-cdfa52971cf8"), "AO", "Angola" },
                    { new Guid("fb6351c6-ee7e-41c9-9f23-6a9305ad332b"), "LI", "Liechtenstein" },
                    { new Guid("fbee809a-0f56-4707-813a-aa5fb4b1bb96"), "VN", "Vietnam" },
                    { new Guid("fde5c9b3-3f81-4b99-833e-5281153bf2ce"), "CF", "Central African Republic" },
                    { new Guid("fe69554d-51e4-48f7-8675-3db093b88960"), "GT", "Guatemala" },
                    { new Guid("ff128fa6-b30b-46b7-b009-d3c93621cf3d"), "MK", "North Macedonia" },
                    { new Guid("ff54dcc2-9f59-497c-8bc2-52d1e3b1e892"), "EC", "Ecuador" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3581983f-0932-4559-b295-10ba5657a802"), "Female" },
                    { new Guid("433b36fc-3490-49de-9811-49b4d85e3ca8"), "Male" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("29a743b1-3d57-4a0b-b80c-7b91d7036f02"), "Preventive Interventions" },
                    { new Guid("3c5c2b8f-8455-471b-bee9-f69d64b1e368"), "Dental Interventions" },
                    { new Guid("4495f125-9498-4e71-8a7c-d040fbd74d07"), "Oncological Interventions" },
                    { new Guid("6207e53a-f0b8-4537-9028-0a9e583bc83f"), "Exotic and Specialized Interventions" },
                    { new Guid("6fe4ef51-9f02-4846-b95a-9b85ae379048"), "Therapeutic Interventions" },
                    { new Guid("869639fd-29ff-4d7f-b3df-374e546784e9"), "Emergency" },
                    { new Guid("901000ec-f24d-4d52-9e89-9ece70265922"), "Postoperative Care" },
                    { new Guid("9c8d2a93-bb43-4773-b919-5f83f0c5fd1a"), "Obstetric and Reproductive Interventions" },
                    { new Guid("a6186404-e9aa-483f-bc6e-a33ee5c23df7"), "Surgical Interventions" },
                    { new Guid("b0ea9311-335a-48eb-b6e4-3c58a4b81730"), "Diagnostic Interventions" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_CountryId",
                table: "UserDetails",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_UserDetails_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interventions_UserDetails_UserId",
                table: "Interventions",
                column: "UserId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookings_UserDetails_UserDetailsId",
                table: "UserBookings",
                column: "UserDetailsId",
                principalTable: "UserDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailsApplicationUsers_AspNetUsers_ApplicationUserId",
                table: "UserDetailsApplicationUsers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailsApplicationUsers_UserDetails_UserDetailsId",
                table: "UserDetailsApplicationUsers",
                column: "UserDetailsId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailsPets_UserDetails_UserDetailsId",
                table: "UserDetailsPets",
                column: "UserDetailsId",
                principalTable: "UserDetails",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_UserDetails_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Interventions_UserDetails_UserId",
                table: "Interventions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBookings_UserDetails_UserDetailsId",
                table: "UserBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailsApplicationUsers_AspNetUsers_ApplicationUserId",
                table: "UserDetailsApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailsApplicationUsers_UserDetails_UserDetailsId",
                table: "UserDetailsApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailsPets_UserDetails_UserDetailsId",
                table: "UserDetailsPets");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("051f08a0-7ab5-45de-ba6e-62e5109ba6a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b0f223d-95ea-411a-bb28-b338892682c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b427d43-10d5-4d19-bd72-0aa4aeb8d9a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0bbf8962-2ae8-4213-9f4c-6aaa0aee467b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d8c6231-feb5-4a4a-847f-5be684220c96"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0dfaa6dc-7fb2-4fe8-bba8-0a9dcf46240e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("10a7a79c-d40b-4207-a7ba-215229955eb7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("113103b8-0959-4fd0-9110-080425841582"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("114ba59b-4216-4224-a68e-05bfefe7c889"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("171d2f29-3711-4ebc-a198-6f45402e4cac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17e2b084-2f7b-482a-baf7-14c5484c6191"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18c3052f-adfb-4d41-969a-95d6a1e77e4b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b09df4d-6323-40dd-b512-895e21c5dc74"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b54a447-33e4-4eae-9a20-e847031dd4d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1bf9d35b-c511-4922-bbac-552d7f63d11c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c5afb35-fd2f-45c0-b5cf-9ad1653d1c81"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d9c5873-2db3-4590-ae7d-b434b223db14"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1f0f8ada-0bfa-432a-83e3-8d3023fb59bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20a62c13-8f76-4e13-a4a6-86b03b940576"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2219ef9b-3780-4587-87f9-4980444cc757"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2336fa1d-6175-4c2d-9e92-79a5b6c67130"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24d04ca7-83b3-424c-be43-2413c03285ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26a62cda-398c-4340-84b0-38e226eab685"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26b7d21e-ccf8-4ab6-9b0f-99c37a0c600f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("287ca53a-d3c3-44ec-86ac-67f991647208"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c6c5421-de83-452a-8f31-d7895cfb970c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c9d10df-50ba-4ba4-9362-68d346de6639"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d48d9c0-a545-4dff-9877-784a64b80bd6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3252aea1-ec1e-490b-ab05-ce313c89c098"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33b76bbc-78c4-4561-8274-222ac9379c6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33dc2b78-eace-448f-98b9-cbb352affeca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34b027aa-d624-4afb-bb9c-43f6412f4c19"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("362793ad-e8c8-456b-928b-0706a782fc8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("364447af-335f-438e-9cad-35779b6c6fec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("38d1ed8b-ce2d-4c9f-b2bd-439487063a1d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("390057b9-e443-40a4-b630-0b849ce2a98b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("396f19d8-527c-4b2d-a832-0c860fbd831c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a2fbf20-97fe-4c65-a1e1-d8dfe51d0de0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3bab6a2b-0969-40cb-b6cd-84207f3092d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3cad1b14-98a7-4c5c-93f9-baa9fb2b7277"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41b3b9a8-8986-4569-aafc-340926b9920a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("421db52c-b8e9-42ed-b883-a2f6f5c20ffb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45974480-b2c5-4b36-9389-a9ab29a4b2a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46d9ca6b-cc23-42f4-be00-adabba4071d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46e9aad2-2f9e-4737-bb5e-98fb2dba8e50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47da6326-ae48-4f7b-9846-7938d26389c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47f0a36b-99c4-4759-b494-02005dfc7b22"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49857670-4f44-4ede-9903-b56924f1ef88"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d44d03f-0d51-40b1-a397-78112364165d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4e2050c9-40a1-4338-80b9-4f6ae7d3980c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("50db5966-a9d7-4de4-a638-abc7d17cf1a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("517ea330-5fad-4f99-a204-c705892582f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51db5986-c5aa-4901-b787-e188eae5a779"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51ec4440-4202-4fc5-b820-5afcf21684ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("52d5ed53-6455-425b-8b51-c23874ca7873"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53a03445-3492-4e37-9c42-47cebd8efb73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("57443e03-6da6-4c39-8853-0acdfecd3adf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58169776-710e-4153-8110-11900c6182ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("596cf380-7d51-4f33-8d3a-eeed937f4721"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a5f85c4-a00c-49d0-afb8-282e46e253ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c22082e-c009-4f5f-acaf-e34719e837ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5da98222-f223-470b-a788-57a86512a70c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5debbdbd-85f5-4e1b-a0ee-6172fb5e3839"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f504172-e1a2-47df-a156-017cb51d6f4d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("603203f9-3375-4b27-976b-d775c5d7a06f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6075b28f-bb3b-4ce6-b7c1-f2feafa30741"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63a9adb2-4f92-4ebb-bb9d-dc73f12baf2b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66a99efc-1b85-4449-a24b-8fbaf208e7b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("672810f3-b149-45b4-bb25-5b9786ddf618"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67338ae5-67a1-4a94-9937-6f2513057320"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("673fc462-3536-4af2-b7b7-c12d15a31932"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67b10ced-e2d0-47af-8e2a-020a721d228c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69fa3b26-dbc6-4406-8dbd-205bcc15983b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a34438a-37ee-4550-884d-08b298b5cbbc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ab68092-44b2-4fb3-a953-d0d60bf01182"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ba1f494-e082-4a22-a03c-6a163070ea0b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ba44f75-43e8-4f05-a8f3-c4bd04757153"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6d198c27-e767-4d05-94b2-13147d953e01"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6dbfa659-0b12-4ea7-8610-fc2b24a53723"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ea2df45-1128-4719-b036-f039fbad7731"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f8b1783-6ada-4ff1-b1e4-9efd07eea09a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fd1315e-7a09-4302-a2e0-1e39d5c9fdb0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6feeebb4-ab69-4d49-9776-1646d905f4e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("722011c3-632e-45e9-93c7-c1fa708c8a4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("748dda03-14f3-453f-a2ee-f2e459d452c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("74c929d4-ccd5-4c9d-9e18-9253b63f1ebf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78a3306c-5fac-4bd1-8630-4cd92e397aae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7cac18f1-9b67-4ced-9890-db4019635de7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7de1cfea-b320-4b26-91f0-5ff04bedcf12"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e88b549-3bf8-4cb8-8766-cf4a1c641ffe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80de2c46-455b-472c-a4f3-e2b3328d8fd7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81b989cc-a912-4d7e-83c0-2d4acf0aab1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87774d93-86aa-43ac-b8e1-3a20a34d2200"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("888d3d32-8d82-45b7-8aa0-a87469b8449f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89e4be32-b4b7-4662-8ab7-403f4c979d5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a08f8e4-d078-41f6-8917-54a32244650a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8be8dcca-c7cf-4471-a6fb-181b73cdd070"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d32eef5-057d-4aed-9fe5-6025f3654b0b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f9b1c49-12a5-4ade-8686-7f35f66a6e79"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("924552d2-97d9-4333-9853-ae6cd9eb6af7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("94f157f2-1ccd-447b-8c11-b1790b663579"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95643ff7-ab01-42e7-80b5-0668c8f14a86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95dd899d-47f6-4934-b314-70f001275d4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("963b3ab0-7ef5-45e4-8010-dc817d91c502"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97152ac1-d5ba-40c5-bd0e-5d7d4b587a89"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a373c65-a8d2-454c-ab5a-251783e8bde2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c87f51f-e6e6-4f98-b64b-b261a38bf587"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d261e52-48f5-4884-98c0-6808cade9140"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e446595-993d-44b7-9da7-8102c0f274c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e787f4b-51d9-439c-b012-1f55e4a564ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a03d01c7-3982-412b-9c9f-2dd0fe7a206c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a07396f9-97e0-49d3-bb56-bdf07bd16e71"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2f7c7ca-5bd6-41eb-b3ad-5c109715531b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3372725-83a6-4a7c-bea4-790049bb0ec6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a361edf7-7969-4e72-b050-4701c3bb9624"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a59bee1f-d19f-435f-8823-498b4d148487"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a60a495d-c13e-48db-b885-f4b8a538a5f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a6395c42-c554-473a-8d6d-318d5117c71a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9b42942-33ff-4450-947a-e0f09ea1563f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa2db52b-5e54-49db-b520-b340f78bb272"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa30b1bb-2561-4154-a8ce-9a63676285ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aaeb0899-f9c7-425e-b772-2fc8a0cd6e6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ab3e1f65-fdc4-4369-8352-f36556680c13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("abe69d9a-2d00-4506-9320-ad2e1393fbcd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("acd3137a-a300-42b1-ab9f-7e3c66f1e240"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad1655e9-6a63-4c63-8555-58f9d20a7413"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afdde494-a3c2-4ecb-854b-f134a03fec1a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afe4bb99-f8cc-4d5b-9c8d-3ccff7dfb38d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0ae6732-e5b0-446a-b2e5-3febf86fe5b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0c3de2d-7add-47eb-9767-9b413008745e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b116494e-d14e-419c-863e-66cb793a43e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b175c335-f1b8-4e4b-8f88-53cfdc3234fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1a2b89d-4427-4255-b88c-62c958d47245"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1c3bb45-f361-4002-9a74-247805536dc4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1e6bb19-25a9-4258-8582-f6147e92b658"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b34879c9-0b72-4bd2-8363-91f6e406f254"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3da325c-6189-45c5-bfea-83f72feba709"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b93502d7-6ba5-4a0c-9595-664bb21900a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bad004cb-926b-4f54-8ac6-aaaacc1e8f09"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bbf925db-c66c-49ce-8c48-4d33a7223535"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc722ccc-0b99-4df2-b6b0-98e76ccbf1c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd4e15f7-9bd8-44c6-8869-43f4494665e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be6b7711-af64-4431-b5c9-3c35257a173b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bef1c61f-7a70-4332-b72f-b442fae545be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf460290-6304-43fb-b41d-398fb35601da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf512eb7-35e9-4b59-a3c5-4e7efa712e4f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0773799-f320-4f73-b8fe-710820d8b277"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c35a3b86-fa77-42b2-817f-560fef30ea52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4be1343-214d-4843-8a63-852727a60e18"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5cdaf96-a3f4-4502-ab8f-dad216a611e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c66baee6-c9b6-4cab-aa5f-59c580f0ec29"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca297afe-dcf5-4e00-8bf5-9104002bf6be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca58c5c0-a147-4bea-bbef-8addcad8e6bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca9f4245-869a-4ab1-bce5-130412333298"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cabcf657-a516-442f-93d1-0f3577d19b9f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc82ab29-689b-4827-b59e-89ba7d76f99a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ccfaf070-2b7b-4751-9e3f-5ca55d0ee40f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cda8b27f-8022-4931-8c2a-3ae54066955a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdf604c2-9f12-4622-9c66-5865c536ad6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce105847-88be-422f-b0df-565b836fabb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1e85da8-d2e4-4cbf-9e8e-cca361183aac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d298346a-e21d-4819-a860-23cf21958b87"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d2c2d1bd-4f67-4eb3-853f-c802ac9f7f08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6126cb8-8824-418b-b93e-3916dd3294b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d859bd06-42f3-4415-9a9b-e6de7305f18f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9e4d1e8-ef37-405e-a0ec-cb23d0e6edf4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc56c650-bc25-4c20-8251-30d3917b1ea5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc6feeee-d2f2-4672-874a-7622acf1b6ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de1fc633-7727-4946-9b7a-b45ed941c7e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0b2c607-1a63-468b-b510-d8ed6eda3e22"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e1f34a42-4910-4a24-8125-c45c010899b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e2bda067-ede5-4ce2-9bb7-893091db8b5a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4d297c2-2cd3-47f1-9a06-956878d99fdb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4d4752b-60c0-4ded-b933-3d9a99c881f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e5534727-8103-42b3-b479-7d816ed6897f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e60873f6-478c-4104-8a6c-d21f38204a59"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6850ebc-5ded-475f-aa45-65ec4cc9e514"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7106164-d00d-478a-8b3e-99dad78a3b12"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed1d2d0c-0390-45e5-b11e-ea94a185efaf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed6d4f21-b281-4fb0-a6f2-1189f6b008bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("edb9fa7f-a51d-48ca-a2a7-680d2b170dfa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0125358-a9ee-4e50-a99d-6a053d8d4f38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f064f8e8-560c-44d1-871a-7f92bb67d4c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0c19ab3-6a66-407b-98a3-30aef72bcc50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f22b7f0c-c316-4c48-b1da-192591cd329b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f855b6ff-18e4-4c74-8ebc-868237ef93c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f85a2a41-7892-4eaa-9689-146a3ee63a3a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb2f24cb-44d1-43bb-b4ae-cdfa52971cf8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb6351c6-ee7e-41c9-9f23-6a9305ad332b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fbee809a-0f56-4707-813a-aa5fb4b1bb96"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fde5c9b3-3f81-4b99-833e-5281153bf2ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe69554d-51e4-48f7-8675-3db093b88960"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff128fa6-b30b-46b7-b009-d3c93621cf3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff54dcc2-9f59-497c-8bc2-52d1e3b1e892"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("3581983f-0932-4559-b295-10ba5657a802"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("433b36fc-3490-49de-9811-49b4d85e3ca8"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("29a743b1-3d57-4a0b-b80c-7b91d7036f02"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3c5c2b8f-8455-471b-bee9-f69d64b1e368"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("4495f125-9498-4e71-8a7c-d040fbd74d07"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("6207e53a-f0b8-4537-9028-0a9e583bc83f"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("6fe4ef51-9f02-4846-b95a-9b85ae379048"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("869639fd-29ff-4d7f-b3df-374e546784e9"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("901000ec-f24d-4d52-9e89-9ece70265922"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("9c8d2a93-bb43-4773-b919-5f83f0c5fd1a"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("a6186404-e9aa-483f-bc6e-a33ee5c23df7"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("b0ea9311-335a-48eb-b6e4-3c58a4b81730"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "PhoneNumber",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                comment: "UserId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                comment: "Address");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "CountryId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "ImageUrl");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "UserDetailsSoftDeleted");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "Town",
                table: "AspNetUsers",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                comment: "Town");

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("001a8880-3a86-4662-9700-fed0efbdfc18"), "IR", "Iran" },
                    { new Guid("019ea4a7-97bf-4b32-a4d0-585ada74d5f7"), "BI", "Burundi" },
                    { new Guid("026e6c04-7538-48d4-8672-1b5f29f9d5c9"), "UY", "Uruguay" },
                    { new Guid("027d7f27-43ef-42dd-9fac-993c0ac66246"), "NG", "Nigeria" },
                    { new Guid("069eaa5b-09fc-4f2a-b892-a3feaa4011c8"), "DM", "Dominica" },
                    { new Guid("06f89017-2a24-44f6-9767-b51a376fc8f7"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("07199ab7-325a-4a8e-a2a6-58e1eaed24bf"), "AE", "United Arab Emirates" },
                    { new Guid("0b1ca580-e4bf-4aca-909b-10241207b7ed"), "SD", "Sudan" },
                    { new Guid("0c59c08f-9676-4409-9195-b8d411264d45"), "AT", "Austria" },
                    { new Guid("0f17842e-5305-482c-94bc-bf8179eb5a8f"), "SZ", "Eswatini" },
                    { new Guid("0f91a6c4-2e89-45fb-b198-2eed4f143eef"), "AU", "Australia" },
                    { new Guid("117f7de1-6b9b-457f-a43b-42664a1c6f91"), "FJ", "Fiji" },
                    { new Guid("11d7438e-5906-4562-911f-761b72a1d5df"), "IS", "Iceland" },
                    { new Guid("1336d3fb-2302-40ee-922b-1fd38e202296"), "LC", "Saint Lucia" },
                    { new Guid("144ab89e-265f-4d32-ac79-306ca985b5e5"), "FR", "France" },
                    { new Guid("1a46a0bb-5819-4180-8588-9f63cc0c5e8e"), "MZ", "Mozambique" },
                    { new Guid("1afcc9a1-6d97-429c-a328-9a64198c4abc"), "BB", "Barbados" },
                    { new Guid("1b552f57-4aa5-4d3d-80fe-8f9a2fa0e196"), "CU", "Cuba" },
                    { new Guid("1bd98bd6-d701-49c6-a6b2-51dca24daabc"), "CR", "Costa Rica" },
                    { new Guid("1c0bc965-dc20-4e4b-899c-8f42b4e6d1f1"), "PE", "Peru" },
                    { new Guid("1c5ccb34-9430-40d9-ab19-dda456075abf"), "DK", "Denmark" },
                    { new Guid("1c972d87-3712-4033-aa24-dcc06c54e2f9"), "MY", "Malaysia" },
                    { new Guid("1dee34a6-3702-4b2b-90ee-3edbf0f3f885"), "MT", "Malta" },
                    { new Guid("1ee3a3bb-8191-4a43-99b9-edf6b10e8662"), "PS", "Palestine" },
                    { new Guid("1fa55c61-c48e-4cce-9882-bf1297a73d25"), "SL", "Sierra Leone" },
                    { new Guid("202b1fee-fd4b-4971-babd-a41808692dbd"), "TG", "Togo" },
                    { new Guid("211cda1a-5d26-4a12-92a0-6caed9b2a16e"), "SI", "Slovenia" },
                    { new Guid("217491c1-0fa6-424f-8ce6-83e53d106008"), "PA", "Panama" },
                    { new Guid("22dd845f-2e66-4c7a-89af-0d09635f661e"), "ER", "Eritrea" },
                    { new Guid("2332d96c-5909-484a-a3e4-c5d140031854"), "BF", "Burkina Faso" },
                    { new Guid("24e3b88c-7339-41e1-8863-d50f5df494af"), "NA", "Namibia" },
                    { new Guid("24e6e5fe-6310-495d-89ed-d902c229778c"), "SG", "Singapore" },
                    { new Guid("261515d3-0ea0-4641-8179-88a42ed2a5c7"), "TV", "Tuvalu" },
                    { new Guid("26aeb05a-22d3-4621-a2c9-e4c75877cfb8"), "BW", "Botswana" },
                    { new Guid("26b0bc35-0e89-41e1-8997-ccef00310f45"), "VE", "Venezuela" },
                    { new Guid("29058c5c-aeef-4fd8-8e38-614bab43cff1"), "LU", "Luxembourg" },
                    { new Guid("2ca9a516-1084-4ba8-9886-69e2602be19f"), "GR", "Greece" },
                    { new Guid("2d647d1c-c6ec-43e2-a5c2-4af609270042"), "IL", "Israel" },
                    { new Guid("2da7dd2f-35cf-40df-a1e9-51856b99eccb"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("31c56b95-f994-4636-bcae-b0cb12af0b06"), "LR", "Liberia" },
                    { new Guid("34d54fe0-cb92-4f30-9796-817e1e22e725"), "IQ", "Iraq" },
                    { new Guid("34f28d89-7eb2-45f3-987b-82b80670f1a2"), "VA", "Vatican City" },
                    { new Guid("351c302f-390c-4101-9976-c17d190e25b9"), "LS", "Lesotho" },
                    { new Guid("3637bc31-cad9-4819-ac3c-2b96cdf0fa4a"), "KZ", "Kazakhstan" },
                    { new Guid("368ef340-a460-4528-ba57-3a39c2bc94d1"), "SC", "Seychelles" },
                    { new Guid("3884919f-f8e9-4f26-ac95-b63aa4c8b6ef"), "BE", "Belgium" },
                    { new Guid("38d4adff-7943-47c0-b905-3e546b7af640"), "PH", "Philippines" },
                    { new Guid("38df4665-8ef5-467b-a2e5-6308f1bc8582"), "PY", "Paraguay" },
                    { new Guid("390b2bdd-52ca-4462-976c-1fc45026d1b2"), "NI", "Nicaragua" },
                    { new Guid("3a0cc9b3-cdfb-4223-8e57-7c3915ca2d08"), "BJ", "Benin" },
                    { new Guid("3a50bdf4-5d98-4d3b-a69d-c7ff7d3cb5ba"), "LA", "Laos" },
                    { new Guid("3acd4d11-62ff-4b85-a09f-323a6b13bf57"), "MK", "North Macedonia" },
                    { new Guid("3dfd3ade-485e-4a0f-b707-e9bec778788c"), "CH", "Switzerland" },
                    { new Guid("3e8a1907-4099-4037-8439-5fe2c1f622df"), "RU", "Russia" },
                    { new Guid("3ebb4011-d5d4-4133-b2d2-fd13d7626117"), "HN", "Honduras" },
                    { new Guid("3f06cecb-e45e-4bc2-87e5-8a1a4afaa16e"), "EE", "Estonia" },
                    { new Guid("3f0f3fbf-e870-48ec-bf41-987f1771df6b"), "BD", "Bangladesh" },
                    { new Guid("3f862269-9706-463c-ab93-6e0163556fc6"), "RW", "Rwanda" },
                    { new Guid("3fc3fb86-c417-4b32-a04f-72a61ad1ffb0"), "ST", "Sao Tome and Principe" },
                    { new Guid("41c14f08-1031-4ebe-81bf-bfc90b15193c"), "AF", "Afghanistan" },
                    { new Guid("4374401a-9e91-434a-92db-772b337222ba"), "IN", "India" },
                    { new Guid("440996a1-d9c7-433b-9d61-8b1a6c14f6a5"), "SB", "Solomon Islands" },
                    { new Guid("44749bd1-6ffd-40a9-bb1d-2199adceae5e"), "ID", "Indonesia" },
                    { new Guid("45888f1b-fb4d-4e98-8232-4fbe62e4b78d"), "TL", "Timor-Leste" },
                    { new Guid("47624dfb-4da2-4417-a19e-87ee5f72a214"), "MM", "Myanmar" },
                    { new Guid("47d3d1c0-de91-48aa-8758-fb8d1f884ee7"), "LT", "Lithuania" },
                    { new Guid("486ba6b6-829e-4cfb-a17f-70d03e735567"), "TT", "Trinidad and Tobago" },
                    { new Guid("486bcdcb-30c9-4d7a-a3df-33e0fff0a441"), "ET", "Ethiopia" },
                    { new Guid("49406440-4ab5-4ef4-ba1b-c8363f39a248"), "FM", "Micronesia" },
                    { new Guid("49851770-52a5-4b6c-a585-a30b51eecf13"), "IT", "Italy" },
                    { new Guid("4b55432f-116d-41bd-864a-55e4f0ed1442"), "SE", "Sweden" },
                    { new Guid("4cfb7e2c-1053-40de-83cf-f545597fc74f"), "BS", "Bahamas" },
                    { new Guid("4d22af2b-a549-4fc8-920b-c59e1fb7904e"), "CV", "Cabo Verde" },
                    { new Guid("5039518f-4b71-4b66-8309-750932389f76"), "KE", "Kenya" },
                    { new Guid("510c1b8a-38d5-4a79-b0c0-7e35aeb2f849"), "HT", "Haiti" },
                    { new Guid("52cf840a-fa31-419c-a4d0-c99c04488236"), "CN", "China" },
                    { new Guid("540549a8-75f7-4929-8fae-9a089b4644de"), "TO", "Tonga" },
                    { new Guid("5468d832-cf8f-44b2-a986-992225de6ba5"), "IE", "Ireland" },
                    { new Guid("5510d9c8-87c6-4bce-8f08-7a551078b183"), "VU", "Vanuatu" },
                    { new Guid("55c88be5-7313-466c-9add-5a4401519655"), "GQ", "Equatorial Guinea" },
                    { new Guid("568a9991-25e8-4ed3-b2fb-49169bf5b655"), "FI", "Finland" },
                    { new Guid("5716d749-acb7-4d66-a644-e740c03a607b"), "TN", "Tunisia" },
                    { new Guid("5bff4d13-ec23-45e9-8b44-8dc779fcc8ca"), "LB", "Lebanon" },
                    { new Guid("5cc572f6-177e-4f86-9962-0d595215d75a"), "ES", "Spain" },
                    { new Guid("5e88ec47-d340-4372-87d3-935c1e03293c"), "BG", "Bulgaria" },
                    { new Guid("5ff9bf47-bc62-4a02-b08a-4d18528d3eba"), "PL", "Poland" },
                    { new Guid("65d6bbf6-ff83-4fc6-86c0-053b15fb4baf"), "MW", "Malawi" },
                    { new Guid("669ebf58-8389-4b04-979a-0fa190079a61"), "JP", "Japan" },
                    { new Guid("6706ebc4-5d07-445b-b171-0fac1252210b"), "MH", "Marshall Islands" },
                    { new Guid("67a49f59-e442-4fd2-8118-34a68109fde9"), "MX", "Mexico" },
                    { new Guid("6a633955-fb31-4d7e-9371-8fb25691c20e"), "KR", "South Korea" },
                    { new Guid("6a9ca749-a489-4bcf-8440-845a260bd023"), "SV", "El Salvador" },
                    { new Guid("6bd2e193-70cf-475e-8f07-d590e29cc35e"), "DJ", "Djibouti" },
                    { new Guid("6bd9c307-3988-4709-b64c-2e3212a9f6c6"), "AO", "Angola" },
                    { new Guid("6be53929-5c9b-42f4-89a8-ecfe25d78b4f"), "KW", "Kuwait" },
                    { new Guid("6dd474df-6eab-4720-ad44-44b54faed462"), "SY", "Syria" },
                    { new Guid("6f11bdbe-ef52-4766-9694-cadc7eb34913"), "ZW", "Zimbabwe" },
                    { new Guid("713844ed-ba9a-491a-8999-0495b50577f8"), "TM", "Turkmenistan" },
                    { new Guid("72986f4c-7946-4c2b-8a9d-ebcd2e9dedc4"), "AD", "Andorra" },
                    { new Guid("745ec8e6-ba71-492b-af50-6f9a8b911faa"), "GH", "Ghana" },
                    { new Guid("74f9e291-6b4f-4627-9471-4af6fc7baeee"), "GB", "United Kingdom" },
                    { new Guid("7696088a-3d64-423e-be63-36c85bb59939"), "PW", "Palau" },
                    { new Guid("769d7eb6-28c5-4ceb-83d6-b17f579c21eb"), "ML", "Mali" },
                    { new Guid("79912503-47b5-4e4b-a3fa-7f3815c75f9e"), "TZ", "Tanzania" },
                    { new Guid("7c0d69b2-5092-4a44-b86a-78622a0fb994"), "GN", "Guinea" },
                    { new Guid("7c8f62c9-2216-48a4-99ad-c69112207e63"), "ME", "Montenegro" },
                    { new Guid("7f12851f-a744-4963-9297-51a8b9012eeb"), "CL", "Chile" },
                    { new Guid("80e97538-0f2a-4a61-939d-5c342d244f7e"), "SO", "Somalia" },
                    { new Guid("826021a1-70e5-44cf-8335-09bd9e4d42f6"), "VN", "Vietnam" },
                    { new Guid("850f34da-0666-4e17-b53e-ce6c5f405c06"), "DZ", "Algeria" },
                    { new Guid("8916a39b-0e03-420f-a2a0-af53bffffbb0"), "SN", "Senegal" },
                    { new Guid("8970d5f6-0501-4307-a0ba-0f75538125ce"), "GA", "Gabon" },
                    { new Guid("89d04e77-be76-4b0c-be23-76b78a4ab2ca"), "OM", "Oman" },
                    { new Guid("8b24ee85-b036-4132-b1a9-50bf877b172d"), "JM", "Jamaica" },
                    { new Guid("8b30d322-e903-45e7-9ec2-c5d78bdb68be"), "DE", "Germany" },
                    { new Guid("93d87527-398e-4286-90b0-bef57f2d5b0a"), "NO", "Norway" },
                    { new Guid("979e37f6-2b0f-47e1-b41a-f230393e1abb"), "UG", "Uganda" },
                    { new Guid("9aa7af95-a421-4a4e-844a-63f086de014c"), "NR", "Nauru" },
                    { new Guid("9c13d193-2693-44b0-92cc-34b3520de082"), "GY", "Guyana" },
                    { new Guid("9c7db7e4-e893-4b95-b620-e795223056a1"), "HU", "Hungary" },
                    { new Guid("9ca20b73-03db-4be7-b5c0-ccb204f44e40"), "CM", "Cameroon" },
                    { new Guid("9d795d48-4a0a-4857-9795-4fc40cfb1bfc"), "RS", "Serbia" },
                    { new Guid("9d7f7541-f071-46b8-9b28-44d5a701d394"), "PK", "Pakistan" },
                    { new Guid("9e9734f6-86e4-4d39-ab0a-85fbe609b770"), "BZ", "Belize" },
                    { new Guid("9ff05672-47a9-45fd-9520-b451e18ff305"), "AL", "Albania" },
                    { new Guid("a0495bd2-110c-4e1b-b15e-cf8036de8c10"), "CF", "Central African Republic" },
                    { new Guid("a248757a-8d35-49b1-b4f8-cbc16ee07d41"), "KP", "North Korea" },
                    { new Guid("a59f501d-aac9-4f84-b3dc-7d4f1938b40d"), "CO", "Colombia" },
                    { new Guid("a64e2909-7ffd-43fa-a359-17618e62d488"), "GE", "Georgia" },
                    { new Guid("a6b86d1e-5cc1-428d-9ef2-fe05257dc651"), "TR", "Turkey" },
                    { new Guid("a71c4359-37ac-4de1-85ff-14dbf4bf2d74"), "UZ", "Uzbekistan" },
                    { new Guid("a8bc6882-1433-494a-93b7-7fd25916bcd2"), "VA", "Holy See" },
                    { new Guid("a91beb74-41a6-4163-a376-9cb6ee51a4c4"), "SM", "San Marino" },
                    { new Guid("aa5adb28-3aab-4e7d-9b10-d27bea7b8c07"), "KG", "Kyrgyzstan" },
                    { new Guid("ace5d174-6019-439f-802b-828f2e1b0913"), "DO", "Dominican Republic" },
                    { new Guid("add562dd-86f6-480e-8724-e2f2f2b3de1f"), "RO", "Romania" },
                    { new Guid("af98abd4-72a6-44ef-8468-daa26e554d0f"), "BN", "Brunei" },
                    { new Guid("b15ba8ec-2ed3-4863-9221-a897e8fde1d6"), "YE", "Yemen" },
                    { new Guid("b2f31bc1-c43c-437d-b22c-4c92fb8ccbfa"), "SS", "South Sudan" },
                    { new Guid("b5e528c2-f351-4b6c-9e79-0ac6efc776bc"), "AG", "Antigua and Barbuda" },
                    { new Guid("b5ed5a3d-9631-4bf0-9344-77c54287116a"), "BT", "Bhutan" },
                    { new Guid("b65e6c04-d4a6-4ba3-b004-722d9bfdf382"), "EG", "Egypt" },
                    { new Guid("b9df90d6-b22d-4942-9a29-c6ebf0174576"), "TJ", "Tajikistan" },
                    { new Guid("bb6cbc67-66f2-4b8a-9690-07035521f9ab"), "LY", "Libya" },
                    { new Guid("be3d8666-6154-4115-886f-edc0ca6b3de9"), "KI", "Kiribati" },
                    { new Guid("c1412c8c-66f3-41e0-be8e-049f2e74c05d"), "MR", "Mauritania" },
                    { new Guid("c20a0db1-dc47-4de7-a7c4-7c4cc7980994"), "TH", "Thailand" },
                    { new Guid("c3c06a64-53ef-46ec-8934-dd0a86d4e4b7"), "MN", "Mongolia" },
                    { new Guid("c75b334a-95a1-432e-b645-a045cd6f3d9a"), "MD", "Moldova" },
                    { new Guid("cbdb4508-874e-47fd-b2a6-0b5f626eccf8"), "CY", "Cyprus" },
                    { new Guid("cc4458cf-6c44-4684-aa59-15360266151f"), "ZA", "South Africa" },
                    { new Guid("cd789399-87a7-4d85-9cc6-134b87312e10"), "US", "United States of America" },
                    { new Guid("ce2bf619-a957-450f-84b5-117939af046b"), "PT", "Portugal" },
                    { new Guid("ce2c5bdf-b0e0-4ae9-aa2f-cc2be81de80e"), "MA", "Morocco" },
                    { new Guid("ce33e505-ffe6-4e13-b421-cc15e954bef5"), "JO", "Jordan" },
                    { new Guid("d1b1f36a-fca6-493a-a026-36abfa20a9a8"), "EC", "Ecuador" },
                    { new Guid("d3744a05-d30b-4f59-afa3-2eec1e0b632a"), "KH", "Cambodia" },
                    { new Guid("d5b0ab8c-83b0-4fcd-adae-241aeac25de3"), "UA", "Ukraine" },
                    { new Guid("d753af1e-79d6-4ece-bcec-ae19ab987f17"), "BO", "Bolivia" },
                    { new Guid("d9bdb07d-5e3e-43dd-86fc-7faa6d320043"), "MC", "Monaco" },
                    { new Guid("da468dc7-6734-425c-bc90-bafcb943b326"), "GD", "Grenada" },
                    { new Guid("ddabb73a-fcab-47ff-aad1-9809cbbb47a4"), "NE", "Niger" },
                    { new Guid("de879b39-735a-4d68-a95d-b6f43f3b530b"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("df0f9bfd-9bb6-4876-9c8b-6686653cc773"), "GT", "Guatemala" },
                    { new Guid("df66a0b8-ea0e-4c46-94f0-ac79d63035a8"), "LI", "Liechtenstein" },
                    { new Guid("e01cedb4-9990-46fb-83c4-c42268b67e7c"), "SK", "Slovakia" },
                    { new Guid("e0f5fb10-b3aa-48bb-a300-3e84db187c90"), "MG", "Madagascar" },
                    { new Guid("e10139e3-a1e2-4913-9801-9038f3cf844d"), "MV", "Maldives" },
                    { new Guid("e363c141-6d1b-46d9-a054-a5f6b932f7fe"), "NP", "Nepal" },
                    { new Guid("e4027efa-2f43-4ec9-994b-02021724b896"), "BR", "Brazil" },
                    { new Guid("e41be010-049e-4cf7-888a-968cddc8dcaf"), "LV", "Latvia" },
                    { new Guid("e4db4241-c5b0-42e8-bf2c-367a975d1480"), "AM", "Armenia" },
                    { new Guid("e4e4ae3c-dff9-40d4-9cb0-fd203dac568e"), "BH", "Bahrain" },
                    { new Guid("e775829c-1205-49ef-b806-f409d656e502"), "HR", "Croatia" },
                    { new Guid("e7bcd677-0b16-4103-afe1-3ccd9e2f9445"), "ZM", "Zambia" },
                    { new Guid("e90d0b37-6123-4859-a221-73e93a60cafb"), "GW", "Guinea-Bissau" },
                    { new Guid("ea0abebb-8472-4265-bb1c-48fada4025cd"), "KM", "Comoros" },
                    { new Guid("eb4f3f73-3dcf-459e-b805-e2dddee2d03b"), "BY", "Belarus" },
                    { new Guid("ebe30489-b663-4be8-8168-5eb40cf08210"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("ed00984a-2cb2-4fb7-87e4-a7721bf55b13"), "AR", "Argentina" },
                    { new Guid("f1a25a7b-dec3-4dfb-bdec-d1aeebd40c4a"), "NZ", "New Zealand" },
                    { new Guid("f2bb8f44-420b-41fe-855f-872c6b460bee"), "GM", "Gambia" },
                    { new Guid("f35b67c9-9f7b-4841-b960-ed5454c05a95"), "MU", "Mauritius" },
                    { new Guid("f405bc72-76b6-40dc-8928-5a416710ed6c"), "AZ", "Azerbaijan" },
                    { new Guid("f566afd7-2578-4412-a5b5-2034ada1ac32"), "WS", "Samoa" },
                    { new Guid("f5d328a4-98c9-43d2-8bda-2371a0cc8e48"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("f639a470-b16c-413a-9e24-7fbc765d3fda"), "CA", "Canada" },
                    { new Guid("f63df191-ff93-45bf-b845-2ab294a53ddb"), "SA", "Saudi Arabia" },
                    { new Guid("f6b9409b-9768-4a8d-80aa-a8561252874f"), "TD", "Chad" },
                    { new Guid("f798c880-1367-4984-91f0-945eaf0e1af1"), "LK", "Sri Lanka" },
                    { new Guid("f9b5bcae-0a4e-4da9-9f46-5e5402e8afd7"), "QA", "Qatar" },
                    { new Guid("fba0729f-1367-40e5-91a9-a0dd6a8c3254"), "SR", "Suriname" },
                    { new Guid("fc069785-84a9-4cbc-8b52-84c14789eb24"), "NL", "Netherlands" },
                    { new Guid("ffdf2174-a986-4bdf-83ce-28747d150642"), "PG", "Papua New Guinea" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02f3799e-194f-48dc-9344-b821233486c3"), "Male" },
                    { new Guid("d931b9fb-23a4-48a7-96cd-8995aeef6c40"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("14db295e-cdd8-4595-9e65-9a87272ccc75"), "Oncological Interventions" },
                    { new Guid("3696b1b4-ba89-4c97-add3-dfcd2ed27deb"), "Dental Interventions" },
                    { new Guid("499b816b-e364-4154-92a7-1cade1413415"), "Obstetric and Reproductive Interventions" },
                    { new Guid("65f90c23-7ccf-4e3a-920f-1278d45b953a"), "Surgical Interventions" },
                    { new Guid("776f5a58-28cb-403e-8418-ae3768d5a3fd"), "Therapeutic Interventions" },
                    { new Guid("80247486-4447-4711-af55-19e214043d4b"), "Diagnostic Interventions" },
                    { new Guid("a86bfd5c-9767-4459-b79e-ad7451bc1b91"), "Postoperative Care" },
                    { new Guid("bb9f72e7-9708-484b-87ab-46cf48f05b0b"), "Emergency" },
                    { new Guid("d98a1284-90c4-4f9c-8036-a903c35ebd9d"), "Preventive Interventions" },
                    { new Guid("f493526d-e4c9-43a5-904e-129fdb4fcc04"), "Exotic and Specialized Interventions" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Countries_CountryId",
                table: "AspNetUsers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interventions_AspNetUsers_UserId",
                table: "Interventions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookings_AspNetUsers_UserDetailsId",
                table: "UserBookings",
                column: "UserDetailsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailsApplicationUsers_ApplicationUsers_ApplicationUserId",
                table: "UserDetailsApplicationUsers",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailsApplicationUsers_AspNetUsers_UserDetailsId",
                table: "UserDetailsApplicationUsers",
                column: "UserDetailsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailsPets_AspNetUsers_UserDetailsId",
                table: "UserDetailsPets",
                column: "UserDetailsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
