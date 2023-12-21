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
