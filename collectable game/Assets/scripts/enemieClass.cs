using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemieClass : MonoBehaviour
{
    public float HP;
    public float speed;
    public float damage;

    private Rigidbody2D rb2;

    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.AddForce(-transform.right * speed);
    }

    public virtual void Damage()
    {
        Debug.Log("attack");

    }

}
