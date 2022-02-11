using MelonLoader;
using UnityEngine;
using ModUI;
using System;
using TMPro;

namespace TownscaperTemplate
{
	public static class MyModUI
	{
		public static MelonMod myMod;
		public static ModSettings myModSettings;

		public static bool isInitialized;

		public static void Initialize(MelonMod thisMod)
		{
			// Create new ModSettings instance
			//
			// [Argument]			[Type]			[Description]
			// [thisMod]			MelonMod		Reference to your mod instance
			// [ButtonColor]		Color32			Color of main mod button in the UI
			//
			// Return:
			// [Type]				[Description]
			// ModSettings			Newly created ModSettings instance. Used to access most methods.
			//
			// Comment:
			// ModSettings instance should not be created before the main scene "Placemaker" is loaded. 
			// Race conditions need to be observed. When in doubt, check if bool "UIManager.isInitialized" is true
			//
			// Example:
			ModSettings myModSettings = UIManager.Register(thisMod, new Color32(255, 179, 174, 255));


			// Create new button
			//
			// [Argument]			[Type]			[Description]
			// [name]				String			Text on button; also used as identifier; must be unique!!!
			// [section]			String			Menu subsection / Settings section; also used as identifier
			// [buttonColor]		Color32			Color of button
			// [newAction]			Action			Action to call on button press

			// Comment:
			// Action delegate is allowed to be empty, eg. "new Action(delegate {})"				
			//
			// Example:
			myModSettings.AddButton("MyButton", "General", new Color32(255, 179, 174, 255), new Action(delegate { MyButtonActionExample(); }));


			// Create new number slider
			//
			// [Argument]		[Type]			[Description]
			// [name]			String			Name of slider; also used as identifier; must be unique!!!
			// [section]		String			Menu subsection / Settings section; also used as identifier
			// [sliderColor]	Color32			Color of slider
			// [minValue]		Float			Minimum value of slider
			// [maxValue]		Float			Maximum value of slider
			// [wholeNumbers]	Bool			If true, only integer numbers are selectable
			// [defaultValue]	Float			Default value of slider if not present in settings file
			// [newAction]		Action			Action to call value change; usually "new Action<float>(delegate (float value) { MethodToCallOnSliderChange(value); })"
			//
			// Example:
			myModSettings.AddSlider("MySlider", "General", new Color32(145, 241, 10, 255), 1, 10, false, 3, new Action<float>(delegate (float value) { MySliderActionExample(value); }));

			// Create new inputfield
			//
			// [Argument]		[Type]								[Description]
			// [name]			String								Name of inputfield; also used as identifier; must be unique!!!
			// [section]		String								Menu subsection / Settings section; also used as identifier
			// [fieldColor]		Color32								Color of inputfield
			// [contentType]	TMP_InputField.ContentType			Content type enum of inputfield; allows restricted input, eg. only numbers
			// [defaultValue]	String								Default value of inputfield if not present in settings file
			// [newAction]		Action								Action to call on edit end; usually "new Action<string>(delegate (string value) { MethodToCallOnSliderChange(value); })"
			//
			// Example:
			myModSettings.AddInputField("MyInput", "General", new Color32(255, 179, 174, 255), TMP_InputField.ContentType.Alphanumeric, "-", new Action<string>(delegate (string value) { MyInputActionExample(value); }));

			// Create new toggle
			//
			// [Argument]		[Type]								[Description]
			// [name]			String								Name of toggle; also used as identifier; must be unique!!!
			// [section]		String								Menu subsection / Settings section; also used as identifier
			// [toggleColor]	Color32								Color of toggle
			// [defaultValue]	Bool								Default value of toggle if not present in settings file
			// [newAction]		Action								Action to call on edit end; usually "new Action<bool>(delegate (bool value) { MethodToCallOnSliderChange(value); })"
			//
			// Example:
			myModSettings.AddToggle("MyToggle", "General", new Color32(255, 179, 174, 255), true, new Action<bool>(delegate (bool value) { MyToggleActionExample(value); }));

			// Create new keybind field
			//
			// [Argument]		[Type]					[Description]
			// [name]			String					Name of keybind; also used as identifier; must be unique!!!
			// [section]		String					Menu subsection / Settings section; also used as identifier
			// [defaultValue]	UniyEngine.KeyCode		Default value of keybind if not present in settings file
			// [keybindColor]	Color32					Color of keybind
			//
			// Example:
			myModSettings.AddKeybind("MyKeybind", "Input", KeyCode.Space, new Color32(10, 190, 124, 255));

			KeyCode myKeyCode;
			myModSettings.GetValueKeyCode("MyKeybind", "Input", out myKeyCode);
			MyInput.myKeycode = myKeyCode;

			isInitialized = true;
		}

		public static void MyButtonActionExample()
		{
			MelonLogger.Msg("Button was pressed!");
		}

		public static void MySliderActionExample(float value)
		{
			MelonLogger.Msg("Slider value changed to: " + value);
		}

		public static void MyInputActionExample(string value)
		{
			MelonLogger.Msg("Input value changed to: " + value);
		}
		public static void MyToggleActionExample(bool value)
		{
			MelonLogger.Msg("Toggle value changed to: " + value);
		}
	}
}
