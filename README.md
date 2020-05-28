# Procedural

Hey There, do you want to learn how to do Procedural Animation in Unity, but don't know how? So did I, and I am here to explain it.

Im sure you've seen Codeer's youtube video semi-tutorial thing, but if you havent, you should watch it before I start. Heres a link to it: https://www.youtube.com/watch?v=e6Gjhr1IP6w
...It outlines the basic first steps for you to start procedural animation!

So by now you've probably watched the video and are wondering how to do any of that fancy stuff, well, its quite simple, really.
...................................................................................................................................


Step 1: Inverse Kinematics. 

Go to the unity asset store and download Fast IK, a powerful tool you'll need for this. Here is the link to it: https://assetstore.unity.com/packages/tools/animation/fast-ik-139972
Now after you've downloaded and Imported the asset into your project, go into the test/demo scene.

When running the scene, you'll see lots of moving parts and it might look a littlel hectic.

The thing that really did it for me, understanding what the hell was going on that is, was the rotating machine. 

It has a little ball, ,the target, and it has three cubes, like the bones of a finger.

Make sure you pay attention to the heirarchy of the machine to set up your procedural invention correctly.

Once you've studied the item to your satisfaction, open a new scene and create a terrain object as a large plane for testing. Lets start making the procedural machine!

....................................................................................................................................


Step 2: Make the Sphapes

Take your torso or abdomen or whatever you want to call it, and make 4(our however many legs you want to give it) spheres attached to i-t. I put mine like car wheels, because thats how I want to anchor the legs to the body.

Now for the legs, I chose a three bone leg, with spheres in the middle. The heirarchy is organized from the ground up, so like:
Foot -->Lower Joint --> Middle Joint --> Top Joint

Now for the bones, put the Shin Bone brothered( same heirarchy level) with the Lower, the MiddleLegBone brothered with the Middle Joint, and the Femur Bone brothered with the Top Joint

You should arrange them in the arch already, but you don't have to.


Then, Attach the FastIkFabric.cs script (part of the Fast IK asset) to the TopJoint Sphere. Make sure the Chain Length Variable is set to the same amount of leg bones you have.
Set the target to the appropriate sphere attached to the body(you should have made this earlier this step)

....................................................................................................................................

Step 3 + 4: Make a target point attached to the body, using Raycasting

You've probably heard of raycasting, but if you haven't you should maybe read some of Unity's documentation for it. 

First, make an empty game object called BackLeft Hover (or whatever you want to call it, I called it this because it is the back left leg of my being). This will be the starting point of your raycast

Next, make a sphere, can name it appropriately. This will be your ground anchor point for your leg.

In the empty game object, attach or make the script like the one I have, titled RaycastObjecctDownward.cs

The code for it is in the other files.

....................................................................................................................................

Step 5: Check the Distance Between the leg and the raycasted target

This is the second to last step!

In the parent object of your leg, should be the foot, attach the RaycastLegToTarget.cs script.

It explained in the comments of the code.

Assign the target variable to be the raycasted object from the previous step. I added (raycast) to the name of my objects to make them easy to see.

.....................................................................................................................................

Step 6: Move the leg

This is already done in the script you added to the foot in the last scene. You can change the distance variable to whatever you prefer.

To make the legs move opposite one another, I just made the target points raycasted at varying distances from the starting length, but I am going to do it via code later.


