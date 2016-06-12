namespace vanns_mobileService.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activity",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        ActivityVanID = c.Int(nullable: false),
                        CreateAt = c.DateTime(nullable: false),
                        ActivityType = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        TripID = c.Int(nullable: false),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                        Student_Id = c.String(maxLength: 128),
                        Trip_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .ForeignKey("dbo.Trip", t => t.Trip_Id)
                .Index(t => t.CreatedAt, clustered: false)
                .Index(t => t.Student_Id)
                .Index(t => t.Trip_Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        StudentID = c.Int(nullable: false),
                        Name = c.String(),
                        DateBirth = c.DateTime(nullable: false),
                        SchoolID = c.Int(nullable: false),
                        VehicleID = c.Int(),
                        LevelID = c.Int(nullable: false),
                        AddressID = c.Int(nullable: false),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                        Level_Id = c.String(maxLength: 128),
                        School_Id = c.String(maxLength: 128),
                        Address_Id = c.String(maxLength: 128),
                        Vehicle_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Levels", t => t.Level_Id)
                .ForeignKey("dbo.School", t => t.School_Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .ForeignKey("dbo.Vehicle", t => t.Vehicle_Id)
                .Index(t => t.CreatedAt, clustered: false)
                .Index(t => t.Level_Id)
                .Index(t => t.School_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        AddressID = c.Int(nullable: false),
                        PublicPlace = c.Int(nullable: false),
                        Lat = c.Double(nullable: false),
                        Long = c.Double(nullable: false),
                        Number = c.String(),
                        Complement = c.String(),
                        Neighborhood = c.String(),
                        State = c.Int(nullable: false),
                        PostalCode = c.String(),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CreatedAt, clustered: false);
            
            CreateTable(
                "dbo.BaseUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        BaseUserID = c.Int(nullable: false),
                        PasswordHash = c.String(),
                        Login = c.String(),
                        Email = c.String(),
                        Name = c.String(),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CreatedAt, clustered: false);
            
            CreateTable(
                "dbo.Estimate",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        EstimateID = c.Int(nullable: false),
                        IsPublic = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZoneID = c.Int(nullable: false),
                        SchoolDriverID = c.Int(nullable: false),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                        SchoolDriver_Id = c.String(maxLength: 128),
                        Zone_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchoolDriver", t => t.SchoolDriver_Id)
                .ForeignKey("dbo.Zone", t => t.Zone_Id)
                .Index(t => t.CreatedAt, clustered: false)
                .Index(t => t.SchoolDriver_Id)
                .Index(t => t.Zone_Id);
            
            CreateTable(
                "dbo.Zone",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        ZoneID = c.Int(nullable: false),
                        Name = c.String(),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CreatedAt, clustered: false);
            
            CreateTable(
                "dbo.Levels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        LevelID = c.Int(nullable: false),
                        LevelName = c.String(),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CreatedAt, clustered: false);
            
            CreateTable(
                "dbo.Trip",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        TripID = c.Int(nullable: false),
                        StartLat = c.Double(nullable: false),
                        StartLong = c.Double(nullable: false),
                        CurrentLat = c.Double(nullable: false),
                        CurrentLong = c.Double(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(),
                        VehicleID = c.Int(nullable: false),
                        SchoolDriverID = c.Int(nullable: false),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                        SchoolDriver_Id = c.String(maxLength: 128),
                        Vehicle_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchoolDriver", t => t.SchoolDriver_Id)
                .ForeignKey("dbo.Vehicle", t => t.Vehicle_Id)
                .Index(t => t.CreatedAt, clustered: false)
                .Index(t => t.SchoolDriver_Id)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        VehicleID = c.Int(nullable: false),
                        PlateCar = c.String(),
                        Model = c.String(),
                        Year = c.String(),
                        Occupants = c.Int(nullable: false),
                        IdentityCar = c.String(),
                        CarColor = c.Int(nullable: false),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CreatedAt, clustered: false);
            
            CreateTable(
                "dbo.Rating",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        RattingID = c.Int(nullable: false),
                        Comment = c.String(),
                        Rate = c.Int(nullable: false),
                        VehicleID = c.Int(nullable: false),
                        ClientID = c.Int(nullable: false),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                        Client_Id = c.String(maxLength: 128),
                        Vehicle_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.Client_Id)
                .ForeignKey("dbo.Vehicle", t => t.Vehicle_Id)
                .Index(t => t.CreatedAt, clustered: false)
                .Index(t => t.Client_Id)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.ZoneSchoolDrivers",
                c => new
                    {
                        Zone_Id = c.String(nullable: false, maxLength: 128),
                        SchoolDriver_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Zone_Id, t.SchoolDriver_Id })
                .ForeignKey("dbo.Zone", t => t.Zone_Id, cascadeDelete: true)
                .ForeignKey("dbo.SchoolDriver", t => t.SchoolDriver_Id, cascadeDelete: true)
                .Index(t => t.Zone_Id)
                .Index(t => t.SchoolDriver_Id);
            
            CreateTable(
                "dbo.LevelSchools",
                c => new
                    {
                        Level_Id = c.String(nullable: false, maxLength: 128),
                        School_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Level_Id, t.School_Id })
                .ForeignKey("dbo.Levels", t => t.Level_Id, cascadeDelete: true)
                .ForeignKey("dbo.School", t => t.School_Id, cascadeDelete: true)
                .Index(t => t.Level_Id)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.SchoolSchoolDrivers",
                c => new
                    {
                        School_Id = c.String(nullable: false, maxLength: 128),
                        SchoolDriver_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.School_Id, t.SchoolDriver_Id })
                .ForeignKey("dbo.School", t => t.School_Id)
                .ForeignKey("dbo.SchoolDriver", t => t.SchoolDriver_Id)
                .Index(t => t.School_Id)
                .Index(t => t.SchoolDriver_Id);
            
            CreateTable(
                "dbo.TripStudents",
                c => new
                    {
                        Trip_Id = c.String(nullable: false, maxLength: 128),
                        Student_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Trip_Id, t.Student_Id })
                .ForeignKey("dbo.Trip", t => t.Trip_Id, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Trip_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.ClientStudents",
                c => new
                    {
                        Client_Id = c.String(nullable: false, maxLength: 128),
                        Student_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Client_Id, t.Student_Id })
                .ForeignKey("dbo.Client", t => t.Client_Id, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Client_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        Vehicle_Id = c.String(maxLength: 128),
                        PhoneNumber = c.String(),
                        VehicleID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BaseUser", t => t.Id)
                .ForeignKey("dbo.Vehicle", t => t.Vehicle_Id)
                .Index(t => t.Id)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.SchoolDriver",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        Address_Id = c.String(maxLength: 128),
                        Vehicle_Id = c.String(maxLength: 128),
                        DateBirth = c.DateTime(nullable: false),
                        License = c.String(),
                        VehicleID = c.Int(nullable: false),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BaseUser", t => t.Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .ForeignKey("dbo.Vehicle", t => t.Vehicle_Id)
                .Index(t => t.Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        Address_Id = c.String(maxLength: 128),
                        Zone_Id = c.String(maxLength: 128),
                        StateRegistration = c.String(),
                        ZoneID = c.Int(nullable: false),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BaseUser", t => t.Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .ForeignKey("dbo.Zone", t => t.Zone_Id)
                .Index(t => t.Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Zone_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.School", "Zone_Id", "dbo.Zone");
            DropForeignKey("dbo.School", "Address_Id", "dbo.Address");
            DropForeignKey("dbo.School", "Id", "dbo.BaseUser");
            DropForeignKey("dbo.SchoolDriver", "Vehicle_Id", "dbo.Vehicle");
            DropForeignKey("dbo.SchoolDriver", "Address_Id", "dbo.Address");
            DropForeignKey("dbo.SchoolDriver", "Id", "dbo.BaseUser");
            DropForeignKey("dbo.Client", "Vehicle_Id", "dbo.Vehicle");
            DropForeignKey("dbo.Client", "Id", "dbo.BaseUser");
            DropForeignKey("dbo.Student", "Vehicle_Id", "dbo.Vehicle");
            DropForeignKey("dbo.Student", "Address_Id", "dbo.Address");
            DropForeignKey("dbo.Trip", "Vehicle_Id", "dbo.Vehicle");
            DropForeignKey("dbo.ClientStudents", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.ClientStudents", "Client_Id", "dbo.Client");
            DropForeignKey("dbo.Rating", "Vehicle_Id", "dbo.Vehicle");
            DropForeignKey("dbo.Rating", "Client_Id", "dbo.Client");
            DropForeignKey("dbo.TripStudents", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.TripStudents", "Trip_Id", "dbo.Trip");
            DropForeignKey("dbo.Trip", "SchoolDriver_Id", "dbo.SchoolDriver");
            DropForeignKey("dbo.Activity", "Trip_Id", "dbo.Trip");
            DropForeignKey("dbo.Student", "School_Id", "dbo.School");
            DropForeignKey("dbo.SchoolSchoolDrivers", "SchoolDriver_Id", "dbo.SchoolDriver");
            DropForeignKey("dbo.SchoolSchoolDrivers", "School_Id", "dbo.School");
            DropForeignKey("dbo.Student", "Level_Id", "dbo.Levels");
            DropForeignKey("dbo.LevelSchools", "School_Id", "dbo.School");
            DropForeignKey("dbo.LevelSchools", "Level_Id", "dbo.Levels");
            DropForeignKey("dbo.ZoneSchoolDrivers", "SchoolDriver_Id", "dbo.SchoolDriver");
            DropForeignKey("dbo.ZoneSchoolDrivers", "Zone_Id", "dbo.Zone");
            DropForeignKey("dbo.Estimate", "Zone_Id", "dbo.Zone");
            DropForeignKey("dbo.Estimate", "SchoolDriver_Id", "dbo.SchoolDriver");
            DropForeignKey("dbo.Activity", "Student_Id", "dbo.Student");
            DropIndex("dbo.School", new[] { "Zone_Id" });
            DropIndex("dbo.School", new[] { "Address_Id" });
            DropIndex("dbo.School", new[] { "Id" });
            DropIndex("dbo.SchoolDriver", new[] { "Vehicle_Id" });
            DropIndex("dbo.SchoolDriver", new[] { "Address_Id" });
            DropIndex("dbo.SchoolDriver", new[] { "Id" });
            DropIndex("dbo.Client", new[] { "Vehicle_Id" });
            DropIndex("dbo.Client", new[] { "Id" });
            DropIndex("dbo.ClientStudents", new[] { "Student_Id" });
            DropIndex("dbo.ClientStudents", new[] { "Client_Id" });
            DropIndex("dbo.TripStudents", new[] { "Student_Id" });
            DropIndex("dbo.TripStudents", new[] { "Trip_Id" });
            DropIndex("dbo.SchoolSchoolDrivers", new[] { "SchoolDriver_Id" });
            DropIndex("dbo.SchoolSchoolDrivers", new[] { "School_Id" });
            DropIndex("dbo.LevelSchools", new[] { "School_Id" });
            DropIndex("dbo.LevelSchools", new[] { "Level_Id" });
            DropIndex("dbo.ZoneSchoolDrivers", new[] { "SchoolDriver_Id" });
            DropIndex("dbo.ZoneSchoolDrivers", new[] { "Zone_Id" });
            DropIndex("dbo.Rating", new[] { "Vehicle_Id" });
            DropIndex("dbo.Rating", new[] { "Client_Id" });
            DropIndex("dbo.Rating", new[] { "CreatedAt" });
            DropIndex("dbo.Vehicle", new[] { "CreatedAt" });
            DropIndex("dbo.Trip", new[] { "Vehicle_Id" });
            DropIndex("dbo.Trip", new[] { "SchoolDriver_Id" });
            DropIndex("dbo.Trip", new[] { "CreatedAt" });
            DropIndex("dbo.Levels", new[] { "CreatedAt" });
            DropIndex("dbo.Zone", new[] { "CreatedAt" });
            DropIndex("dbo.Estimate", new[] { "Zone_Id" });
            DropIndex("dbo.Estimate", new[] { "SchoolDriver_Id" });
            DropIndex("dbo.Estimate", new[] { "CreatedAt" });
            DropIndex("dbo.BaseUser", new[] { "CreatedAt" });
            DropIndex("dbo.Address", new[] { "CreatedAt" });
            DropIndex("dbo.Student", new[] { "Vehicle_Id" });
            DropIndex("dbo.Student", new[] { "Address_Id" });
            DropIndex("dbo.Student", new[] { "School_Id" });
            DropIndex("dbo.Student", new[] { "Level_Id" });
            DropIndex("dbo.Student", new[] { "CreatedAt" });
            DropIndex("dbo.Activity", new[] { "Trip_Id" });
            DropIndex("dbo.Activity", new[] { "Student_Id" });
            DropIndex("dbo.Activity", new[] { "CreatedAt" });
            DropTable("dbo.School",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                });
            DropTable("dbo.SchoolDriver",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                });
            DropTable("dbo.Client",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                });
            DropTable("dbo.ClientStudents");
            DropTable("dbo.TripStudents");
            DropTable("dbo.SchoolSchoolDrivers");
            DropTable("dbo.LevelSchools");
            DropTable("dbo.ZoneSchoolDrivers");
            DropTable("dbo.Rating",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            DropTable("dbo.Vehicle",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            DropTable("dbo.Trip",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            DropTable("dbo.Levels",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            DropTable("dbo.Zone",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            DropTable("dbo.Estimate",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            DropTable("dbo.BaseUser",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            DropTable("dbo.Address",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            DropTable("dbo.Student",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            DropTable("dbo.Activity",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
        }
    }
}
