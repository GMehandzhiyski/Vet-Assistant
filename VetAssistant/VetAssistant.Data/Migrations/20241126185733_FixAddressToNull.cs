using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetAssistant.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixAddressToNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "Address",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Address");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("005d4e06-e03b-4e4d-a132-24ca3b05c4e7"), "BB", "Barbados" },
                    { new Guid("0074e75e-0394-43f1-907b-da3965239150"), "KR", "South Korea" },
                    { new Guid("00a7e856-aac1-4678-82cd-82216e87df19"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("0480469d-9e98-4752-b8b8-d3ca34eb808c"), "AT", "Austria" },
                    { new Guid("0651a7ad-628b-4ddd-a25f-bfc92d111afc"), "HN", "Honduras" },
                    { new Guid("07699185-5797-4cc3-8f32-eed8b13acd89"), "NE", "Niger" },
                    { new Guid("08b37f52-d240-48fe-9154-4d98ecd1a3f0"), "NG", "Nigeria" },
                    { new Guid("0f54f620-b17a-42f3-871c-14a2d802ca17"), "KE", "Kenya" },
                    { new Guid("10536fef-9f99-49d2-90bc-462afc7403a9"), "FM", "Micronesia" },
                    { new Guid("106915b1-f788-41c0-aace-35a83f3e1914"), "BG", "Bulgaria" },
                    { new Guid("1266525b-96da-4125-95a1-3f69f08556c9"), "OM", "Oman" },
                    { new Guid("12d89980-7a10-4219-ab8c-33da842637c0"), "GM", "Gambia" },
                    { new Guid("13a987e4-d773-4764-81c6-9a24eff7bfac"), "IS", "Iceland" },
                    { new Guid("18866938-0b43-41b5-b691-de2ebed2caa9"), "KW", "Kuwait" },
                    { new Guid("188de172-2fc7-4cbc-b7b8-9c33a8254efe"), "AF", "Afghanistan" },
                    { new Guid("196301c1-85b1-444d-a8c2-f41f0ed06610"), "PS", "Palestine" },
                    { new Guid("1a68603f-1d74-452f-8eba-c22cdf448a88"), "MT", "Malta" },
                    { new Guid("1aed6b4f-66e7-4c50-877b-5417580dbe66"), "LT", "Lithuania" },
                    { new Guid("1c7497be-a6e4-417a-89c6-7a0142cd28df"), "SG", "Singapore" },
                    { new Guid("1f464ef1-6bdf-4d15-ab0e-61e63f40f4dd"), "IR", "Iran" },
                    { new Guid("1fe6c64d-f148-475c-b744-22d4022038fe"), "MU", "Mauritius" },
                    { new Guid("20f61cac-6dbc-48db-b8ce-3b855b66ec42"), "PA", "Panama" },
                    { new Guid("213edd02-5c37-4c5d-885d-5010a66af852"), "IT", "Italy" },
                    { new Guid("21e171a7-dca1-4bd1-9eca-546b5bb02ebc"), "HR", "Croatia" },
                    { new Guid("23aa3c84-5461-4b10-bc6c-44c440f8aa6c"), "MR", "Mauritania" },
                    { new Guid("23ee3727-aacc-415e-bee2-18e025aa8681"), "RW", "Rwanda" },
                    { new Guid("249e9b55-0356-4965-866a-daa0c5136331"), "TG", "Togo" },
                    { new Guid("272f9ed1-8a73-4c0e-9b4a-cd16935ec6de"), "TM", "Turkmenistan" },
                    { new Guid("27c47595-88af-42c7-800f-9f61853febb3"), "GA", "Gabon" },
                    { new Guid("28404b0f-e3bd-4197-92cb-cf8f2b09e6a7"), "SR", "Suriname" },
                    { new Guid("2bb67391-0f4f-4b81-a39c-3b3acd31f084"), "JP", "Japan" },
                    { new Guid("2c9dc594-64ce-4594-ade4-1fcc3be45bf7"), "SD", "Sudan" },
                    { new Guid("2e103f33-5895-4812-8990-5be35e673a6b"), "ZW", "Zimbabwe" },
                    { new Guid("2f10696b-aaba-410f-8b1b-55544cc1b3dd"), "NI", "Nicaragua" },
                    { new Guid("3123d7c5-306a-4a11-8abb-bebb9de40756"), "SY", "Syria" },
                    { new Guid("31b57d10-6388-4d54-83db-a9a681ce1d09"), "DK", "Denmark" },
                    { new Guid("322fdb91-7799-42d0-bd18-481c1af6aae3"), "MW", "Malawi" },
                    { new Guid("3350b532-7c34-4399-8a05-ff7551492fb2"), "CN", "China" },
                    { new Guid("3475d62f-c296-44f6-8ab2-a19667f5132e"), "PL", "Poland" },
                    { new Guid("35180bb7-519a-441b-b62e-fa8aadc4e235"), "CH", "Switzerland" },
                    { new Guid("3589b0af-8cbc-4afa-8517-7e991bd49cb7"), "BY", "Belarus" },
                    { new Guid("35eb516b-6577-4c45-b73c-7d1749698939"), "BE", "Belgium" },
                    { new Guid("3659a9dd-a09c-4a84-ab00-45006b77db63"), "CR", "Costa Rica" },
                    { new Guid("37630281-dfcd-42bc-8aef-87a5d8211a80"), "TJ", "Tajikistan" },
                    { new Guid("37835ca4-70ff-4897-b942-dcbf53cdbc64"), "AD", "Andorra" },
                    { new Guid("3804a225-77d1-4c2f-8279-18ac2bbb803f"), "BW", "Botswana" },
                    { new Guid("38bffcca-c6a5-46b7-bb50-ddb9101e689b"), "ET", "Ethiopia" },
                    { new Guid("39e09230-f198-414e-b744-353277bcc931"), "HT", "Haiti" },
                    { new Guid("3d9642d3-9067-4cc9-a44a-94beab03831b"), "GE", "Georgia" },
                    { new Guid("3e30ebd2-2def-41b1-9103-95934a211274"), "BR", "Brazil" },
                    { new Guid("3ef9cc9b-731a-4cf8-afab-89942094086d"), "MG", "Madagascar" },
                    { new Guid("3f1ba679-e94f-48d2-a20e-0c03aec0b973"), "NZ", "New Zealand" },
                    { new Guid("401733a5-5bfc-44bf-89b3-9d1055de0164"), "CU", "Cuba" },
                    { new Guid("415a39fe-d0ad-41dc-b0ab-1982f00f2279"), "TR", "Turkey" },
                    { new Guid("44ae4c9d-4c89-4705-9e6d-f25232f2b938"), "BO", "Bolivia" },
                    { new Guid("44b8f960-0427-49fb-98b0-8b4a4a0a6908"), "CF", "Central African Republic" },
                    { new Guid("44e7e6c7-7870-4275-b74a-7ef4425dc719"), "EE", "Estonia" },
                    { new Guid("457311c4-1fc8-43e4-b572-501ffa2d071b"), "NA", "Namibia" },
                    { new Guid("46c0f47b-732b-4c95-a16a-2403e0367b0b"), "KZ", "Kazakhstan" },
                    { new Guid("47c7265e-6728-4490-9a4a-f8a662ac3e9c"), "AO", "Angola" },
                    { new Guid("486a4ccb-fa6c-4296-8ad1-10cb7ac8752f"), "AU", "Australia" },
                    { new Guid("49444fca-35f7-4eb1-961f-c7f3b30f7daf"), "SS", "South Sudan" },
                    { new Guid("4992a8c8-9163-4bb7-99de-121cee3f7d99"), "QA", "Qatar" },
                    { new Guid("4d37f4b5-899b-4d96-a08c-28af2c98068a"), "GD", "Grenada" },
                    { new Guid("509a1ff2-e3e9-42b3-b507-acaae6076cac"), "DZ", "Algeria" },
                    { new Guid("517bd61d-dbfe-4366-bc03-290ae60f83c6"), "MV", "Maldives" },
                    { new Guid("53b5e578-b042-403b-bdd7-2a28b60cdb4a"), "SL", "Sierra Leone" },
                    { new Guid("53fbb85e-a9b7-49be-9e16-8cc446d53ea6"), "CM", "Cameroon" },
                    { new Guid("5446d733-d06b-4fa7-a617-d9747dee8d3f"), "LS", "Lesotho" },
                    { new Guid("58b6c09d-67b0-42fd-9a1e-a79c84b1a74d"), "FR", "France" },
                    { new Guid("59f567d2-264d-42b8-8d89-bc5f5b8f7143"), "RU", "Russia" },
                    { new Guid("5a898d5b-9d74-42b4-a8df-9167390ecb69"), "ML", "Mali" },
                    { new Guid("5cb1e796-220e-4f94-bc4a-d1b82f6415b4"), "GB", "United Kingdom" },
                    { new Guid("5e22b657-8724-49d4-99bd-33f3fcbeaac6"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("5e963e42-34da-47b0-9103-d13ba66baba8"), "CG", "Congo (Congo-Brazzaville)" },
                    { new Guid("5ec086f5-de25-4bc9-a288-c6bfe70be1af"), "NO", "Norway" },
                    { new Guid("61d03ee9-0a9e-4f83-a617-4a925ff05b00"), "IE", "Ireland" },
                    { new Guid("627657a3-3abd-4ce8-a2a8-fa4d03a5e464"), "SE", "Sweden" },
                    { new Guid("63803219-9f50-42dc-9335-560d6fcc6d3a"), "EC", "Ecuador" },
                    { new Guid("639b7d4d-9c1e-44ad-b597-dda7ea755945"), "DJ", "Djibouti" },
                    { new Guid("63c2da9d-c4f6-43e4-9809-afa7e1341621"), "SM", "San Marino" },
                    { new Guid("649b12be-6f31-4f21-a36d-efabaaf77867"), "LY", "Libya" },
                    { new Guid("64a4fc74-387c-44db-aed9-e85374259234"), "SZ", "Eswatini" },
                    { new Guid("64c022f3-8e77-474e-9c22-eb92eb61bee2"), "BT", "Bhutan" },
                    { new Guid("65386702-dbc0-45ea-b47e-3e1313b79a73"), "UY", "Uruguay" },
                    { new Guid("6b29e034-3d6f-42a7-9d90-086ab244fdd2"), "PG", "Papua New Guinea" },
                    { new Guid("6b34a267-3109-4388-bdc4-29ddfba9542f"), "BJ", "Benin" },
                    { new Guid("6cf300a5-886a-499e-86df-eef73abdfd39"), "MY", "Malaysia" },
                    { new Guid("7400fb63-7ab3-4f51-8ee7-a7d3e900d028"), "TH", "Thailand" },
                    { new Guid("75f9184f-7ee8-451a-82d3-a31892f02f79"), "LC", "Saint Lucia" },
                    { new Guid("761d8933-e106-413f-8e8b-d2988496bfd8"), "CZ", "Czechia (Czech Republic)" },
                    { new Guid("7636c86e-b975-44bc-ba32-23eb86a34de7"), "US", "United States of America" },
                    { new Guid("7781e9f3-ff09-4654-9089-bf19bbc305d4"), "GR", "Greece" },
                    { new Guid("7988a4ca-f689-4a17-8ece-9803bd560a08"), "PE", "Peru" },
                    { new Guid("7a71599a-b99b-4883-b457-7e41bf7d2921"), "VE", "Venezuela" },
                    { new Guid("7c7178de-5491-4687-ae13-730781165882"), "CL", "Chile" },
                    { new Guid("7d7d25cb-c7b7-4619-a0f6-b864efc3d5a3"), "GQ", "Equatorial Guinea" },
                    { new Guid("7fe5273d-ee5a-44c3-b097-29e2383583bf"), "YE", "Yemen" },
                    { new Guid("83ed3378-c98a-4dbe-af7f-98eb70f5dfec"), "MN", "Mongolia" },
                    { new Guid("8492cdd7-d98e-4bd2-a9b0-c61a8186c55f"), "PT", "Portugal" },
                    { new Guid("860ba12d-65cf-4d9f-9a6c-303c28cd63b2"), "MH", "Marshall Islands" },
                    { new Guid("86240609-e692-4073-ade1-6fead42ee15f"), "CV", "Cabo Verde" },
                    { new Guid("8b54f723-da90-43a6-bf44-a0b13bbf5d59"), "ID", "Indonesia" },
                    { new Guid("8e56d308-15ef-4fb2-bd4f-e1ec6a9b35dd"), "VN", "Vietnam" },
                    { new Guid("90b8403f-a2a1-48ee-a8f3-9a5283b45351"), "LV", "Latvia" },
                    { new Guid("92445675-c7ee-49be-967a-9f432f736a98"), "BF", "Burkina Faso" },
                    { new Guid("95c8c530-238a-4fce-b67f-e835fd3cfd41"), "JM", "Jamaica" },
                    { new Guid("9995008f-1738-4893-9e87-0aca76577cb7"), "NL", "Netherlands" },
                    { new Guid("9a6062fb-d320-4cb5-90e9-882010ec9790"), "BI", "Burundi" },
                    { new Guid("9a8d051f-8866-40c9-9cc0-36984cffc076"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("9afcc21f-1783-4387-9bbd-b34291262b7d"), "LA", "Laos" },
                    { new Guid("9cbec5d6-69fe-462e-8d43-e3b00ed55eb2"), "GY", "Guyana" },
                    { new Guid("9cd79b42-61ad-4447-adb9-6a6c1a200ded"), "MD", "Moldova" },
                    { new Guid("9e805074-9d67-4dbe-886e-fd9207671ac4"), "TV", "Tuvalu" },
                    { new Guid("9fc5969f-0d0d-4103-b9cc-f1fd53b1e109"), "AE", "United Arab Emirates" },
                    { new Guid("a0c50c20-ac67-4a17-ab76-124efc3082dd"), "SC", "Seychelles" },
                    { new Guid("a225a20d-320a-4c08-b589-653942ec2c07"), "FI", "Finland" },
                    { new Guid("a4586d71-15c5-4964-85fb-8682dd199ba4"), "GW", "Guinea-Bissau" },
                    { new Guid("a504961b-4bfb-46f6-9174-38918c09f393"), "SN", "Senegal" },
                    { new Guid("a63379be-30cb-43c2-a289-d6b641c2863f"), "CY", "Cyprus" },
                    { new Guid("aa2bd7b4-083b-4e68-ae7c-771267d0ccdf"), "LR", "Liberia" },
                    { new Guid("ac9a9ef9-2660-44ba-8f01-c6878dfcd863"), "BN", "Brunei" },
                    { new Guid("ae40d754-2c47-4d11-add3-fb74a7a8f30b"), "HU", "Hungary" },
                    { new Guid("ae8f340b-fcab-4195-bb67-775d85041a08"), "TZ", "Tanzania" },
                    { new Guid("ae97d9a2-1b2d-447e-b4d8-5aa875da5a95"), "ST", "Sao Tome and Principe" },
                    { new Guid("af7e7718-6c6b-4f73-8dd6-a64019a16f04"), "MM", "Myanmar" },
                    { new Guid("afc20874-f43a-42b9-930f-54930eeb91d5"), "PK", "Pakistan" },
                    { new Guid("b1ece11a-3ce8-4d39-82be-d6beb8be3738"), "GN", "Guinea" },
                    { new Guid("b2d8e5da-9eca-4d06-b9c0-e8fa239282d1"), "ES", "Spain" },
                    { new Guid("b2e0cf47-6b5a-4769-80c1-90843c293404"), "JO", "Jordan" },
                    { new Guid("b31bcd2e-b48c-4a24-88eb-5a12c78de114"), "LI", "Liechtenstein" },
                    { new Guid("b34d5cf6-ccd9-4d93-9f8a-f752efd1bbdd"), "PW", "Palau" },
                    { new Guid("b5267bbd-a80b-4271-9bfa-80cc0afd4c9b"), "AG", "Antigua and Barbuda" },
                    { new Guid("b64b1612-bc6d-4ffc-9d10-fa9c2a4aaf63"), "IL", "Israel" },
                    { new Guid("b77b035d-71f3-4a59-b9e1-ad8bd6ea09c3"), "NP", "Nepal" },
                    { new Guid("b7a7a36b-3ece-40aa-b47b-7c63ce6e0ea0"), "TD", "Chad" },
                    { new Guid("b815a24c-20c7-4d08-b784-b10b8b10c910"), "SA", "Saudi Arabia" },
                    { new Guid("b985cec0-73a5-4ee0-a454-e963d809237e"), "LU", "Luxembourg" },
                    { new Guid("bb40a53d-6a67-4113-a398-7d01c820c190"), "AL", "Albania" },
                    { new Guid("bb75a570-a843-4e91-86ca-d1357c5fa68d"), "ZM", "Zambia" },
                    { new Guid("bd32d905-c61b-4f9c-badc-61ae68717bac"), "VA", "Vatican City" },
                    { new Guid("bd7e13dc-4427-4a2b-85c1-48b7c14f4da8"), "MX", "Mexico" },
                    { new Guid("be242e43-dc6b-42db-a3e6-f703cd1036e1"), "FJ", "Fiji" },
                    { new Guid("c14cb4f3-762b-496b-87e2-7fb2daa88a50"), "AR", "Argentina" },
                    { new Guid("c515beda-006a-49a0-a4ac-5d173448e77f"), "KG", "Kyrgyzstan" },
                    { new Guid("c78c524d-ce32-4970-9537-6d941ffd4743"), "ZA", "South Africa" },
                    { new Guid("c8e3ab41-7428-4b1b-a4f7-262435a16da6"), "MA", "Morocco" },
                    { new Guid("c96119f6-9a0e-49e9-92a0-84d0334cb0b8"), "EG", "Egypt" },
                    { new Guid("ca187194-0143-493f-a5fc-76a45435871e"), "BS", "Bahamas" },
                    { new Guid("caf66bd6-62ef-46bf-96b9-f22adb4f9f36"), "IN", "India" },
                    { new Guid("cb061f4a-e891-4c40-af0e-dd579c8ae4e8"), "LB", "Lebanon" },
                    { new Guid("ccfea695-9e2a-4ddc-8e11-fbc8c28eeb0d"), "SV", "El Salvador" },
                    { new Guid("cd5fd070-3e5c-422b-a1ea-9bc0cf37d820"), "TN", "Tunisia" },
                    { new Guid("cd6fea33-614a-48e7-9131-e7f794cd3104"), "PY", "Paraguay" },
                    { new Guid("cdb4e7c9-c432-4d5d-9919-d4778bf604cf"), "LK", "Sri Lanka" },
                    { new Guid("ce165c27-ede7-4ead-9033-1c93dff4ceac"), "MC", "Monaco" },
                    { new Guid("cf06c991-3375-4341-a03f-bd318f9a804b"), "DM", "Dominica" },
                    { new Guid("d0645444-4c27-4c77-b89b-5b1be1a4892e"), "NR", "Nauru" },
                    { new Guid("d33796ec-6496-4219-80d2-85817f858eb1"), "GT", "Guatemala" },
                    { new Guid("d36e6009-ab3a-411f-98c1-400d595e723e"), "AM", "Armenia" },
                    { new Guid("d3e1b411-b7c8-4e7e-a60f-fffa500538ef"), "DO", "Dominican Republic" },
                    { new Guid("d50792ec-191b-40f9-8daf-40d54646915e"), "SI", "Slovenia" },
                    { new Guid("d6eff1c7-a818-4fa3-b501-fde8257138bd"), "TT", "Trinidad and Tobago" },
                    { new Guid("d72edb45-b199-4295-85e7-045aef7ae7ce"), "DE", "Germany" },
                    { new Guid("d8f63fa9-5685-44c0-99ba-7c2e9eab71e2"), "CO", "Colombia" },
                    { new Guid("da0053b6-39b8-4896-8aa6-8a6cfba373bf"), "PH", "Philippines" },
                    { new Guid("dbf33db9-1a5d-4db0-9ffb-ea5a09100754"), "GH", "Ghana" },
                    { new Guid("dc3c78c1-8a51-4cec-9ce4-959bc779db03"), "KI", "Kiribati" },
                    { new Guid("dde732df-58c5-44f0-9fa5-afcc04de71d8"), "SK", "Slovakia" },
                    { new Guid("e4f613c5-ddc9-4641-8d3d-4389f5b5a00c"), "MK", "North Macedonia" },
                    { new Guid("e55f0fbe-9842-41dd-8a2d-1e43b4cbdee3"), "BH", "Bahrain" },
                    { new Guid("e9f84c9c-51f7-4898-9e5f-3b9ce5f8fd6f"), "UG", "Uganda" },
                    { new Guid("ed1b958c-73b8-487b-bee0-f7a9f78d0039"), "UZ", "Uzbekistan" },
                    { new Guid("ed288f9d-5303-4bb1-b406-19ea4658ee1b"), "RO", "Romania" },
                    { new Guid("edb70e5f-72af-458c-adcd-8f792f93df03"), "CA", "Canada" },
                    { new Guid("edd3bb76-2a25-4451-a4ea-4358183c6473"), "BD", "Bangladesh" },
                    { new Guid("ee04612b-f06b-4427-8c11-ec2c8b4de628"), "RS", "Serbia" },
                    { new Guid("ef2c3536-2d69-49f4-91e1-91ef14115cb7"), "VA", "Holy See" },
                    { new Guid("ef348d90-c447-4525-a0c5-cee276328d15"), "KP", "North Korea" },
                    { new Guid("efabbc8e-3735-4ed3-b7fb-ea97b127833a"), "KH", "Cambodia" },
                    { new Guid("f067df1d-afda-433e-8bbc-06360cf898a0"), "SB", "Solomon Islands" },
                    { new Guid("f31203a7-62b3-4c8f-8d6b-e1654c3dc2fc"), "SO", "Somalia" },
                    { new Guid("f3c9e9c6-4fca-4b48-9f5b-43302e57a1ff"), "AZ", "Azerbaijan" },
                    { new Guid("f3e16de3-eae9-471f-b6df-909b7d33abc5"), "IQ", "Iraq" },
                    { new Guid("f424e2df-b3ad-49ae-9d6c-07d54a453db6"), "VU", "Vanuatu" },
                    { new Guid("f4e3e6d4-085c-46cb-8ee3-5ccabc326b6a"), "TL", "Timor-Leste" },
                    { new Guid("f56847c3-53c3-4f42-8448-69e1be0b088c"), "BZ", "Belize" },
                    { new Guid("f686ebc7-e4c4-4287-abcb-d86e3b7de61c"), "UA", "Ukraine" },
                    { new Guid("f7fe0411-b726-47a7-b47c-9a2ce67d71ad"), "ME", "Montenegro" },
                    { new Guid("f8ca62d6-9d66-43d9-ad78-80384eb456f8"), "ER", "Eritrea" },
                    { new Guid("f96cd7d1-82cf-4e06-9073-4fe58c547f39"), "KM", "Comoros" },
                    { new Guid("fdfcd70d-5823-4ad7-8a28-bc23c84b7602"), "TO", "Tonga" },
                    { new Guid("fe3fecf5-d930-4123-be5d-450a55ca7386"), "MZ", "Mozambique" },
                    { new Guid("ff9312f7-a691-4f13-a4b8-c4e4284447ed"), "WS", "Samoa" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("57bf03a0-1aef-4b9e-966d-ca8538559939"), "Male" },
                    { new Guid("f4d1baeb-186c-4a96-a839-73c03505efa5"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "TypeInspections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("124e22e7-2ed6-41ab-b77d-cfacdf0a0c91"), "Preventive Interventions" },
                    { new Guid("1bbe688e-1baf-459b-b004-5230e5206f89"), "Exotic and Specialized Interventions" },
                    { new Guid("1e4ceee4-399c-4b90-817c-0c23344bc210"), "Surgical Interventions" },
                    { new Guid("2d504f6d-5ed8-4d93-8e20-4dfbc719e35e"), "Postoperative Care" },
                    { new Guid("35ecf1ac-e247-46f1-89c1-ec37b9f87082"), "Therapeutic Interventions" },
                    { new Guid("7a46c5d3-b0b4-4de9-add5-167326649bc5"), "Oncological Interventions" },
                    { new Guid("91c85d6a-1f17-408c-a48f-91b684fcfcca"), "Emergency" },
                    { new Guid("96202a50-0062-417b-b5ba-0107529ed4a2"), "Diagnostic Interventions" },
                    { new Guid("9842792f-bbc6-430c-9942-231ca24c8a8e"), "Dental Interventions" },
                    { new Guid("d3d192a7-79dc-4557-8817-45a3528f0fc3"), "Obstetric and Reproductive Interventions" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("005d4e06-e03b-4e4d-a132-24ca3b05c4e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0074e75e-0394-43f1-907b-da3965239150"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00a7e856-aac1-4678-82cd-82216e87df19"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0480469d-9e98-4752-b8b8-d3ca34eb808c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0651a7ad-628b-4ddd-a25f-bfc92d111afc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07699185-5797-4cc3-8f32-eed8b13acd89"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08b37f52-d240-48fe-9154-4d98ecd1a3f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f54f620-b17a-42f3-871c-14a2d802ca17"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("10536fef-9f99-49d2-90bc-462afc7403a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("106915b1-f788-41c0-aace-35a83f3e1914"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1266525b-96da-4125-95a1-3f69f08556c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12d89980-7a10-4219-ab8c-33da842637c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13a987e4-d773-4764-81c6-9a24eff7bfac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18866938-0b43-41b5-b691-de2ebed2caa9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("188de172-2fc7-4cbc-b7b8-9c33a8254efe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("196301c1-85b1-444d-a8c2-f41f0ed06610"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a68603f-1d74-452f-8eba-c22cdf448a88"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1aed6b4f-66e7-4c50-877b-5417580dbe66"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c7497be-a6e4-417a-89c6-7a0142cd28df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1f464ef1-6bdf-4d15-ab0e-61e63f40f4dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1fe6c64d-f148-475c-b744-22d4022038fe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20f61cac-6dbc-48db-b8ce-3b855b66ec42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("213edd02-5c37-4c5d-885d-5010a66af852"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21e171a7-dca1-4bd1-9eca-546b5bb02ebc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23aa3c84-5461-4b10-bc6c-44c440f8aa6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("23ee3727-aacc-415e-bee2-18e025aa8681"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("249e9b55-0356-4965-866a-daa0c5136331"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("272f9ed1-8a73-4c0e-9b4a-cd16935ec6de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27c47595-88af-42c7-800f-9f61853febb3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28404b0f-e3bd-4197-92cb-cf8f2b09e6a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2bb67391-0f4f-4b81-a39c-3b3acd31f084"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c9dc594-64ce-4594-ade4-1fcc3be45bf7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e103f33-5895-4812-8990-5be35e673a6b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f10696b-aaba-410f-8b1b-55544cc1b3dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3123d7c5-306a-4a11-8abb-bebb9de40756"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31b57d10-6388-4d54-83db-a9a681ce1d09"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("322fdb91-7799-42d0-bd18-481c1af6aae3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3350b532-7c34-4399-8a05-ff7551492fb2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3475d62f-c296-44f6-8ab2-a19667f5132e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35180bb7-519a-441b-b62e-fa8aadc4e235"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3589b0af-8cbc-4afa-8517-7e991bd49cb7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35eb516b-6577-4c45-b73c-7d1749698939"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3659a9dd-a09c-4a84-ab00-45006b77db63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37630281-dfcd-42bc-8aef-87a5d8211a80"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37835ca4-70ff-4897-b942-dcbf53cdbc64"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3804a225-77d1-4c2f-8279-18ac2bbb803f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("38bffcca-c6a5-46b7-bb50-ddb9101e689b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39e09230-f198-414e-b744-353277bcc931"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d9642d3-9067-4cc9-a44a-94beab03831b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e30ebd2-2def-41b1-9103-95934a211274"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ef9cc9b-731a-4cf8-afab-89942094086d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f1ba679-e94f-48d2-a20e-0c03aec0b973"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("401733a5-5bfc-44bf-89b3-9d1055de0164"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("415a39fe-d0ad-41dc-b0ab-1982f00f2279"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("44ae4c9d-4c89-4705-9e6d-f25232f2b938"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("44b8f960-0427-49fb-98b0-8b4a4a0a6908"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("44e7e6c7-7870-4275-b74a-7ef4425dc719"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("457311c4-1fc8-43e4-b572-501ffa2d071b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46c0f47b-732b-4c95-a16a-2403e0367b0b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47c7265e-6728-4490-9a4a-f8a662ac3e9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("486a4ccb-fa6c-4296-8ad1-10cb7ac8752f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49444fca-35f7-4eb1-961f-c7f3b30f7daf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4992a8c8-9163-4bb7-99de-121cee3f7d99"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d37f4b5-899b-4d96-a08c-28af2c98068a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("509a1ff2-e3e9-42b3-b507-acaae6076cac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("517bd61d-dbfe-4366-bc03-290ae60f83c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53b5e578-b042-403b-bdd7-2a28b60cdb4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53fbb85e-a9b7-49be-9e16-8cc446d53ea6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5446d733-d06b-4fa7-a617-d9747dee8d3f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58b6c09d-67b0-42fd-9a1e-a79c84b1a74d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59f567d2-264d-42b8-8d89-bc5f5b8f7143"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a898d5b-9d74-42b4-a8df-9167390ecb69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5cb1e796-220e-4f94-bc4a-d1b82f6415b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e22b657-8724-49d4-99bd-33f3fcbeaac6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e963e42-34da-47b0-9103-d13ba66baba8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ec086f5-de25-4bc9-a288-c6bfe70be1af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61d03ee9-0a9e-4f83-a617-4a925ff05b00"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("627657a3-3abd-4ce8-a2a8-fa4d03a5e464"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63803219-9f50-42dc-9335-560d6fcc6d3a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("639b7d4d-9c1e-44ad-b597-dda7ea755945"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63c2da9d-c4f6-43e4-9809-afa7e1341621"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("649b12be-6f31-4f21-a36d-efabaaf77867"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64a4fc74-387c-44db-aed9-e85374259234"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64c022f3-8e77-474e-9c22-eb92eb61bee2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65386702-dbc0-45ea-b47e-3e1313b79a73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b29e034-3d6f-42a7-9d90-086ab244fdd2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b34a267-3109-4388-bdc4-29ddfba9542f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6cf300a5-886a-499e-86df-eef73abdfd39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7400fb63-7ab3-4f51-8ee7-a7d3e900d028"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("75f9184f-7ee8-451a-82d3-a31892f02f79"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("761d8933-e106-413f-8e8b-d2988496bfd8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7636c86e-b975-44bc-ba32-23eb86a34de7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7781e9f3-ff09-4654-9089-bf19bbc305d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7988a4ca-f689-4a17-8ece-9803bd560a08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a71599a-b99b-4883-b457-7e41bf7d2921"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7c7178de-5491-4687-ae13-730781165882"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d7d25cb-c7b7-4619-a0f6-b864efc3d5a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7fe5273d-ee5a-44c3-b097-29e2383583bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83ed3378-c98a-4dbe-af7f-98eb70f5dfec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8492cdd7-d98e-4bd2-a9b0-c61a8186c55f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("860ba12d-65cf-4d9f-9a6c-303c28cd63b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86240609-e692-4073-ade1-6fead42ee15f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b54f723-da90-43a6-bf44-a0b13bbf5d59"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e56d308-15ef-4fb2-bd4f-e1ec6a9b35dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("90b8403f-a2a1-48ee-a8f3-9a5283b45351"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92445675-c7ee-49be-967a-9f432f736a98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95c8c530-238a-4fce-b67f-e835fd3cfd41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9995008f-1738-4893-9e87-0aca76577cb7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a6062fb-d320-4cb5-90e9-882010ec9790"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a8d051f-8866-40c9-9cc0-36984cffc076"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9afcc21f-1783-4387-9bbd-b34291262b7d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9cbec5d6-69fe-462e-8d43-e3b00ed55eb2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9cd79b42-61ad-4447-adb9-6a6c1a200ded"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e805074-9d67-4dbe-886e-fd9207671ac4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9fc5969f-0d0d-4103-b9cc-f1fd53b1e109"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0c50c20-ac67-4a17-ab76-124efc3082dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a225a20d-320a-4c08-b589-653942ec2c07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4586d71-15c5-4964-85fb-8682dd199ba4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a504961b-4bfb-46f6-9174-38918c09f393"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a63379be-30cb-43c2-a289-d6b641c2863f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa2bd7b4-083b-4e68-ae7c-771267d0ccdf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ac9a9ef9-2660-44ba-8f01-c6878dfcd863"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae40d754-2c47-4d11-add3-fb74a7a8f30b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae8f340b-fcab-4195-bb67-775d85041a08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae97d9a2-1b2d-447e-b4d8-5aa875da5a95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af7e7718-6c6b-4f73-8dd6-a64019a16f04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afc20874-f43a-42b9-930f-54930eeb91d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1ece11a-3ce8-4d39-82be-d6beb8be3738"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2d8e5da-9eca-4d06-b9c0-e8fa239282d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2e0cf47-6b5a-4769-80c1-90843c293404"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b31bcd2e-b48c-4a24-88eb-5a12c78de114"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b34d5cf6-ccd9-4d93-9f8a-f752efd1bbdd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5267bbd-a80b-4271-9bfa-80cc0afd4c9b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b64b1612-bc6d-4ffc-9d10-fa9c2a4aaf63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b77b035d-71f3-4a59-b9e1-ad8bd6ea09c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b7a7a36b-3ece-40aa-b47b-7c63ce6e0ea0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b815a24c-20c7-4d08-b784-b10b8b10c910"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b985cec0-73a5-4ee0-a454-e963d809237e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb40a53d-6a67-4113-a398-7d01c820c190"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb75a570-a843-4e91-86ca-d1357c5fa68d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd32d905-c61b-4f9c-badc-61ae68717bac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd7e13dc-4427-4a2b-85c1-48b7c14f4da8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be242e43-dc6b-42db-a3e6-f703cd1036e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c14cb4f3-762b-496b-87e2-7fb2daa88a50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c515beda-006a-49a0-a4ac-5d173448e77f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c78c524d-ce32-4970-9537-6d941ffd4743"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c8e3ab41-7428-4b1b-a4f7-262435a16da6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c96119f6-9a0e-49e9-92a0-84d0334cb0b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca187194-0143-493f-a5fc-76a45435871e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("caf66bd6-62ef-46bf-96b9-f22adb4f9f36"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb061f4a-e891-4c40-af0e-dd579c8ae4e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ccfea695-9e2a-4ddc-8e11-fbc8c28eeb0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd5fd070-3e5c-422b-a1ea-9bc0cf37d820"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd6fea33-614a-48e7-9131-e7f794cd3104"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdb4e7c9-c432-4d5d-9919-d4778bf604cf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce165c27-ede7-4ead-9033-1c93dff4ceac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf06c991-3375-4341-a03f-bd318f9a804b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0645444-4c27-4c77-b89b-5b1be1a4892e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d33796ec-6496-4219-80d2-85817f858eb1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d36e6009-ab3a-411f-98c1-400d595e723e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3e1b411-b7c8-4e7e-a60f-fffa500538ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d50792ec-191b-40f9-8daf-40d54646915e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6eff1c7-a818-4fa3-b501-fde8257138bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d72edb45-b199-4295-85e7-045aef7ae7ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d8f63fa9-5685-44c0-99ba-7c2e9eab71e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da0053b6-39b8-4896-8aa6-8a6cfba373bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dbf33db9-1a5d-4db0-9ffb-ea5a09100754"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc3c78c1-8a51-4cec-9ce4-959bc779db03"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dde732df-58c5-44f0-9fa5-afcc04de71d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4f613c5-ddc9-4641-8d3d-4389f5b5a00c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e55f0fbe-9842-41dd-8a2d-1e43b4cbdee3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e9f84c9c-51f7-4898-9e5f-3b9ce5f8fd6f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed1b958c-73b8-487b-bee0-f7a9f78d0039"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed288f9d-5303-4bb1-b406-19ea4658ee1b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("edb70e5f-72af-458c-adcd-8f792f93df03"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("edd3bb76-2a25-4451-a4ea-4358183c6473"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee04612b-f06b-4427-8c11-ec2c8b4de628"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef2c3536-2d69-49f4-91e1-91ef14115cb7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef348d90-c447-4525-a0c5-cee276328d15"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efabbc8e-3735-4ed3-b7fb-ea97b127833a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f067df1d-afda-433e-8bbc-06360cf898a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f31203a7-62b3-4c8f-8d6b-e1654c3dc2fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3c9e9c6-4fca-4b48-9f5b-43302e57a1ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3e16de3-eae9-471f-b6df-909b7d33abc5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f424e2df-b3ad-49ae-9d6c-07d54a453db6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4e3e6d4-085c-46cb-8ee3-5ccabc326b6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f56847c3-53c3-4f42-8448-69e1be0b088c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f686ebc7-e4c4-4287-abcb-d86e3b7de61c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f7fe0411-b726-47a7-b47c-9a2ce67d71ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f8ca62d6-9d66-43d9-ad78-80384eb456f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f96cd7d1-82cf-4e06-9073-4fe58c547f39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fdfcd70d-5823-4ad7-8a28-bc23c84b7602"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe3fecf5-d930-4123-be5d-450a55ca7386"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff9312f7-a691-4f13-a4b8-c4e4284447ed"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("57bf03a0-1aef-4b9e-966d-ca8538559939"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f4d1baeb-186c-4a96-a839-73c03505efa5"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("124e22e7-2ed6-41ab-b77d-cfacdf0a0c91"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("1bbe688e-1baf-459b-b004-5230e5206f89"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("1e4ceee4-399c-4b90-817c-0c23344bc210"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("2d504f6d-5ed8-4d93-8e20-4dfbc719e35e"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("35ecf1ac-e247-46f1-89c1-ec37b9f87082"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("7a46c5d3-b0b4-4de9-add5-167326649bc5"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("91c85d6a-1f17-408c-a48f-91b684fcfcca"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("96202a50-0062-417b-b5ba-0107529ed4a2"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("9842792f-bbc6-430c-9942-231ca24c8a8e"));

            migrationBuilder.DeleteData(
                table: "TypeInspections",
                keyColumn: "Id",
                keyValue: new Guid("d3d192a7-79dc-4557-8817-45a3528f0fc3"));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                comment: "Address",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "Address");

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
    }
}
