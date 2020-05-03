using UnityEngine;
using System.Collections;

public class EstadoPerseguir : MonoBehaviour
{

    public MonoBehaviour enemigoPerdido;
    public MonoBehaviour enemigoEnRango;
    UnityEngine.AI.NavMeshAgent nma;
    Agente agent;
    public Transform personaje;
    float distancia = 10.0f;
    public LayerMask layers;
    private Animator anim;

    void Start()
    {
        nma = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent = GetComponent<Agente>();
        anim = GetComponent<Animator>();

    }

    public void ActualizarPuntoDestinoNavMeshAgent(Vector3 puntoDestino)
    {
        nma.destination = puntoDestino;
        nma.Resume();
    }

    public void ActualizarPuntoDestinoNavMeshAgent()
    {
        ActualizarPuntoDestinoNavMeshAgent(personaje.position);
    }

    void Update()
    {
        Collider[] aurAtaque = Physics.OverlapSphere(transform.position, 5, layers);
        anim.SetBool("Run", true);
        anim.SetBool("Walk", false);
        anim.SetBool("Idle", false);

        ActualizarPuntoDestinoNavMeshAgent();
        Vector3 posicionA = transform.position;
        Vector3 posicionB = personaje.position;
        float dis = Vector3.Distance(posicionA, posicionB);
        if (!nma.pathPending && nma.hasPath && nma.remainingDistance < 0.5f)
        {
            nma.SetDestination(personaje.position);
        }
        else
        {
            enemigoPerdido.enabled = true;
            this.enabled = false;
        }

        foreach (Collider item in aurAtaque)
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

                    enemigoEnRango.enabled = true;
                    this.enabled = false;

                }
            }
        }
        }
}
