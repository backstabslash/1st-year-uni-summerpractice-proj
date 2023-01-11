# **Technical task**

1. **Purpose of the program**

Automated management system "PC STORAGE" is a software that allows you to automate the process of maintaining information on goods in a warehouse with a sale price, which depends on the commercial "sale" rate of the currency of CB "Privatbank" and the price of posting, which, in turn, , depends on the exchange rate of the NBU.

2. **Functional purpose**

The main purpose of the system is to maintain an information base of goods, depending on the exchange rate of the national bank, and the selling price, which depends on the “sale” rate of the currency of CB “Privatbank”.

3. **Characteristics of the automation object**

Goods are purchased to the warehouse for currency (USD). Accounting for expenses and income is carried out both in hryvnia and in foreign currency. The goods are sold at the exchange rate of CB "Privatbank". Net profit is calculated by the formula: the price of the goods purchased by users from the warehouse (in USD) multiplied by the Privatbank rate multiplied by the adjustable rate of return, subtract the price of the goods purchased from the supplier (in USD) multiplied by the NBU rate.

4. **Composition of functions**
4.1. Implement in the program the presence of two categories of users: administrator and buyer; 
4.2. Administrator functions: 4.2.1. Adding and removing goods; 4.2.2. Adding and deleting product categories; 4.2.3. Viewing the list of goods; 4.2.4. Setting the selling price of goods based on the Privatbank rate and the profitability ratio; 4.2.5. Purchase of new goods for the warehouse, taking into account the costs based on the NBU rate; 4.2.6. Issuing and depriving users of administrator rights; 
4.3. Buyer's functions: 4.3.1. View a list of all available products; 4.3.2. Adding goods to the cart; 4.3.3. Purchase of goods added to the cart; 4.3.4. Possibility of registration of new users and their authorization; 
4.4. Intuitive user interface and display of products by groups (categories); 
4.5. Maintaining information on all available goods; 
4.6. Recording of all changes in the information data of the system in the format: date and time, the action that was performed, information about the user who performed the operation, the state of the data before and after the change.

5. **Program execution conditions**
   5.1 **Hardware requirements**
- Processor of the Intel Pentium family with a clock frequency of no more than 1.5 GHz, or similar AMD.
- Motherboard with socket LGA 1151 or equivalent for AMD.
- RAM - 3 GB with a clock frequency of not more than 1333 MHz.
- Hard disk requirements - no more than 200 MB.

6. **Software Requirements**
- Operating system Windows 7/8/8.1/10.
- Stable internet connection.

7. **Personnel Requirements**

Requires a system that requires at least one employee to function as an administrator. The number of buyers is unlimited.
# **Technical project**

1. **System design**

