## Simple RazorPage Project

* This project is just a simple RazorPage web application that consist of CRUD process.
* [What is RazorPage?](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-5.0&tabs=visual-studio)
* What is [Entity](https://www.entityframeworktutorial.net/what-is-entityframework.aspx) ?


    | No. | Title |
    | ----------- | ----------- |
    | 1 | [Before Create or Run a RazorPage project](#before-create-or-run-a-razorpage-project) |
    | 2 | [How to run RazorPage project](#how-to-run-razorpage-project) |
    | 3 | [How to create RazorPage project](#how-to-create-razorpage-project) |
    | 4 | [Create Database](#create-database) |
    | 5 | [Setup DB connection on project](#setup-db-connection-on-project) |  
    | 6 | [Insert Library](#insert-library) |
    | 7 | [CRUD code](#crud-code) </br> - [View](#view) </br> - [Insert](#insert) </br> - [Update](#update) </br> - [Delete](#delete) |

***
#### Before Create or Run a RazorPage project

1. Install .Net 5.0 sdk first. For this project, we use .Net 5.0. Below is the link for you to download .Net 5.0 :

    - [.Net 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
    
      > ![image](https://user-images.githubusercontent.com/47632993/146304908-0b339b4b-ba01-4e05-9148-58f86baca272.png)
      
2. For database, we gonna use [SQL Express](https://stackify.com/what-is-sql-server-express/) because it is lighweight and suitable for development. Install SQL Express before proceed to the next step. 

    - [SQL Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
    
      > ![image](https://user-images.githubusercontent.com/47632993/146304099-a575aceb-ba9a-42e8-b0d6-c8e90ac52801.png)

3. To manage your SQL infrastructure, we gonna use [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/sql-server-management-studio-ssms?view=sql-server-ver15). It is better for you to download SSMS version 18.5 or lower because upper version 18.6 and more consist of Azure infrastructure. For this project, we will not use Azure infrastructure. Below is the download link for SSMS.

    - [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/release-notes-ssms?view=sql-server-ver15#186)
    
      > ![image](https://user-images.githubusercontent.com/47632993/146304830-cfce19a5-b639-41df-86fd-2688aaffa6c9.png)

4. For code editor, we prefer to use [Visual Studio Code](https://code.visualstudio.com/docs/editor/whyvscode) and not [Visual Studio](https://visualstudio.microsoft.com/). Below is the download link for VS Code :

    - [Visual Studio Code (VS Code)](https://code.visualstudio.com/)
    
      > ![image](https://user-images.githubusercontent.com/47632993/146308637-3c447b02-0834-4ed3-83aa-a6e0effc4d66.png)

    
5. After you finish setup everything. Now you are ready to proceed to create your first RazorPge project or run this project :grin:
6. [Back to Menu](#simple-razorpage-project)


***
#### How to run RazorPage project

1. [Back to Menu](#simple-razorpage-project)


***
#### How to create RazorPage project

1. Open your install VS Code and open VS Code terminal or any terminal that you have.
2. Change to the directory (cd) which will contain the project.
3. Run the following commands :

        dotnet new webapp -o RazorPages
        
4. "RazorPages" is the projects name.
5. After you finish create the project, you can type this commands on terminal to start code :

        code RazorPages

6. After VS Code appear, it will show like this on VS Code.

    > ![image](https://user-images.githubusercontent.com/47632993/146310939-9ea72afe-e09c-4e71-a703-8d22cf3d3f8c.png)

7. You need to trust the HTTPS development certificate by running the following command :

        dotnet dev-certs https --trust
        
8. The preceding command doesn't work on Linux. See your Linux distribution's documentation for trusting a certificate. The preceding command displays the following dialog, provided the certificate was not previously trusted :

    > ![image](https://user-images.githubusercontent.com/47632993/146311181-89c5eaaa-3aa3-4feb-8e79-a82059dc8456.png)

9. Select Yes if you agree to trust the development certificate.
10. For this project we gonna use 2 package that we need to install. On your terminal inside VS Code, you need to type this commands and click enter :
        
        dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.9
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9
        
    > ![image](https://user-images.githubusercontent.com/47632993/146311793-ba7193b2-ce9a-4959-b1d6-2a2d0dcd6cd0.png)

11. After this package has been installed, you can open your RazorPage.csproj and see whether those 2 package has been installed.
    
    > ![image](https://user-images.githubusercontent.com/47632993/146312151-8864070a-1417-4e22-ad4d-0a66fcd505b2.png)

12. [Back to Menu](#simple-razorpage-project)


***
#### Create Database

1. Before we start to code, you need to create a database (DB).
2. You just need to create DB using SSMS that we install earlier.
3. Open your SSMS and create a new DB. ([How to use SSMS](https://docs.microsoft.com/en-us/sql/ssms/quickstarts/ssms-connect-query-sql-server?view=sql-server-ver15))
   > ![image](https://user-images.githubusercontent.com/47632993/146315651-d7d8889c-9e2a-4773-bbc7-33c091e8141a.png)

5. After you have finished create your DB, create table that consists of 5 field such as below and do't forget to <mark>set ID as a Primary Key and as an Identity Column</mark> :
   > ![image](https://user-images.githubusercontent.com/47632993/146315974-c32f54c8-2618-4fcd-9289-642794923642.png)

6. You will get your result like this after you finished create your DB

   > ![image](https://user-images.githubusercontent.com/47632993/146318517-e4625ddf-18c9-417b-bd4b-5e239f46109d.png)

7. [Back to Menu](#simple-razorpage-project)


***
#### Setup DB connection on project

1. On your project, open appsettings.json file and insert this :

    ```        
    "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR SERVER NAME; Database=YOUR DB NAME; Trusted_Connection=True; MultipleActiveResultSets=True;"
      }
    ```    
    
   > ![image](https://user-images.githubusercontent.com/47632993/146317175-83c4535e-9228-401d-9fcc-46416b9cc2f9.png)

2. Save the file.
3. Create a folder name Data and create a new file call DefaultConnection.cs 
   
   > ![image](https://user-images.githubusercontent.com/47632993/146318102-36c6b4ff-1029-4ebf-b1ea-3be40f7acfe5.png)

4. Open DefaultConnection.cs and insert this code :
    
    ```
    using Microsoft.EntityFrameworkCore;
    using RazorPage.Models;

    namespace RazorPage.Data
    {
        public class DefaultConnection : DbContext
        {
            public DefaultConnection (
                DbContextOptions<DefaultConnection> options)
                : base(options)
            {
            }

            public DbSet<Table_Razor_Page> Table_Razor_Page { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Table_Razor_Page>().ToTable("Table_Razor_Page");
            }
        }
    }
    ```
    
5. If you see error with red lines, don't worry, it is just because we didn't finish create some file that will be use by DefaultConnection.cs
6. Create a new folder name Models and create a new file inside it call Table_Razor_Page.cs .This is an Entity Class that we wil use on our project.
    
   > ![image](https://user-images.githubusercontent.com/47632993/146319343-044045bf-e757-455c-8ebc-a6a9b0a6ef89.png)

7. Open Table_Razor_Page.cs and insert this code and you will see the error on DefaultConnection.cs will be gone :

    ```
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace RazorPage.Models
    {
        public class Table_Razor_Page
        {
            [Key]
            public int ID { get; set; }

            [Required(ErrorMessage = "Please insert Name")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Please insert Date of Birth")]
            [DataType(DataType.Date)]
            public DateTime dateOfBirth { get; set; }

            public DateTime dateTimeInsert { get; set; }

            public DateTime dateTimeUpdate { get; set; }
        }
    }
    ```

8. After that, open Startup.cs and insert this code above namespace

       using Microsoft.EntityFrameworkCore;
       using RazorPage.Data;
        
      > ![image](https://user-images.githubusercontent.com/47632993/146323512-5e45b7ff-b42c-40f5-8726-24490c6d7b60.png)

9. Then, insert this code as follows :
        
       services.AddDbContext<DefaultConnection>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
      
      > ![image](https://user-images.githubusercontent.com/47632993/146323705-8f9a2349-c67e-4cda-bd2d-9b3543aba284.png)

10. [Back to Menu](#simple-razorpage-project)


***
#### Insert Library


1. Before we start to code, we need to download library called [Datatable](https://datatables.net/download/), just use default setting when download Datatable. Other than that, we need to download library called [FontAwesome](https://fontawesome.com/v4.7/get-started/).

    > What is [Datatable](https://datatables.net/)?

    > What is [FontAwesome](https://fontawesome.com/v4.7/)?

2. Insert the Datatable library and FontAwesome inside folder lib on wwwroot folder.
   > ![image](https://user-images.githubusercontent.com/47632993/146663424-e2b4257e-0943-4ee4-8d0d-0519adc045d1.png)

3. After that insert this code 
    
       <link rel="stylesheet" type="text/css" href="~/lib/DataTables/datatables.min.css"/>
       <link rel="stylesheet" type="text/css" href="~/lib/font-awesome-4.7.0/css/font-awesome.min.css" />    
       
   inside _Layout.cshtml on
   
   > ![image](https://user-images.githubusercontent.com/47632993/146326780-1329954c-bae1-4b38-81ca-816f3ac477cc.png)
   
   > ![image](https://user-images.githubusercontent.com/47632993/146663387-86f2a3c5-4f82-4e3b-96b1-0f52eddd9dde.png)


4. Then, we need to insert this code
    
        <script src="~/lib/DataTables/datatables.min.js"></script>

    inside  _Layout.cshtml on
    
    > ![image](https://user-images.githubusercontent.com/47632993/146662388-b66cc6a4-0757-45d4-90c1-efd33cd24029.png)

5. [Back to Menu](#simple-razorpage-project)



***
### [CRUD](https://www.sumologic.com/glossary/crud/#:~:text=CRUD%20Meaning%3A%20CRUD%20is%20an,%2C%20read%2C%20update%20and%20delete.) Code


#### View

1. For this project, we gonna use page Index to show one table that consist all data from database table that we have created.
2. Open file Index.cshtml and paste this code :
    
     ```
    @page "{handler?}/{id?}"
    @model IndexModel
    @{
        ViewData["Title"] = "Home page";
    }

    <div class="text-center">
        <h1 class="display-3 mt-3">Simple Razorpage Project</h1>
        <p>This Project consist of Create, Read, Update and Delete process.</p>

        <div class="text-left mt-5 mb-3">
            <a asp-page="/Manage" class="btn btn-primary">Insert</a>
        </div>
        <div>
            <table class="display table table-striped table-bordered table-sm table-condensed">
                <thead>
                    <tr>
                        <th class="text-center col-md-2">NO</th>
                        <th class="text-left col-md-5">NAME</th>
                        <th class="text-center col-md-3">DATE OF BIRTH</th>
                        <th class="text-center col-md-2" colspan="2">ACTION</th>
                    </tr>
                </thead>
                <tbody>
                    @for(int i=0; i<Model.view.Count(); i++)
                    {
                        <tr>
                            <td class="text-center">@i++</td>
                            <td class="text-left">@Model.view[i].Name</td>
                            <td class="text-center">@Model.view[i].dateOfBirth</td>
                            <form id="person" method="post">
                                <td class="text-center">
                                    <button class="btn btn-link" asp-page-handler="Update" asp-route-id="@Model.view[i].ID" type="submit"><i class="fa fa-edit" aria-hidden="true"></i></button>
                                </td>
                                <td class="text-center">
                                    <button class="btn btn-link" asp-page-handler="Delete" asp-route-id="@Model.view[i].ID" type="submit"><i class="fa fa-delete" aria-hidden="true"></i></button>
                                </td>
                            </form>
                        </tr>
                    }
                </tbody>
            </table>
        </div>
    </div>
     ```



3. If you got an error, it is because we still didn't edit the code on controller. Open Index.cshtml.cs and paste this code :
    
     ```
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Threading.Tasks;
        using Microsoft.AspNetCore.Mvc;
        using Microsoft.AspNetCore.Mvc.RazorPages;
        using Microsoft.Extensions.Logging;

        using Microsoft.EntityFrameworkCore;
        using RazorPage.Data;
        using RazorPage.Models;


        namespace RazorPage.Pages
        {
            public class IndexModel : PageModel
            {
                private readonly DefaultConnection _context;

                public IndexModel(DefaultConnection context)
                {
                   _context = context;
                }

                public IList<Table_Razor_Page> view { get; set;}

                public async Task<ActionResult> OnGet()
                {
                    view = await _context.Table_Razor_Page.ToListAsync();

                    if(view==null) 
                    {
                        view = new List<Table_Razor_Page>();
                    }

                    return Page();
                }
            }
        }

     ```
    

4. You can see that all the errors gone. You can try run the web application first to see whether there is error or not. Click FN + F5 on your keyboard or just F5, depends on your keyboard.

6. You can see that there are no rows on the table because we still didn't insert the data; table inside database is still empty.

7. [Back to Menu](#simple-razorpage-project)


#### Insert


7. [Back to Menu](#simple-razorpage-project)
