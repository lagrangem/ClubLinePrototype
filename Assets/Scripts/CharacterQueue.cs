/// <summary>
/// Character queue.
/// Written By Michael LaGrange
/// June 15th, 2012
/// 
///
/// </summary> 

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CharacterQueue  {
	
	public Queue<Character> Line
	{
		get{return _line;}
	}
	private Queue<Character> _line;
	
	public int Length
	{
		get{return _line.Count;}
	}
	
	public int StartingSize
	{
		get{ return _startingSize;}
		set{ _startingSize = value;}
	}
	private int _startingSize;
	
	public int MaxLineSize
	{
		get { return _maxLineSize;}
		set { _maxLineSize = value;}
	}
	private int _maxLineSize;
	
	public Character LastCharacterCollected
	{
		get{ return _lastCharacterCollected;}
	}
	private Character _LastCharacterCollected;
	
	public void Update()
	{
		foreach(Character character in _line)
			character.updateFromLine();
	}
	
	public CharacterQueue(Queue<Character> line, int maxSize = 10000)
	{
		_maxLineSize = maxSize;
		_line = line;
		_startingSize = line.Count;
		_LastCharacterCollected = null;
		
	}
	
	public CharacterQueue(int maxSize = 10000)
	{
		_line = new Queue<Character>();
		_maxLineSize = maxSize;
		_startingSize = 0;
		_LastCharacterCollected = null;
	}
	
	public CharacterQueue(int maxSize = 10000, params Character[] line)
	{
		_maxLineSize = maxSize;
		foreach (Character newChar in line)
		{
			_line.Enqueue(newChar);
		}
		_startingSize = _line.Count;
		_LastCharacterCollected = null;
	}
	
	
	public boolean AddToEndOfLine(Character newChar)
	{
		if(newChar != null && Length < MaxLineSize)
		{
			_line.Enqueue(newChar);
			return true;
		}
		
		System.Console.WriteLine("CharacterQueue: AddToEndOfLine - adding character was either null or exceed maximum line size");
		return false;
	}
	
	public Character CollectFrontOfLine()
	{
		Character front = _line.Dequeue();
		_LastCharacterCollected = front;
		return front;
	}
	
	public bool MoveCharacter(int characterPos, int movePos)
	{
		if(characterPos > _line.Count || movePos > _line.Count)
		{
			System.Console.WriteLine("CharacterQueue: MoveCharacter - one or both positions fall out of bounds");
			return false;
		}
		Character[] characterArray = _line.ToArray();
		Character moveCharacter = characterArray[characterPos];
		
		Queue<Character> returnQ = new Queue<Character>();
		
		int size = _line.Count;
		int characterpointer = 0;
		for(int i = 0; i < size; i++)
		{
			if(i == movePos)
			{
				returnQ.Enqueue(moveCharacter);
			}
			else
			{	
				returnQ.Enqueue(characterArray[characterpointer]);
				characterpointer++;
				if(characterpointer == characterPos) //skip character we moved.
					characterpointer++;
			}
		}
		return true;
	}
	
	public bool RemoveCharacters(params int[] charPos)
	{
		//if any char pos is invalid just bail
		foreach(int pos in charPos)
		{
			if(pos > _line.Count)
			{
				System.Console.WriteLine("CharacterQueue: RemoveCharacters - a character Pos not valid");
				return false;
			}
		}
		Queue<Character> returnQ = new Queue<Character>();		
		int size = _line.Count;
		for(int i = 0; i < size; i++)
		{
			bool flagForRemoval = false;
			foreach(int pos in charPos)
			{
				if(pos == i)
				{
					flagForRemoval = true;
					break;
				}
			}
			if(flagForRemoval)
				_line.Dequeue();
			else
				returnQ.Enqueue(_line.Dequeue());
		}
		_line = returnQ;
		return true;
	}
	
	public bool ReverseLineOrder()
	{
		Queue<Character> returnQ = new Queue<Character>();
		
		Character[] charArray = _line.ToArray();
		
		for(int i = charArray.Length -1; i >= 0; i--)
		{
			returnQ.Enqueue(charArray[i]);	
		}
		_line.Clear();
		_line = returnQ;
		return true;
	}
	
	public bool SwapCharacters(int charPos1, int charPos2)
	{
		if(charPos1 >= _line.Count || charPos2 >= _line.Count)
		{
			System.Console.WriteLine("CharacterQueue: SwapCharacters - one or both positions fall out of bounds");
			return false;
		}
		Character[] charArray = _line.ToArray();
		Queue<Character> returnQ = new Queue<Character>();
		for(int i = 0; i < _line.Count; i++)
		{
			if(i == charPos1)
				returnQ.Enqueue(charArray[charPos2]);
			else if (i == charPos2)
				returnQ.Enqueue(charArray[charPos1]);
			else
				returnQ.Enqueue(charArray[i]);
		}
		_line.Clear();
		_line = returnQ;
		return true;	
	}
}

