namespace WSC.WebTextFinder.Core;

public class ServiceLocator {
    private static readonly Dictionary<Type, object> singletons = new();
    private static readonly Dictionary<Type, Func<object>> transients = new();

    public static void RegisterSingleton<TService>(TService service) {
        singletons[typeof(TService)] = service!;
    }

    public static void RegisterTransient<TService>(Func<TService> factory) {
        transients[typeof(TService)] = () => factory()!;
    }

    public static TService Resolve<TService>() {
        return (TService)Resolve(typeof(TService));

    }
    public static object Resolve(Type serviceType) {

        if (singletons.TryGetValue(serviceType, out var singleton)) {
            return singleton;
        }

        if (transients.TryGetValue(serviceType, out var factory)) {
            return factory();
        }

        throw new InvalidOperationException($"Service of type {serviceType.Name} is not registered.");
    }
}
