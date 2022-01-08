# Unity_AR
Version - ```Unity 2021.2.1f1```
##### Modules to this version - 
_Android Build Support_ and _IOS Build Support_  

## Location Based Augment Reality Application 

#### Requaried Unity Packages and Assets:- 
- AR Foundation
- ARCore(android) or ARkit(Apple IOS)
- ARCoreXR Plugin
- LeanTouch (Asset Store - Unity)

### Find all the C# Scripts in Asset/Script folder
Used ```Place_object_on_place.cs``` Script to place the object in place of red marker   
Used ```GPS.cs``` script to extract user's location  
used ```UpdateGPS.cs``` script to edit the informations on the template model according to the location of user.

#### Templete 3D model was build on Vectary.com, fbx files are saved in Asset/Model folder.

### Asset/Prefab contains the game objects(Prefab file) and their configurations.
```Pointer.prefab``` contains red pointer.   
```PrefabToPlace.Prefab``` contains model object.

## How to run this application on Android ?
- Download APK file named ```final.apk``` from Asset/Build Folder to your Android mobile.
- Find the app named ```myAR``` app on your device click on it.
- Face the camera toward building and wait for a ```Red pointer``` to appear.
- Tap on the mobile screen and the 3d object will appear.
- You can zoom and roatate according to your choice.

## Demonstration video:-
Find the full video here: [Full Video](https://drive.google.com/file/d/1Z-iSzs6BN49G9G31YT4J_9UYIz5wyBoj/view) or take a look at the full video in the Demonstration folder.

https://user-images.githubusercontent.com/83028360/148637079-95c08bea-893c-4fc5-9efc-0c0ac75b47e8.mp4

## How to open this Project in Unity ?
- Open ```Github Desktop``` and Clone this repositary.
- Open unity hub and make sure you have the required version and modules for this version.
- Add your cloned repo folder under projects and open it with the required unity version ( ```Unity 2021.2.1f1```)
- Make sure to have packages under required Packages section. (look for it in Window -> Package Manager)
