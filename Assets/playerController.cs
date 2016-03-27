using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	
   // Use this for initialization
    public Transform flashPoint;
    public GameObject muzzleFlash;
    public AudioClip shoot;
    public GameObject bulletImpact;
    public GameController gameController;

    private Transform _transform;
    private Vector2 _currentPosition;
    //public Animator _animator;
    public GameObject goblin;
    private Animation goblin_animator;


	void Start () {

        this._transform = gameObject.GetComponent<Transform>();
      //  this._animator = gameObject.GetComponent<Animator>();
      //  goblin_animator = goblin.GetComponent<Animation>();
        
       
	}
	
	// Update is called once per frame
	void Update () 
    {
      
        
           
	}
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Instantiate(this.muzzleFlash, flashPoint.position, Quaternion.identity);
           // Instantiate(this.bulletImpact, flashPoint.position, Quaternion.identity);
            RaycastHit hit;
            if (Physics.Raycast(this._transform.position, this._transform.forward, out hit, 50f))
            {
                if(hit.transform.gameObject.CompareTag("Enemy"))

                {
                    Instantiate(this.bulletImpact, hit.point, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                    this.gameController.ScoreValue += 100;
                }
                else
                {
                Instantiate(this.muzzleFlash, hit.point, Quaternion.identity);
                }
            }
        }
    
    }
}
