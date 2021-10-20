# OOP- Food Delivery Application


UML To Code

General description:
Recommended time to implement the task - 2-3 weeks.
Deadline - Autumn semester final exam.
Maximum points for the easy part - 5 points (7 points with additional tasks).

	The main goal for this task: transform created in 3rd project diagrams to code.

	Subject area: food delivery service.

Required functionality: 
When the program starts the user must type his name and birthday, this action creates a new user in your program. After that the user must see the whole menu (depends on stock ingredients) grouped by categories (meals, drinks, deserts, etc.). Each item must have a unique id, by which the user can add this meal to the cart. Also, user must have functionality to see details of each meal (details can contain for example calories, ingredients, description and other properties). Required thing: your program must have a class “STOCK” where you will store all ingredients for food. This class must have logic for ingredient existing checking, which you will use for each meal to show only actual menu to user. This class can be static, to simulate database and you will have access from any part of program to this class.
In this criteria, the student’s ability to create classes (users, menu, dish, ingredient, storage, cart), the ability to associate classes and work with them will be evaluated. (WorkWithFood)
When user choose all food that he wants, he can see cart with all selected dishes total price and calories (calories must be defined in INGREDIENT class, and you must calculate total calories for meal (also, ingredient has weight, weight needed to calculate calories). For example, you have 1 instance of chicken in stock and weight is 15000 grams, so, it means that you have total 15kg of chicken and if some meal need 0,5kg ypu will decrease weight value). User can create order. When a user creates an order, he must type address, phone, and some comment. Then user confirm order and order creates. If a user has a birthday, you must calculate the discount and show this information in order. When user back to menu, he must have functionality to see all his orders with details. If you at beginning of program define some other discounts, users must see them. (Orders)
Manager can modify menu (add new dish, remove dishes). To add new dish you must have huge collection of ingredients, which you will choose for new dish. Also manager can see all orders, choose order and see it with details (only watch orders, you don’t need to change status of orders and other functionality). When your program starts, need to choose, by which role you want to work (simple user or manager). (Manager)
Additional task: Implementation of user authorization. In your program you must have collection of users with login, password and data (name, birthday, role (user, manager)). All users data needs to be stored in file (login and pass must be hashed). When program starts, user type login and password, you must find this user in your database (file) and authorize this user and set as current. If user not exist, you create new user and add it to file. User must have functionality to edit data (name, birthday). When you create user he must be as simple user, not manager. (Additional)

In your code you must use main paradigms and best practices of OOP (interfaces, encapsulation, polymorphism).


