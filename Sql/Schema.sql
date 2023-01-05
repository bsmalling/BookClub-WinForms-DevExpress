CREATE TABLE "Books" (
    "Id" int identity(1, 1) primary key,
    "Deleted" bit not null default 0,
    "Title" varchar(500) not null,
    "Author" varchar(100) not null,
    "Description" varchar(500),
    "Pages" int,
    "ISBN" varchar(24),
    "ASIN" varchar(20),
    "ThumbnailId" int,
    "Published" date not null,
    "Timestamp" timestamp
);
CREATE INDEX "ix_Books_Title" ON Books("Title");
CREATE INDEX "ix_Books_Author" ON Books("Author");
CREATE INDEX "ix_Books_ISBN" ON Books("ISBN");
CREATE INDEX "ix_Books_ASIN" ON Books("ASIN");

CREATE TABLE "Comments" (
    "Id" int identity(1, 1) primary key,
    "ParentType" int not null,
    "ParentId" int not null,
    "Text" varchar(500) not null,
    "UserId" int not null,
    "Created" datetime not null,
    "Timestamp" timestamp
);
CREATE INDEX "ix_Comments_Parent" ON Comments("ParentType", "ParentId");

CREATE TABLE Locations (
    "Id" int identity(1, 1) primary key,
    "Deleted" bit not null default 0,
    "Address1" varchar(100) not null,
    "Address2" varchar(100),
    "City" varchar(100) not null,
    "State" varchar(50) not null,
    "Zip" varchar(10),
    "Description" varchar(500),
    "Timestamp" timestamp
);
CREATE INDEX "ix_Locations_Address1" ON Locations("Address1");

CREATE TABLE Meetings (
    "Id" int identity(1, 1) primary key,
    "BookId" int not null,
    "HostId" int not null,
    "LocationId" int not null,
    "MeetTime" datetime not null,
    "Description" varchar(500),
    "Timestamp" timestamp
);
CREATE INDEX "ix_Meetings_MeetTime" ON Meetings("MeetTime" DESC);

CREATE TABLE Recommendations (
    "Id" int identity(1, 1) primary key,
    "MeetingId" int not null,
    "BookId" int not null,
    "UserId" int not null,
    "Created" datetime not null,
    "Timestamp" timestamp
);
CREATE INDEX "ix_Recommendations_MeetingId" ON Recommendations("MeetingId", "Created" DESC);

CREATE TABLE Thumbnails (
    "Id" int identity(1, 1) primary key,
    "Image" varbinary(max) not null,
    "Timestamp" timestamp
);

CREATE TABLE Users (
    "Id" int identity(1, 1) primary key,
    "Deleted" bit not null default 0,
    "Username" varchar(100) not null,
    "PwdHash" varchar(40) not null,
    "FirstName" varchar(100) not null,
    "LastName" varchar(100) not null,
    "Email" varchar(100) not null,
    "AboutMe" varchar(500),
    "Role" int not null,
    "Timestamp" timestamp
);
CREATE INDEX "ix_Users_Username" ON Users("Username", "Deleted");
CREATE INDEX "ix_Users_Name" ON Users("LastName", "FirstName");
