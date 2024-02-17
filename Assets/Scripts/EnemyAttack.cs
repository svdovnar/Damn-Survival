using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 25f;
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHItEvent()
    {
        if (target == null) return;
        target.TakeDamage(damage);
        target.GetComponent<DisplayDamage>().ShowDamageCanvas();
    }
}
