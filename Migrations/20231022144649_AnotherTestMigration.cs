using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Kanoo.Migrations
{
    /// <inheritdoc />
    public partial class AnotherTestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Root",
                columns: table => new
                {
                    RootId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Root", x => x.RootId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Data",
                columns: table => new
                {
                    DataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data", x => x.DataId);
                    table.ForeignKey(
                        name: "FK_Data_Root_DataId",
                        column: x => x.DataId,
                        principalTable: "Root",
                        principalColumn: "RootId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TypeaheadAutocomplete",
                columns: table => new
                {
                    TypeaheadAutocompleteId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    resultsId = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeaheadAutocomplete", x => x.TypeaheadAutocompleteId);
                    table.ForeignKey(
                        name: "FK_TypeaheadAutocomplete_Data_TypeaheadAutocompleteId",
                        column: x => x.TypeaheadAutocompleteId,
                        principalTable: "Data",
                        principalColumn: "DataId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TravelAdvisor",
                columns: table => new
                {
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TypeaheadAutocompleteId = table.Column<int>(type: "int", nullable: true),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    documentId = table.Column<string>(type: "longtext", nullable: true),
                    suggestionType = table.Column<string>(type: "longtext", nullable: true),
                    buCategory = table.Column<string>(type: "longtext", nullable: true),
                    text = table.Column<string>(type: "longtext", nullable: true),
                    scopeType = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelAdvisor", x => x.TravelAdvisorId);
                    table.ForeignKey(
                        name: "FK_TravelAdvisor_TypeaheadAutocomplete_TypeaheadAutocompleteId",
                        column: x => x.TypeaheadAutocompleteId,
                        principalTable: "TypeaheadAutocomplete",
                        principalColumn: "TypeaheadAutocompleteId");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.id);
                    table.ForeignKey(
                        name: "FK_Details_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetailsV2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    locationId = table.Column<int>(type: "int", nullable: true),
                    isGeo = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    placeType = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsV2", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetailsV2_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.id);
                    table.ForeignKey(
                        name: "FK_Image_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ParentGeoDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentGeoDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_ParentGeoDetails_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SocialStatistics",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    isSaved = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Detailsid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialStatistics", x => x.id);
                    table.ForeignKey(
                        name: "FK_SocialStatistics_Details_Detailsid",
                        column: x => x.Detailsid,
                        principalTable: "Details",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_SocialStatistics_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    DetailsV2id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contact_DetailsV2_DetailsV2id",
                        column: x => x.DetailsV2id,
                        principalTable: "DetailsV2",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Contact_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Geocode",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    latitude = table.Column<double>(type: "double", nullable: true),
                    longitude = table.Column<double>(type: "double", nullable: true),
                    DetailsV2id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geocode", x => x.id);
                    table.ForeignKey(
                        name: "FK_Geocode_DetailsV2_DetailsV2id",
                        column: x => x.DetailsV2id,
                        principalTable: "DetailsV2",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Geocode_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    fragment = table.Column<string>(type: "longtext", nullable: true),
                    page = table.Column<string>(type: "longtext", nullable: true),
                    url = table.Column<string>(type: "longtext", nullable: true),
                    nonCanonicalUrl = table.Column<string>(type: "longtext", nullable: true),
                    DetailsV2id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.id);
                    table.ForeignKey(
                        name: "FK_Route_DetailsV2_DetailsV2id",
                        column: x => x.DetailsV2id,
                        principalTable: "DetailsV2",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Route_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    Imageid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Photo_Image_Imageid",
                        column: x => x.Imageid,
                        principalTable: "Image",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Photo_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Names",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    longOnlyHierarchyTypeaheadV2 = table.Column<string>(type: "longtext", nullable: true),
                    name = table.Column<string>(type: "longtext", nullable: true),
                    DetailsV2id = table.Column<int>(type: "int", nullable: true),
                    ParentGeoDetailsid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Names", x => x.id);
                    table.ForeignKey(
                        name: "FK_Names_DetailsV2_DetailsV2id",
                        column: x => x.DetailsV2id,
                        principalTable: "DetailsV2",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Names_ParentGeoDetails_ParentGeoDetailsid",
                        column: x => x.ParentGeoDetailsid,
                        principalTable: "ParentGeoDetails",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Names_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StreetAddress",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    street1 = table.Column<string>(type: "longtext", nullable: true),
                    Contactid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetAddress", x => x.id);
                    table.ForeignKey(
                        name: "FK_StreetAddress_Contact_Contactid",
                        column: x => x.Contactid,
                        principalTable: "Contact",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_StreetAddress_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TypedParams",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    geoId = table.Column<int>(type: "int", nullable: true),
                    Routeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypedParams", x => x.id);
                    table.ForeignKey(
                        name: "FK_TypedParams_Route_Routeid",
                        column: x => x.Routeid,
                        principalTable: "Route",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TypedParams_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhotoSize",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    height = table.Column<int>(type: "int", nullable: true),
                    width = table.Column<int>(type: "int", nullable: true),
                    url = table.Column<string>(type: "longtext", nullable: true),
                    Photoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoSize", x => x.id);
                    table.ForeignKey(
                        name: "FK_PhotoSize_Photo_Photoid",
                        column: x => x.Photoid,
                        principalTable: "Photo",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_PhotoSize_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhotoSizeDynamic",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TravelAdvisorId = table.Column<int>(type: "int", nullable: false),
                    __typename = table.Column<string>(type: "longtext", nullable: true),
                    maxHeight = table.Column<int>(type: "int", nullable: true),
                    maxWidth = table.Column<int>(type: "int", nullable: true),
                    urlTemplate = table.Column<string>(type: "longtext", nullable: true),
                    Photoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoSizeDynamic", x => x.id);
                    table.ForeignKey(
                        name: "FK_PhotoSizeDynamic_Photo_Photoid",
                        column: x => x.Photoid,
                        principalTable: "Photo",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_PhotoSizeDynamic_TravelAdvisor_TravelAdvisorId",
                        column: x => x.TravelAdvisorId,
                        principalTable: "TravelAdvisor",
                        principalColumn: "TravelAdvisorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_DetailsV2id",
                table: "Contact",
                column: "DetailsV2id");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_TravelAdvisorId",
                table: "Contact",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_TravelAdvisorId",
                table: "Details",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailsV2_TravelAdvisorId",
                table: "DetailsV2",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Geocode_DetailsV2id",
                table: "Geocode",
                column: "DetailsV2id");

            migrationBuilder.CreateIndex(
                name: "IX_Geocode_TravelAdvisorId",
                table: "Geocode",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_TravelAdvisorId",
                table: "Image",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_DetailsV2id",
                table: "Names",
                column: "DetailsV2id");

            migrationBuilder.CreateIndex(
                name: "IX_Names_ParentGeoDetailsid",
                table: "Names",
                column: "ParentGeoDetailsid");

            migrationBuilder.CreateIndex(
                name: "IX_Names_TravelAdvisorId",
                table: "Names",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentGeoDetails_TravelAdvisorId",
                table: "ParentGeoDetails",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_Imageid",
                table: "Photo",
                column: "Imageid");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_TravelAdvisorId",
                table: "Photo",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoSize_Photoid",
                table: "PhotoSize",
                column: "Photoid");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoSize_TravelAdvisorId",
                table: "PhotoSize",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoSizeDynamic_Photoid",
                table: "PhotoSizeDynamic",
                column: "Photoid");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoSizeDynamic_TravelAdvisorId",
                table: "PhotoSizeDynamic",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_DetailsV2id",
                table: "Route",
                column: "DetailsV2id");

            migrationBuilder.CreateIndex(
                name: "IX_Route_TravelAdvisorId",
                table: "Route",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialStatistics_Detailsid",
                table: "SocialStatistics",
                column: "Detailsid");

            migrationBuilder.CreateIndex(
                name: "IX_SocialStatistics_TravelAdvisorId",
                table: "SocialStatistics",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_StreetAddress_Contactid",
                table: "StreetAddress",
                column: "Contactid");

            migrationBuilder.CreateIndex(
                name: "IX_StreetAddress_TravelAdvisorId",
                table: "StreetAddress",
                column: "TravelAdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelAdvisor_TypeaheadAutocompleteId",
                table: "TravelAdvisor",
                column: "TypeaheadAutocompleteId");

            migrationBuilder.CreateIndex(
                name: "IX_TypedParams_Routeid",
                table: "TypedParams",
                column: "Routeid");

            migrationBuilder.CreateIndex(
                name: "IX_TypedParams_TravelAdvisorId",
                table: "TypedParams",
                column: "TravelAdvisorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Geocode");

            migrationBuilder.DropTable(
                name: "Names");

            migrationBuilder.DropTable(
                name: "PhotoSize");

            migrationBuilder.DropTable(
                name: "PhotoSizeDynamic");

            migrationBuilder.DropTable(
                name: "SocialStatistics");

            migrationBuilder.DropTable(
                name: "StreetAddress");

            migrationBuilder.DropTable(
                name: "TypedParams");

            migrationBuilder.DropTable(
                name: "ParentGeoDetails");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "DetailsV2");

            migrationBuilder.DropTable(
                name: "TravelAdvisor");

            migrationBuilder.DropTable(
                name: "TypeaheadAutocomplete");

            migrationBuilder.DropTable(
                name: "Data");

            migrationBuilder.DropTable(
                name: "Root");
        }
    }
}
