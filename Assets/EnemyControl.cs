using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	// Use this for initialization
    public Animation _anim;
	void Start () {
        this._anim = gameObject.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        _anim.Play("stand_vigilance");
	
	}
}
