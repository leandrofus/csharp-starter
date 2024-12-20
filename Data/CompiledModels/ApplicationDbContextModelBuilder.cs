﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#pragma warning disable 219, 612, 618
#nullable disable

namespace test3.Data.CompiledModels
{
    public partial class ApplicationDbContextModel
    {
        partial void Initialize()
        {
            var user = UserEntityType.Create(this);

            UserEntityType.CreateAnnotations(user);

            AddAnnotation("ProductVersion", "8.0.10");
            AddRuntimeAnnotation("Relational:RelationalModel", CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);

            var user = FindEntityType("test3.Models.User")!;

            var defaultTableMappings = new List<TableMappingBase<ColumnMappingBase>>();
            user.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings);
            var test3ModelsUserTableBase = new TableBase("test3.Models.User", null, relationalModel);
            var idColumnBase = new ColumnBase<ColumnMappingBase>("Id", "INTEGER", test3ModelsUserTableBase);
            test3ModelsUserTableBase.Columns.Add("Id", idColumnBase);
            var passwordColumnBase = new ColumnBase<ColumnMappingBase>("Password", "TEXT", test3ModelsUserTableBase);
            test3ModelsUserTableBase.Columns.Add("Password", passwordColumnBase);
            var refreshTokenColumnBase = new ColumnBase<ColumnMappingBase>("RefreshToken", "TEXT", test3ModelsUserTableBase);
            test3ModelsUserTableBase.Columns.Add("RefreshToken", refreshTokenColumnBase);
            var refreshTokenExpiryTimeColumnBase = new ColumnBase<ColumnMappingBase>("RefreshTokenExpiryTime", "TEXT", test3ModelsUserTableBase);
            test3ModelsUserTableBase.Columns.Add("RefreshTokenExpiryTime", refreshTokenExpiryTimeColumnBase);
            var usernameColumnBase = new ColumnBase<ColumnMappingBase>("Username", "TEXT", test3ModelsUserTableBase);
            test3ModelsUserTableBase.Columns.Add("Username", usernameColumnBase);
            relationalModel.DefaultTables.Add("test3.Models.User", test3ModelsUserTableBase);
            var test3ModelsUserMappingBase = new TableMappingBase<ColumnMappingBase>(user, test3ModelsUserTableBase, true);
            test3ModelsUserTableBase.AddTypeMapping(test3ModelsUserMappingBase, false);
            defaultTableMappings.Add(test3ModelsUserMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)idColumnBase, user.FindProperty("Id")!, test3ModelsUserMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)passwordColumnBase, user.FindProperty("Password")!, test3ModelsUserMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)refreshTokenColumnBase, user.FindProperty("RefreshToken")!, test3ModelsUserMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)refreshTokenExpiryTimeColumnBase, user.FindProperty("RefreshTokenExpiryTime")!, test3ModelsUserMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)usernameColumnBase, user.FindProperty("Username")!, test3ModelsUserMappingBase);

            var tableMappings = new List<TableMapping>();
            user.SetRuntimeAnnotation("Relational:TableMappings", tableMappings);
            var usersTable = new Table("Users", null, relationalModel);
            var idColumn = new Column("Id", "INTEGER", usersTable);
            usersTable.Columns.Add("Id", idColumn);
            var passwordColumn = new Column("Password", "TEXT", usersTable);
            usersTable.Columns.Add("Password", passwordColumn);
            var refreshTokenColumn = new Column("RefreshToken", "TEXT", usersTable);
            usersTable.Columns.Add("RefreshToken", refreshTokenColumn);
            var refreshTokenExpiryTimeColumn = new Column("RefreshTokenExpiryTime", "TEXT", usersTable);
            usersTable.Columns.Add("RefreshTokenExpiryTime", refreshTokenExpiryTimeColumn);
            var usernameColumn = new Column("Username", "TEXT", usersTable);
            usersTable.Columns.Add("Username", usernameColumn);
            var pK_Users = new UniqueConstraint("PK_Users", usersTable, new[] { idColumn });
            usersTable.PrimaryKey = pK_Users;
            var pK_UsersUc = RelationalModel.GetKey(this,
                "test3.Models.User",
                new[] { "Id" });
            pK_Users.MappedKeys.Add(pK_UsersUc);
            RelationalModel.GetOrCreateUniqueConstraints(pK_UsersUc).Add(pK_Users);
            usersTable.UniqueConstraints.Add("PK_Users", pK_Users);
            relationalModel.Tables.Add(("Users", null), usersTable);
            var usersTableMapping = new TableMapping(user, usersTable, true);
            usersTable.AddTypeMapping(usersTableMapping, false);
            tableMappings.Add(usersTableMapping);
            RelationalModel.CreateColumnMapping(idColumn, user.FindProperty("Id")!, usersTableMapping);
            RelationalModel.CreateColumnMapping(passwordColumn, user.FindProperty("Password")!, usersTableMapping);
            RelationalModel.CreateColumnMapping(refreshTokenColumn, user.FindProperty("RefreshToken")!, usersTableMapping);
            RelationalModel.CreateColumnMapping(refreshTokenExpiryTimeColumn, user.FindProperty("RefreshTokenExpiryTime")!, usersTableMapping);
            RelationalModel.CreateColumnMapping(usernameColumn, user.FindProperty("Username")!, usersTableMapping);
            return relationalModel.MakeReadOnly();
        }
    }
}
