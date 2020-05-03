using UnityEngine;
using System.Collections;

public class Vida : MonoBehaviour
{
    public float vida = 100;



    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            vida = 0;
        }
    }




    void Update()
    {
        if (vida <= 0)
        {
           // Destroy(gameObject);
        }
    }
}