using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixPKAspNetUSerTokensName3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPets_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserPets");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPets_Pets_PetId",
                table: "ApplicationUserPets");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPet_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserPet");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserPet_Pets_PetId",
                table: "ApplicationUserPet");

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
        }
    }
}
