using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewSeedingMethodAddIdentitySettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBookings");

            migrationBuilder.DropTable(
                name: "UserDetailsPets");

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TypeInspections",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Type Intervention Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "TypeInterventionName");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "TypeInspections",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Type Inspection Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "TypeInspectionId");

            migrationBuilder.AlterColumn<string>(
                name: "TransponderLocation",
                table: "Pets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Pet Location Of The Transponder",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "PetLocationOfTheTransponder");

            migrationBuilder.AlterColumn<string>(
                name: "TransponderCode",
                table: "Pets",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                comment: "Pet Transponder Alphanumeric Code",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldComment: "PetTransponderAlphanumericCode");

            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Pets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Pet Species",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "PetSpecies");

            migrationBuilder.AlterColumn<int>(
                name: "PassportNumber",
                table: "Pets",
                type: "int",
                nullable: false,
                comment: "PetNumber Of Passport",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "PetNumberOfPassport");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Pet Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "PetName");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Pets",
                type: "bit",
                nullable: false,
                comment: "Deleted status",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "PetSoftDeleted");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Pet Image",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "PetImage");

            migrationBuilder.AlterColumn<Guid>(
                name: "GenderId",
                table: "Pets",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Gender Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "GenderId");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Pets",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Pet Additional Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "PetAdditionalDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Pets",
                type: "datetime2",
                nullable: false,
                comment: "PetDate Of Birth",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "PetDateOfBirth");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "Pets",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Country Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "CountryId");

            migrationBuilder.AlterColumn<string>(
                name: "Breed",
                table: "Pets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Pet Breed",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "PetBreed");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Pets",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "PetId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Pets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of creation");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Pets",
                type: "datetime2",
                nullable: true,
                comment: "Date of deleting");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Pets",
                type: "datetime2",
                nullable: true,
                comment: "Last date of modification");

            migrationBuilder.AlterColumn<Guid>(
                name: "InterventionId",
                table: "PetInterventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Intervention Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "InterventionId");

            migrationBuilder.AlterColumn<Guid>(
                name: "PetId",
                table: "PetInterventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Pet Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "PetId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "User Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "UserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "TypeInspectionId",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Type Of Inspection",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "TypeOfInspection");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Interventions",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                comment: "Price For Intervention",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4,
                oldComment: "PriceForIntervention");

            migrationBuilder.AlterColumn<Guid>(
                name: "PetId",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Pet Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "PetId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsInterventionDone",
                table: "Interventions",
                type: "bit",
                nullable: false,
                comment: "Intervention Status",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "InterventionStatus");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Interventions",
                type: "bit",
                nullable: false,
                comment: "Deleted status",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "BookingInterventionSoftDeleted");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Doctor Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "DoctorId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Interventions",
                type: "datetime2",
                nullable: false,
                comment: "Date Of Intervention",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "DateOfIntervention");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "InterventionId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Interventions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of creation");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Interventions",
                type: "datetime2",
                nullable: true,
                comment: "Date of deleting");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Interventions",
                type: "datetime2",
                nullable: true,
                comment: "Last date of modification");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genders",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                comment: "Gender Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldComment: "GenderName");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Genders",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Pet Gender Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "PetGenderId");

            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Doctors",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                comment: "Doctor Town",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldComment: "DoctorTown");

            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "Doctors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Doctor Specialty",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "DoctorSpecialty");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Doctors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Phone Number",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "PhoneNumber");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Doctors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Doctor Last Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "DoctorLastName");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                type: "bit",
                nullable: false,
                comment: "Deleted status",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "DoctorSoftDelete");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Doctor Image",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "DoctorImage");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Doctors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Doctor First Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "DoctorFirstName");

            migrationBuilder.AlterColumn<string>(
                name: "Experience",
                table: "Doctors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Doctor Experience",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "DoctorExperience");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Doctors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Doctor Email Address",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "DoctorEmailAddress");

            migrationBuilder.AlterColumn<string>(
                name: "Education",
                table: "Doctors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Doctor Education",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "DoctorEducation");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Doctors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Doctor Details",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "DoctorDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                comment: "Doctor Date Of Birth",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "DoctorDateOfBirth");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Country Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "CountryId");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "DoctorId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of creation");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Doctors",
                type: "datetime2",
                nullable: true,
                comment: "Date of deleting");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Doctors",
                type: "datetime2",
                nullable: true,
                comment: "Last date of modification");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "DoctorPets",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Doctor Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "DoctorId");

            migrationBuilder.AlterColumn<Guid>(
                name: "InterventionId",
                table: "DoctorInterventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Intervention Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "InterventionId");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "DoctorInterventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Doctor Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "DoctorId");

            migrationBuilder.AlterColumn<Guid>(
                name: "BookingId",
                table: "DoctorBookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Booking Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "BookingId");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "DoctorBookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Doctor Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "DoctorId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                comment: "Country Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldComment: "CountryName");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Countries",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                comment: "Country ISOCode",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldComment: "CountryISOCode");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Countries",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Country Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "CountryId");

            migrationBuilder.AlterColumn<string>(
                name: "WorkingTime",
                table: "Clinics",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Clinic Working Time",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "ClinicWorkingTime");

            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Clinics",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Clinic Town",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "ClinicTown");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clinics",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Clinic Phone",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "ClinicPhone");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clinics",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Clinic Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "ClinicName");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Clinics",
                type: "bit",
                nullable: false,
                comment: "Deleted status",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "ClinicSoftDeleted");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clinics",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Clinic Email",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "ClinicEmail");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "Clinics",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Country Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "CountryId");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clinics",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Clinic Address",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "ClinicAddress");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Clinics",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "ClinicId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Clinics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of creation");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Clinics",
                type: "datetime2",
                nullable: true,
                comment: "Date of deleting");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Clinics",
                type: "datetime2",
                nullable: true,
                comment: "Last date of modification");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "ClinicDoctors",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Doctor Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "DoctorId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClinicId",
                table: "ClinicDoctors",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Clinic Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "ClinicId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "User Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "UserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "TypeInspectionId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Type Of Inspection",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "TypeOfInspection");

            migrationBuilder.AlterColumn<Guid>(
                name: "PetId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Pet Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "PetId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Bookings",
                type: "bit",
                nullable: false,
                comment: "Deleted status",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "BookingInterventionSoftDeleted");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Doctor Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "DoctorId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                comment: "Date of deleting",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "DeletionTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                comment: "Date Of Intervention",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "DateOfIntervention");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "BookingInterventionId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of creation");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                comment: "Last date of modification");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Last Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "LastName");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                comment: "State of delete",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "UserDetailsSoftDeleted");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Image Url",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "ImageUrl");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "First Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "FirstName");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Country Id",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "CountryId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of create");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                comment: "Date of Delete");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                comment: "Date of modification");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of create");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                comment: "Date of Delete");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetRoles",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "State of delete");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                comment: "Date of modification");

            migrationBuilder.CreateTable(
                name: "ApplicationUserBookings",
                columns: table => new
                {
                    UserDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "UserId"),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "BookingId")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserBookings", x => new { x.UserDetailsId, x.BookingId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserBookings_AspNetUsers_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationUserBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserPets",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "User Details Id"),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Pet Id"),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserPets", x => new { x.UserId, x.PetId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserPets_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationUserPets_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("00c9fd12-161b-4742-95cc-ed3db3c8dd94"), "IL", "Israel" },
                    { new Guid("03360e94-1f78-4c63-8780-bb7bbb6946a5"), "KP", "North Korea" },
                    { new Guid("0340b094-7fc9-460b-a47e-a00747999bc4"), "VN", "Vietnam" },
                    { new Guid("040838ab-1e0c-47f9-95e0-439276737890"), "FR", "France" },
                    { new Guid("0598b43d-418f-44e3-9e58-00b2141dcbd0"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("0609ba1c-0f7e-4f38-aed9-d2cd3d26df9e"), "NA", "Namibia" },
                    { new Guid("0919bf22-d2ef-42c3-b7ca-c7a9ea10b5f8"), "AF", "Afghanistan" },
                    { new Guid("1035ebe7-1635-41cf-ad95-88c730204d6d"), "SK", "Slovakia" },
                    { new Guid("107ca22e-10f8-456a-abb4-27836e0df26e"), "TD", "Chad" },
                    { new Guid("119281cd-f54e-4e93-8b0b-1dabc0d7753e"), "TO", "Tonga" },
                    { new Guid("11fc0791-6b55-4540-83b8-12737a48cf7e"), "TG", "Togo" },
                    { new Guid("148587ac-226a-481c-bea1-aa70b62efff1"), "MH", "Marshall Islands" },
                    { new Guid("1605d968-2259-46e2-9663-de19b418abf5"), "CO", "Colombia" },
                    { new Guid("165e0728-430e-438b-93cf-2b3679d0a304"), "HU", "Hungary" },
                    { new Guid("1669da8e-de20-4db1-8038-2c2b6f16efbd"), "VE", "Venezuela" },
                    { new Guid("178455fa-c782-4840-bcb7-be666e0c6b42"), "SS", "South Sudan" },
                    { new Guid("1943c74e-202c-49f8-bbea-f4f15e57ef27"), "PE", "Peru" },
                    { new Guid("1aef320a-b965-4ec4-a401-737f9b673437"), "GH", "Ghana" },
                    { new Guid("1e2e450b-335d-4c40-b5b0-adc6806d96e4"), "AM", "Armenia" },
                    { new Guid("1ef7a575-1eb9-478b-b1cd-9151494fb987"), "SL", "Sierra Leone" },
                    { new Guid("20c9548a-29b5-462f-afc3-d50900963209"), "NR", "Nauru" },
                    { new Guid("227e62f6-7b88-4e95-97bb-5524c813bc9d"), "KZ", "Kazakhstan" },
                    { new Guid("233fd5fd-2810-44a8-8a25-614398869a6d"), "GR", "Greece" },
                    { new Guid("237cbad6-8eba-4d24-ab34-9d597c366ce6"), "ML", "Mali" },
                    { new Guid("2428c6df-ee51-4d9f-912d-f583c0999cac"), "BY", "Belarus" },
                    { new Guid("257b5408-260c-4abe-9fba-3807eda0290a"), "AT", "Austria" },
                    { new Guid("25a672e5-8957-4e5a-96c7-6866dba6d0c6"), "UG", "Uganda" },
                    { new Guid("27035b42-bfa0-44fb-853f-29c8e1b9e5b4"), "LS", "Lesotho" },
                    { new Guid("2878637d-002a-4789-912f-460a376de679"), "DZ", "Algeria" },
                    { new Guid("28b41fde-3764-425d-ad9b-75c0102e283f"), "MU", "Mauritius" },
                    { new Guid("28befb04-c3c6-4483-8a1e-053a243d34f2"), "TL", "Timor-Leste" },
                    { new Guid("28bf3bcc-30df-42a7-94ea-a0f617077888"), "SN", "Senegal" },
                    { new Guid("2c003c03-cca0-43b9-a03d-8c27516d05a9"), "SC", "Seychelles" },
                    { new Guid("2c521c5c-8759-4370-8dd3-c7da515fc6eb"), "TR", "Turkey" },
                    { new Guid("2ddd70ee-4224-4d63-9a6d-b9d61ff70b74"), "MN", "Mongolia" },
                    { new Guid("2e378e42-c37d-495b-8329-2ea20ca05b72"), "UZ", "Uzbekistan" },
                    { new Guid("316c8055-e8de-4905-8141-bcb27b96bda9"), "BZ", "Belize" },
                    { new Guid("316e25ab-3342-426f-96f6-d780c06143e4"), "MR", "Mauritania" },
                    { new Guid("31782bbb-ffe4-4fd4-9399-edf55f35b60e"), "IQ", "Iraq" },
                    { new Guid("31a990e1-a36b-4396-8818-efdbe0dc26d7"), "CY", "Cyprus" },
                    { new Guid("31f58b83-0db7-47d6-919d-6151d9524507"), "GT", "Guatemala" },
                    { new Guid("32e292dc-1d0b-4418-90c8-5178282a02c9"), "MA", "Morocco" },
                    { new Guid("33d3e4a0-1159-4397-b310-31469201b938"), "BF", "Burkina Faso" },
                    { new Guid("37e9a54f-5e0a-4e27-b846-78b8ba28d376"), "TH", "Thailand" },
                    { new Guid("392840a0-8a81-48dd-94a0-8aaeb03fd1b6"), "IT", "Italy" },
                    { new Guid("3a7e1a83-b638-4b5e-a794-71ba013170c6"), "IN", "India" },
                    { new Guid("3c3ae71e-a064-4e55-b0a1-065789e4a467"), "BS", "Bahamas" },
                    { new Guid("3c92f989-2dd9-4f51-bb6d-d2293c3ef906"), "BT", "Bhutan" },
                    { new Guid("3d36971e-178e-4deb-b20b-57980ece82df"), "OM", "Oman" },
                    { new Guid("3d9db975-a1db-4c71-a34e-c196c5ab4222"), "BO", "Bolivia" },
                    { new Guid("3eab68dc-41c7-4e20-b88f-2a271e44174a"), "SV", "El Salvador" },
                    { new Guid("3fce0d89-faf0-44dd-8ce6-e76f80ae128e"), "BI", "Burundi" },
                    { new Guid("41942c2f-2891-4444-836e-6ca50a268736"), "HR", "Croatia" },
                    { new Guid("4253316d-ac3d-4d25-81d2-e9ad1d60042d"), "ER", "Eritrea" },
                    { new Guid("425de634-7138-4a5f-94dd-3dd1688e7d72"), "SZ", "Eswatini" },
                    { new Guid("46115999-7a10-4f92-b7d4-8f27450f1a9a"), "SR", "Suriname" },
                    { new Guid("494d66f6-4d22-485d-83c7-aadda9be4148"), "TV", "Tuvalu" },
                    { new Guid("4bbd7e14-8af6-46ef-b5af-25641b1a857c"), "CM", "Cameroon" },
                    { new Guid("4c8680bb-75b0-45e6-bd80-48178ffed038"), "NP", "Nepal" },
                    { new Guid("4daaaa30-4c49-4a99-9169-979d92fede5d"), "HN", "Honduras" },
                    { new Guid("4ddf7b23-a978-4b5f-9e2f-7baed184443f"), "MZ", "Mozambique" },
                    { new Guid("4e824f6e-1c45-421d-b0f2-97bfb939803f"), "GD", "Grenada" },
                    { new Guid("4eba3b14-c6b1-49a8-a635-eb1c7a3c0eda"), "MX", "Mexico" },
                    { new Guid("4ff79052-c22e-4f29-acff-6a4ca7d22448"), "SG", "Singapore" },
                    { new Guid("518b01d6-d88a-4819-b6c6-3c64117c214f"), "KM", "Comoros" },
                    { new Guid("5195997b-d3c2-4ecc-a78b-1bdd647b22ab"), "KW", "Kuwait" },
                    { new Guid("563ab821-9409-468b-83ae-7e418cb03075"), "PS", "Palestine" },
                    { new Guid("566456e9-d9a3-4384-9df2-e6d4768ee6d1"), "VA", "Vatican City" },
                    { new Guid("56805e90-4518-4ea1-9937-c3743f0e75da"), "AE", "United Arab Emirates" },
                    { new Guid("5a45d37a-e6ad-459e-95fb-09c867823bdd"), "AU", "Australia" },
                    { new Guid("5ca3bb7f-04b8-49de-b47a-606830c69119"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("60ca56ea-4d2c-493f-be2a-0c28d06941de"), "UA", "Ukraine" },
                    { new Guid("6121520e-af9a-4c60-b662-b79498eaf294"), "SO", "Somalia" },
                    { new Guid("630afb03-7600-4d02-a240-4caa67fb41ba"), "LU", "Luxembourg" },
                    { new Guid("6375a023-8b1c-44ad-8c91-e046ac27b849"), "IS", "Iceland" },
                    { new Guid("64d46e64-6d50-49d9-942e-a4a2a2224398"), "JP", "Japan" },
                    { new Guid("672a7573-3b64-403a-9777-391aa0a39667"), "AG", "Antigua and Barbuda" },
                    { new Guid("696f63b9-dc1d-43e1-b5aa-1614042e5764"), "JO", "Jordan" },
                    { new Guid("6a373c82-5fbc-4848-a7cb-bd8434487c53"), "PG", "Papua New Guinea" },
                    { new Guid("6cefe58a-40bd-4a06-8ed2-694d2ada9acd"), "GA", "Gabon" },
                    { new Guid("6e58ae99-ded0-40dc-9f7a-74173b974eb3"), "ET", "Ethiopia" },
                    { new Guid("6fa2b2aa-f19c-4a05-b440-56e4817ec654"), "RO", "Romania" },
                    { new Guid("6fa2d577-3c00-47ca-a037-a1c7e4b5bcfa"), "ME", "Montenegro" },
                    { new Guid("6fdd1509-8659-4e7c-8e5a-895b45b31018"), "LR", "Liberia" },
                    { new Guid("7097be75-1720-4f2a-aba2-beb6e5843c75"), "CA", "Canada" },
                    { new Guid("70d2f0aa-a7d0-4de4-a31b-444ee5ceb86e"), "BD", "Bangladesh" },
                    { new Guid("71b64707-79a8-4154-8132-cd165d36985e"), "PA", "Panama" },
                    { new Guid("726d587c-ad23-44ce-9035-76973942fbb1"), "MD", "Moldova" },
                    { new Guid("7392f432-d532-4b4e-ac5d-81a88426743a"), "LT", "Lithuania" },
                    { new Guid("74bc92e8-00a6-44f0-9036-84755a5eb8be"), "BG", "Bulgaria" },
                    { new Guid("74f56d2d-8a6e-41b8-aa82-96e8d5265ff0"), "EE", "Estonia" },
                    { new Guid("754b4674-ce80-45e0-91de-d2b9df454007"), "TN", "Tunisia" },
                    { new Guid("77d7ffd8-b6c9-43fe-98b4-09b2993e579a"), "PH", "Philippines" },
                    { new Guid("78a010e9-69ec-43e7-b14b-f95a3a0f4342"), "LI", "Liechtenstein" },
                    { new Guid("795114a5-63e5-4eb5-bcfd-1e465dbd329d"), "VU", "Vanuatu" },
                    { new Guid("797e7ba2-0276-4e22-bba5-b5143be4f388"), "NG", "Nigeria" },
                    { new Guid("7afedbd6-92f7-496d-8a99-5ab6daf3b80b"), "MK", "North Macedonia" },
                    { new Guid("7cd82cbd-53bc-4a29-a6e3-8a96f8d14dfb"), "CN", "China" },
                    { new Guid("7f8ea933-7e2b-451d-812b-c34c66c4c8ac"), "BB", "Barbados" },
                    { new Guid("80dd8a3f-93dc-4b90-a97b-ec65677d2638"), "SY", "Syria" },
                    { new Guid("84e8c704-42e9-4e54-8b2d-98786dcbc83d"), "GM", "Gambia" },
                    { new Guid("87114e14-dda9-4f38-bb04-61b06ce89a50"), "MW", "Malawi" },
                    { new Guid("871c8dcb-ec0d-4645-911e-0b10622c03c3"), "BH", "Bahrain" },
                    { new Guid("880612ed-ed0d-4f3a-abc2-842e8749156a"), "AL", "Albania" },
                    { new Guid("8877ba17-065d-4aef-a957-0242b8465000"), "RW", "Rwanda" },
                    { new Guid("89163a30-d998-43f6-b27a-8080544ea7a9"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("8ac2cc06-6087-424c-a308-1b98d4ad0806"), "SA", "Saudi Arabia" },
                    { new Guid("8e4b4af2-d7f7-4d27-8669-a64e640bdf2f"), "WS", "Samoa" },
                    { new Guid("8fba8e7c-a009-427a-bb6f-a9b5c68c1c21"), "AR", "Argentina" },
                    { new Guid("913b8bb1-9210-423f-a8b3-7dc220d8a478"), "BW", "Botswana" },
                    { new Guid("91d7fb4c-a92d-4022-b566-d842586242b5"), "KE", "Kenya" },
                    { new Guid("92019bf3-c53e-48cd-ba51-b614f57c3d52"), "EG", "Egypt" },
                    { new Guid("9560e4be-8c05-4d67-9e05-4f2a151747b6"), "IR", "Iran" },
                    { new Guid("97a3f259-23db-4781-bb41-d2d01e7da088"), "ZM", "Zambia" },
                    { new Guid("9b4d48e8-da45-4441-a15e-444748bc4b2f"), "LK", "Sri Lanka" },
                    { new Guid("9b4eafa6-1b38-41d0-8a4c-89e7687e32ff"), "MV", "Maldives" },
                    { new Guid("9c4d15f8-c80f-47db-b42c-692d3b7076a0"), "BE", "Belgium" },
                    { new Guid("9dd999ba-5d6a-43df-8bfc-d5197f2eecb1"), "NO", "Norway" },
                    { new Guid("9edeb93c-be36-451b-b6e8-15d2bc8739b4"), "GE", "Georgia" },
                    { new Guid("9fa8cbf6-9326-4531-85e8-d9eb3a98264d"), "DE", "Germany" },
                    { new Guid("a11201c3-a234-4e58-9883-eee958b12630"), "BJ", "Benin" },
                    { new Guid("a1596a4e-afcb-4d68-ac30-93a70e027fcc"), "TZ", "Tanzania" },
                    { new Guid("a2d8449b-1e84-4ead-8eb8-9c06c9d85f30"), "MM", "Myanmar" },
                    { new Guid("a55ff4e8-0f61-4b8d-87dd-0e3f0a6dbce2"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("a5de9750-dfb2-41d0-a309-bac181711546"), "SB", "Solomon Islands" },
                    { new Guid("a640af91-4fd4-45be-99f0-5f8743b59f20"), "GW", "Guinea-Bissau" },
                    { new Guid("a7d2e266-4cde-4f3c-beac-82bfaac56b6a"), "AZ", "Azerbaijan" },
                    { new Guid("a8f9362e-b12d-4b79-9f32-aa29918734ed"), "HT", "Haiti" },
                    { new Guid("a990a0c0-821b-4f12-b06f-270fbd5b0c6f"), "MC", "Monaco" },
                    { new Guid("a9e34df4-ff1f-4498-8577-e08dfe18a9e0"), "AD", "Andorra" },
                    { new Guid("aa422f6c-7816-4987-8248-d522fd9e74eb"), "CU", "Cuba" },
                    { new Guid("acf15cd1-c6d0-41f0-bd80-ef9a0c1a67df"), "LA", "Laos" },
                    { new Guid("b129eabb-f63e-43fa-b545-7b5c8b1cd6da"), "MT", "Malta" },
                    { new Guid("b2f7033a-aa8c-464e-b678-0fb1bcc448c1"), "SE", "Sweden" },
                    { new Guid("b34cac6b-f9e8-4896-8569-40a3179081a8"), "GQ", "Equatorial Guinea" },
                    { new Guid("b53a5f51-a8de-4167-86f7-1c9ad797c10a"), "PY", "Paraguay" },
                    { new Guid("b8948d66-b089-4544-b04e-b1cb0bff701f"), "UY", "Uruguay" },
                    { new Guid("bae3ec07-b687-425a-8332-ebc053875c11"), "MG", "Madagascar" },
                    { new Guid("bb2aff76-00ae-4060-849e-2a9f4da05a10"), "CR", "Costa Rica" },
                    { new Guid("bd10cf99-97b6-4c20-b222-546686cb047d"), "YE", "Yemen" },
                    { new Guid("bd2d8d73-99f5-4f3a-a80c-84ed2bc014ae"), "LC", "Saint Lucia" },
                    { new Guid("be77379d-d6f8-4061-b936-90aa8f1c0ca2"), "KR", "South Korea" },
                    { new Guid("bf1ec804-a783-43f3-97ae-cb09aa1bd970"), "SI", "Slovenia" },
                    { new Guid("bf57aa5e-ea5c-488a-a062-efb036fbd4de"), "NI", "Nicaragua" },
                    { new Guid("c0406073-a685-4667-a9ff-7ed61c704777"), "JM", "Jamaica" },
                    { new Guid("c24378df-bc6d-4819-a099-bc800891318c"), "VA", "Holy See" },
                    { new Guid("c395942c-5fe2-41da-ad73-1f3480a2d286"), "MY", "Malaysia" },
                    { new Guid("c49d6450-2bd8-4037-b090-45614ec684d0"), "FM", "Micronesia" },
                    { new Guid("c5842ea0-1cc3-41f0-b56c-f904c53d3141"), "CH", "Switzerland" },
                    { new Guid("c643d023-1ff1-4091-bb8b-43afc55ce425"), "KG", "Kyrgyzstan" },
                    { new Guid("c72608fc-2ab2-44dc-bded-d15c0b95faef"), "NE", "Niger" },
                    { new Guid("c9006d2e-9711-4363-86be-65378a48d649"), "NZ", "New Zealand" },
                    { new Guid("cb16c20e-31d7-4339-8bd1-2e267a644e04"), "DM", "Dominica" },
                    { new Guid("cb759236-b5e8-43ab-bd64-9e2a5329174d"), "ZA", "South Africa" },
                    { new Guid("cd5a2f8a-13e5-4fe4-b826-0aa35afc2c07"), "CF", "Central African Republic" },
                    { new Guid("ce85499a-5bbb-4181-96e1-3e40478ee041"), "DJ", "Djibouti" },
                    { new Guid("cf5d2ed5-19e5-48de-a2fc-25f6d5300731"), "RS", "Serbia" },
                    { new Guid("d1113417-0880-4865-96cb-b688806c593f"), "TT", "Trinidad and Tobago" },
                    { new Guid("d142cde5-504c-4787-8176-cf9b6703cab0"), "RU", "Russia" },
                    { new Guid("d25e85d8-f167-472e-b0eb-1862e6d4e7a6"), "PL", "Poland" },
                    { new Guid("d571834c-e66b-428d-8f41-6dee3353cfae"), "DK", "Denmark" },
                    { new Guid("d73a7acd-b604-4f36-b860-6dbc2fbf7e01"), "GN", "Guinea" },
                    { new Guid("d7d2ba82-01bc-492a-bcde-c733ffdd6317"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("d83897b5-230a-42b1-b0d9-0c060e267384"), "TM", "Turkmenistan" },
                    { new Guid("d9e956bd-95f4-451a-b438-e45d081789b1"), "SD", "Sudan" },
                    { new Guid("dae16fc6-7301-435f-9f7e-7c04ddd98fec"), "TJ", "Tajikistan" },
                    { new Guid("dd368d3a-d3bd-474a-823e-f2226c370557"), "ST", "Sao Tome and Principe" },
                    { new Guid("dd895c21-c8f7-4b7e-9e22-dd2b4fc9e772"), "BN", "Brunei" },
                    { new Guid("ddec1f00-75de-4347-9eb4-8d05a268845d"), "PK", "Pakistan" },
                    { new Guid("de85bfbf-6d8e-48a2-877c-e5f47d34f88c"), "GY", "Guyana" },
                    { new Guid("dee1801e-62e9-40d9-9f07-52684a37713c"), "LY", "Libya" },
                    { new Guid("df319d95-86da-4ede-8893-f290cfa59735"), "AO", "Angola" },
                    { new Guid("dfe63bb2-fd2c-44fe-a792-dabee6326cbf"), "PT", "Portugal" },
                    { new Guid("e2ca7710-03b8-42cc-911d-a3b764eb67df"), "QA", "Qatar" },
                    { new Guid("e597b08d-e573-458a-9f9a-66ced2cb5666"), "CV", "Cabo Verde" },
                    { new Guid("e61c83e2-a5d5-4b24-b2b7-9f05d1396d5e"), "DO", "Dominican Republic" },
                    { new Guid("ecb29d39-2b90-441a-a017-0f447d4e5c8e"), "CL", "Chile" },
                    { new Guid("ed1f2647-15cf-4790-9a8a-d0f1757b3ed4"), "FI", "Finland" },
                    { new Guid("ee42f600-2f6f-4bf3-8cd5-b52f7d0c3ebd"), "LB", "Lebanon" },
                    { new Guid("ee79fd96-2739-48ac-b8a5-cd4bbe26c9a5"), "KH", "Cambodia" },
                    { new Guid("eee49b97-4a49-474d-830d-8cbf39f3ce7f"), "SM", "San Marino" },
                    { new Guid("ef986182-cf58-4337-a5fc-1ca35a3867f1"), "NL", "Netherlands" },
                    { new Guid("efb5ae05-0422-4af5-97e6-832bf151c520"), "KI", "Kiribati" },
                    { new Guid("f0ad2d4c-795f-4385-a547-0dc459d4b2d0"), "ZW", "Zimbabwe" },
                    { new Guid("f0e03f14-7aa6-4468-b3ab-52b650d71331"), "LV", "Latvia" },
                    { new Guid("f2141445-b2a8-4e75-9862-77b5e83231e1"), "ES", "Spain" },
                    { new Guid("f380468e-0062-447e-bf7d-d73356e704a3"), "FJ", "Fiji" },
                    { new Guid("f4e92e71-e00f-4632-b7bf-e217262f0de1"), "PW", "Palau" },
                    { new Guid("f5ddb78f-bc3e-418a-8ae0-e3548aa4d45e"), "GB", "United Kingdom" },
                    { new Guid("f630f53b-5b1e-43ba-ba50-8561e54aaeca"), "ID", "Indonesia" },
                    { new Guid("f72b4fb0-a786-4903-85ec-2c6e9d559326"), "EC", "Ecuador" },
                    { new Guid("f9d506f3-b1b7-489e-8b86-917f7eece1a9"), "IE", "Ireland" },
                    { new Guid("fa1c3133-eb0e-4328-8ae7-ae62f8976c2d"), "BR", "Brazil" },
                    { new Guid("fae9da98-5d8f-4e97-b4ba-82b575e279ed"), "US", "United States of America" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("05231c79-5e4f-460e-9597-b2fe5677cecf"), "Female" },
                    { new Guid("827dffea-7052-413e-a7cc-368cb274da88"), "Male" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("306d9005-1520-4dcb-a295-036f2213ab15"), "Postoperative Care" },
                    { new Guid("3336abe0-d5db-4ff1-b454-3e7cb1e32e07"), "Preventive Interventions" },
                    { new Guid("58a8b0da-b0bb-4e6f-af58-1633a6019112"), "Exotic and Specialized Interventions" },
                    { new Guid("657de94b-3d6a-4c47-8c31-06e2c2a7a484"), "Diagnostic Interventions" },
                    { new Guid("6682660b-7981-4b50-87bf-d5da30c62f7f"), "Surgical Interventions" },
                    { new Guid("b7093e22-e83f-4618-9a7d-d7147889d240"), "Therapeutic Interventions" },
                    { new Guid("b8e8734d-4d50-4af2-b2b4-47371b8a1310"), "Oncological Interventions" },
                    { new Guid("d17ce6e5-5b18-4a65-a58d-870c5b831e10"), "Obstetric and Reproductive Interventions" },
                    { new Guid("d1c815b8-7685-41a9-a6f1-d581a904d597"), "Dental Interventions" },
                    { new Guid("f950887e-cfb5-41fe-917a-4cccc9ba201d"), "Emergency" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserBookings_BookingId",
                table: "ApplicationUserBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPets_ApplicationUserId",
                table: "ApplicationUserPets",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPets_PetId",
                table: "ApplicationUserPets",
                column: "PetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserBookings");

            migrationBuilder.DropTable(
                name: "ApplicationUserPets");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00c9fd12-161b-4742-95cc-ed3db3c8dd94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03360e94-1f78-4c63-8780-bb7bbb6946a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0340b094-7fc9-460b-a47e-a00747999bc4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("040838ab-1e0c-47f9-95e0-439276737890"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0598b43d-418f-44e3-9e58-00b2141dcbd0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0609ba1c-0f7e-4f38-aed9-d2cd3d26df9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0919bf22-d2ef-42c3-b7ca-c7a9ea10b5f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1035ebe7-1635-41cf-ad95-88c730204d6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("107ca22e-10f8-456a-abb4-27836e0df26e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("119281cd-f54e-4e93-8b0b-1dabc0d7753e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11fc0791-6b55-4540-83b8-12737a48cf7e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("148587ac-226a-481c-bea1-aa70b62efff1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1605d968-2259-46e2-9663-de19b418abf5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("165e0728-430e-438b-93cf-2b3679d0a304"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1669da8e-de20-4db1-8038-2c2b6f16efbd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("178455fa-c782-4840-bcb7-be666e0c6b42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1943c74e-202c-49f8-bbea-f4f15e57ef27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1aef320a-b965-4ec4-a401-737f9b673437"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e2e450b-335d-4c40-b5b0-adc6806d96e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ef7a575-1eb9-478b-b1cd-9151494fb987"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20c9548a-29b5-462f-afc3-d50900963209"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("227e62f6-7b88-4e95-97bb-5524c813bc9d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("233fd5fd-2810-44a8-8a25-614398869a6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("237cbad6-8eba-4d24-ab34-9d597c366ce6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2428c6df-ee51-4d9f-912d-f583c0999cac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("257b5408-260c-4abe-9fba-3807eda0290a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25a672e5-8957-4e5a-96c7-6866dba6d0c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27035b42-bfa0-44fb-853f-29c8e1b9e5b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2878637d-002a-4789-912f-460a376de679"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28b41fde-3764-425d-ad9b-75c0102e283f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28befb04-c3c6-4483-8a1e-053a243d34f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28bf3bcc-30df-42a7-94ea-a0f617077888"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c003c03-cca0-43b9-a03d-8c27516d05a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c521c5c-8759-4370-8dd3-c7da515fc6eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ddd70ee-4224-4d63-9a6d-b9d61ff70b74"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e378e42-c37d-495b-8329-2ea20ca05b72"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("316c8055-e8de-4905-8141-bcb27b96bda9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("316e25ab-3342-426f-96f6-d780c06143e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31782bbb-ffe4-4fd4-9399-edf55f35b60e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31a990e1-a36b-4396-8818-efdbe0dc26d7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31f58b83-0db7-47d6-919d-6151d9524507"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32e292dc-1d0b-4418-90c8-5178282a02c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33d3e4a0-1159-4397-b310-31469201b938"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37e9a54f-5e0a-4e27-b846-78b8ba28d376"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("392840a0-8a81-48dd-94a0-8aaeb03fd1b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a7e1a83-b638-4b5e-a794-71ba013170c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c3ae71e-a064-4e55-b0a1-065789e4a467"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c92f989-2dd9-4f51-bb6d-d2293c3ef906"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d36971e-178e-4deb-b20b-57980ece82df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d9db975-a1db-4c71-a34e-c196c5ab4222"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3eab68dc-41c7-4e20-b88f-2a271e44174a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3fce0d89-faf0-44dd-8ce6-e76f80ae128e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41942c2f-2891-4444-836e-6ca50a268736"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4253316d-ac3d-4d25-81d2-e9ad1d60042d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("425de634-7138-4a5f-94dd-3dd1688e7d72"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46115999-7a10-4f92-b7d4-8f27450f1a9a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("494d66f6-4d22-485d-83c7-aadda9be4148"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4bbd7e14-8af6-46ef-b5af-25641b1a857c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c8680bb-75b0-45e6-bd80-48178ffed038"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4daaaa30-4c49-4a99-9169-979d92fede5d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ddf7b23-a978-4b5f-9e2f-7baed184443f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4e824f6e-1c45-421d-b0f2-97bfb939803f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4eba3b14-c6b1-49a8-a635-eb1c7a3c0eda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ff79052-c22e-4f29-acff-6a4ca7d22448"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("518b01d6-d88a-4819-b6c6-3c64117c214f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5195997b-d3c2-4ecc-a78b-1bdd647b22ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("563ab821-9409-468b-83ae-7e418cb03075"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("566456e9-d9a3-4384-9df2-e6d4768ee6d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56805e90-4518-4ea1-9937-c3743f0e75da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a45d37a-e6ad-459e-95fb-09c867823bdd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ca3bb7f-04b8-49de-b47a-606830c69119"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60ca56ea-4d2c-493f-be2a-0c28d06941de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6121520e-af9a-4c60-b662-b79498eaf294"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("630afb03-7600-4d02-a240-4caa67fb41ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6375a023-8b1c-44ad-8c91-e046ac27b849"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64d46e64-6d50-49d9-942e-a4a2a2224398"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("672a7573-3b64-403a-9777-391aa0a39667"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("696f63b9-dc1d-43e1-b5aa-1614042e5764"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a373c82-5fbc-4848-a7cb-bd8434487c53"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6cefe58a-40bd-4a06-8ed2-694d2ada9acd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e58ae99-ded0-40dc-9f7a-74173b974eb3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fa2b2aa-f19c-4a05-b440-56e4817ec654"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fa2d577-3c00-47ca-a037-a1c7e4b5bcfa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fdd1509-8659-4e7c-8e5a-895b45b31018"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7097be75-1720-4f2a-aba2-beb6e5843c75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70d2f0aa-a7d0-4de4-a31b-444ee5ceb86e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71b64707-79a8-4154-8132-cd165d36985e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("726d587c-ad23-44ce-9035-76973942fbb1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7392f432-d532-4b4e-ac5d-81a88426743a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("74bc92e8-00a6-44f0-9036-84755a5eb8be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("74f56d2d-8a6e-41b8-aa82-96e8d5265ff0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("754b4674-ce80-45e0-91de-d2b9df454007"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77d7ffd8-b6c9-43fe-98b4-09b2993e579a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78a010e9-69ec-43e7-b14b-f95a3a0f4342"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("795114a5-63e5-4eb5-bcfd-1e465dbd329d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("797e7ba2-0276-4e22-bba5-b5143be4f388"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7afedbd6-92f7-496d-8a99-5ab6daf3b80b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7cd82cbd-53bc-4a29-a6e3-8a96f8d14dfb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f8ea933-7e2b-451d-812b-c34c66c4c8ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80dd8a3f-93dc-4b90-a97b-ec65677d2638"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84e8c704-42e9-4e54-8b2d-98786dcbc83d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87114e14-dda9-4f38-bb04-61b06ce89a50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("871c8dcb-ec0d-4645-911e-0b10622c03c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("880612ed-ed0d-4f3a-abc2-842e8749156a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8877ba17-065d-4aef-a957-0242b8465000"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89163a30-d998-43f6-b27a-8080544ea7a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ac2cc06-6087-424c-a308-1b98d4ad0806"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e4b4af2-d7f7-4d27-8669-a64e640bdf2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8fba8e7c-a009-427a-bb6f-a9b5c68c1c21"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("913b8bb1-9210-423f-a8b3-7dc220d8a478"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91d7fb4c-a92d-4022-b566-d842586242b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92019bf3-c53e-48cd-ba51-b614f57c3d52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9560e4be-8c05-4d67-9e05-4f2a151747b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97a3f259-23db-4781-bb41-d2d01e7da088"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b4d48e8-da45-4441-a15e-444748bc4b2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b4eafa6-1b38-41d0-8a4c-89e7687e32ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c4d15f8-c80f-47db-b42c-692d3b7076a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9dd999ba-5d6a-43df-8bfc-d5197f2eecb1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9edeb93c-be36-451b-b6e8-15d2bc8739b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9fa8cbf6-9326-4531-85e8-d9eb3a98264d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a11201c3-a234-4e58-9883-eee958b12630"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1596a4e-afcb-4d68-ac30-93a70e027fcc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2d8449b-1e84-4ead-8eb8-9c06c9d85f30"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a55ff4e8-0f61-4b8d-87dd-0e3f0a6dbce2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a5de9750-dfb2-41d0-a309-bac181711546"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a640af91-4fd4-45be-99f0-5f8743b59f20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a7d2e266-4cde-4f3c-beac-82bfaac56b6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a8f9362e-b12d-4b79-9f32-aa29918734ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a990a0c0-821b-4f12-b06f-270fbd5b0c6f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9e34df4-ff1f-4498-8577-e08dfe18a9e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa422f6c-7816-4987-8248-d522fd9e74eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("acf15cd1-c6d0-41f0-bd80-ef9a0c1a67df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b129eabb-f63e-43fa-b545-7b5c8b1cd6da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2f7033a-aa8c-464e-b678-0fb1bcc448c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b34cac6b-f9e8-4896-8569-40a3179081a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b53a5f51-a8de-4167-86f7-1c9ad797c10a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8948d66-b089-4544-b04e-b1cb0bff701f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bae3ec07-b687-425a-8332-ebc053875c11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb2aff76-00ae-4060-849e-2a9f4da05a10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd10cf99-97b6-4c20-b222-546686cb047d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd2d8d73-99f5-4f3a-a80c-84ed2bc014ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be77379d-d6f8-4061-b936-90aa8f1c0ca2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf1ec804-a783-43f3-97ae-cb09aa1bd970"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf57aa5e-ea5c-488a-a062-efb036fbd4de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0406073-a685-4667-a9ff-7ed61c704777"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c24378df-bc6d-4819-a099-bc800891318c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c395942c-5fe2-41da-ad73-1f3480a2d286"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c49d6450-2bd8-4037-b090-45614ec684d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5842ea0-1cc3-41f0-b56c-f904c53d3141"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c643d023-1ff1-4091-bb8b-43afc55ce425"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c72608fc-2ab2-44dc-bded-d15c0b95faef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9006d2e-9711-4363-86be-65378a48d649"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb16c20e-31d7-4339-8bd1-2e267a644e04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb759236-b5e8-43ab-bd64-9e2a5329174d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd5a2f8a-13e5-4fe4-b826-0aa35afc2c07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce85499a-5bbb-4181-96e1-3e40478ee041"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf5d2ed5-19e5-48de-a2fc-25f6d5300731"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1113417-0880-4865-96cb-b688806c593f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d142cde5-504c-4787-8176-cf9b6703cab0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d25e85d8-f167-472e-b0eb-1862e6d4e7a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d571834c-e66b-428d-8f41-6dee3353cfae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d73a7acd-b604-4f36-b860-6dbc2fbf7e01"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7d2ba82-01bc-492a-bcde-c733ffdd6317"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d83897b5-230a-42b1-b0d9-0c060e267384"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9e956bd-95f4-451a-b438-e45d081789b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dae16fc6-7301-435f-9f7e-7c04ddd98fec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd368d3a-d3bd-474a-823e-f2226c370557"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd895c21-c8f7-4b7e-9e22-dd2b4fc9e772"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddec1f00-75de-4347-9eb4-8d05a268845d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de85bfbf-6d8e-48a2-877c-e5f47d34f88c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dee1801e-62e9-40d9-9f07-52684a37713c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df319d95-86da-4ede-8893-f290cfa59735"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dfe63bb2-fd2c-44fe-a792-dabee6326cbf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e2ca7710-03b8-42cc-911d-a3b764eb67df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e597b08d-e573-458a-9f9a-66ced2cb5666"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e61c83e2-a5d5-4b24-b2b7-9f05d1396d5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ecb29d39-2b90-441a-a017-0f447d4e5c8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed1f2647-15cf-4790-9a8a-d0f1757b3ed4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee42f600-2f6f-4bf3-8cd5-b52f7d0c3ebd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee79fd96-2739-48ac-b8a5-cd4bbe26c9a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eee49b97-4a49-474d-830d-8cbf39f3ce7f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef986182-cf58-4337-a5fc-1ca35a3867f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efb5ae05-0422-4af5-97e6-832bf151c520"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0ad2d4c-795f-4385-a547-0dc459d4b2d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0e03f14-7aa6-4468-b3ab-52b650d71331"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2141445-b2a8-4e75-9862-77b5e83231e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f380468e-0062-447e-bf7d-d73356e704a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4e92e71-e00f-4632-b7bf-e217262f0de1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5ddb78f-bc3e-418a-8ae0-e3548aa4d45e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f630f53b-5b1e-43ba-ba50-8561e54aaeca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f72b4fb0-a786-4903-85ec-2c6e9d559326"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9d506f3-b1b7-489e-8b86-917f7eece1a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa1c3133-eb0e-4328-8ae7-ae62f8976c2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fae9da98-5d8f-4e97-b4ba-82b575e279ed"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("05231c79-5e4f-460e-9597-b2fe5677cecf"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("827dffea-7052-413e-a7cc-368cb274da88"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("306d9005-1520-4dcb-a295-036f2213ab15"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3336abe0-d5db-4ff1-b454-3e7cb1e32e07"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("58a8b0da-b0bb-4e6f-af58-1633a6019112"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("657de94b-3d6a-4c47-8c31-06e2c2a7a484"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("6682660b-7981-4b50-87bf-d5da30c62f7f"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("b7093e22-e83f-4618-9a7d-d7147889d240"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("b8e8734d-4d50-4af2-b2b4-47371b8a1310"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("d17ce6e5-5b18-4a65-a58d-870c5b831e10"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("d1c815b8-7685-41a9-a6f1-d581a904d597"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f950887e-cfb5-41fe-917a-4cccc9ba201d"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Interventions");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Interventions");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Interventions");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TypeInspections",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "TypeInterventionName",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Type Intervention Name");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "TypeInspections",
                type: "uniqueidentifier",
                nullable: false,
                comment: "TypeInspectionId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Type Inspection Id");

            migrationBuilder.AlterColumn<string>(
                name: "TransponderLocation",
                table: "Pets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "PetLocationOfTheTransponder",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Pet Location Of The Transponder");

            migrationBuilder.AlterColumn<string>(
                name: "TransponderCode",
                table: "Pets",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                comment: "PetTransponderAlphanumericCode",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldComment: "Pet Transponder Alphanumeric Code");

            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Pets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "PetSpecies",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Pet Species");

            migrationBuilder.AlterColumn<int>(
                name: "PassportNumber",
                table: "Pets",
                type: "int",
                nullable: false,
                comment: "PetNumberOfPassport",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "PetNumber Of Passport");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "PetName",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Pet Name");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Pets",
                type: "bit",
                nullable: false,
                comment: "PetSoftDeleted",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deleted status");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                comment: "PetImage",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Pet Image");

            migrationBuilder.AlterColumn<Guid>(
                name: "GenderId",
                table: "Pets",
                type: "uniqueidentifier",
                nullable: false,
                comment: "GenderId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Gender Id");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Pets",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "PetAdditionalDetails",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Pet Additional Details");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Pets",
                type: "datetime2",
                nullable: false,
                comment: "PetDateOfBirth",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "PetDate Of Birth");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "Pets",
                type: "uniqueidentifier",
                nullable: false,
                comment: "CountryId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Country Id");

            migrationBuilder.AlterColumn<string>(
                name: "Breed",
                table: "Pets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "PetBreed",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Pet Breed");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Pets",
                type: "uniqueidentifier",
                nullable: false,
                comment: "PetId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Identifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "InterventionId",
                table: "PetInterventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "InterventionId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Intervention Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "PetId",
                table: "PetInterventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "PetId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Pet Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "UserId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "User Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "TypeInspectionId",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "TypeOfInspection",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Type Of Inspection");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Interventions",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                comment: "PriceForIntervention",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4,
                oldComment: "Price For Intervention");

            migrationBuilder.AlterColumn<Guid>(
                name: "PetId",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "PetId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Pet Id");

            migrationBuilder.AlterColumn<bool>(
                name: "IsInterventionDone",
                table: "Interventions",
                type: "bit",
                nullable: false,
                comment: "InterventionStatus",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Intervention Status");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Interventions",
                type: "bit",
                nullable: false,
                comment: "BookingInterventionSoftDeleted",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deleted status");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "DoctorId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Doctor Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Interventions",
                type: "datetime2",
                nullable: false,
                comment: "DateOfIntervention",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Date Of Intervention");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Interventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "InterventionId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genders",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                comment: "GenderName",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldComment: "Gender Name");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Genders",
                type: "uniqueidentifier",
                nullable: false,
                comment: "PetGenderId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Pet Gender Id");

            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Doctors",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                comment: "DoctorTown",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldComment: "Doctor Town");

            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "Doctors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "DoctorSpecialty",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Doctor Specialty");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Doctors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "PhoneNumber",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Phone Number");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Doctors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "DoctorLastName",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Doctor Last Name");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                type: "bit",
                nullable: false,
                comment: "DoctorSoftDelete",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deleted status");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                comment: "DoctorImage",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Doctor Image");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Doctors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "DoctorFirstName",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Doctor First Name");

            migrationBuilder.AlterColumn<string>(
                name: "Experience",
                table: "Doctors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "DoctorExperience",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Doctor Experience");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Doctors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "DoctorEmailAddress",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Doctor Email Address");

            migrationBuilder.AlterColumn<string>(
                name: "Education",
                table: "Doctors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "DoctorEducation",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Doctor Education");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Doctors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "DoctorDetails",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Doctor Details");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                comment: "DoctorDateOfBirth",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Doctor Date Of Birth");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: false,
                comment: "CountryId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Country Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: false,
                comment: "DoctorId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Identifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "DoctorPets",
                type: "uniqueidentifier",
                nullable: false,
                comment: "DoctorId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Doctor Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "InterventionId",
                table: "DoctorInterventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "InterventionId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Intervention Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "DoctorInterventions",
                type: "uniqueidentifier",
                nullable: false,
                comment: "DoctorId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Doctor Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "BookingId",
                table: "DoctorBookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "BookingId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Booking Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "DoctorBookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "DoctorId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Doctor Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                comment: "CountryName",
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldComment: "Country Name");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Countries",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                comment: "CountryISOCode",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldComment: "Country ISOCode");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Countries",
                type: "uniqueidentifier",
                nullable: false,
                comment: "CountryId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Country Id");

            migrationBuilder.AlterColumn<string>(
                name: "WorkingTime",
                table: "Clinics",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "ClinicWorkingTime",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Clinic Working Time");

            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Clinics",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "ClinicTown",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Clinic Town");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clinics",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "ClinicPhone",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Clinic Phone");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clinics",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "ClinicName",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Clinic Name");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Clinics",
                type: "bit",
                nullable: false,
                comment: "ClinicSoftDeleted",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deleted status");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clinics",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "ClinicEmail",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Clinic Email");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "Clinics",
                type: "uniqueidentifier",
                nullable: false,
                comment: "CountryId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Country Id");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clinics",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "ClinicAddress",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Clinic Address");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Clinics",
                type: "uniqueidentifier",
                nullable: false,
                comment: "ClinicId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Identifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "ClinicDoctors",
                type: "uniqueidentifier",
                nullable: false,
                comment: "DoctorId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Doctor Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClinicId",
                table: "ClinicDoctors",
                type: "uniqueidentifier",
                nullable: false,
                comment: "ClinicId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Clinic Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "UserId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "User Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "TypeInspectionId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "TypeOfInspection",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Type Of Inspection");

            migrationBuilder.AlterColumn<Guid>(
                name: "PetId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "PetId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Pet Id");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Bookings",
                type: "bit",
                nullable: false,
                comment: "BookingInterventionSoftDeleted",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Deleted status");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "DoctorId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Doctor Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                comment: "DeletionTime",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Date of deleting");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                comment: "DateOfIntervention",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Date Of Intervention");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                comment: "BookingInterventionId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "LastName",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Last Name");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                comment: "UserDetailsSoftDeleted",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "State of delete");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                comment: "ImageUrl",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Image Url");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "FirstName",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "First Name");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                comment: "CountryId",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Country Id");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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
                        name: "FK_UserBookings_AspNetUsers_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
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
                        name: "FK_UserDetailsPets_AspNetUsers_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetailsPets_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                });

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
                name: "IX_UserBookings_BookingId",
                table: "UserBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailsPets_PetId",
                table: "UserDetailsPets",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailsPets_UserDetailsId",
                table: "UserDetailsPets",
                column: "UserDetailsId");
        }
    }
}
