using MelonLoader;
using UnityEngine;

namespace TownscaperTemplate
{
	public static class MyInput
	{
		public static MelonMod thisMod;
		public static KeyCode myKeycode = KeyCode.None;
		public static void GetInput()
		{
			// Don't accept input before keycodes are loaded from settings
			if(MyModUI.isInitialized)
			{
				if (Input.GetKeyDown(myKeycode))
				{
					MelonLogger.Msg("Input button was pressed!");
				}
			}
		}
	}
}
