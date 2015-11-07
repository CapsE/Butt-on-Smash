using UnityEngine;
using System.Collections;

public class Effect{

	public Effect(Transform parent, GameObject effect, float delay){
		GameObject go =  GameObject.Instantiate(effect) as GameObject;
		go.transform.position = parent.position;
		EffectBehaviour eb = go.AddComponent<EffectBehaviour> ();
		eb.SetDelay (delay);
	}

}
