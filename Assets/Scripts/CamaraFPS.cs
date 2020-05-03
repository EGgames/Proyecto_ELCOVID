using UnityEngine;
using System.Collections;

public class CamaraFPS : MonoBehaviour {
   
    private float angulo;
    private float mouseHorizontal;
	void Start () {
	
	}
	
	void Update () {
        mouseHorizontal -= Input.GetAxis("Mouse X");
        angulo -= Input.GetAxis("Mouse Y");
        transform.Rotate(0, -mouseHorizontal, 0);
        transform.eulerAngles = new Vector3(angulo, -mouseHorizontal, 0);
        angulo = Mathf.Clamp(angulo, -90, 90);
	}
}
