using System.Reflection;
using System.Resources;

namespace NToolbox.Resources
{
	internal static class Resource
	{
		#region Private Methods
		private static ResourceManager _resourceManager;
		#endregion

		#region Constructor
		static Resource()
		{
			_resourceManager = new ResourceManager("NToolbox.Resources.NToolboxResource", Assembly.GetExecutingAssembly());
		}
		#endregion

		#region Public Static Methods
		public static string GetString(ResourceName name)
		{
			return _resourceManager.GetString(name.ToString());
		}
		#endregion
	}
}