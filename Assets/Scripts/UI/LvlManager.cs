using UnityEngine;
using System.Collections;

public class LvlManager : MonoBehaviour {
    public GameObject perdisteText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void nextLvl()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	public void reloadLvl()
	{
		Application.LoadLevel (Application.loadedLevel);
        Destroy(gameObject);
        Destroy(perdisteText);
	}

}
