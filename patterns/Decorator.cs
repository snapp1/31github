// The base Component interface
public interface IConfigurationComponent {
    string GetConfiguration();
}

// Concrete Component implementing the base interface
public class BaseConfiguration : IConfigurationComponent {
    public string GetConfiguration() {
        return "Base Configuration";
    }
}

// Decorator Base Class
public abstract class ConfigurationDecorator : IConfigurationComponent {
    protected IConfigurationComponent wrappedComponent;

    public ConfigurationDecorator(IConfigurationComponent component) {
        wrappedComponent = component;
    }

    public virtual string GetConfiguration() {
        return wrappedComponent.GetConfiguration();
    }
}

// Concrete Decorator that adds a specific type of setting
public class NetworkConfigurationDecorator : ConfigurationDecorator {
    public NetworkConfigurationDecorator(IConfigurationComponent component) : base(component) { }

    public override string GetConfiguration() {
        return $"{base.GetConfiguration()}, Network Configuration";
    }
}

// Another Concrete Decorator
public class UserPreferencesDecorator : ConfigurationDecorator {
    public UserPreferencesDecorator(IConfigurationComponent component) : base(component) { }

    public override string GetConfiguration() {
        return $"{base.GetConfiguration()}, User Preferences";
    }
}

class Program {
    static void Main(string[] args) {
        IConfigurationComponent baseConfig = new BaseConfiguration();
        IConfigurationComponent networkConfig = new NetworkConfigurationDecorator(baseConfig);
        IConfigurationComponent userPrefConfig = new UserPreferencesDecorator(networkConfig);

        Console.WriteLine(userPrefConfig.GetConfiguration());
    }
}

// In this implementation:

// IConfigurationComponent is the base interface for all components.
// BaseConfiguration is a concrete component implementing IConfigurationComponent.
// ConfigurationDecorator is an abstract decorator implementing IConfigurationComponent.
// NetworkConfigurationDecorator and UserPreferencesDecorator are concrete decorators that add additional behavior to the base configuration.
// In the Main method, we create a base configuration and then decorate it with network and user preference settings. The flexibility of the Decorator Pattern is shown by how we can stack decorators on top of each other to extend functionality.

// This is a simple example to illustrate the concept. In a real-world scenario, you'd likely have more complex logic and more types of configuration settings.