///////////////////////////////////
/////	  GameEventManager Class
/////		Triage
/////	  by Mike LaGrange
//////////////////////////////////
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//this manages firing game events, as well as managing all object monitoring the various game events.
public class GameEventManager : Mansager
{
	private static Manager gameEventManager = null;
	public static GameEventManager GetManager()
	{
		return Manager.GetInstance(gameEventManager, GetManagerName()) as GameEventManager;
	}

	public static override string GetManagerName()
	{
		return "GameEventManager";
	}

	protected override void Init ()
	{

		base.Init();
	}

	// Update is called once per frame
	private void Update()
	{

	}

	////////////////////////
	// Main Game Phases ///
	////////////////////////

	public delegate void GameStartHandler(IList<Player> players, CharacterQueue characters);
	public event GameStartHandler OnGameStart = delegate {};

	public delegate void DayStartHandler(IList<Player> players, CharacterQueue characters);
	public event DayStartHandler OnDayStart = delegate {};

	public delegate void TurnStartHandler(Player player, int turnNumber);
	public event TurnStartHandler OnTurnStart = delegate {};

	public delegate void ActionPhaseStartHandler(Player player, bool outOfOrder);
	public event ActionPhaseStartHandler OnActionPhaseStart = delegate {};

	public delegate void CollectCharacterPhaseStartHandler(Player player, CharacterQueue characterList);
	public event CollectCharacterPhaseStartHandler OnCollectCharacterPhaseStart = delegate {};

	public delegate void DrawCardPhaseStartHandler(Player player);
	public event DrawCardPhaseStartHandler OnDrawCardPhaseStart = delegate {};

	public delegate void EndOfTurnHandler(Player player );
	public event EndOfTurnHandler OnEndOfTurn = delegate {};

	public delegate void EndOfDayHandler(IList<Player> players, CharacterQueue characters);
	public event EndOfDayHandler OnEndOfDay = delegate {};

	public delegate void GameEndHandler(IList<Player> players, CharacterQueue characters);
	public event GameEndHandler OnGameEnd = delegate {};


	////////////////////////
	// Game Triggers ///
	////////////////////////

	public delegate void ActionPlayedHandler(Player player, Action playedAction, CharacterQueue characters);
	public event ActionPlayedHandler OnActionPlayed = delegate {};

	public delegate void CharacterCollectedHandler(Player player, Character collectedCharacter, CharacterQueue characters);
	public event CharacterCollectedHandler OnCharacterCollected = delegate {};

	public delegate void ActionReadyHandler(Player player, Action regeneratedAction);
	public event ActionReadyHandler OnActionReady = delegate {};
	

}



}

