namespace CsREPL
{
	using Nancy;
	using Nancy.Bootstrapper;
	using Nancy.TinyIoc;

	public class NancyBootstrapper : DefaultNancyBootstrapper
	{
		protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
		{
			base.ApplicationStartup(container, pipelines);
			StaticConfiguration.EnableRequestTracing = true;
			StaticConfiguration.DisableErrorTraces = false;
		}
	}
}