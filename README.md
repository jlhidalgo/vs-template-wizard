#vs-template-wizard

The main goal of this project is to explore the idea of creating a Visual Studio extension to automatically generate an item template using IWizard and Windows Forms. This project has only one item template so far, which is `SProcTemplate`. There are no current implementations for a project template under this project, and there are no plans in the near future to implement this type of template.

In this case, the generated template is a `.sql` file that contains Transact-SQL code, which can be used to create or alter a specific stored procedure. 

The intention of using a Windows Form before the template is created, is to allow the user to input some details related to the stored procedure's changes, those details are used to document the changes and to generate the code within the script. 

Some of the above mentioned details are: name of the stored procedure, database name, user story item number, revision number, comments about the changes, etc. 

The result is a database script that not only contains the documentation details, it also contains enough code to create/alter a stored procedure, although, this script has a simple and generic stored procedure body that the developer must replace with some valid code.  And this is exactly the main idea: automate the creation of a database script and generate its documentation so the developer can focus only in the most important matter, which is coding.

### Steps to use the generated Visual Studio Extension
* Download the repository
* Open the project with Visual Studio 2015
* Build the project
* Install the Visual Studio Extension once it is built. The installation is done by double clicking on the generated `.visx` file, which is located within the `bin` folder after the project is built.
* Restart Visual Studio 2015 so the templates are reloaded.
* Create a new SQL Server Database Project. 
* Select the project in the Solution Explorer view, press `Ctrl` + `Shift` + `A` to open the Add New Item dialog.
* Pick up `SProcTemplate` from the SQL Server templates list, then the Stored Procedure Template form is loaded.
* Fill the form data accordingly and click `OK`.
* A `Code1.sql` file is created and added to the project. This new file contains the database script with enough code to create/alter a stored procedure.

### Additional resources

* How to: Use Wizards with Project Templates: https://msdn.microsoft.com/en-us/library/ms185301.aspx
* Starting to Develop Visual Studio Extensions: https://msdn.microsoft.com/en-us/library/bb166030.aspx
