
# True_Coach

https://truecoachbigrig.azurewebsites.net/

This app is designed for the everyday user that has a particular fitness goal in mind. 
This app will get a user on the right path to achieve their desired goal. 
The app will provide recommendations for exercises and nutrition to achieve the desired goal. 


### Login Page
![LoginPage](/Assets/TrueCoachApp.jpg) 

### Register Page
![LoginPage](https://github.com/true-coach/True-Coach/blob/master/Assets/Register-Page.PNG)  

### Workout Page
![LoginPage](https://github.com/true-coach/True-Coach/blob/master/Assets/Workout-page.PNG)

### Nutrition Page
![LoginPage](https://github.com/true-coach/True-Coach/blob/master/Assets/Nutrition-page.PNG)  

### Journal Page
![LoginPage](https://github.com/true-coach/True-Coach/blob/master/Assets/Journal-page.PNG)  


## MVC Schema
Here is an image of our MVC schema
![Schema](/Assets/MVCSchema.jpg)  

## API/DB Schema
Here is an image of our API/DB schema
![Schema](/Assets/Schema.jpg)  


###  Profile WireFrame
![WireFrame](/Assets/WireFrame1.jpg)  

### Register WireFrame
![WireFrame](/Assets/WireFrame2.jpg)  

### Workout WireFrame
![WireFrame](/Assets/WireFrame3.jpg)  

### Login WireFrame
![WireFrame](/Assets/WireFrame4.jpg) 

### Journal WireFrame
![WireFrame](/Assets/WireFrame6.jpg)  

## Database Schema breakdown/explination
* User table holds the name of the User and a unique ID for each user. 
* Journal table holds the date time stamp and the journal that user wants to store. 
* Nutrition table holds the goalID and Meals that that user should eat to remain healthy. 
* Meals table has a foreign key reference to Nutrition Id and the name and description of meals. 
* Exercise table has a foreign key reference to WorkoutTypeId in WorkoutTable. It has a description of the exercise and a unique ID. 
* Regeneration table has a unique ID and the regeneratin steps for revival. 
* Workout table holds the workout goals and the workouttype with the reference to the exercise table. 

## Tools used for this project
* i.Visual Studios 2017 or equivalent C# IDE
* ii. Entity Framework CORE
* iii. Microsoft SQL Database.
* iv. NET Core 2.1 SDK
* v. POSTMAN for CRUD operations
* vi. Azure or other online PAAS for hosting.
* vii. Instructions

## Contributors
* Regan Dufort
* Dev Shrestha
* Shalom Belaineh
* Joseph Pumphrey
* Raymond Johnson

## Acknowledgments

* For the Gifs https://giphy.com/
* HowardFreeman Motivation from youtube https://youtu.be/EykWcFEtFqo 
* Bootstrap website
* W3 Schools
* StackOverflow

## Licensing 

This project is licensed under the MIT License

## Software Requirements 
Please read out software requirements
* [Requirements](https://github.com/true-coach/True-Coach/blob/master/Requirements.md)  

