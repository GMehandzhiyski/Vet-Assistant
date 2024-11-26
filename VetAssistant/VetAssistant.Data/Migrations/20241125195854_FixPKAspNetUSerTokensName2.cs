using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixPKAspNetUSerTokensName2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserBookings_AspNetUsers_UserDetailsId",
                table: "ApplicationUserBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserBookings_Bookings_BookingId",
                table: "ApplicationUserBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserPets",
                table: "ApplicationUserPets");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserPets_ApplicationUserId",
                table: "ApplicationUserPets");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00a99495-e8bc-4172-b911-ba42617bb983"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0381594e-a3e6-45aa-9914-7e99c9377bda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0404a25e-e0a5-4359-9ae5-a6fb8b6543a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("041ef411-f6c9-4bf4-a7e8-37092ba4f196"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("048eacd6-0060-43c0-94e6-0f43e083a275"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08387237-f277-416e-a65f-e33ed32ca559"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("083baef5-02e3-4e2d-9cdf-81145bb5dd93"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08a393d5-88e9-4c86-b719-b299d903d527"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("098c65c6-ff05-401c-a118-4ab8f660532d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a81506a-8151-4a6f-94bd-f9278874c359"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d1d257e-bbfd-48f8-a0ae-1da228da4926"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e4096fd-6d6c-4b7e-a2c5-2258b1b71b43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0ea0afdd-4923-472a-91ec-57c088b42820"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f2a2920-e8b9-45de-8d2c-0eda7fc4250f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11136dac-5192-44fe-8e0e-5a23e1e675bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11bb9590-1fd3-4e6a-8207-6454e8699cee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13386d82-db16-45fd-a56b-18a507aec2eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("14cab769-cd51-4633-a33e-6da6f91424c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15a55290-afcd-400d-9034-39318ce6b585"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15cc8e35-4665-461d-9116-0921b0684a0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17a337f1-cf87-415e-839e-7c5c1fd9f570"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17e1d03c-2fc5-4b05-a160-d01de7689b01"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1bd3f517-28dc-45ea-8b13-44e10ca6350a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1be1cd04-4012-4002-9085-d9e376217b92"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d976ed9-56d0-4582-a014-995e31ef9a30"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ed03bd4-8aa1-44e7-81e0-a6263d6c4887"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23417357-ae16-4d64-9dde-796744ac9b57"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23871065-e693-470b-9c3d-6863aee4a563"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23aeae8c-bb18-47cb-840a-e11f28e996aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("267cbfa7-e2fb-4ae2-b4e7-f4aa50e9474a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2716b7c6-7078-4ab4-bd91-59f4c635957e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("271e8de4-b62f-48b6-835d-7de4bf92473f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28f66103-5eb8-40be-9358-25ec3df243bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29d92fca-28c9-4388-9472-0b158e665151"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2cc4f4dc-589d-41bc-90c5-e2c174980638"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d5dc601-6fc6-4fd8-bccc-6d0f01139ca4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2dbcad05-2e8c-4703-8d1a-76493cbd4518"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e4d88bd-2ac7-4027-90a6-aae572aeb0d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3193b259-231e-405f-9574-afead062f051"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34a4617d-ccae-4092-9489-6a07effa3f9a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35e80f33-f305-4c4a-9292-27b3a70a6df3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37b3e1a6-3b01-4c85-ac10-ef7e1e4bcf50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("38b05e68-b23c-4020-844d-3f63e892a818"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("395c73a3-cb5c-406c-aee7-604625983115"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39a3ff36-1cbf-4596-9812-9fc9fb652d14"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39fcd227-0c46-43c7-9225-6a6e3b1e29ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3afcf2db-319d-46dc-b51b-5d2e8fa5ded9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3bb346a8-4501-4dee-90dc-aa4884f9628d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d06e441-c199-497f-834c-ad0b50cb8b52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d3cd049-f419-4bc7-83db-8e89f219660f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d9b167e-8ad0-4b83-8303-fc36a73848e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f443bcf-b64c-4038-a6d5-c40c76cc3096"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("412b2f1b-f78c-4424-8d44-5552c0084d53"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4183af72-8dc8-4330-8b67-cba69d581d4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41e209e6-aac0-4052-a4c9-fd984058928b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("429f5304-de3c-42e2-b50c-b183b170a60a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("42bacdda-4a50-4629-be68-c166c4aa88b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("44ebd5d2-c94c-4f22-bc48-ff23a9d5786c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("455c3ba3-1d1f-41a8-94a0-4735e098dac5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45e9cc61-7b79-4066-91d7-d44d2dc33705"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("468ad825-9dbf-4063-b602-305613ded725"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46c302af-df44-49db-8ab5-0af61691b41a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("479a8cf9-d7c2-486e-9c86-f9aec36a4669"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b355a84-5a47-4bbc-871b-7b7b862a4ae9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4fe72aed-f79a-4bff-a5ba-39318b555736"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("508b75b0-635f-492d-89cd-1223c3c93d01"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("519380f3-a782-4bf7-9c61-6cb8abe42bd4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51cfab11-8ce5-44e6-85d1-641dc0e366a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5207caaf-bdde-4d2c-a7db-639ac1d31738"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("54541919-3acc-4474-9198-963d86c684f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("552b0890-09e6-4273-8235-14664b14203c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("555e1477-f618-408c-a3da-2727b23c1354"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55777e45-4294-4787-bf84-761a575ae1b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5589f146-e6bc-4665-8ab0-7b6998f47990"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("561689ff-6df3-4fd1-8ba2-870c56aa6a46"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5663fb40-1b8d-4350-932e-3bb57ac2001e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56ad245c-c9fc-4e9b-a8e2-b9543f04ba8a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5859a620-e7db-487d-9e7b-adce4c7d0c43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5917f331-1899-4716-a196-fe0e1e71e699"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("591e0e86-0a7b-4ce2-b640-05f3303d9e91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5aca1927-d299-4fcb-8701-c7ce9ed3e538"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c6835ea-1abb-4bc8-9784-15e455baf15c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e563a65-a7da-4e3c-81e2-22e81aae6acd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f3a9293-b121-4749-be59-29c7c0074a4f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("607e9b41-9ae4-4b84-b704-5e60fdb2fea2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("625b8239-08f9-4042-a313-9fb53feb7497"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("657b4f9c-21a9-4b47-b399-409da8083ba4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69460549-27e5-4a9a-b34d-a82df835eb5f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6978db6b-be9c-46ab-bc2f-2aacabfec0c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69d8383b-1f5e-424f-96fd-cf6cedef1e3e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b714d2b-087b-4811-8a15-a355cddeb420"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6dccb638-06e8-458a-81b8-e1edb9b5accd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e43d68e-c8d2-4eda-b6a2-086d4a600f3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f09bcce-3ec9-4315-9de8-10a0bec8ed6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70e2884b-de79-4892-a340-fa8fb0cbb859"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("760b2979-0629-4cd2-bb4e-4ead88b0ce11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78766611-994a-4a2a-96b1-76598ecc27ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79d36b85-3231-45fe-b164-0e1f2ea96847"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b8d9b0e-7133-4dcd-929d-433687adf37f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7dde3ec9-3a00-4ff4-8023-bae42e5b3270"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7df0f11a-68c4-4e67-b548-fbb379a16d52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e33a9cb-7a48-4ada-abf8-856ae6e67a13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e5128cd-4402-4249-ae07-7c67f04aec8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7efb312c-651e-4687-9010-1f4e6e4b07da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("806bce63-c727-43bb-8db0-74397d94ec46"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("834a8c67-534b-46e8-b1c1-6697a640644f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83809627-c3ac-43af-9627-1b9289ed43c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86858cfc-2fa3-46d7-a020-6042bef3b1dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("88dce617-5b0b-4d7c-85d1-d0c993413aee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c7f7064-9709-41b9-98de-661f5f42ec9d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ccb37f7-0a9e-48d7-82e6-ea0dd27f3e45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8eaaafd8-37bb-447f-8452-627b010746c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9216ae0a-d5fe-4ffd-bf07-b6ec946c9311"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("926fba51-dc5e-4166-b0be-f6686fc11b89"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99bc4a04-48b4-47d6-aa24-69145540a966"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9acffadc-aebf-49f8-a288-86627d7250dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b380558-5c45-44bc-b8ed-1c8335d59e9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d77a24a-3aa4-45ff-a7a3-6a99348dda1c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d7e1e56-32b7-4b6b-9b0d-9c852b033ae3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ecb67ba-348e-4ce1-a9a0-8788cf14de38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f11e9e9-8ca9-4d85-bace-d326e1a10859"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f53a74d-f0d9-4fb3-92d0-913518073dfe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1677fea-8d0a-41e5-854e-3602aaf5555b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a18f7eac-2cbc-42c5-b83e-8e0b69841d09"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a195f224-e376-49f1-8cb6-a2b3076479e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3afb3e7-3a40-4ac1-ac30-a6d59a2583e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a61cbac3-c83d-4eab-b688-5eaeeeb05038"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a62a2052-7684-4652-b98f-c4ebd45129f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa9593e1-0895-4847-85ba-418ff7cd81b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("abf03933-1dac-4c95-873e-bd945b76e7a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ac76b374-33ab-44ea-a4cc-1387cb7bfbfa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad719300-a00e-47d4-9a97-a966f173e8ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af5040c6-b0c8-4ffc-b6ae-8973081973f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af80b62a-9b51-4310-bea3-24e206ae0435"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af91e09b-7ff3-4c91-9419-e9d455197658"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afb19788-ff05-45be-81b2-67d999726af9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afb321a0-104a-430c-8d04-8229cd1b2c37"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afe4501b-fe64-4972-ae4b-a96bbb27bbdc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b15ff395-a74d-43b9-8c41-2aa80d1a26a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3ca8b9d-577a-400c-bbc0-a15ee9dd10a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bbf928a3-6d5e-49f6-89c9-498a446ed8ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc63f682-bbaa-4198-ac12-c242d40ea61e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bda4c52a-06f3-42ff-9b47-db5618043f86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be9501f4-81df-4912-b548-16ced68aa88a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be9ecc93-29a2-41c2-8c1e-68599c35dc27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("becca01f-40fd-4aab-8e47-3b4f70b47a4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c10245c5-63f6-4b42-9a91-4b3ce7b4bea0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3121554-cb2b-4568-b5d4-b2bf69d9ce38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c316753d-8615-4544-acfc-3828ec1937e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4cb78ef-52f4-4c4e-b718-8c5796baf286"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c561c268-5d8c-4c41-b012-ccf5c77c7480"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c618c91b-0bf3-4c83-a441-c30612a1ff45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6992081-eda1-4fc3-ab70-d194cf5c4e50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7153d47-9e0e-4e1e-9bdf-a24465d69fb1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c82a2276-3feb-4318-91bf-3e94a7786f8d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9e4baf7-79cb-4834-ae1a-7ad8e448a345"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca97e98f-f981-4886-bda6-acf85c4c3d5d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cba128a6-10f5-4a44-9841-089e0db2bfbe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cbaf255b-72ba-4d94-9adb-76fc53b95713"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce0c783d-7fa4-49d7-ab53-632631ebeb2b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d127646e-77c2-4926-bcf6-5a7d2f46a096"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d32bb6c6-d00e-43ed-9f4c-f80dd0811243"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d48f2b07-474c-4395-aa7c-15cc90b83c40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d571258c-3b62-4b28-8ad7-f66fd1c6b04a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d610b74b-fc00-49ef-9504-9710be73f1a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7360e6b-a5cc-41fb-93df-55b479cf14a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd2e0187-ea26-4e21-a8f1-f19911e71e54"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd36f82c-c9de-43b6-9fdc-0c22fbb0685d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df3353ba-815d-486e-b812-a06113b5a6a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4c0218f-8dd7-4f3c-8a46-da86ac67e556"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4f5b3b9-72f6-4377-8fe5-8a291a3f471b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6f2cb10-4987-4f1c-973c-9fd3fe6f9f46"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7cf5ca4-9761-48b9-854d-e651321b1800"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e9164e09-cc31-4cfd-8d44-c1392dfbc615"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ead03201-e794-4181-bf67-2a3d3ddf4b06"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ebf82b0d-dee8-4da6-ae6e-e50987b7083e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed353fd6-6b4c-482d-9a1b-8d586c118aa1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee815472-4cf1-4be4-bc47-6d28dbfb7cc7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee8ff7ef-f0c7-4e8f-a773-6639fc0c12eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eee3efe7-3dee-446a-8990-51cac30b3adc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efa94e59-478b-44f3-a734-8375cdcba2d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0c60ff6-dd4f-4fa1-9b6e-64cffcd14e0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f103ea61-4d30-466a-a2fc-bac628882cc9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44b4157-9b8d-40bc-adde-3c7f675b4653"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f59095d3-e745-4ea8-bac9-41332e1c2518"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5f16004-9e4d-4e7f-a20e-36944b095178"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f610c6ce-2f55-4d26-826a-cdee69d99f73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f7f1a0ba-26a5-4b9a-9d63-0cc503e8ea15"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f961c886-285a-45dc-9075-126b42430a37"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9a62088-522e-41d6-8718-3a25fcc87d5a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9e12bef-4ec5-4b92-9dd3-291231cda9af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb26826b-b639-4a0b-a541-700908884feb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd39fa10-fd48-46b3-a0e6-99a97272e2b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd3a0b2d-39cb-4d1a-b5d0-3fa7d6592c0a"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("480e0cc3-73d0-4b07-bde8-adfd6f804ae6"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("91afed81-19a3-4a16-b500-d50e76c8e0e6"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("0e1cc096-e4c7-4f7f-9dac-0185028d7b94"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("213cbba6-4e73-492f-b023-7e7553eeb348"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("27b09e44-f1c9-4d98-99f1-fef1234a1673"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3752d83c-c6be-4203-93f8-6bfe47050392"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("52f2b1e4-bb34-448f-a598-6ed291c89480"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("614ea707-a330-4ced-bc1b-c07f1009f0cd"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("a23c2fcb-1a30-4ed3-8d80-396723abf50f"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("ce82aaae-cdb0-40a4-b5cd-dd04265d4f06"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("ed58be4a-d108-4fd2-bfc0-6b6446004085"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f03d96b1-3559-4ebc-9c13-2c8ed4fe8b71"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ApplicationUserPets");

            migrationBuilder.RenameColumn(
                name: "UserDetailsId",
                table: "ApplicationUserBookings",
                newName: "ApplicationUserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationUserId",
                table: "ApplicationUserPets",
                type: "uniqueidentifier",
                nullable: false,
                comment: "User Details Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserPets",
                table: "ApplicationUserPets",
                columns: new[] { "ApplicationUserId", "PetId" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("026ffbda-025e-4601-8454-3b5b6a2d9e6c"), "TV", "Tuvalu" },
                    { new Guid("035de50f-3ed2-4b88-b416-ef77c52eb0f7"), "KE", "Kenya" },
                    { new Guid("03d01613-5321-4d3b-b129-cb89cde3144b"), "SM", "San Marino" },
                    { new Guid("040bb7cc-6d5c-40c1-9c17-4fb9dbc5a3ac"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("058409fb-0394-47f1-bee2-95b05e335355"), "GQ", "Equatorial Guinea" },
                    { new Guid("0711bda3-07c1-45cb-92c4-76a3ff7d09d4"), "MA", "Morocco" },
                    { new Guid("0962ded8-8b6a-4bd6-9079-41184510d25b"), "MU", "Mauritius" },
                    { new Guid("09ad2b55-70bc-428c-b32d-8302ae6639de"), "GY", "Guyana" },
                    { new Guid("0c912a34-5caf-4d64-afb2-24a16d16966e"), "PK", "Pakistan" },
                    { new Guid("0c98ecc9-041c-4328-a3ee-62068a535955"), "AD", "Andorra" },
                    { new Guid("0d36f423-9d4a-4293-9128-07b386f3a8e5"), "LB", "Lebanon" },
                    { new Guid("11a526a2-865d-44a4-aafc-faf562b2d1c0"), "DZ", "Algeria" },
                    { new Guid("1377adce-2837-417d-8826-c237be61bc9c"), "BB", "Barbados" },
                    { new Guid("13835e8e-5c70-4b61-829f-efde68d8bff5"), "ET", "Ethiopia" },
                    { new Guid("13d1b2ee-5039-49a1-a8ce-1ee5e739a206"), "SK", "Slovakia" },
                    { new Guid("142abe77-b112-4234-b64b-7ff2549094e9"), "DO", "Dominican Republic" },
                    { new Guid("14f277f7-4169-4ef6-b90f-de1be9a404ac"), "ST", "Sao Tome and Principe" },
                    { new Guid("1581940a-28ce-4810-8522-59e64a9c8517"), "MD", "Moldova" },
                    { new Guid("167883c0-845f-49b9-97fe-f5066c898d45"), "SD", "Sudan" },
                    { new Guid("17b7cea7-a233-4a72-9f3c-82b4ee261cb5"), "IE", "Ireland" },
                    { new Guid("1878f5c9-1b2d-4c94-94b4-6672e05216d4"), "BR", "Brazil" },
                    { new Guid("1c7597fa-7471-49de-a8f5-826c2cf420aa"), "ER", "Eritrea" },
                    { new Guid("1c829676-1eb3-4da5-89c4-19cfe15b851e"), "MK", "North Macedonia" },
                    { new Guid("1ee19f71-d73d-4faf-8f42-a6d32d20262b"), "CY", "Cyprus" },
                    { new Guid("1f85bac7-3731-418f-8737-4d31d0ecc321"), "PS", "Palestine" },
                    { new Guid("1fd4fc72-8304-4a4f-8139-b970ebd6723c"), "VE", "Venezuela" },
                    { new Guid("21e6967a-2028-439f-81d0-f9d010da80ce"), "KW", "Kuwait" },
                    { new Guid("227b1653-0cd9-4ee4-82cf-25ac35cf4726"), "KG", "Kyrgyzstan" },
                    { new Guid("2288c099-21a2-4726-affd-9cf3b397ffa9"), "AZ", "Azerbaijan" },
                    { new Guid("28951333-a5fe-4881-81f8-0f7d256e2ef0"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("28ad20b7-a0f7-4a21-ba94-ffbaf889602e"), "CO", "Colombia" },
                    { new Guid("29830845-74ea-45ff-bc6c-0bda87ca205e"), "ZW", "Zimbabwe" },
                    { new Guid("2b881ad9-e301-42df-a821-b927cb6499fa"), "MT", "Malta" },
                    { new Guid("2badf3de-04a9-4f18-86d1-59c8463b05f4"), "RU", "Russia" },
                    { new Guid("2d1beafd-313a-4715-a479-9f0fc89689a1"), "IL", "Israel" },
                    { new Guid("2ec15ff8-a413-4c8f-a98f-fcb244b94878"), "CU", "Cuba" },
                    { new Guid("2fd98b66-0b17-4aed-997f-416dcd714bd6"), "LR", "Liberia" },
                    { new Guid("3039e166-0fac-4971-b552-e6f637f301d1"), "NA", "Namibia" },
                    { new Guid("307a5460-f131-45df-ba70-20fce7eb78cb"), "LA", "Laos" },
                    { new Guid("30c1c1a2-2cca-4dea-b67b-dc3f604f4720"), "AT", "Austria" },
                    { new Guid("31827150-adc9-459c-96aa-39cc9aab964c"), "BH", "Bahrain" },
                    { new Guid("328fec72-2b00-4ee8-9357-3cd42d2aa403"), "JM", "Jamaica" },
                    { new Guid("334fb8d7-0af1-476b-8854-9771691350d3"), "SE", "Sweden" },
                    { new Guid("351cd2e3-799d-4ed2-8422-57d7d89ff719"), "FM", "Micronesia" },
                    { new Guid("364927ce-9c60-4231-9986-39788676b34a"), "GA", "Gabon" },
                    { new Guid("3735c9df-26d9-420b-8f1d-b517c28a200a"), "BF", "Burkina Faso" },
                    { new Guid("377c5776-0fd9-4534-9e6b-67590b8d9aa6"), "ZA", "South Africa" },
                    { new Guid("37b202f1-0e3d-4e02-97ea-4c4f486039fb"), "LC", "Saint Lucia" },
                    { new Guid("3892c846-efca-49a4-8e06-ae98421833f7"), "PT", "Portugal" },
                    { new Guid("394b6a44-0d9a-4c93-aedf-561bced844c4"), "MY", "Malaysia" },
                    { new Guid("3a8edb02-4d10-432b-b8ab-0dfa064ed215"), "LS", "Lesotho" },
                    { new Guid("3d98a86a-ba0b-469a-929f-a8971f4c37f1"), "UY", "Uruguay" },
                    { new Guid("3e274b9e-f8fd-4dc0-be9d-704612b3b683"), "KP", "North Korea" },
                    { new Guid("43313753-b12f-411e-879b-d04b945337a6"), "MG", "Madagascar" },
                    { new Guid("440d9f71-0a93-4504-846e-6e4f1fa83925"), "AO", "Angola" },
                    { new Guid("455e55e1-7d09-4060-901c-04ac2e624785"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("457d57fa-6ce4-4164-b951-7731565ca7bb"), "IQ", "Iraq" },
                    { new Guid("458cc08e-473b-4a6a-b40d-a126e1807fee"), "HN", "Honduras" },
                    { new Guid("46c6e980-217c-4cde-b471-01bef6493fe5"), "GT", "Guatemala" },
                    { new Guid("4791c07a-8b19-4862-9640-d39698c7fd9c"), "BI", "Burundi" },
                    { new Guid("486388e5-39e8-4e04-82de-0edf0ddb7ec1"), "FJ", "Fiji" },
                    { new Guid("489beafe-7b1e-4ac7-ab69-bd00cbf1af03"), "TN", "Tunisia" },
                    { new Guid("4bb8a585-6c04-4ae7-b6bf-f948f732b9ec"), "TL", "Timor-Leste" },
                    { new Guid("4c5ca7a7-2d53-4ccd-9f04-a00242786905"), "GW", "Guinea-Bissau" },
                    { new Guid("4dd56576-552f-461b-ac2a-ab2caca13b18"), "SZ", "Eswatini" },
                    { new Guid("4e809d21-437b-4933-b1cc-90ed20e1f169"), "TT", "Trinidad and Tobago" },
                    { new Guid("4eb8a8cf-abbb-4767-ba34-9a01dbe197a2"), "EG", "Egypt" },
                    { new Guid("51425f87-ecf3-40cd-bad2-0f42c50f0774"), "HT", "Haiti" },
                    { new Guid("546c51fc-69d9-4810-aa0d-bcea3adbc781"), "GB", "United Kingdom" },
                    { new Guid("57577f2c-247e-45b9-9291-1c1f2cb06c67"), "BZ", "Belize" },
                    { new Guid("58896d68-699f-49a4-80cb-85e5c7a15367"), "BG", "Bulgaria" },
                    { new Guid("58fb83de-a44f-42a6-ba3b-080f744309c7"), "NI", "Nicaragua" },
                    { new Guid("5991c939-621b-4959-ae89-c8f6645f3771"), "KZ", "Kazakhstan" },
                    { new Guid("5a396edc-a48b-4740-b103-d2e59ea6101e"), "GD", "Grenada" },
                    { new Guid("5a3ceb72-dfa8-43be-85f1-42cbc75bd9bd"), "PH", "Philippines" },
                    { new Guid("5d9d3a65-0dbf-4f61-b334-944691d27e11"), "FR", "France" },
                    { new Guid("5f3ea599-b83f-443b-bf6b-e7b1e765a741"), "MC", "Monaco" },
                    { new Guid("5feabc2d-d0a6-4d81-be45-ac3ea9e3375e"), "AE", "United Arab Emirates" },
                    { new Guid("60d39a38-08c4-4a55-b605-45194bc19efb"), "LU", "Luxembourg" },
                    { new Guid("6113b2c7-0dd0-4d02-b12d-e1f4445f565e"), "NG", "Nigeria" },
                    { new Guid("628d9529-45da-4c74-b70f-1e52d72aab9e"), "CH", "Switzerland" },
                    { new Guid("6368cd75-4f20-44ac-9fb7-a70a917d07ad"), "PA", "Panama" },
                    { new Guid("663033f7-2a6c-44ae-a02e-8efb4212e1af"), "MR", "Mauritania" },
                    { new Guid("681b47d3-8fdb-4fa6-8362-671faf5f8be3"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("69fd7482-8223-4289-95ef-36aae839050e"), "LK", "Sri Lanka" },
                    { new Guid("6a346fa7-32c3-4415-9c9d-effe166b5247"), "AL", "Albania" },
                    { new Guid("6bb860bd-d65c-4b78-b90c-670641a1b856"), "BO", "Bolivia" },
                    { new Guid("6dbb818f-0b08-42b5-a898-5eead0602595"), "SY", "Syria" },
                    { new Guid("71263743-bc6b-464a-af42-91e858728049"), "SB", "Solomon Islands" },
                    { new Guid("72a6e76e-fb55-4004-a771-15c0499e6be5"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("7450bd95-9bd7-4a01-9ee1-b3cb8fe963f0"), "BD", "Bangladesh" },
                    { new Guid("749b3099-4aa1-418f-ae84-c1bbee3bed88"), "PW", "Palau" },
                    { new Guid("76d203cb-1e19-4e66-94f1-a8819102b502"), "TZ", "Tanzania" },
                    { new Guid("77320e05-b707-4ae6-ab40-38f7c0835bcd"), "NZ", "New Zealand" },
                    { new Guid("787d723b-50c4-48e8-b7ab-549ef0bb1d06"), "CF", "Central African Republic" },
                    { new Guid("79d1c341-33ba-45e2-b1b6-530b947a3f48"), "TH", "Thailand" },
                    { new Guid("7a83d735-7a52-42f2-b74d-8073e4b046a9"), "MH", "Marshall Islands" },
                    { new Guid("7af5b947-756a-41d5-9e44-3d6d598423cb"), "RO", "Romania" },
                    { new Guid("83388b6a-a595-47f0-a480-732968e9814f"), "ME", "Montenegro" },
                    { new Guid("83ed028a-52d6-4b80-ba25-399991c5c0c1"), "ZM", "Zambia" },
                    { new Guid("8401d115-29ec-4a53-8d3b-f31154c574ac"), "FI", "Finland" },
                    { new Guid("851827c4-789f-4c39-837f-e1fea6f7973b"), "BN", "Brunei" },
                    { new Guid("86c704d0-fede-4e63-bc87-4b968ec354e4"), "CR", "Costa Rica" },
                    { new Guid("8b78536c-15e5-42a0-b9dc-c01cca732cc1"), "DM", "Dominica" },
                    { new Guid("8c13098d-c8d9-4f75-a16a-8ffba580ae29"), "TG", "Togo" },
                    { new Guid("8e05ec9a-299c-41ad-aa09-3b5d54b5bc70"), "LY", "Libya" },
                    { new Guid("936b97ef-b075-460d-a3c8-32d6404078d7"), "PG", "Papua New Guinea" },
                    { new Guid("937198a8-e997-419d-a62e-7404d096f6c8"), "MM", "Myanmar" },
                    { new Guid("93f01d45-f6cb-4c70-b39d-58cf7b1cacd1"), "AG", "Antigua and Barbuda" },
                    { new Guid("9794da34-92f1-4f48-ae34-a6d7e31fa014"), "QA", "Qatar" },
                    { new Guid("98967e76-8bfe-413d-b697-fe29ecaaf8c9"), "SO", "Somalia" },
                    { new Guid("9922c999-a3d0-4db4-bc1f-e9bcfcfba01f"), "TD", "Chad" },
                    { new Guid("9a7f62ed-dc93-4497-82a7-0ad8f05fb6aa"), "NL", "Netherlands" },
                    { new Guid("9ac70375-f135-47ef-86fa-cf2c0a1e0334"), "DJ", "Djibouti" },
                    { new Guid("9adc09a8-afc3-4619-83a0-e11f6199769d"), "MN", "Mongolia" },
                    { new Guid("9bb9bce0-c1f8-4efd-9f06-79ae2107dd9c"), "SL", "Sierra Leone" },
                    { new Guid("9c2acb6c-e217-4988-8e4f-a02cc533991d"), "BW", "Botswana" },
                    { new Guid("9d580d7c-f391-4f7d-b2f3-eb0198832003"), "ML", "Mali" },
                    { new Guid("9dbcd814-f1cd-4845-87b0-8e76e43a7eec"), "GR", "Greece" },
                    { new Guid("9ee5d3b2-b85d-45a7-8431-e728a243f3a6"), "CA", "Canada" },
                    { new Guid("9f00422a-7926-4023-96a0-48f5bcc661a1"), "LT", "Lithuania" },
                    { new Guid("9fbbd7b9-2c61-4a6e-8f2f-f6794bb1f7a6"), "MX", "Mexico" },
                    { new Guid("a0e05efb-6654-46a4-851b-112f1ae87b06"), "NP", "Nepal" },
                    { new Guid("a35bfa53-119d-4ca4-98f5-2faecbaceabd"), "IT", "Italy" },
                    { new Guid("a5356eb5-ec98-4f6c-afe0-b70330d31471"), "ID", "Indonesia" },
                    { new Guid("a55e0492-4cae-4e77-b4bd-ae1a25b7e8b6"), "EE", "Estonia" },
                    { new Guid("a6564265-2549-45f3-9219-fb961ff3a414"), "BE", "Belgium" },
                    { new Guid("a86dd467-5973-4f18-aaff-fee1ac83be0d"), "CL", "Chile" },
                    { new Guid("a988736f-d82d-424c-917e-39511b579ab8"), "AF", "Afghanistan" },
                    { new Guid("a9b5148f-77cc-4f8d-ad1b-e9b784628e42"), "SI", "Slovenia" },
                    { new Guid("aa9fce10-e42f-427f-bc73-e02422257e68"), "TJ", "Tajikistan" },
                    { new Guid("abcf9b99-e03d-466c-b69f-629e051c3322"), "AM", "Armenia" },
                    { new Guid("af7263c5-9d4b-4ecf-bbe5-60404614faaf"), "VA", "Vatican City" },
                    { new Guid("b0d9d671-d2cb-4358-a6ec-88b60453029b"), "JO", "Jordan" },
                    { new Guid("b0e58524-a361-420e-8cbe-3d9a03db78e2"), "PE", "Peru" },
                    { new Guid("b11989fb-e85e-45b9-9133-7e87520bb9ea"), "SN", "Senegal" },
                    { new Guid("b22495ac-99f8-4e95-91b0-9cc82e886800"), "SS", "South Sudan" },
                    { new Guid("b302af66-dc2b-4617-a55c-645770409883"), "NO", "Norway" },
                    { new Guid("b33a541a-aec1-4aae-b1b4-7b8760bf2720"), "HR", "Croatia" },
                    { new Guid("b73e8e9a-1b84-482d-923b-73dcb9b6a0e3"), "SV", "El Salvador" },
                    { new Guid("bab831fd-e60b-486d-be00-64a9723f84f2"), "IS", "Iceland" },
                    { new Guid("bac6f8d2-7dff-4f98-a075-c1226f346dd3"), "DK", "Denmark" },
                    { new Guid("bc871a1e-bba4-42eb-9d6e-89d8537f0089"), "NE", "Niger" },
                    { new Guid("bcba831f-fefe-495e-9e6e-33478d70fba3"), "GH", "Ghana" },
                    { new Guid("bcc7f9b6-bd33-48e9-a7b7-a27c41d213be"), "UG", "Uganda" },
                    { new Guid("c11596ff-6281-4531-872b-799c417a372b"), "KM", "Comoros" },
                    { new Guid("c13f4d5e-5e55-4f45-9264-ca49ded0236d"), "MV", "Maldives" },
                    { new Guid("c2199d2b-6540-42c1-9f2a-9c48fd46cb5e"), "BT", "Bhutan" },
                    { new Guid("c2860bb3-bd90-4e39-9de9-dbd210f92017"), "CN", "China" },
                    { new Guid("c2e52851-969a-4896-9d70-c5e9b24dd2a9"), "IN", "India" },
                    { new Guid("c505022b-f45f-4a4e-9b16-6aad9abefa70"), "KH", "Cambodia" },
                    { new Guid("c6d1746c-b74d-4325-a917-9f2526f2f40a"), "VN", "Vietnam" },
                    { new Guid("c702fc49-3d6c-4f80-b494-e31facbe7abf"), "PL", "Poland" },
                    { new Guid("c73c0b87-564e-460e-bf0b-4bcd50fe2065"), "CM", "Cameroon" },
                    { new Guid("c9c99307-ce22-4cc9-88ec-ba7c45ac0478"), "HU", "Hungary" },
                    { new Guid("cac326a9-d360-496b-ab60-18edbc9d6a13"), "YE", "Yemen" },
                    { new Guid("cae676fc-0d6a-41cf-a8be-0500728ec30b"), "LI", "Liechtenstein" },
                    { new Guid("cbb5d1b6-3771-4d38-bc15-9d015da1387f"), "SC", "Seychelles" },
                    { new Guid("cc6411f2-56d9-4f25-addd-addd0ec6c144"), "AR", "Argentina" },
                    { new Guid("cd338c8a-1c80-4112-a54b-33452cab1199"), "SA", "Saudi Arabia" },
                    { new Guid("cdbe9f95-8615-4415-a360-e54ca0020c9a"), "EC", "Ecuador" },
                    { new Guid("cec57c1b-4f93-46a8-bf76-208432777a70"), "DE", "Germany" },
                    { new Guid("cf98a21c-6a21-4264-9808-c902df96725b"), "UZ", "Uzbekistan" },
                    { new Guid("d0c3e8ae-52b3-46cd-bda3-80cfd73470da"), "MZ", "Mozambique" },
                    { new Guid("d12b217b-1641-4b2d-b38a-1c0a0d1f5d8b"), "NR", "Nauru" },
                    { new Guid("d23c14e2-bb84-4a93-9e56-83d3781e7243"), "GN", "Guinea" },
                    { new Guid("d3184a91-2add-4ab1-8fc2-c74ccab90015"), "LV", "Latvia" },
                    { new Guid("d3349547-c347-4943-9e6f-c426ce248b08"), "WS", "Samoa" },
                    { new Guid("d5c326f8-821f-4502-8bea-d8c9363038e8"), "VA", "Holy See" },
                    { new Guid("d647d6cc-9c0d-4d3f-bc7e-ee6561babe79"), "BY", "Belarus" },
                    { new Guid("d70a54ab-66ff-4306-a58e-6c0fab6a2e78"), "SR", "Suriname" },
                    { new Guid("d88fca9b-b981-4872-ba45-d66a59f45747"), "US", "United States of America" },
                    { new Guid("d8e2a48e-c05b-4dc8-9b5c-d8eb92a994b2"), "TR", "Turkey" },
                    { new Guid("da4d0367-975f-48a0-a0ca-ff8eb81b7fbc"), "AU", "Australia" },
                    { new Guid("dd442343-9774-4901-9eed-7325fc160d4c"), "KI", "Kiribati" },
                    { new Guid("e03b2821-4d11-4bd4-ac8e-ccf0e11d3474"), "MW", "Malawi" },
                    { new Guid("e0f89dc2-d720-4a59-905a-9110bdca9523"), "TO", "Tonga" },
                    { new Guid("e3b57562-f5e6-4823-aa5a-e02ba3376ccd"), "RS", "Serbia" },
                    { new Guid("e3c91c31-47b5-4ea9-bc61-aa6cf6e9474b"), "TM", "Turkmenistan" },
                    { new Guid("e5276b7e-ae3c-452b-a358-685280458043"), "RW", "Rwanda" },
                    { new Guid("e6d35e43-7fa5-422a-b8ae-5534e3a955ba"), "VU", "Vanuatu" },
                    { new Guid("e76d95d3-8ea5-424f-8e31-fc3660a608f7"), "GM", "Gambia" },
                    { new Guid("e86085e3-f3f5-45b2-8f21-803ea75fb903"), "UA", "Ukraine" },
                    { new Guid("e8764536-05de-4441-9e79-7e44ed007710"), "BS", "Bahamas" },
                    { new Guid("ecaa124b-0baa-4268-853c-688d1e7b99a5"), "JP", "Japan" },
                    { new Guid("ee36451a-2c35-4f09-b060-83787aea9643"), "BJ", "Benin" },
                    { new Guid("f2217c12-6bfe-408e-90ac-30d309d1f882"), "GE", "Georgia" },
                    { new Guid("f33c580e-7b7a-4c9c-b527-9990ea3d6047"), "PY", "Paraguay" },
                    { new Guid("f613e3c6-d8aa-4fc7-a8e7-c4cd147d39d5"), "OM", "Oman" },
                    { new Guid("f851d7fb-3eb6-4c0e-840e-12616fb30a78"), "CV", "Cabo Verde" },
                    { new Guid("f974a306-67f6-4e91-9b91-442a7f1d2b56"), "KR", "South Korea" },
                    { new Guid("fa345365-1547-4ef3-9d76-fdb95cef8656"), "ES", "Spain" },
                    { new Guid("fd2f2f41-efa6-4d29-8bf9-ab66a56f2cfd"), "IR", "Iran" },
                    { new Guid("feb6ecf9-654b-4d7b-be71-22c753f00916"), "SG", "Singapore" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4c9accaa-b0d7-4414-9560-0b99c91dc6eb"), "Male" },
                    { new Guid("a6950d2d-ad94-4988-b3ae-73b9806262aa"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("24cb4268-b30d-40f5-980f-5b7a9cd62439"), "Emergency" },
                    { new Guid("297d3ac6-d88c-4e7e-abad-33dc476cf1fd"), "Obstetric and Reproductive Interventions" },
                    { new Guid("5af317a5-6174-4e2f-95a0-c902f5b63bd4"), "Preventive Interventions" },
                    { new Guid("5bd923a3-2358-4e0a-aa2f-3cae5a3dfbf7"), "Therapeutic Interventions" },
                    { new Guid("719fcdc8-60fa-437b-93c2-e78387ac5dc8"), "Diagnostic Interventions" },
                    { new Guid("7b846fce-c3cb-49df-bd4e-6c49992be73f"), "Oncological Interventions" },
                    { new Guid("a177659a-2a60-4f37-8fd8-3578b2d89c23"), "Dental Interventions" },
                    { new Guid("b19c3e4f-4273-4938-a7f0-85942030b6b9"), "Postoperative Care" },
                    { new Guid("b80c0527-1e69-493c-bd5e-0cd5ec42ca8d"), "Exotic and Specialized Interventions" },
                    { new Guid("c174c316-c0b4-4ffd-bccc-922e72d83330"), "Surgical Interventions" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserBookings_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserBookings",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserBookings_Bookings_BookingId",
                table: "ApplicationUserBookings",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserBookings_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserBookings_Bookings_BookingId",
                table: "ApplicationUserBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserPets",
                table: "ApplicationUserPets");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("026ffbda-025e-4601-8454-3b5b6a2d9e6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("035de50f-3ed2-4b88-b416-ef77c52eb0f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03d01613-5321-4d3b-b129-cb89cde3144b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("040bb7cc-6d5c-40c1-9c17-4fb9dbc5a3ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("058409fb-0394-47f1-bee2-95b05e335355"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0711bda3-07c1-45cb-92c4-76a3ff7d09d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0962ded8-8b6a-4bd6-9079-41184510d25b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("09ad2b55-70bc-428c-b32d-8302ae6639de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c912a34-5caf-4d64-afb2-24a16d16966e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c98ecc9-041c-4328-a3ee-62068a535955"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d36f423-9d4a-4293-9128-07b386f3a8e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11a526a2-865d-44a4-aafc-faf562b2d1c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1377adce-2837-417d-8826-c237be61bc9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13835e8e-5c70-4b61-829f-efde68d8bff5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13d1b2ee-5039-49a1-a8ce-1ee5e739a206"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("142abe77-b112-4234-b64b-7ff2549094e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("14f277f7-4169-4ef6-b90f-de1be9a404ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1581940a-28ce-4810-8522-59e64a9c8517"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("167883c0-845f-49b9-97fe-f5066c898d45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17b7cea7-a233-4a72-9f3c-82b4ee261cb5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1878f5c9-1b2d-4c94-94b4-6672e05216d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c7597fa-7471-49de-a8f5-826c2cf420aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c829676-1eb3-4da5-89c4-19cfe15b851e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ee19f71-d73d-4faf-8f42-a6d32d20262b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1f85bac7-3731-418f-8737-4d31d0ecc321"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1fd4fc72-8304-4a4f-8139-b970ebd6723c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21e6967a-2028-439f-81d0-f9d010da80ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("227b1653-0cd9-4ee4-82cf-25ac35cf4726"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2288c099-21a2-4726-affd-9cf3b397ffa9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28951333-a5fe-4881-81f8-0f7d256e2ef0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28ad20b7-a0f7-4a21-ba94-ffbaf889602e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29830845-74ea-45ff-bc6c-0bda87ca205e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2b881ad9-e301-42df-a821-b927cb6499fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2badf3de-04a9-4f18-86d1-59c8463b05f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d1beafd-313a-4715-a479-9f0fc89689a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ec15ff8-a413-4c8f-a98f-fcb244b94878"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fd98b66-0b17-4aed-997f-416dcd714bd6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3039e166-0fac-4971-b552-e6f637f301d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("307a5460-f131-45df-ba70-20fce7eb78cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30c1c1a2-2cca-4dea-b67b-dc3f604f4720"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31827150-adc9-459c-96aa-39cc9aab964c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("328fec72-2b00-4ee8-9357-3cd42d2aa403"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("334fb8d7-0af1-476b-8854-9771691350d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("351cd2e3-799d-4ed2-8422-57d7d89ff719"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("364927ce-9c60-4231-9986-39788676b34a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3735c9df-26d9-420b-8f1d-b517c28a200a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("377c5776-0fd9-4534-9e6b-67590b8d9aa6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37b202f1-0e3d-4e02-97ea-4c4f486039fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3892c846-efca-49a4-8e06-ae98421833f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("394b6a44-0d9a-4c93-aedf-561bced844c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a8edb02-4d10-432b-b8ab-0dfa064ed215"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d98a86a-ba0b-469a-929f-a8971f4c37f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e274b9e-f8fd-4dc0-be9d-704612b3b683"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43313753-b12f-411e-879b-d04b945337a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("440d9f71-0a93-4504-846e-6e4f1fa83925"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("455e55e1-7d09-4060-901c-04ac2e624785"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("457d57fa-6ce4-4164-b951-7731565ca7bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("458cc08e-473b-4a6a-b40d-a126e1807fee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46c6e980-217c-4cde-b471-01bef6493fe5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4791c07a-8b19-4862-9640-d39698c7fd9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("486388e5-39e8-4e04-82de-0edf0ddb7ec1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("489beafe-7b1e-4ac7-ab69-bd00cbf1af03"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4bb8a585-6c04-4ae7-b6bf-f948f732b9ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c5ca7a7-2d53-4ccd-9f04-a00242786905"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4dd56576-552f-461b-ac2a-ab2caca13b18"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4e809d21-437b-4933-b1cc-90ed20e1f169"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4eb8a8cf-abbb-4767-ba34-9a01dbe197a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51425f87-ecf3-40cd-bad2-0f42c50f0774"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("546c51fc-69d9-4810-aa0d-bcea3adbc781"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("57577f2c-247e-45b9-9291-1c1f2cb06c67"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58896d68-699f-49a4-80cb-85e5c7a15367"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58fb83de-a44f-42a6-ba3b-080f744309c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5991c939-621b-4959-ae89-c8f6645f3771"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a396edc-a48b-4740-b103-d2e59ea6101e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a3ceb72-dfa8-43be-85f1-42cbc75bd9bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d9d3a65-0dbf-4f61-b334-944691d27e11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f3ea599-b83f-443b-bf6b-e7b1e765a741"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5feabc2d-d0a6-4d81-be45-ac3ea9e3375e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60d39a38-08c4-4a55-b605-45194bc19efb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6113b2c7-0dd0-4d02-b12d-e1f4445f565e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("628d9529-45da-4c74-b70f-1e52d72aab9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6368cd75-4f20-44ac-9fb7-a70a917d07ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("663033f7-2a6c-44ae-a02e-8efb4212e1af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("681b47d3-8fdb-4fa6-8362-671faf5f8be3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69fd7482-8223-4289-95ef-36aae839050e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a346fa7-32c3-4415-9c9d-effe166b5247"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6bb860bd-d65c-4b78-b90c-670641a1b856"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6dbb818f-0b08-42b5-a898-5eead0602595"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71263743-bc6b-464a-af42-91e858728049"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72a6e76e-fb55-4004-a771-15c0499e6be5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7450bd95-9bd7-4a01-9ee1-b3cb8fe963f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("749b3099-4aa1-418f-ae84-c1bbee3bed88"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76d203cb-1e19-4e66-94f1-a8819102b502"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77320e05-b707-4ae6-ab40-38f7c0835bcd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("787d723b-50c4-48e8-b7ab-549ef0bb1d06"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79d1c341-33ba-45e2-b1b6-530b947a3f48"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a83d735-7a52-42f2-b74d-8073e4b046a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7af5b947-756a-41d5-9e44-3d6d598423cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83388b6a-a595-47f0-a480-732968e9814f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83ed028a-52d6-4b80-ba25-399991c5c0c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8401d115-29ec-4a53-8d3b-f31154c574ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("851827c4-789f-4c39-837f-e1fea6f7973b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86c704d0-fede-4e63-bc87-4b968ec354e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b78536c-15e5-42a0-b9dc-c01cca732cc1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c13098d-c8d9-4f75-a16a-8ffba580ae29"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e05ec9a-299c-41ad-aa09-3b5d54b5bc70"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("936b97ef-b075-460d-a3c8-32d6404078d7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("937198a8-e997-419d-a62e-7404d096f6c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93f01d45-f6cb-4c70-b39d-58cf7b1cacd1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9794da34-92f1-4f48-ae34-a6d7e31fa014"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98967e76-8bfe-413d-b697-fe29ecaaf8c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9922c999-a3d0-4db4-bc1f-e9bcfcfba01f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a7f62ed-dc93-4497-82a7-0ad8f05fb6aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ac70375-f135-47ef-86fa-cf2c0a1e0334"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9adc09a8-afc3-4619-83a0-e11f6199769d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9bb9bce0-c1f8-4efd-9f06-79ae2107dd9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c2acb6c-e217-4988-8e4f-a02cc533991d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d580d7c-f391-4f7d-b2f3-eb0198832003"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9dbcd814-f1cd-4845-87b0-8e76e43a7eec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ee5d3b2-b85d-45a7-8431-e728a243f3a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f00422a-7926-4023-96a0-48f5bcc661a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9fbbd7b9-2c61-4a6e-8f2f-f6794bb1f7a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0e05efb-6654-46a4-851b-112f1ae87b06"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a35bfa53-119d-4ca4-98f5-2faecbaceabd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a5356eb5-ec98-4f6c-afe0-b70330d31471"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a55e0492-4cae-4e77-b4bd-ae1a25b7e8b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a6564265-2549-45f3-9219-fb961ff3a414"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a86dd467-5973-4f18-aaff-fee1ac83be0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a988736f-d82d-424c-917e-39511b579ab8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9b5148f-77cc-4f8d-ad1b-e9b784628e42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa9fce10-e42f-427f-bc73-e02422257e68"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("abcf9b99-e03d-466c-b69f-629e051c3322"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af7263c5-9d4b-4ecf-bbe5-60404614faaf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0d9d671-d2cb-4358-a6ec-88b60453029b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0e58524-a361-420e-8cbe-3d9a03db78e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b11989fb-e85e-45b9-9133-7e87520bb9ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b22495ac-99f8-4e95-91b0-9cc82e886800"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b302af66-dc2b-4617-a55c-645770409883"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b33a541a-aec1-4aae-b1b4-7b8760bf2720"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b73e8e9a-1b84-482d-923b-73dcb9b6a0e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bab831fd-e60b-486d-be00-64a9723f84f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bac6f8d2-7dff-4f98-a075-c1226f346dd3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc871a1e-bba4-42eb-9d6e-89d8537f0089"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bcba831f-fefe-495e-9e6e-33478d70fba3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bcc7f9b6-bd33-48e9-a7b7-a27c41d213be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c11596ff-6281-4531-872b-799c417a372b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c13f4d5e-5e55-4f45-9264-ca49ded0236d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2199d2b-6540-42c1-9f2a-9c48fd46cb5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2860bb3-bd90-4e39-9de9-dbd210f92017"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2e52851-969a-4896-9d70-c5e9b24dd2a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c505022b-f45f-4a4e-9b16-6aad9abefa70"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6d1746c-b74d-4325-a917-9f2526f2f40a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c702fc49-3d6c-4f80-b494-e31facbe7abf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c73c0b87-564e-460e-bf0b-4bcd50fe2065"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9c99307-ce22-4cc9-88ec-ba7c45ac0478"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cac326a9-d360-496b-ab60-18edbc9d6a13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cae676fc-0d6a-41cf-a8be-0500728ec30b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cbb5d1b6-3771-4d38-bc15-9d015da1387f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc6411f2-56d9-4f25-addd-addd0ec6c144"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd338c8a-1c80-4112-a54b-33452cab1199"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdbe9f95-8615-4415-a360-e54ca0020c9a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cec57c1b-4f93-46a8-bf76-208432777a70"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf98a21c-6a21-4264-9808-c902df96725b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0c3e8ae-52b3-46cd-bda3-80cfd73470da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d12b217b-1641-4b2d-b38a-1c0a0d1f5d8b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d23c14e2-bb84-4a93-9e56-83d3781e7243"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3184a91-2add-4ab1-8fc2-c74ccab90015"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3349547-c347-4943-9e6f-c426ce248b08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d5c326f8-821f-4502-8bea-d8c9363038e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d647d6cc-9c0d-4d3f-bc7e-ee6561babe79"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d70a54ab-66ff-4306-a58e-6c0fab6a2e78"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d88fca9b-b981-4872-ba45-d66a59f45747"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d8e2a48e-c05b-4dc8-9b5c-d8eb92a994b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da4d0367-975f-48a0-a0ca-ff8eb81b7fbc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd442343-9774-4901-9eed-7325fc160d4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e03b2821-4d11-4bd4-ac8e-ccf0e11d3474"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0f89dc2-d720-4a59-905a-9110bdca9523"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e3b57562-f5e6-4823-aa5a-e02ba3376ccd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e3c91c31-47b5-4ea9-bc61-aa6cf6e9474b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e5276b7e-ae3c-452b-a358-685280458043"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6d35e43-7fa5-422a-b8ae-5534e3a955ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e76d95d3-8ea5-424f-8e31-fc3660a608f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e86085e3-f3f5-45b2-8f21-803ea75fb903"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8764536-05de-4441-9e79-7e44ed007710"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ecaa124b-0baa-4268-853c-688d1e7b99a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee36451a-2c35-4f09-b060-83787aea9643"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2217c12-6bfe-408e-90ac-30d309d1f882"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f33c580e-7b7a-4c9c-b527-9990ea3d6047"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f613e3c6-d8aa-4fc7-a8e7-c4cd147d39d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f851d7fb-3eb6-4c0e-840e-12616fb30a78"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f974a306-67f6-4e91-9b91-442a7f1d2b56"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa345365-1547-4ef3-9d76-fdb95cef8656"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd2f2f41-efa6-4d29-8bf9-ab66a56f2cfd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("feb6ecf9-654b-4d7b-be71-22c753f00916"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("4c9accaa-b0d7-4414-9560-0b99c91dc6eb"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("a6950d2d-ad94-4988-b3ae-73b9806262aa"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("24cb4268-b30d-40f5-980f-5b7a9cd62439"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("297d3ac6-d88c-4e7e-abad-33dc476cf1fd"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("5af317a5-6174-4e2f-95a0-c902f5b63bd4"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("5bd923a3-2358-4e0a-aa2f-3cae5a3dfbf7"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("719fcdc8-60fa-437b-93c2-e78387ac5dc8"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("7b846fce-c3cb-49df-bd4e-6c49992be73f"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("a177659a-2a60-4f37-8fd8-3578b2d89c23"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("b19c3e4f-4273-4938-a7f0-85942030b6b9"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("b80c0527-1e69-493c-bd5e-0cd5ec42ca8d"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("c174c316-c0b4-4ffd-bccc-922e72d83330"));

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "ApplicationUserBookings",
                newName: "UserDetailsId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationUserId",
                table: "ApplicationUserPets",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "User Details Id");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ApplicationUserPets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "User Details Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserPets",
                table: "ApplicationUserPets",
                columns: new[] { "UserId", "PetId" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("00a99495-e8bc-4172-b911-ba42617bb983"), "ZW", "Zimbabwe" },
                    { new Guid("0381594e-a3e6-45aa-9914-7e99c9377bda"), "ZA", "South Africa" },
                    { new Guid("0404a25e-e0a5-4359-9ae5-a6fb8b6543a3"), "FR", "France" },
                    { new Guid("041ef411-f6c9-4bf4-a7e8-37092ba4f196"), "ML", "Mali" },
                    { new Guid("048eacd6-0060-43c0-94e6-0f43e083a275"), "ST", "Sao Tome and Principe" },
                    { new Guid("08387237-f277-416e-a65f-e33ed32ca559"), "GR", "Greece" },
                    { new Guid("083baef5-02e3-4e2d-9cdf-81145bb5dd93"), "AD", "Andorra" },
                    { new Guid("08a393d5-88e9-4c86-b719-b299d903d527"), "SV", "El Salvador" },
                    { new Guid("098c65c6-ff05-401c-a118-4ab8f660532d"), "PY", "Paraguay" },
                    { new Guid("0a81506a-8151-4a6f-94bd-f9278874c359"), "DZ", "Algeria" },
                    { new Guid("0d1d257e-bbfd-48f8-a0ae-1da228da4926"), "HT", "Haiti" },
                    { new Guid("0e4096fd-6d6c-4b7e-a2c5-2258b1b71b43"), "PH", "Philippines" },
                    { new Guid("0ea0afdd-4923-472a-91ec-57c088b42820"), "PL", "Poland" },
                    { new Guid("0f2a2920-e8b9-45de-8d2c-0eda7fc4250f"), "BB", "Barbados" },
                    { new Guid("11136dac-5192-44fe-8e0e-5a23e1e675bb"), "BO", "Bolivia" },
                    { new Guid("11bb9590-1fd3-4e6a-8207-6454e8699cee"), "AL", "Albania" },
                    { new Guid("13386d82-db16-45fd-a56b-18a507aec2eb"), "PW", "Palau" },
                    { new Guid("14cab769-cd51-4633-a33e-6da6f91424c7"), "ET", "Ethiopia" },
                    { new Guid("15a55290-afcd-400d-9034-39318ce6b585"), "LA", "Laos" },
                    { new Guid("15cc8e35-4665-461d-9116-0921b0684a0c"), "IQ", "Iraq" },
                    { new Guid("17a337f1-cf87-415e-839e-7c5c1fd9f570"), "SN", "Senegal" },
                    { new Guid("17e1d03c-2fc5-4b05-a160-d01de7689b01"), "VN", "Vietnam" },
                    { new Guid("1bd3f517-28dc-45ea-8b13-44e10ca6350a"), "LB", "Lebanon" },
                    { new Guid("1be1cd04-4012-4002-9085-d9e376217b92"), "EE", "Estonia" },
                    { new Guid("1d976ed9-56d0-4582-a014-995e31ef9a30"), "SL", "Sierra Leone" },
                    { new Guid("1ed03bd4-8aa1-44e7-81e0-a6263d6c4887"), "KR", "South Korea" },
                    { new Guid("23417357-ae16-4d64-9dde-796744ac9b57"), "MW", "Malawi" },
                    { new Guid("23871065-e693-470b-9c3d-6863aee4a563"), "FM", "Micronesia" },
                    { new Guid("23aeae8c-bb18-47cb-840a-e11f28e996aa"), "UA", "Ukraine" },
                    { new Guid("267cbfa7-e2fb-4ae2-b4e7-f4aa50e9474a"), "AR", "Argentina" },
                    { new Guid("2716b7c6-7078-4ab4-bd91-59f4c635957e"), "KP", "North Korea" },
                    { new Guid("271e8de4-b62f-48b6-835d-7de4bf92473f"), "YE", "Yemen" },
                    { new Guid("28f66103-5eb8-40be-9358-25ec3df243bf"), "NG", "Nigeria" },
                    { new Guid("29d92fca-28c9-4388-9472-0b158e665151"), "AM", "Armenia" },
                    { new Guid("2cc4f4dc-589d-41bc-90c5-e2c174980638"), "PE", "Peru" },
                    { new Guid("2d5dc601-6fc6-4fd8-bccc-6d0f01139ca4"), "BR", "Brazil" },
                    { new Guid("2dbcad05-2e8c-4703-8d1a-76493cbd4518"), "NZ", "New Zealand" },
                    { new Guid("2e4d88bd-2ac7-4027-90a6-aae572aeb0d0"), "PK", "Pakistan" },
                    { new Guid("3193b259-231e-405f-9574-afead062f051"), "IS", "Iceland" },
                    { new Guid("34a4617d-ccae-4092-9489-6a07effa3f9a"), "PG", "Papua New Guinea" },
                    { new Guid("35e80f33-f305-4c4a-9292-27b3a70a6df3"), "VA", "Holy See" },
                    { new Guid("37b3e1a6-3b01-4c85-ac10-ef7e1e4bcf50"), "MZ", "Mozambique" },
                    { new Guid("38b05e68-b23c-4020-844d-3f63e892a818"), "CV", "Cabo Verde" },
                    { new Guid("395c73a3-cb5c-406c-aee7-604625983115"), "BI", "Burundi" },
                    { new Guid("39a3ff36-1cbf-4596-9812-9fc9fb652d14"), "MA", "Morocco" },
                    { new Guid("39fcd227-0c46-43c7-9225-6a6e3b1e29ff"), "BS", "Bahamas" },
                    { new Guid("3afcf2db-319d-46dc-b51b-5d2e8fa5ded9"), "RW", "Rwanda" },
                    { new Guid("3bb346a8-4501-4dee-90dc-aa4884f9628d"), "NP", "Nepal" },
                    { new Guid("3d06e441-c199-497f-834c-ad0b50cb8b52"), "CU", "Cuba" },
                    { new Guid("3d3cd049-f419-4bc7-83db-8e89f219660f"), "LR", "Liberia" },
                    { new Guid("3d9b167e-8ad0-4b83-8303-fc36a73848e5"), "LI", "Liechtenstein" },
                    { new Guid("3f443bcf-b64c-4038-a6d5-c40c76cc3096"), "KW", "Kuwait" },
                    { new Guid("412b2f1b-f78c-4424-8d44-5552c0084d53"), "SD", "Sudan" },
                    { new Guid("4183af72-8dc8-4330-8b67-cba69d581d4e"), "FI", "Finland" },
                    { new Guid("41e209e6-aac0-4052-a4c9-fd984058928b"), "BN", "Brunei" },
                    { new Guid("429f5304-de3c-42e2-b50c-b183b170a60a"), "TN", "Tunisia" },
                    { new Guid("42bacdda-4a50-4629-be68-c166c4aa88b7"), "VE", "Venezuela" },
                    { new Guid("44ebd5d2-c94c-4f22-bc48-ff23a9d5786c"), "MK", "North Macedonia" },
                    { new Guid("455c3ba3-1d1f-41a8-94a0-4735e098dac5"), "PA", "Panama" },
                    { new Guid("45e9cc61-7b79-4066-91d7-d44d2dc33705"), "HR", "Croatia" },
                    { new Guid("468ad825-9dbf-4063-b602-305613ded725"), "ME", "Montenegro" },
                    { new Guid("46c302af-df44-49db-8ab5-0af61691b41a"), "LT", "Lithuania" },
                    { new Guid("479a8cf9-d7c2-486e-9c86-f9aec36a4669"), "LK", "Sri Lanka" },
                    { new Guid("4b355a84-5a47-4bbc-871b-7b7b862a4ae9"), "GQ", "Equatorial Guinea" },
                    { new Guid("4fe72aed-f79a-4bff-a5ba-39318b555736"), "KE", "Kenya" },
                    { new Guid("508b75b0-635f-492d-89cd-1223c3c93d01"), "CN", "China" },
                    { new Guid("519380f3-a782-4bf7-9c61-6cb8abe42bd4"), "JP", "Japan" },
                    { new Guid("51cfab11-8ce5-44e6-85d1-641dc0e366a5"), "CY", "Cyprus" },
                    { new Guid("5207caaf-bdde-4d2c-a7db-639ac1d31738"), "CL", "Chile" },
                    { new Guid("54541919-3acc-4474-9198-963d86c684f7"), "GM", "Gambia" },
                    { new Guid("552b0890-09e6-4273-8235-14664b14203c"), "RU", "Russia" },
                    { new Guid("555e1477-f618-408c-a3da-2727b23c1354"), "NI", "Nicaragua" },
                    { new Guid("55777e45-4294-4787-bf84-761a575ae1b4"), "LS", "Lesotho" },
                    { new Guid("5589f146-e6bc-4665-8ab0-7b6998f47990"), "GD", "Grenada" },
                    { new Guid("561689ff-6df3-4fd1-8ba2-870c56aa6a46"), "ZM", "Zambia" },
                    { new Guid("5663fb40-1b8d-4350-932e-3bb57ac2001e"), "MV", "Maldives" },
                    { new Guid("56ad245c-c9fc-4e9b-a8e2-b9543f04ba8a"), "SM", "San Marino" },
                    { new Guid("5859a620-e7db-487d-9e7b-adce4c7d0c43"), "MT", "Malta" },
                    { new Guid("5917f331-1899-4716-a196-fe0e1e71e699"), "KG", "Kyrgyzstan" },
                    { new Guid("591e0e86-0a7b-4ce2-b640-05f3303d9e91"), "CO", "Colombia" },
                    { new Guid("5aca1927-d299-4fcb-8701-c7ce9ed3e538"), "SY", "Syria" },
                    { new Guid("5c6835ea-1abb-4bc8-9784-15e455baf15c"), "BT", "Bhutan" },
                    { new Guid("5e563a65-a7da-4e3c-81e2-22e81aae6acd"), "KH", "Cambodia" },
                    { new Guid("5f3a9293-b121-4749-be59-29c7c0074a4f"), "ER", "Eritrea" },
                    { new Guid("607e9b41-9ae4-4b84-b704-5e60fdb2fea2"), "NO", "Norway" },
                    { new Guid("625b8239-08f9-4042-a313-9fb53feb7497"), "BH", "Bahrain" },
                    { new Guid("657b4f9c-21a9-4b47-b399-409da8083ba4"), "TL", "Timor-Leste" },
                    { new Guid("69460549-27e5-4a9a-b34d-a82df835eb5f"), "DO", "Dominican Republic" },
                    { new Guid("6978db6b-be9c-46ab-bc2f-2aacabfec0c7"), "AE", "United Arab Emirates" },
                    { new Guid("69d8383b-1f5e-424f-96fd-cf6cedef1e3e"), "EC", "Ecuador" },
                    { new Guid("6b714d2b-087b-4811-8a15-a355cddeb420"), "GT", "Guatemala" },
                    { new Guid("6dccb638-06e8-458a-81b8-e1edb9b5accd"), "MU", "Mauritius" },
                    { new Guid("6e43d68e-c8d2-4eda-b6a2-086d4a600f3b"), "WS", "Samoa" },
                    { new Guid("6f09bcce-3ec9-4315-9de8-10a0bec8ed6a"), "MY", "Malaysia" },
                    { new Guid("70e2884b-de79-4892-a340-fa8fb0cbb859"), "VU", "Vanuatu" },
                    { new Guid("760b2979-0629-4cd2-bb4e-4ead88b0ce11"), "CA", "Canada" },
                    { new Guid("78766611-994a-4a2a-96b1-76598ecc27ce"), "SO", "Somalia" },
                    { new Guid("79d36b85-3231-45fe-b164-0e1f2ea96847"), "GH", "Ghana" },
                    { new Guid("7b8d9b0e-7133-4dcd-929d-433687adf37f"), "JO", "Jordan" },
                    { new Guid("7dde3ec9-3a00-4ff4-8023-bae42e5b3270"), "NE", "Niger" },
                    { new Guid("7df0f11a-68c4-4e67-b548-fbb379a16d52"), "MH", "Marshall Islands" },
                    { new Guid("7e33a9cb-7a48-4ada-abf8-856ae6e67a13"), "SK", "Slovakia" },
                    { new Guid("7e5128cd-4402-4249-ae07-7c67f04aec8c"), "BE", "Belgium" },
                    { new Guid("7efb312c-651e-4687-9010-1f4e6e4b07da"), "TR", "Turkey" },
                    { new Guid("806bce63-c727-43bb-8db0-74397d94ec46"), "GB", "United Kingdom" },
                    { new Guid("834a8c67-534b-46e8-b1c1-6697a640644f"), "KM", "Comoros" },
                    { new Guid("83809627-c3ac-43af-9627-1b9289ed43c7"), "SG", "Singapore" },
                    { new Guid("86858cfc-2fa3-46d7-a020-6042bef3b1dd"), "GE", "Georgia" },
                    { new Guid("88dce617-5b0b-4d7c-85d1-d0c993413aee"), "KI", "Kiribati" },
                    { new Guid("8c7f7064-9709-41b9-98de-661f5f42ec9d"), "GA", "Gabon" },
                    { new Guid("8ccb37f7-0a9e-48d7-82e6-ea0dd27f3e45"), "DJ", "Djibouti" },
                    { new Guid("8eaaafd8-37bb-447f-8452-627b010746c9"), "RS", "Serbia" },
                    { new Guid("9216ae0a-d5fe-4ffd-bf07-b6ec946c9311"), "AG", "Antigua and Barbuda" },
                    { new Guid("926fba51-dc5e-4166-b0be-f6686fc11b89"), "SS", "South Sudan" },
                    { new Guid("99bc4a04-48b4-47d6-aa24-69145540a966"), "LC", "Saint Lucia" },
                    { new Guid("9acffadc-aebf-49f8-a288-86627d7250dd"), "BG", "Bulgaria" },
                    { new Guid("9b380558-5c45-44bc-b8ed-1c8335d59e9e"), "TO", "Tonga" },
                    { new Guid("9d77a24a-3aa4-45ff-a7a3-6a99348dda1c"), "IR", "Iran" },
                    { new Guid("9d7e1e56-32b7-4b6b-9b0d-9c852b033ae3"), "SC", "Seychelles" },
                    { new Guid("9ecb67ba-348e-4ce1-a9a0-8788cf14de38"), "SA", "Saudi Arabia" },
                    { new Guid("9f11e9e9-8ca9-4d85-bace-d326e1a10859"), "IT", "Italy" },
                    { new Guid("9f53a74d-f0d9-4fb3-92d0-913518073dfe"), "PS", "Palestine" },
                    { new Guid("a1677fea-8d0a-41e5-854e-3602aaf5555b"), "SR", "Suriname" },
                    { new Guid("a18f7eac-2cbc-42c5-b83e-8e0b69841d09"), "HN", "Honduras" },
                    { new Guid("a195f224-e376-49f1-8cb6-a2b3076479e7"), "TZ", "Tanzania" },
                    { new Guid("a3afb3e7-3a40-4ac1-ac30-a6d59a2583e5"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("a61cbac3-c83d-4eab-b688-5eaeeeb05038"), "KZ", "Kazakhstan" },
                    { new Guid("a62a2052-7684-4652-b98f-c4ebd45129f5"), "CF", "Central African Republic" },
                    { new Guid("aa9593e1-0895-4847-85ba-418ff7cd81b0"), "LY", "Libya" },
                    { new Guid("abf03933-1dac-4c95-873e-bd945b76e7a2"), "MD", "Moldova" },
                    { new Guid("ac76b374-33ab-44ea-a4cc-1387cb7bfbfa"), "CR", "Costa Rica" },
                    { new Guid("ad719300-a00e-47d4-9a97-a966f173e8ae"), "GW", "Guinea-Bissau" },
                    { new Guid("af5040c6-b0c8-4ffc-b6ae-8973081973f6"), "PT", "Portugal" },
                    { new Guid("af80b62a-9b51-4310-bea3-24e206ae0435"), "MG", "Madagascar" },
                    { new Guid("af91e09b-7ff3-4c91-9419-e9d455197658"), "TH", "Thailand" },
                    { new Guid("afb19788-ff05-45be-81b2-67d999726af9"), "MC", "Monaco" },
                    { new Guid("afb321a0-104a-430c-8d04-8229cd1b2c37"), "AF", "Afghanistan" },
                    { new Guid("afe4501b-fe64-4972-ae4b-a96bbb27bbdc"), "AZ", "Azerbaijan" },
                    { new Guid("b15ff395-a74d-43b9-8c41-2aa80d1a26a0"), "QA", "Qatar" },
                    { new Guid("b3ca8b9d-577a-400c-bbc0-a15ee9dd10a3"), "CH", "Switzerland" },
                    { new Guid("bbf928a3-6d5e-49f6-89c9-498a446ed8ad"), "FJ", "Fiji" },
                    { new Guid("bc63f682-bbaa-4198-ac12-c242d40ea61e"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("bda4c52a-06f3-42ff-9b47-db5618043f86"), "TM", "Turkmenistan" },
                    { new Guid("be9501f4-81df-4912-b548-16ced68aa88a"), "UZ", "Uzbekistan" },
                    { new Guid("be9ecc93-29a2-41c2-8c1e-68599c35dc27"), "CM", "Cameroon" },
                    { new Guid("becca01f-40fd-4aab-8e47-3b4f70b47a4c"), "IN", "India" },
                    { new Guid("c10245c5-63f6-4b42-9a91-4b3ce7b4bea0"), "MR", "Mauritania" },
                    { new Guid("c3121554-cb2b-4568-b5d4-b2bf69d9ce38"), "IE", "Ireland" },
                    { new Guid("c316753d-8615-4544-acfc-3828ec1937e3"), "TG", "Togo" },
                    { new Guid("c4cb78ef-52f4-4c4e-b718-8c5796baf286"), "ID", "Indonesia" },
                    { new Guid("c561c268-5d8c-4c41-b012-ccf5c77c7480"), "BY", "Belarus" },
                    { new Guid("c618c91b-0bf3-4c83-a441-c30612a1ff45"), "AU", "Australia" },
                    { new Guid("c6992081-eda1-4fc3-ab70-d194cf5c4e50"), "US", "United States of America" },
                    { new Guid("c7153d47-9e0e-4e1e-9bdf-a24465d69fb1"), "UY", "Uruguay" },
                    { new Guid("c82a2276-3feb-4318-91bf-3e94a7786f8d"), "SZ", "Eswatini" },
                    { new Guid("c9e4baf7-79cb-4834-ae1a-7ad8e448a345"), "DE", "Germany" },
                    { new Guid("ca97e98f-f981-4886-bda6-acf85c4c3d5d"), "TV", "Tuvalu" },
                    { new Guid("cba128a6-10f5-4a44-9841-089e0db2bfbe"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("cbaf255b-72ba-4d94-9adb-76fc53b95713"), "SB", "Solomon Islands" },
                    { new Guid("ce0c783d-7fa4-49d7-ab53-632631ebeb2b"), "TD", "Chad" },
                    { new Guid("d127646e-77c2-4926-bcf6-5a7d2f46a096"), "LV", "Latvia" },
                    { new Guid("d32bb6c6-d00e-43ed-9f4c-f80dd0811243"), "MX", "Mexico" },
                    { new Guid("d48f2b07-474c-4395-aa7c-15cc90b83c40"), "HU", "Hungary" },
                    { new Guid("d571258c-3b62-4b28-8ad7-f66fd1c6b04a"), "SI", "Slovenia" },
                    { new Guid("d610b74b-fc00-49ef-9504-9710be73f1a2"), "VA", "Vatican City" },
                    { new Guid("d7360e6b-a5cc-41fb-93df-55b479cf14a3"), "GN", "Guinea" },
                    { new Guid("dd2e0187-ea26-4e21-a8f1-f19911e71e54"), "DM", "Dominica" },
                    { new Guid("dd36f82c-c9de-43b6-9fdc-0c22fbb0685d"), "MM", "Myanmar" },
                    { new Guid("df3353ba-815d-486e-b812-a06113b5a6a5"), "TJ", "Tajikistan" },
                    { new Guid("e4c0218f-8dd7-4f3c-8a46-da86ac67e556"), "GY", "Guyana" },
                    { new Guid("e4f5b3b9-72f6-4377-8fe5-8a291a3f471b"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("e6f2cb10-4987-4f1c-973c-9fd3fe6f9f46"), "LU", "Luxembourg" },
                    { new Guid("e7cf5ca4-9761-48b9-854d-e651321b1800"), "AO", "Angola" },
                    { new Guid("e9164e09-cc31-4cfd-8d44-c1392dfbc615"), "SE", "Sweden" },
                    { new Guid("ead03201-e794-4181-bf67-2a3d3ddf4b06"), "OM", "Oman" },
                    { new Guid("ebf82b0d-dee8-4da6-ae6e-e50987b7083e"), "NR", "Nauru" },
                    { new Guid("ed353fd6-6b4c-482d-9a1b-8d586c118aa1"), "MN", "Mongolia" },
                    { new Guid("ee815472-4cf1-4be4-bc47-6d28dbfb7cc7"), "BF", "Burkina Faso" },
                    { new Guid("ee8ff7ef-f0c7-4e8f-a773-6639fc0c12eb"), "BW", "Botswana" },
                    { new Guid("eee3efe7-3dee-446a-8990-51cac30b3adc"), "RO", "Romania" },
                    { new Guid("efa94e59-478b-44f3-a734-8375cdcba2d0"), "BZ", "Belize" },
                    { new Guid("f0c60ff6-dd4f-4fa1-9b6e-64cffcd14e0c"), "DK", "Denmark" },
                    { new Guid("f103ea61-4d30-466a-a2fc-bac628882cc9"), "BJ", "Benin" },
                    { new Guid("f44b4157-9b8d-40bc-adde-3c7f675b4653"), "UG", "Uganda" },
                    { new Guid("f59095d3-e745-4ea8-bac9-41332e1c2518"), "NA", "Namibia" },
                    { new Guid("f5f16004-9e4d-4e7f-a20e-36944b095178"), "JM", "Jamaica" },
                    { new Guid("f610c6ce-2f55-4d26-826a-cdee69d99f73"), "IL", "Israel" },
                    { new Guid("f7f1a0ba-26a5-4b9a-9d63-0cc503e8ea15"), "AT", "Austria" },
                    { new Guid("f961c886-285a-45dc-9075-126b42430a37"), "BD", "Bangladesh" },
                    { new Guid("f9a62088-522e-41d6-8718-3a25fcc87d5a"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("f9e12bef-4ec5-4b92-9dd3-291231cda9af"), "ES", "Spain" },
                    { new Guid("fb26826b-b639-4a0b-a541-700908884feb"), "NL", "Netherlands" },
                    { new Guid("fd39fa10-fd48-46b3-a0e6-99a97272e2b8"), "TT", "Trinidad and Tobago" },
                    { new Guid("fd3a0b2d-39cb-4d1a-b5d0-3fa7d6592c0a"), "EG", "Egypt" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("480e0cc3-73d0-4b07-bde8-adfd6f804ae6"), "Male" },
                    { new Guid("91afed81-19a3-4a16-b500-d50e76c8e0e6"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0e1cc096-e4c7-4f7f-9dac-0185028d7b94"), "Emergency" },
                    { new Guid("213cbba6-4e73-492f-b023-7e7553eeb348"), "Oncological Interventions" },
                    { new Guid("27b09e44-f1c9-4d98-99f1-fef1234a1673"), "Exotic and Specialized Interventions" },
                    { new Guid("3752d83c-c6be-4203-93f8-6bfe47050392"), "Therapeutic Interventions" },
                    { new Guid("52f2b1e4-bb34-448f-a598-6ed291c89480"), "Dental Interventions" },
                    { new Guid("614ea707-a330-4ced-bc1b-c07f1009f0cd"), "Diagnostic Interventions" },
                    { new Guid("a23c2fcb-1a30-4ed3-8d80-396723abf50f"), "Postoperative Care" },
                    { new Guid("ce82aaae-cdb0-40a4-b5cd-dd04265d4f06"), "Obstetric and Reproductive Interventions" },
                    { new Guid("ed58be4a-d108-4fd2-bfc0-6b6446004085"), "Preventive Interventions" },
                    { new Guid("f03d96b1-3559-4ebc-9c13-2c8ed4fe8b71"), "Surgical Interventions" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPets_ApplicationUserId",
                table: "ApplicationUserPets",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserBookings_AspNetUsers_UserDetailsId",
                table: "ApplicationUserBookings",
                column: "UserDetailsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserBookings_Bookings_BookingId",
                table: "ApplicationUserBookings",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
