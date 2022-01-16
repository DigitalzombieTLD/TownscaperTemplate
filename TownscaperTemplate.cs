using MelonLoader;


namespace TownscaperTemplate
{
    public class LittleEnvironmentMain : MelonMod
    {		
		public override void OnApplicationStart()
		{	
			MelonLogger.Msg("Mod started");
		}


		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			if(sceneName == "Placemaker")
			{
				MelonLogger.Msg("Main scene loaded");
			}			
		}
		
		public override void OnUpdate()
		{
			MyInput.GetInput();			
		}
	}
}
