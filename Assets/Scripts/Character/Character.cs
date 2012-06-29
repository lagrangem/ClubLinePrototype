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
	private int _value;

	enum CharacterType
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
	private CharacterType _type;
	
	string getPrefabName(CharacterType charType)
	{
		string returnString;
		switch(charType)
		{
			case SPORTY:
				returnString = "";
				break;
			case HIPSTER:
				returnString = "";
				break;
			case PREPPY:
				returnString = "";				
				break;
			case ROCKER:
				returnString = "";				
				break;
			case GIRLY:
				returnString = "";				
				break;
			case JOCK:
				returnString = "";				
				break;
			case BRO:
				returnString = "";				
				break;
			case NERD:
				returnString = "";
				break;
			case PUNK:
				returnString = "";
				break;
			case MEATHEAD:
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
	private List<Effect> _effectList;
	
	public List<Effect> GetEffectsByTrigger(Effect.Trigger trigger)
	{
		List<Effect> returnList;
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
