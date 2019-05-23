# NewsBubbles-Hololens-App
News app for the Hololens.

# Required client setup

  - Unity 2018.3 version
  - Visual studio code 2017
  - Windows SDK: 10.0.18362 and 10.0.17763.0
  - MRTK toolkit: Microsoft.MixedReality.Toolkit.Unity.Foundation-v2.0.0-RC1-Refresh
  - Hololens 2 emulator (windows Education or pro license needed)

# Unity Setup

1. Clone project folder from GIT
2. open unity project (Newsbubbles-hololens-app) with Unity 2018.3
3. change buildsettings to universal windows platform 
4. change buildsettings to the following:

  -Set scene to = scenes/News Bubbles Hololens
  -Target Device = Hololens
  -Architure = x86
  -Build type = D3D
  -Tarket SDK = 10.0.18362
  -Minimum platform version = 10.0.1763.0 
  -Visual studio version = Visual studio 2017
  -Build and run on = Local machine
  -Build Configuration = Release
  (other settings are standard unity) 
  
 5. Go To Edit-> Project settings -> player -> {windows logo} -> XR settings. and set to the following:
 
  -Virtual reality supported: enabled
  -Depth format : 16 bit depth
  -Enable Depth Buffer sharing : enabled 
  -Sterio rendering mode : single pass instanced
  
  6.  Go to Edit -> quality. below the windows logo click the downward arrow and set to very low.
  
  7. Go to Edit -> editor. set version control, mode to Visible meta files. also set Asset sterilazation to force text.
  
  8. Go to window -> text mesh pro -> import TMP essential resources and import TMP

 9. Go to assets -> import pakage -> custom package -> (select the MRTK unity project) and import all assets
 
10. after the iport go to Mixed reality toolkit and select add to scene and configure. select the default proifle.

With the correcd scene loaded everything should now be ready to develop.

# Building and loading the app in the emulator

1.  within unity go to mixed realty toolkit (see toolbar) -> utilities -> build window. 

2 set the setings to the following:

- build directory: Builds$/WSAPlayer change $ for different output when chaning settings / objects while tot destroying the master file.

- scripting backend (Appx build options) : IL2CPP
- Build Configuration : Master 
- Build platform : x 86

3. select "build Unity project" 

4. After finishing select "open in visual studio" or find the folder in the unity folder (example name.sln)

5 In Vs code 2017 wait till te package is loaded (see bottom part of the screen)

6. in the top part of the screen select: Master, x86, hololens emulator 10.0.18362.1005 and run the solution.

7. Do the following:
  - retry and run in elevated mode
  - click ok to bootstraper alert\
  - wait for the emulator to start 
  - run the solution again to start the app in the emulator
  
 # building the app on a holoLens 
 
 1. Repeat step 1 to 5 from "Building and loading the app in the emulator".
 
 2. in the top part of the screen select: Master, x86 and device 
 
 3. connect the hololens and make sure it is turned on (and accesable form your pc) 
 
 3. Within visual studio code 2017 go to Debug and select start without debugging.
 
 4. wait until the solution is finished (it wil say so in the bottom of Visual studio code 2017) 

 5. when the solution is finished, disconnect the holoLens. the app should have started already or can be launched from the hololens itself.

 # other notes about the development 
