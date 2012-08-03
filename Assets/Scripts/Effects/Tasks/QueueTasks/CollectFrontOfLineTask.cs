/// <summary>
/// CollectFrontOfLineTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CollectFrontOfLineTask : QueueTask
{
	public Character CollectedCharacter
	{
		get {	if(_characterIsCollected)
					return _collectedCharacter;
				else
					return null;
										}
	}
	private Character _collectedCharacter = null;
	
	public bool CharacterIsCollected
	{
		get{return _characterIsCollected;}
		set{_characterIsCollected = value;}
	}
	private bool _characterIsCollected = false;
	
	public CollectFrontOfLineTask(CharacterQueue queue) : base (queue)
	{
		//do nothing for now...
	}
	
	public override bool DoTask ()
	{
		if(QTarget.Length == 0)
			return false;
		_collectedCharacter = QTarget.CollectFrontOfLine();
		_characterIsCollected = true;
		TaskHasRun = true;
		return _characterIsCollected;
	}
}
