using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [SerializeField] float moveSpeed = 5.0f;

    Transform playerModel;
    Rigidbody2D controller;

	// Use this for initialization
	void Start () {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        playerModel = playerGameObject.transform;
        controller = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = playerModel.position - transform.position;
        direction.Normalize();
        Vector2 velocity = direction * moveSpeed;
        controller.velocity = velocity;
	}
}
