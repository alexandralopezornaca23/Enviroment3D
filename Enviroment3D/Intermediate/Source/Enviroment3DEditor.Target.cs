using UnrealBuildTool;

public class Enviroment3DEditorTarget : TargetRules
{
	public Enviroment3DEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Enviroment3D");
	}
}
