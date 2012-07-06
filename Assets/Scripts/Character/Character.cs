/// <summary>
/// Character.
/// 
/// Written By Michael LaGrange
/// June 15, 2012
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Character : MonoBehaviour {

	public int Value
	{
		get{ return _value;}
		set{_value = value;}
	}
	private int _value = 1;

	public enum CharacterType
	{
		SPORTY,
		HIPSTER,
		PREPPY,
		ROCKER,
		GIRLY,
		JOCK,
		BRO,
		NERD,
		PUNK,
		MEATHEAD
	}	

	public CharacterType type
	{
		get{ return _type;}
		set{ _type = value;}
	}
	private CharacterType _type = CharacterType.SPORTY;
	
	string getPrefabName(CharacterType charType)
	{
		string returnString;
		switch(charType)
		{
			case CharacterType.SPORTY:
				returnString = "";
				break;
			case CharacterType.HIPSTER:
				returnString = "";
				break;
			case CharacterType.PREPPY:
				returnString = "";				
				break;
			case CharacterType.ROCKER:
				returnString = "";				
				break;
			case CharacterType.GIRLY:
				returnString = "";				
				break;
			case CharacterType.JOCK:
				returnString = "";				
				break;
			case CharacterType.BRO:
				returnString = "";				
				break;
			case CharacterType.NERD:
				returnString = "";
				break;
			case CharacterType.PUNK:
				returnString = "";
				break;
			case CharacterType.MEATHEAD:
				returnString = "";			
				break;
			default:
				returnString = "";
				break;
		}
		
		return returnString;
	}
	public GameObject CharacterPrefab
	{
		get { return _characterPrefab;}
		set { _characterPrefab = value;}
	}
	private GameObject _characterPrefab;

	public virtual void updateFromLine()
	{
		
	}
	
	public List<Effect> EffectList
	{
		get{return _effectList;}
	}
	private List<Effect> _effectList = new List<Effect>();
	
	public List<Effect> GetEffectsByTrigger(Effect.Trigger trigger)
	{
		List<Effect> returnList = new List<Effect>();
		foreach(Effect effect in _effectList)
		{
			if(	effect.TriggerType == trigger)
				returnList.Add (effect);
		}
		return returnList;
	}
	
	
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
