using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveApplicationUserMaping : Migration
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
                keyValue: new Guid("00ae1727-850c-41d2-b769-7d8e3e72ca56"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01213826-3492-4d9c-8884-1cb2ca95f10e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01270f6a-9e35-46b0-9357-f007eba77b65"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0232b013-2a51-4cbf-bf05-2492001b9854"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02f342a9-bdb3-4c9d-9a9e-f02101e26b98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06a3f6f1-f2a2-4959-ae29-e0fb37ed91b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06c2b087-908b-4a2c-ab7e-f6411bf52960"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0724b0f0-7756-4e25-b4be-f924af699626"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("081600f6-7264-4f9f-9d60-0a2ba9b840bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a8a7053-4af3-468c-87ff-8a7c8b64be7f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0dfda2ca-a21a-4b70-8d28-31278954c795"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0eede598-5928-40ac-abec-2f1a2e55b723"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f42e59a-1825-45d0-a1ed-37808cacc825"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1000a217-9657-47f1-a688-662c33eb69f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("10a68249-e512-49d2-b1e5-cb7949915fe2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("133b61a8-073b-43ec-a9f9-05f4f0c7e250"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13f63d45-bdc4-4ee5-b046-78e479e41ecf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15a0f2c2-6f83-436a-b988-f84ac3c2116e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15b8633a-1f44-4b9d-b5df-d656cc6d1540"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15d054ba-36d6-4696-8f0a-69947ad0702c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15f5a296-2d94-4b40-841b-c2f2021333b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1688b520-6518-4a77-ba9b-baf3deae33c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1738f778-665a-4d55-81c9-fa5f6dbffe77"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("176a10a8-6ae8-4eb0-b8c9-ffa0f093f2ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19b04742-ecec-4efd-91d1-76940286b8de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a719dd0-953b-4f92-93dd-8cb8887db933"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1df9fcfc-ac4f-482d-92ae-7543d68e5ae9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e07b9be-2ba2-4ec1-820f-b18b78b0e14e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e9f55c0-a09d-4778-9d3d-eb631a9b0fcb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2088b6b3-6b70-4ef4-972d-fa543de8c245"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("216f3db7-4dc0-42ab-9fe7-4e64b1db90bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("246f9fee-f185-4040-af2a-f12451f78b41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24d0d33e-64f1-4ddd-af28-700ad7d5c7a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2899ab06-fea2-48fd-a2cc-9cbafe2af2d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29ad4fd4-7edd-47b5-a035-a5d6e1064ef9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a1cd64c-f8a3-4f7d-9d1b-690b2c9639a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a966c2d-b0e7-479b-b5c3-672f12d06c8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a9bd9cb-50c7-40d9-8673-e9f113414ebc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2b073599-0c4c-4046-82df-954dcd0b3852"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c94757c-d396-4df1-91f4-6aac338d365e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d2d9455-6cf2-42ca-8b2b-7507201941fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d34e4d0-31dc-4721-91c7-891d98da79fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d8905d1-8146-49cd-913c-3841a2a2d797"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e36fd62-0768-47da-94c4-7e600ff8ba94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31af1d74-2417-4385-9097-c87c72faf030"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32056b98-8eeb-465b-8993-104930f17b87"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32e7d735-77f9-4d98-92fc-775a38220766"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("349e039e-45a3-4039-8ae1-9b3281a67f2c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3512ed52-93f1-43c8-84ae-327e81099909"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("390fa90a-0260-425a-b11f-e2e0c1dab877"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b43132b-bd73-41e0-901e-038d3d8a35a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3dd75624-81d3-4169-bde8-f159322dac2b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3fbb62b1-74c3-4af9-b204-2245874b670c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3fc93f10-1b37-4371-bd2f-1f9cb73bd2f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3fce75ee-1159-4e41-9da6-1b2758f277e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4204f3b3-3d66-4545-ba1e-27f821b0a157"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43612479-c065-4486-9981-e5a704bb9ee1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4663b867-5207-4364-80bb-bedd2f4ae164"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46b4f9fc-cb58-44fb-91c8-4b37a0bafbb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("483f3ff0-d7a1-488c-ac4f-0202ea8f27e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49ca8cc4-72fd-422e-bfe3-96f8048d7cd7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a5c2b33-ca6e-4549-8ba7-1e834b126b6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b428565-4f5f-4dcd-b86f-532a18b1cfcb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4bd592ce-714e-469e-9818-6e1ecf5842a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c62ca31-2b9c-4b3d-98cc-387f7305924b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ef9a963-a602-472b-908d-1af57995d935"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f90483e-d677-49cf-9a07-509793cb2dff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("52029a04-b15d-4bea-9072-81d57e49c9dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5308b0db-258e-4083-a4c6-c8201fbb9ce4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("531e81b6-f53d-410b-a288-21d4aa61473a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55ebe959-7178-42ff-801d-78757236d0d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59e8597c-583d-4db2-921b-418a5bed82ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a10f280-4a82-4912-93f9-7c2912187a4f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b3c6212-8558-4040-9753-128a5166700e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b3e2c83-4714-4d4f-9a61-3e639ef115ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5bfc50ed-b97d-4dc0-ae62-2bdd1814cc2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d9402f6-bfc5-4c0a-b5c7-ada56b220998"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5de923b0-7cd1-4001-b457-4131cdfaf14c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e578369-12d9-4e31-92a3-c385d9145f9b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f68c8b2-3892-4e99-9da4-53c8512e1523"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61a29a59-cfd0-4b1c-aefc-d6dd46a1ef83"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("62d1231d-69f8-4ed7-a172-6be7d2070be4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("646e81d0-0629-472e-a56e-3bcf89e7b319"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("652bc048-be37-4f61-a465-84ce667fcc79"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6782e845-9099-40ae-b6da-955fd06ba2b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67f23381-1189-4837-af5d-1f8bdecc054e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("697b07cd-1944-4e4a-a716-37482281c311"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f02cf5c-e257-4660-afce-836e631b8715"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71b60ec2-a4f2-4424-9475-909cc19784e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73804e5e-4382-496b-9c78-6a8707f4c658"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("746251b4-e0a4-4b3f-8435-9ef954a443bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("755ffabd-6648-45ee-a83d-bc5c95e1642c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a26d9a1-21e1-4d13-b0f2-a09fa1d13e92"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b199cd9-8692-4953-88f0-d8627c736bb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d6e83e3-b39a-45d8-9381-40109d6a7818"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7dd8213f-b2ca-4b59-8b76-3ad9381ca097"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7fd1156f-1a6c-4abb-ade0-a4ecf2cea030"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("801df666-e0e9-46d3-a2b1-b16567ef0a58"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82b8348b-d306-48a4-8165-9ff639b59d70"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8343c285-eabb-444d-9484-99c4b9b14c27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86976436-0ebd-4c23-917a-8147b86f791a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87987a8d-3b5a-49bf-bf6d-acc3652b35e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87dd8b52-aafd-40f3-856c-aa5ef37c35a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a54d6e7-843a-4f54-ad7f-6118e73e32c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d499757-f069-4ba5-b593-3a2c8ba6e9da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e33963a-a059-47ca-b7ea-1af5a9def1a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ec5b5b6-429f-4684-b88c-92be53b2d336"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("919b347e-ec6c-4864-afa7-d8f42f320067"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9235eb45-db1c-4fe8-bfec-a058a092d4ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9302d4fb-188e-46d1-bb8a-56236146a91a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93aad2fb-5f4b-4fbe-bae6-1d03c99ec904"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9454c20d-c29f-4a21-88ad-6f44bb2b4e57"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("94f6689b-b350-4bcf-a654-30c02c7d9948"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9782bfd9-0e2d-4881-b431-4aaf2916bffb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("982acc58-27ed-4c3b-a15f-da04b66c79a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99252cf0-84ad-4c70-a090-781e013265c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99e93447-db8d-4d64-98b4-7fdc966206e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b802fb9-517e-4f00-a110-7ddd90df206c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d97e585-4ade-4aa3-9834-b115d25bb17a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9dad5197-af79-4270-8906-8508c1b1ee7b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a079ccba-91f0-454f-a015-2f82d73b8cfb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0afce6f-4268-401b-98be-210eec03cf29"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0f10850-76c8-4c71-b324-036469121205"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0fd2c8e-a4a5-43df-a024-6f9dbee58a5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3043be0-7e65-4460-ba4a-4585bbb987da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a31c3939-3170-4142-b23d-170d0a878907"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a385902c-6054-4e70-b332-ecaca7058dc0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a42f4ba5-17ee-4e43-ad87-b1d6e204500f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4631646-6005-4241-931c-ff42d248b32d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a683a594-7da0-4d48-a0d5-4f97c974656e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a77513d2-dfc2-4cf3-b5bd-264c5a2682c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a7e4db88-846c-43cb-adf6-99a4dbba6f63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a8f71682-f9e3-4b04-bd0e-a21df6c947f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("abc17fdb-dc64-47db-bc98-7d69395d022b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af396e7a-7947-49ea-9bfc-7f39be908d3f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afffa3cc-e023-4ee5-9278-edb00a3116ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b39eb065-b7e8-4826-af99-8308e9b2b9c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b7d5840e-d3c5-4cb1-8adf-d204f3f67aec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b80e011a-ea58-4455-bc42-69eb625817ee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ba7a203d-1134-423e-a3b0-cbe0596e14f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb340f96-f6b1-4871-8537-bdb6f7cd8816"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bcc748e5-2d12-4563-9591-232189ecffbe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be8e5474-8db0-4250-94cd-34aa238a61a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bed6805d-9b99-4efc-b62e-3236a2cd0f85"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c20eae83-25de-4c43-9e44-0dda5f946b7f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c36f770c-6325-4f60-a696-f12b0feb1379"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c38c6a7d-20a5-4a23-9049-ba81738f567b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6a8fc07-e574-4edd-9749-745588ab92c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c73988dd-24d7-43ea-a276-7884f91aa0fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c79063de-4187-40bc-9883-d71cd3c81cde"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7ada25a-6c00-4522-98a7-63584b12cbb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7ffe854-8c0f-4471-bfac-9688f7d39ff5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c83a4330-1fba-4cb2-b365-89e66c5df09b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c866ef3e-0648-43dd-8582-a5c65d755651"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cae57cdf-2f74-42ff-967b-93d5ddbb0539"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb4eb95b-265f-435e-8e57-3408e0e20393"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdf43810-eee6-4a65-bef3-2fc15bcf837d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf194355-73d2-4254-a2d6-3adc8308a540"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf55ed70-74eb-4e69-89f4-2620457b1487"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1688726-3811-4c40-b1b3-ce689ef255c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1f05ef1-dfec-4d76-aa93-1caa85989be3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d686fc5e-ea86-4267-8528-4bcf692decf0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6d46b32-2d21-4464-9b48-f5dbdc6b8e53"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9d428cd-0c0d-4cd0-ae9a-91c98c489c2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dbf26abc-edf7-4da7-9bde-c41bb91d1c2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc512f55-cfae-4000-b9c4-92ddfd65e834"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc75996c-cdd8-4801-b54c-1df8a6fcf2f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df6648e4-f202-4afe-a6b9-b02ff0f04233"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e191a707-80ce-43ae-9d9e-2c84b6608343"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e45f96b0-2cc4-4a40-a7ee-21520c8cf4ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8d4d99a-1f51-4e8a-9033-36bc2c7bb359"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8fc5339-3e84-4bb9-813c-53926cd9a3e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ead9eacb-6323-4371-89b7-1880fac077fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb20bc19-bb67-4192-b3aa-7cf302026f84"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb821b3b-cae3-47f3-b687-714dc7e318c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eca07750-1eef-4a14-8554-87e6907b814c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed7bc6e9-a71b-4e9f-ac5a-a30a782e38bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efcdf9cb-e53b-4851-8e89-50436c4380fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f00aa88d-8efa-4854-aff7-289518ca81cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f14baaf9-863a-46bd-bca1-2ab7620ff388"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f241980e-61ba-4c60-a007-c069797d005a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f248c5e2-a664-46c4-ade3-d2dc4ca63544"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f33633bb-0024-4bfa-8bd8-df640a3018d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f372b00b-31c5-4285-b313-eb17f14d6cd8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f39c7ca6-d3cd-44d6-96e7-ee75dc687460"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3ab1f4d-0ed1-4120-82d8-dfe58feec6de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4b49723-c9b4-4f04-83c6-38927fe9986d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5c22419-05ba-43ce-a47e-01991d9f457f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f6d08ff2-fd8f-48b9-9ca2-fee4243d79f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb1df71d-0ae9-4f3c-97c2-319e9907d538"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fdd009a0-e7d0-4bc1-859e-e714b41d39e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe0dc907-7793-4d2f-88b0-b28c0cc4f131"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("feab06fa-00a6-4529-8a97-853e7b7367dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff8ca592-a540-491f-ba53-ae7de1619b2e"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("9a1c41f9-b241-49a4-9735-26c882377da7"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("9eef9bf4-0a62-46b8-9088-456984c3fdb8"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("043db6c4-740c-4be2-b187-d8b40d388e57"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("24f9fe3c-dfeb-4774-9435-1187896d69dc"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3009cbe3-05ff-467d-bcaa-fa68f6283ec8"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3e147d6b-cc63-457b-a72d-7b25b33cbf9f"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("50065faf-c698-438d-9c95-d02ce0f66f9c"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("a4e9d842-9653-4e62-8c52-2807f4108ab9"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("c2cb2932-3cec-48ca-84d5-4afbeb5eddd9"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("c5b4f8db-7c3d-4209-85ca-20bf45228489"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("cda9429d-4488-490b-8329-db701034e670"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("d960e86d-1e91-4f72-b02a-2a3f213e7675"));

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
                    { new Guid("012f18f5-fa7a-4c80-a5d7-2307e0ebf825"), "ZM", "Zambia" },
                    { new Guid("0361fa73-1ee8-4ece-872e-0fae9e661385"), "IL", "Israel" },
                    { new Guid("04caf9ea-5e25-407e-8240-5c1a3c704470"), "GQ", "Equatorial Guinea" },
                    { new Guid("06fdc711-5909-462d-93bf-2642e2978d1b"), "GN", "Guinea" },
                    { new Guid("07278c05-8c63-4d46-9605-d83853c9b61c"), "TV", "Tuvalu" },
                    { new Guid("08347e49-8cc0-4b03-bf7f-f11b577d3636"), "LI", "Liechtenstein" },
                    { new Guid("084fcdf8-6013-4dd7-9549-59d7aab656ad"), "CN", "China" },
                    { new Guid("08f0d065-6fb7-4879-8168-3a401ac26a8e"), "LS", "Lesotho" },
                    { new Guid("0bcc8808-29cb-4217-8981-ca372c482896"), "CV", "Cabo Verde" },
                    { new Guid("0bcca64b-7a54-498a-ae30-47a104c2ac81"), "AT", "Austria" },
                    { new Guid("0da0e458-d73c-41d4-8def-bcaee17195ac"), "AL", "Albania" },
                    { new Guid("1009f8cf-439a-4ec6-b088-ec1fdc133776"), "BG", "Bulgaria" },
                    { new Guid("1135e88b-a56e-4174-a8cc-f9840c21af5d"), "ZA", "South Africa" },
                    { new Guid("1263c9b4-d007-4e2c-8c10-54dcd5dda77b"), "NG", "Nigeria" },
                    { new Guid("129800ba-af72-4801-8b72-947be0a0093e"), "LC", "Saint Lucia" },
                    { new Guid("130243c4-86f5-4d29-ab84-bb852997b009"), "AO", "Angola" },
                    { new Guid("1725864a-0b4f-4302-a3f3-fcf722c6c03d"), "CH", "Switzerland" },
                    { new Guid("17b1290f-697e-4a8b-a15f-e85005203a74"), "DZ", "Algeria" },
                    { new Guid("18875708-73bf-4920-8f08-630f9160a5f4"), "EE", "Estonia" },
                    { new Guid("18ac3bad-543a-40a8-8ad4-add12db679ed"), "HU", "Hungary" },
                    { new Guid("1aefbe0b-8bb1-457a-8874-397978829e88"), "MG", "Madagascar" },
                    { new Guid("1bba82b2-ded8-4376-977d-ea995cce015b"), "QA", "Qatar" },
                    { new Guid("1d389e76-3fba-40bc-8d62-7e127e0332af"), "PL", "Poland" },
                    { new Guid("1f02aa2c-7473-4252-8bb9-689a2dda842f"), "SD", "Sudan" },
                    { new Guid("2147497a-4099-4e38-8d71-129b53a84832"), "CY", "Cyprus" },
                    { new Guid("2171bdb3-6878-43ff-b21d-d62110c78a94"), "KH", "Cambodia" },
                    { new Guid("21d04ccf-1520-41bd-b388-7a039fde31de"), "RO", "Romania" },
                    { new Guid("232ccf82-7e7b-4308-a7b1-9fb4c0a4d51d"), "SR", "Suriname" },
                    { new Guid("24620e81-f64f-4841-b861-5322aea9d58d"), "KI", "Kiribati" },
                    { new Guid("251103fb-84ad-41f5-949f-a8cf5cc6bed3"), "BN", "Brunei" },
                    { new Guid("28f6e424-988b-4f5c-a04c-fef3ffaafb7a"), "VU", "Vanuatu" },
                    { new Guid("292aadf6-0c9a-4e2e-8fec-77ff3a237de1"), "BF", "Burkina Faso" },
                    { new Guid("29f23f10-d2e2-4ddc-a60c-673a897857f4"), "AU", "Australia" },
                    { new Guid("2a2a404b-cbba-4a4a-a538-df4aaddd12ab"), "ME", "Montenegro" },
                    { new Guid("2acb0c00-ba8a-4a2d-ba84-cff14fb31e4a"), "ES", "Spain" },
                    { new Guid("2bad3be8-c51f-43bb-bd5f-070315d37d1c"), "BI", "Burundi" },
                    { new Guid("2bd7a3a4-494c-4edf-b340-35009d160f5b"), "TJ", "Tajikistan" },
                    { new Guid("2ddc577c-4792-48b2-a1fb-ad5ebd308e00"), "HN", "Honduras" },
                    { new Guid("2ee0c302-2ed8-434a-898a-1f991833a6f3"), "PY", "Paraguay" },
                    { new Guid("2f11efe6-3456-4711-b6f5-4d135c1fd1b8"), "EG", "Egypt" },
                    { new Guid("2f6f70f4-2650-4f5f-b0af-6a308ba56ddf"), "MH", "Marshall Islands" },
                    { new Guid("30978597-0e23-4d6c-8696-b0f5c94ffa6d"), "ML", "Mali" },
                    { new Guid("3161d231-f8cc-41a0-9af4-dcf381fd073d"), "JO", "Jordan" },
                    { new Guid("376fd354-e025-44e9-a08c-cf41d1be7783"), "TZ", "Tanzania" },
                    { new Guid("382cd2da-97ab-4083-91be-e3ade5aa9732"), "AM", "Armenia" },
                    { new Guid("39bf2f3e-2ba8-4cd1-afd2-ae4cf05e37a6"), "US", "United States of America" },
                    { new Guid("39ea63b4-d0da-4924-80ca-ac7ea2da6555"), "BW", "Botswana" },
                    { new Guid("3e03094b-9b87-4666-a596-94054d36e79e"), "CO", "Colombia" },
                    { new Guid("3e59f609-58a0-42fa-9da3-031aaef72e29"), "TM", "Turkmenistan" },
                    { new Guid("3e8394a1-fc82-44e2-bee6-752e494abf90"), "AZ", "Azerbaijan" },
                    { new Guid("42ea6f9a-33ab-455a-8d56-4e4b15802e8f"), "IE", "Ireland" },
                    { new Guid("43352cb7-0c27-483e-8ff7-5bb764d3e2a0"), "FM", "Micronesia" },
                    { new Guid("43ac9bb3-fc92-4e83-990a-b60ae3d68850"), "SM", "San Marino" },
                    { new Guid("43e3008c-86db-4ddc-b871-aebc72b0c8f6"), "PW", "Palau" },
                    { new Guid("4495a504-7493-450c-92b9-e7128f41eb14"), "SE", "Sweden" },
                    { new Guid("45213ea5-f7bf-483d-89d9-b9050f48c6b3"), "DM", "Dominica" },
                    { new Guid("4b682353-afc0-4e55-a573-566bc15afb0e"), "MN", "Mongolia" },
                    { new Guid("4b81990a-b47f-47cd-a263-edf8071a1d1d"), "KE", "Kenya" },
                    { new Guid("5119b22a-3452-41a7-8656-0cdcc3f5b2ec"), "IS", "Iceland" },
                    { new Guid("543e95c6-6fd7-48b7-a030-fb6224a1092c"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("5461c0af-eed8-4af9-aaaa-25d88d7cf2b7"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("55c52885-7eac-4810-b6c4-86bcce6311d5"), "BT", "Bhutan" },
                    { new Guid("55fa9d23-3769-4864-95d0-eac5d0c42801"), "PE", "Peru" },
                    { new Guid("56ad5ed5-32dd-41ff-b649-86ed27069483"), "TO", "Tonga" },
                    { new Guid("5795c7e0-59e0-4856-bb61-edd74621b42d"), "DK", "Denmark" },
                    { new Guid("57b2f108-6f83-4188-9e49-ef884a7494ba"), "TH", "Thailand" },
                    { new Guid("58ce60f3-90f9-4143-a89f-f0420a18f08d"), "MR", "Mauritania" },
                    { new Guid("5a6e2df7-11ed-4067-9a2e-ccee25104c40"), "LV", "Latvia" },
                    { new Guid("5d971e39-c783-4d8b-a822-75cad58ca1da"), "MC", "Monaco" },
                    { new Guid("5ee6ca4a-0034-4e65-980e-d5244c73bc4b"), "LR", "Liberia" },
                    { new Guid("5f165159-9e54-4d64-9e35-485a6825634e"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("610f12e9-2a38-443b-98f8-5ddcd8a6bbce"), "UY", "Uruguay" },
                    { new Guid("613d0a1c-f2c4-46c0-9c14-240a13d57dd5"), "AR", "Argentina" },
                    { new Guid("62545fc8-32db-489f-a3b7-b4fdb1c2a9c1"), "PG", "Papua New Guinea" },
                    { new Guid("641b6885-604b-48c3-9fc5-33a62e688156"), "VN", "Vietnam" },
                    { new Guid("6448f215-c245-4b44-8912-6a8dcef2f6c8"), "ZW", "Zimbabwe" },
                    { new Guid("64837e21-141c-469c-9f8a-38a6716bd510"), "LB", "Lebanon" },
                    { new Guid("64d5c941-a966-4e70-82f7-bbd433b7fe66"), "LT", "Lithuania" },
                    { new Guid("693a0670-0332-4d34-97b7-0de8db3e6857"), "MA", "Morocco" },
                    { new Guid("6a318801-b6b0-4568-8a5c-384a5058fec6"), "TR", "Turkey" },
                    { new Guid("6a7ccd11-c0c8-406c-bbc7-93bc19d8fc86"), "JP", "Japan" },
                    { new Guid("6c69f99d-993d-473f-b65b-d2bbd8f22cc7"), "YE", "Yemen" },
                    { new Guid("6ca6bb67-2e05-41ac-8d9c-6dbcca6eb581"), "MW", "Malawi" },
                    { new Guid("6e9e0a5e-5bdd-4449-868f-2f595fb9214e"), "NL", "Netherlands" },
                    { new Guid("6f1520eb-06e8-4136-a82e-ab46ee4deb24"), "LA", "Laos" },
                    { new Guid("7312e068-43e4-4c8c-beab-b717c7c77e38"), "CU", "Cuba" },
                    { new Guid("7438cdf4-c21c-4ea9-b71e-d55734528aac"), "KG", "Kyrgyzstan" },
                    { new Guid("761da197-22d1-4375-96d0-01edce177ed2"), "SL", "Sierra Leone" },
                    { new Guid("77d4ae32-f022-43d7-93ce-701131c0d127"), "RW", "Rwanda" },
                    { new Guid("7dfd51b4-b3ab-455b-877a-7478482e4641"), "UG", "Uganda" },
                    { new Guid("7e088bfc-4325-4e5f-a0ae-61241c6e44e1"), "BJ", "Benin" },
                    { new Guid("7efb8480-2080-4172-b5fe-74d5b09ea8cb"), "KP", "North Korea" },
                    { new Guid("80af83f8-0069-4509-93fb-54827e1db98f"), "LY", "Libya" },
                    { new Guid("81e14200-5052-474e-a4da-e0339b956bb8"), "ER", "Eritrea" },
                    { new Guid("8277d960-fdc1-4e7b-9608-2f1bfe8d1dab"), "HT", "Haiti" },
                    { new Guid("83c00915-549c-4d3e-acf3-6ed5d9abea92"), "BR", "Brazil" },
                    { new Guid("84b99a10-4e73-4595-95d4-02eb7087ff26"), "GD", "Grenada" },
                    { new Guid("895053f4-8367-4b29-8ebf-8475be692529"), "CF", "Central African Republic" },
                    { new Guid("89f94de4-c82e-406b-91fb-9ea6f743ddbf"), "BY", "Belarus" },
                    { new Guid("8a079488-2f26-40a4-8fd1-82d4f7d06c64"), "KR", "South Korea" },
                    { new Guid("8a9f4b6a-b76c-4041-9973-017d9c54aabb"), "UA", "Ukraine" },
                    { new Guid("8b107ea6-818b-4e48-b118-0c7986b93655"), "SA", "Saudi Arabia" },
                    { new Guid("8c0d9714-da45-42c2-a618-8423f96ac1cd"), "KM", "Comoros" },
                    { new Guid("8dad67b5-1d15-4b5a-9fe2-4b0b13307bf8"), "GA", "Gabon" },
                    { new Guid("8f1e12de-1e2d-4931-a49d-a067fbb70091"), "NE", "Niger" },
                    { new Guid("91301e6f-713f-431b-aa91-dd671b92113f"), "TG", "Togo" },
                    { new Guid("91dc4b8c-8dcd-45b2-a640-9004ed94082e"), "NR", "Nauru" },
                    { new Guid("921f06e7-2c88-49cf-b47d-e37230d2197b"), "PH", "Philippines" },
                    { new Guid("933645f8-9e7c-495c-8041-ba5e33d54faa"), "FI", "Finland" },
                    { new Guid("9544eacd-53d8-4356-ae85-d6e226a1287b"), "IT", "Italy" },
                    { new Guid("964f6b7b-2aa8-476c-bf69-18cb0a3a9710"), "LU", "Luxembourg" },
                    { new Guid("96ad5162-3f8d-45fd-9095-104bf37b9f98"), "KW", "Kuwait" },
                    { new Guid("98c308f4-bff6-402e-88a5-64ac1ff12801"), "TD", "Chad" },
                    { new Guid("99078d34-02ad-4e0c-93ce-2a590b5de2dd"), "BS", "Bahamas" },
                    { new Guid("997018f5-dbca-44fc-b81b-e589685ff52d"), "HR", "Croatia" },
                    { new Guid("9a950678-40ac-4c5a-96df-f6c927e6f667"), "MT", "Malta" },
                    { new Guid("a00e41ef-aa01-4ebb-a599-7a1b4f04b3fa"), "IQ", "Iraq" },
                    { new Guid("a4687232-b840-486b-bfe8-9c5cd79b155a"), "CA", "Canada" },
                    { new Guid("a532f409-7f05-4bfe-86b0-c4855463d3be"), "NA", "Namibia" },
                    { new Guid("a62feb8e-ccc8-4e6e-aa20-68bf13399dfb"), "TN", "Tunisia" },
                    { new Guid("a67146b4-915e-4f31-98ca-96bad6e5c0da"), "SN", "Senegal" },
                    { new Guid("a70c1352-a504-4a7c-a4da-357eea026c07"), "AE", "United Arab Emirates" },
                    { new Guid("a8949c27-63ca-451f-a14f-1cdd349bd020"), "SK", "Slovakia" },
                    { new Guid("aa5dd3ab-1338-47ad-ab80-f8a761e46c9a"), "CL", "Chile" },
                    { new Guid("aadbfb78-1397-4a94-9239-a14ba4a5e2b3"), "ST", "Sao Tome and Principe" },
                    { new Guid("ae2cdaec-984b-40b0-a443-acd33b875d0f"), "BZ", "Belize" },
                    { new Guid("b0b87074-9f5f-4379-98c0-5c1a21ee4c58"), "MY", "Malaysia" },
                    { new Guid("b1d0e10c-ce63-469d-a254-739e8823d031"), "TL", "Timor-Leste" },
                    { new Guid("b386a4d1-129b-4358-8dd8-bdd943696472"), "AG", "Antigua and Barbuda" },
                    { new Guid("b42e654e-422c-497c-a58e-365009a2b194"), "WS", "Samoa" },
                    { new Guid("b5c54e4d-5fde-43a8-a662-9a2407683c89"), "VE", "Venezuela" },
                    { new Guid("b945b9eb-a37c-4707-a50f-44bfe0081855"), "DE", "Germany" },
                    { new Guid("bb382f49-bde8-42de-b454-f3afd11116a9"), "SG", "Singapore" },
                    { new Guid("bb44eb42-9f44-49fd-b316-ae88b9be1757"), "LK", "Sri Lanka" },
                    { new Guid("bc485582-cd0e-46f1-93f5-323ad149d6c0"), "GM", "Gambia" },
                    { new Guid("bd845f84-a5e0-442b-9efa-2cc4e4960568"), "IR", "Iran" },
                    { new Guid("bef4df71-20ac-496e-b1c4-5c4da9de9898"), "MD", "Moldova" },
                    { new Guid("bfe5ba56-142e-4420-93ec-46758a30c0ea"), "TT", "Trinidad and Tobago" },
                    { new Guid("c011ed7b-29db-40f6-84ae-991ad58e23df"), "NI", "Nicaragua" },
                    { new Guid("c20c037a-f3bf-4cc2-b4f2-3c3a53db8b1d"), "PT", "Portugal" },
                    { new Guid("c2b39bb7-be43-40d4-b726-ed5d3a62baec"), "BE", "Belgium" },
                    { new Guid("c2c61b56-2a9d-423a-b8d8-7b5885a4f847"), "SZ", "Eswatini" },
                    { new Guid("c39c153b-2356-47ad-a264-ef6fcb03c747"), "GW", "Guinea-Bissau" },
                    { new Guid("c54c165a-b21a-4073-a80f-d514ada4ae25"), "PS", "Palestine" },
                    { new Guid("c5f86164-5ff8-4c4f-853e-7a5cb91840c9"), "IN", "India" },
                    { new Guid("c60a70fa-d789-4be5-a5c9-42652b898697"), "SV", "El Salvador" },
                    { new Guid("c667b7d2-b355-4025-abd3-d336fc72966c"), "ET", "Ethiopia" },
                    { new Guid("c9ec16e4-f2db-4e49-bd9d-81a2c0c39674"), "UZ", "Uzbekistan" },
                    { new Guid("cc1aadfb-738f-4596-9289-53830ed3b3b2"), "BB", "Barbados" },
                    { new Guid("cc95f404-c5e6-45fe-8821-4fe3db86d022"), "GE", "Georgia" },
                    { new Guid("cd5de2f4-e973-4194-a9a1-e622f30097a2"), "SY", "Syria" },
                    { new Guid("d35515f1-8568-468c-8fa7-b21825e6b0d9"), "SS", "South Sudan" },
                    { new Guid("d4fc87cc-108c-4e8b-abb1-79257ffe212e"), "KZ", "Kazakhstan" },
                    { new Guid("d6e6ea6f-ce53-4ad8-98de-786b0737771a"), "GB", "United Kingdom" },
                    { new Guid("d719ad5f-b224-474d-8c18-7693999c693b"), "DJ", "Djibouti" },
                    { new Guid("d7a547e0-c5ab-4008-97fc-9d00d58a5dea"), "MX", "Mexico" },
                    { new Guid("d8c8e8f3-3d02-4835-982f-f5495ed70edb"), "SI", "Slovenia" },
                    { new Guid("d99595f7-9005-4ca5-841c-a30f99b70a0d"), "RS", "Serbia" },
                    { new Guid("d995d5e8-37d9-4520-8c91-d01f2a0d9508"), "EC", "Ecuador" },
                    { new Guid("dd175d33-11e8-4496-92a6-9efebdd204ab"), "MZ", "Mozambique" },
                    { new Guid("ddc58846-d5be-4469-8f0b-89a3820dc87b"), "PA", "Panama" },
                    { new Guid("dddfe4a6-1bb8-4c0b-b148-fd6e923763c3"), "MM", "Myanmar" },
                    { new Guid("df077799-8782-4693-9464-3ca01ac5fe45"), "SB", "Solomon Islands" },
                    { new Guid("dfa4e2ed-1c3a-4cf2-b5f1-c2ce32a25f1a"), "CM", "Cameroon" },
                    { new Guid("e03c9961-f9ea-4107-83b5-83934c680c9d"), "PK", "Pakistan" },
                    { new Guid("e16790cd-c4ce-4122-843c-1e66cb884457"), "GR", "Greece" },
                    { new Guid("e1bb853d-9588-4512-8753-d8db15c985e0"), "DO", "Dominican Republic" },
                    { new Guid("e29717c5-8856-4812-ac14-221194ecacf1"), "MU", "Mauritius" },
                    { new Guid("e36588fc-9950-4f17-a4ba-01ce4c7473ad"), "GT", "Guatemala" },
                    { new Guid("e395d9fc-7a25-41af-bb2f-5bdf16bcca3d"), "FJ", "Fiji" },
                    { new Guid("e415c4af-c892-4d75-a719-3639801b729d"), "SO", "Somalia" },
                    { new Guid("e434fe64-6a27-4f2d-810e-5d3dce8c13f9"), "ID", "Indonesia" },
                    { new Guid("e53f1560-de15-44c1-b1bc-e903e125de2b"), "BH", "Bahrain" },
                    { new Guid("e5667af0-c5fe-49ef-9864-8b07e08636c4"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("e8a33fc5-d0ca-47d0-bcf1-c737819dfe31"), "MV", "Maldives" },
                    { new Guid("eb30bb18-cb3f-40b0-a707-ccf32dbd3e4c"), "GY", "Guyana" },
                    { new Guid("ec0f5148-4a05-4eb9-9e3c-de2182b684ad"), "BO", "Bolivia" },
                    { new Guid("ec875260-95f3-4565-bc5a-65e40e9dc719"), "GH", "Ghana" },
                    { new Guid("ee5582df-3b23-4659-9c65-c9062506358b"), "RU", "Russia" },
                    { new Guid("ee74b93c-56cd-4cc7-8d03-04599077e04b"), "FR", "France" },
                    { new Guid("ef482d63-b2c7-4e31-a8b1-54a3eab009b5"), "VA", "Vatican City" },
                    { new Guid("efbab887-ba1d-42da-b84b-f8784e45b1df"), "OM", "Oman" },
                    { new Guid("f2617d12-e265-48c2-a02d-1e755a687a73"), "AF", "Afghanistan" },
                    { new Guid("f309a90c-77a0-4ba9-b395-87385f78c472"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("f3426e5b-73ba-403d-b5ee-99f361febf20"), "BD", "Bangladesh" },
                    { new Guid("f3d7f662-f38f-4202-9183-20903dd3acb6"), "NO", "Norway" },
                    { new Guid("f55ff955-205a-42fc-81eb-27b0c66c5b4c"), "MK", "North Macedonia" },
                    { new Guid("f5b7438c-07ef-466a-b1be-7cdcfac13cb4"), "NZ", "New Zealand" },
                    { new Guid("f76f3fc5-506a-4ca7-b69b-e272c2bd3515"), "VA", "Holy See" },
                    { new Guid("f7b90793-01fb-47db-bd6a-7420090eb083"), "NP", "Nepal" },
                    { new Guid("f83cc573-c48f-4569-a2c4-e2ca4f562a95"), "AD", "Andorra" },
                    { new Guid("f9cb2b7f-9d18-4e99-ac34-fa291edebaad"), "JM", "Jamaica" },
                    { new Guid("fbbf5b6e-ba97-4409-886d-454f5348d2b4"), "CR", "Costa Rica" },
                    { new Guid("fce955c0-401d-49a7-838e-70549141ae3f"), "SC", "Seychelles" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("67fdf752-c3d9-4bc4-98c0-b0a960ad5c64"), "Male" },
                    { new Guid("dc5093d6-7574-48ae-9da5-1f18652358ed"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("143b8ab5-5dc9-43f9-882b-dca63734d151"), "Diagnostic Interventions" },
                    { new Guid("256b93d9-7d5a-4a44-9a2d-a3b4a4f03612"), "Exotic and Specialized Interventions" },
                    { new Guid("3362a24f-bf98-4e78-97d9-23d03b6e4aac"), "Obstetric and Reproductive Interventions" },
                    { new Guid("360831f6-87fd-4bc1-946f-24e165c5f661"), "Therapeutic Interventions" },
                    { new Guid("459edb42-5f90-4ac0-85c3-6a874f813045"), "Emergency" },
                    { new Guid("624d487e-5ad7-499f-acde-c8d25be9a80f"), "Postoperative Care" },
                    { new Guid("7137f2f3-b39f-4183-bf67-5f0ccc655d9e"), "Dental Interventions" },
                    { new Guid("8125a7d4-eed0-4382-a668-923256757c3d"), "Surgical Interventions" },
                    { new Guid("df66d65e-e74a-4f73-819a-87aefac3e28e"), "Preventive Interventions" },
                    { new Guid("f317f5b2-3829-49f3-b977-b27bb027a064"), "Oncological Interventions" }
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
                keyValue: new Guid("012f18f5-fa7a-4c80-a5d7-2307e0ebf825"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0361fa73-1ee8-4ece-872e-0fae9e661385"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04caf9ea-5e25-407e-8240-5c1a3c704470"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06fdc711-5909-462d-93bf-2642e2978d1b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07278c05-8c63-4d46-9605-d83853c9b61c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08347e49-8cc0-4b03-bf7f-f11b577d3636"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("084fcdf8-6013-4dd7-9549-59d7aab656ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08f0d065-6fb7-4879-8168-3a401ac26a8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0bcc8808-29cb-4217-8981-ca372c482896"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0bcca64b-7a54-498a-ae30-47a104c2ac81"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0da0e458-d73c-41d4-8def-bcaee17195ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1009f8cf-439a-4ec6-b088-ec1fdc133776"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1135e88b-a56e-4174-a8cc-f9840c21af5d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1263c9b4-d007-4e2c-8c10-54dcd5dda77b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("129800ba-af72-4801-8b72-947be0a0093e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("130243c4-86f5-4d29-ab84-bb852997b009"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1725864a-0b4f-4302-a3f3-fcf722c6c03d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17b1290f-697e-4a8b-a15f-e85005203a74"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18875708-73bf-4920-8f08-630f9160a5f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18ac3bad-543a-40a8-8ad4-add12db679ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1aefbe0b-8bb1-457a-8874-397978829e88"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1bba82b2-ded8-4376-977d-ea995cce015b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d389e76-3fba-40bc-8d62-7e127e0332af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1f02aa2c-7473-4252-8bb9-689a2dda842f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2147497a-4099-4e38-8d71-129b53a84832"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2171bdb3-6878-43ff-b21d-d62110c78a94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21d04ccf-1520-41bd-b388-7a039fde31de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("232ccf82-7e7b-4308-a7b1-9fb4c0a4d51d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24620e81-f64f-4841-b861-5322aea9d58d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("251103fb-84ad-41f5-949f-a8cf5cc6bed3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28f6e424-988b-4f5c-a04c-fef3ffaafb7a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("292aadf6-0c9a-4e2e-8fec-77ff3a237de1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29f23f10-d2e2-4ddc-a60c-673a897857f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a2a404b-cbba-4a4a-a538-df4aaddd12ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2acb0c00-ba8a-4a2d-ba84-cff14fb31e4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2bad3be8-c51f-43bb-bd5f-070315d37d1c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2bd7a3a4-494c-4edf-b340-35009d160f5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ddc577c-4792-48b2-a1fb-ad5ebd308e00"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ee0c302-2ed8-434a-898a-1f991833a6f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f11efe6-3456-4711-b6f5-4d135c1fd1b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f6f70f4-2650-4f5f-b0af-6a308ba56ddf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30978597-0e23-4d6c-8696-b0f5c94ffa6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3161d231-f8cc-41a0-9af4-dcf381fd073d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("376fd354-e025-44e9-a08c-cf41d1be7783"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("382cd2da-97ab-4083-91be-e3ade5aa9732"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39bf2f3e-2ba8-4cd1-afd2-ae4cf05e37a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39ea63b4-d0da-4924-80ca-ac7ea2da6555"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e03094b-9b87-4666-a596-94054d36e79e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e59f609-58a0-42fa-9da3-031aaef72e29"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e8394a1-fc82-44e2-bee6-752e494abf90"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("42ea6f9a-33ab-455a-8d56-4e4b15802e8f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43352cb7-0c27-483e-8ff7-5bb764d3e2a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43ac9bb3-fc92-4e83-990a-b60ae3d68850"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43e3008c-86db-4ddc-b871-aebc72b0c8f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4495a504-7493-450c-92b9-e7128f41eb14"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45213ea5-f7bf-483d-89d9-b9050f48c6b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b682353-afc0-4e55-a573-566bc15afb0e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b81990a-b47f-47cd-a263-edf8071a1d1d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5119b22a-3452-41a7-8656-0cdcc3f5b2ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("543e95c6-6fd7-48b7-a030-fb6224a1092c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5461c0af-eed8-4af9-aaaa-25d88d7cf2b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55c52885-7eac-4810-b6c4-86bcce6311d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55fa9d23-3769-4864-95d0-eac5d0c42801"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56ad5ed5-32dd-41ff-b649-86ed27069483"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5795c7e0-59e0-4856-bb61-edd74621b42d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("57b2f108-6f83-4188-9e49-ef884a7494ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58ce60f3-90f9-4143-a89f-f0420a18f08d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a6e2df7-11ed-4067-9a2e-ccee25104c40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d971e39-c783-4d8b-a822-75cad58ca1da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ee6ca4a-0034-4e65-980e-d5244c73bc4b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f165159-9e54-4d64-9e35-485a6825634e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("610f12e9-2a38-443b-98f8-5ddcd8a6bbce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("613d0a1c-f2c4-46c0-9c14-240a13d57dd5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("62545fc8-32db-489f-a3b7-b4fdb1c2a9c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("641b6885-604b-48c3-9fc5-33a62e688156"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6448f215-c245-4b44-8912-6a8dcef2f6c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64837e21-141c-469c-9f8a-38a6716bd510"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64d5c941-a966-4e70-82f7-bbd433b7fe66"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("693a0670-0332-4d34-97b7-0de8db3e6857"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a318801-b6b0-4568-8a5c-384a5058fec6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a7ccd11-c0c8-406c-bbc7-93bc19d8fc86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6c69f99d-993d-473f-b65b-d2bbd8f22cc7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ca6bb67-2e05-41ac-8d9c-6dbcca6eb581"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e9e0a5e-5bdd-4449-868f-2f595fb9214e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f1520eb-06e8-4136-a82e-ab46ee4deb24"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7312e068-43e4-4c8c-beab-b717c7c77e38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7438cdf4-c21c-4ea9-b71e-d55734528aac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("761da197-22d1-4375-96d0-01edce177ed2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77d4ae32-f022-43d7-93ce-701131c0d127"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7dfd51b4-b3ab-455b-877a-7478482e4641"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e088bfc-4325-4e5f-a0ae-61241c6e44e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7efb8480-2080-4172-b5fe-74d5b09ea8cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80af83f8-0069-4509-93fb-54827e1db98f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81e14200-5052-474e-a4da-e0339b956bb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8277d960-fdc1-4e7b-9608-2f1bfe8d1dab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83c00915-549c-4d3e-acf3-6ed5d9abea92"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84b99a10-4e73-4595-95d4-02eb7087ff26"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("895053f4-8367-4b29-8ebf-8475be692529"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89f94de4-c82e-406b-91fb-9ea6f743ddbf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a079488-2f26-40a4-8fd1-82d4f7d06c64"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a9f4b6a-b76c-4041-9973-017d9c54aabb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b107ea6-818b-4e48-b118-0c7986b93655"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c0d9714-da45-42c2-a618-8423f96ac1cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8dad67b5-1d15-4b5a-9fe2-4b0b13307bf8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f1e12de-1e2d-4931-a49d-a067fbb70091"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91301e6f-713f-431b-aa91-dd671b92113f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91dc4b8c-8dcd-45b2-a640-9004ed94082e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("921f06e7-2c88-49cf-b47d-e37230d2197b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("933645f8-9e7c-495c-8041-ba5e33d54faa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9544eacd-53d8-4356-ae85-d6e226a1287b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("964f6b7b-2aa8-476c-bf69-18cb0a3a9710"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96ad5162-3f8d-45fd-9095-104bf37b9f98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98c308f4-bff6-402e-88a5-64ac1ff12801"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99078d34-02ad-4e0c-93ce-2a590b5de2dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("997018f5-dbca-44fc-b81b-e589685ff52d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a950678-40ac-4c5a-96df-f6c927e6f667"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a00e41ef-aa01-4ebb-a599-7a1b4f04b3fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4687232-b840-486b-bfe8-9c5cd79b155a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a532f409-7f05-4bfe-86b0-c4855463d3be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a62feb8e-ccc8-4e6e-aa20-68bf13399dfb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a67146b4-915e-4f31-98ca-96bad6e5c0da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a70c1352-a504-4a7c-a4da-357eea026c07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a8949c27-63ca-451f-a14f-1cdd349bd020"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa5dd3ab-1338-47ad-ab80-f8a761e46c9a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aadbfb78-1397-4a94-9239-a14ba4a5e2b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae2cdaec-984b-40b0-a443-acd33b875d0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0b87074-9f5f-4379-98c0-5c1a21ee4c58"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1d0e10c-ce63-469d-a254-739e8823d031"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b386a4d1-129b-4358-8dd8-bdd943696472"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b42e654e-422c-497c-a58e-365009a2b194"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5c54e4d-5fde-43a8-a662-9a2407683c89"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b945b9eb-a37c-4707-a50f-44bfe0081855"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb382f49-bde8-42de-b454-f3afd11116a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb44eb42-9f44-49fd-b316-ae88b9be1757"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc485582-cd0e-46f1-93f5-323ad149d6c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd845f84-a5e0-442b-9efa-2cc4e4960568"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bef4df71-20ac-496e-b1c4-5c4da9de9898"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bfe5ba56-142e-4420-93ec-46758a30c0ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c011ed7b-29db-40f6-84ae-991ad58e23df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c20c037a-f3bf-4cc2-b4f2-3c3a53db8b1d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2b39bb7-be43-40d4-b726-ed5d3a62baec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2c61b56-2a9d-423a-b8d8-7b5885a4f847"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c39c153b-2356-47ad-a264-ef6fcb03c747"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c54c165a-b21a-4073-a80f-d514ada4ae25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5f86164-5ff8-4c4f-853e-7a5cb91840c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c60a70fa-d789-4be5-a5c9-42652b898697"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c667b7d2-b355-4025-abd3-d336fc72966c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9ec16e4-f2db-4e49-bd9d-81a2c0c39674"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc1aadfb-738f-4596-9289-53830ed3b3b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc95f404-c5e6-45fe-8821-4fe3db86d022"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd5de2f4-e973-4194-a9a1-e622f30097a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d35515f1-8568-468c-8fa7-b21825e6b0d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d4fc87cc-108c-4e8b-abb1-79257ffe212e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6e6ea6f-ce53-4ad8-98de-786b0737771a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d719ad5f-b224-474d-8c18-7693999c693b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7a547e0-c5ab-4008-97fc-9d00d58a5dea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d8c8e8f3-3d02-4835-982f-f5495ed70edb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d99595f7-9005-4ca5-841c-a30f99b70a0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d995d5e8-37d9-4520-8c91-d01f2a0d9508"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd175d33-11e8-4496-92a6-9efebdd204ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddc58846-d5be-4469-8f0b-89a3820dc87b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dddfe4a6-1bb8-4c0b-b148-fd6e923763c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df077799-8782-4693-9464-3ca01ac5fe45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dfa4e2ed-1c3a-4cf2-b5f1-c2ce32a25f1a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e03c9961-f9ea-4107-83b5-83934c680c9d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e16790cd-c4ce-4122-843c-1e66cb884457"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e1bb853d-9588-4512-8753-d8db15c985e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e29717c5-8856-4812-ac14-221194ecacf1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e36588fc-9950-4f17-a4ba-01ce4c7473ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e395d9fc-7a25-41af-bb2f-5bdf16bcca3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e415c4af-c892-4d75-a719-3639801b729d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e434fe64-6a27-4f2d-810e-5d3dce8c13f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e53f1560-de15-44c1-b1bc-e903e125de2b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e5667af0-c5fe-49ef-9864-8b07e08636c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8a33fc5-d0ca-47d0-bcf1-c737819dfe31"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb30bb18-cb3f-40b0-a707-ccf32dbd3e4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec0f5148-4a05-4eb9-9e3c-de2182b684ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec875260-95f3-4565-bc5a-65e40e9dc719"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee5582df-3b23-4659-9c65-c9062506358b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee74b93c-56cd-4cc7-8d03-04599077e04b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef482d63-b2c7-4e31-a8b1-54a3eab009b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efbab887-ba1d-42da-b84b-f8784e45b1df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2617d12-e265-48c2-a02d-1e755a687a73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f309a90c-77a0-4ba9-b395-87385f78c472"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3426e5b-73ba-403d-b5ee-99f361febf20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3d7f662-f38f-4202-9183-20903dd3acb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f55ff955-205a-42fc-81eb-27b0c66c5b4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5b7438c-07ef-466a-b1be-7cdcfac13cb4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f76f3fc5-506a-4ca7-b69b-e272c2bd3515"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f7b90793-01fb-47db-bd6a-7420090eb083"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f83cc573-c48f-4569-a2c4-e2ca4f562a95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9cb2b7f-9d18-4e99-ac34-fa291edebaad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fbbf5b6e-ba97-4409-886d-454f5348d2b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fce955c0-401d-49a7-838e-70549141ae3f"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("67fdf752-c3d9-4bc4-98c0-b0a960ad5c64"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("dc5093d6-7574-48ae-9da5-1f18652358ed"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("143b8ab5-5dc9-43f9-882b-dca63734d151"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("256b93d9-7d5a-4a44-9a2d-a3b4a4f03612"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3362a24f-bf98-4e78-97d9-23d03b6e4aac"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("360831f6-87fd-4bc1-946f-24e165c5f661"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("459edb42-5f90-4ac0-85c3-6a874f813045"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("624d487e-5ad7-499f-acde-c8d25be9a80f"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("7137f2f3-b39f-4183-bf67-5f0ccc655d9e"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("8125a7d4-eed0-4382-a668-923256757c3d"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("df66d65e-e74a-4f73-819a-87aefac3e28e"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f317f5b2-3829-49f3-b977-b27bb027a064"));

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
                    { new Guid("00ae1727-850c-41d2-b769-7d8e3e72ca56"), "AD", "Andorra" },
                    { new Guid("01213826-3492-4d9c-8884-1cb2ca95f10e"), "PW", "Palau" },
                    { new Guid("01270f6a-9e35-46b0-9357-f007eba77b65"), "IL", "Israel" },
                    { new Guid("0232b013-2a51-4cbf-bf05-2492001b9854"), "FM", "Micronesia" },
                    { new Guid("02f342a9-bdb3-4c9d-9a9e-f02101e26b98"), "DJ", "Djibouti" },
                    { new Guid("06a3f6f1-f2a2-4959-ae29-e0fb37ed91b2"), "SO", "Somalia" },
                    { new Guid("06c2b087-908b-4a2c-ab7e-f6411bf52960"), "NG", "Nigeria" },
                    { new Guid("0724b0f0-7756-4e25-b4be-f924af699626"), "MY", "Malaysia" },
                    { new Guid("081600f6-7264-4f9f-9d60-0a2ba9b840bb"), "CV", "Cabo Verde" },
                    { new Guid("0a8a7053-4af3-468c-87ff-8a7c8b64be7f"), "ME", "Montenegro" },
                    { new Guid("0dfda2ca-a21a-4b70-8d28-31278954c795"), "LS", "Lesotho" },
                    { new Guid("0eede598-5928-40ac-abec-2f1a2e55b723"), "HR", "Croatia" },
                    { new Guid("0f42e59a-1825-45d0-a1ed-37808cacc825"), "BE", "Belgium" },
                    { new Guid("1000a217-9657-47f1-a688-662c33eb69f8"), "CF", "Central African Republic" },
                    { new Guid("10a68249-e512-49d2-b1e5-cb7949915fe2"), "PA", "Panama" },
                    { new Guid("133b61a8-073b-43ec-a9f9-05f4f0c7e250"), "ID", "Indonesia" },
                    { new Guid("13f63d45-bdc4-4ee5-b046-78e479e41ecf"), "CL", "Chile" },
                    { new Guid("15a0f2c2-6f83-436a-b988-f84ac3c2116e"), "IE", "Ireland" },
                    { new Guid("15b8633a-1f44-4b9d-b5df-d656cc6d1540"), "NR", "Nauru" },
                    { new Guid("15d054ba-36d6-4696-8f0a-69947ad0702c"), "VN", "Vietnam" },
                    { new Guid("15f5a296-2d94-4b40-841b-c2f2021333b4"), "MZ", "Mozambique" },
                    { new Guid("1688b520-6518-4a77-ba9b-baf3deae33c3"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("1738f778-665a-4d55-81c9-fa5f6dbffe77"), "GB", "United Kingdom" },
                    { new Guid("176a10a8-6ae8-4eb0-b8c9-ffa0f093f2ea"), "TM", "Turkmenistan" },
                    { new Guid("19b04742-ecec-4efd-91d1-76940286b8de"), "SK", "Slovakia" },
                    { new Guid("1a719dd0-953b-4f92-93dd-8cb8887db933"), "TV", "Tuvalu" },
                    { new Guid("1df9fcfc-ac4f-482d-92ae-7543d68e5ae9"), "CY", "Cyprus" },
                    { new Guid("1e07b9be-2ba2-4ec1-820f-b18b78b0e14e"), "BY", "Belarus" },
                    { new Guid("1e9f55c0-a09d-4778-9d3d-eb631a9b0fcb"), "DZ", "Algeria" },
                    { new Guid("2088b6b3-6b70-4ef4-972d-fa543de8c245"), "BD", "Bangladesh" },
                    { new Guid("216f3db7-4dc0-42ab-9fe7-4e64b1db90bb"), "VE", "Venezuela" },
                    { new Guid("246f9fee-f185-4040-af2a-f12451f78b41"), "MM", "Myanmar" },
                    { new Guid("24d0d33e-64f1-4ddd-af28-700ad7d5c7a6"), "UZ", "Uzbekistan" },
                    { new Guid("2899ab06-fea2-48fd-a2cc-9cbafe2af2d9"), "EG", "Egypt" },
                    { new Guid("29ad4fd4-7edd-47b5-a035-a5d6e1064ef9"), "PL", "Poland" },
                    { new Guid("2a1cd64c-f8a3-4f7d-9d1b-690b2c9639a6"), "VA", "Holy See" },
                    { new Guid("2a966c2d-b0e7-479b-b5c3-672f12d06c8c"), "SR", "Suriname" },
                    { new Guid("2a9bd9cb-50c7-40d9-8673-e9f113414ebc"), "FJ", "Fiji" },
                    { new Guid("2b073599-0c4c-4046-82df-954dcd0b3852"), "SL", "Sierra Leone" },
                    { new Guid("2c94757c-d396-4df1-91f4-6aac338d365e"), "KH", "Cambodia" },
                    { new Guid("2d2d9455-6cf2-42ca-8b2b-7507201941fd"), "SE", "Sweden" },
                    { new Guid("2d34e4d0-31dc-4721-91c7-891d98da79fa"), "KI", "Kiribati" },
                    { new Guid("2d8905d1-8146-49cd-913c-3841a2a2d797"), "SG", "Singapore" },
                    { new Guid("2e36fd62-0768-47da-94c4-7e600ff8ba94"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("31af1d74-2417-4385-9097-c87c72faf030"), "LT", "Lithuania" },
                    { new Guid("32056b98-8eeb-465b-8993-104930f17b87"), "NA", "Namibia" },
                    { new Guid("32e7d735-77f9-4d98-92fc-775a38220766"), "GY", "Guyana" },
                    { new Guid("349e039e-45a3-4039-8ae1-9b3281a67f2c"), "NZ", "New Zealand" },
                    { new Guid("3512ed52-93f1-43c8-84ae-327e81099909"), "LR", "Liberia" },
                    { new Guid("390fa90a-0260-425a-b11f-e2e0c1dab877"), "NI", "Nicaragua" },
                    { new Guid("3b43132b-bd73-41e0-901e-038d3d8a35a9"), "PE", "Peru" },
                    { new Guid("3dd75624-81d3-4169-bde8-f159322dac2b"), "SD", "Sudan" },
                    { new Guid("3fbb62b1-74c3-4af9-b204-2245874b670c"), "NL", "Netherlands" },
                    { new Guid("3fc93f10-1b37-4371-bd2f-1f9cb73bd2f9"), "US", "United States of America" },
                    { new Guid("3fce75ee-1159-4e41-9da6-1b2758f277e2"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("4204f3b3-3d66-4545-ba1e-27f821b0a157"), "ZW", "Zimbabwe" },
                    { new Guid("43612479-c065-4486-9981-e5a704bb9ee1"), "BZ", "Belize" },
                    { new Guid("4663b867-5207-4364-80bb-bedd2f4ae164"), "SI", "Slovenia" },
                    { new Guid("46b4f9fc-cb58-44fb-91c8-4b37a0bafbb6"), "IN", "India" },
                    { new Guid("483f3ff0-d7a1-488c-ac4f-0202ea8f27e6"), "UA", "Ukraine" },
                    { new Guid("49ca8cc4-72fd-422e-bfe3-96f8048d7cd7"), "MR", "Mauritania" },
                    { new Guid("4a5c2b33-ca6e-4549-8ba7-1e834b126b6c"), "SB", "Solomon Islands" },
                    { new Guid("4b428565-4f5f-4dcd-b86f-532a18b1cfcb"), "GT", "Guatemala" },
                    { new Guid("4bd592ce-714e-469e-9818-6e1ecf5842a2"), "PH", "Philippines" },
                    { new Guid("4c62ca31-2b9c-4b3d-98cc-387f7305924b"), "KE", "Kenya" },
                    { new Guid("4ef9a963-a602-472b-908d-1af57995d935"), "IR", "Iran" },
                    { new Guid("4f90483e-d677-49cf-9a07-509793cb2dff"), "AF", "Afghanistan" },
                    { new Guid("52029a04-b15d-4bea-9072-81d57e49c9dd"), "BB", "Barbados" },
                    { new Guid("5308b0db-258e-4083-a4c6-c8201fbb9ce4"), "SY", "Syria" },
                    { new Guid("531e81b6-f53d-410b-a288-21d4aa61473a"), "DM", "Dominica" },
                    { new Guid("55ebe959-7178-42ff-801d-78757236d0d6"), "ER", "Eritrea" },
                    { new Guid("59e8597c-583d-4db2-921b-418a5bed82ec"), "JM", "Jamaica" },
                    { new Guid("5a10f280-4a82-4912-93f9-7c2912187a4f"), "CH", "Switzerland" },
                    { new Guid("5b3c6212-8558-4040-9753-128a5166700e"), "SS", "South Sudan" },
                    { new Guid("5b3e2c83-4714-4d4f-9a61-3e639ef115ba"), "IS", "Iceland" },
                    { new Guid("5bfc50ed-b97d-4dc0-ae62-2bdd1814cc2d"), "WS", "Samoa" },
                    { new Guid("5d9402f6-bfc5-4c0a-b5c7-ada56b220998"), "GD", "Grenada" },
                    { new Guid("5de923b0-7cd1-4001-b457-4131cdfaf14c"), "TL", "Timor-Leste" },
                    { new Guid("5e578369-12d9-4e31-92a3-c385d9145f9b"), "BS", "Bahamas" },
                    { new Guid("5f68c8b2-3892-4e99-9da4-53c8512e1523"), "FR", "France" },
                    { new Guid("61a29a59-cfd0-4b1c-aefc-d6dd46a1ef83"), "TG", "Togo" },
                    { new Guid("62d1231d-69f8-4ed7-a172-6be7d2070be4"), "ZM", "Zambia" },
                    { new Guid("646e81d0-0629-472e-a56e-3bcf89e7b319"), "MX", "Mexico" },
                    { new Guid("652bc048-be37-4f61-a465-84ce667fcc79"), "RO", "Romania" },
                    { new Guid("6782e845-9099-40ae-b6da-955fd06ba2b1"), "TT", "Trinidad and Tobago" },
                    { new Guid("67f23381-1189-4837-af5d-1f8bdecc054e"), "MW", "Malawi" },
                    { new Guid("697b07cd-1944-4e4a-a716-37482281c311"), "MV", "Maldives" },
                    { new Guid("6f02cf5c-e257-4660-afce-836e631b8715"), "RU", "Russia" },
                    { new Guid("71b60ec2-a4f2-4424-9475-909cc19784e8"), "KG", "Kyrgyzstan" },
                    { new Guid("73804e5e-4382-496b-9c78-6a8707f4c658"), "BR", "Brazil" },
                    { new Guid("746251b4-e0a4-4b3f-8435-9ef954a443bf"), "PK", "Pakistan" },
                    { new Guid("755ffabd-6648-45ee-a83d-bc5c95e1642c"), "MT", "Malta" },
                    { new Guid("7a26d9a1-21e1-4d13-b0f2-a09fa1d13e92"), "AT", "Austria" },
                    { new Guid("7b199cd9-8692-4953-88f0-d8627c736bb6"), "BW", "Botswana" },
                    { new Guid("7d6e83e3-b39a-45d8-9381-40109d6a7818"), "BI", "Burundi" },
                    { new Guid("7dd8213f-b2ca-4b59-8b76-3ad9381ca097"), "LY", "Libya" },
                    { new Guid("7fd1156f-1a6c-4abb-ade0-a4ecf2cea030"), "EE", "Estonia" },
                    { new Guid("801df666-e0e9-46d3-a2b1-b16567ef0a58"), "MH", "Marshall Islands" },
                    { new Guid("82b8348b-d306-48a4-8165-9ff639b59d70"), "JP", "Japan" },
                    { new Guid("8343c285-eabb-444d-9484-99c4b9b14c27"), "AO", "Angola" },
                    { new Guid("86976436-0ebd-4c23-917a-8147b86f791a"), "BH", "Bahrain" },
                    { new Guid("87987a8d-3b5a-49bf-bf6d-acc3652b35e1"), "LU", "Luxembourg" },
                    { new Guid("87dd8b52-aafd-40f3-856c-aa5ef37c35a8"), "HT", "Haiti" },
                    { new Guid("8a54d6e7-843a-4f54-ad7f-6118e73e32c0"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("8d499757-f069-4ba5-b593-3a2c8ba6e9da"), "LB", "Lebanon" },
                    { new Guid("8e33963a-a059-47ca-b7ea-1af5a9def1a2"), "NP", "Nepal" },
                    { new Guid("8ec5b5b6-429f-4684-b88c-92be53b2d336"), "CU", "Cuba" },
                    { new Guid("919b347e-ec6c-4864-afa7-d8f42f320067"), "GR", "Greece" },
                    { new Guid("9235eb45-db1c-4fe8-bfec-a058a092d4ff"), "LI", "Liechtenstein" },
                    { new Guid("9302d4fb-188e-46d1-bb8a-56236146a91a"), "GQ", "Equatorial Guinea" },
                    { new Guid("93aad2fb-5f4b-4fbe-bae6-1d03c99ec904"), "TD", "Chad" },
                    { new Guid("9454c20d-c29f-4a21-88ad-6f44bb2b4e57"), "OM", "Oman" },
                    { new Guid("94f6689b-b350-4bcf-a654-30c02c7d9948"), "ML", "Mali" },
                    { new Guid("9782bfd9-0e2d-4881-b431-4aaf2916bffb"), "SC", "Seychelles" },
                    { new Guid("982acc58-27ed-4c3b-a15f-da04b66c79a4"), "AR", "Argentina" },
                    { new Guid("99252cf0-84ad-4c70-a090-781e013265c0"), "AZ", "Azerbaijan" },
                    { new Guid("99e93447-db8d-4d64-98b4-7fdc966206e2"), "GE", "Georgia" },
                    { new Guid("9b802fb9-517e-4f00-a110-7ddd90df206c"), "UG", "Uganda" },
                    { new Guid("9d97e585-4ade-4aa3-9834-b115d25bb17a"), "DO", "Dominican Republic" },
                    { new Guid("9dad5197-af79-4270-8906-8508c1b1ee7b"), "HN", "Honduras" },
                    { new Guid("a079ccba-91f0-454f-a015-2f82d73b8cfb"), "BN", "Brunei" },
                    { new Guid("a0afce6f-4268-401b-98be-210eec03cf29"), "AM", "Armenia" },
                    { new Guid("a0f10850-76c8-4c71-b324-036469121205"), "GN", "Guinea" },
                    { new Guid("a0fd2c8e-a4a5-43df-a024-6f9dbee58a5b"), "LV", "Latvia" },
                    { new Guid("a3043be0-7e65-4460-ba4a-4585bbb987da"), "QA", "Qatar" },
                    { new Guid("a31c3939-3170-4142-b23d-170d0a878907"), "LK", "Sri Lanka" },
                    { new Guid("a385902c-6054-4e70-b332-ecaca7058dc0"), "CO", "Colombia" },
                    { new Guid("a42f4ba5-17ee-4e43-ad87-b1d6e204500f"), "MA", "Morocco" },
                    { new Guid("a4631646-6005-4241-931c-ff42d248b32d"), "ES", "Spain" },
                    { new Guid("a683a594-7da0-4d48-a0d5-4f97c974656e"), "SZ", "Eswatini" },
                    { new Guid("a77513d2-dfc2-4cf3-b5bd-264c5a2682c1"), "VU", "Vanuatu" },
                    { new Guid("a7e4db88-846c-43cb-adf6-99a4dbba6f63"), "TZ", "Tanzania" },
                    { new Guid("a8f71682-f9e3-4b04-bd0e-a21df6c947f0"), "LC", "Saint Lucia" },
                    { new Guid("abc17fdb-dc64-47db-bc98-7d69395d022b"), "NO", "Norway" },
                    { new Guid("af396e7a-7947-49ea-9bfc-7f39be908d3f"), "CN", "China" },
                    { new Guid("afffa3cc-e023-4ee5-9278-edb00a3116ef"), "PG", "Papua New Guinea" },
                    { new Guid("b39eb065-b7e8-4826-af99-8308e9b2b9c8"), "GA", "Gabon" },
                    { new Guid("b7d5840e-d3c5-4cb1-8adf-d204f3f67aec"), "HU", "Hungary" },
                    { new Guid("b80e011a-ea58-4455-bc42-69eb625817ee"), "CR", "Costa Rica" },
                    { new Guid("ba7a203d-1134-423e-a3b0-cbe0596e14f3"), "CM", "Cameroon" },
                    { new Guid("bb340f96-f6b1-4871-8537-bdb6f7cd8816"), "EC", "Ecuador" },
                    { new Guid("bcc748e5-2d12-4563-9591-232189ecffbe"), "ST", "Sao Tome and Principe" },
                    { new Guid("be8e5474-8db0-4250-94cd-34aa238a61a9"), "SN", "Senegal" },
                    { new Guid("bed6805d-9b99-4efc-b62e-3236a2cd0f85"), "TR", "Turkey" },
                    { new Guid("c20eae83-25de-4c43-9e44-0dda5f946b7f"), "CA", "Canada" },
                    { new Guid("c36f770c-6325-4f60-a696-f12b0feb1379"), "MC", "Monaco" },
                    { new Guid("c38c6a7d-20a5-4a23-9049-ba81738f567b"), "YE", "Yemen" },
                    { new Guid("c6a8fc07-e574-4edd-9749-745588ab92c4"), "JO", "Jordan" },
                    { new Guid("c73988dd-24d7-43ea-a276-7884f91aa0fd"), "BT", "Bhutan" },
                    { new Guid("c79063de-4187-40bc-9883-d71cd3c81cde"), "RW", "Rwanda" },
                    { new Guid("c7ada25a-6c00-4522-98a7-63584b12cbb6"), "KP", "North Korea" },
                    { new Guid("c7ffe854-8c0f-4471-bfac-9688f7d39ff5"), "BO", "Bolivia" },
                    { new Guid("c83a4330-1fba-4cb2-b365-89e66c5df09b"), "IT", "Italy" },
                    { new Guid("c866ef3e-0648-43dd-8582-a5c65d755651"), "FI", "Finland" },
                    { new Guid("cae57cdf-2f74-42ff-967b-93d5ddbb0539"), "ET", "Ethiopia" },
                    { new Guid("cb4eb95b-265f-435e-8e57-3408e0e20393"), "RS", "Serbia" },
                    { new Guid("cdf43810-eee6-4a65-bef3-2fc15bcf837d"), "AG", "Antigua and Barbuda" },
                    { new Guid("cf194355-73d2-4254-a2d6-3adc8308a540"), "ZA", "South Africa" },
                    { new Guid("cf55ed70-74eb-4e69-89f4-2620457b1487"), "TN", "Tunisia" },
                    { new Guid("d1688726-3811-4c40-b1b3-ce689ef255c8"), "VA", "Vatican City" },
                    { new Guid("d1f05ef1-dfec-4d76-aa93-1caa85989be3"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("d686fc5e-ea86-4267-8528-4bcf692decf0"), "GW", "Guinea-Bissau" },
                    { new Guid("d6d46b32-2d21-4464-9b48-f5dbdc6b8e53"), "BF", "Burkina Faso" },
                    { new Guid("d9d428cd-0c0d-4cd0-ae9a-91c98c489c2d"), "DE", "Germany" },
                    { new Guid("dbf26abc-edf7-4da7-9bde-c41bb91d1c2f"), "SA", "Saudi Arabia" },
                    { new Guid("dc512f55-cfae-4000-b9c4-92ddfd65e834"), "TO", "Tonga" },
                    { new Guid("dc75996c-cdd8-4801-b54c-1df8a6fcf2f6"), "KR", "South Korea" },
                    { new Guid("df6648e4-f202-4afe-a6b9-b02ff0f04233"), "LA", "Laos" },
                    { new Guid("e191a707-80ce-43ae-9d9e-2c84b6608343"), "AU", "Australia" },
                    { new Guid("e45f96b0-2cc4-4a40-a7ee-21520c8cf4ca"), "AE", "United Arab Emirates" },
                    { new Guid("e8d4d99a-1f51-4e8a-9033-36bc2c7bb359"), "MK", "North Macedonia" },
                    { new Guid("e8fc5339-3e84-4bb9-813c-53926cd9a3e5"), "PT", "Portugal" },
                    { new Guid("ead9eacb-6323-4371-89b7-1880fac077fc"), "TH", "Thailand" },
                    { new Guid("eb20bc19-bb67-4192-b3aa-7cf302026f84"), "MN", "Mongolia" },
                    { new Guid("eb821b3b-cae3-47f3-b687-714dc7e318c4"), "UY", "Uruguay" },
                    { new Guid("eca07750-1eef-4a14-8554-87e6907b814c"), "MU", "Mauritius" },
                    { new Guid("ed7bc6e9-a71b-4e9f-ac5a-a30a782e38bc"), "MD", "Moldova" },
                    { new Guid("efcdf9cb-e53b-4851-8e89-50436c4380fc"), "GH", "Ghana" },
                    { new Guid("f00aa88d-8efa-4854-aff7-289518ca81cd"), "MG", "Madagascar" },
                    { new Guid("f14baaf9-863a-46bd-bca1-2ab7620ff388"), "GM", "Gambia" },
                    { new Guid("f241980e-61ba-4c60-a007-c069797d005a"), "KW", "Kuwait" },
                    { new Guid("f248c5e2-a664-46c4-ade3-d2dc4ca63544"), "PY", "Paraguay" },
                    { new Guid("f33633bb-0024-4bfa-8bd8-df640a3018d3"), "BG", "Bulgaria" },
                    { new Guid("f372b00b-31c5-4285-b313-eb17f14d6cd8"), "SM", "San Marino" },
                    { new Guid("f39c7ca6-d3cd-44d6-96e7-ee75dc687460"), "IQ", "Iraq" },
                    { new Guid("f3ab1f4d-0ed1-4120-82d8-dfe58feec6de"), "SV", "El Salvador" },
                    { new Guid("f4b49723-c9b4-4f04-83c6-38927fe9986d"), "DK", "Denmark" },
                    { new Guid("f5c22419-05ba-43ce-a47e-01991d9f457f"), "KZ", "Kazakhstan" },
                    { new Guid("f6d08ff2-fd8f-48b9-9ca2-fee4243d79f0"), "NE", "Niger" },
                    { new Guid("fb1df71d-0ae9-4f3c-97c2-319e9907d538"), "PS", "Palestine" },
                    { new Guid("fdd009a0-e7d0-4bc1-859e-e714b41d39e5"), "TJ", "Tajikistan" },
                    { new Guid("fe0dc907-7793-4d2f-88b0-b28c0cc4f131"), "BJ", "Benin" },
                    { new Guid("feab06fa-00a6-4529-8a97-853e7b7367dd"), "AL", "Albania" },
                    { new Guid("ff8ca592-a540-491f-ba53-ae7de1619b2e"), "KM", "Comoros" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9a1c41f9-b241-49a4-9735-26c882377da7"), "Male" },
                    { new Guid("9eef9bf4-0a62-46b8-9088-456984c3fdb8"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("043db6c4-740c-4be2-b187-d8b40d388e57"), "Dental Interventions" },
                    { new Guid("24f9fe3c-dfeb-4774-9435-1187896d69dc"), "Obstetric and Reproductive Interventions" },
                    { new Guid("3009cbe3-05ff-467d-bcaa-fa68f6283ec8"), "Diagnostic Interventions" },
                    { new Guid("3e147d6b-cc63-457b-a72d-7b25b33cbf9f"), "Oncological Interventions" },
                    { new Guid("50065faf-c698-438d-9c95-d02ce0f66f9c"), "Surgical Interventions" },
                    { new Guid("a4e9d842-9653-4e62-8c52-2807f4108ab9"), "Postoperative Care" },
                    { new Guid("c2cb2932-3cec-48ca-84d5-4afbeb5eddd9"), "Exotic and Specialized Interventions" },
                    { new Guid("c5b4f8db-7c3d-4209-85ca-20bf45228489"), "Emergency" },
                    { new Guid("cda9429d-4488-490b-8329-db701034e670"), "Therapeutic Interventions" },
                    { new Guid("d960e86d-1e91-4f72-b02a-2a3f213e7675"), "Preventive Interventions" }
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
