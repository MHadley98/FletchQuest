using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    private bool attacking = false;

    private float attackTimer = 0;
    private float attackCool = 0.3f;

    public Collider2D attackTrigger;

    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown("E") && !attacking)
        {
            attacking = true;
            attackTimer = attackCool;
        }

        if(attacking)
        {
            if(attackTimer > 0)
            {
                attackTimer -= attackTimer.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }
        }
       
	}
}
