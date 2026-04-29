# GDIM33 Vertical Slice
## Milestone 1 Devlog
1. My visual scripting graph labeled "Movement" serves to control camera and player movement through two On System Event Vector 2 Nodes. There is also a On Event Update, and Sequence node to ensure they play simultaneously. Each set of nodes gets uses the "Get X" and "Get Y" Vector 2 nodes to set up "Transform Rotate" nodes to ensure that the camera and movement work in a 3D space by plugging in the "Get Y" node into the "Z" section of the "Transform Rotate" node. The Camera is set to a "Relative to World" setting in its "Transform Rotate" while the player movement is set to a "Relative to Self" setting to ensure that both are oriented properly. However, I am still having some issues with inverted controls that seem to refuse to resolve despite amything I try.
2. [Updated Breakdown](https://docs.google.com/drawings/d/1NvAUgFmQJYhwPN1YyRDQrk8eTDtNd-WTWk8I6AfkeL0/edit?usp=sharing)
	- My breakdown now  contains a section for future 3D animation (as I am running into some issues currently with setting up a rig for my custom player character) and a section for my current state machine which controls the jump mechanic of my player movement. My State Machine section of my breakdown overviews the main two states of the jump mechanic, the grounded, and in air states. My State Machine is heavily related to my Visual Scripting graph for player movement, and camera movement, as it is yet another available type of movement for players. However, I found it difficult to visually set up jumping without a state machine, which additionally allowed me to prevent double jumping by creating two distinct states. 

## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
[Platform Tiles - PolyPack](https://assetstore.unity.com/packages/3d/environments/platform-tiles-polypack-209922)
[Real Stars Skybox Lite](https://assetstore.unity.com/packages/3d/environments/sci-fi/real-stars-skybox-lite-116333)
