namespace DesignPatterns.Structural.Proxy
{
	public class ProxyClient
	{
		public void ClientCode(ISubject subject)
		{
			// ... Before
            
			subject.Request();
            
			// ... After
		}
	}
}
