using MelonLoader;

namespace TownscaperTemplate
{
    public class TownscaperTemplateMain : MelonMod
    {		
		

		public override void OnApplicationStart()
		{	
			MelonLogger.Msg("Mod started");
			MyInput.thisMod = this;
		}


		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			if(sceneName == "Placemaker")
			{
				MelonLogger.Msg("Main scene loaded");

				// Initializing ModUI
				MyModUI.Initialize(this);
			}
		}
		
		public override void OnUpdate()
		{
			MyInput.GetInput();			
		}	
	}
}
