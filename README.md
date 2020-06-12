
# **Parks Lookup**

#### _C# Building an API Independent Project._

#### Made By **Nitun Data_**
#### June 12, 2020

### Description

__An Api for state and national parks of the United States.__

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. Make sure that C#/.netcore2.2 is installed on your computer.
4. Ensure that  MySQL Community Server is installed on your computer.
5. 5. Currently, the mySQL database is set up with an appsettings.json file that was not uploaded to Github.  Once you have saved the SQL database on your computer, create an appsettings.json file in the project root directory, and update it with your MySQL installation information in this format:
```
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=[YOUR PORT     NUMBER HERE];database=[DATABASE NAME AS YOU SAVED IT];uid=YOUR USER ID HERE;pwd=YOUR PASSWORD HERE;"
  }
}
```
6. For launching the program navigate to the _ParksLookup_ directory and run ```dotnet build ```.
7. Then run ```dotnet ef database update```.
8. Finaly,run ```dotnet run``` command in the same directory to to open a live server w/auto updated viewing.Then navigate to localhost:5000/.

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)

### Known Bugs

No bugs have been identified at the time of this update.

### Support and Contact Information

Please contact me with any suggestions or questions at nitun.2@gmail.com. Thank you for your input!  

### Technologies Used

* C#
* ASP.NET Core
* ASP.NET Core MVC
* MySQL
* Entity Framework Core
* Git and GitHub

### Specifications : 
You can test the API directly using an applicaion such as `Postman`. All endpoints use host `localhost:5000`

#### PARKS
|| Spec  | API Endpoint  |
|-| :---------------- | :----- | 
|1| User can READ all parks api call | `GET` /api/parks |
|2| User can READ a certain park | `GET` /api/parks/{id} |
|2| User can SEARCH parks by park name and/or state codes | `GET` /api/parks?parkname=yellowstone |
|3| User can CREATE a new park | `POST` /api/parks |
|4| User can UPDATE a existing park information | `PUT` /api/parks/{id} |
|5| User can DELETE a certain park | `DELETE` /api/parks/{id} |


#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Nitun Datta_**
