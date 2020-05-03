using UnityEngine;
using System.Collections;

public class Muerte_vacio : MonoBehaviour {

	void Start () {
	
	}
	
    public void OnTriggerEnter (Collider colision)
    {
        Vida vidadelobjeto = colision.GetComponent<Vida>();
        //   vidadelobjeto.vida = vidadelobjeto.vida - daño;
        vidadelobjeto.vida = 0;
    }


	void Update () {
	
	}
}
