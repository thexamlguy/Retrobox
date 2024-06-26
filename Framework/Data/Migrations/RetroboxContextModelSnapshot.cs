﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(RetroboxContext))]
    partial class RetroboxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Data.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PlatformId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlatformId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Data.Platform", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FamilyId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4098c8bf-895e-4d6a-a218-53691a798689"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "3DO"
                        },
                        new
                        {
                            Id = new Guid("6ee2a004-c0ef-4f26-b2a2-d07fa0e9e4f5"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "Arcade"
                        },
                        new
                        {
                            Id = new Guid("8cc47e09-6ac1-4108-99ce-038463861d48"),
                            FamilyId = new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"),
                            Name = "Atari 2600"
                        },
                        new
                        {
                            Id = new Guid("874461f9-9d6d-42f7-b4f6-d4bd24db2a52"),
                            FamilyId = new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"),
                            Name = "Atari 5200"
                        },
                        new
                        {
                            Id = new Guid("3472484e-80ae-4ba9-a3aa-9b04e8a9a140"),
                            FamilyId = new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"),
                            Name = "Atari 7800"
                        },
                        new
                        {
                            Id = new Guid("e570d238-fbda-4b30-b7f6-1e119611744b"),
                            FamilyId = new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"),
                            Name = "Atari Jaguar"
                        },
                        new
                        {
                            Id = new Guid("1e3b9c54-893c-4aa4-9f7c-b023d99327fc"),
                            FamilyId = new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"),
                            Name = "Atari Lynx"
                        },
                        new
                        {
                            Id = new Guid("6aa76185-ecff-4bd4-bccc-64a6db187346"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "ColecoVision"
                        },
                        new
                        {
                            Id = new Guid("634f1ff7-676e-4b74-868b-a3735c5e640a"),
                            FamilyId = new Guid("0decc41d-4572-4c29-acf1-71f015a60271"),
                            Name = "Commodore 64"
                        },
                        new
                        {
                            Id = new Guid("aa423d51-a65e-41a7-aba4-37d21f3c24e4"),
                            FamilyId = new Guid("0decc41d-4572-4c29-acf1-71f015a60271"),
                            Name = "Commodore Amiga"
                        },
                        new
                        {
                            Id = new Guid("b5aecd72-2341-419c-8e37-deb310e0f0cd"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Famicom"
                        },
                        new
                        {
                            Id = new Guid("a728d061-2b61-43db-94ca-4cdedc7d12ea"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Game Boy"
                        },
                        new
                        {
                            Id = new Guid("dac9980e-8f60-40e6-9c07-41a2a54a7af2"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Game Boy Advance"
                        },
                        new
                        {
                            Id = new Guid("55ae0b01-9628-4b3f-94dc-cdadf83d8fe1"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "Google Stadia"
                        },
                        new
                        {
                            Id = new Guid("aefcdd4c-78b1-4c8b-b7e7-6b1d2c0e3326"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "Intellivision"
                        },
                        new
                        {
                            Id = new Guid("f5bd6bca-9153-4072-a393-abdbc48e38af"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "Magnavox Odyssey"
                        },
                        new
                        {
                            Id = new Guid("4f350651-1ce6-49a7-94c2-aa5a95d4bf58"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "Mobile Devices"
                        },
                        new
                        {
                            Id = new Guid("1daa870e-6b9e-468b-b25b-80dc78c9b2d6"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "N-Gage"
                        },
                        new
                        {
                            Id = new Guid("78e25c31-dc73-4d21-b7cc-b278af708a36"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "Neo Geo"
                        },
                        new
                        {
                            Id = new Guid("f52f7ee5-ac8e-4492-9c4f-c1e345e3348b"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Nintendo 3DS"
                        },
                        new
                        {
                            Id = new Guid("19682024-3656-4ed6-bf35-981961c46519"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Nintendo 64"
                        },
                        new
                        {
                            Id = new Guid("8352ec10-ff36-4da3-815d-720bda4dd55c"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Nintendo DS"
                        },
                        new
                        {
                            Id = new Guid("476a47da-0afa-4d3c-9f0f-e62daaf5f5b4"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Nintendo Entertainment System"
                        },
                        new
                        {
                            Id = new Guid("6e8c742d-a7b5-43e6-9e9c-4a0b95f61205"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Nintendo GameCube"
                        },
                        new
                        {
                            Id = new Guid("5770aba7-86db-4c0d-9032-7ef25d25364a"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Nintendo Switch"
                        },
                        new
                        {
                            Id = new Guid("5e97b8e8-909b-4acf-8cb1-54ccd949e27a"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "Oculus Quest"
                        },
                        new
                        {
                            Id = new Guid("b1812fab-aa29-4550-9bc3-4e21bdcf347f"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "Oculus Rift"
                        },
                        new
                        {
                            Id = new Guid("8782ab71-97d5-4e15-8be3-9e6a99444682"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "PC"
                        },
                        new
                        {
                            Id = new Guid("926c779a-7d7f-4ce9-9b82-9b7ba13d4480"),
                            FamilyId = new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"),
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = new Guid("87c71d93-fa6f-437f-87e6-e803f0ac1998"),
                            FamilyId = new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"),
                            Name = "PlayStation 2"
                        },
                        new
                        {
                            Id = new Guid("74e1686d-998f-4cc9-830a-c3a6d8883a09"),
                            FamilyId = new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"),
                            Name = "PlayStation 3"
                        },
                        new
                        {
                            Id = new Guid("b31fc5ca-053d-4932-97f0-7305d4040c32"),
                            FamilyId = new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"),
                            Name = "PlayStation 4"
                        },
                        new
                        {
                            Id = new Guid("275ff961-7db8-41af-a1ce-82d834b92f70"),
                            FamilyId = new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"),
                            Name = "PlayStation 5"
                        },
                        new
                        {
                            Id = new Guid("5ab09c01-3229-44c8-b754-9b93c096d665"),
                            FamilyId = new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"),
                            Name = "PlayStation Portable (PSP)"
                        },
                        new
                        {
                            Id = new Guid("78d5a146-0b0b-49c8-981d-efd984760eb0"),
                            FamilyId = new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"),
                            Name = "PlayStation Vita"
                        },
                        new
                        {
                            Id = new Guid("73e444b4-00aa-483c-87a5-c375d5e501b2"),
                            FamilyId = new Guid("50260204-167a-47ea-a9e7-97c55711f02d"),
                            Name = "Sega 32x"
                        },
                        new
                        {
                            Id = new Guid("ccf7101e-1361-469d-a4b4-c1bf8120d9cb"),
                            FamilyId = new Guid("50260204-167a-47ea-a9e7-97c55711f02d"),
                            Name = "Sega CD"
                        },
                        new
                        {
                            Id = new Guid("b851f6fd-1197-4dd1-8b14-78fd6ea266d1"),
                            FamilyId = new Guid("50260204-167a-47ea-a9e7-97c55711f02d"),
                            Name = "Sega Dreamcast"
                        },
                        new
                        {
                            Id = new Guid("370f84d8-2c3d-487f-998b-83e94fb1b43b"),
                            FamilyId = new Guid("50260204-167a-47ea-a9e7-97c55711f02d"),
                            Name = "Sega Game Gear"
                        },
                        new
                        {
                            Id = new Guid("b5055ff3-2498-4cb2-a233-58cc60143d92"),
                            FamilyId = new Guid("50260204-167a-47ea-a9e7-97c55711f02d"),
                            Name = "Sega Genesis"
                        },
                        new
                        {
                            Id = new Guid("11794b62-33d4-4ac9-a690-3a9b42aec909"),
                            FamilyId = new Guid("50260204-167a-47ea-a9e7-97c55711f02d"),
                            Name = "Sega Master System"
                        },
                        new
                        {
                            Id = new Guid("80fa596a-683a-479d-97bc-c6a1b8a492dc"),
                            FamilyId = new Guid("50260204-167a-47ea-a9e7-97c55711f02d"),
                            Name = "Sega Saturn"
                        },
                        new
                        {
                            Id = new Guid("2cb76fd5-5e97-4446-9846-15e20e39950a"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Super Famicom"
                        },
                        new
                        {
                            Id = new Guid("c96f13f3-662c-4f63-9704-e90c0cc8d34b"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Super Nintendo Entertainment System"
                        },
                        new
                        {
                            Id = new Guid("6760eeae-ede2-43a3-b64b-9a8d450f81f2"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "TurboGrafx-16"
                        },
                        new
                        {
                            Id = new Guid("03a63b2b-6848-48f3-b513-d4ad76f32554"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "VIC-20"
                        },
                        new
                        {
                            Id = new Guid("c7b92277-3b71-4a0e-94ce-4afa4eb0aab3"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Wii"
                        },
                        new
                        {
                            Id = new Guid("17321ae1-e7f0-415e-91a0-3283d92e2d18"),
                            FamilyId = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Wii U"
                        },
                        new
                        {
                            Id = new Guid("0374eb77-6199-4b52-9b2f-03096d782253"),
                            FamilyId = new Guid("58659264-61a8-476a-acb5-948dc65f638a"),
                            Name = "Xbox"
                        },
                        new
                        {
                            Id = new Guid("c89ab82e-654d-43cf-b76b-bca785cb3b0f"),
                            FamilyId = new Guid("58659264-61a8-476a-acb5-948dc65f638a"),
                            Name = "Xbox 360"
                        },
                        new
                        {
                            Id = new Guid("cda4604d-1dc8-4860-80e7-e198d9d2457f"),
                            FamilyId = new Guid("58659264-61a8-476a-acb5-948dc65f638a"),
                            Name = "Xbox One"
                        },
                        new
                        {
                            Id = new Guid("b0623fa7-337c-4a5f-a024-015ae4df6e1c"),
                            FamilyId = new Guid("58659264-61a8-476a-acb5-948dc65f638a"),
                            Name = "Xbox Series X/S"
                        },
                        new
                        {
                            Id = new Guid("699f47f5-9e7f-437e-b10d-757c4af584eb"),
                            FamilyId = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "ZX Spectrum"
                        });
                });

            modelBuilder.Entity("Data.PlatformFamily", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PlatformFamilies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"),
                            Name = "Atari"
                        },
                        new
                        {
                            Id = new Guid("0decc41d-4572-4c29-acf1-71f015a60271"),
                            Name = "Commodore"
                        },
                        new
                        {
                            Id = new Guid("179348af-c199-4810-abbb-98a8d6a40187"),
                            Name = "Nintendo"
                        },
                        new
                        {
                            Id = new Guid("188d8bbf-9409-4b60-ba46-962a41272220"),
                            Name = "Other"
                        },
                        new
                        {
                            Id = new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"),
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = new Guid("50260204-167a-47ea-a9e7-97c55711f02d"),
                            Name = "Sega"
                        },
                        new
                        {
                            Id = new Guid("58659264-61a8-476a-acb5-948dc65f638a"),
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("Data.Game", b =>
                {
                    b.HasOne("Data.Platform", null)
                        .WithMany("Games")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Platform", b =>
                {
                    b.HasOne("Data.PlatformFamily", "Family")
                        .WithMany("Platforms")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Family");
                });

            modelBuilder.Entity("Data.Platform", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("Data.PlatformFamily", b =>
                {
                    b.Navigation("Platforms");
                });
#pragma warning restore 612, 618
        }
    }
}
