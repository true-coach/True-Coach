
# True_Coach

This app is designed for the everyday user that has a particular fitness goal in mind. This app will get a user on the right path to achieve their desired goal. The app will provide recommendations for exercises and nutrition to achieve the desired goal. 

https://truecoachbigrig.azurewebsites.net/

![WireFrame](/Assets/TrueCoachApp.jpg)  

## Software Requirements 
Please read out software requirements
* [Requirements](/Requirements.md)  

## How the App Works

1. A user will open the landing page. From there, the user will read about the website and through the reading the user will be directed to register to get started. 

2. Once the user is registered, the user can then proceed to the goal selection page. 

3. On the goal selection page the user will select a workout plan from the drop down that suits their needs.

4. Once a workout plan is selected, a list of suggested potential exercises will be provided for each movement/muscle group. 

5. After the desired goal has been established, the user will then be directed to the appropriate nutrition plan with suggested foods to achieve the desired goal.


## Installation/Usage
1. Clone the repository, open the TrueCoach solution in Visual Studio.
2. Open the TrueCoach.sln solution located in the Async-Inn folder.
3. Run IISExpress to host the webpages locally. The Web Browser should automatically open and redirect you to the Landing Page.
4. Create associated SQL database.
5. Use the API endpoints to conduct operations.
6. Deploy to online web host if desired.

## Testing
* Testing was conducted on each CRUD operation for each specific model. See XunitTesting folder.

The following tests were done:

1. Getters/Setters on all Models

2. Standard CRUD operations on all tables

## Requirements
1.Visual Studios 2017 or equivalent C# IDE
2 Entity Framework CORE
3. Microsoft SQL Database.
4. NET Core 2.1 SDK
5. POSTMAN for CRUD operations
6. Azure or other online PAAS for hosting.
7. Instructions

## Authors
* Regan Dufort
* Dev Shrestha
* Shalom Belaineh
* Joseph Pumphrey
* Raymond Johnson

## Licensing 

This project is licensed under the MIT License

## Acknowledgments

* Bootstrap website
* W3 Schools
* StackOverflow

### Communication plan: How will your group communicate with each other? What is your strategy for ensuring everyone’s voices are heard, and that contributions from both loud and soft voices are listened to? Do you have a plan for managing psychological safety?

* Listen fully and ask each member of the team if diverse input have been solicited. Be open to feedbacks. Invite quite members to speak and contribute. Acknowledge all contributions in a discussion. Before responding paraphrase what you heard. Recognize all contributions, ideas and values. Build on the thoughts and ideas of others.

### Conflict plan: What will your group do when it encounters conflict? What will your process be to resolve it? Paper, Rock, Scissors. 

* Use disagreements as a catalyst for learning. Intervene when someone is being discounted or ignored. If anyone forgot to share ideas during a meeting, send a follow-up email. Develop a team mechanism to address disagreements. Keep a calm demeanor and don’t speak loudly or interrupt. Eliminate distractions and relive time pressures when possible.

### Work plan: How you will identify tasks, assign tasks, know when they are complete, and manage work in general? In particular, make sure you know how you’ll track whether everyone is contributing equally to all parts of the application, and that each person is working on “meaty” problems. What project management tool will be used?

* Due to time constraint, set goals that are attainable. Deploy a working application now, think about CI / CD for continuous improvements. Ensure everyone on the team understands how each person’s role is essential for the team. Align individual contributions and team goals

### Git process: What is your Git flow? How many people must review a PR? Who merges PRs? How often will you merge? How will you communicate that it’s time to merge?

* Two lead developers might be assigned to approve pull requests. The pull request must make improvements and not add to any confusion. The pull request must be agreed upon.

### Anything else you feel is important: expectations around work times, stand-up times(outside of the ones schedule with the instructional team), taking breaks/seeking help when you’re stuck, etc.
* This is a shared document and changes can be applied as needed. 

## Schema
![Schema](/Assets/MVCSchema.jpg)  

## Schema
![Schema](/Assets/Schema.jpg)  

## Tables
* User table holds the name of the User and a unique ID for each user. 
* Journal table holds the date time stamp and the journal that user wants to store. 
* Nutrition table holds the goalID and Meals that that user should eat to remain healthy. 
* Meals table has a foreign key reference to Nutrition Id and the name and description of meals. 
* Exercise table has a foreign key reference to WorkoutTypeId in WorkoutTable. It has a description of the exercise and a unique ID. 
* Regeneration table has a unique ID and the regeneratin steps for revival. 
* Workout table holds the workout goals and the workouttype with the reference to the exercise table. 


## WireFrame
![WireFrame](/Assets/WireFrame1.jpg)  
![WireFrame](/Assets/WireFrame2.jpg)  
![WireFrame](/Assets/WireFrame3.jpg)  
![WireFrame](/Assets/WireFrame4.jpg)  
![WireFrame](/Assets/WireFrame6.jpg)  