![projstructure](https://github.com/backstabslash/1st-year-uni-summerpractice-proj/blob/master/projstructure.png)

*Picture 1 - Project structure*

2. **Data storage format**

![xmlstructure](https://github.com/backstabslash/1st-year-uni-summerpractice-proj/blob/master/xmlstructure.png)

*Picture 2 – XML Data Structure*

![txtstructure](https://github.com/backstabslash/1st-year-uni-summerpractice-proj/blob/master/txtstructure.png)

*Picture 3 – TXT Data Structure*

To store various program data, different XML files are used, which are created and located in the program folder:

2.1. To store key data changes in the program, the “Log.xml” file is used;
2.2. “Basket.xml” is used to store the items selected by the user for purchase;
2.3. To store the current exchange rates of the NBU and CB Privatbank, the files “CurrencyNBU.xml” and “CurrencyPrivat.xml” are used, respectively;
2.4. The file “UserList.xml” is used to store the list of users registered in the system;
2.5. The file “Categories.txt” is used to store a list of all categories;
2.6. To store data about products in a certain category, a file with the name: category name + “.xml” is used.


3. **Technological means**

The programming language C# was chosen for the project. We used API web requests, parsing using XML. Development environment - Microsoft Visual Studio 2019.

4. **Justification for the choice of tools**

C# is a modern object-oriented programming language with a huge number of different libraries containing many useful functions.

XML is a user-friendly markup language with a simple formal syntax that is convenient for both software and humans to create and manipulate documents.

Microsoft Visual Studio is an easy-to-use environment for developing .NET applications with a lot of useful features; Main advantages:

- Fast coding
- Effortless debugging and diagnostics
- Expand and customize according to your preferences
- Effective collaboration

5. **Project structure**

The project contains a number of objects described by classes:

1. Store class:

Performs an administration function in a project. Contains public methods for adding product types, adding and removing categories, purchasing products, and user buying products.

2. Class "User":

Performs an authorization function. Private fields: login, password, boolean variable that reflects the presence of administrator rights. Public methods: saving registration data, checking the entered login and password for existence in the system, checking the login entered by the user during registration for uniqueness, checking for administrator rights, issuing administrator rights.

3. Class "Products":

Contains private fields: product name, price in hryvnia, price in currency, quantity, product category; getters and setters for these fields.

4. Class "Currency":

Gets the current exchange rate using the open API. Private fields: currency code, sell rate, buy rate. Public methods: getting the current dollar rate from various sources and saving it as an XML file, currency conversion.

5. Class "Log":

Keeping a log of changes in important system parameters, such as: the purchase of products by users from the warehouse, the addition and removal of product names in the selected category, the purchase of products of the selected category, the addition and removal of product categories, the change in the profitability factor in the format: “Operation, Date, Time, User , Data state before and after change.

6. Windows Forms interface classes:

In association, represent the user interface. They contain methods for entering information from the keyboard, displaying information on the screen. Provide interaction between the user and the program.


**User's Manual**

When starting the program, the user is greeted with an intuitive interface in which he is asked to either log into his account, or if there is no account yet, then create it; there is a password recovery function. To recover your password, click "Forgot your password?".

Suppose that our user had not yet created an account at the time the program was launched, in which case, he obviously selects the option “Don’t have an account yet?” and sees the registration menu in front of him.

The user is offered a typical form for registering a new account: first, a login is selected, then a password, and an additional password check to avoid possible typos by the user.

After authorization/registration, a user who does not have administrator rights enters the menu for purchasing goods (Fig. 4), where he can select one of the existing categories of goods, then select the product he needs by clicking on it in the list that appears after selecting the category, enter the necessary quantity of goods. Next, click on the "Add to Cart" button.

After performing all the necessary operations and then clicking on the "Add to Cart" button, the cost of the selected product multiplied by the entered quantity will appear on the right; when clicking on the cart icon, the user opens a new menu.

If the user agrees to confirm the payment, then he should click on the appropriate button, if not, then on the "Back" button, after which the basket will be reset to zero, and the user will be redirected to the previous form with the purchase of goods. If the purchase is confirmed, the user will be notified that everything went well with a message akin to “Thank you for your purchase!”.

If the user logs in by entering administrator data (for example, if another administrator grants him such rights), he is greeted by a menu.

Let's go through the administrator's capabilities in order. The first one, starting from the top, will be Adding and Removing Categories. Allows the administrator to add and remove product categories.

The third admin option is "Add products". An extremely useful menu in which the administrator can add new types of products and purchase goods.

The administrator can view the total profit and expenses, as well as find out the profitability of his warehouse.

There is also the possibility of issuing administrator rights to ordinary users, and the possibility of depriving administrators of their rights.

The last item in the admin menu is Activity Log. An extremely useful feature that helps track the actions of all users and changes that occur in the system. Each line stores information about the state of the object being changed before and after making changes, which makes it easy to find the cause of the error if a problem occurs in the system.

**Conclusion**

The created program shows itself perfectly in tests and meets all the requirements of the customer. The program easily performs all tasks, and most importantly, it does it quickly and has very low hardware requirements.
