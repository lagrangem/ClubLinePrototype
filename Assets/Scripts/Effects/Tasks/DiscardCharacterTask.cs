/// <summary>
/// AddToEndOfLineTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DiscardCharacterTask : QueueTask {
	
	public List<int> DiscardPositions
	{
		get{return _discardPositions;}
		set{_discardPositions = value;}
	}
	private List<int> _discardPositions = new List<int>();
	
	public List<Character> DiscardedCharacters
	{
		get{return _discardedCharacters;}
		set{_discardedCharacters = value;}
	}
	private List<Character> _discardedCharacters = new List<Character>();


	public DiscardCharacterTask(CharacterQueue queue, params int[] position) : base(queue)
	{
		foreach(int pos in position)
			_discardPositions.Add(pos);
	}
	
	
	public override bool DoTask ()
	{
		foreach(int pos in _discardPositions)
		{
			if(pos > QTarget.Length)
			{
				Valid = false;		
				return false;	
			}
		}
		
		Character[] array = QTarget.Line.ToArray();
		
		foreach(int pos in _discardPositions)
			_discardedCharacters.Add(array[pos]);
		
		QTarget.RemoveCharacters(_discardPositions);
		TaskHasRun = true;		
		return true;
	}
}

