using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.BookStore.Migrations
{
    public partial class rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerApiClaims_IdentityServerApiResources_ApiResourceId",
                table: "IdentityServerApiClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerApiScopeClaims_IdentityServerApiScopes_ApiResourceId_Name",
                table: "IdentityServerApiScopeClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerApiScopes_IdentityServerApiResources_ApiResourceId",
                table: "IdentityServerApiScopes");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerApiSecrets_IdentityServerApiResources_ApiResourceId",
                table: "IdentityServerApiSecrets");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerClientClaims_IdentityServerClients_ClientId",
                table: "IdentityServerClientClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerClientCorsOrigins_IdentityServerClients_ClientId",
                table: "IdentityServerClientCorsOrigins");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerClientGrantTypes_IdentityServerClients_ClientId",
                table: "IdentityServerClientGrantTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerClientIdPRestrictions_IdentityServerClients_ClientId",
                table: "IdentityServerClientIdPRestrictions");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerClientPostLogoutRedirectUris_IdentityServerClients_ClientId",
                table: "IdentityServerClientPostLogoutRedirectUris");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerClientProperties_IdentityServerClients_ClientId",
                table: "IdentityServerClientProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerClientRedirectUris_IdentityServerClients_ClientId",
                table: "IdentityServerClientRedirectUris");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerClientScopes_IdentityServerClients_ClientId",
                table: "IdentityServerClientScopes");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerClientSecrets_IdentityServerClients_ClientId",
                table: "IdentityServerClientSecrets");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityServerIdentityClaims_IdentityServerIdentityResources_IdentityResourceId",
                table: "IdentityServerIdentityClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerPersistedGrants",
                table: "IdentityServerPersistedGrants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerIdentityResources",
                table: "IdentityServerIdentityResources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerIdentityClaims",
                table: "IdentityServerIdentityClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerDeviceFlowCodes",
                table: "IdentityServerDeviceFlowCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClientSecrets",
                table: "IdentityServerClientSecrets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClientScopes",
                table: "IdentityServerClientScopes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClients",
                table: "IdentityServerClients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClientRedirectUris",
                table: "IdentityServerClientRedirectUris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClientProperties",
                table: "IdentityServerClientProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClientPostLogoutRedirectUris",
                table: "IdentityServerClientPostLogoutRedirectUris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClientIdPRestrictions",
                table: "IdentityServerClientIdPRestrictions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClientGrantTypes",
                table: "IdentityServerClientGrantTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClientCorsOrigins",
                table: "IdentityServerClientCorsOrigins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerClientClaims",
                table: "IdentityServerClientClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerApiSecrets",
                table: "IdentityServerApiSecrets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerApiScopes",
                table: "IdentityServerApiScopes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerApiScopeClaims",
                table: "IdentityServerApiScopeClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerApiResources",
                table: "IdentityServerApiResources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityServerApiClaims",
                table: "IdentityServerApiClaims");

            migrationBuilder.RenameTable(
                name: "IdentityServerPersistedGrants",
                newName: "MyIdentityServerPersistedGrants");

            migrationBuilder.RenameTable(
                name: "IdentityServerIdentityResources",
                newName: "MyIdentityServerIdentityResources");

            migrationBuilder.RenameTable(
                name: "IdentityServerIdentityClaims",
                newName: "MyIdentityServerIdentityClaims");

            migrationBuilder.RenameTable(
                name: "IdentityServerDeviceFlowCodes",
                newName: "MyIdentityServerDeviceFlowCodes");

            migrationBuilder.RenameTable(
                name: "IdentityServerClientSecrets",
                newName: "MyIdentityServerClientSecrets");

            migrationBuilder.RenameTable(
                name: "IdentityServerClientScopes",
                newName: "MyIdentityServerClientScopes");

            migrationBuilder.RenameTable(
                name: "IdentityServerClients",
                newName: "MyIdentityServerClients");

            migrationBuilder.RenameTable(
                name: "IdentityServerClientRedirectUris",
                newName: "MyIdentityServerClientRedirectUris");

            migrationBuilder.RenameTable(
                name: "IdentityServerClientProperties",
                newName: "MyIdentityServerClientProperties");

            migrationBuilder.RenameTable(
                name: "IdentityServerClientPostLogoutRedirectUris",
                newName: "MyIdentityServerClientPostLogoutRedirectUris");

            migrationBuilder.RenameTable(
                name: "IdentityServerClientIdPRestrictions",
                newName: "MyIdentityServerClientIdPRestrictions");

            migrationBuilder.RenameTable(
                name: "IdentityServerClientGrantTypes",
                newName: "MyIdentityServerClientGrantTypes");

            migrationBuilder.RenameTable(
                name: "IdentityServerClientCorsOrigins",
                newName: "MyIdentityServerClientCorsOrigins");

            migrationBuilder.RenameTable(
                name: "IdentityServerClientClaims",
                newName: "MyIdentityServerClientClaims");

            migrationBuilder.RenameTable(
                name: "IdentityServerApiSecrets",
                newName: "MyIdentityServerApiSecrets");

            migrationBuilder.RenameTable(
                name: "IdentityServerApiScopes",
                newName: "MyIdentityServerApiScopes");

            migrationBuilder.RenameTable(
                name: "IdentityServerApiScopeClaims",
                newName: "MyIdentityServerApiScopeClaims");

            migrationBuilder.RenameTable(
                name: "IdentityServerApiResources",
                newName: "MyIdentityServerApiResources");

            migrationBuilder.RenameTable(
                name: "IdentityServerApiClaims",
                newName: "MyIdentityServerApiClaims");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityServerPersistedGrants_SubjectId_ClientId_Type",
                table: "MyIdentityServerPersistedGrants",
                newName: "IX_MyIdentityServerPersistedGrants_SubjectId_ClientId_Type");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityServerPersistedGrants_Expiration",
                table: "MyIdentityServerPersistedGrants",
                newName: "IX_MyIdentityServerPersistedGrants_Expiration");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityServerDeviceFlowCodes_UserCode",
                table: "MyIdentityServerDeviceFlowCodes",
                newName: "IX_MyIdentityServerDeviceFlowCodes_UserCode");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityServerDeviceFlowCodes_Expiration",
                table: "MyIdentityServerDeviceFlowCodes",
                newName: "IX_MyIdentityServerDeviceFlowCodes_Expiration");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityServerDeviceFlowCodes_DeviceCode",
                table: "MyIdentityServerDeviceFlowCodes",
                newName: "IX_MyIdentityServerDeviceFlowCodes_DeviceCode");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityServerClients_ClientId",
                table: "MyIdentityServerClients",
                newName: "IX_MyIdentityServerClients_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerPersistedGrants",
                table: "MyIdentityServerPersistedGrants",
                column: "Key");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerIdentityResources",
                table: "MyIdentityServerIdentityResources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerIdentityClaims",
                table: "MyIdentityServerIdentityClaims",
                columns: new[] { "IdentityResourceId", "Type" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerDeviceFlowCodes",
                table: "MyIdentityServerDeviceFlowCodes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClientSecrets",
                table: "MyIdentityServerClientSecrets",
                columns: new[] { "ClientId", "Type", "Value" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClientScopes",
                table: "MyIdentityServerClientScopes",
                columns: new[] { "ClientId", "Scope" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClients",
                table: "MyIdentityServerClients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClientRedirectUris",
                table: "MyIdentityServerClientRedirectUris",
                columns: new[] { "ClientId", "RedirectUri" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClientProperties",
                table: "MyIdentityServerClientProperties",
                columns: new[] { "ClientId", "Key" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClientPostLogoutRedirectUris",
                table: "MyIdentityServerClientPostLogoutRedirectUris",
                columns: new[] { "ClientId", "PostLogoutRedirectUri" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClientIdPRestrictions",
                table: "MyIdentityServerClientIdPRestrictions",
                columns: new[] { "ClientId", "Provider" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClientGrantTypes",
                table: "MyIdentityServerClientGrantTypes",
                columns: new[] { "ClientId", "GrantType" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClientCorsOrigins",
                table: "MyIdentityServerClientCorsOrigins",
                columns: new[] { "ClientId", "Origin" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerClientClaims",
                table: "MyIdentityServerClientClaims",
                columns: new[] { "ClientId", "Type", "Value" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerApiSecrets",
                table: "MyIdentityServerApiSecrets",
                columns: new[] { "ApiResourceId", "Type", "Value" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerApiScopes",
                table: "MyIdentityServerApiScopes",
                columns: new[] { "ApiResourceId", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerApiScopeClaims",
                table: "MyIdentityServerApiScopeClaims",
                columns: new[] { "ApiResourceId", "Name", "Type" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerApiResources",
                table: "MyIdentityServerApiResources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyIdentityServerApiClaims",
                table: "MyIdentityServerApiClaims",
                columns: new[] { "ApiResourceId", "Type" });

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerApiClaims_MyIdentityServerApiResources_ApiResourceId",
                table: "MyIdentityServerApiClaims",
                column: "ApiResourceId",
                principalTable: "MyIdentityServerApiResources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerApiScopeClaims_MyIdentityServerApiScopes_ApiResourceId_Name",
                table: "MyIdentityServerApiScopeClaims",
                columns: new[] { "ApiResourceId", "Name" },
                principalTable: "MyIdentityServerApiScopes",
                principalColumns: new[] { "ApiResourceId", "Name" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerApiScopes_MyIdentityServerApiResources_ApiResourceId",
                table: "MyIdentityServerApiScopes",
                column: "ApiResourceId",
                principalTable: "MyIdentityServerApiResources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerApiSecrets_MyIdentityServerApiResources_ApiResourceId",
                table: "MyIdentityServerApiSecrets",
                column: "ApiResourceId",
                principalTable: "MyIdentityServerApiResources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerClientClaims_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientClaims",
                column: "ClientId",
                principalTable: "MyIdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerClientCorsOrigins_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientCorsOrigins",
                column: "ClientId",
                principalTable: "MyIdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerClientGrantTypes_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientGrantTypes",
                column: "ClientId",
                principalTable: "MyIdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerClientIdPRestrictions_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientIdPRestrictions",
                column: "ClientId",
                principalTable: "MyIdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerClientPostLogoutRedirectUris_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientPostLogoutRedirectUris",
                column: "ClientId",
                principalTable: "MyIdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerClientProperties_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientProperties",
                column: "ClientId",
                principalTable: "MyIdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerClientRedirectUris_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientRedirectUris",
                column: "ClientId",
                principalTable: "MyIdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerClientScopes_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientScopes",
                column: "ClientId",
                principalTable: "MyIdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerClientSecrets_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientSecrets",
                column: "ClientId",
                principalTable: "MyIdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyIdentityServerIdentityClaims_MyIdentityServerIdentityResources_IdentityResourceId",
                table: "MyIdentityServerIdentityClaims",
                column: "IdentityResourceId",
                principalTable: "MyIdentityServerIdentityResources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerApiClaims_MyIdentityServerApiResources_ApiResourceId",
                table: "MyIdentityServerApiClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerApiScopeClaims_MyIdentityServerApiScopes_ApiResourceId_Name",
                table: "MyIdentityServerApiScopeClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerApiScopes_MyIdentityServerApiResources_ApiResourceId",
                table: "MyIdentityServerApiScopes");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerApiSecrets_MyIdentityServerApiResources_ApiResourceId",
                table: "MyIdentityServerApiSecrets");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerClientClaims_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerClientCorsOrigins_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientCorsOrigins");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerClientGrantTypes_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientGrantTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerClientIdPRestrictions_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientIdPRestrictions");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerClientPostLogoutRedirectUris_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientPostLogoutRedirectUris");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerClientProperties_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerClientRedirectUris_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientRedirectUris");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerClientScopes_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientScopes");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerClientSecrets_MyIdentityServerClients_ClientId",
                table: "MyIdentityServerClientSecrets");

            migrationBuilder.DropForeignKey(
                name: "FK_MyIdentityServerIdentityClaims_MyIdentityServerIdentityResources_IdentityResourceId",
                table: "MyIdentityServerIdentityClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerPersistedGrants",
                table: "MyIdentityServerPersistedGrants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerIdentityResources",
                table: "MyIdentityServerIdentityResources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerIdentityClaims",
                table: "MyIdentityServerIdentityClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerDeviceFlowCodes",
                table: "MyIdentityServerDeviceFlowCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClientSecrets",
                table: "MyIdentityServerClientSecrets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClientScopes",
                table: "MyIdentityServerClientScopes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClients",
                table: "MyIdentityServerClients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClientRedirectUris",
                table: "MyIdentityServerClientRedirectUris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClientProperties",
                table: "MyIdentityServerClientProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClientPostLogoutRedirectUris",
                table: "MyIdentityServerClientPostLogoutRedirectUris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClientIdPRestrictions",
                table: "MyIdentityServerClientIdPRestrictions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClientGrantTypes",
                table: "MyIdentityServerClientGrantTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClientCorsOrigins",
                table: "MyIdentityServerClientCorsOrigins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerClientClaims",
                table: "MyIdentityServerClientClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerApiSecrets",
                table: "MyIdentityServerApiSecrets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerApiScopes",
                table: "MyIdentityServerApiScopes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerApiScopeClaims",
                table: "MyIdentityServerApiScopeClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerApiResources",
                table: "MyIdentityServerApiResources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyIdentityServerApiClaims",
                table: "MyIdentityServerApiClaims");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerPersistedGrants",
                newName: "IdentityServerPersistedGrants");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerIdentityResources",
                newName: "IdentityServerIdentityResources");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerIdentityClaims",
                newName: "IdentityServerIdentityClaims");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerDeviceFlowCodes",
                newName: "IdentityServerDeviceFlowCodes");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClientSecrets",
                newName: "IdentityServerClientSecrets");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClientScopes",
                newName: "IdentityServerClientScopes");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClients",
                newName: "IdentityServerClients");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClientRedirectUris",
                newName: "IdentityServerClientRedirectUris");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClientProperties",
                newName: "IdentityServerClientProperties");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClientPostLogoutRedirectUris",
                newName: "IdentityServerClientPostLogoutRedirectUris");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClientIdPRestrictions",
                newName: "IdentityServerClientIdPRestrictions");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClientGrantTypes",
                newName: "IdentityServerClientGrantTypes");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClientCorsOrigins",
                newName: "IdentityServerClientCorsOrigins");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerClientClaims",
                newName: "IdentityServerClientClaims");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerApiSecrets",
                newName: "IdentityServerApiSecrets");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerApiScopes",
                newName: "IdentityServerApiScopes");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerApiScopeClaims",
                newName: "IdentityServerApiScopeClaims");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerApiResources",
                newName: "IdentityServerApiResources");

            migrationBuilder.RenameTable(
                name: "MyIdentityServerApiClaims",
                newName: "IdentityServerApiClaims");

            migrationBuilder.RenameIndex(
                name: "IX_MyIdentityServerPersistedGrants_SubjectId_ClientId_Type",
                table: "IdentityServerPersistedGrants",
                newName: "IX_IdentityServerPersistedGrants_SubjectId_ClientId_Type");

            migrationBuilder.RenameIndex(
                name: "IX_MyIdentityServerPersistedGrants_Expiration",
                table: "IdentityServerPersistedGrants",
                newName: "IX_IdentityServerPersistedGrants_Expiration");

            migrationBuilder.RenameIndex(
                name: "IX_MyIdentityServerDeviceFlowCodes_UserCode",
                table: "IdentityServerDeviceFlowCodes",
                newName: "IX_IdentityServerDeviceFlowCodes_UserCode");

            migrationBuilder.RenameIndex(
                name: "IX_MyIdentityServerDeviceFlowCodes_Expiration",
                table: "IdentityServerDeviceFlowCodes",
                newName: "IX_IdentityServerDeviceFlowCodes_Expiration");

            migrationBuilder.RenameIndex(
                name: "IX_MyIdentityServerDeviceFlowCodes_DeviceCode",
                table: "IdentityServerDeviceFlowCodes",
                newName: "IX_IdentityServerDeviceFlowCodes_DeviceCode");

            migrationBuilder.RenameIndex(
                name: "IX_MyIdentityServerClients_ClientId",
                table: "IdentityServerClients",
                newName: "IX_IdentityServerClients_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerPersistedGrants",
                table: "IdentityServerPersistedGrants",
                column: "Key");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerIdentityResources",
                table: "IdentityServerIdentityResources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerIdentityClaims",
                table: "IdentityServerIdentityClaims",
                columns: new[] { "IdentityResourceId", "Type" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerDeviceFlowCodes",
                table: "IdentityServerDeviceFlowCodes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClientSecrets",
                table: "IdentityServerClientSecrets",
                columns: new[] { "ClientId", "Type", "Value" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClientScopes",
                table: "IdentityServerClientScopes",
                columns: new[] { "ClientId", "Scope" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClients",
                table: "IdentityServerClients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClientRedirectUris",
                table: "IdentityServerClientRedirectUris",
                columns: new[] { "ClientId", "RedirectUri" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClientProperties",
                table: "IdentityServerClientProperties",
                columns: new[] { "ClientId", "Key" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClientPostLogoutRedirectUris",
                table: "IdentityServerClientPostLogoutRedirectUris",
                columns: new[] { "ClientId", "PostLogoutRedirectUri" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClientIdPRestrictions",
                table: "IdentityServerClientIdPRestrictions",
                columns: new[] { "ClientId", "Provider" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClientGrantTypes",
                table: "IdentityServerClientGrantTypes",
                columns: new[] { "ClientId", "GrantType" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClientCorsOrigins",
                table: "IdentityServerClientCorsOrigins",
                columns: new[] { "ClientId", "Origin" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerClientClaims",
                table: "IdentityServerClientClaims",
                columns: new[] { "ClientId", "Type", "Value" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerApiSecrets",
                table: "IdentityServerApiSecrets",
                columns: new[] { "ApiResourceId", "Type", "Value" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerApiScopes",
                table: "IdentityServerApiScopes",
                columns: new[] { "ApiResourceId", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerApiScopeClaims",
                table: "IdentityServerApiScopeClaims",
                columns: new[] { "ApiResourceId", "Name", "Type" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerApiResources",
                table: "IdentityServerApiResources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityServerApiClaims",
                table: "IdentityServerApiClaims",
                columns: new[] { "ApiResourceId", "Type" });

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerApiClaims_IdentityServerApiResources_ApiResourceId",
                table: "IdentityServerApiClaims",
                column: "ApiResourceId",
                principalTable: "IdentityServerApiResources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerApiScopeClaims_IdentityServerApiScopes_ApiResourceId_Name",
                table: "IdentityServerApiScopeClaims",
                columns: new[] { "ApiResourceId", "Name" },
                principalTable: "IdentityServerApiScopes",
                principalColumns: new[] { "ApiResourceId", "Name" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerApiScopes_IdentityServerApiResources_ApiResourceId",
                table: "IdentityServerApiScopes",
                column: "ApiResourceId",
                principalTable: "IdentityServerApiResources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerApiSecrets_IdentityServerApiResources_ApiResourceId",
                table: "IdentityServerApiSecrets",
                column: "ApiResourceId",
                principalTable: "IdentityServerApiResources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerClientClaims_IdentityServerClients_ClientId",
                table: "IdentityServerClientClaims",
                column: "ClientId",
                principalTable: "IdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerClientCorsOrigins_IdentityServerClients_ClientId",
                table: "IdentityServerClientCorsOrigins",
                column: "ClientId",
                principalTable: "IdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerClientGrantTypes_IdentityServerClients_ClientId",
                table: "IdentityServerClientGrantTypes",
                column: "ClientId",
                principalTable: "IdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerClientIdPRestrictions_IdentityServerClients_ClientId",
                table: "IdentityServerClientIdPRestrictions",
                column: "ClientId",
                principalTable: "IdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerClientPostLogoutRedirectUris_IdentityServerClients_ClientId",
                table: "IdentityServerClientPostLogoutRedirectUris",
                column: "ClientId",
                principalTable: "IdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerClientProperties_IdentityServerClients_ClientId",
                table: "IdentityServerClientProperties",
                column: "ClientId",
                principalTable: "IdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerClientRedirectUris_IdentityServerClients_ClientId",
                table: "IdentityServerClientRedirectUris",
                column: "ClientId",
                principalTable: "IdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerClientScopes_IdentityServerClients_ClientId",
                table: "IdentityServerClientScopes",
                column: "ClientId",
                principalTable: "IdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerClientSecrets_IdentityServerClients_ClientId",
                table: "IdentityServerClientSecrets",
                column: "ClientId",
                principalTable: "IdentityServerClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityServerIdentityClaims_IdentityServerIdentityResources_IdentityResourceId",
                table: "IdentityServerIdentityClaims",
                column: "IdentityResourceId",
                principalTable: "IdentityServerIdentityResources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
