using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemieClass : MonoBehaviour
{
    public float HP;
    public float speed;
    public float damage;
    public ParticleSystem damageEffect;
    public ParticleSystem deathEffect;

    private Rigidbody2D rb2;

    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.AddForce(-transform.right * speed);
    }

    public virtual void Damage(int damage)
    {
        Debug.Log("attack");
        HP -= damage;
        if (HP > 0)
        {
            damageEffect.Play();
        }
        if (HP <=        0) {
            deathEffect.Play();
            Destroy(gameObject);
        }
        
    }

}
