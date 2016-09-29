namespace PetersRestraunt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialise : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.bookTables",
                c => new
                    {
                        bookedTable = c.Int(nullable: false, identity: true),
                        Id = c.String(),
                        tableId = c.Int(nullable: false),
                        orderId = c.Int(nullable: false),
                        numberInParty = c.Int(nullable: false),
                        whenTableBooked = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.bookedTable)
                .ForeignKey("dbo.Orders", t => t.orderId, cascadeDelete: true)
                .ForeignKey("dbo.restrauntTables", t => t.tableId, cascadeDelete: true)
                .Index(t => t.tableId)
                .Index(t => t.orderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        orderId = c.Int(nullable: false, identity: true),
                        Id = c.String(),
                        bookTableId = c.Int(nullable: false),
                        menuId = c.Int(nullable: false),
                        menuItem = c.String(),
                        menuAmount = c.Int(nullable: false),
                        orderMade = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.orderId)
                .ForeignKey("dbo.Menus", t => t.menuId, cascadeDelete: true)
                .Index(t => t.menuId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        menuId = c.Int(nullable: false, identity: true),
                        menuItem = c.String(),
                        isThisVegaterian = c.Boolean(nullable: false),
                        isThisGlutenFree = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.menuId);
            
            CreateTable(
                "dbo.restrauntTables",
                c => new
                    {
                        tableId = c.Int(nullable: false, identity: true),
                        tableName = c.String(),
                    })
                .PrimaryKey(t => t.tableId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        numberInParty = c.Int(nullable: false),
                        role = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.bookTables", "tableId", "dbo.restrauntTables");
            DropForeignKey("dbo.Orders", "menuId", "dbo.Menus");
            DropForeignKey("dbo.bookTables", "orderId", "dbo.Orders");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Orders", new[] { "menuId" });
            DropIndex("dbo.bookTables", new[] { "orderId" });
            DropIndex("dbo.bookTables", new[] { "tableId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.restrauntTables");
            DropTable("dbo.Menus");
            DropTable("dbo.Orders");
            DropTable("dbo.bookTables");
        }
    }
}
