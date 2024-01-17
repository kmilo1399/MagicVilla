﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa", new DateTime(2024, 1, 17, 0, 23, 57, 393, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 1, 17, 0, 23, 57, 393, DateTimeKind.Local).AddTicks(503), "", 50, "villa real", 5, 200.0 },
                    { 2, "", "Detalle de la villa", new DateTime(2024, 1, 17, 0, 23, 57, 393, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 1, 17, 0, 23, 57, 393, DateTimeKind.Local).AddTicks(533), "", 40, "Premium vista a la piscina", 4, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
