# GDIM33 Vertical Slice
## Milestone 1 Devlog
1. My visual scripting graph labeled "Movement" serves to control camera and player movement through two On System Event Vector 2 Nodes. There is also a On Event Update, and Sequence node to ensure they play simultaneously. Each set of nodes gets uses the "Get X" and "Get Y" Vector 2 nodes to set up "Transform Rotate" nodes to ensure that the camera and movement work in a 3D space by plugging in the "Get Y" node into the "Z" section of the "Transform Rotate" node. The Camera is set to a "Relative to World" setting in its "Transform Rotate" while the player movement is set to a "Relative to Self" setting to ensure that both are oriented properly. However, I am still having some issues with inverted controls that seem to refuse to resolve despite amything I try.
2. [Updated Breakdown](https://docs.google.com/drawings/d/1NvAUgFmQJYhwPN1YyRDQrk8eTDtNd-WTWk8I6AfkeL0/edit?usp=sharing)
	- My breakdown now  contains a section for future 3D animation (as I am running into some issues currently with setting up a rig for my custom player character) and a section for my current state machine which controls the jump mechanic of my player movement. My State Machine section of my breakdown overviews the main two states of the jump mechanic, the grounded, and in air states. My State Machine is heavily related to my Visual Scripting graph for player movement, and camera movement, as it is yet another available type of movement for players. However, I found it difficult to visually set up jumping without a state machine, which additionally allowed me to prevent double jumping by creating two distinct states.
	- The player input for the spacebar being used to jump, or propel the player into the air, is located within the transition of the state machine through an "On Key Input Event" node. There is additionally a cooldown node of one second attached to the "On Keyboard Input Event" node to prevent double jumping, by ensuring that the player must be in the air for atleast one second before jumping again. The other transition contains an "On Event Update" node that connects to a "Physics Raycast" node that has a "Get Velocity" rigidbody node attached to it to get the velocity of the player. The "Physics Raycast" node is set to check if the layer mask is set to "_isGrounded" and if so then the player is permitted to jump. The state labeled "InAir" contains an "On Enter State Event" node that connects to a "Rigidbody Add Force" node that is set to 5 on the Y-axis as far as force, and is set to the Impulse mode to ensure that the player is propelled into the air.

## Milestone 2 Devlog

### Devlog Question 1
My complicating gameplay feature involves introducing the boss to the game, TacNayn, who the player must defeat at the end of the game, alongside creating beacons to lead the player through the levels, and ultimately, to TacNayn.
1. Create a model and animations for TacNayn.
- This will involve rigging TacNayn outside of the engine as well. I will be using Blender for this.
2. Export his fbx into Unity, and implement his animations.
- To implement his animations, I will need attach an animator component to TacNayn, alongside creating an animator controller for him.
- I will then need to set up his animations to trigger, perhaps requiring a state machine.
3. Create a system that allows the player to defeat NaynCat.
- I will need to create script machines that allows the player to attack TacNayn and that causes TacNayn to die after he is defeated by Nyan Cat (the player).
- I will need to create script machines to trigger the power-ups that I proposed in my vertical slice, and I will need them to trigger Nyan Cat's rainbow to appear to indicate that they have been collected.
- I will need to animate the power-ups in Blender, and implement their animations in Unity.

### Devlog Question 2
The task breakdown allowed me to better map out what I wanted to do for my milestone, and how I wanted to approach my complicating gameplay feature. Writing out the steps made the tasks feel a bit more feasible, as they initially felt a bit out of reach. Though, mapping out steps to begin brainstorming how I may approach the feature gave me more confidence that I may be able to tackle it.

### Devlog Question 3
I bridged coding and visual scripting in my game through the respawn feature of the game that I implemented for this build. First, I wrote my respawn code and labeled the script "Respawn", [here is a screenshot of my code.](https://docs.google.com/drawings/d/1XdRr4Rv_oj_39YCkKe9q4vuXx0DfbjtRLiWgRCFEs1o/edit)
I then made sure that the class was public. Next, I set the threshold for the player to respawn to -5 in the inspector. After ensuring that the player would respawn I decided to trigger the respawn point to change to the last checkpoint (beacon) by creating three more respawn scripts (Respawn 2, Respawn 3, Respawn 4) and called them in my [visual scripting.](https://docs.google.com/drawings/d/1O1c5c4hGcUFf-i7dIwdRYLPQfYHLatiKe3pUqEu2gnc/edit?usp=sharing) to trigger the scripts at each beacon which would change the respawn point to the last beacon reached.


### Devlog Question 4
The Unity System I want to be graded surrounds the implementation of Nyan Cat's and Tac Nayn's 
animations. I coded Nyan Cat's to trigger when the player idles, and when his velocity changes, which causes an additional animation to occur. When the player collects a power-up, Nyan Cat's rainbow now appears as well. I realized after the fact that his animations may be a bit subtle, so the easiest way to differentiate them may be to look and Nyan Cat's legs: if his legs are moving up and down, he is idling, if they are moving forwards and back, he is in motion. For Tac Nayn, a death animation triggers when the player defeats him. I additionally implemented a start game UI to this build as well, I'm not sure as to whether this may count as unity systerm or complicating gamplay feature, but it is new to the game, as I wanted to begin adding UI!


## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
[Platform Tiles - PolyPack](https://assetstore.unity.com/packages/3d/environments/platform-tiles-polypack-209922)
[Real Stars Skybox Lite](https://assetstore.unity.com/packages/3d/environments/sci-fi/real-stars-skybox-lite-116333)\
[GameDev Starter Kit - Platformer [Free Edition]](https://www.fab.com/listings/cd5d54fa-ba2a-48e5-870b-7ca1f8689110)
