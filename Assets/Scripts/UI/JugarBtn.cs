using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class JugarBtn : MonoBehaviour {

	public void JugarEvento () {
        SceneManager.LoadScene("Nivel1"); 
        //Application.LoadLevel("nivel1");
	}
}
