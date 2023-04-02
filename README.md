# zutari-unity-2023-Dhillan-Gopal

Task 1

Main Menu Scene:

Create a new scene and name it "Main Menu".
In the "Main Menu" scene, create a UI button and position it in the center of the screen.
Attach a script to the button that will load the "Level One" scene when it is clicked.
Test the scene to make sure the button loads the "Level One" scene correctly.

Level One Scene:

Create a new scene and name it "Level One".
Set the camera to 'orthographic' by selecting the camera object and changing its projection to 'orthographic'.
Create a cube and position it in the center of the camera view.
Attach a rigidbody component to the cube to allow it to move with physics.
Write a script that moves the cube up, down, left, and right using the WASD keys.
Use the 'GetComponent' method to get the cube's renderer component and change its color depending on the direction the cube is moving in.
Use the 'OnBecameInvisible' method to detect when the cube goes off-screen and reposition it on the opposite edge of the screen.
Create a UI slider or text input that will allow the player to change the velocity of the cube's movement.
Test the scene to make sure the cube moves in the correct direction, changes color, and reappears on the opposite edge of the screen when it goes off-screen.

Task 2

Open Unity and create a new project.
Create a new scene and name it "WeatherApp".
Create a Canvas and add a Panel to it.
Add a Text component to the Panel and set it to display the weather data.
Sign up for an API key.
Create a new C# script called "WeatherApp".
Add the "WeatherApp" script to the Canvas object.
Test the scene to make sure the weather data is retrieved and displayed on the UI panel.
