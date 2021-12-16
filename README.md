## Simple RazorPage Project

* This project is just a simple RazorPage web application that consist of CRUD process.
* [What is RazorPage?](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-5.0&tabs=visual-studio)


    | No. | Title |
    | ----------- | ----------- |
    | 1 | [Before Create or Run a RazorPage project](#before-create-or-run-a-razorpage-project) |
    | 2 | [How to run RazorPage project](#how-to-run-razorpage-project) |
    | 3 | [How to create RazorPage project](#how-to-create-razorpage-project) |
    | 4 | [Start Code](#start-code) |

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
#### Start Code

12. [Back to Menu](#simple-razorpage-project)



