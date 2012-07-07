/// <summary>
/// SwapCharacterTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SwapCharacterTask : QueueTask {

	public int FirstCharacterPos
	{
		get{return _firstCharacterPos;}
		set{_firstCharacterPos = value;}
	}
	private int _firstCharacterPos = -1;

	public int SecondCharacterPos
	{
		get{return _secondCharacterPos;}
		set{_secondCharacterPos = value;}
	}
	private int _secondCharacterPos = -1;

	public SwapCharacterTask(int charPos1, int charPos2, CharacterQueue queue) : base(queue)
	{
		_firstCharacterPos = charPos1;
		_secondCharacterPos = charPos2;
	}
	
	
	public override bool DoTask ()
	{
		bool success = QTarget.SwapCharacters(FirstCharacterPos, SecondCharacterPos);
	
		TaskHasRun = true;
		return success;
	}
	
}
