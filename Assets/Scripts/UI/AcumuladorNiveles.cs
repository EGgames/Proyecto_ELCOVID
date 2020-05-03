using UnityEngine;
using System.Collections;

public class AcumuladorNiveles : MonoBehaviour {
    public int nivel = 0;
    int parser;
	// Use this for initialization
	void Start () {
        nivel = nivel + 1;
        DontDestroyOnLoad(gameObject);

	}
	
}
