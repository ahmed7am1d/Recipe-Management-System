CREATE DATABASE RecipeManagementSystem
USE RecipeManagementSystem
GO

-- User table
CREATE TABLE [User]
(
  UserID INT IDENTITY(1,1) NOT NULL,
  UserName VARCHAR(100) NOT NULL,
  FirstName VARCHAR(100) NOT NULL,
  LastName VARCHAR(100) NUll,
  Password VARCHAR(255) NOT NULL,
  PRIMARY KEY  (UserID),
  UNIQUE (UserName)
);

--Category table

CREATE TABLE Category
(
  CategoryID INT NOT NULL,
  Name VARCHAR(25) NOT NULL,
  PRIMARY KEY (CategoryID)
);

--Admin table

CREATE TABLE [Admin]
(
  AdminID INT NOT NULL,
  FirstName VARCHAR(100) NOT NULL,
  LastName VARCHAR(100) NOT NULL,
  UserName VARCHAR(100) NOT NULL,
  Password VARCHAR(255) NOT NULL,
  PRIMARY KEY (AdminID),
  UNIQUE (UserName)
);
-- Recipe table
CREATE TABLE Recipe
(
  [Name] VARCHAR(25) NOT NULL,
  Description VARCHAR(255) NOT NULL,
  RecipeID INT IDENTITY(1,1) NOT NULL,
  RecipeStatus VARCHAR(15) NOT NULL,
  [User_ID] INT NOT NULL,
  Category_ID INT NOT NULL,
  PRIMARY KEY (RecipeID),
  FOREIGN KEY ([User_ID]) REFERENCES [User](UserID),
  FOREIGN KEY (Category_ID) REFERENCES Category(CategoryID)
);


--execute the below code after executing the Recipe table :
ALTER TABLE Recipe
ADD CONSTRAINT df_recipeStatus
DEFAULT 'Pended' for RecipeStatus



--step table
CREATE TABLE Step
(
  StepID INT IDENTITY(1,1) NOT NULL,
  Description VARCHAR(255) NOT NULL,
  Recipe_ID INT NOT NULL,
  PRIMARY KEY (StepID),
  FOREIGN KEY (Recipe_ID) REFERENCES Recipe(RecipeID)
);


--ingredient table

CREATE TABLE Ingredient
(
  IngredientID INT IDENTITY(1,1) NOT NULL,
  Name VARCHAR(25) NOT NULL,
  Quantity VARCHAR(25) NOT NULL,
  Recipe_ID INT NOT NULL,
  PRIMARY KEY (IngredientID),
  FOREIGN KEY (Recipe_ID) REFERENCES Recipe(RecipeID)
);

--Baic Selecitons:

SELECT * FROM [User]
SELECT * FROM [Admin]
SELECT * FROM Category
SELECT * FROM Recipe
SELECT * FROM Ingredient
SELECT * FROM Step

-- insert an admin:

INSERT INTO [Admin] (AdminID,FirstName,LastName,UserName,[Password]) VALUES (1,'','','','')

--inserting category 

INSERT INTO Category(CategoryID,[Name]) Values
(1,'BreakFast'),
(2,'Lunch'),
(3,'Dinner'),
(4,'Apptizer'),
(5,'Dessert'),
(6,'Beverage'),
(7,'Juice')


--all the inner join and the connected tables query commands are written in c# project those here are the most important queries