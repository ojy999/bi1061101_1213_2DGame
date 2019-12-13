using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_MOVE : MonoBehaviour {
#region parameters

    [Header("Moving speed"), Range(0,2000)]
    public float speed = 1.5f;

    [Header("HP amount"), Range(100, 1000)]
    public float hp = 100;

    [Header("Bullet")]
    public GameObject bullet;

    [Header("ShootAudio")]
    public AudioClip shootAUD;

    [Header("Instantiate Position")]
    public Transform point;

    public float BulletSpeed = 1000f;

    private Animator anim;
    private Rigidbody2D r2D;
    private AudioSource sound;

    
    
    #endregion

    // Use this for initialization
    private void Start () {
        r2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	private void FixedUpdate () {
		Move();
	}

    private void Update()
    {
        Fire();
    }

    private void Move(){

        float controlX = Input.GetAxisRaw("Horizontal");
        //float controly = Input.GetAxisRaw("Vertical");

         r2D.AddForce(new Vector2(speed*controlX,0));
        // r2D.AddForce(new Vector2(0,speed*controly));

        if(controlX != 0){ transform.localScale = new Vector3(controlX,1,1);}

    }

    private void Fire() {

        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            sound.PlayOneShot(shootAUD);
            GameObject pewpewpew = Instantiate(bullet,point.position, Quaternion.identity);
            pewpewpew.GetComponent<Rigidbody2D>().AddForce(new Vector2(BulletSpeed*transform.localScale.x,0));

        }

    }
}
