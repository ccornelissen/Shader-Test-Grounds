// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Shader_Test_Project : ModuleRules
{
	public Shader_Test_Project(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
                new string[]
                {
                    "Core",
                    "CoreUObject",
                    "Engine",
                    "InputCore",
                    "HeadMountedDisplay",
                    "RHI",
                    "RenderCore",
                    "ShaderCore",
					// ... add other public dependencies that you statically link with here ...
				}
                );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                // ... add private dependencies that you statically link with here ...
            }
            );
    }
}
