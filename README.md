# Stealth Mode

A lightweight Windows application developed in C# WinForms to help prevent the computer from becoming idle and automatically locking during long-running operations.

The application periodically moves the mouse cursor by one pixel and performs a mouse click within a designated safe area of the screen. This simulates minimal user activity while avoiding unintended interaction with other applications or controls.

## Key Features

Automatic Mouse Movement — Moves the cursor by one pixel at configurable intervals.

Safe Mouse Clicking — Performs clicks within a designated screen area to minimize the risk of triggering unwanted actions.

Configurable Interval — Allows users to specify how frequently the activity is simulated.

Lightweight Operation — Runs in the background with minimal system resource usage.

## Example Use Case

When copying a large file to a network folder, the operation may take a considerable amount of time. Keep Awake simulates periodic user activity to help prevent the computer from becoming idle and locking the screen before the transfer is complete.

Note: The application helps prevent idle-based locking but cannot override organizational security policies, enforced lock timers, or other system restrictions.


## Configuration & Settings

The **Settings** menu allows you to fully customize how actions are recorded, replayed, and how the app behaves:

### Playback Options
* **Interval**: mouse click interval.

### Behavior Options
* **Minimize to System Tray**: Keeps the app running quietly in the system tray when minimized.
* **Minimize on Play / Record**: Automatically minimizes the window when starting recording or playback to avoid blocking the screen.
* **Show Status Overlay**: Displays an on-screen overlay indicating current status (Recording/Playing).
* **Always on Top**: Keeps the app window above all other open windows.
* **Turn Off All Events at [HH:MM]**: Schedule a specific time to automatically stop recording or playback activities.

### Window & Interface
* **Window Title**: Customize the main window title bar text (default: `Activity Recorder`).

##  Support the Project

If you find this tool helpful and it saves you time, consider supporting further development via the **SUPPORT PROJECT** button inside the app.
