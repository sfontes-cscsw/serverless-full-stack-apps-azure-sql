namespace GetBusData;

public class GetBusDataFunction
{
    private readonly IBusDataManagerService _busDataManagerService;

    public GetBusDataFunction(
        IBusDataManagerService busDataManagerService) =>
        _busDataManagerService = busDataManagerService;

    [FunctionName(nameof(GetBusData))]
    public async Task GetBusData(
        [TimerTrigger("*/15 * * * * *")] TimerInfo timerInfo) =>
        await _busDataManagerService.ProcessBusDataAsync();

    [FunctionName("HelloWorld")]
    public async Task HelloWorld(
        [TimerTrigger("*/15 * * * * *")] TimerInfo timerInfo) =>
        await _busDataManagerService.HelloWorld();
}
