# C# Stock And Inventory Management Software
A widely made, bland and non-unique, mainstream C# project

This C# project was built as a school project for a "Non-Exam-Assessment" component.
The project aims to aid small shop keepers, with focus on wholesale shops and small groceries which are quite widely setup all across India. The app uses a Maria DB server and also a local Sqlite3 database to handle cashflow, inventory, product catalogues, seller information, employee and admin credentials

The project is made using Windows Forms template, with over 15 Forms used to smoothly traverse through the software, including a splash screen and central portal screen with branching sub screens that lead to the functions and features baked into the application.

Features:
1. Login and verification of user: User details are verified against a sql database table that contains the credentials. There is a facility to change the password via email verification using a randomly generated 6 digit code that will allow to chaneg the password, if entered correctly
2. Central landing Portal: A big screen with feature related buttons and a big table showing the stock quantities and alerts if the stock is too low
3. Add new employees
4. Add new Products
5. Add Seller information
6. Order stock
7. Make payments
8. Check balance and Deposit/Withdraw funds
9. Make Payments and Salaries
10. Compare prices across websites for stock acquirement: This is one of the selling points in the software, the program has been hardcoded with select products' links from Amazon, Flipkart and Indiamart. the code basically reads the links hands over the links to a python script that scrapes the data from the html files using the class and id tags of the price component. though this is limited to a few products, one could find ways to fetch links for all and have a completely automated comparison tool.


A few requests,
To fellow coders/programmers,

I encourage you to use this as a template to your work and build on what I have done here and not submit assignments and Computer Science NEA's with this code.
It is not a good practice to pass off ones work as your own, this repository is for my personal showcase and a source of inspiration for you to asses the flaws and logic and improve your own work

I am trusting you, best of luck in your endeavours!


