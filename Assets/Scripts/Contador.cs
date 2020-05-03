using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{

    public GameManager mgr;

    public void Update()
    {
        UnityEngine.GameObject mgr = UnityEngine.GameObject.Find("Managers");

        GameManager m = mgr.GetComponent<GameManager>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PapelHigienico")
        {
            
            mgr.papelCount++;
            mgr.exp_obtenida += mgr.tiempo;
            mgr.exp_cont += mgr.tiempo;
            
            
            Destroy(collision.gameObject);
        }

    }


   
}
