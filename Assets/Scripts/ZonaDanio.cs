using UnityEngine;
using System.Collections;

public class ZonaDanio : MonoBehaviour {

    public float atenuacion;

    public void recibirDaño(float daño)
    {
        Vida v = GetComponentInParent<Vida>();
        v.vida -= daño * atenuacion;
    }

    public void OnTriggerEnter(Collider c)
    {

        ZonaDanio x = c.GetComponentInParent<ZonaDanio>();
       // x.recibirDaño(10);
    }

}
