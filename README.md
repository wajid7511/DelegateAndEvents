# DelegateAndEvents in C#

This repository showcases the use of **delegates** and **events** in C#. It includes practical examples to demonstrate their implementation and use cases. Delegates and events are core features of C# that enable event-driven programming and callback methods, making them essential for writing flexible, responsive applications.

## Features

- **Delegates**: Learn how to declare, instantiate, and use delegates.
- **Events**: Understand how to declare events, subscribe to them, and handle event-driven behavior.
- **Practical Examples**: Several scenarios show the implementation of delegates and events in real-world applications.

## Project Structure

- **Program.cs**: Contains examples of delegates and events, including:
  - Using delegates to reference methods.
  - Invoking delegates.
  - Declaring and raising events.
  - Subscribing to and handling events.

## Getting Started

### Prerequisites

- .NET SDK (version 8.0 or later)
- A basic understanding of C# programming

### Running the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/wajid7511/DelegateAndEvents.git
  
2. Navigate to the project directory:
   ```bash
   cd DelegateAndEvents
   ```
3. Run the application:
   ```bash 
    dotnet run
    ```
  
What Are Delegates?
Delegates are a type-safe function pointer in C#. They are used to encapsulate methods and can be passed as parameters. Delegates are particularly useful for defining callback methods.

Example:
   ```bash 
    public delegate void MyDelegate(string message);
    
    public class MyClass
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    } 
    
    MyDelegate del = new MyDelegate(MyClass.PrintMessage);
    del("Hello from delegate!");
```

What Are Events?
Events provide a way for a class to notify other classes when something of interest occurs. Events are built on delegates and are typically used in scenarios where a one-to-many relationship is required between publishers and subscribers.

Example:
   ```bash 
    public class Publisher
    {
        public event EventHandler? OnChange;
    
        public void Change()
        {
            OnChange?.Invoke(this, EventArgs.Empty);
        }
    }
    
    public class Subscriber
    {
        public void OnPublisherChange(object sender, EventArgs e)
        {
            Console.WriteLine("Event triggered");
        }
    }

// Usage
Publisher publisher = new Publisher();
Subscriber subscriber = new Subscriber();
publisher.OnChange += subscriber.OnPublisherChange;
publisher.Change();
```

Contributing
Feel free to fork the repository and submit pull requests if you would like to contribute or suggest improvements.
 