using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixAddressNoNULL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("00a724c3-ee5d-4e9a-864b-834232a73fa3"), "ZM", "Zambia" },
                    { new Guid("07128ea6-c05f-4628-aee4-f910e9e0c86f"), "JM", "Jamaica" },
                    { new Guid("08ec131f-f3a5-41f1-b835-caefcbbe085a"), "MT", "Malta" },
                    { new Guid("0a3f3fd2-a716-4354-b575-9f69caff1143"), "FM", "Micronesia" },
                    { new Guid("0abbe512-f24d-4401-b6cc-77ca54049fff"), "MR", "Mauritania" },
                    { new Guid("0d1f57c9-b5c4-4db1-b10a-24236e34effd"), "PS", "Palestine" },
                    { new Guid("0d425327-70ae-4bbd-ad01-a3ff626ec537"), "GY", "Guyana" },
                    { new Guid("0dc0b46d-58f4-4024-857b-f1ca1b84f2f3"), "HU", "Hungary" },
                    { new Guid("0e6efa14-0c29-4b0d-b55c-88db30b70be5"), "IR", "Iran" },
                    { new Guid("0e97846c-780c-4a40-b5ef-d24303fe4b38"), "MX", "Mexico" },
                    { new Guid("101f32ba-35c4-444e-8fed-1cad758bc32e"), "LT", "Lithuania" },
                    { new Guid("103f8f75-cb0d-49c1-83e9-ec71c08eeb8e"), "DZ", "Algeria" },
                    { new Guid("1088a7bb-1bd1-4cd2-ad2b-e38f503c8bdc"), "CV", "Cabo Verde" },
                    { new Guid("111c7eb1-fb6c-459f-82b8-e7498c3b53c8"), "MA", "Morocco" },
                    { new Guid("1169b116-986b-412c-aa50-c75b93931b84"), "BR", "Brazil" },
                    { new Guid("11916f9c-4007-430d-bb4a-1e462ac706c1"), "AT", "Austria" },
                    { new Guid("11e6a175-533a-40f3-9aec-748a4ea2c3dd"), "UZ", "Uzbekistan" },
                    { new Guid("13d143f1-2368-4142-8b0b-576bbfea64f4"), "GB", "United Kingdom" },
                    { new Guid("14bb0c30-4749-48c8-af98-9dbbd4118097"), "SO", "Somalia" },
                    { new Guid("15533ff2-0325-4b3c-9a6a-2c6ae97df8d9"), "MG", "Madagascar" },
                    { new Guid("15736751-2fd6-4498-a1f5-f2e78281820b"), "PH", "Philippines" },
                    { new Guid("166a2c86-91a5-46ea-a7cc-4214f6554f53"), "AR", "Argentina" },
                    { new Guid("173920fb-edda-4bba-99fa-e950f32f5efa"), "UA", "Ukraine" },
                    { new Guid("1cbc71ec-724b-40ac-b7fd-8465cddd2ed4"), "FI", "Finland" },
                    { new Guid("1e3530c7-8420-4ed9-997d-e70e1854c3a6"), "FR", "France" },
                    { new Guid("1f8976c3-0d19-40a9-99d1-cdf2c837794d"), "KI", "Kiribati" },
                    { new Guid("20437f78-3aa2-438f-9816-567bc67b73e0"), "CO", "Colombia" },
                    { new Guid("20f3e82f-445d-40ef-a761-d8a88ff88b0f"), "ML", "Mali" },
                    { new Guid("210dfc7f-89f5-4532-9b9a-8229e98d63b0"), "GH", "Ghana" },
                    { new Guid("22201249-07f5-48c7-8fdc-7b976cfd9f24"), "FJ", "Fiji" },
                    { new Guid("228b4b89-0419-41c0-978f-298b5c9f8024"), "ER", "Eritrea" },
                    { new Guid("24160181-8013-4647-92a3-11d8d537fadc"), "SV", "El Salvador" },
                    { new Guid("2669c5f1-1364-46b9-9715-0b087848ee55"), "BI", "Burundi" },
                    { new Guid("2bf79fa7-95f5-482d-bd85-4ab8a9c7d9fe"), "IQ", "Iraq" },
                    { new Guid("2ceca91f-f3ae-43a8-b415-e68928cba814"), "TD", "Chad" },
                    { new Guid("2f22ac0e-14e2-4691-85c1-764a38922ac9"), "DM", "Dominica" },
                    { new Guid("2ff0d344-b17a-4c18-b5fc-521578b95d11"), "NG", "Nigeria" },
                    { new Guid("30a25982-85de-43b0-8d63-d957b9cba0ac"), "MM", "Myanmar" },
                    { new Guid("314ae6a3-8d5a-4399-be09-f994e29c49be"), "US", "United States of America" },
                    { new Guid("3294ec41-e11f-4e28-acce-ad0e82aa102e"), "LC", "Saint Lucia" },
                    { new Guid("3382d075-c5e0-4648-9c2b-1467ca5246db"), "SS", "South Sudan" },
                    { new Guid("33ee1740-26fb-460d-9fde-a99fee2d9d05"), "LS", "Lesotho" },
                    { new Guid("3743b358-9412-4602-a324-7156967ad326"), "GQ", "Equatorial Guinea" },
                    { new Guid("37de60eb-a721-4cf0-a20c-7119f8886424"), "VA", "Holy See" },
                    { new Guid("38eecb03-28af-4e0d-85c0-ab969910ee98"), "HT", "Haiti" },
                    { new Guid("3c560a89-4272-4a6b-931a-ebf0b52e0a3e"), "AM", "Armenia" },
                    { new Guid("3d037ef0-ca3e-414b-b0a7-3b57ea4d71ea"), "IE", "Ireland" },
                    { new Guid("3d8c9a2b-e323-4b04-8e63-a45d25defd5f"), "DK", "Denmark" },
                    { new Guid("3f5f560e-fc31-4814-9817-42b5ebb86e3d"), "TL", "Timor-Leste" },
                    { new Guid("3f6e69fb-ec2f-4848-a987-54f3e8e5fe23"), "MW", "Malawi" },
                    { new Guid("3f97054f-5e62-4b1a-b72c-f3a968278a7d"), "GW", "Guinea-Bissau" },
                    { new Guid("41dcf1ed-8d52-4a32-b90c-59a92c0cb5bc"), "JP", "Japan" },
                    { new Guid("422d8641-e8b3-4814-aac0-35dc4130415b"), "HR", "Croatia" },
                    { new Guid("4256419c-3e7f-401b-b289-74fa3444b8a1"), "GT", "Guatemala" },
                    { new Guid("4782c653-953c-4b5a-adde-c69a93abdff3"), "CA", "Canada" },
                    { new Guid("4b8f74dd-c0bf-45a4-98b8-b2debb019330"), "KH", "Cambodia" },
                    { new Guid("4de415e1-cc12-437e-ac30-454652cb7503"), "BG", "Bulgaria" },
                    { new Guid("4df0c423-ad98-472f-9999-b0f7dc2e8493"), "BZ", "Belize" },
                    { new Guid("4df92187-2fd4-4905-8537-33e192105160"), "RO", "Romania" },
                    { new Guid("50614979-155a-4f1e-8282-9a13ab6e8d76"), "VA", "Vatican City" },
                    { new Guid("5347f77a-58c1-4ee7-b3a7-a2dcc8f681a7"), "SE", "Sweden" },
                    { new Guid("561514d0-d7b3-4ef0-a836-2a808a321a2d"), "IL", "Israel" },
                    { new Guid("569c2261-9d73-4212-9f50-9fb50d5f8e22"), "TT", "Trinidad and Tobago" },
                    { new Guid("5839be66-0e7d-45f3-9fa0-efef4d6acac8"), "PA", "Panama" },
                    { new Guid("5859be97-0675-4ac1-b114-9122a18e02b5"), "TM", "Turkmenistan" },
                    { new Guid("58d553bd-12e5-44fe-a00c-cf9268c83a16"), "KZ", "Kazakhstan" },
                    { new Guid("59135fec-40fe-4bde-b6ba-c3eb22100737"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("595e26a5-8ba3-4374-b0dd-6d471b24fffd"), "GM", "Gambia" },
                    { new Guid("59a1b546-01f9-4445-9e98-989d29072341"), "YE", "Yemen" },
                    { new Guid("59f31fef-2fa0-46ed-8ef8-04e62e17f012"), "NZ", "New Zealand" },
                    { new Guid("5b7b385f-6d03-4b0c-8887-b9030d0deae2"), "JO", "Jordan" },
                    { new Guid("5b888492-f56c-41c1-84f3-a1089f90fd17"), "SB", "Solomon Islands" },
                    { new Guid("5c2fb8f8-a193-474c-96d9-4b062f2bf189"), "CH", "Switzerland" },
                    { new Guid("5d185253-85d4-4943-bca9-95c8f8214cb3"), "LA", "Laos" },
                    { new Guid("5d82f613-40f4-4b92-bae1-9de876ebafd4"), "MY", "Malaysia" },
                    { new Guid("5e1d0750-3ba1-44e0-b995-43ab1c2a9dcb"), "AO", "Angola" },
                    { new Guid("5f0b6b53-e616-48c5-9b67-5915a4513fff"), "GN", "Guinea" },
                    { new Guid("61cb0042-44ae-45c1-ac9c-f353e6f05e98"), "DO", "Dominican Republic" },
                    { new Guid("61e30e85-140a-4750-bf5a-05e76dd99230"), "CF", "Central African Republic" },
                    { new Guid("625e7cd0-84ba-43b5-84da-f0d77ae0e1c3"), "TN", "Tunisia" },
                    { new Guid("63abfb21-ab8a-4017-90cf-46eed3420cb8"), "LB", "Lebanon" },
                    { new Guid("63d1dda1-8242-468c-b13f-e06f9d8097e0"), "TG", "Togo" },
                    { new Guid("6683e2e8-c8f7-4232-b091-01e4c8f5df2d"), "ES", "Spain" },
                    { new Guid("668c8e33-b189-41cb-b254-362e2905bb52"), "ID", "Indonesia" },
                    { new Guid("66df5fc5-f5bf-4f8f-9658-a4ffcc6fd0c4"), "KG", "Kyrgyzstan" },
                    { new Guid("67aa2bc6-e727-460a-89ca-1fcaca08ce33"), "VE", "Venezuela" },
                    { new Guid("695d212f-6fb3-4638-a705-d507724fed4d"), "MH", "Marshall Islands" },
                    { new Guid("6986c2b7-3c18-42c4-8844-6e72f3c0dccb"), "ET", "Ethiopia" },
                    { new Guid("6a61ce71-3a6b-4200-a092-7bc249e3220b"), "SA", "Saudi Arabia" },
                    { new Guid("6a93b60d-cd08-4e45-81d7-624549a8ad39"), "AU", "Australia" },
                    { new Guid("6bfea72f-01c8-4d5b-85be-dbd9ebc0384f"), "LR", "Liberia" },
                    { new Guid("6ca4d7bb-2097-4b95-a21d-838093f85a85"), "SZ", "Eswatini" },
                    { new Guid("6dabd1fe-2c39-42b5-8cd5-c26954d2bf8c"), "GR", "Greece" },
                    { new Guid("6ec79805-48d6-42da-a0ef-0408c19f0cf4"), "QA", "Qatar" },
                    { new Guid("70486789-5e82-4cac-9bbf-0937f1088bea"), "BO", "Bolivia" },
                    { new Guid("710f37c3-ae16-4c8d-b1da-ffae10771f52"), "TJ", "Tajikistan" },
                    { new Guid("712a3e77-ee77-4cb7-92fa-98f6e88dce38"), "TH", "Thailand" },
                    { new Guid("73c0fd8b-ef2d-4f05-88bf-a9130b3e5907"), "WS", "Samoa" },
                    { new Guid("74861ed0-ec02-4234-b13a-6c63af3faf36"), "MU", "Mauritius" },
                    { new Guid("7536b00b-6213-4a41-b866-be1dda553d58"), "BT", "Bhutan" },
                    { new Guid("77e5331c-75cc-4e00-8d6c-1cbe8f236909"), "LV", "Latvia" },
                    { new Guid("78c6c28f-d8be-4dfa-a4fb-bce77d125ba7"), "UG", "Uganda" },
                    { new Guid("7a50f61c-b08e-41e4-bb10-608a5aefa6db"), "ZW", "Zimbabwe" },
                    { new Guid("7abc3886-25bd-4b1b-9577-6169106319d1"), "LK", "Sri Lanka" },
                    { new Guid("7ccd934d-4aef-49bb-91e3-ef0d223c07b4"), "CM", "Cameroon" },
                    { new Guid("7dcf465f-6382-4b4a-80a4-c74cab619b9f"), "MD", "Moldova" },
                    { new Guid("7fd792a6-4577-468b-8f1d-25b9c5eca761"), "CN", "China" },
                    { new Guid("8181c4f3-0a46-4349-a9cd-4132f9c93e7b"), "RS", "Serbia" },
                    { new Guid("81f49038-47bc-42be-a843-5993c7352fab"), "MZ", "Mozambique" },
                    { new Guid("825cc757-dc13-4ae7-9319-d5553d732327"), "TR", "Turkey" },
                    { new Guid("855f0c10-bfb2-4d6c-922b-f25ffae5c3c6"), "SM", "San Marino" },
                    { new Guid("8570c432-a6e4-4690-829e-e6b8fef892aa"), "MK", "North Macedonia" },
                    { new Guid("86a7b2b5-c28a-482e-ac17-0b3aa313b477"), "ZA", "South Africa" },
                    { new Guid("86c21d74-7b35-46d0-a6e4-7ed3819bbfb7"), "SN", "Senegal" },
                    { new Guid("891bcfc7-b7aa-4797-a983-8df9a1cd4820"), "KR", "South Korea" },
                    { new Guid("8937934c-7c46-452d-ba6b-b696e86744b0"), "CY", "Cyprus" },
                    { new Guid("89f5b6b1-e627-404f-ae5b-bd57301f028c"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("8ca4722a-8d28-4203-8882-17623dce13ca"), "HN", "Honduras" },
                    { new Guid("8fc1b0ab-75ab-4603-a81f-12438efd1de4"), "BW", "Botswana" },
                    { new Guid("90181cad-c221-486f-9225-c690259f1357"), "PT", "Portugal" },
                    { new Guid("92923542-1c4d-424b-84e6-23c77f0081bc"), "SC", "Seychelles" },
                    { new Guid("96e7dc42-30e4-4231-934a-60d0fb675f15"), "PY", "Paraguay" },
                    { new Guid("96f11074-14d4-4272-8cc6-681a49be0d28"), "KE", "Kenya" },
                    { new Guid("98123ae1-c996-4780-bf36-6374ed95223d"), "TZ", "Tanzania" },
                    { new Guid("9a5b7964-2848-4630-b379-83f862acb968"), "NE", "Niger" },
                    { new Guid("9bc1440e-b232-487c-988d-7df872bd6616"), "AD", "Andorra" },
                    { new Guid("9fa74f8c-aa90-48af-9fe0-f2392c2ca8e8"), "AL", "Albania" },
                    { new Guid("a011f1a3-9dfe-438a-babe-02ce3fffb791"), "ME", "Montenegro" },
                    { new Guid("a0b59853-9b51-4098-8bde-b634d2e30689"), "MN", "Mongolia" },
                    { new Guid("a47be348-7467-4ecd-9d91-118917790113"), "BB", "Barbados" },
                    { new Guid("a4f0086f-77b5-49a2-83cc-f94b55fb5be2"), "UY", "Uruguay" },
                    { new Guid("a5b1b94d-0545-4af3-b251-1dd3154fff8a"), "MV", "Maldives" },
                    { new Guid("a60969e1-a202-45fa-93f7-9dc0fa081f8c"), "CU", "Cuba" },
                    { new Guid("a885f8e8-3dce-4cd4-9841-203be9f6e755"), "BJ", "Benin" },
                    { new Guid("ab51b07d-75b3-4c8a-9431-b50af920fd64"), "NO", "Norway" },
                    { new Guid("abf9e9ac-8616-43b8-b718-57d3e57ec8fb"), "SG", "Singapore" },
                    { new Guid("ae7d687a-e4cd-43d9-9bdd-be18da3b83f3"), "RU", "Russia" },
                    { new Guid("b0f9d7ce-7e96-4f81-95f3-d79ef23fd3d6"), "OM", "Oman" },
                    { new Guid("b13f3a1d-9fb5-4a42-b7ed-3556ddc2b12e"), "DE", "Germany" },
                    { new Guid("b2d69c79-889a-4a4e-8ad9-cb6513628f5b"), "PW", "Palau" },
                    { new Guid("b43c448b-cf1e-4d02-844a-7b663b1edc11"), "AG", "Antigua and Barbuda" },
                    { new Guid("b4c16deb-5288-4ed6-b71a-9a59a5ab1896"), "GD", "Grenada" },
                    { new Guid("b77f9948-746e-4008-975d-74f0054abf1f"), "RW", "Rwanda" },
                    { new Guid("ba0d6dcd-1dfe-4c18-b2a4-c881fedcd367"), "EC", "Ecuador" },
                    { new Guid("bae2630b-b3be-474a-9369-73f4977555bf"), "GA", "Gabon" },
                    { new Guid("bbad40f7-2e87-4efb-aab7-ca253243af84"), "BN", "Brunei" },
                    { new Guid("bd1ca4e9-89ed-47a0-9fc9-e2b54f7eef7e"), "SL", "Sierra Leone" },
                    { new Guid("bdd88e2a-1885-4721-a65a-df83d8d90e91"), "VN", "Vietnam" },
                    { new Guid("bf2fb981-7fc0-42d7-97b6-7f878c7c8ed2"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("c500d004-c880-42b1-9b9b-f71761a6682a"), "BF", "Burkina Faso" },
                    { new Guid("c665dfd1-5fc6-4a32-b8cf-f7358a4a900e"), "SR", "Suriname" },
                    { new Guid("c7085048-f105-4faf-947e-b33487d327aa"), "PK", "Pakistan" },
                    { new Guid("c94d56ad-9c3a-4be1-ad49-65cd8d4dd09f"), "BE", "Belgium" },
                    { new Guid("cb9528b6-300a-4e2e-9f8f-dd8fd27f056a"), "CL", "Chile" },
                    { new Guid("cd492994-3ff5-407c-a079-5ab6546872dd"), "EE", "Estonia" },
                    { new Guid("ce9f240d-34e7-4ba9-b7f2-b43116f62bfc"), "PE", "Peru" },
                    { new Guid("cfd04042-5e1a-401e-bfda-8108225745eb"), "NI", "Nicaragua" },
                    { new Guid("d0277780-3115-4277-8d95-0fe15d50649c"), "ST", "Sao Tome and Principe" },
                    { new Guid("d06d0e7c-2d90-4710-987a-825293eac44f"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("d184414a-4879-426d-83be-8f69af46c136"), "AF", "Afghanistan" },
                    { new Guid("d619da5d-5eda-4d6c-9773-259d51c72bd8"), "AE", "United Arab Emirates" },
                    { new Guid("db5e6e61-2d94-484e-9d4c-66f2bfc3b181"), "DJ", "Djibouti" },
                    { new Guid("dd1f0b31-b5d5-4c92-b3d1-c6ee6677703d"), "KW", "Kuwait" },
                    { new Guid("dd60d518-a931-4e6e-acc2-794cbc682cc1"), "NR", "Nauru" },
                    { new Guid("df8afd38-0d9f-4a0c-936b-86107f7c403b"), "SK", "Slovakia" },
                    { new Guid("e02946fe-92bf-4e77-a4ba-8fddae0884a1"), "BD", "Bangladesh" },
                    { new Guid("e24bdfbd-4ad3-45de-9cbf-80ab65d8abe0"), "EG", "Egypt" },
                    { new Guid("e28837b6-8632-4f94-8fa5-834d8cafeafc"), "AZ", "Azerbaijan" },
                    { new Guid("e303e97f-cdef-44ad-8161-04737c6431e6"), "SI", "Slovenia" },
                    { new Guid("e525d315-6964-42f9-9e80-74601c10ee4a"), "SY", "Syria" },
                    { new Guid("e55b8c74-8ee9-4920-b817-2967b2e9c81c"), "TO", "Tonga" },
                    { new Guid("e593209b-55b6-4b68-90d5-8609d36cf1be"), "PG", "Papua New Guinea" },
                    { new Guid("e5a4a078-1ab0-4517-8389-4d8a6cebc24f"), "KM", "Comoros" },
                    { new Guid("e6246f22-e804-48aa-b7bc-a2fe64568aea"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("e62b126b-c399-41f4-94aa-c1479ccbd5fb"), "LU", "Luxembourg" },
                    { new Guid("e686b67d-41bd-4645-895d-445fc0074ab5"), "NP", "Nepal" },
                    { new Guid("e82321df-8ed2-414a-b296-122ef2b52026"), "NL", "Netherlands" },
                    { new Guid("e8311cb1-df8b-42d3-8652-88eca2e6fad8"), "IT", "Italy" },
                    { new Guid("ea86e9ea-5abe-43a3-ae7b-fc5f5604d8a6"), "MC", "Monaco" },
                    { new Guid("eb05b664-2512-40f5-8f2c-034abc837311"), "LI", "Liechtenstein" },
                    { new Guid("ed41c8b0-3dfc-48ac-931c-afca1896880a"), "BH", "Bahrain" },
                    { new Guid("eda3d56e-2657-4d1a-88d5-114986103535"), "TV", "Tuvalu" },
                    { new Guid("eef5d6a6-4ef3-41ec-9856-992f4f415aa1"), "VU", "Vanuatu" },
                    { new Guid("ef79fa3a-34cb-4b63-9a8d-b624b22fd1fa"), "NA", "Namibia" },
                    { new Guid("f02cbb2f-80d3-4916-9064-fc8699b0bef5"), "IS", "Iceland" },
                    { new Guid("f2c03cb2-0d54-4895-a2e2-c55c0a81f728"), "GE", "Georgia" },
                    { new Guid("f48e92c7-c299-4e5d-bde0-02ca3c95cdb4"), "LY", "Libya" },
                    { new Guid("f4f9b46a-9a15-4e44-8bf8-867c6dae5f50"), "KP", "North Korea" },
                    { new Guid("f6432189-1890-42d2-bade-e4bb1a6cad44"), "BS", "Bahamas" },
                    { new Guid("f7d0e572-665d-4968-99db-4a1303eb24d9"), "CR", "Costa Rica" },
                    { new Guid("f809dfbe-dfb9-4f18-80f3-1fca1876e87d"), "IN", "India" },
                    { new Guid("f981cf0c-3777-47c6-9379-64da09a56f8c"), "SD", "Sudan" },
                    { new Guid("fe426673-a346-4616-9a88-67770503d405"), "BY", "Belarus" },
                    { new Guid("fe4aa3a2-f55a-4679-a91e-2f08c252013e"), "PL", "Poland" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7ddcb969-e74e-4ffb-bc7e-696c3d841365"), "Male" },
                    { new Guid("c9483456-1330-40fe-b6ea-e8fe3627043c"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("017a039a-a90f-4d21-9140-548238cd51a5"), "Exotic and Specialized Interventions" },
                    { new Guid("5e3f38c0-b72d-4bb1-8495-5734afa9cb9b"), "Diagnostic Interventions" },
                    { new Guid("6507a196-9d38-43cd-990e-1f47dae61261"), "Preventive Interventions" },
                    { new Guid("8ab27e4c-3fe7-4ec9-85b2-28e35cefd0f5"), "Surgical Interventions" },
                    { new Guid("8bd30d90-d73e-4c7e-a578-d6b12082af1b"), "Dental Interventions" },
                    { new Guid("accc355d-358b-4af2-a32d-4f1bdccb92a6"), "Oncological Interventions" },
                    { new Guid("e2eaed99-2b5d-4123-82c0-6ca8ed79fd81"), "Postoperative Care" },
                    { new Guid("f2de36a8-9401-4b01-b07c-7e96e0af3bd5"), "Obstetric and Reproductive Interventions" },
                    { new Guid("f5fc3eae-25ce-4555-9f7d-599473ec5c61"), "Therapeutic Interventions" },
                    { new Guid("f80f40c9-da18-4a72-b5f1-387ed311859e"), "Emergency" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00a724c3-ee5d-4e9a-864b-834232a73fa3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07128ea6-c05f-4628-aee4-f910e9e0c86f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08ec131f-f3a5-41f1-b835-caefcbbe085a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a3f3fd2-a716-4354-b575-9f69caff1143"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0abbe512-f24d-4401-b6cc-77ca54049fff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d1f57c9-b5c4-4db1-b10a-24236e34effd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d425327-70ae-4bbd-ad01-a3ff626ec537"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0dc0b46d-58f4-4024-857b-f1ca1b84f2f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e6efa14-0c29-4b0d-b55c-88db30b70be5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e97846c-780c-4a40-b5ef-d24303fe4b38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("101f32ba-35c4-444e-8fed-1cad758bc32e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("103f8f75-cb0d-49c1-83e9-ec71c08eeb8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1088a7bb-1bd1-4cd2-ad2b-e38f503c8bdc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("111c7eb1-fb6c-459f-82b8-e7498c3b53c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1169b116-986b-412c-aa50-c75b93931b84"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11916f9c-4007-430d-bb4a-1e462ac706c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11e6a175-533a-40f3-9aec-748a4ea2c3dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13d143f1-2368-4142-8b0b-576bbfea64f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("14bb0c30-4749-48c8-af98-9dbbd4118097"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15533ff2-0325-4b3c-9a6a-2c6ae97df8d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15736751-2fd6-4498-a1f5-f2e78281820b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("166a2c86-91a5-46ea-a7cc-4214f6554f53"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("173920fb-edda-4bba-99fa-e950f32f5efa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1cbc71ec-724b-40ac-b7fd-8465cddd2ed4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e3530c7-8420-4ed9-997d-e70e1854c3a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1f8976c3-0d19-40a9-99d1-cdf2c837794d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20437f78-3aa2-438f-9816-567bc67b73e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20f3e82f-445d-40ef-a761-d8a88ff88b0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("210dfc7f-89f5-4532-9b9a-8229e98d63b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("22201249-07f5-48c7-8fdc-7b976cfd9f24"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("228b4b89-0419-41c0-978f-298b5c9f8024"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24160181-8013-4647-92a3-11d8d537fadc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2669c5f1-1364-46b9-9715-0b087848ee55"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2bf79fa7-95f5-482d-bd85-4ab8a9c7d9fe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ceca91f-f3ae-43a8-b415-e68928cba814"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f22ac0e-14e2-4691-85c1-764a38922ac9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ff0d344-b17a-4c18-b5fc-521578b95d11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30a25982-85de-43b0-8d63-d957b9cba0ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("314ae6a3-8d5a-4399-be09-f994e29c49be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3294ec41-e11f-4e28-acce-ad0e82aa102e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3382d075-c5e0-4648-9c2b-1467ca5246db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33ee1740-26fb-460d-9fde-a99fee2d9d05"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3743b358-9412-4602-a324-7156967ad326"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37de60eb-a721-4cf0-a20c-7119f8886424"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("38eecb03-28af-4e0d-85c0-ab969910ee98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c560a89-4272-4a6b-931a-ebf0b52e0a3e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d037ef0-ca3e-414b-b0a7-3b57ea4d71ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d8c9a2b-e323-4b04-8e63-a45d25defd5f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f5f560e-fc31-4814-9817-42b5ebb86e3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f6e69fb-ec2f-4848-a987-54f3e8e5fe23"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f97054f-5e62-4b1a-b72c-f3a968278a7d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41dcf1ed-8d52-4a32-b90c-59a92c0cb5bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("422d8641-e8b3-4814-aac0-35dc4130415b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4256419c-3e7f-401b-b289-74fa3444b8a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4782c653-953c-4b5a-adde-c69a93abdff3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b8f74dd-c0bf-45a4-98b8-b2debb019330"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4de415e1-cc12-437e-ac30-454652cb7503"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4df0c423-ad98-472f-9999-b0f7dc2e8493"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4df92187-2fd4-4905-8537-33e192105160"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("50614979-155a-4f1e-8282-9a13ab6e8d76"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5347f77a-58c1-4ee7-b3a7-a2dcc8f681a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("561514d0-d7b3-4ef0-a836-2a808a321a2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("569c2261-9d73-4212-9f50-9fb50d5f8e22"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5839be66-0e7d-45f3-9fa0-efef4d6acac8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5859be97-0675-4ac1-b114-9122a18e02b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58d553bd-12e5-44fe-a00c-cf9268c83a16"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59135fec-40fe-4bde-b6ba-c3eb22100737"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("595e26a5-8ba3-4374-b0dd-6d471b24fffd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59a1b546-01f9-4445-9e98-989d29072341"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59f31fef-2fa0-46ed-8ef8-04e62e17f012"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b7b385f-6d03-4b0c-8887-b9030d0deae2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b888492-f56c-41c1-84f3-a1089f90fd17"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c2fb8f8-a193-474c-96d9-4b062f2bf189"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d185253-85d4-4943-bca9-95c8f8214cb3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d82f613-40f4-4b92-bae1-9de876ebafd4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e1d0750-3ba1-44e0-b995-43ab1c2a9dcb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f0b6b53-e616-48c5-9b67-5915a4513fff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61cb0042-44ae-45c1-ac9c-f353e6f05e98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61e30e85-140a-4750-bf5a-05e76dd99230"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("625e7cd0-84ba-43b5-84da-f0d77ae0e1c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63abfb21-ab8a-4017-90cf-46eed3420cb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63d1dda1-8242-468c-b13f-e06f9d8097e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6683e2e8-c8f7-4232-b091-01e4c8f5df2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("668c8e33-b189-41cb-b254-362e2905bb52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66df5fc5-f5bf-4f8f-9658-a4ffcc6fd0c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67aa2bc6-e727-460a-89ca-1fcaca08ce33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("695d212f-6fb3-4638-a705-d507724fed4d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6986c2b7-3c18-42c4-8844-6e72f3c0dccb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a61ce71-3a6b-4200-a092-7bc249e3220b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a93b60d-cd08-4e45-81d7-624549a8ad39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6bfea72f-01c8-4d5b-85be-dbd9ebc0384f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ca4d7bb-2097-4b95-a21d-838093f85a85"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6dabd1fe-2c39-42b5-8cd5-c26954d2bf8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ec79805-48d6-42da-a0ef-0408c19f0cf4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70486789-5e82-4cac-9bbf-0937f1088bea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("710f37c3-ae16-4c8d-b1da-ffae10771f52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("712a3e77-ee77-4cb7-92fa-98f6e88dce38"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73c0fd8b-ef2d-4f05-88bf-a9130b3e5907"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("74861ed0-ec02-4234-b13a-6c63af3faf36"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7536b00b-6213-4a41-b866-be1dda553d58"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77e5331c-75cc-4e00-8d6c-1cbe8f236909"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78c6c28f-d8be-4dfa-a4fb-bce77d125ba7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a50f61c-b08e-41e4-bb10-608a5aefa6db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7abc3886-25bd-4b1b-9577-6169106319d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ccd934d-4aef-49bb-91e3-ef0d223c07b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7dcf465f-6382-4b4a-80a4-c74cab619b9f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7fd792a6-4577-468b-8f1d-25b9c5eca761"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8181c4f3-0a46-4349-a9cd-4132f9c93e7b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81f49038-47bc-42be-a843-5993c7352fab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("825cc757-dc13-4ae7-9319-d5553d732327"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("855f0c10-bfb2-4d6c-922b-f25ffae5c3c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8570c432-a6e4-4690-829e-e6b8fef892aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86a7b2b5-c28a-482e-ac17-0b3aa313b477"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86c21d74-7b35-46d0-a6e4-7ed3819bbfb7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("891bcfc7-b7aa-4797-a983-8df9a1cd4820"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8937934c-7c46-452d-ba6b-b696e86744b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89f5b6b1-e627-404f-ae5b-bd57301f028c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ca4722a-8d28-4203-8882-17623dce13ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8fc1b0ab-75ab-4603-a81f-12438efd1de4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("90181cad-c221-486f-9225-c690259f1357"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92923542-1c4d-424b-84e6-23c77f0081bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96e7dc42-30e4-4231-934a-60d0fb675f15"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96f11074-14d4-4272-8cc6-681a49be0d28"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98123ae1-c996-4780-bf36-6374ed95223d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a5b7964-2848-4630-b379-83f862acb968"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9bc1440e-b232-487c-988d-7df872bd6616"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9fa74f8c-aa90-48af-9fe0-f2392c2ca8e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a011f1a3-9dfe-438a-babe-02ce3fffb791"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0b59853-9b51-4098-8bde-b634d2e30689"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a47be348-7467-4ecd-9d91-118917790113"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4f0086f-77b5-49a2-83cc-f94b55fb5be2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a5b1b94d-0545-4af3-b251-1dd3154fff8a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a60969e1-a202-45fa-93f7-9dc0fa081f8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a885f8e8-3dce-4cd4-9841-203be9f6e755"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ab51b07d-75b3-4c8a-9431-b50af920fd64"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("abf9e9ac-8616-43b8-b718-57d3e57ec8fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae7d687a-e4cd-43d9-9bdd-be18da3b83f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0f9d7ce-7e96-4f81-95f3-d79ef23fd3d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b13f3a1d-9fb5-4a42-b7ed-3556ddc2b12e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2d69c79-889a-4a4e-8ad9-cb6513628f5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b43c448b-cf1e-4d02-844a-7b663b1edc11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4c16deb-5288-4ed6-b71a-9a59a5ab1896"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b77f9948-746e-4008-975d-74f0054abf1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ba0d6dcd-1dfe-4c18-b2a4-c881fedcd367"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bae2630b-b3be-474a-9369-73f4977555bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bbad40f7-2e87-4efb-aab7-ca253243af84"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd1ca4e9-89ed-47a0-9fc9-e2b54f7eef7e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bdd88e2a-1885-4721-a65a-df83d8d90e91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf2fb981-7fc0-42d7-97b6-7f878c7c8ed2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c500d004-c880-42b1-9b9b-f71761a6682a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c665dfd1-5fc6-4a32-b8cf-f7358a4a900e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7085048-f105-4faf-947e-b33487d327aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c94d56ad-9c3a-4be1-ad49-65cd8d4dd09f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb9528b6-300a-4e2e-9f8f-dd8fd27f056a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd492994-3ff5-407c-a079-5ab6546872dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce9f240d-34e7-4ba9-b7f2-b43116f62bfc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cfd04042-5e1a-401e-bfda-8108225745eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0277780-3115-4277-8d95-0fe15d50649c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d06d0e7c-2d90-4710-987a-825293eac44f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d184414a-4879-426d-83be-8f69af46c136"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d619da5d-5eda-4d6c-9773-259d51c72bd8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db5e6e61-2d94-484e-9d4c-66f2bfc3b181"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd1f0b31-b5d5-4c92-b3d1-c6ee6677703d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd60d518-a931-4e6e-acc2-794cbc682cc1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df8afd38-0d9f-4a0c-936b-86107f7c403b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e02946fe-92bf-4e77-a4ba-8fddae0884a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e24bdfbd-4ad3-45de-9cbf-80ab65d8abe0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e28837b6-8632-4f94-8fa5-834d8cafeafc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e303e97f-cdef-44ad-8161-04737c6431e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e525d315-6964-42f9-9e80-74601c10ee4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e55b8c74-8ee9-4920-b817-2967b2e9c81c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e593209b-55b6-4b68-90d5-8609d36cf1be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e5a4a078-1ab0-4517-8389-4d8a6cebc24f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6246f22-e804-48aa-b7bc-a2fe64568aea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e62b126b-c399-41f4-94aa-c1479ccbd5fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e686b67d-41bd-4645-895d-445fc0074ab5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e82321df-8ed2-414a-b296-122ef2b52026"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8311cb1-df8b-42d3-8652-88eca2e6fad8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea86e9ea-5abe-43a3-ae7b-fc5f5604d8a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb05b664-2512-40f5-8f2c-034abc837311"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed41c8b0-3dfc-48ac-931c-afca1896880a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eda3d56e-2657-4d1a-88d5-114986103535"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eef5d6a6-4ef3-41ec-9856-992f4f415aa1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef79fa3a-34cb-4b63-9a8d-b624b22fd1fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f02cbb2f-80d3-4916-9064-fc8699b0bef5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2c03cb2-0d54-4895-a2e2-c55c0a81f728"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f48e92c7-c299-4e5d-bde0-02ca3c95cdb4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4f9b46a-9a15-4e44-8bf8-867c6dae5f50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f6432189-1890-42d2-bade-e4bb1a6cad44"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f7d0e572-665d-4968-99db-4a1303eb24d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f809dfbe-dfb9-4f18-80f3-1fca1876e87d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f981cf0c-3777-47c6-9379-64da09a56f8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe426673-a346-4616-9a88-67770503d405"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe4aa3a2-f55a-4679-a91e-2f08c252013e"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("7ddcb969-e74e-4ffb-bc7e-696c3d841365"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("c9483456-1330-40fe-b6ea-e8fe3627043c"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("017a039a-a90f-4d21-9140-548238cd51a5"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("5e3f38c0-b72d-4bb1-8495-5734afa9cb9b"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("6507a196-9d38-43cd-990e-1f47dae61261"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("8ab27e4c-3fe7-4ec9-85b2-28e35cefd0f5"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("8bd30d90-d73e-4c7e-a578-d6b12082af1b"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("accc355d-358b-4af2-a32d-4f1bdccb92a6"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("e2eaed99-2b5d-4123-82c0-6ca8ed79fd81"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f2de36a8-9401-4b01-b07c-7e96e0af3bd5"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f5fc3eae-25ce-4555-9f7d-599473ec5c61"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("f80f40c9-da18-4a72-b5f1-387ed311859e"));

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
        }
    }
}
