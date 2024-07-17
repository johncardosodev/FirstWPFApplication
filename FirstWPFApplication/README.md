# First WPF Application

This project is a simple Windows Presentation Foundation (WPF) application that demonstrates basic UI interactions. One of the functionalities includes changing the sign of a number displayed on the application's interface.

## Features

- **Negative Sign Toggle**: Allows the user to toggle the negative sign of the displayed number. If the number is positive, clicking the button will prepend a negative sign to the number, making it negative. If the number is already negative, clicking the button will remove the negative sign, making the number positive.

## Implementation Details

The functionality for toggling the negative sign is implemented in the `MainWindow.xaml.cs` file, within the `BtnNegative_Click` event handler. The logic checks if the displayed number is not zero, then toggles the negative sign based on whether it is already present or not.

### Key Code Snippets

- **Toggling Negative Sign**:
  The application checks if the current display content is not "0". If the display already contains a "-", it removes it, otherwise, it adds a "-" at the beginning of the number.


  
## Getting Started

To run this application, you will need Visual Studio with the WPF App (.NET Framework) project template. Clone the repository, open the solution in Visual Studio, build the project, and run it.

## Contributing

Contributions are welcome. Please open an issue first to discuss what you would like to change or add.

## License

[MIT](https://choosealicense.com/licenses/mit/)
