using UnrealBuildTool;

public class TheChosenOneTarget : TargetRules
{
	public TheChosenOneTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TheChosenOne");
	}
}
