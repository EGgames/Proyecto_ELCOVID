using UnityEngine;
using System.Collections;

public class EstadoPatrullar : MonoBehaviour {

	public float dano;
	private float tiempo;
	private int estado;
	//float largoDelRayo = 5.5f;
	private Animator anim;
	public GameObject fire;
	public LayerMask layers;
	public int puntoActual;
	private UnityEngine.AI.NavMeshAgent nma;
	public Transform punto1;
	public Transform[] puntos;
	public Transform[] jugadores;
	Agente agent;

    public int maxpoints;
    
	public MonoBehaviour enemigoDetectado;
	public Transform player;

	void Start () {
		anim = GetComponent<Animator>();
		agent = GetComponent<Agente>();
		nma = GetComponent<UnityEngine.AI.NavMeshAgent>();
		nma.SetDestination(punto1.position);
		puntoActual = 1;

    }

    void Update () {
		//Transform jugadorCercano = jugadores[0];
		Collider[] area = Physics.OverlapSphere (transform.position, 10, layers);
		foreach (Collider item in area)
		{
			if (item.tag.Equals("Player"))
			{
				Vector3 vectorAPj = item.GetComponent<Transform>().position - transform.position;
				vectorAPj.Normalize();
				float dot = Vector3.Dot(transform.forward, vectorAPj);
				if (dot > 0.5f)
				{
                    GetComponent<Agente>().enemigoActual = item.gameObject;
                    GetComponent<EstadoPerseguir>().personaje = item.transform;

                    enemigoDetectado.enabled = true;
					this.enabled = false;

				}
			}
		}



		if (!nma.pathPending && nma.hasPath && nma.remainingDistance < 0.5f)
		{
			puntoActual = Random.Range(0,33);
			Transform destino = puntos[puntoActual];
			nma.SetDestination(destino.position);
         

            if (puntoActual >= 33)
			{
				puntoActual = 0;
                
			}

        }
	}
}


////