
****2023-03-02****
1505
Started assignment 2 in-class in the lab computer
set up the ASP.NET MVC w/ core 3.1 (out of support)
HTTPS enabled,individual account authencation...no Razor...booo!
Reviewed the areas folder, controller,model,view...
AND....
1506 in startup.cs on line 13
removed options for default identity.
option=>option.signIn.RequireConfirmedAccount=true
1510
Tested the app...ran it good...tested links
Action Items:
-Modify the navigation
-update the copyright ...from 'static'to'dynamic':)

1516
modified the default welcome message...tested..
review the route pattern in startup.cs

****2023-02-03*****
1509
clone respository RobinBookStore assignment with github

1545
created README.md file in Github 
AND.....
1550
pull it into visual studio code 2019

****2023-02-09******
start file again 
1415
clone respository RobinBookStore assignment with github

1420- firstly download theme(PULSE) from bootswatch.com
1422- Replace text in  bootstrap.css(www.root/lib/bootstrap/dist/bootstrap.css)
1438- done all changes in _Layout.cshtml(change name bootstrap.min.css to bootstrap.css, change navbar-light to navbar-dark and bg-white to bg-primary, 
remove text-dark in line 23 and add additional properties in footer)

1502-Remove references to 'text-dark' in _LoginPartial.cshtml inside (views/shared)

2005- edit _layout.cshtml file(add link into _layout.cshtml and add dropdown menu div class )
1509- edit_layout.cshtml file
1524- add 3 new projects

******start again(2023-03-23)********
1747- move data folder to  Robinbooks.DataAccess
1751- delete migration folder 
1756- install package in appicationDbContext.cs and delete class1.css from 3 class library
1807-make some changes in ErrorViewModels.cs,startup.cs,Error.cshtml,HomeController.cs
1823- Move Home Controller to customer/contoller and change the root in startup.cs file 
1823- move View/Home folder to customer/views
1831- change namespace in HomeController.cs
1832- move ViewImports.cshtml and viewstart.cshtml to customer
1835-changes in customer/_viewStart.cshtml
1839- add admin into area folder
1840- again move ViewImports.cshtml and viewstart.cshtml to admin
1841- copy Home folder from customer to admin folder
1842- Delete main controller folder

**********2023-03-24*********
1525- changes in appsettings.json file and run nuget package manager(add-migration AddDefaultIdentityMigration)

*********start again 2023-03-30*******
Update database
but i got error
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	Robinbooks.DataAccess	C:\Users\W0802989\source\repos\RobinBookStoreW23\Robinbooks.DataAccess\Migrations\20230324192520_AddDefaultIdentityMigration.Designer.cs	22	Active
Error	CS0006	Metadata file 'C:\Users\W0802989\source\repos\RobinBookStoreW23\Robinbooks.DataAccess\bin\Debug\netcoreapp3.1\Robinbooks.DataAccess.dll' could not be found	RobinBookStore	C:\Users\W0802989\source\repos\RobinBookStoreW23\RobinBookStore\CSC	1	Active
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	Robinbooks.DataAccess	C:\Users\W0802989\source\repos\RobinBookStoreW23\Robinbooks.DataAccess\Migrations\20230324192520_AddDefaultIdentityMigration.Designer.cs	56	Active
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	Robinbooks.DataAccess	C:\Users\W0802989\source\repos\RobinBookStoreW23\Robinbooks.DataAccess\Migrations\20230324192520_AddDefaultIdentityMigration.Designer.cs	145	Active
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	Robinbooks.DataAccess	C:\Users\W0802989\source\repos\RobinBookStoreW23\Robinbooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	20	Active
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	Robinbooks.DataAccess	C:\Users\W0802989\source\repos\RobinBookStoreW23\Robinbooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	54	Active
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	Robinbooks.DataAccess	C:\Users\W0802989\source\repos\RobinBookStoreW23\Robinbooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	143	Active
Message	IDE0052	Private member 'HomeController._logger' can be removed as the value assigned to it is never read	RobinBookStore	C:\Users\W0802989\source\repos\RobinBookStoreW23\RobinBookStore\Areas\Customer\Controllers\HomeController.cs	16	Active
 
 resolve the error in ApplicationDbContextModelSnapshot.cs and AddDefaultIdentityMigration.Designer.cs
 after do update-database
 this eoor happened
 Value cannot be null. (Parameter 'value')
 ****1752***
 final solve the error and update database
 1755 - added new class (Category.cs) in RobinBooks.Models
 1759- modify category.cs class
 add migration AddCategoryToDb in PM console
 1806- ApplicationDbContext.cs
 delete 20230331220604_AdddCategoryToDb.cs
 re-run the add migration AddCategoryToDb in PM console
 update-database
 1813 - Modify 20230331220604_AddCategoryToDb 
 1815- ADDED TWO FOLDER (Repository>IRepository)in the .DataAccess project
 1817- added IRepository.cs interface in IRepository folder and also modify it
 1823- added Repository.cs class in Repository folder 
 then....
 modify it
 1827- added CategoryRepository.cs class in Repository folder
 1828- modify the CategoryRepository.cs class
 1831- added ICategoryRepository.cs Interface in IRepository folder
 1833- modify ICategoryRepository.cs Interface

 1835- added ISP_Call interface in IRepository folder
 1835- created SP_call Class in Repository folder
 1839- Modify both files(ISP_Call interface,SP_Call class)


 1843- created UnitOfWork.cs class in Repository folder
 1843- created IUnitOfWork.cs interface in IRepository folder
 1845- modify UnitOfWork.cs class in Repository folder and IUnitOfWork.cs interface in IRepository folder
 edit startup.cs file

 *****start again(2023-04-06)******
 1414- Add CategoryController.cs inside Area/Admin/Controller
 1422- modify CategoryController.cs

 1428- add Category folder in Areas/Views
 1428- added and modify index.cshtml in Areas/Views/Category folder
 got error



*****Unable to solve the error so, i started project again********
******2023-04-07********