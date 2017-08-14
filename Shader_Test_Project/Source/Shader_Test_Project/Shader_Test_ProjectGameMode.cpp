// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

#include "Shader_Test_ProjectGameMode.h"
#include "Shader_Test_ProjectCharacter.h"
#include "UObject/ConstructorHelpers.h"

AShader_Test_ProjectGameMode::AShader_Test_ProjectGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
