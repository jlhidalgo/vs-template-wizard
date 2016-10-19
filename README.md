#vs-template-wizard

The main goal of this project is to explore the idea of creating a Visual Studio extension to generate an item template using IWizard and Windows Forms. This project has only one item template so far, which is `SProcTemplate`. There are no current implementations for a  project template under this project, and there are no plans in the near future to implement this type of template.

The generated template is a `.sql` file that contains Transact-SQL code, that can be used to create or alter a stored procedure. The Windows Form, which is launched by the IWizard implementation, contains some data fields that the user can fill to generate the stored procedure template.

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
* A `Code1.sql` file will be created and added to the project. This file contains the template for the stored procedure.

### Additional resources

* How to: Use Wizards with Project Templates: https://msdn.microsoft.com/en-us/library/ms185301.aspx
* Starting to Develop Visual Studio Extensions: https://msdn.microsoft.com/en-us/library/bb166030.aspx
