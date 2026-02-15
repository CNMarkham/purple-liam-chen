using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    public float speed;
    public float attackingDistance;

    private Animator animatorEnemy;
    private Rigidbody rigidbodyEnemy;
    private Transform target;

    [SerializeField]
    private bool isFollowingTarget;

    // private float currentAttackingTime = 0f;
    // private float maxAttackingTime = 2f;

    void Start()
    {
        animatorEnemy = GetComponent<Animator>();
        rigidbodyEnemy = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.LookAt(target.position);
        isFollowingTarget = Vector3.Distance(transform.position, target.position) >= attackingDistance;

        if (isFollowingTarget)
        {
            rigidbodyEnemy.velocity = transform.forward * speed;
        }
        else
        {
            Attack();
        }
        animatorEnemy.SetBool("Walk", isFollowingTarget);
    }

    void Attack()
    {
        rigidbodyEnemy.velocity = Vector3.zero;
    }
}
