﻿// <auto-generated />
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata;
using Northwind.Models;

#pragma warning disable 219, 612, 618
#nullable enable

namespace Northwind.Modes
{
    internal partial class SummaryOfSalesByYearEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Northwind.Models.SummaryOfSalesByYear",
                typeof(SummaryOfSalesByYear),
                baseEntityType);

            var orderId = runtimeEntityType.AddProperty(
                "OrderId",
                typeof(int),
                propertyInfo: typeof(SummaryOfSalesByYear).GetProperty("OrderId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SummaryOfSalesByYear).GetField("<OrderId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            orderId.AddAnnotation("Relational:ColumnName", "OrderID");
            orderId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var shippedDate = runtimeEntityType.AddProperty(
                "ShippedDate",
                typeof(DateTime?),
                propertyInfo: typeof(SummaryOfSalesByYear).GetProperty("ShippedDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SummaryOfSalesByYear).GetField("<ShippedDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            shippedDate.AddAnnotation("Relational:ColumnType", "datetime");
            shippedDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var subtotal = runtimeEntityType.AddProperty(
                "Subtotal",
                typeof(decimal?),
                propertyInfo: typeof(SummaryOfSalesByYear).GetProperty("Subtotal", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SummaryOfSalesByYear).GetField("<Subtotal>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            subtotal.AddAnnotation("Relational:ColumnType", "money");
            subtotal.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "Summary of Sales by Year");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
