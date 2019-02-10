## VISION

The vision of our product is help individuals achieve their desired level of fitness or a fitness goal with time in mind.

### PURPOSE

* The purpose of the app is to provide a roadmap to the desired goal by providing regimented workouts and nutritional guidelines tailored to that goal and time alloted.

### WHY?

* This product will help ensure that users are provided with proven quality content to create and maintain a healthy lifestyle. By utilizing this app, a user is investing in their health for the future. 

## MVC User Stories

* As a new user I want to be able to receive new workouts based on my current goals and have the ability to save it.
* As a user, I want to see regeneration info to be able to have the knowledge to quickly recover from workouts.
* As a user, I want to search for my saved workouts by a saved name so that I can quickly navigate to the workout.
* As a user I want the ability to track days I worked out and the days I missed.
* As a SuperUser I want the ability to add new goals and workouts.


## SCOPE
## IN
1. The web app will give a workout plan based on focus.
2. The web app will provide a nutrition plan based on focus.
3. The web app will allow a user to have a journal to document progress.
4. The user will be able to login with their name.

## OUT
1. The webapp does not provide information about BMI.
2. The webapp does not calculate food intake.
3. The webapp will not show the nearest fitness center near me.

## MVP
1. Have user create a profile username.
2. Allow user to select an Exercise plan based on their focus.
3. Have the ability to journal missed workouts, excuses, or gratitude on a journal page. 
4. Have a nutrition plan given to the user based on their goal.


## STRETCH
* Adding a regeneration page.
* Progress pictures
* Add personal goals for user
* Add height and weight
* Add body fat percentage
* Add personal lift records
* Add calorie calculator


## FUNCTIONAL REQUIREMENTS

1. A user can view detailed information about the workouts.
2. A user can view detailed information about the nutrition plan
3. A user can register
4. A user can create a journal entry

## NON-FUNCTIONAL REQUIREMENTS

Data Integrity: we want to make sure data is always available to users at all times.
Usability: we want to make sure the web app can be used 24/7 without causing any difficulty to the user. 

## DATA FLOW
1. The user will go to the Login/Home page.
2. If the user does not have a login, the user will have to register and make a profile page.
3. The user will then go to the workout page to select a goal/workout plan . These plans include Strength, Lose body fat, quick workouts, and mobility.
4. If Workout is selected,there will be workout informations available from the plans page(Full body, Lower body, Upper body, Core)
5. Based on the user selection each focus options, the user will then navigate to the Nutrition page and select the corresponding nutrition plan.
6. After completing a worout a user can log their worout in the Journal page. 

* The data will be pulled from TruCoachAPI https://truecoachapi.azurewebsites.net. The API is hosted in azure. Additionally the user also be able to create
lists of journal which is stored separately in azure. 
