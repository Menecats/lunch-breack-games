using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Entity))]
public class EntityAnimate : MonoBehaviour
{
    private Entity entity;
    private Animator animator;

    void Start()
    {
        entity = GetComponent<Entity>();
        animator = GetComponentInChildren<Animator>();
    }

    void LateUpdate()
    {
        float speedPerc = Mathf.Min(entity.speed / entity.maxSpeed, 1);
        animator.SetFloat("speed", speedPerc);
    }
}
