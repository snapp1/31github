// Implement exception handler that will output single exception but would take different exceptions in input
// in different formats.
// - Plain text (e.g. “Failed to load resource: the server responded with a status of 404 ()”
// - JSON (e.g. “{ “exceptionType”: “System.NullReferenceException”, “exceptionMessage”:  “Object reference not set to an instance of an object. “} 
// - Minidumps (binary file)
// - there could be more in future

// - Input: Format: string, Data: string
// - Output: OpenTelemetryException { Type: string, Message: string, Stacktrace: string }

public class ExceptionFabric {
    IOpenTelemetryExceptionConverter CreateConcrete(string ConcreteType) {
        switch(ConcreteType){
            case "PlainText":
                return new PlainTextConverter();
            case "Json":
                return new JsonConverter();
        }
    }
}

public class Solution {
    public static void Main(string args[]){
        var type = args[0];
        var exception = args[1];
        ExceptionFabric fabric = new ExceptionFabric();
        IOpenTelemetryExceptionConverter openTelemetryExceptionConverter = fabric.CreateConcrete(type);
        var result = openTelemetryExceptionConverter.Convert(exception);
    }
}


public OpenTelemetryException {
    // Some logic for exception
}

public interface IOpenTelemetryExceptionConverter {
    public OpenTelemetryException Convert(string exception);
}

public PlainTextConverter : IOpenTelemetryExceptionConverter {
    OpenTelemetryException Convert(string exception) {
        //some converter logic
    }
}

public JsonConverter : IOpenTelemetryExceptionConverter {
    OpenTelemetryException Convert(string exception) {
        //some converter logic
    }
}