/*
README

Camera Collision Script
Lylek Games

Hope you enjoy this asset! ;)

CAMERA COLLISION PREFAB:
To use the Camera Collision, simply drag and drop the FocusPoint prefab from the Prefabs folder onto your player. Reset the
transform position to (0, 0, 0) so the FocusPoint is centered on the player. Then adjust the y axis so the pivot point
lies above your players head. You should be good to go!

Positioning the the focus point to the side of your player, along either the x or z axis, may not void obstacles from view of your player.
The FocusPoint should be centered on your player. Make sure the FocusPoint is positioned above any colliders attached to your player, or
mark them as trigger, so they are not mistaken for obstacles or walls.

SCRIPT VARIABLE COMPONENTS:
Focus Point		 	: used as the focal rotation point, and raycast point | must be centered on the player(x and z)
Detection Radius 	: radius detection | used to prevent the camera from peeking through nearby walls
Zoom Intensity	 	: the distance the camera will zoom in and out per scroll
Max Zoom Distance	: used to limit distance you can zoom out, away from your character (maxZoomIn will be limited based on the starting position of the camera)
Masked Tags			: if you have an object you do not wish for the camera to detect, give the object a tag, and add the name of that tag to this list, in the inspector | the object will be ignored

The use of other camera zooming scripts may interfere with the CameraCollision script. Scripts, other than MouseLook, that enable camera angling
should work, so long as they angle the focusPoint and not the camera itself.

If you need any help, please contact:
support@lylekgames.com

Hope you enjoy, and please feel free to leave a rating or review!
Thank you. =)

*******************************************************************************************

Website
http://www.lylekgames.com/

Email
support@lylekgames.com
*/
