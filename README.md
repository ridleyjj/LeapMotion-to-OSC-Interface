
# LeapMotion to OSC Unity Project  #

[updated by Jack Ridley 04-06-2022]

This project is an interface application that sends data from a LeapMotion camera to OSC so that it can be connected more easily to other software. I developed this with the express purpose of connection the LeapMotion to Max/MSP and have included a .maxpat file that receives and parses the data.

*This project was made possible by the [UnityOSC Plugin](https://thomasfredericks.github.io/UnityOSC/) made by Thomas Fredericks*

If you are only interested in the interface, then you can just use the .exe in the build folder, however I have also included the full Unity Project to allow for others to tweak the application to their needs.

Here is a quick overview of the Application:
_________________________________________________________________________


## Controls ##
| Function | Key    |
|:--------:|:------:|
|Pause     |spacebar|
|Mute SFX  | s      |
|Toggle HUD| h		  |
|Quit      | Esc		|

## OSC Data Format ##

| Parameter           			  	    | OSC Message Address   		   |
|:---------------------------------:|:----------------------------:|
|Palm XYZ Position   				  	    | /Left_PalmXYZ         		   |
|Finger Tip XYZ Position		  		  | /Left_fingerTip1XYZ   		   |
|Finger Joint 1 XYZ Position	  	  |/Left_finger1Joint1XYZ        |
|Finger Joint 2 XYZ Position	  	  |/Left_finger1Joint2XYZ        |
|Knuckle XYZ Position   				    |/Left_finger1KnuckleXYZ       |
|Palm Velocity XYZ      		  	    |/Left_PalmVelocityXYZ         |
|Pinch Strength, Distance				  	|/Left_Pinch_Strength_Distance |
|Palm Rotation Quaternion XYZW      |/Left_RotationXYZW            |
|Hand Visible										  	|/Left_Active									 |
|Time Since Hand Became Visible (s) |/Left_TimeVisible						 |


## *Notes on OSC Addresses* ##

(replace "Left" for "Right" for data of right hand i.e. "/Right_PalmXYZ")

(for all finger values replace 1 with any number between 1 and 5 for
corresponding finger where thumb = 1 and pinky = 5)

(for fingers, joint 1 is the joint closest to the finger tip, and joint 2
is the joint closest to the knuckle)
_________________________________________________________________________


## Parameter Ranges/Scales ##

|Parameter Type					|Value Range				|
|:---------------------:|:-----------------:|
|X Position Values			|-0.5 to 0.5				|
|Y Position Values			|0.0 to 1.0					|
|Z Position values			|-0.5 to 0.5				|
|X Velocity Values			|-3.0 to 3.0				|
|Y Velocity Values			|-3.0 to 3.0				|
|Z Position values			|-3.0 to 3.0				|
|X Rotation Values			|-0.6 to 0.8				|
|Y Rotation Values			|-1.0 to 1.0				|
|Z Rotation Values			|0.0 to 1.0					|
|W Rotation Values			|0.0 to 1.0					|
|Pinch Strength					|0.0 to 1.0					|
|Pinch Distance					|20.0 to 100.0			|

## *Notes on Value Ranges* ##

These are all approximate ranges determined by my own experimentation,
they are by no means exact - in particular, the velocity values tend to
have a much wider range possible.

From my experience these are the workable ranges for each of the values
however these ranges may be exceeded in the raw data, so be careful when
implementing them. I generally clamp the raw data to these ranges above
in any program that uses them just to be safe, but have left them all raw
here in order to keep the application as versatile as possible.
_________________________________________________________________________
