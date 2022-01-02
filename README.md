## Simple RazorPage Project

* This project is just a simple RazorPage web application that consist of CRUD process.
* What is [RazorPage](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-5.0&tabs=visual-studio)?
* What is [CRUD](https://www.sumologic.com/glossary/crud/#:~:text=CRUD%20Meaning%3A%20CRUD%20is%20an,%2C%20read%2C%20update%20and%20delete.)?
* What is [Entity](https://www.entityframeworktutorial.net/what-is-entityframework.aspx)?
* What is [LINQ](https://www.tutorialsteacher.com/linq/what-is-linq)?
* To run RazorPage on VS Code, click FN + F5 or just F5 on your keyboard. It is depends on your keyboard.
</BR>

| NO. | TITLE |
| ----------- | ----------- |
| 1 | [Before Create or Run a RazorPage project](#before-create-or-run-a-razorpage-project) |
| 2 | [How to run RazorPage project](#how-to-run-razorpage-project) |
| 3 | [How to create RazorPage project](#how-to-create-razorpage-project) |
| 4 | [Create Database](#create-database) |
| 5 | [Setup DB connection on project](#setup-db-connection-on-project) |  
| 6 | [Insert Library](#insert-library) |
| 7 | [CRUD code](#crud-code) </br> - [View](#view) </br> - [Insert](#insert) </br> - [Update](#update) </br> - [Delete](#delete) |
</BR>

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
</BR>

***

#### How to run RazorPage project

1. Download this project and open your terminal or VS Code.
2. On your terminal type this command, but first you need to make sure you know where your project folder is. For my case, I put it on my desktop
   
   > ![image](https://user-images.githubusercontent.com/47632993/146669384-e9b4b021-077d-4de5-acc3-e8aced9863b2.png)
    
   ```console 
   code -r RazorPage
   ``` 
   > ![image](https://user-images.githubusercontent.com/47632993/146669328-8036b74d-8c4f-4d94-a030-f4541527451f.png)

3. "RazorPage" name on this command is the folder name of the project. The name is depends on you.
4. System will open the project on your Code Editor.
5. Other than that, by using VS Code, you can just drag project folder on VS Code and and trust the author.     
6. If VS Code authorize you to insert some assets, just click ***Yes/Accept***    
7. [Back to Menu](#simple-razorpage-project)
</BR>

***

#### How to create RazorPage project

1. Open your install VS Code and open VS Code terminal or any terminal that you have.
2. Change to the directory (cd) which will contain the project.
3. Run the following commands :
   
   ```console 
   dotnet new webapp -o RazorPage
   ```
   
4. "RazorPage" is the projects name. The name is depends on you.
5. After you finish create the project, you can type this commands on terminal to start code :

   ```console 
   code RazorPage
   ```
   
6. After VS Code appear, it will show like this on VS Code.

    > ![image](https://user-images.githubusercontent.com/47632993/146310939-9ea72afe-e09c-4e71-a703-8d22cf3d3f8c.png)

7. You need to trust the HTTPS development certificate by running the following command :

   ```console 
   dotnet dev-certs https --trust
   ```     
        
8. The preceding command doesn't work on Linux. See your Linux distribution's documentation for trusting a certificate. The preceding command displays the following dialog, provided the certificate was not previously trusted :

    > ![image](https://user-images.githubusercontent.com/47632993/146311181-89c5eaaa-3aa3-4feb-8e79-a82059dc8456.png)

9. Select Yes if you agree to trust the development certificate.
10. For this project we gonna use 2 package that we need to install. On your terminal inside VS Code, you need to type this commands and click enter :
        
    ```console 
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.9
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9
    ```
        
    > ![image](https://user-images.githubusercontent.com/47632993/146311793-ba7193b2-ce9a-4959-b1d6-2a2d0dcd6cd0.png)

11. After this package has been installed, you can open your RazorPage.csproj and see whether those 2 package has been installed.
    
    > ![image](https://user-images.githubusercontent.com/47632993/146312151-8864070a-1417-4e22-ad4d-0a66fcd505b2.png)

12. [Back to Menu](#simple-razorpage-project)
</BR>

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
</BR>

***

#### Setup DB connection on project

1. On your project, open appsettings.json file and insert this ***(If your server name have slash " \ " , you need to insert double slash like this " \\ " )***:

   ```JSON        
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME; Database=YOUR_DB_NAME; Trusted_Connection=True; MultipleActiveResultSets=True;"
    }
   ```    
    
   > ![image](https://user-images.githubusercontent.com/47632993/146317175-83c4535e-9228-401d-9fcc-46416b9cc2f9.png)

2. Save the file.
3. Create a folder name Data and create a new file call DefaultConnection.cs 
   
   > ![image](https://user-images.githubusercontent.com/47632993/146318102-36c6b4ff-1029-4ebf-b1ea-3be40f7acfe5.png)

4. Open DefaultConnection.cs and insert this code :
    
   ```C#
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
6. Create a new folder name Models and create a new file inside it call Table_Razor_Page.cs .This is an Entity Class that we wil use on our project. You can name this file anything that you want because we just gonna callback the class name inside this file. It is not required to create the file name similar with class name because inside this file, we can include a lot of class and we can callback many class inside this file at similar times.
    
   > ![image](https://user-images.githubusercontent.com/47632993/146319343-044045bf-e757-455c-8ebc-a6a9b0a6ef89.png)

7. Open Table_Razor_Page.cs and insert this code and you will see the error on DefaultConnection.cs will be gone :

   ```C#
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

   ```C#
   using Microsoft.EntityFrameworkCore;
   using RazorPage.Data;
   ```
        
   > ![image](https://user-images.githubusercontent.com/47632993/146323512-5e45b7ff-b42c-40f5-8726-24490c6d7b60.png)

9. Then, insert this code as follows :
        
    ```C#    
    services.AddDbContext<DefaultConnection>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    ```
      
    > ![image](https://user-images.githubusercontent.com/47632993/146323705-8f9a2349-c67e-4cda-bd2d-9b3543aba284.png)

10. [Back to Menu](#simple-razorpage-project)
</BR>

***

#### Insert Library

1. Before we start to code, we need to download library called [Datatable](https://datatables.net/download/), just use default setting when download Datatable. Other than that, we need to download library called [FontAwesome](https://fontawesome.com/v4.7/get-started/).

   > What is [Datatable](https://datatables.net/)?

   > What is [FontAwesome](https://fontawesome.com/v4.7/)?

2. Insert the Datatable library and FontAwesome inside folder lib on wwwroot folder.
   
   > ![image](https://user-images.githubusercontent.com/47632993/146663424-e2b4257e-0943-4ee4-8d0d-0519adc045d1.png)

3. After that insert this code 
    
   ```HTML+Razor 
   <link rel="stylesheet" type="text/css" href="~/lib/DataTables/datatables.min.css"/>
   <link rel="stylesheet" type="text/css" href="~/lib/font-awesome-4.7.0/css/font-awesome.min.css" />   
   ```
       
   inside _Layout.cshtml on
   
   > ![image](https://user-images.githubusercontent.com/47632993/146326780-1329954c-bae1-4b38-81ca-816f3ac477cc.png)
   
   > ![image](https://user-images.githubusercontent.com/47632993/146663387-86f2a3c5-4f82-4e3b-96b1-0f52eddd9dde.png)


4. Then, we need to insert this code
   
   ```HTML+Razor 
   <script src="~/lib/DataTables/datatables.min.js"></script>
   ``` 

   inside  _Layout.cshtml on
    
   > ![image](https://user-images.githubusercontent.com/47632993/146662388-b66cc6a4-0757-45d4-90c1-efd33cd24029.png)

5. [Back to Menu](#simple-razorpage-project)
</BR>

***

### [CRUD](https://www.sumologic.com/glossary/crud/#:~:text=CRUD%20Meaning%3A%20CRUD%20is%20an,%2C%20read%2C%20update%20and%20delete.) Code


#### View

1. For this project, we gonna use page Index to show one table that consist all data from database table that we have created.
2. Open file Index.cshtml and paste this code (remove old code first) :
    
   ```HTML+Razor 
   @page "{handler?}/{id?}"
   @model IndexModel
   @{
       ViewData["Title"] = "Home page";
   }

   <div class="text-center col-md-12">
        <h1 class="display-3 mt-3">Simple Razorpage Project</h1>
        <p>This Project consist of Create, Read, Update and Delete process.</p>

        <div class="text-left mt-5 mb-4">
            <a asp-page="Manage" asp-page-handler="Insert" class="btn btn-primary">Insert</a>
        </div>
        <div>
            <table id="data" class="display table table-striped table-bordered table-sm table-condensed">
                <thead>
                    <tr>
                        <th class="text-center col-md-2">NO</th>
                        <th class="text-left col-md-5">NAME</th>
                        <th class="text-center col-md-3">BIRTH DATE</th>
                        <th class="text-center col-md-2">ACTION</th>
                    </tr>
                </thead>
                <tbody>
                    @for(int i=0; i<Model.view.Count(); i++)
                    {
                        <tr>
                            <td class="text-center"></td>
                            <td class="text-left">@Model.view[i].Name</td>
                            <td class="text-center">@Model.view[i].dateOfBirth.ToShortDateString()</td>
                            <form id="person" method="post">
                                <td class="text-center">
                                    <a class="btn btn-link" asp-page="Manage" asp-page-handler="Update" asp-route-id="@Model.view[i].ID"><i class="fa fa-edit" aria-hidden="true"></i></a>
                                    <button class="btn btn-link text-danger" asp-page-handler="Delete" asp-route-id="@Model.view[i].ID" type="submit"><i class="fa fa-trash" aria-hidden="true"></i></button>
                                </td>
                            </form>
                        </tr>
                    }
                </tbody>
            </table>
        </div>
   </div>

   @section Scripts {
        <script src="~/js/datatable.js"></script>
   }
   ```



3. If you got an error, it is because we still didn't edit the code on controller. Open Index.cshtml.cs and paste this code :
    
   ```C#
   using System.Collections.Generic;
   using System.Threading.Tasks;
   using Microsoft.AspNetCore.Mvc;
   using Microsoft.AspNetCore.Mvc.RazorPages;

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

4. You can see that all the errors are gone.
5. After that, create one file inside js folder and name it datatable.js

   > ![image](https://user-images.githubusercontent.com/47632993/146667756-5c02709e-e6fe-4819-a61b-ad2b3a576866.png)

6. Copy and paste this code inside datatable.js
    
   ```JavaScript
   $(document).ready(function()
   {
        var t = $('#data').DataTable({
            pageLength: 5,
            "lengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "SEMUA"]],
            "order": [[ 1, 'asc' ]],
            "columnDefs": [ 
            {
                "searchable": false,
                "orderable": false,
                "targets": [0],
            },
        ],
        });


        t.on( 'order.dt search.dt', function () {
            t.column(0, {search:'applied', order:'applied'}).nodes().each( function (cell, i) {
                cell.innerHTML = i+1;
            } );
        }).draw(); 
   });
   ```

7. You can try run the web application first to see whether there is error or not. Click FN + F5 on your keyboard or just F5, depends on your keyboard.

6. You can see that there are no rows on the table because we still didn't insert the data; table inside database is still empty.
    
   > ![image](https://user-images.githubusercontent.com/47632993/146668100-a4aefe6b-cbad-497a-92f3-b211497d2e14.png)

8. [Back to Menu](#simple-razorpage-project)
</BR>

#### Insert

1. Create two new file name Manage.cshtml and Manage.cshtml.cs inside folder Pages.

   > ![image](https://user-images.githubusercontent.com/47632993/146664578-37b2f611-4913-4001-8486-877bf496c3b0.png)

3. Open Manage.cshtml and paste this code inside it :

   ```HTML+Razor 
   @page
   @model ManageModel
   @{
        ViewData["Title"] = "Manage";
   }

   <div class="text-center col-md-12">
        <div mt-4> 
            <h1 class="display-4">
                 Insert Data
            </h1>
        </div>
        <div>
            <form method="post">
                <div class="row">
                    <label asp-for="manage.Name" class="col-form-label">Name</label>
                    <input asp-for="manage.Name" class="form-control"/>
                    <span asp-validation-for="manage.Name" class="text-danger"></span>
                </div>
                <div class="row mt-3">
                    <label asp-for="manage.dateOfBirth" class="col-form-label">Birth Date</label>
                    <input asp-for="manage.dateOfBirth" class="form-control" type="date" value="@DateTime.Now.ToShortDateString()"/>
                    <span asp-validation-for="manage.dateOfBirth" class="text-danger"></span>
                </div>
                <div class="row mt-3 ">
                    <a asp-page="/Index" class="btn btn-primary mr-3">Back</a>
                    <button type="submit" class="btn btn-success">Save</button>
                </div>
            </form>
        </div>
   </div>
   
   @section Scripts {
        @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
   }
   ```

4. Then, open Manage.cshtml.cs and paste this code :
    
   ```C#
   using System;
   using System.Threading.Tasks;
   using Microsoft.AspNetCore.Mvc;
   using Microsoft.AspNetCore.Mvc.RazorPages;

   using Microsoft.EntityFrameworkCore;
   using RazorPage.Data;
   using RazorPage.Models;

   namespace RazorPage.Pages
   {
        public class ManageModel : PageModel
        {
            private readonly DefaultConnection _context;
            DateTime now = DateTime.Now;

            public ManageModel(DefaultConnection context)
            {
               _context = context;
            }

            [BindProperty]
            public Table_Razor_Page manage { get; set;}

            public ActionResult OnGet()
            {
                manage = new Table_Razor_Page();

                return Page();
            }

            public async Task<ActionResult> OnPost()
            {
                manage.dateTimeInsert = now;
                manage.dateTimeUpdate = now;

                await _context.Table_Razor_Page.AddAsync(manage);
                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }
        }
   }
   ```
   
5. Run the web application and try insert data and click save. When you finish insert data, you will see the data that you insert on page Index.cshtml.
    
   > ![image](https://user-images.githubusercontent.com/47632993/146668135-fb7ea215-4f42-49f6-87cf-96c0f8521c8d.png)
    
   > ![image](https://user-images.githubusercontent.com/47632993/146668163-b9bb84c2-9065-449d-a1f3-c3d502fed101.png)
  
6. [Back to Menu](#simple-razorpage-project)
</BR>

#### Update

1. To create an update process, we gonna edit some code on Manage.cshtml and Manage.cshtml.cs because we already put a button on Index.cshtml such as this :

   > ![image](https://user-images.githubusercontent.com/47632993/146668442-22051f3e-4959-4d2a-bfd4-3c91a94b6ec8.png)

2. Open Manage.cshtml and edit the code like this :
    
   ```HTML+Razor 
   @page "{handler?}/{id?}"
   @model ManageModel
   @{
        ViewData["Title"] = "Manage";
   }

   <div class="text-center col-md-12">
        <div mt-4> 
            <h1 class="display-4">
                @if(Model.IsNull==true)
                {
                    <span>Insert</span> 
                }
                else
                {
                    <span>Update</span>     
                }
                Data
            </h1>
        </div>
        <div>
            <form method="post">
                <input asp-for="manage.ID" type="hidden"/>
                <div class="row">
                    <label asp-for="manage.Name" class="col-form-label">Name</label>
                    <input asp-for="manage.Name" class="form-control"/>
                    <span asp-validation-for="manage.Name" class="text-danger"></span>
                </div>
                <div class="row mt-3">
                    <label asp-for="manage.dateOfBirth" class="col-form-label">Birth Date</label>
                    @if(Model.IsNull==true)
                    {
                        <input asp-for="manage.dateOfBirth" class="form-control" type="date" value="@DateTime.Now.ToShortDateString()"/>
                    }
                    else
                    {
                        <input asp-for="manage.dateOfBirth" class="form-control" type="date" />
                    }
                    <span asp-validation-for="manage.dateOfBirth" class="text-danger"></span>
                </div>
                <div class="row mt-3 ">
                    <a asp-page="/Index" class="btn btn-primary mr-3">Back</a>
                    @if(Model.IsNull==true)
                    {
                        <button asp-page-handler="Insert" type="submit" class="btn btn-success">Save</button>
                    }
                    else
                    {
                        <button asp-page-handler="Update" type="submit" class="btn btn-success">Update</button>
                    }
                </div>
            </form>
        </div>
   </div>

   @section Scripts {
        @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
   }
   ```

3. After that, open Manage.cshtml.cs and edit the code like this :

   ```C#
   using System;
   using System.Threading.Tasks;
   using Microsoft.AspNetCore.Mvc;
   using Microsoft.AspNetCore.Mvc.RazorPages;

   using Microsoft.EntityFrameworkCore;
   using RazorPage.Data;
   using RazorPage.Models;

   namespace RazorPage.Pages
   {
        public class ManageModel : PageModel
        {
            private readonly DefaultConnection _context;
            DateTime now = DateTime.Now;

            public ManageModel(DefaultConnection context)
            {
               _context = context;
            }

            [BindProperty]
            public Table_Razor_Page manage { get; set;}

            public Table_Razor_Page update { get; set;}

            public bool IsNull { get; set; }

            public ActionResult OnGetInsert()
            {
                IsNull = true;
                manage = new Table_Razor_Page();

                return Page();
            }

            public async Task<ActionResult> OnGetUpdate(int? id)
            {
                if(id==null || id==0)
                {
                    return RedirectToPage("Index");
                }
                else if(id!=null && id!=0)
                {
                    IsNull = false;
                    manage = await _context.Table_Razor_Page.FirstOrDefaultAsync(x=>x.ID==id);
                }

                return Page();
            }

            public async Task<ActionResult> OnPostInsert()
            {
                manage.dateTimeInsert = now;
                manage.dateTimeUpdate = now;

                await _context.Table_Razor_Page.AddAsync(manage);
                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }

            public async Task<ActionResult> OnPostUpdate()
            {
                update = await _context.Table_Razor_Page.FirstOrDefaultAsync(x=>x.ID==manage.ID);
                update.Name=manage.Name;
                update.dateOfBirth=manage.dateOfBirth;
                update.dateTimeUpdate = now; 

                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }
        }
   }
   ```
    
4. Run your web app and click edit button on table.
    
   > ![Screenshot 2021-12-19 163123](https://user-images.githubusercontent.com/47632993/146668631-c41d6747-5400-4776-9a96-ee65a25d94ba.png)

5. Manage page will be open and you can see that the title is change and button also change.

   > ![image](https://user-images.githubusercontent.com/47632993/146668651-d11c9775-4fb4-43fb-b7cc-c9d1ffbf606a.png)

6. Edit the data as you like and click update button.
7. Web app will redirect to page Index and as you can see, the data changed.
8. [Back to Menu](#simple-razorpage-project)
</BR>

#### Delete

1. For this process we gonna edit the code inside Index.cshtml.cs. It is because we already include the code on Index.cshtml such as below :

   > ![image](https://user-images.githubusercontent.com/47632993/146669030-9632709d-1ade-4616-960b-89b887da31a7.png)

2. Open Index.cshtml.cs and paste this code :

   > ![image](https://user-images.githubusercontent.com/47632993/146669524-066253da-d718-4eda-9495-7c74d1e3d4ac.png)
    
   ```C#
   public Table_Razor_Page delete { get; set;}
   ```

3. Paste this code below OnGet method.
    
   >![image](https://user-images.githubusercontent.com/47632993/146669052-7ccb0b0c-0837-4b78-853a-4defdbb78dd2.png)

   ```C#
   public async Task<ActionResult> OnPostDelete(int id)
   {
        delete = await _context.Table_Razor_Page.FirstOrDefaultAsync(x=>x.ID==id);
        _context.Table_Razor_Page.Remove(delete);

        await _context.SaveChangesAsync();

        return RedirectToPage();
   }
   ```
   
4. Run your application and try delete the data that you already insert before by clicking the delete button on the table.
    
   > ![image](https://user-images.githubusercontent.com/47632993/146669091-fb907269-437b-4076-a91b-049e3ef17009.png)

5. As you can see the data that you delete already gone.
6. [Back to Menu](#simple-razorpage-project)
