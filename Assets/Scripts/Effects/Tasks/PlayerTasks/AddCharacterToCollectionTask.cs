using UnityEngine;
using System.Collections;

public class AddCharacterToCollectionTask : PlayerTask {
	
	public Character AddedChar
	{
		get{return _addedChar;}
	}
	private Character _addedChar;
	
	public AddCharacterToCollectionTask (Player target, Character toAdd, bool collected) : base(target)
	{
		_addedChar = toAdd;
		_collectedChar = collected;
	}
	
	public override bool DoTask ()
	{
		PlayerTarget.Collection.Add(_addedChar);
		if(_collectedChar)
			PlayerTarget.CollectsMade += 1;
		TaskHasRun = true;
		return true;
	}
	
	public bool isACollectedCharacter
	{
		get{return _collectedChar;}
	}
	private bool _collectedChar = true;
}
