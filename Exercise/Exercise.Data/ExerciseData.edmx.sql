
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2017 23:02:59
-- Generated from EDMX file: C:\Users\usuario\Source\Repos\Test\Exercise\Exercise.Data\ExerciseData.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Exercise];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Student'
CREATE TABLE [dbo].[Student] (
    [StudentId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [EnrollmentDate] datetime  NOT NULL
);
GO

-- Creating table 'Enrollment'
CREATE TABLE [dbo].[Enrollment] (
    [EnrollmentId] int IDENTITY(1,1) NOT NULL,
    [StudentId] int  NOT NULL,
    [CourseId] int  NOT NULL,
    [Grade] nvarchar(max)  NOT NULL,
    [StudentStudentId] int  NOT NULL,
    [CourseCourseId] int  NOT NULL
);
GO

-- Creating table 'Course'
CREATE TABLE [dbo].[Course] (
    [CourseId] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Credits] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [StudentId] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [PK_Student]
    PRIMARY KEY CLUSTERED ([StudentId] ASC);
GO

-- Creating primary key on [EnrollmentId] in table 'Enrollment'
ALTER TABLE [dbo].[Enrollment]
ADD CONSTRAINT [PK_Enrollment]
    PRIMARY KEY CLUSTERED ([EnrollmentId] ASC);
GO

-- Creating primary key on [CourseId] in table 'Course'
ALTER TABLE [dbo].[Course]
ADD CONSTRAINT [PK_Course]
    PRIMARY KEY CLUSTERED ([CourseId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentStudentId] in table 'Enrollment'
ALTER TABLE [dbo].[Enrollment]
ADD CONSTRAINT [FK_StudentEnrollment]
    FOREIGN KEY ([StudentStudentId])
    REFERENCES [dbo].[Student]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentEnrollment'
CREATE INDEX [IX_FK_StudentEnrollment]
ON [dbo].[Enrollment]
    ([StudentStudentId]);
GO

-- Creating foreign key on [CourseCourseId] in table 'Enrollment'
ALTER TABLE [dbo].[Enrollment]
ADD CONSTRAINT [FK_CourseEnrollment]
    FOREIGN KEY ([CourseCourseId])
    REFERENCES [dbo].[Course]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseEnrollment'
CREATE INDEX [IX_FK_CourseEnrollment]
ON [dbo].[Enrollment]
    ([CourseCourseId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------