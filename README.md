# Guards

Simple .NET parameter guards.

### Usage

Guards can be configured for any input parameters via the static `Guard` class.

```#csharp
    // Guard against null messages and excessive print calls
    public void PrintMessage(string message, int timesToPrint)
    {
        Guard.ThrowIf(nameof(message), message).Null();
        Guard.ThrowIf(nameof(timesToPrint), timesToPrint).GreaterThan(5);
        ...
    }
```
