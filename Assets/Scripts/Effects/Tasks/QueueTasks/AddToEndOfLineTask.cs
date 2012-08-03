/// <summary>
/// AddToEndOfLineTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AddToEndOfLineTask : QueueTask {

	public List<Character> NewCharacters
	{
		get{ return _newCharacters;}
		set{ _newCharacters = value;}
	}	
	private List<Character> _newCharacters = new List<Character>();
	
	public AddToEndOfLineTask(CharacterQueue queue, params Character[] newChar) : base(queue)
	{
		foreach(Character character in newChar)
			_newCharacters.Add (character);
		
	}
	
	public override bool DoTask ()
	{
		//checking
		if(QTarget.Length + NewCharacters.Count > QTarget.MaxLineSize)
			return false;
		
		foreach(Character character in _newCharacters)
			QTarget.AddToEndOfLine(character);
		TaskHasRun = true;
		return true;
	}
	
}
