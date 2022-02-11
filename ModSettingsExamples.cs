using MelonLoader;
using UnityEngine;
using ModUI;
using System;

namespace TownscaperTemplate
{
	public static class ModSettingsExamples
	{
		// Methods used to set arbitrary custom settings
		public static void SetCustomSettings()
		{
			// Set new integer value setting
			int exampleInt = 5;
			MyModUI.myModSettings.SetValueInt("NewIntValue", "ExampleSection", exampleInt);

			// Set new float value setting
			float exampleFloat = 3.14f;
			MyModUI.myModSettings.SetValueFloat("NewFloatValue", "ExampleSection", exampleFloat);

			// Set new bool value setting
			bool exampleBool = true;
			MyModUI.myModSettings.SetValueBool("NewBoolValue", "ExampleSection", exampleBool);

			// Set new keycode value setting
			KeyCode exampleKeyCode = KeyCode.Space;
			MyModUI.myModSettings.SetValueKeyCode("NewKeyCodeValue", "ExampleInputSection", exampleKeyCode);

			// Save all settings to file. Changes are only hold on runtime otherwise.
			// Get's called automatically on closing of the main ModUI sidebar
			MyModUI.myModSettings.SaveToFile();
		}






		// Methods used to retrieve settings
		// Used for UI elements and arbitrary custom settings
		public static void GetAnySettings()
		{		
			// Try to retreive int value from settings
			bool doesExampleIntExistInSettings = MyModUI.myModSettings.GetValueInt("NewIntValue", "ExampleSection", out int exampleInt);			
			if(!doesExampleIntExistInSettings)
			{
				MelonLogger.Msg("Example int does not exist in settings");
			}			
			else
			{
				MelonLogger.Msg("Example int was found: ", exampleInt);
			}

			// Try to retreive float value from settings
			bool doesExampleFloatExistInSettings = MyModUI.myModSettings.GetValueFloat("NewFloatValue", "ExampleSection", out float exampleFloat);
			if (!doesExampleFloatExistInSettings)
			{
				MelonLogger.Msg("Example float does not exist in settings");
			}
			else
			{
				MelonLogger.Msg("Example float was found: ", exampleFloat);
			}

			// Try to retreive bool value from settings
			bool doesExampleBoolExistInSettings = MyModUI.myModSettings.GetValueBool("NewBoolValue", "ExampleSection", out bool exampleBool);
			if (!doesExampleBoolExistInSettings)
			{
				MelonLogger.Msg("Example bool does not exist in settings");
			}
			else
			{
				MelonLogger.Msg("Example bool was found: ", exampleBool);
			}

			// Try to retreive KeyCode value from settings
			bool doesExampleKeyCodeExistInSettings = MyModUI.myModSettings.GetValueKeyCode("NewKeyCodeValue", "ExampleInputSection", out KeyCode exampleKeyCode);
			if (!doesExampleKeyCodeExistInSettings)
			{
				MelonLogger.Msg("Example KeyCode does not exist in settings");
			}
			else
			{
				MelonLogger.Msg("Example KeyCode was found: ", exampleKeyCode.ToString());
			}
		}
	}
}
