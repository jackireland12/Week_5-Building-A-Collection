using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eniememovement : MonoBehaviour
{
    private Rigidbody2D rb2;
    public float speed ;
    public GameObject[] eninimesArray;


    // Start is called before the first frame update
    void Start()
    {
         rb2 = GetComponent<Rigidbody2D>();
        rb2.AddForce(-transform.right * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class enemieClass : MonoBehaviour
{
    public string name;

    public virtual void HP()
    {
        Debug.Log(  "win       ");
    }

}
public class big : enemieClass
{
    public override void HP()
    {
        Debug.Log(name + "HP");
    }
}

public class small : enemieClass
{
    public override void HP()
    {
        Debug.Log(name + "HP");
    }
}
