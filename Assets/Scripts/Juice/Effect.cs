using UnityEngine;
using System.Collections;

public class Effect{

	public Effect(Vector3 position, GameObject effect, float delay){
		GameObject go =  GameObject.Instantiate(effect) as GameObject;
		go.transform.position = position;
		EffectBehaviour eb = go.AddComponent<EffectBehaviour> ();
		eb.SetDelay (delay);
	}

}
