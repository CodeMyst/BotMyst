﻿// <auto-generated />
using BotMyst.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace BotMyst.Web.Migrations.ModuleOptions
{
    [DbContext(typeof(ModuleOptionsContext))]
    [Migration("20180625143832_ModuleOptions")]
    partial class ModuleOptions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("BotMyst.Bot.Options.Utility.LmgtfyOptions", b =>
                {
                    b.Property<ulong>("GuildId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChannelBlacklist");

                    b.Property<string>("ChannelWhitelist");

                    b.Property<bool>("DeleteInvocationMessage");

                    b.Property<bool>("Dm");

                    b.Property<bool>("Enabled");

                    b.Property<string>("RoleBlacklist");

                    b.Property<string>("RoleWhitelist");

                    b.HasKey("GuildId");

                    b.ToTable("LmgtfyOptions");
                });

            modelBuilder.Entity("BotMyst.Bot.Options.Utility.UserInfoOptions", b =>
                {
                    b.Property<ulong>("GuildId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChannelBlacklist");

                    b.Property<string>("ChannelWhitelist");

                    b.Property<bool>("DeleteInvocationMessage");

                    b.Property<bool>("Dm");

                    b.Property<bool>("Enabled");

                    b.Property<string>("RoleBlacklist");

                    b.Property<string>("RoleWhitelist");

                    b.HasKey("GuildId");

                    b.ToTable("UserInfoOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
