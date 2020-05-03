using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BarraVida : MonoBehaviour {

    public Vida vida;
    public GameObject player;
    public Image barra;

	void Awake () {

    }
	
	void Update () {
        Vida VidaP = vida.GetComponent<Vida>();
        //Debug.LogError(VidaP.vida);
	    barra.fillAmount = VidaP.vida/100;
	}
}
