using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    float nextTimeAttackIsAllowed = -1.0f;

    [SerializeField] float attackDelay = 1.0f;

    [SerializeField] int damageDealt = 5;

    

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && Time.time >= nextTimeAttackIsAllowed)
        {
            Debug.Log("hit");
            Health playerHealth = other.GetComponent<Health>();
            playerHealth.Damage(damageDealt);
            nextTimeAttackIsAllowed = Time.time + attackDelay;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
