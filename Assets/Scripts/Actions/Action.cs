/// <summary>
/// Action.
/// 
/// Written By Michael LaGrange
/// June 15, 2012
/// </summary>

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Action : MonoBehaviour {

	public string Name
	{
		get { return _name;}
		set { _name = value;}
	}
	private string _name;
	
	public Effect[] EffectList
	{
		get{return _effectList;}
		set{_effectList = value;}
	}
	private Effect[] _effectList;
		

	public void ApplyEffects()
	{
		foreach(Effect effect in _effectList)
			effect.ApplyEffect();
	}
	
	public Character TargetCharacter
	{
		get{return _targetCharacter;}
		set{_targetCharacter = value;}
	}
	private Character _targetCharacter;
	
	public Player TargetPlayer
	{
		get{return _targetPlayer;}
		set{_targetPlayer = value;}
	}
	private Player _targetPlayer;
	
	public int TargetLineLocation
	{
		get {return _targetLocation;}
		set {_targetLocation = value;}
	}
	private int _targetLocation;
	
	
	
	// Use this for initialization
	public virtual void Start () {
	
	}
	
	// Update is called once per frame
	public virtual void Update () {
	
	}
		
		
}
