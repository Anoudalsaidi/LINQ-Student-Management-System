# 📘 LINQ Student Management System

<p align="center">
  <b>A Step-by-Step LINQ Practice Project using C#</b><br>
  Demonstrating real-world data manipulation using LINQ methods in a simple student management system.
</p>

---

## 📌 Project Overview

This project demonstrates how to use **LINQ in C#** to perform data operations on a list of students.

It simulates a simple student management system where we apply filtering, sorting, projection, and aggregation using LINQ.

---

## 🎯 Student Model

Each student in the system contains:

- Id  
- Name  
- Age  
- Department  
- Grade  

This represents the structure of the dataset used in the system.

---

## 🧠 LINQ Operations Explained

### 1️⃣ Creating Student List
We created a `List<Student>` and added sample data to simulate a database.

---

### 2️⃣ Filtering Data (Where)
We used `Where()` to filter students with **Grade > 80**.

✔ Purpose: Filter data based on conditions.

---

### 3️⃣ Selecting Data (Select)
We used `Select()` to display only student names.

✔ Purpose: Transform data from full object to specific fields.

---

### 4️⃣ Getting Single Record (FirstOrDefault)
We used `FirstOrDefault()` to get the first student in the CS department.

✔ Purpose: Safely retrieve a single matching record.

---

### 5️⃣ Sorting Data (OrderByDescending)
We sorted students by grade from highest to lowest.

✔ Purpose: Arrange data in descending order.

---

### 6️⃣ Aggregation (Average)
We calculated the average grade of all students.

✔ Purpose: Perform numeric aggregation.

---

### 7️⃣ Counting Records (Count)
We counted how many students are in the IT department.

✔ Purpose: Count filtered results.

---

### 8️⃣ Maximum Value (Max)
We found the highest grade and identified the top student.

✔ Purpose: Find maximum value in dataset.

---

## 📊 Final Output

At the end, all results are printed in a clean console format for better readability.

---

## 🏗️ Tech Stack

- C#
- LINQ
- .NET Console Application
- Object-Oriented Programming (OOP)

---

## 👨‍💻 Author

**Anoud Alsaidi**  
.NET Developer | Backend Engineer | Cybersecurity Enthusiast  

🌐 GitHub: https://github.com/Anoudalsaidi  

---

## ⭐ Support

If you like this project, please give it a ⭐ on GitHub.
