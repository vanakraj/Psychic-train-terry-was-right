Psychic Train Terry Was Right - Library App
This is a simple Windows Forms library management application built with C# (.NET 8). The app allows users to log in, add new books, and manage library data. It uses SQL connections to interact with a local SQL Server database ((localdb)\booktool). Book and user information is stored and retrieved using SQL queries.

Features:
•	User login with credentials stored in the database
•	Add new books to the library
•	Data validation for book entries
•	Modern WinForms UI

Requirements:
•	.NET 8 SDK
•	SQL Server LocalDB instance
•	A local database named library with the required tables (e.g., loginTable, NewBook)

Note:
This app is for demonstration purposes and uses direct SQL queries. For production, use parameterized queries and secure password storage.
