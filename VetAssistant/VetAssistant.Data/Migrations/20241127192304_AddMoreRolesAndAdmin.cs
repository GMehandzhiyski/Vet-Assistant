using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreRolesAndAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("00565012-9279-4581-863d-49c17d359ee9"), "TR", "Turkey" },
                    { new Guid("019343f5-09c0-47a6-84e7-dc47e95fdf76"), "TM", "Turkmenistan" },
                    { new Guid("023ab01f-b46c-4f7d-a59c-355c21921173"), "SL", "Sierra Leone" },
                    { new Guid("03257e5f-3ad2-4624-aadc-50f93a0cb25f"), "KZ", "Kazakhstan" },
                    { new Guid("043e8893-7500-45e5-9339-f40e818699af"), "AU", "Australia" },
                    { new Guid("04edb84f-af72-4027-83d2-80b1964b17a7"), "KR", "South Korea" },
                    { new Guid("056d5604-c540-43fe-9650-18e8566fcc1b"), "AE", "United Arab Emirates" },
                    { new Guid("05a535fd-65f9-4e34-b4d5-f82ac2ec573e"), "BI", "Burundi" },
                    { new Guid("0a3313ac-9322-45fa-b1da-74caed77d40b"), "ID", "Indonesia" },
                    { new Guid("0ad6c563-3af2-4a48-9511-fdbb475ba58f"), "NO", "Norway" },
                    { new Guid("0b2a4cbc-3c1c-4b12-8dbd-246f00790473"), "CN", "China" },
                    { new Guid("0b7fdc34-55ac-46c7-b789-c9efafe5b6f3"), "VA", "Holy See" },
                    { new Guid("0dc373b2-39c5-4d9e-b6c3-55e3aaebc3f9"), "AR", "Argentina" },
                    { new Guid("0f70da9d-85e3-41ca-986a-72a524ae1035"), "TZ", "Tanzania" },
                    { new Guid("10549df4-68ab-4170-8bec-b6e0a4b9b1d1"), "ES", "Spain" },
                    { new Guid("10f8fe69-c587-4b40-8701-228578534a2a"), "LS", "Lesotho" },
                    { new Guid("11f49162-9efd-4169-8d20-0f9e115aca3d"), "ET", "Ethiopia" },
                    { new Guid("1290e1ac-77de-4b27-b878-ac94d0f2182f"), "ME", "Montenegro" },
                    { new Guid("133c0aa3-9148-4791-a69f-2a0afa775cac"), "BZ", "Belize" },
                    { new Guid("14a346a1-2688-43da-a7dc-023b4182087a"), "CO", "Colombia" },
                    { new Guid("165f742c-ee32-4233-9568-1b204229e532"), "CL", "Chile" },
                    { new Guid("17dd7423-cd0c-4662-a4fb-46ccce05fc7c"), "TO", "Tonga" },
                    { new Guid("18760771-6311-41a9-895b-115db14fc2ce"), "SC", "Seychelles" },
                    { new Guid("18f9e126-d765-44ae-bb2e-5c6554d44dc9"), "SD", "Sudan" },
                    { new Guid("1bdf62f3-aaae-4f6a-99fd-89a8c3430850"), "BG", "Bulgaria" },
                    { new Guid("1ff582f2-4380-4ae7-853f-def75e28697a"), "LY", "Libya" },
                    { new Guid("21a3b4c6-6608-4148-b35e-a0d5c987794d"), "JO", "Jordan" },
                    { new Guid("23defec6-1de4-45a6-a7d3-f564460b2e53"), "MC", "Monaco" },
                    { new Guid("24b1bbd7-2163-441c-a15d-f61c0e9052d9"), "HU", "Hungary" },
                    { new Guid("24f392f3-387e-49a1-80ff-39765c7ad009"), "ER", "Eritrea" },
                    { new Guid("25f0907c-396a-431d-8916-ec82c63f3ec9"), "KE", "Kenya" },
                    { new Guid("2886fcb5-df01-47f9-bee6-18094444b191"), "MA", "Morocco" },
                    { new Guid("2900d4ec-75af-43e3-b65b-7c9df2abe48a"), "AZ", "Azerbaijan" },
                    { new Guid("29d29e8f-6676-4b15-bbea-592e314ac8ed"), "MH", "Marshall Islands" },
                    { new Guid("2c1e2d71-c167-43ae-b640-399a8b6ac229"), "CV", "Cabo Verde" },
                    { new Guid("2cb88465-05b6-445a-8e0b-61fa03174102"), "SY", "Syria" },
                    { new Guid("2e0485c2-4778-4920-a24a-a10fd7fe87a6"), "GQ", "Equatorial Guinea" },
                    { new Guid("2eb1a3ea-716e-425b-9ce0-2adc2ee6c82c"), "VU", "Vanuatu" },
                    { new Guid("2f21dcac-1b05-4118-9367-1604e07a0df4"), "PA", "Panama" },
                    { new Guid("2fbd0269-3064-447f-a626-318182c7bdb3"), "PL", "Poland" },
                    { new Guid("2fe7e5da-5276-466a-b013-b9f08514ba93"), "LB", "Lebanon" },
                    { new Guid("30188779-2b42-47e5-978a-a91d71bf33da"), "GN", "Guinea" },
                    { new Guid("311dab1c-cf3f-47ba-a6f9-cd21f9b99f9d"), "CY", "Cyprus" },
                    { new Guid("334a5f12-4bae-4639-9b65-29b8b572b749"), "SR", "Suriname" },
                    { new Guid("337d5f83-8695-4740-b25c-2879139a556b"), "IT", "Italy" },
                    { new Guid("33e94504-62c4-45f1-9846-f33f91affb68"), "ZW", "Zimbabwe" },
                    { new Guid("34480e1a-13d2-4ce0-88b0-dc4abe03f4fe"), "SZ", "Eswatini" },
                    { new Guid("35cfae65-e54a-4aef-8f98-a11226da4066"), "NE", "Niger" },
                    { new Guid("36fbaf20-b271-4847-9489-58a2b9644dc5"), "LC", "Saint Lucia" },
                    { new Guid("371f83ba-f969-4845-acac-7701bed6aa5b"), "AD", "Andorra" },
                    { new Guid("37e80bf6-db7c-4c4b-bd2b-d1bd6d481edf"), "CH", "Switzerland" },
                    { new Guid("39b664da-362f-40b3-96f0-e65ff6543ab4"), "TT", "Trinidad and Tobago" },
                    { new Guid("3b41f02a-6eed-4bfa-991a-dbe9b9bd8385"), "ZM", "Zambia" },
                    { new Guid("3ce692d7-1365-424f-b0a6-575022c02e26"), "VN", "Vietnam" },
                    { new Guid("4312bd41-2f93-4603-a0b4-244625175bec"), "SI", "Slovenia" },
                    { new Guid("431431be-b518-4c05-a129-a6d3db7fac4a"), "SA", "Saudi Arabia" },
                    { new Guid("4596f554-dbb8-474e-b5e6-571f3b7cdeaa"), "HT", "Haiti" },
                    { new Guid("488d6594-e1e6-4b58-b19c-295cce89f5f2"), "ML", "Mali" },
                    { new Guid("4892f47d-312b-408d-a344-7e4ae0b3cf64"), "BS", "Bahamas" },
                    { new Guid("4b0cca85-dc14-4305-bafa-a9b024c99671"), "LI", "Liechtenstein" },
                    { new Guid("4c02f251-851e-4801-95f5-5006c3c18136"), "DJ", "Djibouti" },
                    { new Guid("4dc5e40a-73e6-4127-95aa-0a1c012c80e8"), "TL", "Timor-Leste" },
                    { new Guid("4e313f02-7d96-4da2-a0fb-e521463fb7c5"), "TG", "Togo" },
                    { new Guid("4e5f4ca7-4797-4c0e-87d6-7f345602326c"), "RU", "Russia" },
                    { new Guid("4ff5c3c8-d1e1-44fc-af0f-273b07e0cfbb"), "VE", "Venezuela" },
                    { new Guid("5112db01-3f75-4c9a-9984-2f3065761f94"), "GD", "Grenada" },
                    { new Guid("526e94c1-358b-4789-ae00-7eaf67853ebd"), "GM", "Gambia" },
                    { new Guid("5291e61a-aba1-4d91-9047-1a9b2ca9772b"), "KM", "Comoros" },
                    { new Guid("53279f12-c1a7-482b-9b9a-3aa3a4e61db2"), "JP", "Japan" },
                    { new Guid("552a901b-ec57-4789-b9da-9a0fc3e82400"), "AF", "Afghanistan" },
                    { new Guid("55eaade4-efe7-44b8-989f-7f55974a1dcb"), "SO", "Somalia" },
                    { new Guid("566dabe5-44c1-4e01-af1d-56cdeb39d6c9"), "BO", "Bolivia" },
                    { new Guid("56b873d7-e523-4638-a363-77a51b570231"), "FI", "Finland" },
                    { new Guid("56c9c948-8d3b-4bd6-9c81-df8a818aa25d"), "PS", "Palestine" },
                    { new Guid("58010e2e-aeba-431f-96cf-f4eb1aa571c4"), "CF", "Central African Republic" },
                    { new Guid("59508a82-3baa-4b4d-b4b5-b9fbf739ed9e"), "BF", "Burkina Faso" },
                    { new Guid("59c7830a-aef2-4ffd-b3fc-a3c628573a96"), "AM", "Armenia" },
                    { new Guid("59f57fe6-0b2b-4916-838b-16af3d779e32"), "DE", "Germany" },
                    { new Guid("5a8f12c3-723d-4f18-bdca-ab546ba2cbe9"), "LK", "Sri Lanka" },
                    { new Guid("5d76886e-bf6f-4b73-a6d1-888c0431afd3"), "PW", "Palau" },
                    { new Guid("5deb4488-8c67-4f7d-aa01-10d1b1536ff4"), "IR", "Iran" },
                    { new Guid("5e00d3af-7c18-412d-825f-51580e86385d"), "UG", "Uganda" },
                    { new Guid("5ed872ad-0ce3-4f31-aabd-a8092ac2bcf4"), "BB", "Barbados" },
                    { new Guid("5ff41b1f-5db1-422f-bdf1-c7258f05b419"), "MK", "North Macedonia" },
                    { new Guid("6058418b-7ab4-4b97-b380-0306bf9a01ff"), "JM", "Jamaica" },
                    { new Guid("6249734e-5b5f-4594-963d-8103bb78e054"), "SS", "South Sudan" },
                    { new Guid("63151f7a-8dba-4424-be59-c094119724c8"), "IN", "India" },
                    { new Guid("63f11491-c02d-43a5-b29e-72df868239fa"), "BT", "Bhutan" },
                    { new Guid("64501b12-3f3f-4da1-980c-d4f202261e20"), "MX", "Mexico" },
                    { new Guid("6544bc7a-31b5-4b9a-bd08-6f29de329fb4"), "DM", "Dominica" },
                    { new Guid("666c3e2e-2033-44d2-a495-f304d1daa2f1"), "NR", "Nauru" },
                    { new Guid("66cc5c69-77b8-436b-8c99-4a3ef8be2ab6"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("6a0eab01-6f5a-45ec-b6d1-cf8852bd592e"), "MT", "Malta" },
                    { new Guid("6a2aa3ed-f3bc-4d08-88aa-586d19ba5da9"), "CU", "Cuba" },
                    { new Guid("6ce0bfaf-7b3c-418c-8933-dd33d93ca1f6"), "KI", "Kiribati" },
                    { new Guid("70e6a498-3b4b-4a5c-8a6f-4902c0854d95"), "GY", "Guyana" },
                    { new Guid("76d90a07-6a36-4726-810d-0b36b0a69cdf"), "OM", "Oman" },
                    { new Guid("76f14832-6af2-41c0-b29d-5d2f4d107081"), "SM", "San Marino" },
                    { new Guid("77564f58-da4b-4687-9821-7be9e7981caa"), "AG", "Antigua and Barbuda" },
                    { new Guid("78a08f2f-fcac-4976-bea1-de03808f7bd1"), "RS", "Serbia" },
                    { new Guid("78c2d0cd-f0fa-40b6-9d49-aad1af36bc0d"), "BY", "Belarus" },
                    { new Guid("7ae46693-7986-483e-aa1f-4b3d065d3181"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("7b47b53c-7058-4631-a89b-d2af78ecb67e"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("7d2f3892-6faf-4d63-823e-c425e9c56c57"), "BD", "Bangladesh" },
                    { new Guid("7e63ac00-b9cb-403d-8b3e-cb5a934391ee"), "BW", "Botswana" },
                    { new Guid("80a16eef-8105-4071-9b60-f88e023f063a"), "NA", "Namibia" },
                    { new Guid("826303a6-bef6-45bd-b0d5-9e268d6ae217"), "KW", "Kuwait" },
                    { new Guid("82de8d18-dadd-49a6-9010-fe9c3af3f71c"), "TD", "Chad" },
                    { new Guid("83cc4b34-dea3-43c7-a493-16eec87d2e45"), "CA", "Canada" },
                    { new Guid("8438752c-f9ae-40a6-ae05-3c481b0956e6"), "NG", "Nigeria" },
                    { new Guid("84595b3e-efb4-40f1-833f-fac549261e35"), "MR", "Mauritania" },
                    { new Guid("8560ea64-5be1-4830-bbbe-e68ab5d9928c"), "NI", "Nicaragua" },
                    { new Guid("8977b647-d27a-46e5-b517-9b39fddeb796"), "GH", "Ghana" },
                    { new Guid("89f2fa28-f2de-4008-a3ec-98dd2ac105c3"), "KH", "Cambodia" },
                    { new Guid("8a1a8e2e-4957-413a-8d1a-e6972b77e25f"), "VA", "Vatican City" },
                    { new Guid("8d07a9a8-4835-4359-a406-111bceea05c7"), "GW", "Guinea-Bissau" },
                    { new Guid("8eaf9394-a5d0-4c93-a12b-1b92af20ff12"), "MN", "Mongolia" },
                    { new Guid("8f41a54c-d9e5-4613-81f0-d9911899be90"), "SB", "Solomon Islands" },
                    { new Guid("91b319d4-aaf0-4be7-9ed5-f1d587bff495"), "IL", "Israel" },
                    { new Guid("95016b60-584e-46c6-8b84-48ae94f47056"), "PT", "Portugal" },
                    { new Guid("973b30d0-60e1-46b6-89fb-c38619f02579"), "RO", "Romania" },
                    { new Guid("97ceaac0-4486-4ebf-a9f1-2c5b71806253"), "FR", "France" },
                    { new Guid("98c49387-14ce-4aef-be6c-3c79ab6af7b9"), "SE", "Sweden" },
                    { new Guid("99a1fc7d-7544-4c72-b67a-475f0b2d72a6"), "UY", "Uruguay" },
                    { new Guid("9bb7a9d7-9610-45c1-bbda-4c6536ca0490"), "ZA", "South Africa" },
                    { new Guid("9c69b492-e9b8-476c-826b-f3cfb6987928"), "US", "United States of America" },
                    { new Guid("9ca370a5-e98e-4e42-a90a-3ea44cfda183"), "MW", "Malawi" },
                    { new Guid("9f9ae508-faa4-49c7-9206-a80949c3acd4"), "PE", "Peru" },
                    { new Guid("9fbd6bbf-b2af-46c1-a222-ecad83716104"), "NL", "Netherlands" },
                    { new Guid("a0383304-2b73-4a97-b48c-aa65a7519029"), "IS", "Iceland" },
                    { new Guid("a4c7d2e2-15ca-4041-ac43-12c10b8e7a99"), "TN", "Tunisia" },
                    { new Guid("a632589c-7b0b-4ac2-af15-5cff971331bc"), "PH", "Philippines" },
                    { new Guid("a715c8d2-2fd9-40ca-adb9-78d673f2e293"), "BR", "Brazil" },
                    { new Guid("a7bc64ca-c854-4d43-8971-6db8687239c9"), "IE", "Ireland" },
                    { new Guid("a988271f-7a16-48c4-bcd6-8685293a8db5"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("aab4bcf8-bf23-4a3b-907d-db3658a156d5"), "PG", "Papua New Guinea" },
                    { new Guid("aadb1cdc-f480-423d-8464-657bedee522e"), "IQ", "Iraq" },
                    { new Guid("ab680278-6f68-4762-a53f-8a83877203a8"), "GT", "Guatemala" },
                    { new Guid("ae3dd2c8-4404-458d-b6cd-936a1bb0f9fb"), "CR", "Costa Rica" },
                    { new Guid("ae8ef4bd-a87c-46b8-b89b-e1c665dd2a20"), "PK", "Pakistan" },
                    { new Guid("b02e4eb2-0012-43d1-b4d9-0f00504989b1"), "MD", "Moldova" },
                    { new Guid("b2932abd-d33e-44ee-b07d-3cdaa1937e61"), "BJ", "Benin" },
                    { new Guid("b2f9bd20-40d9-4852-8059-a4193786f528"), "YE", "Yemen" },
                    { new Guid("b3079652-4d35-480d-be5d-31d13aead86f"), "EC", "Ecuador" },
                    { new Guid("b5234ce8-b365-4ffd-b25e-0a8ddb6a58b8"), "KP", "North Korea" },
                    { new Guid("b5be7df9-09e2-4163-869b-b26be667f351"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("b6182f8f-28a8-417e-9462-918d655a7bf8"), "NP", "Nepal" },
                    { new Guid("b800f10d-ead7-4b03-99ab-e7a059e05b73"), "UZ", "Uzbekistan" },
                    { new Guid("b8c372c5-6f1d-4994-a5ca-2621dffdaec1"), "PY", "Paraguay" },
                    { new Guid("b9b1f61a-4051-4c93-9ce3-1e6c92c28473"), "UA", "Ukraine" },
                    { new Guid("bb3cdf9b-dada-4f23-8155-44d1e4f7445f"), "TJ", "Tajikistan" },
                    { new Guid("bb811cd4-445c-42b7-ba30-0d5278f195b0"), "EE", "Estonia" },
                    { new Guid("bbdcf38b-2576-41ce-be3e-606accb8b0c7"), "NZ", "New Zealand" },
                    { new Guid("bbe899e1-fb47-45ab-81de-4bcdc9263462"), "RW", "Rwanda" },
                    { new Guid("c02e544a-635d-4cac-bf2f-cb578b32550b"), "LA", "Laos" },
                    { new Guid("c18c79ce-f6d1-4807-83bd-403bdfb9c64f"), "BN", "Brunei" },
                    { new Guid("c1c09ec6-9736-4680-b941-349549e3673c"), "LV", "Latvia" },
                    { new Guid("c21a7d5b-20c9-404c-89d3-9ad250f546e9"), "DK", "Denmark" },
                    { new Guid("c2a286ca-c9a7-4fd3-85a3-3a3ddfe45fd1"), "SN", "Senegal" },
                    { new Guid("c53bcc35-f63d-45d0-a177-dc7fe48df287"), "TV", "Tuvalu" },
                    { new Guid("c680eb8e-7602-430d-8e3b-b18ea8cd4e91"), "GR", "Greece" },
                    { new Guid("c7d81819-184b-4f32-bd99-fc4b36ac9ded"), "TH", "Thailand" },
                    { new Guid("cc8d2aed-4ba9-4c72-8096-324483ec814f"), "AT", "Austria" },
                    { new Guid("cdcfe171-99be-43f2-a762-70fed8bc8f79"), "LU", "Luxembourg" },
                    { new Guid("cf83e67b-1fd1-47f8-b6cf-c60268157f45"), "WS", "Samoa" },
                    { new Guid("d06a62a1-b676-4ddb-8d18-169afd5689d1"), "FM", "Micronesia" },
                    { new Guid("d079ea86-256a-420c-80bb-28068bbffcbc"), "MY", "Malaysia" },
                    { new Guid("d1195217-bc6d-4fe8-857a-c02923602d70"), "KG", "Kyrgyzstan" },
                    { new Guid("d1205993-a503-4f5f-8e09-02b1ddccc6df"), "AO", "Angola" },
                    { new Guid("d1dd4284-ede5-4c71-afc3-d1e995ee9c54"), "EG", "Egypt" },
                    { new Guid("d2b52dee-96f0-4575-ac43-df1fdc06d8b6"), "GE", "Georgia" },
                    { new Guid("d30c6ef5-0141-431b-9c02-c9884795978c"), "CM", "Cameroon" },
                    { new Guid("d3af39bc-b1b4-4776-b098-05ccaed0e390"), "BE", "Belgium" },
                    { new Guid("d4fd57eb-84ce-43ae-b238-73aeab41ceb7"), "HR", "Croatia" },
                    { new Guid("d5337a2f-863a-4755-bc97-5d3ac4bc78ad"), "LR", "Liberia" },
                    { new Guid("d62f2f7b-74c8-46a6-bb46-c1c92f569ce5"), "QA", "Qatar" },
                    { new Guid("d83ba768-d05e-4e16-974e-1cfecf9e892d"), "HN", "Honduras" },
                    { new Guid("e279b4ea-2489-49f4-a74a-9a0afe999047"), "DO", "Dominican Republic" },
                    { new Guid("e471d9e3-39f7-4237-a378-da82a5da3a3a"), "MZ", "Mozambique" },
                    { new Guid("e592ac95-8f28-4503-8d7c-c7c2983f5e0f"), "MM", "Myanmar" },
                    { new Guid("e639deb2-d027-46fb-a2ec-5a72f25abb10"), "DZ", "Algeria" },
                    { new Guid("e65083d5-7002-44f9-821f-c803403fcd55"), "BH", "Bahrain" },
                    { new Guid("ea2016fa-cb2b-4d09-95c9-42d415b448f5"), "SK", "Slovakia" },
                    { new Guid("eada5588-f183-4864-9894-8c8a6ea1aa96"), "SV", "El Salvador" },
                    { new Guid("eb5a525a-c715-402e-8c84-45a3c3b6a4da"), "MG", "Madagascar" },
                    { new Guid("f22483e3-cba4-4a05-b6dc-153e54f3d8b2"), "LT", "Lithuania" },
                    { new Guid("f3a085cf-2b32-4e32-b5f4-01a2fd511775"), "MV", "Maldives" },
                    { new Guid("f5a3f473-aeae-4f08-a335-1e2a43ac0430"), "SG", "Singapore" },
                    { new Guid("f87798f6-8d85-479a-abaa-90b9152641f8"), "MU", "Mauritius" },
                    { new Guid("f8d98730-5994-4a94-893e-62c32ce562d2"), "GB", "United Kingdom" },
                    { new Guid("f9ed78fa-2e43-4f38-ad6c-5bd76fd65526"), "FJ", "Fiji" },
                    { new Guid("fa21eee7-fa29-487c-a1fe-2790e4d9cac3"), "AL", "Albania" },
                    { new Guid("fd088244-842d-4025-9fa2-cac1749a1cb9"), "GA", "Gabon" },
                    { new Guid("ff5fd300-307b-477c-8245-19439e66a4d6"), "ST", "Sao Tome and Principe" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1f06b94b-c302-4292-9098-985d2a235b4c"), "Male" },
                    { new Guid("786dfdf3-48b8-4cf0-a03a-4f4610630284"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3212c2de-662a-4e18-9d8c-686c302326c4"), "Obstetric and Reproductive Interventions" },
                    { new Guid("342ac934-1bdf-4bce-ac63-fec37d9b3680"), "Exotic and Specialized Interventions" },
                    { new Guid("35ea9a1c-0c9f-49bc-92d7-088e16e2fd63"), "Therapeutic Interventions" },
                    { new Guid("6c297af6-697f-4ee9-8cee-e1173981f178"), "Postoperative Care" },
                    { new Guid("77ea5f35-2a83-4b6c-ab6b-f077e901606a"), "Diagnostic Interventions" },
                    { new Guid("7cc9f20f-4034-4652-8e78-ea30145f8111"), "Oncological Interventions" },
                    { new Guid("8445b449-6472-4266-93da-88d543b9e827"), "Dental Interventions" },
                    { new Guid("8b7b9792-bdc1-4562-9980-f7720f34e32f"), "Surgical Interventions" },
                    { new Guid("da4a7321-1bdb-4ca8-b42f-935776edbf94"), "Preventive Interventions" },
                    { new Guid("fbaa1013-5491-4240-93f8-26ea5c2f6d34"), "Emergency" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00565012-9279-4581-863d-49c17d359ee9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("019343f5-09c0-47a6-84e7-dc47e95fdf76"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("023ab01f-b46c-4f7d-a59c-355c21921173"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03257e5f-3ad2-4624-aadc-50f93a0cb25f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("043e8893-7500-45e5-9339-f40e818699af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04edb84f-af72-4027-83d2-80b1964b17a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("056d5604-c540-43fe-9650-18e8566fcc1b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("05a535fd-65f9-4e34-b4d5-f82ac2ec573e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a3313ac-9322-45fa-b1da-74caed77d40b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0ad6c563-3af2-4a48-9511-fdbb475ba58f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b2a4cbc-3c1c-4b12-8dbd-246f00790473"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b7fdc34-55ac-46c7-b789-c9efafe5b6f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0dc373b2-39c5-4d9e-b6c3-55e3aaebc3f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f70da9d-85e3-41ca-986a-72a524ae1035"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("10549df4-68ab-4170-8bec-b6e0a4b9b1d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("10f8fe69-c587-4b40-8701-228578534a2a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11f49162-9efd-4169-8d20-0f9e115aca3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1290e1ac-77de-4b27-b878-ac94d0f2182f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("133c0aa3-9148-4791-a69f-2a0afa775cac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("14a346a1-2688-43da-a7dc-023b4182087a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("165f742c-ee32-4233-9568-1b204229e532"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17dd7423-cd0c-4662-a4fb-46ccce05fc7c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18760771-6311-41a9-895b-115db14fc2ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18f9e126-d765-44ae-bb2e-5c6554d44dc9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1bdf62f3-aaae-4f6a-99fd-89a8c3430850"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ff582f2-4380-4ae7-853f-def75e28697a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21a3b4c6-6608-4148-b35e-a0d5c987794d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23defec6-1de4-45a6-a7d3-f564460b2e53"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24b1bbd7-2163-441c-a15d-f61c0e9052d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24f392f3-387e-49a1-80ff-39765c7ad009"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25f0907c-396a-431d-8916-ec82c63f3ec9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2886fcb5-df01-47f9-bee6-18094444b191"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2900d4ec-75af-43e3-b65b-7c9df2abe48a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29d29e8f-6676-4b15-bbea-592e314ac8ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c1e2d71-c167-43ae-b640-399a8b6ac229"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2cb88465-05b6-445a-8e0b-61fa03174102"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e0485c2-4778-4920-a24a-a10fd7fe87a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2eb1a3ea-716e-425b-9ce0-2adc2ee6c82c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f21dcac-1b05-4118-9367-1604e07a0df4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fbd0269-3064-447f-a626-318182c7bdb3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fe7e5da-5276-466a-b013-b9f08514ba93"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30188779-2b42-47e5-978a-a91d71bf33da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("311dab1c-cf3f-47ba-a6f9-cd21f9b99f9d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("334a5f12-4bae-4639-9b65-29b8b572b749"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("337d5f83-8695-4740-b25c-2879139a556b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33e94504-62c4-45f1-9846-f33f91affb68"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34480e1a-13d2-4ce0-88b0-dc4abe03f4fe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35cfae65-e54a-4aef-8f98-a11226da4066"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("36fbaf20-b271-4847-9489-58a2b9644dc5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("371f83ba-f969-4845-acac-7701bed6aa5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37e80bf6-db7c-4c4b-bd2b-d1bd6d481edf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39b664da-362f-40b3-96f0-e65ff6543ab4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b41f02a-6eed-4bfa-991a-dbe9b9bd8385"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ce692d7-1365-424f-b0a6-575022c02e26"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4312bd41-2f93-4603-a0b4-244625175bec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("431431be-b518-4c05-a129-a6d3db7fac4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4596f554-dbb8-474e-b5e6-571f3b7cdeaa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("488d6594-e1e6-4b58-b19c-295cce89f5f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4892f47d-312b-408d-a344-7e4ae0b3cf64"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b0cca85-dc14-4305-bafa-a9b024c99671"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c02f251-851e-4801-95f5-5006c3c18136"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4dc5e40a-73e6-4127-95aa-0a1c012c80e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4e313f02-7d96-4da2-a0fb-e521463fb7c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4e5f4ca7-4797-4c0e-87d6-7f345602326c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ff5c3c8-d1e1-44fc-af0f-273b07e0cfbb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5112db01-3f75-4c9a-9984-2f3065761f94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("526e94c1-358b-4789-ae00-7eaf67853ebd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5291e61a-aba1-4d91-9047-1a9b2ca9772b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53279f12-c1a7-482b-9b9a-3aa3a4e61db2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("552a901b-ec57-4789-b9da-9a0fc3e82400"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55eaade4-efe7-44b8-989f-7f55974a1dcb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("566dabe5-44c1-4e01-af1d-56cdeb39d6c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56b873d7-e523-4638-a363-77a51b570231"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56c9c948-8d3b-4bd6-9c81-df8a818aa25d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58010e2e-aeba-431f-96cf-f4eb1aa571c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59508a82-3baa-4b4d-b4b5-b9fbf739ed9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59c7830a-aef2-4ffd-b3fc-a3c628573a96"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59f57fe6-0b2b-4916-838b-16af3d779e32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a8f12c3-723d-4f18-bdca-ab546ba2cbe9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d76886e-bf6f-4b73-a6d1-888c0431afd3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5deb4488-8c67-4f7d-aa01-10d1b1536ff4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e00d3af-7c18-412d-825f-51580e86385d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ed872ad-0ce3-4f31-aabd-a8092ac2bcf4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ff41b1f-5db1-422f-bdf1-c7258f05b419"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6058418b-7ab4-4b97-b380-0306bf9a01ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6249734e-5b5f-4594-963d-8103bb78e054"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63151f7a-8dba-4424-be59-c094119724c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63f11491-c02d-43a5-b29e-72df868239fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64501b12-3f3f-4da1-980c-d4f202261e20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6544bc7a-31b5-4b9a-bd08-6f29de329fb4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("666c3e2e-2033-44d2-a495-f304d1daa2f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66cc5c69-77b8-436b-8c99-4a3ef8be2ab6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a0eab01-6f5a-45ec-b6d1-cf8852bd592e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a2aa3ed-f3bc-4d08-88aa-586d19ba5da9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ce0bfaf-7b3c-418c-8933-dd33d93ca1f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70e6a498-3b4b-4a5c-8a6f-4902c0854d95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76d90a07-6a36-4726-810d-0b36b0a69cdf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76f14832-6af2-41c0-b29d-5d2f4d107081"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77564f58-da4b-4687-9821-7be9e7981caa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78a08f2f-fcac-4976-bea1-de03808f7bd1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78c2d0cd-f0fa-40b6-9d49-aad1af36bc0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ae46693-7986-483e-aa1f-4b3d065d3181"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b47b53c-7058-4631-a89b-d2af78ecb67e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d2f3892-6faf-4d63-823e-c425e9c56c57"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e63ac00-b9cb-403d-8b3e-cb5a934391ee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80a16eef-8105-4071-9b60-f88e023f063a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("826303a6-bef6-45bd-b0d5-9e268d6ae217"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82de8d18-dadd-49a6-9010-fe9c3af3f71c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83cc4b34-dea3-43c7-a493-16eec87d2e45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8438752c-f9ae-40a6-ae05-3c481b0956e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84595b3e-efb4-40f1-833f-fac549261e35"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8560ea64-5be1-4830-bbbe-e68ab5d9928c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8977b647-d27a-46e5-b517-9b39fddeb796"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89f2fa28-f2de-4008-a3ec-98dd2ac105c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a1a8e2e-4957-413a-8d1a-e6972b77e25f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d07a9a8-4835-4359-a406-111bceea05c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8eaf9394-a5d0-4c93-a12b-1b92af20ff12"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f41a54c-d9e5-4613-81f0-d9911899be90"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91b319d4-aaf0-4be7-9ed5-f1d587bff495"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95016b60-584e-46c6-8b84-48ae94f47056"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("973b30d0-60e1-46b6-89fb-c38619f02579"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97ceaac0-4486-4ebf-a9f1-2c5b71806253"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98c49387-14ce-4aef-be6c-3c79ab6af7b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99a1fc7d-7544-4c72-b67a-475f0b2d72a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9bb7a9d7-9610-45c1-bbda-4c6536ca0490"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c69b492-e9b8-476c-826b-f3cfb6987928"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ca370a5-e98e-4e42-a90a-3ea44cfda183"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f9ae508-faa4-49c7-9206-a80949c3acd4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9fbd6bbf-b2af-46c1-a222-ecad83716104"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0383304-2b73-4a97-b48c-aa65a7519029"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4c7d2e2-15ca-4041-ac43-12c10b8e7a99"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a632589c-7b0b-4ac2-af15-5cff971331bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a715c8d2-2fd9-40ca-adb9-78d673f2e293"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a7bc64ca-c854-4d43-8971-6db8687239c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a988271f-7a16-48c4-bcd6-8685293a8db5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aab4bcf8-bf23-4a3b-907d-db3658a156d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aadb1cdc-f480-423d-8464-657bedee522e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ab680278-6f68-4762-a53f-8a83877203a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae3dd2c8-4404-458d-b6cd-936a1bb0f9fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae8ef4bd-a87c-46b8-b89b-e1c665dd2a20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b02e4eb2-0012-43d1-b4d9-0f00504989b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2932abd-d33e-44ee-b07d-3cdaa1937e61"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2f9bd20-40d9-4852-8059-a4193786f528"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3079652-4d35-480d-be5d-31d13aead86f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5234ce8-b365-4ffd-b25e-0a8ddb6a58b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5be7df9-09e2-4163-869b-b26be667f351"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6182f8f-28a8-417e-9462-918d655a7bf8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b800f10d-ead7-4b03-99ab-e7a059e05b73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8c372c5-6f1d-4994-a5ca-2621dffdaec1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b9b1f61a-4051-4c93-9ce3-1e6c92c28473"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb3cdf9b-dada-4f23-8155-44d1e4f7445f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb811cd4-445c-42b7-ba30-0d5278f195b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bbdcf38b-2576-41ce-be3e-606accb8b0c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bbe899e1-fb47-45ab-81de-4bcdc9263462"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c02e544a-635d-4cac-bf2f-cb578b32550b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c18c79ce-f6d1-4807-83bd-403bdfb9c64f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c1c09ec6-9736-4680-b941-349549e3673c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c21a7d5b-20c9-404c-89d3-9ad250f546e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2a286ca-c9a7-4fd3-85a3-3a3ddfe45fd1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c53bcc35-f63d-45d0-a177-dc7fe48df287"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c680eb8e-7602-430d-8e3b-b18ea8cd4e91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7d81819-184b-4f32-bd99-fc4b36ac9ded"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc8d2aed-4ba9-4c72-8096-324483ec814f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdcfe171-99be-43f2-a762-70fed8bc8f79"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf83e67b-1fd1-47f8-b6cf-c60268157f45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d06a62a1-b676-4ddb-8d18-169afd5689d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d079ea86-256a-420c-80bb-28068bbffcbc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1195217-bc6d-4fe8-857a-c02923602d70"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1205993-a503-4f5f-8e09-02b1ddccc6df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1dd4284-ede5-4c71-afc3-d1e995ee9c54"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d2b52dee-96f0-4575-ac43-df1fdc06d8b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d30c6ef5-0141-431b-9c02-c9884795978c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3af39bc-b1b4-4776-b098-05ccaed0e390"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d4fd57eb-84ce-43ae-b238-73aeab41ceb7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d5337a2f-863a-4755-bc97-5d3ac4bc78ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d62f2f7b-74c8-46a6-bb46-c1c92f569ce5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d83ba768-d05e-4e16-974e-1cfecf9e892d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e279b4ea-2489-49f4-a74a-9a0afe999047"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e471d9e3-39f7-4237-a378-da82a5da3a3a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e592ac95-8f28-4503-8d7c-c7c2983f5e0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e639deb2-d027-46fb-a2ec-5a72f25abb10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e65083d5-7002-44f9-821f-c803403fcd55"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea2016fa-cb2b-4d09-95c9-42d415b448f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eada5588-f183-4864-9894-8c8a6ea1aa96"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb5a525a-c715-402e-8c84-45a3c3b6a4da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f22483e3-cba4-4a05-b6dc-153e54f3d8b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3a085cf-2b32-4e32-b5f4-01a2fd511775"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5a3f473-aeae-4f08-a335-1e2a43ac0430"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f87798f6-8d85-479a-abaa-90b9152641f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f8d98730-5994-4a94-893e-62c32ce562d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9ed78fa-2e43-4f38-ad6c-5bd76fd65526"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa21eee7-fa29-487c-a1fe-2790e4d9cac3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd088244-842d-4025-9fa2-cac1749a1cb9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff5fd300-307b-477c-8245-19439e66a4d6"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("1f06b94b-c302-4292-9098-985d2a235b4c"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("786dfdf3-48b8-4cf0-a03a-4f4610630284"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("3212c2de-662a-4e18-9d8c-686c302326c4"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("342ac934-1bdf-4bce-ac63-fec37d9b3680"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("35ea9a1c-0c9f-49bc-92d7-088e16e2fd63"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("6c297af6-697f-4ee9-8cee-e1173981f178"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("77ea5f35-2a83-4b6c-ab6b-f077e901606a"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("7cc9f20f-4034-4652-8e78-ea30145f8111"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("8445b449-6472-4266-93da-88d543b9e827"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("8b7b9792-bdc1-4562-9980-f7720f34e32f"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("da4a7321-1bdb-4ca8-b42f-935776edbf94"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("fbaa1013-5491-4240-93f8-26ea5c2f6d34"));

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
    }
}
