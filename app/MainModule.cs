namespace CsREPL
{
	public class MainModule : Nancy.NancyModule
	{
		public MainModule()
		{
			Get["/"] = _ => View["Main.cshtml", new { Message = "Hello World!" }];
		}
	}
}