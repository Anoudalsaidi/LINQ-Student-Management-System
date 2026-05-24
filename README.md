LINQ Student Management System - Step by Step Explanation
---------------------------------------------------------

1️⃣ First, we created a Student class that contains:
   - Id
   - Name
   - Age
   - Department
   - Grade

   This class represents the structure of each student in the system.

------------------------------------------------------------

2️⃣ Then, we created a List of Student objects and added sample data
   to simulate a real student database.

------------------------------------------------------------

3️⃣ We used LINQ Where() method to filter students
   and display only those who have Grade greater than 80.

   Purpose: Filtering data based on a condition.

------------------------------------------------------------

4️⃣ We used Select() method to project data
   and display only student names.

   Purpose: Transforming data from full object to specific field.

------------------------------------------------------------

5️⃣ We used FirstOrDefault() to get the first student
   in the CS department.

   Purpose: Retrieve a single matching record safely.

------------------------------------------------------------

6️⃣ We used OrderByDescending() to sort students
   based on their Grade from highest to lowest.

   Purpose: Sorting data in descending order.

------------------------------------------------------------

7️⃣ We used Average() to calculate the average grade
   of all students.

   Purpose: Performing aggregation on numeric data.

------------------------------------------------------------

8️⃣ We used Count() to count how many students
   are in the IT department.

   Purpose: Counting filtered records.

------------------------------------------------------------

9️⃣ We used Max() to find the highest grade
   and then identified the top student.

   Purpose: Finding maximum value in dataset.

------------------------------------------------------------

 Finally, we printed all results in a clean format
to display the output clearly in the console.
