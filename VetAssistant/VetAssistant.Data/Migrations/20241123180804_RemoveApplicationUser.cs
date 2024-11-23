using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_UserDetailsPets_UserDetails_UserDetailsId",
                table: "UserDetailsPets");

            migrationBuilder.DropTable(
                name: "UserDetailsApplicationUsers");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0051f113-a1a5-48af-b8af-f8db23555a74"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02836724-cb7c-4693-a6bf-ebf7e95ae492"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("05291f28-f94a-43e7-a8ee-cbdccb4612ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("073b314e-7ae3-437f-9487-e21dd6ff2f5a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("077d9dc1-3253-46dd-92f7-ba21e6641bc8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08e632ea-fa25-4ddc-abfd-83d78d914c52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("09d28c8f-d25f-4dee-9f70-8d38e3e6b0fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a5eda74-2560-4b77-a4d0-cf6c7c5ad1ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c09b2be-0ac1-4ff1-98ba-fdb76741dbd1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c85448e-0fa9-47ac-9d6f-4b8a8f4e7127"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f81fc8c-0fcb-4ddd-801a-32086e8179f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0fec4761-42bb-4fd4-904e-d27bcfce58ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("10fdb21a-1cd4-434d-97a1-cc0e0d27a91f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("119c5258-7183-4136-8852-94787ce132c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11d85c0a-505d-4431-91ca-365d31192c3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("132612f9-9565-497e-8dbc-ac76ffdeb40e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("136afb49-77bd-4956-a41e-91ee90240297"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13fdcc96-4d53-40e4-93e7-a49b1eecddba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("146532d5-7040-480a-b60c-e9de5e80876b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1495a151-bdcf-4ed5-9c36-a21466c5921f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("14e1b457-6061-47a6-88fb-5e3b243cfc3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15630223-4eb5-4d2b-affa-8db775d7d7bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("163293ee-c020-4617-b01e-3b7a23e79aa5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("176efd02-42fe-48d0-b234-90c45c2922b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1813979c-f909-4af4-aac4-2b1d788566dc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b3da3e2-f4a8-4fb9-94bc-4614979f1e27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1bbf61c8-f4b0-4d76-a503-1638a22f7ed0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c16edf0-c587-4e62-8d0e-6fdaf52eeebe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ce6105a-58fa-4257-929a-7b0877c4474d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e22b379-a0c3-4b0e-9402-7bf4b13630ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1f01d674-acf8-4cd0-b1f9-917ceb44dccb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("201ac6c1-1827-49fe-b3e1-ec0df7c1aeda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("206c55b9-95fe-4866-a757-5ad2796682c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2316b3f8-44e9-43e5-b6bb-d12b1d2cf5cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24decf1a-6412-41da-969a-551845a915c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25032991-7088-4990-a171-15b660155d6b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2829332c-3876-4765-92b3-cb2964f876e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28e45857-9421-4156-94f1-1ef1d658488c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a4aa46a-3fd2-4a5e-bf2d-976e534b3e2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fb2a4da-2869-4843-8b9c-6332b082acdd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30fc9582-4387-4aae-9e88-d48b014fcf61"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31afe637-3abe-4a3b-b1a9-dbfe8c39f8ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32e173a6-08cc-4f7e-afb4-1f16334d95cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("347f1b47-298c-48ea-a87a-f48022b94d5d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("359838fa-5981-4dc0-ae97-9fbd25cd89bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39f7910c-37e9-4f5d-acd3-359536809113"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a881136-b0bb-4f71-89e7-81c45dc69b97"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ad6c3c8-8183-40c2-b5cf-3a71a804843a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c2da900-62e8-40ef-9231-af31198b607b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c7afba9-91a3-4cd2-a623-b12f79229a92"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e57f7b6-239f-499b-b440-7ec4f115d4b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4060e374-1097-4d67-baf0-57b594195d5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("40d13bd8-9fe5-455c-a270-d711345efab2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41b94640-a568-4ee1-8a47-729f308a964a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("451a9b01-7c36-46d3-a02c-47eadafbc13c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("48d26e13-98dc-4deb-882b-f613bfe41f4b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("48df0827-19f1-4009-9c2f-edab7fe5fa07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a1a0f09-de39-4cde-92b0-db0668826f7d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a9a6ab6-d0a2-4296-8957-6a37f305b236"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4cdcbfb1-e048-4571-a1c0-0e6065dbbf95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d72db03-c3a9-4a05-9da5-5f5afc52a63b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f24a16d-6872-4257-b1da-28c14d447e4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4fe54c00-8f2f-4588-8bf8-09a08afce1f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("50eeaf44-3e9c-4652-b0a6-b3e84b1b213e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("50f550a8-68de-4355-9920-fadc3e2f1b2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51771d54-865d-436f-bdfb-b4815012e9cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58275c70-1c07-4804-b8d3-7caacf7e79c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58a6c442-69ef-43d8-ae40-f9859be0f062"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58edc076-3fa5-4c30-aa1f-0429411c2c27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59bcbb14-c5ee-4b6b-9fa0-63ae6fd9d438"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59bf3b03-2e4f-4b52-b787-f74a52af62c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ab74f46-e801-4a86-99b3-672e2389829d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5be00c29-3f00-4fac-b861-c68b56a4e6fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ce75b9e-515b-4062-86d4-8931d5765e38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d43df3d-b57d-4224-b36d-6be80b13e772"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5db13f45-4e44-4357-953f-04319b3f8bd9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e2dabe3-c775-475f-a647-9e0a19713bd5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ff0f3fd-a689-4c2d-844c-f2b5abb7a8e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60412d76-a846-40f8-aa2f-0ed2cbbd720b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60577866-c9f0-4f77-a83b-c9a8888d63fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60b903c9-a4b5-4e2e-937a-1ee7b1c80268"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60ed4d77-30c4-4bb4-b3b3-242919e013ee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("614fd4a4-70df-4c28-b44d-5f5085aa5c83"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("62313145-330a-44dc-b8a0-0b1f85a4ff4f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("642728c8-0606-4ba4-a806-466c42ecf9d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("647d9843-9add-4d20-8888-756e8ff518d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65ab4f61-57be-43fc-a71e-73fcc175fb1a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6602c48a-0ae0-449c-8f8b-173101b80965"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6726ec48-cfe2-4fd3-a4d2-edd958060943"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("68bfaf34-467f-4321-82c0-09c21d9f90b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("696defad-f44f-429a-9e01-8fd8dc4e6227"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6c255709-7e2f-4f3f-b69f-5dea1f3e7aa2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6d329cc1-7d5d-4a65-8924-599c7f87429e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e12b56d-4f85-4f1c-9713-6593b7100686"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6efbbcfd-6d5e-401c-a157-febe82fe349e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7533c6e0-fe48-45c2-bac0-996d14308bf6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("75aee484-2190-4370-8d48-cc70df8a737a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("760b8024-1b4b-4d2d-a32f-374486e5009f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7661611c-5c4c-4f3e-8153-56e0334ed55b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7815b654-b074-46ab-9e3f-efb94403e361"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78752889-5b28-4ac0-a59b-575fe0eac1c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78e065ee-9501-42d6-b4d1-ad2a12aaa341"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79076b71-b4f9-410c-860f-1f9132f3c81e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("790a2d97-ebe9-4c22-b053-a920ca15fb75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79d988cc-fe31-4255-ac16-1f00aded37f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7bb012a6-5f3b-4c84-ab86-db6e9dc063cf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ed95e03-2c7e-4439-b084-e21d59885292"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ee586db-a771-41a3-a755-1faaca7ef4b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f44fb24-a47b-444e-942d-d5078a51c40f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82cf3171-cbda-4077-91a4-4847bf4b8d44"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84c33aac-41ee-4524-a084-595c70aea921"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84e6f1d8-dc43-4879-8570-de4c016be04a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85872c43-85f1-4bb5-a3c3-5fec09149fe0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8899043a-879a-43d9-b918-cb01a6bfb847"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8db9d55c-5061-4ee3-a727-2944ad70baed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8dfdd401-e1c7-4289-8825-a8d00a1b1114"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e83bbfd-9950-4fbd-bd86-63c59f1c1b81"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ecc3741-9cdc-4edf-b1bd-8b206e8b4831"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f0e1dd1-6dc9-4c00-8ad4-3b5e5bebc695"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8fb79544-1e1e-48a1-88e1-57a4a6530ce3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("900174b1-1f0c-45de-be15-ac5e44e60acd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("903a3477-942d-498d-8ad7-f2f9424d2f93"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("932f6641-0d78-4ffe-97b7-2aa02320b95e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("938cec65-f319-4b61-8f84-c0bc47637c16"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98429dc9-46a1-444e-a810-6a075a89de9a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b111ed7-d066-4e73-8f94-48724983db82"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c38eb99-d4c8-4398-8619-434a046cc736"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e553e29-6298-4377-8932-dfc5d7c8cd2a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f8b4935-1412-4ba5-93f3-959c65caf031"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a367122a-b431-4155-bca9-2e193630544d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4cdc4f2-3e7a-49cd-9ba6-c3a784fc648f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a6ddec4c-6d6b-44bf-b921-16a24864be83"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a7c47761-8ee6-45c7-9370-4f5dccd18343"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a7fb82fd-8f82-42d4-850a-1ca5274500af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a947676a-9195-4db2-b9e3-ed7ffd35bf46"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aab630ce-8a65-410b-9f0f-5ec42107ae38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aaf689e1-f84a-4072-86a9-e4419f92800f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad7f38b1-f083-47f2-974f-9a723c5a6886"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af6656b4-04da-4210-a836-346abb0f05c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b055064b-c728-4abb-8ef3-b0d7728969e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1eea1ce-a799-4015-a3dd-a318d894d555"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b451730d-5a8a-43f4-86fa-cadfe9992994"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4a30250-672f-4270-88c5-a3ac06026049"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6dca6d0-8e3f-41eb-b3ae-4ef07c7ea0c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6e6bd19-39cb-42ab-8692-eb082730c753"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8d006d8-85f9-4cdf-bf9f-4906a17d2575"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b9523c39-cd32-4379-8367-530bbcb07172"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b99fd527-7a56-406d-988f-dd6410fd8512"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("baafb8a1-439a-4f6d-910d-71e3b6a3ae71"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb3e2052-aa2a-4b77-af24-0dc579ec27f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bce54b8f-e552-4d08-94c0-257c33c35bf0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0d11139-7158-4200-a70a-dc8cd1a40340"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c1c99e44-5db0-42c8-89bd-ba7e599c71bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c466e06b-491e-4a08-84e4-4308991668d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c847efec-7cc9-4ca6-ad20-801d9574218c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c968c7aa-a1bd-408a-b99c-dd27e5606392"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb213f3a-6b32-4afa-8cc8-c3b0d5974ba9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cba90152-bbb2-4457-8556-6491246c14e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdc9f6e7-3a75-4376-8dbb-deb61aa82bb9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cec3d8d0-5ac8-4512-b7fd-d39f2c7ec41b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d13beaa4-41ce-4ac6-9a69-e44786f0113a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1cf637b-f93b-4489-b347-fa4f83b512ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3827c2a-e8f9-4463-b852-d8af8a806404"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d4d76580-abb6-4a3f-be6d-eea3b3c74d0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d57bb1fb-68d7-41ec-89a8-0f8184a6de78"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d759fd9f-3e8a-42b1-942d-8447f285c25d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da1e00fc-ebcf-4507-8923-e354230fa761"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df365ef0-3a00-46d9-a478-cada5a77d126"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df9cec09-955c-440f-95ac-8c076d733b75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e1174b5f-3e91-4f0c-a14e-e4cd0b251e6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e11a5c45-e4f7-4366-9aa2-9c30a7f196f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e15d6cd5-b7ed-474a-a389-a8d19554973d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e165f06f-24ba-4663-b09a-107b66433e25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e166486d-ac92-482d-8cf9-c68e83de26e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e1bbde39-9ed3-45f3-81d0-864cd6f64a22"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6e5e5c2-0c81-475d-ac6d-8e5118acfd08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e9862297-0998-4c66-ad0e-4b3abf316b8d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea6f8da4-e12e-42dd-883d-25e679b8ee74"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb221aab-b113-45f1-abed-4bfbd46b60b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec274e23-55d3-4c32-92ad-b59b8f89ca2e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("edea5920-4dbf-45a3-a74f-7bac8a58cba6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee07a86f-7494-4c6f-885f-43253d9ee007"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee4d562b-1f53-4002-b96f-7b70c238e279"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eee4d292-f906-4208-a42a-f62f59ebf4d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef564c8f-dae6-426c-a7c9-1e7f929060e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef9fcc24-7845-4e0c-9de5-26e5e36eff56"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0cb0f47-71f3-44fb-8c90-c94decbe3a20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f21288ed-9c3a-463b-baaf-5fe214508798"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5986a0d-43a5-4578-b850-40aade4701a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9071618-703a-40b9-abac-2d5172507966"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fae189ba-03ce-4072-bbad-b2f4fc896aed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb430e86-40bf-44a3-93ff-a544d96b2bd0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd91ee6a-1f15-4897-ba99-fdbe4d71079b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff6c9841-5c86-4c87-a63a-61ff48c163ed"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("4ecf606f-a512-44a9-a29d-5a92cfc6584d"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("53df8532-0f02-4044-9a82-72a788f77ac0"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3c0fe220-c4bd-470e-909b-e487090b9872"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("40c908fa-9356-4e66-9adf-e798e9677903"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("7180472c-91d2-417b-be77-c3cd984a3c78"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("8e534223-6105-41c1-8a08-11aec3218178"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("9cd917e8-1a74-4a8d-9521-45aabfaf400a"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("af379a78-da2b-4703-a03f-d2082f433eb7"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("b83dd9df-8bcc-4be9-a1b7-7fe97a9ee93e"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("bb31a26a-2cdf-4866-b10a-dd97fabe06c3"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("ca2c8d0e-414e-4083-8f67-a1cab6dc3afa"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f7d187ef-ae55-4914-80a4-41ae9f7abac0"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                comment: "DeletionTime");

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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0088e2d3-26b7-47d3-8224-6f74c2e14a55"), "GD", "Grenada" },
                    { new Guid("01821dfe-30f7-4350-bb3f-c20c757c4962"), "TO", "Tonga" },
                    { new Guid("03216154-d2d6-4e49-a910-0c2c48e95cea"), "IS", "Iceland" },
                    { new Guid("03240bf7-7e46-4875-aaf8-b79755a69d55"), "LU", "Luxembourg" },
                    { new Guid("03903847-24f9-4a79-b29b-3ce32ee51734"), "MY", "Malaysia" },
                    { new Guid("05705ae7-5892-47e9-9588-b437a38ac52d"), "UZ", "Uzbekistan" },
                    { new Guid("06a11929-c7c0-45cd-9933-ba308037b2c6"), "GB", "United Kingdom" },
                    { new Guid("095342d3-0be5-4462-bcd8-fa4b50a62bb5"), "BD", "Bangladesh" },
                    { new Guid("096b1522-9161-4cf5-b4c5-0505b2fde251"), "SR", "Suriname" },
                    { new Guid("0a0a18ca-5de8-4ac7-a8c3-29f6e5c63624"), "SM", "San Marino" },
                    { new Guid("0a492b24-9948-431e-af78-cc1f90ff882e"), "BF", "Burkina Faso" },
                    { new Guid("0a57b4af-5bbb-4a49-83b7-1dec3aaa73c5"), "DO", "Dominican Republic" },
                    { new Guid("0a96e0c0-9aac-4050-9d41-7435717a6e4d"), "JM", "Jamaica" },
                    { new Guid("0bb82ac1-2828-41e9-aa8c-7ef0195f68e2"), "GT", "Guatemala" },
                    { new Guid("0dabbd75-3d7d-484c-8638-e00688c15b58"), "VE", "Venezuela" },
                    { new Guid("0ee6c336-38f2-4f4f-ac16-7dc771599907"), "LS", "Lesotho" },
                    { new Guid("12df14ec-e35f-49a2-ac43-2bf373afeb52"), "GH", "Ghana" },
                    { new Guid("13dc1f77-919d-4f3a-a03e-9ed4e16635f2"), "MH", "Marshall Islands" },
                    { new Guid("1487d1c7-2b94-4754-89dc-bad81805419f"), "SB", "Solomon Islands" },
                    { new Guid("1625f0f9-80b0-4685-83bc-534906f6835a"), "FI", "Finland" },
                    { new Guid("16fa99ef-82a8-4021-84a2-feacbd86c31a"), "ES", "Spain" },
                    { new Guid("19847461-1058-43d3-8679-ee0afd7b6348"), "HN", "Honduras" },
                    { new Guid("1b87aab4-6a2e-48ae-99c2-58983f308fbf"), "GM", "Gambia" },
                    { new Guid("1e39309c-71e0-4dec-85ed-7b76af431e4e"), "PT", "Portugal" },
                    { new Guid("21526818-885d-4bcf-b98e-4ac37519bfe1"), "NR", "Nauru" },
                    { new Guid("220575f3-3028-4797-8c92-533e101312bf"), "CL", "Chile" },
                    { new Guid("229aa3d7-24f7-4059-83cd-737603fd2f1d"), "KM", "Comoros" },
                    { new Guid("246ddb0d-1804-41a9-9b2c-a25c9e3b87b3"), "RW", "Rwanda" },
                    { new Guid("24b4bd75-a95b-441a-8aaf-625777bdfbd9"), "QA", "Qatar" },
                    { new Guid("24d5015b-6f85-4ead-b506-0ea3413385b5"), "SA", "Saudi Arabia" },
                    { new Guid("24fa1577-3256-41fb-b830-f181c0a08b6d"), "FJ", "Fiji" },
                    { new Guid("2694e116-562d-42ad-972a-0a2277c321ba"), "LV", "Latvia" },
                    { new Guid("26c7efc0-b3e9-4f98-ad5a-78f011c12c69"), "LR", "Liberia" },
                    { new Guid("28af3243-7cf8-4d3e-bc2a-71f6b285abab"), "ID", "Indonesia" },
                    { new Guid("2b06a3cc-4630-4224-9a83-a1568564ee0a"), "MZ", "Mozambique" },
                    { new Guid("2b2dc701-da52-4d23-978a-acecc0422149"), "TM", "Turkmenistan" },
                    { new Guid("2bedd924-62a5-4a64-966c-583ce8c0e25b"), "EE", "Estonia" },
                    { new Guid("2c8e6333-b18a-431a-a1c8-3586ca53d840"), "AZ", "Azerbaijan" },
                    { new Guid("2e11555d-589f-40b0-9cac-82f87e84f930"), "HU", "Hungary" },
                    { new Guid("2edc7d6c-afa8-48b2-8eda-6c435b7c5598"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("32dc36c5-eb79-48cb-b057-a0cf030ff591"), "DM", "Dominica" },
                    { new Guid("339c27d2-1032-4b7c-bd47-7b5769943ed6"), "TN", "Tunisia" },
                    { new Guid("344e4ab8-2cf5-4289-8ddd-bf3d03d2400f"), "DE", "Germany" },
                    { new Guid("346506f6-5559-4874-95aa-598191d8f142"), "LK", "Sri Lanka" },
                    { new Guid("34da887d-c0d9-4031-aaf1-18b3ae7fee05"), "AM", "Armenia" },
                    { new Guid("3603bfb2-7c9e-4ae1-94ce-d898fc646a05"), "CO", "Colombia" },
                    { new Guid("36d2600a-70d4-4b5a-badc-ff3b29deb0bf"), "SI", "Slovenia" },
                    { new Guid("373125e2-7542-4d28-a08f-894d56f49759"), "BT", "Bhutan" },
                    { new Guid("386263ac-5fb4-44ce-84d6-92a478e479bf"), "DK", "Denmark" },
                    { new Guid("386c4f54-42de-44ae-ac3e-932d13ff0a41"), "HT", "Haiti" },
                    { new Guid("3ae173b5-1535-4508-af2e-eea8cacd4508"), "GW", "Guinea-Bissau" },
                    { new Guid("3e31e591-3eeb-4249-aad1-8f383a2cbebd"), "CR", "Costa Rica" },
                    { new Guid("3e6f701d-60e5-42a5-8bd5-5896f949a327"), "PA", "Panama" },
                    { new Guid("3fb11b1e-fb49-4b9b-8b8b-f1c289e90b7f"), "LB", "Lebanon" },
                    { new Guid("435aeadd-d52a-4bd5-9fa5-adefc0246f8b"), "KR", "South Korea" },
                    { new Guid("447a681a-afd8-4239-b6a1-5a9adfe4bfeb"), "AE", "United Arab Emirates" },
                    { new Guid("45b31936-9b35-4d49-8c9a-8cc1619a33ec"), "PS", "Palestine" },
                    { new Guid("478ec963-29d0-4c78-8214-56b99a9c085c"), "UG", "Uganda" },
                    { new Guid("47f917be-1642-4c73-affa-ee4a9fa73072"), "BW", "Botswana" },
                    { new Guid("49a15714-aa74-48f9-a94b-58dce67d4dc2"), "ME", "Montenegro" },
                    { new Guid("4a0fb730-28c4-4bed-bd49-440c73d76406"), "RS", "Serbia" },
                    { new Guid("4a79788f-ae07-4d5c-8390-e7c2b0784e9c"), "KI", "Kiribati" },
                    { new Guid("52f732e2-7faf-4c98-8b76-cf05d24e2df6"), "CN", "China" },
                    { new Guid("53484f62-cd8f-4c60-a855-a12c6bce4ee4"), "SC", "Seychelles" },
                    { new Guid("56d0fa76-303a-4056-9dc3-28bb9e57b3cc"), "SZ", "Eswatini" },
                    { new Guid("571ce878-5d47-461f-9d07-02c58d6c8a3c"), "PL", "Poland" },
                    { new Guid("592f1c45-1f82-4f50-89ae-57a5724fd22f"), "YE", "Yemen" },
                    { new Guid("5971712d-f9c4-4148-a7f6-2e7c7ba102bb"), "BN", "Brunei" },
                    { new Guid("597e13de-73b2-46f5-8167-6fe395d8ddac"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("5986d9c6-48dc-4f81-b885-dd27034a18c9"), "IT", "Italy" },
                    { new Guid("5d2d2525-6967-4e76-abb7-1312dac9d8a8"), "AR", "Argentina" },
                    { new Guid("5e2b563b-85d0-4ec8-80b6-2bb148c41dfa"), "CA", "Canada" },
                    { new Guid("5f89c64f-fc6a-4177-81bc-28f072838855"), "NP", "Nepal" },
                    { new Guid("602b47cd-e883-4123-bb62-85ca3ef2b2dd"), "CH", "Switzerland" },
                    { new Guid("61fbe421-96c9-475a-bcaf-fef9245156d9"), "LA", "Laos" },
                    { new Guid("6299f9c9-f3dc-487b-a749-8e4cec64d554"), "GQ", "Equatorial Guinea" },
                    { new Guid("62f60b5c-538a-4204-a40c-6cfa69e6f0d7"), "HR", "Croatia" },
                    { new Guid("647e0a14-1a09-49a4-bd02-e5c8760be7b0"), "SD", "Sudan" },
                    { new Guid("64c82bbd-35da-4c61-a18c-67a9e7cfa7f6"), "SN", "Senegal" },
                    { new Guid("656f3a96-0e39-4ad5-b68e-63fadcfeaea9"), "GY", "Guyana" },
                    { new Guid("666dc502-39f6-4f00-949a-8f06ec5812b8"), "BH", "Bahrain" },
                    { new Guid("6c706b0e-c677-41a2-a047-18712bddae0c"), "MN", "Mongolia" },
                    { new Guid("6d36e4c7-010e-4dbe-8dac-de5d6c6d831b"), "GE", "Georgia" },
                    { new Guid("7151b881-ef09-4808-adb1-8fe575c4fd96"), "GA", "Gabon" },
                    { new Guid("71f8fb24-8067-4fdb-8463-0b4ce8f51c98"), "DJ", "Djibouti" },
                    { new Guid("726226db-aeff-4a7f-9db1-540883bd2623"), "BI", "Burundi" },
                    { new Guid("7324d641-00e4-413b-bc55-1efc20beaddf"), "FM", "Micronesia" },
                    { new Guid("7695067d-f9b8-4ae9-acb0-d37d92b402b7"), "MK", "North Macedonia" },
                    { new Guid("7761d4de-9a91-4c1f-9761-c4d0ba74945d"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("7794a75c-472d-4d53-81a6-b2fed9e9a8c3"), "MD", "Moldova" },
                    { new Guid("7859aaa0-e38c-4f91-9905-1a4d302a4b9d"), "SV", "El Salvador" },
                    { new Guid("7929094c-8288-4940-8702-e58a3e6877bd"), "KE", "Kenya" },
                    { new Guid("79c96ef4-5bdb-42a7-98fd-573f354ad061"), "SK", "Slovakia" },
                    { new Guid("7e362f15-6d0a-4f71-9ae1-b0720bc60329"), "SL", "Sierra Leone" },
                    { new Guid("7e6305f6-0cbf-4391-9650-e02676e91959"), "LY", "Libya" },
                    { new Guid("7ecef24a-c245-43f8-9e79-8ca70712ebc1"), "TV", "Tuvalu" },
                    { new Guid("8064ad3e-fa94-4785-9122-b6fa6342a247"), "CV", "Cabo Verde" },
                    { new Guid("82872878-2b9c-4ee8-96a1-c02bbf402faa"), "KP", "North Korea" },
                    { new Guid("82b0984f-eb51-408e-8ca2-9e246bfe0148"), "ZM", "Zambia" },
                    { new Guid("82fd9e18-197f-4f48-b292-7420f493264c"), "ET", "Ethiopia" },
                    { new Guid("83f30379-2cf5-4e84-9d02-431f084c3d0c"), "VU", "Vanuatu" },
                    { new Guid("8480a9f4-c244-47a7-97f3-91456ebc0ae5"), "DZ", "Algeria" },
                    { new Guid("855552c8-dff2-4939-9933-e40f76ac8fa9"), "MV", "Maldives" },
                    { new Guid("85c0a575-d4c9-495a-a68e-ffce0fcbcb1c"), "NA", "Namibia" },
                    { new Guid("85edb06b-f462-4dc7-8c96-95df0f76fbdd"), "NO", "Norway" },
                    { new Guid("86790926-17fa-41a7-868b-013efc16a95e"), "AT", "Austria" },
                    { new Guid("875614f1-ad50-44b2-b47e-65cf3b1c1206"), "MU", "Mauritius" },
                    { new Guid("8a26c558-203b-45ba-9da4-ce05415ce827"), "GR", "Greece" },
                    { new Guid("8acb4a5c-1815-4633-9572-17d35c4ef27f"), "SS", "South Sudan" },
                    { new Guid("8b250c6a-3ac5-4500-b0e3-063d4fefd031"), "AO", "Angola" },
                    { new Guid("8d34c733-d768-49d0-a018-6247172df617"), "BJ", "Benin" },
                    { new Guid("8f28e042-4df4-4791-8764-4d2383ab8bc0"), "IQ", "Iraq" },
                    { new Guid("90594031-3bcd-48dd-bab1-e18a540c2ad8"), "BY", "Belarus" },
                    { new Guid("9128aa58-9d79-4697-ac62-22b4b6b8114f"), "LC", "Saint Lucia" },
                    { new Guid("922ac711-e68e-4c3e-8bed-409d392828e8"), "VN", "Vietnam" },
                    { new Guid("935149f9-4b01-47f9-8b39-055bf760e9c0"), "US", "United States of America" },
                    { new Guid("94facb0b-b750-4b79-8e72-29db07994bf5"), "SG", "Singapore" },
                    { new Guid("9556264c-f8c5-4ccf-9f2f-7c9f88b41e04"), "TH", "Thailand" },
                    { new Guid("970f44b5-5665-4679-aab8-7b4ffdfb8e51"), "KZ", "Kazakhstan" },
                    { new Guid("9879af29-d778-42ca-9f00-c822876b71f1"), "KW", "Kuwait" },
                    { new Guid("9affa43d-5cd0-447d-a6f2-1d05d497b146"), "IN", "India" },
                    { new Guid("9b128a88-453d-4389-9c7f-137acc215cf6"), "BZ", "Belize" },
                    { new Guid("9c86db51-0698-40d5-875a-b2e4dd56f1f1"), "JO", "Jordan" },
                    { new Guid("a24d86fe-014c-4aac-97f2-95e480caf1eb"), "TZ", "Tanzania" },
                    { new Guid("a4001a13-23ee-4bea-b114-caca5d75e0a7"), "TG", "Togo" },
                    { new Guid("a8324ef5-81e4-4ed5-956c-d690eb2affc9"), "LT", "Lithuania" },
                    { new Guid("a9de3f8c-9c74-435d-9a40-e3fa362f2a07"), "AU", "Australia" },
                    { new Guid("aaa650ae-cc7b-4154-9d54-f70cd85cf19a"), "TD", "Chad" },
                    { new Guid("ae198c73-f345-48b2-80ca-d95a8466766d"), "ZW", "Zimbabwe" },
                    { new Guid("ae5cf686-f202-454d-9869-5b4b89814637"), "ER", "Eritrea" },
                    { new Guid("aea61e6c-7843-43dd-9ca7-9dbb671d4f8c"), "BR", "Brazil" },
                    { new Guid("b05fe062-b2c5-4ca4-8c52-eacfa4c49c17"), "CU", "Cuba" },
                    { new Guid("b075081d-ad95-4e74-91f9-fda000be14b4"), "EG", "Egypt" },
                    { new Guid("b221e758-dc85-4101-8c35-c05ac408d47f"), "AF", "Afghanistan" },
                    { new Guid("b25d492e-cff4-43f6-8b9c-f0dd5e5c97c9"), "MR", "Mauritania" },
                    { new Guid("b2c01efd-6817-4a48-a282-c62505b73315"), "OM", "Oman" },
                    { new Guid("b2d2969f-2d17-4ac9-9057-b70913c718a9"), "NZ", "New Zealand" },
                    { new Guid("b388712a-0dc6-44ff-8581-cb851c4a7852"), "MA", "Morocco" },
                    { new Guid("b487a2a5-def1-4173-ba92-e67a32b0bcd2"), "LI", "Liechtenstein" },
                    { new Guid("b6e7a193-99b5-4013-8d12-c6bd25e1a230"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("b8965ccb-1640-485c-85d4-eeba25b68d62"), "PH", "Philippines" },
                    { new Guid("b8a3a4a6-8ce0-4470-adc3-de7314c6a7c8"), "AG", "Antigua and Barbuda" },
                    { new Guid("b8ac76b6-efed-432f-9ef0-0aa759452852"), "UA", "Ukraine" },
                    { new Guid("ba01e218-db4b-4531-b650-d5c592a04335"), "TL", "Timor-Leste" },
                    { new Guid("baf696c5-5c05-4e1f-949f-d68c22b2823b"), "NG", "Nigeria" },
                    { new Guid("bb024354-e1b2-44a2-9cea-5a43c9ffdf38"), "NI", "Nicaragua" },
                    { new Guid("bcff55c8-4086-4f9c-9d78-70c066353c94"), "BO", "Bolivia" },
                    { new Guid("bd649338-2a7b-4764-9fed-f4a2003724ef"), "CY", "Cyprus" },
                    { new Guid("beae3d34-e43c-4a38-97da-5ce97f30cbb9"), "MT", "Malta" },
                    { new Guid("beb961bf-7eae-4905-9d56-597c8e341395"), "IE", "Ireland" },
                    { new Guid("bf419251-516f-4be1-a7c1-7479a7a39ca4"), "AL", "Albania" },
                    { new Guid("bfc4d5d0-19ed-489c-9499-2986104fce82"), "PW", "Palau" },
                    { new Guid("c1243e7c-2956-4c6a-877b-1055c1fdc1be"), "GN", "Guinea" },
                    { new Guid("c187cad8-49d1-40f5-b183-77e505fe6f1a"), "KH", "Cambodia" },
                    { new Guid("c2143cc2-1999-4cee-a1c2-a4d648cf1035"), "MM", "Myanmar" },
                    { new Guid("c26d4543-ed1b-46e0-a2fa-69e8d6bac1b7"), "PE", "Peru" },
                    { new Guid("c2b23e11-8961-4865-8618-0f50c5509dbf"), "ML", "Mali" },
                    { new Guid("c2eeb466-bcd1-466d-8051-015c97f412a2"), "TR", "Turkey" },
                    { new Guid("c435cca7-463e-4bdf-a054-10739f62a796"), "TJ", "Tajikistan" },
                    { new Guid("c682e545-7753-4d94-9be9-d44cfb508737"), "TT", "Trinidad and Tobago" },
                    { new Guid("c7b0ebcb-9d88-4089-80f2-e62dd1910128"), "CM", "Cameroon" },
                    { new Guid("c83b355e-65fc-46e4-b915-dcc7242b16c9"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("cad99ed1-6715-494a-be28-1b9c364378af"), "MG", "Madagascar" },
                    { new Guid("cfbb0f34-738f-4fd2-9c8c-5757adced645"), "PG", "Papua New Guinea" },
                    { new Guid("d28f6113-d910-47c2-9a02-a36459fa5751"), "ST", "Sao Tome and Principe" },
                    { new Guid("d2f20115-5f04-4857-9034-7ba919af3374"), "MX", "Mexico" },
                    { new Guid("d32539be-4e34-4776-948f-d23ff360c71a"), "BS", "Bahamas" },
                    { new Guid("d50b6667-6622-46bd-9716-1ff2710d99b6"), "MC", "Monaco" },
                    { new Guid("d6a356ac-f92c-49ef-a89b-748943eb6f27"), "FR", "France" },
                    { new Guid("d7749c2f-2f6e-4375-be18-dde8830a4bfa"), "SE", "Sweden" },
                    { new Guid("dda183f1-0c4a-4942-9d4f-3407ad6a3b7c"), "BG", "Bulgaria" },
                    { new Guid("de0384be-d7ac-4089-ba35-4d6cd5562bf8"), "BB", "Barbados" },
                    { new Guid("e25e4e14-d027-4363-b0bf-a35cf4f64528"), "AD", "Andorra" },
                    { new Guid("e288dc24-b4b1-4901-ab97-5467e8d1fcde"), "ZA", "South Africa" },
                    { new Guid("e28beb37-ed3e-4e5e-afa7-37de6211852a"), "PY", "Paraguay" },
                    { new Guid("e5047bec-f833-4243-9480-24a8bc57d7a1"), "MW", "Malawi" },
                    { new Guid("e7149579-752d-4ea4-97be-50be2ba0d9f2"), "PK", "Pakistan" },
                    { new Guid("e7e53063-b00f-4638-9e6e-c05d12609b73"), "EC", "Ecuador" },
                    { new Guid("ea162d84-8daa-491f-8151-b406c9ae6276"), "JP", "Japan" },
                    { new Guid("eb704688-863c-4760-8e63-e8bb4137de5c"), "VA", "Vatican City" },
                    { new Guid("ec6901ce-79fc-4081-9a97-5bc73789b937"), "BE", "Belgium" },
                    { new Guid("eeb22cdc-da56-43f0-9d49-5a26494b6c6f"), "RU", "Russia" },
                    { new Guid("ef3ac0da-50a4-4c64-9451-45d883d1276c"), "CF", "Central African Republic" },
                    { new Guid("f0bffdd4-714d-4389-9fa4-d6391b26ba0a"), "IL", "Israel" },
                    { new Guid("f0d0bcad-5149-44f4-b867-a89237c910bc"), "NL", "Netherlands" },
                    { new Guid("f0f6b81a-221b-48e4-a685-769ceeda0e10"), "RO", "Romania" },
                    { new Guid("f1813bd2-0623-4278-8396-6008d2e142cf"), "KG", "Kyrgyzstan" },
                    { new Guid("f278ff18-6db3-490f-9a21-fd2e31d3d64c"), "IR", "Iran" },
                    { new Guid("f2da2324-b555-4b61-a022-926fd026753f"), "WS", "Samoa" },
                    { new Guid("f458f341-29cd-4778-9f94-39a8b8746c38"), "SO", "Somalia" },
                    { new Guid("f7cf42bd-bd72-42ca-a3d0-d99c803e7a43"), "SY", "Syria" },
                    { new Guid("f85b0435-85b8-4da0-a736-2f9128c8ebbb"), "NE", "Niger" },
                    { new Guid("fb069ab3-d87e-4351-97e2-867c248714d1"), "VA", "Holy See" },
                    { new Guid("fe367b68-86cc-45ab-bfe7-574902db7d6d"), "UY", "Uruguay" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("07fa8bd6-2f99-4ce2-a7cf-378d54438ad5"), "Female" },
                    { new Guid("5053a79e-0846-40b6-aa32-f4ab1bd50404"), "Male" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("18c5da8e-449e-42e9-9010-6137c94e4a5c"), "Therapeutic Interventions" },
                    { new Guid("1a12aba8-cd06-40da-8e84-aaae5cf230bf"), "Dental Interventions" },
                    { new Guid("3c95536a-99a3-4665-9c57-b6408e4daac1"), "Emergency" },
                    { new Guid("5d3ad9f3-aa19-4908-860b-b5073dc5f0d7"), "Surgical Interventions" },
                    { new Guid("9951c093-2907-47ff-ab87-2f5b97078741"), "Postoperative Care" },
                    { new Guid("b08f2a11-3bc1-4d7a-a462-37f3f9405976"), "Obstetric and Reproductive Interventions" },
                    { new Guid("bc4b6c70-b0f3-43ac-a96b-981940c73298"), "Diagnostic Interventions" },
                    { new Guid("beb92dfe-973d-459c-8d2d-e3c138d98c91"), "Exotic and Specialized Interventions" },
                    { new Guid("d3058d4c-bd2a-4065-a060-df2d74cffd4a"), "Preventive Interventions" },
                    { new Guid("e24141e0-f554-43d6-a030-7ff5c71697ba"), "Oncological Interventions" }
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
                name: "FK_UserDetailsPets_AspNetUsers_UserDetailsId",
                table: "UserDetailsPets",
                column: "UserDetailsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_UserDetailsPets_AspNetUsers_UserDetailsId",
                table: "UserDetailsPets");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0088e2d3-26b7-47d3-8224-6f74c2e14a55"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01821dfe-30f7-4350-bb3f-c20c757c4962"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03216154-d2d6-4e49-a910-0c2c48e95cea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03240bf7-7e46-4875-aaf8-b79755a69d55"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03903847-24f9-4a79-b29b-3ce32ee51734"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("05705ae7-5892-47e9-9588-b437a38ac52d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06a11929-c7c0-45cd-9933-ba308037b2c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("095342d3-0be5-4462-bcd8-fa4b50a62bb5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("096b1522-9161-4cf5-b4c5-0505b2fde251"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a0a18ca-5de8-4ac7-a8c3-29f6e5c63624"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a492b24-9948-431e-af78-cc1f90ff882e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a57b4af-5bbb-4a49-83b7-1dec3aaa73c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a96e0c0-9aac-4050-9d41-7435717a6e4d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0bb82ac1-2828-41e9-aa8c-7ef0195f68e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0dabbd75-3d7d-484c-8638-e00688c15b58"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0ee6c336-38f2-4f4f-ac16-7dc771599907"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12df14ec-e35f-49a2-ac43-2bf373afeb52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13dc1f77-919d-4f3a-a03e-9ed4e16635f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1487d1c7-2b94-4754-89dc-bad81805419f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1625f0f9-80b0-4685-83bc-534906f6835a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("16fa99ef-82a8-4021-84a2-feacbd86c31a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19847461-1058-43d3-8679-ee0afd7b6348"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b87aab4-6a2e-48ae-99c2-58983f308fbf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e39309c-71e0-4dec-85ed-7b76af431e4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21526818-885d-4bcf-b98e-4ac37519bfe1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("220575f3-3028-4797-8c92-533e101312bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("229aa3d7-24f7-4059-83cd-737603fd2f1d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("246ddb0d-1804-41a9-9b2c-a25c9e3b87b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24b4bd75-a95b-441a-8aaf-625777bdfbd9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24d5015b-6f85-4ead-b506-0ea3413385b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24fa1577-3256-41fb-b830-f181c0a08b6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2694e116-562d-42ad-972a-0a2277c321ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26c7efc0-b3e9-4f98-ad5a-78f011c12c69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28af3243-7cf8-4d3e-bc2a-71f6b285abab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2b06a3cc-4630-4224-9a83-a1568564ee0a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2b2dc701-da52-4d23-978a-acecc0422149"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2bedd924-62a5-4a64-966c-583ce8c0e25b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c8e6333-b18a-431a-a1c8-3586ca53d840"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e11555d-589f-40b0-9cac-82f87e84f930"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2edc7d6c-afa8-48b2-8eda-6c435b7c5598"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32dc36c5-eb79-48cb-b057-a0cf030ff591"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("339c27d2-1032-4b7c-bd47-7b5769943ed6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("344e4ab8-2cf5-4289-8ddd-bf3d03d2400f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("346506f6-5559-4874-95aa-598191d8f142"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34da887d-c0d9-4031-aaf1-18b3ae7fee05"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3603bfb2-7c9e-4ae1-94ce-d898fc646a05"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("36d2600a-70d4-4b5a-badc-ff3b29deb0bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("373125e2-7542-4d28-a08f-894d56f49759"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("386263ac-5fb4-44ce-84d6-92a478e479bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("386c4f54-42de-44ae-ac3e-932d13ff0a41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ae173b5-1535-4508-af2e-eea8cacd4508"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e31e591-3eeb-4249-aad1-8f383a2cbebd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e6f701d-60e5-42a5-8bd5-5896f949a327"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3fb11b1e-fb49-4b9b-8b8b-f1c289e90b7f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("435aeadd-d52a-4bd5-9fa5-adefc0246f8b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("447a681a-afd8-4239-b6a1-5a9adfe4bfeb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45b31936-9b35-4d49-8c9a-8cc1619a33ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("478ec963-29d0-4c78-8214-56b99a9c085c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47f917be-1642-4c73-affa-ee4a9fa73072"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49a15714-aa74-48f9-a94b-58dce67d4dc2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a0fb730-28c4-4bed-bd49-440c73d76406"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a79788f-ae07-4d5c-8390-e7c2b0784e9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("52f732e2-7faf-4c98-8b76-cf05d24e2df6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53484f62-cd8f-4c60-a855-a12c6bce4ee4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56d0fa76-303a-4056-9dc3-28bb9e57b3cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("571ce878-5d47-461f-9d07-02c58d6c8a3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("592f1c45-1f82-4f50-89ae-57a5724fd22f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5971712d-f9c4-4148-a7f6-2e7c7ba102bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("597e13de-73b2-46f5-8167-6fe395d8ddac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5986d9c6-48dc-4f81-b885-dd27034a18c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d2d2525-6967-4e76-abb7-1312dac9d8a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e2b563b-85d0-4ec8-80b6-2bb148c41dfa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f89c64f-fc6a-4177-81bc-28f072838855"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("602b47cd-e883-4123-bb62-85ca3ef2b2dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61fbe421-96c9-475a-bcaf-fef9245156d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6299f9c9-f3dc-487b-a749-8e4cec64d554"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("62f60b5c-538a-4204-a40c-6cfa69e6f0d7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("647e0a14-1a09-49a4-bd02-e5c8760be7b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64c82bbd-35da-4c61-a18c-67a9e7cfa7f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("656f3a96-0e39-4ad5-b68e-63fadcfeaea9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("666dc502-39f6-4f00-949a-8f06ec5812b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6c706b0e-c677-41a2-a047-18712bddae0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6d36e4c7-010e-4dbe-8dac-de5d6c6d831b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7151b881-ef09-4808-adb1-8fe575c4fd96"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71f8fb24-8067-4fdb-8463-0b4ce8f51c98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("726226db-aeff-4a7f-9db1-540883bd2623"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7324d641-00e4-413b-bc55-1efc20beaddf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7695067d-f9b8-4ae9-acb0-d37d92b402b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7761d4de-9a91-4c1f-9761-c4d0ba74945d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7794a75c-472d-4d53-81a6-b2fed9e9a8c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7859aaa0-e38c-4f91-9905-1a4d302a4b9d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7929094c-8288-4940-8702-e58a3e6877bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79c96ef4-5bdb-42a7-98fd-573f354ad061"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e362f15-6d0a-4f71-9ae1-b0720bc60329"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e6305f6-0cbf-4391-9650-e02676e91959"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ecef24a-c245-43f8-9e79-8ca70712ebc1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8064ad3e-fa94-4785-9122-b6fa6342a247"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82872878-2b9c-4ee8-96a1-c02bbf402faa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82b0984f-eb51-408e-8ca2-9e246bfe0148"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82fd9e18-197f-4f48-b292-7420f493264c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83f30379-2cf5-4e84-9d02-431f084c3d0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8480a9f4-c244-47a7-97f3-91456ebc0ae5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("855552c8-dff2-4939-9933-e40f76ac8fa9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85c0a575-d4c9-495a-a68e-ffce0fcbcb1c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85edb06b-f462-4dc7-8c96-95df0f76fbdd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86790926-17fa-41a7-868b-013efc16a95e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("875614f1-ad50-44b2-b47e-65cf3b1c1206"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a26c558-203b-45ba-9da4-ce05415ce827"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8acb4a5c-1815-4633-9572-17d35c4ef27f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b250c6a-3ac5-4500-b0e3-063d4fefd031"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d34c733-d768-49d0-a018-6247172df617"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f28e042-4df4-4791-8764-4d2383ab8bc0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("90594031-3bcd-48dd-bab1-e18a540c2ad8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9128aa58-9d79-4697-ac62-22b4b6b8114f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("922ac711-e68e-4c3e-8bed-409d392828e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("935149f9-4b01-47f9-8b39-055bf760e9c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("94facb0b-b750-4b79-8e72-29db07994bf5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9556264c-f8c5-4ccf-9f2f-7c9f88b41e04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("970f44b5-5665-4679-aab8-7b4ffdfb8e51"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9879af29-d778-42ca-9f00-c822876b71f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9affa43d-5cd0-447d-a6f2-1d05d497b146"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b128a88-453d-4389-9c7f-137acc215cf6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c86db51-0698-40d5-875a-b2e4dd56f1f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a24d86fe-014c-4aac-97f2-95e480caf1eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4001a13-23ee-4bea-b114-caca5d75e0a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a8324ef5-81e4-4ed5-956c-d690eb2affc9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9de3f8c-9c74-435d-9a40-e3fa362f2a07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aaa650ae-cc7b-4154-9d54-f70cd85cf19a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae198c73-f345-48b2-80ca-d95a8466766d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae5cf686-f202-454d-9869-5b4b89814637"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aea61e6c-7843-43dd-9ca7-9dbb671d4f8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b05fe062-b2c5-4ca4-8c52-eacfa4c49c17"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b075081d-ad95-4e74-91f9-fda000be14b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b221e758-dc85-4101-8c35-c05ac408d47f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b25d492e-cff4-43f6-8b9c-f0dd5e5c97c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2c01efd-6817-4a48-a282-c62505b73315"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2d2969f-2d17-4ac9-9057-b70913c718a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b388712a-0dc6-44ff-8581-cb851c4a7852"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b487a2a5-def1-4173-ba92-e67a32b0bcd2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6e7a193-99b5-4013-8d12-c6bd25e1a230"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8965ccb-1640-485c-85d4-eeba25b68d62"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8a3a4a6-8ce0-4470-adc3-de7314c6a7c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8ac76b6-efed-432f-9ef0-0aa759452852"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ba01e218-db4b-4531-b650-d5c592a04335"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("baf696c5-5c05-4e1f-949f-d68c22b2823b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb024354-e1b2-44a2-9cea-5a43c9ffdf38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bcff55c8-4086-4f9c-9d78-70c066353c94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd649338-2a7b-4764-9fed-f4a2003724ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("beae3d34-e43c-4a38-97da-5ce97f30cbb9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("beb961bf-7eae-4905-9d56-597c8e341395"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf419251-516f-4be1-a7c1-7479a7a39ca4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bfc4d5d0-19ed-489c-9499-2986104fce82"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c1243e7c-2956-4c6a-877b-1055c1fdc1be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c187cad8-49d1-40f5-b183-77e505fe6f1a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2143cc2-1999-4cee-a1c2-a4d648cf1035"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c26d4543-ed1b-46e0-a2fa-69e8d6bac1b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2b23e11-8961-4865-8618-0f50c5509dbf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2eeb466-bcd1-466d-8051-015c97f412a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c435cca7-463e-4bdf-a054-10739f62a796"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c682e545-7753-4d94-9be9-d44cfb508737"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7b0ebcb-9d88-4089-80f2-e62dd1910128"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c83b355e-65fc-46e4-b915-dcc7242b16c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cad99ed1-6715-494a-be28-1b9c364378af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cfbb0f34-738f-4fd2-9c8c-5757adced645"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d28f6113-d910-47c2-9a02-a36459fa5751"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d2f20115-5f04-4857-9034-7ba919af3374"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d32539be-4e34-4776-948f-d23ff360c71a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d50b6667-6622-46bd-9716-1ff2710d99b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6a356ac-f92c-49ef-a89b-748943eb6f27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7749c2f-2f6e-4375-be18-dde8830a4bfa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dda183f1-0c4a-4942-9d4f-3407ad6a3b7c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de0384be-d7ac-4089-ba35-4d6cd5562bf8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e25e4e14-d027-4363-b0bf-a35cf4f64528"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e288dc24-b4b1-4901-ab97-5467e8d1fcde"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e28beb37-ed3e-4e5e-afa7-37de6211852a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e5047bec-f833-4243-9480-24a8bc57d7a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7149579-752d-4ea4-97be-50be2ba0d9f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7e53063-b00f-4638-9e6e-c05d12609b73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea162d84-8daa-491f-8151-b406c9ae6276"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb704688-863c-4760-8e63-e8bb4137de5c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec6901ce-79fc-4081-9a97-5bc73789b937"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eeb22cdc-da56-43f0-9d49-5a26494b6c6f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef3ac0da-50a4-4c64-9451-45d883d1276c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0bffdd4-714d-4389-9fa4-d6391b26ba0a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0d0bcad-5149-44f4-b867-a89237c910bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0f6b81a-221b-48e4-a685-769ceeda0e10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1813bd2-0623-4278-8396-6008d2e142cf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f278ff18-6db3-490f-9a21-fd2e31d3d64c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2da2324-b555-4b61-a022-926fd026753f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f458f341-29cd-4778-9f94-39a8b8746c38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f7cf42bd-bd72-42ca-a3d0-d99c803e7a43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f85b0435-85b8-4da0-a736-2f9128c8ebbb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb069ab3-d87e-4351-97e2-867c248714d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe367b68-86cc-45ab-bfe7-574902db7d6d"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("07fa8bd6-2f99-4ce2-a7cf-378d54438ad5"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("5053a79e-0846-40b6-aa32-f4ab1bd50404"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("18c5da8e-449e-42e9-9010-6137c94e4a5c"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("1a12aba8-cd06-40da-8e84-aaae5cf230bf"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3c95536a-99a3-4665-9c57-b6408e4daac1"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("5d3ad9f3-aa19-4908-860b-b5073dc5f0d7"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("9951c093-2907-47ff-ab87-2f5b97078741"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("b08f2a11-3bc1-4d7a-a462-37f3f9405976"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("bc4b6c70-b0f3-43ac-a96b-981940c73298"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("beb92dfe-973d-459c-8d2d-e3c138d98c91"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("d3058d4c-bd2a-4065-a060-df2d74cffd4a"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("e24141e0-f554-43d6-a030-7ff5c71697ba"));

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Bookings");

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

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "UserId"),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "CountryId"),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Address"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "FirstName"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "ImageUrl"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "UserDetailsSoftDeleted"),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "LastName"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "PhoneNumber"),
                    Town = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "Town")
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
                name: "IX_UserDetails_CountryId",
                table: "UserDetails",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailsApplicationUsers_ApplicationUserId",
                table: "UserDetailsApplicationUsers",
                column: "ApplicationUserId");

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
                name: "FK_UserDetailsPets_UserDetails_UserDetailsId",
                table: "UserDetailsPets",
                column: "UserDetailsId",
                principalTable: "UserDetails",
                principalColumn: "Id");
        }
    }
}
