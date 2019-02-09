## VISION

The vision of our product is help individuals achieve their desired level of fitness or a fitness goal with time in mind.

PURPOSE

The purpose of the app is to provide a roadmap to the desired goal by providing regimented workouts and nutritional guidelines tailored to that goal and time alloted.

WHY?

This product will help ensure that users are provided with proven quality content to create and maintain a healthy lifestyle. By utilizing this app, a user is investing in their health for the future. 

## SCOPE
## IN
The web app will give a plan based on workout focus.
The web app will provide a plan based on nutrition focus.
The web app will allow a user to have a journal to document progress.

## OUT
The webapp does not provide information about BMI.
The webapp does not calculate food intake.


## MVP
Create user profile with a username.
Allow user to select an Exercise plan based on their focus.
Have the ability to journal missed workouts, excuses or gratitude on a journal page. 
Have a nutrition plan given to the user based on their goal.


## STRETCH
Adding a regeneration page.
Add users to the users page 
Add progress pictures
Add personal goals for user
Add height and weight
Add body fat percentage
Add personal lift records
Add calorie calculator


## FUNCTIONAL REQUIREMENTS

1. A user can view Detail Information about the workout.
2. A user can Save favorite workout.
3. A user can identify

## NON-FUNCTIONAL REQUIREMENTS

Data Integrity: we wanna make sure  data is always available when needed or requested.
Usability: we want to make sure the web app is used 24/7 without causing any difficulty to the user. 

## DATA FLOW
1. The user will get the Login page.
2. The second page has the Focus page where user gets to choose the workout plan and has the description(Strength, lose bf, quick workouts, mobility).
3. Based on the user selection each Focus options refer to either workout page or Nutrition page.
4.If Workout is selected,there will be workout informations available from the plans page(Full body, Lower body, Upper body, Core)
5.If Nutrition is selected there are options available to choose from that helps determine your Nutrition.

* The data will be pulled from TruCoachAPI https://truecoachapi.azurewebsites.net. The API is hosted in azure. Additionally the user also be able to create
lists of journal which is stored separately in azure. 