using UnrealBuildTool;

public class CLTTarget : TargetRules
{
	public CLTTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CLT");
	}
}
