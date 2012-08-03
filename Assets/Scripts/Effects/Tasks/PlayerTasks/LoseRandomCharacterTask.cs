/// <summary>
/// LoseRandomCharacterTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoseRandomCharacterTask : PlayerTask {

	public Character RemovedCharacter
	{
		get{return _removedCharacter;}
	}
	private Character _removedCharacter;
	
	public LoseRandomCharacterTask(Player targetPlayer) : base(targetPlayer)
	{
			
	}
	
	public override bool DoTask ()
	{
		int randomCharLost = Random.Range((int)0, PlayerTarget.Collection.Count);
		_removedCharacter = PlayerTarget.Collection[randomCharLost]; 
		PlayerTarget.Collection.RemoveAt(randomCharLost);
		TaskHasRun = true;
		return true;
	}
	
	
}
