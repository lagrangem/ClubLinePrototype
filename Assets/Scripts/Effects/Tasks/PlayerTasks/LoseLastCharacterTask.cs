/// <summary>
/// LoseLastCharacterTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoseLastCharacterTask : PlayerTask
{
	public Character RemovedCharacter
	{
		get{return _removedCharacter;}
	}
	private Character _removedCharacter;
	
	public LoseLastCharacterTask(Player targetPlayer) : base(targetPlayer)
	{
			
	}
	
	public override bool DoTask ()
	{
		int charIndex = PlayerTarget.Collection.Count - 1;
		_removedCharacter = PlayerTarget.Collection[charIndex]; 
		PlayerTarget.Collection.RemoveAt(charIndex);
		TaskHasRun = true;
		return true;
	}

}
