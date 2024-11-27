using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00eb9cfc-a67f-4cae-8c20-413e38d28a88"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0494e217-99b8-4fb6-a386-c2e72f286891"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("05994a6e-2869-40bf-a142-6e5bee195e86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07b70c21-bd31-4227-bc49-a738deb8dbe1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07c6f8ff-a06f-44f7-8063-5d4d3ebefc07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0ad04faa-94a5-4999-8c6c-667664ad9081"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0ef398b1-f17e-44bf-ab45-72b7bae82c69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f7f40f9-f220-4139-8e1e-ac0a03a9008e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("106a46eb-c17b-4f79-bfb4-e1c277999472"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11a250e4-bbcc-48ec-b2db-3dc26be0ce87"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("149908da-2ef3-4a13-82f7-bc14a224ec49"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("169d7652-3ab2-4ca9-9614-1a56447a87ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17782260-e2b8-4de4-b735-aa4f17aa0436"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("191392f1-11d0-4b42-8c8e-d2a3544972dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("193f4cc9-0152-4c62-ae2b-78c898b932ee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a163998-0ada-4bd5-8c0d-fa3aa1c0172c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d8178d2-52dd-4a61-9f25-1aaf139fb5e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e3501fa-fb9f-4713-973b-c0669af2413c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21294c5b-91e7-4afc-9336-bc8e1bd00223"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2323edfd-6fb3-49b0-bc60-238a30603d5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23c781ac-083f-45d3-bbdb-17fa79fed4a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("245cd92f-4c9f-4d50-b032-ad94a8e30ad6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25b98d0b-0c77-420d-b4b8-f1ea9717f36a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2676bcec-fa96-4afe-96cf-132dc621098a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28348afa-5f37-4d90-b100-e337d3d73a7c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29ccd8a8-cf8a-44b1-a570-a602c2056dc2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a6c32e6-b43b-49d1-a363-f8ce33428213"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a7a0a5c-35ef-4709-a11c-00249460ce95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2b175e9e-e705-4892-bd2b-1e02b7faf689"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d3f1076-e0fd-456b-b999-24df885b01be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e354dad-3f3d-4bb6-93ef-eb878c34acfd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("342765de-a352-4c2a-8378-463d62b445dc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34640960-e630-4254-8ddd-637f13bb13e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3574cf15-03f3-4f74-a6e6-8caf1d475449"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("370260c8-36c5-4ea8-a040-154c46147302"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b71d1ab-dd43-46ce-aec4-bc90755316b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3bdb4aa0-9029-49e1-be25-8ea91799f3fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3dbbd000-e874-42b0-946f-df126ce1fc34"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f3585b6-1ce7-40bf-8d3c-b76e782e306b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("411c00d3-65ab-4e60-9fc0-6421dc56cc2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41d22161-4ccd-4c0b-8d08-b94660eb8ca6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45de4713-fb79-4c17-8f65-20d455b70bcc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("489a9628-e748-453f-8753-0ed6e3eb35c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("491cc17d-bcfd-4a1a-a32b-a4c545086920"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b6e49a7-32ca-4be0-9738-4dbaf8bf8149"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4cade121-72af-43b6-8406-d8d51cfb438b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d9b56dc-425d-4226-b6ac-48ec1f6e4050"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ec220d2-40c6-4fa5-bb87-abeb839048a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ffc0572-d64d-4ed7-8793-d8edd0084db3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("508a89d4-3372-44f4-9013-9ec331a25aef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("50acf98a-8467-4979-b98b-d537543117de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("523a26ca-3b56-40a8-9f48-7a576b8b3dd8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53c8f761-4b8e-446e-814b-198418df3003"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("565fc558-8ecf-4830-a0d9-2c8367192029"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58e91a1d-65c1-49a0-9cf6-408a7a3caa3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("593100b5-6c9d-4a2e-89a8-8ea19b93a7c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("599fa997-4845-4b4d-9188-96e912c00ce6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a1c0288-2170-4b10-a314-b2f7a42106db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ab00a62-58de-4f8c-b2af-b334c979e2b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5af54ff7-cdae-421a-bf89-9129cf75f1af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c522ef1-b375-4415-9ef2-554ceb6acfcd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d43682d-da62-4e4a-ae6a-3f2c6050d390"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d6b19e2-d56b-4763-958c-56d38df75e99"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5daef371-0eb2-456c-82ab-9d6fde4f234b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f5bbc9d-621b-4c87-921f-e3967cb2d7b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6212d483-fef2-4ad3-bb50-a3425849a13e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("62258b68-c9c8-43b4-86f7-902ec02e769f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("627324c3-39fa-4ca4-9979-1ee087f5b54a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("637480d1-c58d-48f0-b1ec-7924ff9e8b8d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("637bca74-5c46-4f3c-b1cd-8fdfbf233621"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66ac5463-41ca-4797-a079-f28ed3dbbd35"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("671cbeed-f1a7-478d-88fb-89227444e9fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6751b941-a50a-48ac-bea4-80480f8c4a8b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a50561c-222b-4881-a459-300afacf1822"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ab3a5ab-fd3a-4917-bf7c-a1fb8c8a13da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6dc7cebc-4d8b-43d7-812d-666131a5995c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72481c76-8042-41e4-b7eb-3dafeab945e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72a83406-f715-40c6-85db-a44413c949ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("732d9623-f430-4d80-aae3-39a4c89d7002"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("737a7c6a-4cbc-4214-8d5a-56b2945b722c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73e4a82c-bedc-4ac2-8fe2-096652c047a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7544ef88-ecb1-4c10-91c1-ea5ce67f1ef1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78de492b-3f57-48b6-8987-8ebd0ac57b94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("792f9b10-8b68-4799-a188-f21ca4bf33f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a5d6659-1531-426c-9dff-2f40226a4f3e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7adff02a-0fea-469e-bd0f-acbd48592269"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b64bdcd-f219-41e9-847b-76c929b57550"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7caee84c-c0f7-4734-9834-f9360a4fce74"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7dbf4435-4055-4b2c-b606-ca59c22e2b05"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e6ba29f-5222-475e-bb4b-06b6bac3889b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ec5d023-7331-4def-a3e0-113576e7aede"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7fe68724-eca8-4e72-aa23-e0e8b9a242e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80623035-cee2-4e58-8782-f51fc7c702dc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80fbdc7f-dec0-4894-95be-b36d51f28299"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("812ea8bb-448c-446f-8061-a60a71998169"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81aba926-c08e-4050-aa9e-913cdd6902c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84d59a31-6d6e-4222-a251-0ed91740cf0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85b74c9a-e917-49f9-9ede-01d3fecefb0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85ddf6bd-fe9e-42b1-880f-80a95787e08d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("870a41c9-0ea5-4e14-bd1f-78d28172da30"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8792673c-0fde-4610-be64-93a36f56e298"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("88334ee8-8866-4c03-9e9f-68ffb65de620"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("886371b3-a423-4ce6-89db-e08cb9593e31"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("898259e2-027a-4077-9720-e9ca298a99e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b2389b9-6752-48c9-8681-bcfbffab3b07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d7157bd-07bd-4721-b0b5-439ccb183b71"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ec95acf-7323-4644-8697-1af85bffa1e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8fbfa20c-e508-4eaf-b2af-f40094caf766"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("901a9c81-fb4b-46ab-85ad-792fff0cbf95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9040faa7-8b90-4d2e-95d5-0b621df6fd48"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("917f058a-b654-499f-a50d-585876f78424"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95efc751-804c-4915-92a3-333639cd1bc8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97d19348-e11e-48b7-aa29-ad12e93a8d6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97e2344a-d4b8-43dc-92e6-0565ef6b8406"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98cf4d2f-3a54-4286-9a7d-8257d9d5f9e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99784b5b-bd53-4258-a55d-746fd6317299"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99dbff13-2e37-4bfa-9305-928d8b780990"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99e47240-fcca-4c73-9712-2de45d0d900b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a12028c-d5f9-44ba-bae1-890b7c16e4e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b0681ec-e109-4871-8f14-0ba960a91575"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0512f1f-af71-4b91-b2fa-cc244a5f603c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3376569-6d7f-4c20-a493-af5872dc8516"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a38da1cc-13b6-4f1f-972b-74f66b82d09b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4baa9ee-3f43-4686-8b2e-0980067ad3e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4f58adf-ab08-4c1f-a12e-22ff0717eee7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a544b554-3e97-4814-8c28-35169976db94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a5ea2e2d-79be-433b-b4dc-51695037c838"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a6f88076-70fd-4f45-b786-4160b39fc731"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a730b6e0-0ae9-46ad-8617-5b9e0eb28f47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a777f4db-1a0d-4d30-b65b-e2c923cc7c43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ab842a10-1d24-4818-bb14-fe4af1f8333b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad6d5e69-9d2e-4bd2-bb45-5cf7845c04b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("adc8a136-0e72-4ec2-830e-d4d00185670e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aece16db-cace-40bc-996a-0d544d6d416f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af328372-b751-4cc9-b480-a91c113ae21c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b04c8176-08e1-4cfa-b54c-cb8a8585ac04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b31df56c-3d23-4acf-91e7-9f29e3316e7c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b37725b0-abc3-4a54-8a3a-0cbecb26ff41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3a01fec-c098-4eee-ad3f-4cba949ef020"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4b2d761-4177-4f7c-9de7-aa69e341c9dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b56f30e3-1c40-47ff-9303-3e1c47ea1360"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5dd0629-9326-4223-9bb4-840029d293d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b66df5a8-9d81-4aab-a093-af4ee734a4e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6731013-454e-48eb-a693-7286455e05a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b729497e-2251-485c-b63e-cebe81eef6ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb0216ff-5774-42c0-babd-e8484e991a89"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf1b6645-bf82-4e66-b89c-c4426d6b376b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0353efa-5490-4a4e-8659-954b6e71ac8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c06ba9c0-191e-442a-a4e4-ec781d9c33e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2351194-0f07-418f-ad61-e03b066b4638"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4ebb580-88c4-4185-b9af-94549dc96dc3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5ace8d9-c0de-4f0f-b848-986c4edffab2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5f728a6-3de5-49f9-a33a-51a83bbc64c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c90c4f60-5d39-4cb2-b5d4-cd3f43cfdf94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9b2e4ad-3f12-43f0-a116-6dc216c6b652"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9ed739c-2d71-413f-9c55-8bbd160217c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cbd06371-7a4b-4c78-b6b5-62693858bea3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cbf9303c-2fad-48cb-a4c4-9c887fe008bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc8ca35d-d62f-41ee-8428-b8f6865a73cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd52029c-8390-4f07-af3c-5b2d639fe593"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdd5c6c5-7621-47f5-9ebe-619905bcef62"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf83426f-ba4a-48c6-83fb-12b8c32c02ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1756c7a-7953-4f13-89c2-c6678600618d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d8bbb8dd-fe44-4131-af9a-0c7b87da2e38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9126c83-a234-4d1c-a91a-5d5881bbd0e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dbc8d9ad-c576-4fee-804f-f4d37b807de7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dbf6b696-4571-4d9b-9044-efb6fc218920"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df146bb4-a312-4b33-8eef-1ad9b8d70eb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df166fda-358c-4935-91e5-69ddcf441b4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df1ab81a-83fd-4a98-9342-04a8b31cd176"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dff24425-1038-494a-81cb-e4687bafd56a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e48708a7-a12d-442e-bf3c-8e401ea544d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e90f71fa-76e0-4df4-8ec9-2564e8560540"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea2571ab-8fd2-48a5-a726-80c702fc910a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea2725ae-3059-4b25-8108-f55d592dd148"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ebfcc8f1-3970-41d9-a3fc-7c1aa0b16651"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec447547-4bff-42b2-adad-a2248c98c3a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed9dd234-f31d-465b-ae77-37addbc44997"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1009394-56f2-410b-aa83-a36ce07c652f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f33ce01f-a093-4278-8660-d7b622f8af41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3a056a1-c1c4-43e8-8688-efb4bc820965"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3db8671-69e0-496a-9c50-57175b4c8fee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f569f026-cb8b-4c7d-b794-76f47f6caa98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f61ad253-e786-45bd-a974-c95c1bae4938"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f6318b45-dbdd-4167-8869-c7c090bc04ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f6567a82-fd8e-46c2-b6d6-a246767308f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f6fa45b1-3070-422c-beef-2577b1de506c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f8153563-e24d-4a70-96a7-9d61fe2bdd4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f828da13-40d3-49c1-aa0b-6c59fad6875a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fae7cc86-13fe-4adc-9e60-ef4a273f6339"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faf78a84-c6b1-4d2a-a713-18dd58b2e33a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb7b56d6-1bed-4e27-b7d5-913e8687857c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe0e4468-a731-4722-9074-f7d294c7c661"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ffec1e7d-1211-4226-8371-5d38e11a140d"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("8de261ba-7c2b-436c-9a13-2615e366771b"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b6c287fa-0e6c-47d1-a7f7-ed950cf56002"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("077356f1-c03b-4b32-9666-87ecd95dcf03"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("1504e3fb-083a-4921-9df7-cd22142e153e"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("233831b9-a026-48d7-85a9-d7d1d9df9598"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("2f4d6caa-977d-4606-81be-353b4d413a8a"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("4e04ef35-19aa-480c-8ecb-f29c18f391d7"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("62826788-9c85-40ab-ac0d-5d48d009b339"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("723d9d4d-5b73-482b-88d8-14b9136c8f35"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("8d17d6db-c184-4ad1-ac17-bd5548b19c88"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("a9c247f1-e2b6-4db8-9807-e2c3888b2ce2"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("be2c20b7-6491-4617-a246-3f5d8edb89a0"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("003e3ae7-3b30-41c6-8e43-b7507b318b6b"), "ME", "Montenegro" },
                    { new Guid("0098eeb7-353a-4077-a0a0-b2495dbe733b"), "WS", "Samoa" },
                    { new Guid("026f3e67-e2b2-4ca9-bba2-23443c03bc87"), "RW", "Rwanda" },
                    { new Guid("03229357-8dda-47a4-926e-c07465d1ed94"), "HT", "Haiti" },
                    { new Guid("049541f5-8247-4c1b-ab2d-c2d8311eec77"), "VN", "Vietnam" },
                    { new Guid("058db30f-aa91-405f-af9d-64409b61ec29"), "BY", "Belarus" },
                    { new Guid("064f1854-bb48-4059-9789-6df04100d107"), "PK", "Pakistan" },
                    { new Guid("08a8ffb2-9301-477d-9949-1460f0f1c2bb"), "TH", "Thailand" },
                    { new Guid("098cd6f4-4d92-44c7-a0c8-a63356d94d6c"), "TM", "Turkmenistan" },
                    { new Guid("0a8ff0a8-1b13-4d92-a196-5e2b7f72e8bf"), "EC", "Ecuador" },
                    { new Guid("0cc6eaa6-4248-438d-bf0f-db7bceeb683d"), "SG", "Singapore" },
                    { new Guid("0d06f894-e1d5-4a77-b5a2-89a4b4f35bc9"), "PY", "Paraguay" },
                    { new Guid("0d25beb6-ae87-4df9-8739-0406f454feca"), "JM", "Jamaica" },
                    { new Guid("0eaf6439-944c-4016-b10f-13b7b5b1de4f"), "ZM", "Zambia" },
                    { new Guid("0f451ed3-c1fc-4dee-8c97-05483aa37593"), "RS", "Serbia" },
                    { new Guid("11c29e32-514a-46e1-9969-79fab01015db"), "MD", "Moldova" },
                    { new Guid("11d693e9-0dc9-4a81-8692-0e7ad3b09fa9"), "BS", "Bahamas" },
                    { new Guid("12bce4f3-4932-42e0-8bd2-01e909d27733"), "NL", "Netherlands" },
                    { new Guid("12da4e63-1ce4-4760-a7a2-f1b84f982c0f"), "MW", "Malawi" },
                    { new Guid("131b084b-cec3-4e2b-8b9a-08945e3fd265"), "CN", "China" },
                    { new Guid("15185b26-f168-4486-9536-84c63c943922"), "TZ", "Tanzania" },
                    { new Guid("15222355-cb52-4fc3-a03b-e21a593020d6"), "UY", "Uruguay" },
                    { new Guid("1628eeb5-e476-4238-a450-25b8ee2b448c"), "AR", "Argentina" },
                    { new Guid("18bad55f-5e17-43f7-96a4-15a7aed51a06"), "SL", "Sierra Leone" },
                    { new Guid("19a864e6-f2d9-42bf-84f2-3a48fcce2834"), "AL", "Albania" },
                    { new Guid("1df4d5a0-ce38-4dc5-8970-029c6f405e9c"), "CO", "Colombia" },
                    { new Guid("20723c3b-c146-4e47-9f07-63402f561d90"), "LA", "Laos" },
                    { new Guid("23b9920f-f46d-4835-b869-f5e2a09f6173"), "GY", "Guyana" },
                    { new Guid("2501876a-00ee-4469-b564-b542efeffa87"), "IR", "Iran" },
                    { new Guid("257208a8-49e6-4411-a8de-1aaf74dcf4c9"), "DK", "Denmark" },
                    { new Guid("27a55de0-ec84-438e-9cbc-476ca3010424"), "GD", "Grenada" },
                    { new Guid("2873ee84-5c24-404c-a142-e4377650e74a"), "AE", "United Arab Emirates" },
                    { new Guid("29951877-bfe8-4b78-851d-27abb9282461"), "UZ", "Uzbekistan" },
                    { new Guid("2e3b0754-ae54-41a6-ad08-903f3a91921a"), "BB", "Barbados" },
                    { new Guid("2ee95d97-d81c-4a2b-bc5b-dc286dd4c4b0"), "OM", "Oman" },
                    { new Guid("2f576cfc-1da9-4d78-ac15-8824905c2181"), "KM", "Comoros" },
                    { new Guid("310142c3-ec5e-4ebb-911c-7f3cf18acf40"), "ZA", "South Africa" },
                    { new Guid("322a2ff8-fbde-41d3-a7d3-8b459cf82c6d"), "SZ", "Eswatini" },
                    { new Guid("3517ed6b-4aaf-488d-8fd1-e1aa490f6456"), "AG", "Antigua and Barbuda" },
                    { new Guid("35ace2b0-e571-4918-b6bf-eb29fdd712a0"), "CY", "Cyprus" },
                    { new Guid("36f151a4-6dc3-4582-ad41-a84eeba29295"), "GA", "Gabon" },
                    { new Guid("3798458c-f025-4f79-9673-e22c0b54bdf0"), "CM", "Cameroon" },
                    { new Guid("3b410264-a5e1-4143-9a17-2c3dc425b94e"), "BJ", "Benin" },
                    { new Guid("3cd9465c-b009-42e2-900d-b2937e8c0db6"), "BD", "Bangladesh" },
                    { new Guid("3d41c763-45ac-4d21-bffe-debe9af1d8d9"), "FI", "Finland" },
                    { new Guid("3dc9fab5-e08f-44a4-9455-b70e5d54cf1e"), "MA", "Morocco" },
                    { new Guid("41cca822-b1c7-43ea-8814-02bcde6f0fd2"), "HU", "Hungary" },
                    { new Guid("4398211d-9064-483a-8825-766c0e15c50d"), "MH", "Marshall Islands" },
                    { new Guid("45694d80-312d-4aff-aa17-633aac8b0b50"), "BH", "Bahrain" },
                    { new Guid("48597b4b-8c94-4615-901f-472958971dd6"), "MU", "Mauritius" },
                    { new Guid("4963bdec-399b-4085-8f60-c12100c9cab7"), "ER", "Eritrea" },
                    { new Guid("4a6dd55c-2c38-49f1-9945-29145d3d4400"), "YE", "Yemen" },
                    { new Guid("4bd85101-b6eb-4df4-96a9-caa06eeb0a95"), "PT", "Portugal" },
                    { new Guid("4c44c45b-1a8f-48b8-9ac0-c456c14b6f15"), "KI", "Kiribati" },
                    { new Guid("4ccb314c-d4a6-4c89-a7c6-ae617d1c4895"), "LU", "Luxembourg" },
                    { new Guid("4d0a08ec-8f87-41c8-b9ee-b07771702172"), "MV", "Maldives" },
                    { new Guid("4f24d5e6-b41d-4bab-90e2-2fb40e765b0f"), "JP", "Japan" },
                    { new Guid("529afd00-76bf-43e6-931a-e04fff50b8fc"), "GE", "Georgia" },
                    { new Guid("53b3321b-2fd0-43fa-aa09-362692d536f7"), "SI", "Slovenia" },
                    { new Guid("54a91c6a-9aae-4ee8-a29b-483e4fac2f5c"), "KG", "Kyrgyzstan" },
                    { new Guid("56c2f6c3-f9ca-4ada-bd86-168a8d4d542a"), "HN", "Honduras" },
                    { new Guid("5760074d-edea-4280-be8b-e5bb9826fb37"), "NR", "Nauru" },
                    { new Guid("58336bfd-e61a-45ad-afa5-810fc4577e8c"), "LB", "Lebanon" },
                    { new Guid("5ae9911c-a7fa-4745-9134-2790c2182b23"), "LT", "Lithuania" },
                    { new Guid("5ba3ecf9-021f-4490-9ae9-ef2e678c0805"), "CU", "Cuba" },
                    { new Guid("5d681dd4-9b4e-4228-b5c2-d8648c289ee4"), "BF", "Burkina Faso" },
                    { new Guid("5dbe31a7-6ef0-428b-89a4-9b99580cdb71"), "BN", "Brunei" },
                    { new Guid("60f838b9-e498-46ed-a6f6-5711fa30f113"), "CF", "Central African Republic" },
                    { new Guid("61904653-b802-4ed3-9447-e23dbe5477ba"), "PG", "Papua New Guinea" },
                    { new Guid("62cc4b49-1c16-4a31-8901-796caadcb915"), "KR", "South Korea" },
                    { new Guid("639369a5-d71b-4880-a565-397e1e804a3c"), "KW", "Kuwait" },
                    { new Guid("63b1a34a-aaa9-47da-bfdd-df554161f512"), "DE", "Germany" },
                    { new Guid("64f937ff-4335-43b9-9dc6-4815bc9a3d93"), "TL", "Timor-Leste" },
                    { new Guid("67a97fca-e657-4f42-8cd7-8c98101d2160"), "PS", "Palestine" },
                    { new Guid("6a0dbe74-6337-4fc6-9ac4-cc66951e125d"), "VE", "Venezuela" },
                    { new Guid("6a1c0055-40a0-4345-b485-5a413161479f"), "KZ", "Kazakhstan" },
                    { new Guid("6ab025e7-1df2-49c7-8046-0893c63f7b8f"), "BE", "Belgium" },
                    { new Guid("6edcf830-6433-49d0-b6c1-e2063aab6908"), "MT", "Malta" },
                    { new Guid("7109734a-dc95-45f7-9ddd-7ebaf732cd8a"), "NP", "Nepal" },
                    { new Guid("715a92e8-65b3-47cd-a623-f01b4bab12c1"), "SM", "San Marino" },
                    { new Guid("7253b256-0630-4551-b54a-205fbf0ad4a3"), "GR", "Greece" },
                    { new Guid("72aab703-41db-4cb5-b37e-8441b108d3b0"), "QA", "Qatar" },
                    { new Guid("72d77f55-4fb8-430e-9839-e2a4a6624f88"), "BI", "Burundi" },
                    { new Guid("7390dfd1-aafa-4d16-b80b-307fb6d4063b"), "MX", "Mexico" },
                    { new Guid("760b4297-d146-48f7-a881-9d99be78d684"), "ML", "Mali" },
                    { new Guid("76c7cfcf-7d42-4b6c-b361-3843dbc51e68"), "HR", "Croatia" },
                    { new Guid("783152d3-8dc6-4b69-bcf7-3c43e2a378ca"), "SK", "Slovakia" },
                    { new Guid("7949a9f8-afa4-49f3-89c8-c1f1aa59cc7b"), "DM", "Dominica" },
                    { new Guid("79921762-b7fa-49ad-abd0-575acff623d1"), "IL", "Israel" },
                    { new Guid("7b3db7d1-d09c-4a00-90ae-0abd4b01a872"), "AT", "Austria" },
                    { new Guid("7cceb8ce-88dd-4021-8098-8be9c778618e"), "EG", "Egypt" },
                    { new Guid("7d85848d-2ab7-4f40-b4d3-a8cbc52f8df1"), "NG", "Nigeria" },
                    { new Guid("815f5752-741d-4c06-b50c-6d3318035d3e"), "CH", "Switzerland" },
                    { new Guid("82daf210-f02d-4ea6-a9de-c1b7f81e2119"), "BG", "Bulgaria" },
                    { new Guid("846f6301-5601-4ba7-9106-e08a52e2c850"), "KH", "Cambodia" },
                    { new Guid("847febb5-160e-490a-9eb9-ed1014537546"), "SY", "Syria" },
                    { new Guid("85a5889e-0f92-4b7e-a53d-2208c9031ecd"), "SS", "South Sudan" },
                    { new Guid("87d84eec-6c94-40d9-a65c-810d1c9adfcf"), "MR", "Mauritania" },
                    { new Guid("88f655ec-9189-4ff6-8c3e-9ec5f0f2eaa3"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("8952cc63-20c3-4993-84e3-2f0529658254"), "CR", "Costa Rica" },
                    { new Guid("89c9823e-bce8-460d-831c-3b3cf0a433a3"), "MC", "Monaco" },
                    { new Guid("8ae52938-caa4-45a9-946a-100eb56ebc44"), "GN", "Guinea" },
                    { new Guid("8ef36e61-8124-445e-8447-0e8dc2e815cd"), "IN", "India" },
                    { new Guid("8ffa7735-a98d-431e-b63b-d807b6a5d291"), "FJ", "Fiji" },
                    { new Guid("90c61265-5458-43e1-8569-e9f76db87ef8"), "SO", "Somalia" },
                    { new Guid("920510ce-522b-48e1-a9b2-6f3b9730217e"), "MK", "North Macedonia" },
                    { new Guid("93a3f778-a0dc-43d3-8d94-4b16fbfc2d41"), "GM", "Gambia" },
                    { new Guid("9509d392-d9bd-4514-b7c1-e0710679dcc4"), "MG", "Madagascar" },
                    { new Guid("963af0b7-bf43-4483-b6b0-e0c2936f123f"), "BT", "Bhutan" },
                    { new Guid("963cadc6-425a-40b6-991d-8230639d333a"), "SC", "Seychelles" },
                    { new Guid("9712a6b3-60c1-40aa-bb84-ba95ff972584"), "LY", "Libya" },
                    { new Guid("98a92799-20db-4310-9e3c-9105f653b34a"), "PW", "Palau" },
                    { new Guid("9cae51a7-ede0-4ff1-ba32-ad4de26dfdd9"), "TG", "Togo" },
                    { new Guid("9dd42252-fe64-46c4-ae3a-e8a94a72ff0f"), "CL", "Chile" },
                    { new Guid("9fcb0bc1-f405-420e-8b6d-d5a310e1a984"), "GH", "Ghana" },
                    { new Guid("a142efce-f45b-4375-94fe-117cbba0a694"), "TO", "Tonga" },
                    { new Guid("a1712bbd-4e7f-4a14-bb93-8cd7e4c087ad"), "AO", "Angola" },
                    { new Guid("a38ad48a-63da-42c7-97b0-9bdd1dacdd00"), "SD", "Sudan" },
                    { new Guid("a3b64eff-6d2c-4e7d-be92-b7cb47b408a3"), "NI", "Nicaragua" },
                    { new Guid("a54d5c9a-cfbe-46d0-ac56-7d95af138428"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("a64934f7-035f-4e91-81b3-b152057f6f04"), "VA", "Holy See" },
                    { new Guid("a81248a1-e81a-416b-9ae7-6f76b8e8159d"), "MZ", "Mozambique" },
                    { new Guid("a8a8381d-e6fa-4017-ae3b-e5666a907640"), "EE", "Estonia" },
                    { new Guid("aaf21fb4-e37d-4d3a-aec9-3a302164e72b"), "JO", "Jordan" },
                    { new Guid("acd41997-072f-48a5-ad48-38513dc136c0"), "IQ", "Iraq" },
                    { new Guid("ad73bcd8-c95b-4c6d-8392-13302cd1aaeb"), "SB", "Solomon Islands" },
                    { new Guid("b0a2a7bc-3a43-44e4-8c49-cfe50a08cf0c"), "DJ", "Djibouti" },
                    { new Guid("b25f6be2-f601-4838-9764-b01d54eaffa7"), "GQ", "Equatorial Guinea" },
                    { new Guid("b27a6e74-931d-410a-b2f5-3dd7cf249704"), "SE", "Sweden" },
                    { new Guid("b2c1a795-559f-40c7-be6b-035c1d8daf76"), "PA", "Panama" },
                    { new Guid("b2fd56ed-140f-4688-b816-964cf035e752"), "GB", "United Kingdom" },
                    { new Guid("b3515988-887a-4f1d-bb3f-6ee243b3e11e"), "LC", "Saint Lucia" },
                    { new Guid("b464dbdd-a7dc-4f08-baf1-f81e2979f577"), "SA", "Saudi Arabia" },
                    { new Guid("b4e07594-84dd-4da2-9a5e-baf5884c3ceb"), "LS", "Lesotho" },
                    { new Guid("b4f50cc2-c29b-40f3-a188-d2b78af574e8"), "KP", "North Korea" },
                    { new Guid("b6081cd4-e7ea-4ba2-b953-a2401853c3e1"), "BR", "Brazil" },
                    { new Guid("b6566653-7571-4d0f-970a-b43475545f01"), "TJ", "Tajikistan" },
                    { new Guid("b676cd0a-73fe-42fd-9ecb-9900d025f06c"), "LV", "Latvia" },
                    { new Guid("b6e4ab32-2070-473f-8e13-ab641308bb51"), "SN", "Senegal" },
                    { new Guid("b8b6cb73-36c1-4da7-9f0c-9e9475fbf4f1"), "BZ", "Belize" },
                    { new Guid("b8c60656-0ee6-466f-a768-7d2112aaeeda"), "PE", "Peru" },
                    { new Guid("b9e2e305-a497-4158-8f4b-237f2043b701"), "CV", "Cabo Verde" },
                    { new Guid("babd6b28-56d9-489e-8a30-29939c167ce6"), "GT", "Guatemala" },
                    { new Guid("bc257f53-ec22-49d0-b7c4-99861f569646"), "SR", "Suriname" },
                    { new Guid("bcd43225-caf2-4811-bd2b-3a32144c6eed"), "MM", "Myanmar" },
                    { new Guid("bdfd89a7-d483-4764-90d4-208d9a7a1626"), "IE", "Ireland" },
                    { new Guid("be3c0b42-a5e2-4a18-9218-3dca009c5919"), "DO", "Dominican Republic" },
                    { new Guid("c1857432-835f-4a82-aa12-69da58ca7211"), "ES", "Spain" },
                    { new Guid("c41156e6-0afc-4967-b5c2-3c75e8396491"), "PL", "Poland" },
                    { new Guid("c5aa652b-33ed-474a-9a2b-c5f86cc21ec1"), "UA", "Ukraine" },
                    { new Guid("c9b5070b-3d9e-453f-ab18-893217b23a0d"), "GW", "Guinea-Bissau" },
                    { new Guid("cac94e01-c66b-4cf7-89eb-29091bac9a30"), "FR", "France" },
                    { new Guid("cad0463b-5432-4cec-baaf-a28f29369f95"), "ET", "Ethiopia" },
                    { new Guid("cbf48cc1-8d62-4e59-b027-cec7d7e846f1"), "FM", "Micronesia" },
                    { new Guid("cca25cde-879e-4f03-8f48-c614282608d1"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("cd87c382-290c-4250-8910-122b628e04c7"), "IS", "Iceland" },
                    { new Guid("cdd4f66f-459c-4d68-a124-a1f99fa08dbf"), "ID", "Indonesia" },
                    { new Guid("cdfc339a-fe6c-4b6e-a95e-0d5ec4968e6f"), "TV", "Tuvalu" },
                    { new Guid("d05e10c9-8259-4be8-873f-d0a51019cb63"), "AF", "Afghanistan" },
                    { new Guid("d1ea2f25-886c-4f70-b624-b14bd05d48bb"), "VA", "Vatican City" },
                    { new Guid("d32d3e9b-a617-41a6-bd05-992853846596"), "ZW", "Zimbabwe" },
                    { new Guid("d4d3df14-3187-4470-9645-e44395a3ac12"), "TN", "Tunisia" },
                    { new Guid("d67afbd0-e3a9-4044-94ae-7be487d2842d"), "SV", "El Salvador" },
                    { new Guid("d6aaaeb5-f73b-4c1c-b503-cc9f5f736dc0"), "AM", "Armenia" },
                    { new Guid("d80142dd-36ac-462c-b23a-93f86a306fef"), "LK", "Sri Lanka" },
                    { new Guid("d8c07df2-4384-409a-9772-7c0af2bc9c06"), "LI", "Liechtenstein" },
                    { new Guid("d91703c7-8145-4829-9a22-25ddd42a5bfe"), "IT", "Italy" },
                    { new Guid("dd9dc332-9e46-456d-8162-1ab4d90a096b"), "NO", "Norway" },
                    { new Guid("de5c368f-0d78-47eb-a05e-582ec2a1197e"), "NA", "Namibia" },
                    { new Guid("e01c6395-26a6-44ad-8d35-2b45ff9ecea3"), "TD", "Chad" },
                    { new Guid("e05d3aa4-b307-4ca1-9289-a1788d74bfef"), "AD", "Andorra" },
                    { new Guid("e0c44208-f9e8-4d59-a6d2-d8e7b5551664"), "AZ", "Azerbaijan" },
                    { new Guid("e4c97092-ce85-4beb-b0d9-b6959efd5757"), "LR", "Liberia" },
                    { new Guid("e733d53c-0478-42b4-bef7-c66cc970d2d8"), "PH", "Philippines" },
                    { new Guid("e8906f35-6b49-4416-bfdd-2e8bc5489aa4"), "AU", "Australia" },
                    { new Guid("ea0d6f4a-baa4-46a2-91a7-014d1e9ab7fa"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("ef4d6d26-6c8c-4ee5-ac89-c79bd4d6aa4a"), "BW", "Botswana" },
                    { new Guid("ef5a0193-b178-496c-a810-1c3cab772763"), "BO", "Bolivia" },
                    { new Guid("efbf1295-603c-4ec9-a86d-4b848535c004"), "MN", "Mongolia" },
                    { new Guid("f110e1ac-8fdc-4f8b-af54-570d9f9d61a0"), "NE", "Niger" },
                    { new Guid("f1ef5fbb-8405-420e-a4d5-0a046a40b779"), "ST", "Sao Tome and Principe" },
                    { new Guid("f28ed9a3-59bd-413e-9e97-32f9b43686e5"), "VU", "Vanuatu" },
                    { new Guid("f4a0d6d8-d43b-4288-9cb4-d05f54604df9"), "US", "United States of America" },
                    { new Guid("f5efa255-d59f-4634-90d5-e6bf01445ef2"), "RO", "Romania" },
                    { new Guid("f6810a4a-63e5-4d8c-8e97-4d3ea8a299f2"), "TR", "Turkey" },
                    { new Guid("f870ae79-6a9e-416e-9bd9-1d8d74b110e5"), "MY", "Malaysia" },
                    { new Guid("f9a608b8-dd08-423a-9d68-18ad09bcd06c"), "TT", "Trinidad and Tobago" },
                    { new Guid("fae3c389-607c-4ef7-b5b8-c061fdb51e81"), "DZ", "Algeria" },
                    { new Guid("fb7d79fb-e295-42b5-a1a7-868553d36c2b"), "RU", "Russia" },
                    { new Guid("fc720623-5275-4a92-895e-14f0cf6db5e7"), "CA", "Canada" },
                    { new Guid("fcff2167-a128-4996-a203-f6273a053421"), "UG", "Uganda" },
                    { new Guid("fd3b53a8-30e8-4fa6-ba91-b45009bfa584"), "NZ", "New Zealand" },
                    { new Guid("fd826b32-fbc6-4916-944c-a73621e15640"), "KE", "Kenya" },
                    { new Guid("fe5e9bcb-12f9-4987-a333-d245d263f057"), "BA", "Bosnia and Herzegovina" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c0399b6e-9536-4ccd-a991-d5aa0dbd4420"), "Female" },
                    { new Guid("fe459699-464f-4e3a-9011-3f9b499e165b"), "Male" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1d13ed43-7cd0-4c53-84ed-e08ac5227914"), "Diagnostic Interventions" },
                    { new Guid("4f4f6543-b099-4e49-9bf8-e84b6514a243"), "Obstetric and Reproductive Interventions" },
                    { new Guid("66638c20-d9aa-4388-892a-5d3305679538"), "Emergency" },
                    { new Guid("6c32b81a-528c-4b4d-b0d6-6a813219271a"), "Surgical Interventions" },
                    { new Guid("acad3317-f8cc-4d95-9d15-2d001a18b349"), "Exotic and Specialized Interventions" },
                    { new Guid("b1fb17c5-7ee8-475d-9e86-b48b86e9feb1"), "Dental Interventions" },
                    { new Guid("b2bafe27-2400-4e6c-b98c-f49313d98d3d"), "Postoperative Care" },
                    { new Guid("c8df327b-92c4-4208-bb8a-019d24160579"), "Oncological Interventions" },
                    { new Guid("e9c17a2c-1fe9-497b-9236-874da20379ea"), "Preventive Interventions" },
                    { new Guid("f5d9a679-cc7a-472f-8c55-9a5e1016faa2"), "Therapeutic Interventions" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("003e3ae7-3b30-41c6-8e43-b7507b318b6b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0098eeb7-353a-4077-a0a0-b2495dbe733b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("026f3e67-e2b2-4ca9-bba2-23443c03bc87"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03229357-8dda-47a4-926e-c07465d1ed94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("049541f5-8247-4c1b-ab2d-c2d8311eec77"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("058db30f-aa91-405f-af9d-64409b61ec29"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("064f1854-bb48-4059-9789-6df04100d107"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08a8ffb2-9301-477d-9949-1460f0f1c2bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("098cd6f4-4d92-44c7-a0c8-a63356d94d6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a8ff0a8-1b13-4d92-a196-5e2b7f72e8bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0cc6eaa6-4248-438d-bf0f-db7bceeb683d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d06f894-e1d5-4a77-b5a2-89a4b4f35bc9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d25beb6-ae87-4df9-8739-0406f454feca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0eaf6439-944c-4016-b10f-13b7b5b1de4f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f451ed3-c1fc-4dee-8c97-05483aa37593"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11c29e32-514a-46e1-9969-79fab01015db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11d693e9-0dc9-4a81-8692-0e7ad3b09fa9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12bce4f3-4932-42e0-8bd2-01e909d27733"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12da4e63-1ce4-4760-a7a2-f1b84f982c0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("131b084b-cec3-4e2b-8b9a-08945e3fd265"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15185b26-f168-4486-9536-84c63c943922"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15222355-cb52-4fc3-a03b-e21a593020d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1628eeb5-e476-4238-a450-25b8ee2b448c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18bad55f-5e17-43f7-96a4-15a7aed51a06"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19a864e6-f2d9-42bf-84f2-3a48fcce2834"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1df4d5a0-ce38-4dc5-8970-029c6f405e9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20723c3b-c146-4e47-9f07-63402f561d90"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23b9920f-f46d-4835-b869-f5e2a09f6173"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2501876a-00ee-4469-b564-b542efeffa87"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("257208a8-49e6-4411-a8de-1aaf74dcf4c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27a55de0-ec84-438e-9cbc-476ca3010424"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2873ee84-5c24-404c-a142-e4377650e74a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29951877-bfe8-4b78-851d-27abb9282461"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e3b0754-ae54-41a6-ad08-903f3a91921a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ee95d97-d81c-4a2b-bc5b-dc286dd4c4b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f576cfc-1da9-4d78-ac15-8824905c2181"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("310142c3-ec5e-4ebb-911c-7f3cf18acf40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("322a2ff8-fbde-41d3-a7d3-8b459cf82c6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3517ed6b-4aaf-488d-8fd1-e1aa490f6456"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35ace2b0-e571-4918-b6bf-eb29fdd712a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("36f151a4-6dc3-4582-ad41-a84eeba29295"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3798458c-f025-4f79-9673-e22c0b54bdf0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b410264-a5e1-4143-9a17-2c3dc425b94e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3cd9465c-b009-42e2-900d-b2937e8c0db6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d41c763-45ac-4d21-bffe-debe9af1d8d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3dc9fab5-e08f-44a4-9455-b70e5d54cf1e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41cca822-b1c7-43ea-8814-02bcde6f0fd2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4398211d-9064-483a-8825-766c0e15c50d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45694d80-312d-4aff-aa17-633aac8b0b50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("48597b4b-8c94-4615-901f-472958971dd6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4963bdec-399b-4085-8f60-c12100c9cab7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a6dd55c-2c38-49f1-9945-29145d3d4400"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4bd85101-b6eb-4df4-96a9-caa06eeb0a95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c44c45b-1a8f-48b8-9ac0-c456c14b6f15"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ccb314c-d4a6-4c89-a7c6-ae617d1c4895"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d0a08ec-8f87-41c8-b9ee-b07771702172"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f24d5e6-b41d-4bab-90e2-2fb40e765b0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("529afd00-76bf-43e6-931a-e04fff50b8fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53b3321b-2fd0-43fa-aa09-362692d536f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("54a91c6a-9aae-4ee8-a29b-483e4fac2f5c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56c2f6c3-f9ca-4ada-bd86-168a8d4d542a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5760074d-edea-4280-be8b-e5bb9826fb37"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58336bfd-e61a-45ad-afa5-810fc4577e8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ae9911c-a7fa-4745-9134-2790c2182b23"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ba3ecf9-021f-4490-9ae9-ef2e678c0805"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d681dd4-9b4e-4228-b5c2-d8648c289ee4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5dbe31a7-6ef0-428b-89a4-9b99580cdb71"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60f838b9-e498-46ed-a6f6-5711fa30f113"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61904653-b802-4ed3-9447-e23dbe5477ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("62cc4b49-1c16-4a31-8901-796caadcb915"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("639369a5-d71b-4880-a565-397e1e804a3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63b1a34a-aaa9-47da-bfdd-df554161f512"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64f937ff-4335-43b9-9dc6-4815bc9a3d93"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67a97fca-e657-4f42-8cd7-8c98101d2160"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a0dbe74-6337-4fc6-9ac4-cc66951e125d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a1c0055-40a0-4345-b485-5a413161479f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ab025e7-1df2-49c7-8046-0893c63f7b8f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6edcf830-6433-49d0-b6c1-e2063aab6908"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7109734a-dc95-45f7-9ddd-7ebaf732cd8a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("715a92e8-65b3-47cd-a623-f01b4bab12c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7253b256-0630-4551-b54a-205fbf0ad4a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72aab703-41db-4cb5-b37e-8441b108d3b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72d77f55-4fb8-430e-9839-e2a4a6624f88"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7390dfd1-aafa-4d16-b80b-307fb6d4063b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("760b4297-d146-48f7-a881-9d99be78d684"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76c7cfcf-7d42-4b6c-b361-3843dbc51e68"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("783152d3-8dc6-4b69-bcf7-3c43e2a378ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7949a9f8-afa4-49f3-89c8-c1f1aa59cc7b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79921762-b7fa-49ad-abd0-575acff623d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b3db7d1-d09c-4a00-90ae-0abd4b01a872"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7cceb8ce-88dd-4021-8098-8be9c778618e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d85848d-2ab7-4f40-b4d3-a8cbc52f8df1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("815f5752-741d-4c06-b50c-6d3318035d3e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82daf210-f02d-4ea6-a9de-c1b7f81e2119"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("846f6301-5601-4ba7-9106-e08a52e2c850"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("847febb5-160e-490a-9eb9-ed1014537546"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85a5889e-0f92-4b7e-a53d-2208c9031ecd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87d84eec-6c94-40d9-a65c-810d1c9adfcf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("88f655ec-9189-4ff6-8c3e-9ec5f0f2eaa3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8952cc63-20c3-4993-84e3-2f0529658254"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89c9823e-bce8-460d-831c-3b3cf0a433a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ae52938-caa4-45a9-946a-100eb56ebc44"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ef36e61-8124-445e-8447-0e8dc2e815cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ffa7735-a98d-431e-b63b-d807b6a5d291"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("90c61265-5458-43e1-8569-e9f76db87ef8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("920510ce-522b-48e1-a9b2-6f3b9730217e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93a3f778-a0dc-43d3-8d94-4b16fbfc2d41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9509d392-d9bd-4514-b7c1-e0710679dcc4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("963af0b7-bf43-4483-b6b0-e0c2936f123f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("963cadc6-425a-40b6-991d-8230639d333a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9712a6b3-60c1-40aa-bb84-ba95ff972584"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98a92799-20db-4310-9e3c-9105f653b34a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9cae51a7-ede0-4ff1-ba32-ad4de26dfdd9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9dd42252-fe64-46c4-ae3a-e8a94a72ff0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9fcb0bc1-f405-420e-8b6d-d5a310e1a984"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a142efce-f45b-4375-94fe-117cbba0a694"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1712bbd-4e7f-4a14-bb93-8cd7e4c087ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a38ad48a-63da-42c7-97b0-9bdd1dacdd00"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3b64eff-6d2c-4e7d-be92-b7cb47b408a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a54d5c9a-cfbe-46d0-ac56-7d95af138428"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a64934f7-035f-4e91-81b3-b152057f6f04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a81248a1-e81a-416b-9ae7-6f76b8e8159d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a8a8381d-e6fa-4017-ae3b-e5666a907640"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aaf21fb4-e37d-4d3a-aec9-3a302164e72b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("acd41997-072f-48a5-ad48-38513dc136c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad73bcd8-c95b-4c6d-8392-13302cd1aaeb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0a2a7bc-3a43-44e4-8c49-cfe50a08cf0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b25f6be2-f601-4838-9764-b01d54eaffa7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b27a6e74-931d-410a-b2f5-3dd7cf249704"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2c1a795-559f-40c7-be6b-035c1d8daf76"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2fd56ed-140f-4688-b816-964cf035e752"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3515988-887a-4f1d-bb3f-6ee243b3e11e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b464dbdd-a7dc-4f08-baf1-f81e2979f577"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4e07594-84dd-4da2-9a5e-baf5884c3ceb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4f50cc2-c29b-40f3-a188-d2b78af574e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6081cd4-e7ea-4ba2-b953-a2401853c3e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6566653-7571-4d0f-970a-b43475545f01"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b676cd0a-73fe-42fd-9ecb-9900d025f06c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6e4ab32-2070-473f-8e13-ab641308bb51"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8b6cb73-36c1-4da7-9f0c-9e9475fbf4f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8c60656-0ee6-466f-a768-7d2112aaeeda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b9e2e305-a497-4158-8f4b-237f2043b701"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("babd6b28-56d9-489e-8a30-29939c167ce6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc257f53-ec22-49d0-b7c4-99861f569646"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bcd43225-caf2-4811-bd2b-3a32144c6eed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bdfd89a7-d483-4764-90d4-208d9a7a1626"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be3c0b42-a5e2-4a18-9218-3dca009c5919"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c1857432-835f-4a82-aa12-69da58ca7211"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c41156e6-0afc-4967-b5c2-3c75e8396491"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5aa652b-33ed-474a-9a2b-c5f86cc21ec1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9b5070b-3d9e-453f-ab18-893217b23a0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cac94e01-c66b-4cf7-89eb-29091bac9a30"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cad0463b-5432-4cec-baaf-a28f29369f95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cbf48cc1-8d62-4e59-b027-cec7d7e846f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cca25cde-879e-4f03-8f48-c614282608d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd87c382-290c-4250-8910-122b628e04c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdd4f66f-459c-4d68-a124-a1f99fa08dbf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdfc339a-fe6c-4b6e-a95e-0d5ec4968e6f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d05e10c9-8259-4be8-873f-d0a51019cb63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1ea2f25-886c-4f70-b624-b14bd05d48bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d32d3e9b-a617-41a6-bd05-992853846596"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d4d3df14-3187-4470-9645-e44395a3ac12"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d67afbd0-e3a9-4044-94ae-7be487d2842d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6aaaeb5-f73b-4c1c-b503-cc9f5f736dc0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d80142dd-36ac-462c-b23a-93f86a306fef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d8c07df2-4384-409a-9772-7c0af2bc9c06"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d91703c7-8145-4829-9a22-25ddd42a5bfe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd9dc332-9e46-456d-8162-1ab4d90a096b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de5c368f-0d78-47eb-a05e-582ec2a1197e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e01c6395-26a6-44ad-8d35-2b45ff9ecea3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e05d3aa4-b307-4ca1-9289-a1788d74bfef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0c44208-f9e8-4d59-a6d2-d8e7b5551664"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4c97092-ce85-4beb-b0d9-b6959efd5757"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e733d53c-0478-42b4-bef7-c66cc970d2d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8906f35-6b49-4416-bfdd-2e8bc5489aa4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea0d6f4a-baa4-46a2-91a7-014d1e9ab7fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef4d6d26-6c8c-4ee5-ac89-c79bd4d6aa4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef5a0193-b178-496c-a810-1c3cab772763"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efbf1295-603c-4ec9-a86d-4b848535c004"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f110e1ac-8fdc-4f8b-af54-570d9f9d61a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1ef5fbb-8405-420e-a4d5-0a046a40b779"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f28ed9a3-59bd-413e-9e97-32f9b43686e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4a0d6d8-d43b-4288-9cb4-d05f54604df9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5efa255-d59f-4634-90d5-e6bf01445ef2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f6810a4a-63e5-4d8c-8e97-4d3ea8a299f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f870ae79-6a9e-416e-9bd9-1d8d74b110e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9a608b8-dd08-423a-9d68-18ad09bcd06c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fae3c389-607c-4ef7-b5b8-c061fdb51e81"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb7d79fb-e295-42b5-a1a7-868553d36c2b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc720623-5275-4a92-895e-14f0cf6db5e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fcff2167-a128-4996-a203-f6273a053421"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd3b53a8-30e8-4fa6-ba91-b45009bfa584"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd826b32-fbc6-4916-944c-a73621e15640"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe5e9bcb-12f9-4987-a333-d245d263f057"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("c0399b6e-9536-4ccd-a991-d5aa0dbd4420"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("fe459699-464f-4e3a-9011-3f9b499e165b"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("1d13ed43-7cd0-4c53-84ed-e08ac5227914"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("4f4f6543-b099-4e49-9bf8-e84b6514a243"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("66638c20-d9aa-4388-892a-5d3305679538"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("6c32b81a-528c-4b4d-b0d6-6a813219271a"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("acad3317-f8cc-4d95-9d15-2d001a18b349"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("b1fb17c5-7ee8-475d-9e86-b48b86e9feb1"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("b2bafe27-2400-4e6c-b98c-f49313d98d3d"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("c8df327b-92c4-4208-bb8a-019d24160579"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("e9c17a2c-1fe9-497b-9236-874da20379ea"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f5d9a679-cc7a-472f-8c55-9a5e1016faa2"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("00eb9cfc-a67f-4cae-8c20-413e38d28a88"), "PW", "Palau" },
                    { new Guid("0494e217-99b8-4fb6-a386-c2e72f286891"), "TJ", "Tajikistan" },
                    { new Guid("05994a6e-2869-40bf-a142-6e5bee195e86"), "PK", "Pakistan" },
                    { new Guid("07b70c21-bd31-4227-bc49-a738deb8dbe1"), "DM", "Dominica" },
                    { new Guid("07c6f8ff-a06f-44f7-8063-5d4d3ebefc07"), "FI", "Finland" },
                    { new Guid("0ad04faa-94a5-4999-8c6c-667664ad9081"), "EG", "Egypt" },
                    { new Guid("0ef398b1-f17e-44bf-ab45-72b7bae82c69"), "SR", "Suriname" },
                    { new Guid("0f7f40f9-f220-4139-8e1e-ac0a03a9008e"), "JP", "Japan" },
                    { new Guid("106a46eb-c17b-4f79-bfb4-e1c277999472"), "MM", "Myanmar" },
                    { new Guid("11a250e4-bbcc-48ec-b2db-3dc26be0ce87"), "TV", "Tuvalu" },
                    { new Guid("149908da-2ef3-4a13-82f7-bc14a224ec49"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("169d7652-3ab2-4ca9-9614-1a56447a87ab"), "SK", "Slovakia" },
                    { new Guid("17782260-e2b8-4de4-b735-aa4f17aa0436"), "LV", "Latvia" },
                    { new Guid("191392f1-11d0-4b42-8c8e-d2a3544972dd"), "GR", "Greece" },
                    { new Guid("193f4cc9-0152-4c62-ae2b-78c898b932ee"), "ZA", "South Africa" },
                    { new Guid("1a163998-0ada-4bd5-8c0d-fa3aa1c0172c"), "LY", "Libya" },
                    { new Guid("1d8178d2-52dd-4a61-9f25-1aaf139fb5e8"), "TH", "Thailand" },
                    { new Guid("1e3501fa-fb9f-4713-973b-c0669af2413c"), "DK", "Denmark" },
                    { new Guid("21294c5b-91e7-4afc-9336-bc8e1bd00223"), "UY", "Uruguay" },
                    { new Guid("2323edfd-6fb3-49b0-bc60-238a30603d5b"), "SS", "South Sudan" },
                    { new Guid("23c781ac-083f-45d3-bbdb-17fa79fed4a5"), "AU", "Australia" },
                    { new Guid("245cd92f-4c9f-4d50-b032-ad94a8e30ad6"), "PT", "Portugal" },
                    { new Guid("25b98d0b-0c77-420d-b4b8-f1ea9717f36a"), "BI", "Burundi" },
                    { new Guid("2676bcec-fa96-4afe-96cf-132dc621098a"), "KG", "Kyrgyzstan" },
                    { new Guid("28348afa-5f37-4d90-b100-e337d3d73a7c"), "ST", "Sao Tome and Principe" },
                    { new Guid("29ccd8a8-cf8a-44b1-a570-a602c2056dc2"), "BY", "Belarus" },
                    { new Guid("2a6c32e6-b43b-49d1-a363-f8ce33428213"), "PE", "Peru" },
                    { new Guid("2a7a0a5c-35ef-4709-a11c-00249460ce95"), "KW", "Kuwait" },
                    { new Guid("2b175e9e-e705-4892-bd2b-1e02b7faf689"), "US", "United States of America" },
                    { new Guid("2d3f1076-e0fd-456b-b999-24df885b01be"), "AG", "Antigua and Barbuda" },
                    { new Guid("2e354dad-3f3d-4bb6-93ef-eb878c34acfd"), "QA", "Qatar" },
                    { new Guid("342765de-a352-4c2a-8378-463d62b445dc"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("34640960-e630-4254-8ddd-637f13bb13e8"), "NA", "Namibia" },
                    { new Guid("3574cf15-03f3-4f74-a6e6-8caf1d475449"), "RS", "Serbia" },
                    { new Guid("370260c8-36c5-4ea8-a040-154c46147302"), "ML", "Mali" },
                    { new Guid("3b71d1ab-dd43-46ce-aec4-bc90755316b9"), "PA", "Panama" },
                    { new Guid("3bdb4aa0-9029-49e1-be25-8ea91799f3fb"), "ER", "Eritrea" },
                    { new Guid("3dbbd000-e874-42b0-946f-df126ce1fc34"), "LT", "Lithuania" },
                    { new Guid("3f3585b6-1ce7-40bf-8d3c-b76e782e306b"), "VE", "Venezuela" },
                    { new Guid("411c00d3-65ab-4e60-9fc0-6421dc56cc2d"), "BH", "Bahrain" },
                    { new Guid("41d22161-4ccd-4c0b-8d08-b94660eb8ca6"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("45de4713-fb79-4c17-8f65-20d455b70bcc"), "UA", "Ukraine" },
                    { new Guid("489a9628-e748-453f-8753-0ed6e3eb35c5"), "CA", "Canada" },
                    { new Guid("491cc17d-bcfd-4a1a-a32b-a4c545086920"), "AF", "Afghanistan" },
                    { new Guid("4b6e49a7-32ca-4be0-9738-4dbaf8bf8149"), "PH", "Philippines" },
                    { new Guid("4cade121-72af-43b6-8406-d8d51cfb438b"), "BR", "Brazil" },
                    { new Guid("4d9b56dc-425d-4226-b6ac-48ec1f6e4050"), "SL", "Sierra Leone" },
                    { new Guid("4ec220d2-40c6-4fa5-bb87-abeb839048a5"), "VU", "Vanuatu" },
                    { new Guid("4ffc0572-d64d-4ed7-8793-d8edd0084db3"), "GW", "Guinea-Bissau" },
                    { new Guid("508a89d4-3372-44f4-9013-9ec331a25aef"), "TM", "Turkmenistan" },
                    { new Guid("50acf98a-8467-4979-b98b-d537543117de"), "IQ", "Iraq" },
                    { new Guid("523a26ca-3b56-40a8-9f48-7a576b8b3dd8"), "CR", "Costa Rica" },
                    { new Guid("53c8f761-4b8e-446e-814b-198418df3003"), "GH", "Ghana" },
                    { new Guid("565fc558-8ecf-4830-a0d9-2c8367192029"), "JM", "Jamaica" },
                    { new Guid("58e91a1d-65c1-49a0-9cf6-408a7a3caa3b"), "UG", "Uganda" },
                    { new Guid("593100b5-6c9d-4a2e-89a8-8ea19b93a7c8"), "HR", "Croatia" },
                    { new Guid("599fa997-4845-4b4d-9188-96e912c00ce6"), "GD", "Grenada" },
                    { new Guid("5a1c0288-2170-4b10-a314-b2f7a42106db"), "GN", "Guinea" },
                    { new Guid("5ab00a62-58de-4f8c-b2af-b334c979e2b9"), "KM", "Comoros" },
                    { new Guid("5af54ff7-cdae-421a-bf89-9129cf75f1af"), "BN", "Brunei" },
                    { new Guid("5c522ef1-b375-4415-9ef2-554ceb6acfcd"), "IS", "Iceland" },
                    { new Guid("5d43682d-da62-4e4a-ae6a-3f2c6050d390"), "OM", "Oman" },
                    { new Guid("5d6b19e2-d56b-4763-958c-56d38df75e99"), "BW", "Botswana" },
                    { new Guid("5daef371-0eb2-456c-82ab-9d6fde4f234b"), "BJ", "Benin" },
                    { new Guid("5f5bbc9d-621b-4c87-921f-e3967cb2d7b1"), "ZW", "Zimbabwe" },
                    { new Guid("6212d483-fef2-4ad3-bb50-a3425849a13e"), "TN", "Tunisia" },
                    { new Guid("62258b68-c9c8-43b4-86f7-902ec02e769f"), "PG", "Papua New Guinea" },
                    { new Guid("627324c3-39fa-4ca4-9979-1ee087f5b54a"), "ET", "Ethiopia" },
                    { new Guid("637480d1-c58d-48f0-b1ec-7924ff9e8b8d"), "CV", "Cabo Verde" },
                    { new Guid("637bca74-5c46-4f3c-b1cd-8fdfbf233621"), "BO", "Bolivia" },
                    { new Guid("66ac5463-41ca-4797-a079-f28ed3dbbd35"), "CM", "Cameroon" },
                    { new Guid("671cbeed-f1a7-478d-88fb-89227444e9fb"), "SY", "Syria" },
                    { new Guid("6751b941-a50a-48ac-bea4-80480f8c4a8b"), "MK", "North Macedonia" },
                    { new Guid("6a50561c-222b-4881-a459-300afacf1822"), "CU", "Cuba" },
                    { new Guid("6ab3a5ab-fd3a-4917-bf7c-a1fb8c8a13da"), "EE", "Estonia" },
                    { new Guid("6dc7cebc-4d8b-43d7-812d-666131a5995c"), "GQ", "Equatorial Guinea" },
                    { new Guid("72481c76-8042-41e4-b7eb-3dafeab945e9"), "ME", "Montenegro" },
                    { new Guid("72a83406-f715-40c6-85db-a44413c949ea"), "MT", "Malta" },
                    { new Guid("732d9623-f430-4d80-aae3-39a4c89d7002"), "KP", "North Korea" },
                    { new Guid("737a7c6a-4cbc-4214-8d5a-56b2945b722c"), "LU", "Luxembourg" },
                    { new Guid("73e4a82c-bedc-4ac2-8fe2-096652c047a8"), "KZ", "Kazakhstan" },
                    { new Guid("7544ef88-ecb1-4c10-91c1-ea5ce67f1ef1"), "IE", "Ireland" },
                    { new Guid("78de492b-3f57-48b6-8987-8ebd0ac57b94"), "BS", "Bahamas" },
                    { new Guid("792f9b10-8b68-4799-a188-f21ca4bf33f2"), "MD", "Moldova" },
                    { new Guid("7a5d6659-1531-426c-9dff-2f40226a4f3e"), "TR", "Turkey" },
                    { new Guid("7adff02a-0fea-469e-bd0f-acbd48592269"), "LR", "Liberia" },
                    { new Guid("7b64bdcd-f219-41e9-847b-76c929b57550"), "NE", "Niger" },
                    { new Guid("7caee84c-c0f7-4734-9834-f9360a4fce74"), "CN", "China" },
                    { new Guid("7dbf4435-4055-4b2c-b606-ca59c22e2b05"), "MY", "Malaysia" },
                    { new Guid("7e6ba29f-5222-475e-bb4b-06b6bac3889b"), "NZ", "New Zealand" },
                    { new Guid("7ec5d023-7331-4def-a3e0-113576e7aede"), "ZM", "Zambia" },
                    { new Guid("7fe68724-eca8-4e72-aa23-e0e8b9a242e2"), "ID", "Indonesia" },
                    { new Guid("80623035-cee2-4e58-8782-f51fc7c702dc"), "RU", "Russia" },
                    { new Guid("80fbdc7f-dec0-4894-95be-b36d51f28299"), "AM", "Armenia" },
                    { new Guid("812ea8bb-448c-446f-8061-a60a71998169"), "LI", "Liechtenstein" },
                    { new Guid("81aba926-c08e-4050-aa9e-913cdd6902c2"), "RO", "Romania" },
                    { new Guid("84d59a31-6d6e-4222-a251-0ed91740cf0c"), "DJ", "Djibouti" },
                    { new Guid("85b74c9a-e917-49f9-9ede-01d3fecefb0d"), "BE", "Belgium" },
                    { new Guid("85ddf6bd-fe9e-42b1-880f-80a95787e08d"), "MA", "Morocco" },
                    { new Guid("870a41c9-0ea5-4e14-bd1f-78d28172da30"), "NL", "Netherlands" },
                    { new Guid("8792673c-0fde-4610-be64-93a36f56e298"), "AR", "Argentina" },
                    { new Guid("88334ee8-8866-4c03-9e9f-68ffb65de620"), "IT", "Italy" },
                    { new Guid("886371b3-a423-4ce6-89db-e08cb9593e31"), "MC", "Monaco" },
                    { new Guid("898259e2-027a-4077-9720-e9ca298a99e6"), "CH", "Switzerland" },
                    { new Guid("8b2389b9-6752-48c9-8681-bcfbffab3b07"), "GY", "Guyana" },
                    { new Guid("8d7157bd-07bd-4721-b0b5-439ccb183b71"), "MZ", "Mozambique" },
                    { new Guid("8ec95acf-7323-4644-8697-1af85bffa1e3"), "CF", "Central African Republic" },
                    { new Guid("8fbfa20c-e508-4eaf-b2af-f40094caf766"), "TO", "Tonga" },
                    { new Guid("901a9c81-fb4b-46ab-85ad-792fff0cbf95"), "BF", "Burkina Faso" },
                    { new Guid("9040faa7-8b90-4d2e-95d5-0b621df6fd48"), "BB", "Barbados" },
                    { new Guid("917f058a-b654-499f-a50d-585876f78424"), "LA", "Laos" },
                    { new Guid("95efc751-804c-4915-92a3-333639cd1bc8"), "NP", "Nepal" },
                    { new Guid("97d19348-e11e-48b7-aa29-ad12e93a8d6a"), "AZ", "Azerbaijan" },
                    { new Guid("97e2344a-d4b8-43dc-92e6-0565ef6b8406"), "SI", "Slovenia" },
                    { new Guid("98cf4d2f-3a54-4286-9a7d-8257d9d5f9e1"), "LK", "Sri Lanka" },
                    { new Guid("99784b5b-bd53-4258-a55d-746fd6317299"), "MN", "Mongolia" },
                    { new Guid("99dbff13-2e37-4bfa-9305-928d8b780990"), "HU", "Hungary" },
                    { new Guid("99e47240-fcca-4c73-9712-2de45d0d900b"), "PL", "Poland" },
                    { new Guid("9a12028c-d5f9-44ba-bae1-890b7c16e4e5"), "NG", "Nigeria" },
                    { new Guid("9b0681ec-e109-4871-8f14-0ba960a91575"), "CY", "Cyprus" },
                    { new Guid("a0512f1f-af71-4b91-b2fa-cc244a5f603c"), "HT", "Haiti" },
                    { new Guid("a3376569-6d7f-4c20-a493-af5872dc8516"), "SC", "Seychelles" },
                    { new Guid("a38da1cc-13b6-4f1f-972b-74f66b82d09b"), "BD", "Bangladesh" },
                    { new Guid("a4baa9ee-3f43-4686-8b2e-0980067ad3e7"), "AT", "Austria" },
                    { new Guid("a4f58adf-ab08-4c1f-a12e-22ff0717eee7"), "KR", "South Korea" },
                    { new Guid("a544b554-3e97-4814-8c28-35169976db94"), "TG", "Togo" },
                    { new Guid("a5ea2e2d-79be-433b-b4dc-51695037c838"), "MX", "Mexico" },
                    { new Guid("a6f88076-70fd-4f45-b786-4160b39fc731"), "SM", "San Marino" },
                    { new Guid("a730b6e0-0ae9-46ad-8617-5b9e0eb28f47"), "KE", "Kenya" },
                    { new Guid("a777f4db-1a0d-4d30-b65b-e2c923cc7c43"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("ab842a10-1d24-4818-bb14-fe4af1f8333b"), "AL", "Albania" },
                    { new Guid("ad6d5e69-9d2e-4bd2-bb45-5cf7845c04b7"), "LC", "Saint Lucia" },
                    { new Guid("adc8a136-0e72-4ec2-830e-d4d00185670e"), "MG", "Madagascar" },
                    { new Guid("aece16db-cace-40bc-996a-0d544d6d416f"), "BT", "Bhutan" },
                    { new Guid("af328372-b751-4cc9-b480-a91c113ae21c"), "NI", "Nicaragua" },
                    { new Guid("b04c8176-08e1-4cfa-b54c-cb8a8585ac04"), "UZ", "Uzbekistan" },
                    { new Guid("b31df56c-3d23-4acf-91e7-9f29e3316e7c"), "SD", "Sudan" },
                    { new Guid("b37725b0-abc3-4a54-8a3a-0cbecb26ff41"), "IN", "India" },
                    { new Guid("b3a01fec-c098-4eee-ad3f-4cba949ef020"), "GB", "United Kingdom" },
                    { new Guid("b4b2d761-4177-4f7c-9de7-aa69e341c9dd"), "GE", "Georgia" },
                    { new Guid("b56f30e3-1c40-47ff-9303-3e1c47ea1360"), "ES", "Spain" },
                    { new Guid("b5dd0629-9326-4223-9bb4-840029d293d2"), "PS", "Palestine" },
                    { new Guid("b66df5a8-9d81-4aab-a093-af4ee734a4e3"), "MR", "Mauritania" },
                    { new Guid("b6731013-454e-48eb-a693-7286455e05a8"), "TD", "Chad" },
                    { new Guid("b729497e-2251-485c-b63e-cebe81eef6ac"), "DO", "Dominican Republic" },
                    { new Guid("bb0216ff-5774-42c0-babd-e8484e991a89"), "NR", "Nauru" },
                    { new Guid("bf1b6645-bf82-4e66-b89c-c4426d6b376b"), "GM", "Gambia" },
                    { new Guid("c0353efa-5490-4a4e-8659-954b6e71ac8c"), "SV", "El Salvador" },
                    { new Guid("c06ba9c0-191e-442a-a4e4-ec781d9c33e4"), "SA", "Saudi Arabia" },
                    { new Guid("c2351194-0f07-418f-ad61-e03b066b4638"), "SE", "Sweden" },
                    { new Guid("c4ebb580-88c4-4185-b9af-94549dc96dc3"), "FM", "Micronesia" },
                    { new Guid("c5ace8d9-c0de-4f0f-b848-986c4edffab2"), "SB", "Solomon Islands" },
                    { new Guid("c5f728a6-3de5-49f9-a33a-51a83bbc64c3"), "AO", "Angola" },
                    { new Guid("c90c4f60-5d39-4cb2-b5d4-cd3f43cfdf94"), "MU", "Mauritius" },
                    { new Guid("c9b2e4ad-3f12-43f0-a116-6dc216c6b652"), "BZ", "Belize" },
                    { new Guid("c9ed739c-2d71-413f-9c55-8bbd160217c5"), "GA", "Gabon" },
                    { new Guid("cbd06371-7a4b-4c78-b6b5-62693858bea3"), "MW", "Malawi" },
                    { new Guid("cbf9303c-2fad-48cb-a4c4-9c887fe008bd"), "TZ", "Tanzania" },
                    { new Guid("cc8ca35d-d62f-41ee-8428-b8f6865a73cb"), "MH", "Marshall Islands" },
                    { new Guid("cd52029c-8390-4f07-af3c-5b2d639fe593"), "PY", "Paraguay" },
                    { new Guid("cdd5c6c5-7621-47f5-9ebe-619905bcef62"), "AE", "United Arab Emirates" },
                    { new Guid("cf83426f-ba4a-48c6-83fb-12b8c32c02ad"), "YE", "Yemen" },
                    { new Guid("d1756c7a-7953-4f13-89c2-c6678600618d"), "CO", "Colombia" },
                    { new Guid("d8bbb8dd-fe44-4131-af9a-0c7b87da2e38"), "RW", "Rwanda" },
                    { new Guid("d9126c83-a234-4d1c-a91a-5d5881bbd0e7"), "NO", "Norway" },
                    { new Guid("dbc8d9ad-c576-4fee-804f-f4d37b807de7"), "IR", "Iran" },
                    { new Guid("dbf6b696-4571-4d9b-9044-efb6fc218920"), "VN", "Vietnam" },
                    { new Guid("df146bb4-a312-4b33-8eef-1ad9b8d70eb6"), "TL", "Timor-Leste" },
                    { new Guid("df166fda-358c-4935-91e5-69ddcf441b4c"), "SG", "Singapore" },
                    { new Guid("df1ab81a-83fd-4a98-9342-04a8b31cd176"), "FR", "France" },
                    { new Guid("dff24425-1038-494a-81cb-e4687bafd56a"), "CL", "Chile" },
                    { new Guid("e48708a7-a12d-442e-bf3c-8e401ea544d2"), "SN", "Senegal" },
                    { new Guid("e90f71fa-76e0-4df4-8ec9-2564e8560540"), "IL", "Israel" },
                    { new Guid("ea2571ab-8fd2-48a5-a726-80c702fc910a"), "HN", "Honduras" },
                    { new Guid("ea2725ae-3059-4b25-8108-f55d592dd148"), "JO", "Jordan" },
                    { new Guid("ebfcc8f1-3970-41d9-a3fc-7c1aa0b16651"), "AD", "Andorra" },
                    { new Guid("ec447547-4bff-42b2-adad-a2248c98c3a0"), "KI", "Kiribati" },
                    { new Guid("ed9dd234-f31d-465b-ae77-37addbc44997"), "TT", "Trinidad and Tobago" },
                    { new Guid("f1009394-56f2-410b-aa83-a36ce07c652f"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("f33ce01f-a093-4278-8660-d7b622f8af41"), "FJ", "Fiji" },
                    { new Guid("f3a056a1-c1c4-43e8-8688-efb4bc820965"), "LB", "Lebanon" },
                    { new Guid("f3db8671-69e0-496a-9c50-57175b4c8fee"), "EC", "Ecuador" },
                    { new Guid("f569f026-cb8b-4c7d-b794-76f47f6caa98"), "SO", "Somalia" },
                    { new Guid("f61ad253-e786-45bd-a974-c95c1bae4938"), "BG", "Bulgaria" },
                    { new Guid("f6318b45-dbdd-4167-8869-c7c090bc04ed"), "GT", "Guatemala" },
                    { new Guid("f6567a82-fd8e-46c2-b6d6-a246767308f5"), "DZ", "Algeria" },
                    { new Guid("f6fa45b1-3070-422c-beef-2577b1de506c"), "DE", "Germany" },
                    { new Guid("f8153563-e24d-4a70-96a7-9d61fe2bdd4e"), "VA", "Vatican City" },
                    { new Guid("f828da13-40d3-49c1-aa0b-6c59fad6875a"), "WS", "Samoa" },
                    { new Guid("fae7cc86-13fe-4adc-9e60-ef4a273f6339"), "KH", "Cambodia" },
                    { new Guid("faf78a84-c6b1-4d2a-a713-18dd58b2e33a"), "MV", "Maldives" },
                    { new Guid("fb7b56d6-1bed-4e27-b7d5-913e8687857c"), "VA", "Holy See" },
                    { new Guid("fe0e4468-a731-4722-9074-f7d294c7c661"), "SZ", "Eswatini" },
                    { new Guid("ffec1e7d-1211-4226-8371-5d38e11a140d"), "LS", "Lesotho" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8de261ba-7c2b-436c-9a13-2615e366771b"), "Female" },
                    { new Guid("b6c287fa-0e6c-47d1-a7f7-ed950cf56002"), "Male" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("077356f1-c03b-4b32-9666-87ecd95dcf03"), "Postoperative Care" },
                    { new Guid("1504e3fb-083a-4921-9df7-cd22142e153e"), "Surgical Interventions" },
                    { new Guid("233831b9-a026-48d7-85a9-d7d1d9df9598"), "Emergency" },
                    { new Guid("2f4d6caa-977d-4606-81be-353b4d413a8a"), "Therapeutic Interventions" },
                    { new Guid("4e04ef35-19aa-480c-8ecb-f29c18f391d7"), "Dental Interventions" },
                    { new Guid("62826788-9c85-40ab-ac0d-5d48d009b339"), "Exotic and Specialized Interventions" },
                    { new Guid("723d9d4d-5b73-482b-88d8-14b9136c8f35"), "Obstetric and Reproductive Interventions" },
                    { new Guid("8d17d6db-c184-4ad1-ac17-bd5548b19c88"), "Diagnostic Interventions" },
                    { new Guid("a9c247f1-e2b6-4db8-9807-e2c3888b2ce2"), "Oncological Interventions" },
                    { new Guid("be2c20b7-6491-4617-a246-3f5d8edb89a0"), "Preventive Interventions" }
                });
        }
    }
}
