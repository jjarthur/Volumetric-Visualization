# Volumetric-Visualization
Unity assets for Volumetric rendering using open source library at https://github.com/brianasu/unity-ray-marching

# Steps to run from scratch
1. Create a new blank project in Unity.
2. Unzip Volumetric Visualization and import all files and folders into the new project's "Assets" folder.
3. Import .TIF volume slices into a new folder within the Assets folder.
4. Inside Unity, select all the volume slices.
    4.1. Check "Read/Write Enabled".
    4.2. Uncheck "Generate Mit Maps".
    4.3. Change "Filter Mode" to "Point (no filter)".
5. Open "scene" located in "Scenes" folder.
6. Select the Main Camera in the hierarchy and click the lock button in the top right above the Inspector panel.
7. In the list of attached components, locate the SECOND Ray Marching script and expand the "Slices" field. Ensure the size is set to 0, then drag and drop all .TIF slices into the field.
8. Make sure the component is enabled, then press play.

# Script list
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

# Other notes
- The first volume rendered has a strange bug where the X axis rotation is inverted and the Y position moves with the camera angle. This is why the first RayMarching component is added with a blank slice.
- 256x256x128 is a good volume resolution for general use as it has a relatively short load time and isn't too pixelated.
- The Volume number in the GUI dropdown refers to the nth Ray Marching component on the Main Camera.