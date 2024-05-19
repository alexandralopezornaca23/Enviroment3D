using UnrealBuildTool;

public class Enviroment3DTarget : TargetRules
{
	public Enviroment3DTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Enviroment3D");
	}
}
