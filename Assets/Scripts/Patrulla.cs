using UnityEngine;
using System.Collections;

public class Patrulla : MonoBehaviour {

    private UnityEngine.AI.NavMeshAgent nma;

    public int puntoActual;

    public Transform[] puntos;
    
    public Transform punto1;

	void Start () {
        nma = GetComponent<UnityEngine.AI.NavMeshAgent>();
        nma.SetDestination(punto1.position);
        puntoActual = 1;

	}
	
	void Update () {
        if (puntos.Length >= 3 )
        {
            print("El Array tiene 3 o mas elementos");
        }
        else
        {
            print("El Array tiene menos de 3 elementos");
        }
        if (!nma.pathPending && nma.hasPath && nma.remainingDistance < 0.5f)
        {
            /*if (puntoActual == 1)
            {
                nma.SetDestination(punto2.position);
                puntoActual = 2;
            }
            else if (puntoActual == 2)
            {
                nma.SetDestination(punto3.position);
                puntoActual = 3;
            }
            else if (puntoActual == 3)
            {
                nma.SetDestination(punto1.position);
                puntoActual = 1;
            }*/

            puntoActual++;
            Transform destino = puntos[puntoActual];
            nma.SetDestination(destino.position);

            if (puntoActual == 2)
            {
                puntoActual = 0;
            }
        }
    
    }
    public void ReseteoArray()
    {
    }
}
