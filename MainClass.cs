using System;
using System.Windows.Forms;
using log4net;
namespace SwitchNetConfig
{
	/// <summary>
	/// Entry point
	/// </summary>
	public class MainClass
	{
        private static readonly ILog log = LogManager.GetLogger(typeof(MainClass));
		[STAThreadAttribute]
		public static void Main()
		{
            log4net.Config.XmlConfigurator.Configure();
            log.Debug("Starting Network manager...");

            Application.Run( new NetworkAddressManagerForm() );

        }
    }
}
