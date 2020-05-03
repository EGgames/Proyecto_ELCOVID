using UnityEngine;
using System.Collections;

public class MovimientoHorizontal : MonoBehaviour {
    
    public float VelocidadX;
    public float VelocidadY;
    public float VelocidadZ;
    public float res;
    public float velo;
    private float tiempo;
	
    void Start () {
	
	}
	
	void Update () {
        tiempo += Time.deltaTime;
       // print(tiempo);

        if (tiempo >= 0)
        {
            VelocidadX = res;
        }
        if (tiempo >= 2)
        {
            VelocidadX = 0;
        }
        if (tiempo >= 4)
        {
            VelocidadX = -velo;
        }
        if (tiempo >= 6)
        {
            VelocidadX = 0;
        }
        if (tiempo >= 8)
        {
            tiempo = 0;
        }

        transform.Translate(VelocidadX * Time.deltaTime, VelocidadY * Time.deltaTime, VelocidadZ * Time.deltaTime);

        
        }
}