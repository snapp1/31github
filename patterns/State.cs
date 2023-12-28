public interface INotification {
    void Display();
}

public class BasicNotification : INotification {
    private string sender;
    private DateTime timestamp;

    public BasicNotification(string sender, DateTime timestamp) {
        this.sender = sender;
        this.timestamp = timestamp;
    }

    public void Display() {
        Console.WriteLine($"Basic Notification from {sender} at {timestamp}");
    }
}


public class TextNotification : INotification {
    private BasicNotification basicNotification;
    private string textContent;

    public TextNotification(BasicNotification basicNotification, string textContent) {
        this.basicNotification = basicNotification;
        this.textContent = textContent;
    }

    public void Display() {
        basicNotification.Display();
        Console.WriteLine($"Text Content: {textContent}");
    }
}

public class ImageNotification : INotification {
    private BasicNotification basicNotification;
    private string imageUrl;

    public ImageNotification(BasicNotification basicNotification, string imageUrl) {
        this.basicNotification = basicNotification;
        this.imageUrl = imageUrl;
    }

    public void Display() {
        basicNotification.Display();
        Console.WriteLine($"Image URL: {imageUrl}");
    }
}

// Similar state classes for other types of notifications

class Program {
    static void Main(string[] args) {
        INotification basicNotification = new BasicNotification("Alice", DateTime.Now);

        // Transition to a TextNotification state
        INotification textNotification = new TextNotification((BasicNotification)basicNotification, "Hello!");
        textNotification.Display();

        // Transition to an ImageNotification state
        INotification imageNotification = new ImageNotification((BasicNotification)basicNotification, "http://example.com/image.jpg");
        imageNotification.Display();

        // You can easily add more state classes for different notification types
    }
}


