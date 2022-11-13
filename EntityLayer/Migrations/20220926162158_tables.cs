using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace EntityLayer.Migrations
{
    public partial class tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RolType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    namesurname = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "belgelers",
                columns: table => new
                {
                    Belge_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Belge_isim = table.Column<string>(type: "text", nullable: true),
                    Belge_Resim_Yol = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_belgelers", x => x.Belge_Id);
                });

            migrationBuilder.CreateTable(
                name: "dilTablosus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DilAdi = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dilTablosus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hakkimizdaGuncelBilgilers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UyeSayisi = table.Column<string>(type: "text", nullable: true),
                    IsArayanSayisi = table.Column<string>(type: "text", nullable: true),
                    IsVerenSayisi = table.Column<string>(type: "text", nullable: true),
                    IsIlaniSayisi = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hakkimizdaGuncelBilgilers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    Iletisim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Iletisim_Adresimiz = table.Column<string>(type: "text", nullable: true),
                    Iletisim_Telefon_numaramiz = table.Column<string>(type: "text", nullable: true),
                    Iletisim_Email_Adresimiz = table.Column<string>(type: "text", nullable: true),
                    Arge_Iletisim_Adres = table.Column<string>(type: "text", nullable: true),
                    Arge_Iletisim_Telefon = table.Column<string>(type: "text", nullable: true),
                    Arge_Iletisim_Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.Iletisim_id);
                });

            migrationBuilder.CreateTable(
                name: "iletisimMesajs",
                columns: table => new
                {
                    mesaj_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    iletisim_Ad_Soyad = table.Column<string>(type: "text", nullable: true),
                    Iletisim_Email = table.Column<string>(type: "text", nullable: true),
                    Iletisim_Konu = table.Column<string>(type: "text", nullable: true),
                    Iletisim_Mesaj = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iletisimMesajs", x => x.mesaj_id);
                });

            migrationBuilder.CreateTable(
                name: "Logos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LogoUrl = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LogoYol = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailBultenis",
                columns: table => new
                {
                    MailBultenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KullaniciMail = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailBultenis", x => x.MailBultenId);
                });

            migrationBuilder.CreateTable(
                name: "SosyalMedyaLinks",
                columns: table => new
                {
                    SosyalMedyaLink_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    InstagramLink = table.Column<string>(type: "text", nullable: true),
                    TwitterLink = table.Column<string>(type: "text", nullable: true),
                    FacebookLink = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalMedyaLinks", x => x.SosyalMedyaLink_id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(256)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(256)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(256)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "isArayanBilgis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ad_Soyad = table.Column<string>(type: "text", nullable: true),
                    Mail = table.Column<string>(type: "text", nullable: true),
                    Telefon = table.Column<string>(type: "text", nullable: true),
                    Adres = table.Column<string>(type: "text", nullable: true),
                    Cv_Yol = table.Column<string>(type: "text", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_isArayanBilgis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_isArayanBilgis_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sifremiUnuttums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Mail = table.Column<string>(type: "text", nullable: true),
                    RandomKod = table.Column<string>(type: "text", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sifremiUnuttums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sifremiUnuttums_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "altBilgis",
                columns: table => new
                {
                    AltBilgiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Baslik2 = table.Column<string>(type: "text", nullable: true),
                    AltBilgiUrlBasligi = table.Column<string>(type: "text", nullable: true),
                    AltBilgiUrl = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_altBilgis", x => x.AltBilgiId);
                    table.ForeignKey(
                        name: "FK_altBilgis_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "anaSayfaKisim1s",
                columns: table => new
                {
                    AnaSayfaKisim1Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AnaSayfaKucukBaslik1 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaBuyukBaslik1 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaDescription1 = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anaSayfaKisim1s", x => x.AnaSayfaKisim1Id);
                    table.ForeignKey(
                        name: "FK_anaSayfaKisim1s_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "anaSayfaKisim2s",
                columns: table => new
                {
                    AnaSayfaKisim2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AnaSayfaBaslik2 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaDescription2_1 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaDescription2_2 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaAltBaslik2 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaAltDescription2 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaAltUrl2 = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anaSayfaKisim2s", x => x.AnaSayfaKisim2Id);
                    table.ForeignKey(
                        name: "FK_anaSayfaKisim2s_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "anaSayfaKisim3s",
                columns: table => new
                {
                    AnaSayfaKisim3Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AnaSayfaBaslik3 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaDescription3_1 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaKucukBaslik3_1 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaKucukBaslik3_1_1 = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anaSayfaKisim3s", x => x.AnaSayfaKisim3Id);
                    table.ForeignKey(
                        name: "FK_anaSayfaKisim3s_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "anaSayfaKisim4s",
                columns: table => new
                {
                    AnaSayfaKisim4Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AnaSayfaBaslik4 = table.Column<string>(type: "text", nullable: true),
                    AnaSayfaResim4Yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anaSayfaKisim4s", x => x.AnaSayfaKisim4Id);
                    table.ForeignKey(
                        name: "FK_anaSayfaKisim4s_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "anasayfaMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MenuIsim = table.Column<string>(type: "text", nullable: true),
                    MenuUrl = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anasayfaMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_anasayfaMenus_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "arges",
                columns: table => new
                {
                    Arge_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Arge_Baslik = table.Column<string>(type: "text", nullable: true),
                    Arge_Icerik = table.Column<string>(type: "text", nullable: true),
                    Arge_Biz_kimiz = table.Column<string>(type: "text", nullable: true),
                    Arge_Resim_Yol = table.Column<string>(type: "text", nullable: true),
                    Arge_vizyonumuz = table.Column<string>(type: "text", nullable: true),
                    Arge_Misyonumuz = table.Column<string>(type: "text", nullable: true),
                    Arge_Tarihcemiz_Baslik = table.Column<string>(type: "text", nullable: true),
                    Arge_Tarihcemiz_icerik = table.Column<string>(type: "text", nullable: true),
                    Arge_Tarihcemiz_Resim_Yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arges", x => x.Arge_Id);
                    table.ForeignKey(
                        name: "FK_arges_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bakimYonetimis",
                columns: table => new
                {
                    BakimYonetimi_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BakimYonetimi_isim = table.Column<string>(type: "text", nullable: true),
                    BakimYonetimi_icerik = table.Column<string>(type: "text", nullable: true),
                    BakimYonetimi_Resim_Yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bakimYonetimis", x => x.BakimYonetimi_id);
                    table.ForeignKey(
                        name: "FK_bakimYonetimis_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "barkodTakipStoks",
                columns: table => new
                {
                    BarkodTakipStok_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BarkodTakipStok_isim = table.Column<string>(type: "text", nullable: true),
                    BarkodTakipStok_icerik = table.Column<string>(type: "text", nullable: true),
                    BarkodTakipStok_Resim_Yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barkodTakipStoks", x => x.BarkodTakipStok_id);
                    table.ForeignKey(
                        name: "FK_barkodTakipStoks_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "blogKategoris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BlogKategoriAdi = table.Column<string>(type: "text", nullable: true),
                    BlogKategoriAciklamasi = table.Column<string>(type: "text", nullable: true),
                    KategoriResimYol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogKategoris", x => x.ID);
                    table.ForeignKey(
                        name: "FK_blogKategoris_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "destekPortaliIletisimKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Kategori_adi = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_destekPortaliIletisimKategoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_destekPortaliIletisimKategoris_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "destekPortalis",
                columns: table => new
                {
                    DestekPortali_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DestekPortali_Baslik = table.Column<string>(type: "text", nullable: true),
                    DestekPortali_icerik = table.Column<string>(type: "text", nullable: true),
                    DestekPortali_soru = table.Column<string>(type: "text", nullable: true),
                    DestekPortali_cevap = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_destekPortalis", x => x.DestekPortali_id);
                    table.ForeignKey(
                        name: "FK_destekPortalis_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "endustriAkilliFabrikas",
                columns: table => new
                {
                    EndustriAkilliFabrika_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EndustriAkilliFabrika_isim = table.Column<string>(type: "text", nullable: true),
                    EndustriAkilliFabrika_icerik = table.Column<string>(type: "text", nullable: true),
                    EndustriAkilliFabrika_resim_yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endustriAkilliFabrikas", x => x.EndustriAkilliFabrika_id);
                    table.ForeignKey(
                        name: "FK_endustriAkilliFabrikas_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "enerjiYonetimis",
                columns: table => new
                {
                    EnerjiYonetimi_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EnerjiYonetimi_isim = table.Column<string>(type: "text", nullable: true),
                    EnerjiYonetimi_icerik = table.Column<string>(type: "text", nullable: true),
                    EnerjiYonetimi_ResimYol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enerjiYonetimis", x => x.EnerjiYonetimi_Id);
                    table.ForeignKey(
                        name: "FK_enerjiYonetimis_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "entegreSistems",
                columns: table => new
                {
                    EntegreSistem_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EntegreSistem_isim = table.Column<string>(type: "text", nullable: true),
                    EntegreSistem_icerik = table.Column<string>(type: "text", nullable: true),
                    EntegreSistem_resim_yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entegreSistems", x => x.EntegreSistem_id);
                    table.ForeignKey(
                        name: "FK_entegreSistems_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "habers",
                columns: table => new
                {
                    Haber_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Haber_isim = table.Column<string>(type: "text", nullable: true),
                    Haber_icerik = table.Column<string>(type: "text", nullable: true),
                    Haber_resim_yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_habers", x => x.Haber_id);
                    table.ForeignKey(
                        name: "FK_habers_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hakkimizdas",
                columns: table => new
                {
                    Hkkimizda_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Hakkimizda_Baslik = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_icerik = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_alt_baslik_bir = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_Misyonumuz_icerik = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_altbaslik_orta = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_Vizyon_icerik = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_altbaslik_sag = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_Neden_Biz_icerik = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_Bizkimiz_baslik = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_Biz_Kimiz_icerik = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_Ekibimiz_Baslik = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_Ekibimiz_icerik = table.Column<string>(type: "text", nullable: true),
                    Biz_kimiz_resim_yol = table.Column<string>(type: "text", nullable: true),
                    Hakkimizda_Ekibimiz_Resim_Yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hakkimizdas", x => x.Hkkimizda_id);
                    table.ForeignKey(
                        name: "FK_hakkimizdas_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "isilanlaris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(type: "text", nullable: true),
                    Aciklama = table.Column<string>(type: "text", nullable: true),
                    IsYeriAdres = table.Column<string>(type: "text", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_isilanlaris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_isilanlaris_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_isilanlaris_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kaliteYonetimis",
                columns: table => new
                {
                    KaliteYonetimi_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KaliteYonetimi_isim = table.Column<string>(type: "text", nullable: true),
                    KaliteYonetimi_icerik = table.Column<string>(type: "text", nullable: true),
                    KaliteYonetimi_Resim_Yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kaliteYonetimis", x => x.KaliteYonetimi_Id);
                    table.ForeignKey(
                        name: "FK_kaliteYonetimis_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kariyers",
                columns: table => new
                {
                    Kariyer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Kariyer_Konu_baslik = table.Column<string>(type: "text", nullable: true),
                    kariyer_konu_icerik = table.Column<string>(type: "text", nullable: true),
                    Kariyer_resim_yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kariyers", x => x.Kariyer_id);
                    table.ForeignKey(
                        name: "FK_kariyers_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KUstMenuId = table.Column<int>(type: "int", nullable: true),
                    MenuName = table.Column<string>(type: "text", nullable: true),
                    MenuUrl = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KMenus_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KMenus_KMenus_KUstMenuId",
                        column: x => x.KUstMenuId,
                        principalTable: "KMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Musterilerimizs",
                columns: table => new
                {
                    MusterilerimizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MusterilerimizBaslik = table.Column<string>(type: "text", nullable: true),
                    Musterilerimizİcerik = table.Column<string>(type: "text", nullable: true),
                    MusterilerimizYol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musterilerimizs", x => x.MusterilerimizId);
                    table.ForeignKey(
                        name: "FK_Musterilerimizs_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "referanslars",
                columns: table => new
                {
                    Referanslar_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Referanslar_isim = table.Column<string>(type: "text", nullable: true),
                    Referanslar_icerik = table.Column<string>(type: "text", nullable: true),
                    Referanslar_resim_yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referanslars", x => x.Referanslar_id);
                    table.ForeignKey(
                        name: "FK_referanslars_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "surumKilavuzus",
                columns: table => new
                {
                    SurumKilavuz_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SurumKilavuz_Baslik = table.Column<string>(type: "text", nullable: true),
                    SurumKilavuz_Aciklama = table.Column<string>(type: "text", nullable: true),
                    SurumKilavuz_BelgeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_surumKilavuzus", x => x.SurumKilavuz_Id);
                    table.ForeignKey(
                        name: "FK_surumKilavuzus_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "uretimTakipYonetimis",
                columns: table => new
                {
                    UretimTakip_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UretimTakip_name = table.Column<string>(type: "text", nullable: true),
                    UretimTakip_icerik = table.Column<string>(type: "text", nullable: true),
                    UretimTakip_Resim_Yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uretimTakipYonetimis", x => x.UretimTakip_id);
                    table.ForeignKey(
                        name: "FK_uretimTakipYonetimis_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoKategoris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KategoriAdi = table.Column<string>(type: "text", nullable: true),
                    KategoriAciklamasi = table.Column<string>(type: "text", nullable: true),
                    KategoriResimYol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoKategoris", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VideoKategoris_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "webMobils",
                columns: table => new
                {
                    WebMobil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    WebMobil_isim = table.Column<string>(type: "text", nullable: true),
                    WebMobil_icerik = table.Column<string>(type: "text", nullable: true),
                    WebMobil_resim_yol = table.Column<string>(type: "text", nullable: true),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_webMobils", x => x.WebMobil_id);
                    table.ForeignKey(
                        name: "FK_webMobils_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sifremiUnuttumMailTuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Mail = table.Column<string>(type: "text", nullable: true),
                    SifremiUnuttumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sifremiUnuttumMailTuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sifremiUnuttumMailTuts_sifremiUnuttums_SifremiUnuttumId",
                        column: x => x.SifremiUnuttumId,
                        principalTable: "sifremiUnuttums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "anasayfaAltMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AltMenuIsim = table.Column<string>(type: "text", nullable: true),
                    AltMenuUrl = table.Column<string>(type: "text", nullable: true),
                    AnasayfaMenuId = table.Column<int>(type: "int", nullable: false),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anasayfaAltMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_anasayfaAltMenus_anasayfaMenus_AnasayfaMenuId",
                        column: x => x.AnasayfaMenuId,
                        principalTable: "anasayfaMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_anasayfaAltMenus_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    Blog_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Blog_baslik = table.Column<string>(type: "text", nullable: true),
                    Blog_icerik = table.Column<string>(type: "text", nullable: true),
                    Blog_resim_yol = table.Column<string>(type: "text", nullable: true),
                    Blog_status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BlogKategoriID = table.Column<int>(type: "int", nullable: false),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.Blog_id);
                    table.ForeignKey(
                        name: "FK_blogs_blogKategoris_BlogKategoriID",
                        column: x => x.BlogKategoriID,
                        principalTable: "blogKategoris",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_blogs_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "destekIletisims",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    isim = table.Column<string>(type: "text", nullable: true),
                    mail = table.Column<string>(type: "text", nullable: true),
                    konu = table.Column<string>(type: "text", nullable: true),
                    mesaj = table.Column<string>(type: "text", nullable: true),
                    DestekPortaliIletisimKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_destekIletisims", x => x.id);
                    table.ForeignKey(
                        name: "FK_destekIletisims_destekPortaliIletisimKategoris_DestekPortali~",
                        column: x => x.DestekPortaliIletisimKategoriId,
                        principalTable: "destekPortaliIletisimKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsBasvuruTbls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    isilanlariId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsBasvuruTbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsBasvuruTbls_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsBasvuruTbls_isilanlaris_isilanlariId",
                        column: x => x.isilanlariId,
                        principalTable: "isilanlaris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kullaniciKlavuzuIceriks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(type: "text", nullable: true),
                    Icerik = table.Column<string>(type: "text", nullable: true),
                    ResimYol = table.Column<string>(type: "text", nullable: true),
                    KMenuId = table.Column<int>(type: "int", nullable: false),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullaniciKlavuzuIceriks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kullaniciKlavuzuIceriks_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kullaniciKlavuzuIceriks_KMenus_KMenuId",
                        column: x => x.KMenuId,
                        principalTable: "KMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "surumKilavuzIceriks",
                columns: table => new
                {
                    SurumKilavuzIcerik_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SurumKilavuzIcerik_No = table.Column<string>(type: "text", nullable: true),
                    SurumKilavuzIcerik_Tanim = table.Column<string>(type: "text", nullable: true),
                    SurumKilavuzIcerik_Aciklama = table.Column<string>(type: "text", nullable: true),
                    SurumKilavuzuSurumKilavuz_Id = table.Column<int>(type: "int", nullable: false),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_surumKilavuzIceriks", x => x.SurumKilavuzIcerik_ID);
                    table.ForeignKey(
                        name: "FK_surumKilavuzIceriks_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_surumKilavuzIceriks_surumKilavuzus_SurumKilavuzuSurumKilavuz~",
                        column: x => x.SurumKilavuzuSurumKilavuz_Id,
                        principalTable: "surumKilavuzus",
                        principalColumn: "SurumKilavuz_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "egitimVideolaris",
                columns: table => new
                {
                    EgitimVideo_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EgitimVideo_Baslik = table.Column<string>(type: "text", nullable: true),
                    EgitimVideo_Yol = table.Column<string>(type: "text", nullable: true),
                    VideoKategoriID = table.Column<int>(type: "int", nullable: false),
                    DilTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_egitimVideolaris", x => x.EgitimVideo_Id);
                    table.ForeignKey(
                        name: "FK_egitimVideolaris_dilTablosus_DilTablosuId",
                        column: x => x.DilTablosuId,
                        principalTable: "dilTablosus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_egitimVideolaris_VideoKategoris_VideoKategoriID",
                        column: x => x.VideoKategoriID,
                        principalTable: "VideoKategoris",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_altBilgis_DilTablosuId",
                table: "altBilgis",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_anasayfaAltMenus_AnasayfaMenuId",
                table: "anasayfaAltMenus",
                column: "AnasayfaMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_anasayfaAltMenus_DilTablosuId",
                table: "anasayfaAltMenus",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_anaSayfaKisim1s_DilTablosuId",
                table: "anaSayfaKisim1s",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_anaSayfaKisim2s_DilTablosuId",
                table: "anaSayfaKisim2s",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_anaSayfaKisim3s_DilTablosuId",
                table: "anaSayfaKisim3s",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_anaSayfaKisim4s_DilTablosuId",
                table: "anaSayfaKisim4s",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_anasayfaMenus_DilTablosuId",
                table: "anasayfaMenus",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_arges_DilTablosuId",
                table: "arges",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_bakimYonetimis_DilTablosuId",
                table: "bakimYonetimis",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_barkodTakipStoks_DilTablosuId",
                table: "barkodTakipStoks",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_blogKategoris_DilTablosuId",
                table: "blogKategoris",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_BlogKategoriID",
                table: "blogs",
                column: "BlogKategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_DilTablosuId",
                table: "blogs",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_destekIletisims_DestekPortaliIletisimKategoriId",
                table: "destekIletisims",
                column: "DestekPortaliIletisimKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_destekPortaliIletisimKategoris_DilTablosuId",
                table: "destekPortaliIletisimKategoris",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_destekPortalis_DilTablosuId",
                table: "destekPortalis",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_egitimVideolaris_DilTablosuId",
                table: "egitimVideolaris",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_egitimVideolaris_VideoKategoriID",
                table: "egitimVideolaris",
                column: "VideoKategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_endustriAkilliFabrikas_DilTablosuId",
                table: "endustriAkilliFabrikas",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_enerjiYonetimis_DilTablosuId",
                table: "enerjiYonetimis",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_entegreSistems_DilTablosuId",
                table: "entegreSistems",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_habers_DilTablosuId",
                table: "habers",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_hakkimizdas_DilTablosuId",
                table: "hakkimizdas",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_IsBasvuruTbls_AppUserId",
                table: "IsBasvuruTbls",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IsBasvuruTbls_isilanlariId",
                table: "IsBasvuruTbls",
                column: "isilanlariId");

            migrationBuilder.CreateIndex(
                name: "IX_isArayanBilgis_AppUserId",
                table: "isArayanBilgis",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_isilanlaris_AppUserId",
                table: "isilanlaris",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_isilanlaris_DilTablosuId",
                table: "isilanlaris",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_kaliteYonetimis_DilTablosuId",
                table: "kaliteYonetimis",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_kariyers_DilTablosuId",
                table: "kariyers",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_KMenus_DilTablosuId",
                table: "KMenus",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_KMenus_KUstMenuId",
                table: "KMenus",
                column: "KUstMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_kullaniciKlavuzuIceriks_DilTablosuId",
                table: "kullaniciKlavuzuIceriks",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_kullaniciKlavuzuIceriks_KMenuId",
                table: "kullaniciKlavuzuIceriks",
                column: "KMenuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musterilerimizs_DilTablosuId",
                table: "Musterilerimizs",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_referanslars_DilTablosuId",
                table: "referanslars",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_sifremiUnuttumMailTuts_SifremiUnuttumId",
                table: "sifremiUnuttumMailTuts",
                column: "SifremiUnuttumId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sifremiUnuttums_AppUserId",
                table: "sifremiUnuttums",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_surumKilavuzIceriks_DilTablosuId",
                table: "surumKilavuzIceriks",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_surumKilavuzIceriks_SurumKilavuzuSurumKilavuz_Id",
                table: "surumKilavuzIceriks",
                column: "SurumKilavuzuSurumKilavuz_Id");

            migrationBuilder.CreateIndex(
                name: "IX_surumKilavuzus_DilTablosuId",
                table: "surumKilavuzus",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_uretimTakipYonetimis_DilTablosuId",
                table: "uretimTakipYonetimis",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoKategoris_DilTablosuId",
                table: "VideoKategoris",
                column: "DilTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_webMobils_DilTablosuId",
                table: "webMobils",
                column: "DilTablosuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "altBilgis");

            migrationBuilder.DropTable(
                name: "anasayfaAltMenus");

            migrationBuilder.DropTable(
                name: "anaSayfaKisim1s");

            migrationBuilder.DropTable(
                name: "anaSayfaKisim2s");

            migrationBuilder.DropTable(
                name: "anaSayfaKisim3s");

            migrationBuilder.DropTable(
                name: "anaSayfaKisim4s");

            migrationBuilder.DropTable(
                name: "arges");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "bakimYonetimis");

            migrationBuilder.DropTable(
                name: "barkodTakipStoks");

            migrationBuilder.DropTable(
                name: "belgelers");

            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "destekIletisims");

            migrationBuilder.DropTable(
                name: "destekPortalis");

            migrationBuilder.DropTable(
                name: "egitimVideolaris");

            migrationBuilder.DropTable(
                name: "endustriAkilliFabrikas");

            migrationBuilder.DropTable(
                name: "enerjiYonetimis");

            migrationBuilder.DropTable(
                name: "entegreSistems");

            migrationBuilder.DropTable(
                name: "habers");

            migrationBuilder.DropTable(
                name: "hakkimizdaGuncelBilgilers");

            migrationBuilder.DropTable(
                name: "hakkimizdas");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "IsBasvuruTbls");

            migrationBuilder.DropTable(
                name: "iletisimMesajs");

            migrationBuilder.DropTable(
                name: "isArayanBilgis");

            migrationBuilder.DropTable(
                name: "kaliteYonetimis");

            migrationBuilder.DropTable(
                name: "kariyers");

            migrationBuilder.DropTable(
                name: "kullaniciKlavuzuIceriks");

            migrationBuilder.DropTable(
                name: "Logos");

            migrationBuilder.DropTable(
                name: "MailBultenis");

            migrationBuilder.DropTable(
                name: "Musterilerimizs");

            migrationBuilder.DropTable(
                name: "referanslars");

            migrationBuilder.DropTable(
                name: "sifremiUnuttumMailTuts");

            migrationBuilder.DropTable(
                name: "SosyalMedyaLinks");

            migrationBuilder.DropTable(
                name: "surumKilavuzIceriks");

            migrationBuilder.DropTable(
                name: "uretimTakipYonetimis");

            migrationBuilder.DropTable(
                name: "webMobils");

            migrationBuilder.DropTable(
                name: "anasayfaMenus");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "blogKategoris");

            migrationBuilder.DropTable(
                name: "destekPortaliIletisimKategoris");

            migrationBuilder.DropTable(
                name: "VideoKategoris");

            migrationBuilder.DropTable(
                name: "isilanlaris");

            migrationBuilder.DropTable(
                name: "KMenus");

            migrationBuilder.DropTable(
                name: "sifremiUnuttums");

            migrationBuilder.DropTable(
                name: "surumKilavuzus");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "dilTablosus");
        }
    }
}
