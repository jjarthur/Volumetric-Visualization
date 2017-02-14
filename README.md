# Volumetric-Visualization
Unity assets for Volumetric rendering using open source library at https://github.com/brianasu/unity-ray-marching

## Controls
- WSAD move camera position.
- Right click + drag to adjust camera angle.
- Left click + drag volume to rotate.
- Shift + left click + drag volume to rotate the forward rotation.
- Ctrl + left click + drag volume to rotate on the right rotation.
- K to screenshot.

## Steps to run from scratch
1. Create a new blank project in Unity.
2. Unzip Volumetric Visualization and import all files and folders into the new project's "Assets" folder.
3. Import .TIF volume slices into a new folder within the Assets folder.
4. Inside Unity, select all the volume slices.
  1. Check "Read/Write Enabled".
  2. Uncheck "Generate Mit Maps".
  3. Change "Filter Mode" to "Point (no filter)".
5. Open "scene" located in "Scenes" folder.
6. Select the Main Camera in the hierarchy and click the lock button in the top right above the Inspector panel.
7. In the list of attached components, locate the SECOND Ray Marching script and expand the "Slices" field. Ensure the size is set to 0, then drag and drop all .TIF slices into the field.
8. Make sure the component is enabled, then press play.

## Steps to change volumes
1. Follow steps 3 and 4 from above to import a new data set into Unity.
2. Select the Main Camera in the hierarchy and click the lock button in the top right above the Inspector panel.
3. In the list of attached components, find the script containing the volume you wish to remove and set the size of the slice array to 0.
  - If you want to add an additional volumes without removing existing ones, click the settings gear of an existing script then copy and paste as new.
4. Drag and drop all .TIF slices from the newly imported data set into the field.
5. Make sure the component is enabled, then press play.

## Steps to deploy build
1. Go to File -> Build Settings.
2. Select "PC, Max & Linux Standalone" and click "Add Open Scenes".
3. Select target platform and set Architecture to "x86".
4. Leave check boxes unchecked and click Build.
5. Name the executable and save it in a new folder.

## Script list
- RayMarching.cs: Handles the main visualization operations.
- SliceMesh.cs: Assists RayMarching.cs with volume visualization.
- Screenshot.cs: Handles screenshots taken by the user.
- Input/ManualGazeControl.cs: Handles input from the user allowing the camera to be controlled with the keyboard and mouse.
- Input/AxisController.cs: Assists ManualGazeControl.cs with camera management.
- Input/ButtonController.cs: Assists ManualGazeControl.cs with camera management.
- Input/RotateObject.cs: Allows an object to be rotated by dragging it around with the mouse. Shift + drag and Ctrl + drag rotate on single axis.
- MeshSlicer/ClassificationUtil.cs: Assists RayMarching.cs with volume visualization.
- MeshSlicer/Intersection.cs: Assists RayMarching.cs with volume visualization.
- MeshSlicer/MeshSlicer.cs: Assists RayMarching.cs with volume visualization.
- MeshSlicer/Triangle3D.cs: Assists RayMarching.cs with volume visualization.
- MeshSlicer/TriangleUtil.cs: Assists RayMarching.cs with volume visualization.
- MeshSlicer/Triangulator.cs: Assists RayMarching.cs with volume visualization.
- UI/CollapseWindow.cs: Hides GUI windows when collapse button is clicked.
- UI/FPSCounter.cs: Adds a FPS counter on the screen to monitor performance.
- UI/MarkerListener.cs: A listener to change the position of the marker on the slice map whenever the value changes.
- UI/SetValueText.cs: Updates the text on the statistics window whenever the values change.
- UI/VolumeSlicer.cs: Adds the functionality for either all or just a single volume to be sliced depending on user selection.

## Other notes
- The first volume rendered has a strange bug where the X axis rotation is inverted and the Y position moves with the camera angle. This is why the first RayMarching component is added with a blank slice.
- 256x256x128 is a good volume resolution for general use as it has a relatively short load time and isn't too pixelated.
- The Volume number in the GUI dropdown refers to the nth Ray Marching component on the Main Camera.
- Rendering more volumes increases the rendering cost.
- Script order matters. Place the script that you want to be rendered last after the rest.

## TO DO list:
- ‘Reset’ button to set objects and player location back to original positions.
- Add support for any number of volumes.
- Allow zooming with mouse wheel.