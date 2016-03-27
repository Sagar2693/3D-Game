using UnityEngine;
using System.Collections;

public class Animate : MonoBehaviour {
    public Transform goblin_position;
    public Transform enemy_walk;
    private Transform _transform;
    private Transform _transform1;
    private float x;
    private float y;
    private float z;

    private Transform _enemy;

	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this._transform1 = gameObject.GetComponent<Transform>();
     
	
	}
	
	// Update is called once per frame
	void Update () {
      x=this._transform.position.x;

      y = this._transform.position.y;
      z = this._transform.position.z;
       
        
      this._transform1.position = new Vector3(x-0.02f, y,z-0.02f);

	
	}
}
