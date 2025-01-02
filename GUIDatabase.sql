CREATE DATABASE Car_Rental_System_DB;

CREATE TABLE Customer
(
  Customer_NIC int primary key,
  Customer_Name varchar(50),
  Contact_No int,
  Email varchar(50),
  Username varchar(50),
  C_Password varchar(20)
  
);

CREATE TABLE Car
(
  Car_ID varchar(5) primary key check(Car_ID like 'C%'),
  Model varchar(20),
  Customer_NIC int foreign key references Customer(Customer_NIC)
);

CREATE TABLE Ride
(
  Ride_ID varchar(5) primary key,
  Ride_Date date default GETDATE(),	 
  PickUp_Location varchar(20),
  Drop_Location varchar(20),
  Price float,
  No_of_days int,
  Customer_NIC int foreign key references Customer(Customer_NIC)
);

CREATE TABLE Payment
(
  Payment_ID varchar(5) primary key,
  Card_Number int,
  Payment_Date date default GETDATE(), 
  Amount float,
  Customer_NIC int foreign key references Customer(Customer_NIC)
);

CREATE TABLE Feedback
(
  Feedback_ID varchar(5) primary key,
  F_Description varchar(50),
  Ride_ID varchar(5) foreign key references Ride(Ride_ID)
);

drop table Feedback








