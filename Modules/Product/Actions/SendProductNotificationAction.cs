namespace WolverineTest.Modules.Product.Actions;

public class SendProductNotificationArgument();

public class SendProductNotificationResult();

public class SendProductNotificationArgumentHandler(ILogger<SendProductNotificationArgumentHandler> logger) : BaseHandler<SendProductNotificationArgument, SendProductNotificationResult>
{
    public override void Before()
    {
        // Validaciones
        logger.LogInformation("***** Before *****");
    }

    public override async Task<SendProductNotificationResult> Handle(SendProductNotificationArgument argument)
    {
        await Task.Delay(3000);
        return new();
    }

    public override void After()
    {
        logger.LogInformation("***** After *****");
    }
}
