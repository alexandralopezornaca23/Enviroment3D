using UnrealBuildTool;

public class Enviroment3DClientTarget : TargetRules
{
	public Enviroment3DClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Enviroment3D");
	}
}
