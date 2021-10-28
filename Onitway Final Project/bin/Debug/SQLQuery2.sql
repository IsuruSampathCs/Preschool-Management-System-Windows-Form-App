create database OnitwayDB;

USE OnitwayDB;

Create table users(
Full_Name varchar(50),Email varchar(50),UserName varchar(10),Password varchar(100)
);

Insert into users(Full_Name,Email,UserName,Password)
Values('Kusala Kanil','Kusala@gmail.com','admin',1234);

Select * from users;

Create table Admin(
UserName varchar(10),Password varchar(25)
);

Insert into Admin(UserName,Password)
Values('admin','admin');

Select * From Admin;

Create Table Student(
Student_ID varchar(20) Primary Key,
Full_Name varchar(50),
DOB DATETIME,
Age INT,
Profile_Picture image,
Nationality Varchar(20),
Religion varchar(20),
Blood_Group varchar(20),
Gender varchar(10),
Address varchar(100),
Alergies_OR_Medical_Conditions varchar(500),
Any_Long_Term_Medication varchar(500),
Assign_Class varchar(10),
Admission_Fees int,
);

Select * From Student;

Create Table Employee(
Employee_ID varchar(20) Primary Key,
Full_Name varchar(50),
DOB DATETIME,
Age INT,
Gender varchar(10),
Address varchar(200),
Designation varchar(100),
Education_Qualifications varchar(500),
Professional_Qualifications varchar(500),
Work_Experience varchar(500),
Email varchar(50),
NIC varchar(50),
Mobile INT
);

Select * from Employee;

Create Table Salary(
Salary_ID varchar(20) primary key,
Emp_ID varchar(20),
Employee_Name varchar(50),
Basic_Salary int,
Advance int,
Allowance int,
Attendance_Allowance int,
Net_Salary int
);

ALTER TABLE Salary ADD CONSTRAINT Employee_ID_REF FOREIGN KEY(Emp_ID)
REFERENCES Employee(Employee_ID);

Select * from Salary;

Create Table Payments(
Payment_Id varchar(20) primary key,
Student_Name varchar(100),
Payment_Type varchar(50),
Amount int,
Month Varchar(20),
Phone_No int
);

Select * From Payments;

Create Table Event(
Event_ID varchar(20) primary key,
Stud_ID varchar(20),
Student_Name varchar(50),
Event_Name varchar(100),
Event_Date DATETIME,
Amount int,
Total_Amount int
);

ALTER TABLE Event ADD CONSTRAINT Student_ID_REF FOREIGN KEY(Stud_ID)
REFERENCES Student(Student_ID);

Select * From Event;
