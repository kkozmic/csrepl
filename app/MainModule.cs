namespace CsREPL
{
	public class MainModule : Nancy.NancyModule
	{
		public MainModule()
		{
			Get["/"] = _ => "Hello World!";
		}
	}
}