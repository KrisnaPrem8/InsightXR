# InsightXR
Setup Instructions:

Clone the project from github. Open the NatureScene from the Scenes folder, disable replay bool and play. Stop the recording after you have explored the scene. Check the replay bool and play, you should be able to see the heatmap data on the focus points of the player.

Implemented Features:

Heatmap Visualization Development using Particle System Approach
Time dependent heatmap dynamics

Heatmap Implementation: 

To access the logged position and rotation of the VR Camera, we attach a script to the camera gameObject and get its position. 

I have chosen to implement the particle system approach for the visualization of the heatmap data.

We are sending a ray from the camera position and direction and instantiating a particle effect prefab at the hit point of the other collider. This will give us the focus points of the player. 

Now, we destroy this prefab after a limited amount of time to highlight the current focus points.
