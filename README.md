# Ghost Writer: Key Logger and Screen Capture Utility

This C# application, **Ghost Writer**, is a utility that captures keyboard input and takes screenshots whenever certain keys are pressed. It logs the captured data into a text file and stores screenshots in a designated directory.

## Features

- **Keyboard Logging**: Captures and records keystrokes into a text file.
- **Shift/Caps Lock Tracking**: Detects and adjusts input based on the state of the Shift and Caps Lock keys.
- **Screen Capture**: Takes a screenshot whenever the Enter or Tab key is pressed.
- **Exit Command**: Allows the user to terminate the program by pressing **Shift + Esc**.

## Requirements

- **Operating System**: Windows (due to the use of Windows APIs for keyboard hooking)
- **Framework**: .NET Framework 4.7.2+ or .NET Core 3.1+

## Setup

1. **Compile and Build**:
   - Use Visual Studio or another C# IDE to build the solution.
   - Ensure you have the necessary dependencies for `System.Windows.Forms` and `System.Drawing`.

2. **Run the Program**:
   - After building, run the executable file from the command line or directly from the IDE.

## Usage

1. **Log Files**:
   - A text file named `Text_Data.txt` is created or appended in the current directory.
   - Each recorded keystroke is stored in this file.
  
2. **Screenshot Storage**:
   - A folder named `Image_Data` is created in the current directory.
   - Screenshots are saved as JPEG images with timestamps.

3. **Exit the Program**:
   - Press **Shift + Esc** to terminate the application safely.

## Example Output

1. **Keystroke Logging**:
   - All captured keystrokes are saved in `Text_Data.txt` in real-time.
   - The state of the Shift and Caps Lock keys is tracked, allowing accurate representation of upper/lowercase letters and special characters.

2. **Screenshots**:
   - Saved in the `Image_Data` folder with filenames in the format `MM-DD-YYYY_HH-MM-SS.jpg`.

## Notes

- **Security & Ethical Use**: This tool captures sensitive information. Use it only in a legal and ethical manner, with the explicit consent of the users being monitored.
- **Performance**: While running, the application hooks into low-level keyboard events, which might be flagged as suspicious by antivirus software.

## Dependencies

- **System.Windows.Forms**: For user interface interactions.
- **System.Drawing**: For image creation and processing.
- **Windows APIs**: Used for low-level keyboard hooking and monitoring.

## Limitations

- This program is intended for Windows environments only.
- It may require elevated permissions to set keyboard hooks and create files in certain directories.
