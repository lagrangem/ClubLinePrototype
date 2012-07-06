/// <summary>
/// Game manager.
/// Written By Michael LaGrange
/// June 15, 2012
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GameManager : MonoBehaviour {
	//main line ref	
	public QueueManager QMgr
	{
		get{ return _queueMgr;}
	}
	private QueueManager _queueMgr = new QueueManager(new Queue<Character>());
	
	public enum GameState
	{
		TURN_START,
		WAITING_FOR_ACTION,
		HANDLING_TASK,
		CHARACTER_COLLECTION,
		END_OF_TURN,
		PAUSED,
		GAME_START
	};
	
	public int TurnNumber
	{
		get {return _turnNumber;}
		set {_turnNumber= value;}
	}
	private int _turnNumber;
	
	public GameState CurrentState
	{
		get{ return _currentState;}
		set{ _currentState = value;}
	}
	private GameState _currentState;
	
	
	public GameState PreviousState
	{
		get{ return _previousState;}
		set{ _previousState = value;}
	}
	private GameState _previousState;
	
	
	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
