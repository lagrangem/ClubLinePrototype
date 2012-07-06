/// <summary>
/// Queue manager.
/// 
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class QueueManager {
	
	public CharacterQueue MainLine
	{
		get {return _mainLine;}
//		set {_mainLine = value;}
	}
	private CharacterQueue _mainLine;
	
//	private TaskManager _queueTaskMgr = new TaskManager();
	
	public QueueManager(params Character[] chars)
	{
		Queue<Character> returnQ = new Queue<Character>();
		foreach (Character character in chars)
			returnQ.Enqueue(character);
		initQueue(returnQ);
	}
	
	public QueueManager(Queue<Character> charQ)
	{
		initQueue(charQ);
	}
	
	public void initQueue(Queue<Character> charQ)
	{
		_mainLine = new CharacterQueue(charQ);
	}
	public void Update()
	{
		_mainLine.Update();
	}
}
