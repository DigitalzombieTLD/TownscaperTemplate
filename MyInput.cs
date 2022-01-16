using MelonLoader;
using UnityEngine;

namespace TownscaperTemplate
{
	public static class MyInput
	{		
		public static void GetInput()
		{		
			if(Input.GetKeyDown(KeyCode.Space))
			{
				MelonLogger.Msg("Space pressed!");
			}
		}
	}
}
