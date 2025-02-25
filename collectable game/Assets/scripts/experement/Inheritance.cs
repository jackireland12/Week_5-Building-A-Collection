using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    public string Ename;
    private void Start()
    {
        Inheritance em = new Inheritance();

        em.HP();
    }
    

    public virtual void HP()
    {
        Debug.Log("win       ");
    }

}
public class big : Inheritance
{
    public override void HP()
    {
        Debug.Log(Ename + "HP");
    }
}

public class small : Inheritance
{
    public override void HP()
    {
        Debug.Log(Ename + "HP");
    }
}
