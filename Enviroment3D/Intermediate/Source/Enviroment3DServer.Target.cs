using UnrealBuildTool;

public class Enviroment3DServerTarget : TargetRules
{
	public Enviroment3DServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Enviroment3D");
	}
}
