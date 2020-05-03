using UnityEngine;
using System.Collections;

public class Dañador : MonoBehaviour {
    public float daño;

    void Start () {
	
	}
    void OnTriggerEnter(Collider colision) {
        Vida vidadelobjeto = colision.GetComponent<Vida>();
     //   vidadelobjeto.vida = vidadelobjeto.vida - daño;
        vidadelobjeto.vida = vidadelobjeto.vida - daño;
    }

    void Update () {
	
	}
}
