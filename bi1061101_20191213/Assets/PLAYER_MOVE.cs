using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_MOVE : MonoBehaviour {
#region parameters

    [Header("Moving speed"), Range(0,2000)]
    public float speed = 1.5f;
    [Header("HP amount"), Range(0, 1000)]
    public float hp = 1.5f;

    public Animator anim;
    public RigidBody2D r2D;

    #endregion

    // Use this for initialization
    void Start () {
        r2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
