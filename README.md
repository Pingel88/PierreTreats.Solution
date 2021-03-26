## <div align="center">Pierre's Sweet and Savory Treats</div>
#### <div align="center">*Epicodus Week 12 C# Project 03/26/2021* </div> 
***<p align="center">By Mike Pingel***</p>
<p align="center">
<img alt="C#" src="https://forthebadge.com/images/badges/made-with-c-sharp.svg"/>
</p>

___
### This project is not in a complete or portfolio ready state, and should not be considered as representation of professional work.
___
## *Description*    
### *An MVC application to manage treats and flavors at Pierre's bakery. Upon being greeted with a splash page, the user can add new treats and flavors as well as view flavors a treat has or view which treats fit a specific flavor. This project utilizes Entity to communicate with a MySQL database that stores treats and flavor data. Anyone can view the data and their relationships but only logged in users authenticated with Identity can create, update, or delete data.*

## *Setup/Installation instructions*
### *From the web*
* Go to the GitHub repository for this project: [https://github.com/Pingel88/PierreTreats.Solution.git](https://github.com/Pingel88/PierreTreats.Solution.git).
* At the top of the repository, click <img src="https://i.imgur.com/Ej9Dphm.png" alt="Code Button" height="20" align="center"> then select "Download ZIP".

  <img src="https://i.imgur.com/tZKvGne.gif" alt="download zip gif" height="200">
* Unzip the file, navigate to the **'PierreTreats'** folder to view code.
### *From the terminal*
* Clone my repository from GitHub using `git clone https://github.com/Pingel88/PierreTreats.Solution.git` in your terminal or GitBash
* Navigate to the downloaded folder using `cd` command
* Execute `code .` command in your terminal and it will open all source code in your code editor.

### ⚠️*Note*⚠️
To run this project locally you will need to have .NET Core and MySQL, follow along with the Epicodus C# setup lessons to verify installation.

###  *View website*
A GitHub page is not available for this project. To view functionality in your browser:
* Create a new database using migration through Entity
  * Navigate to the **'PierreTreats'** folder in your terminal
  * Enter `dotnet ef database update`
* Rename **EDITMEappsettings.json** in the **'PierreTreats'** folder to **appsettings.json**
* Open **appsettings.json** in VS Code or Notepad
  * Enter your password in the DefaultConnection string (replacing `[PASSWORD]`) and save the file
* If not already there, navigate to the **'PierreTreats'** folder in your terminal
* Enter `dotnet run`
* Open your browser and visit http://localhost:5000

## *Technologies used*
* C# 9
* .NET v5.0
* MySQL & MySQL Workbench
* <span>ASP.</span>NET Core MVC
* Entity Framework Core
* Identity
* Razor
* HTML Helper
* REPL
* Git & GitHub

## *Known bugs*
* No known bugs.

## Contact Information
[![Ask Me Anything !](https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg)](mailto:mdpingel+github@gmail.com?subject=[GitHub]Epicodus%20Project%20-%20PierreTreats.Solution)

## *License and copyright*

***© Michael Pingel, 2021***

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)