using Serilog;

/// Hide the Serilog stuff in here
public class Logger
{
	public Logger()
	{
		var log = new LoggerConfiguration()
			.WriteTo.Console()
			.CreateLogger();

		Log.Logger = log;
		Log.Information("The global logger has been configured");
	}
}
