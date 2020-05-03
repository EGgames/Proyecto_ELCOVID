using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float dano;
    private float tiempo;
    private int estado;
    float largoDelRayo = 5.5f;
    private Animator anim;
    public GameObject fire;
    public LayerMask layers;
    public int puntoActual;
    private UnityEngine.AI.NavMeshAgent nma;
    public Transform punto1;
    public Transform[] puntos;


	void Start () {
        anim = GetComponent<Animator>();
        nma = GetComponent<UnityEngine.AI.NavMeshAgent>();
        nma.SetDestination(punto1.position);
        puntoActual = 1;
	}


    void disparo()
    {
        RaycastHit hit;
        anim.SetTrigger("Fire");
        bool dispara = Physics.Raycast(transform.position, transform.forward, out hit, largoDelRayo, layers);
        if (dispara)
        {
            Instantiate(fire, hit.point, Quaternion.LookRotation(hit.normal));
          //  hit.collider.gameObject.GetComponent<ZonaDanio>().recibirDaño(10);
        }
    }


    void camina()
    {
        anim.SetBool("Walk", true);
    }

    void corre()
    {
        anim.SetBool("Run", true);
    }

	void Update () {

        if (!nma.pathPending && nma.hasPath && nma.remainingDistance < 0.5f)
        {
            puntoActual++;
            Transform destino = puntos[puntoActual];
            nma.SetDestination(destino.position);
            anim.SetBool("Walk", true);

            if (puntoActual == 9)
            {
                puntoActual = 1;
            }
        }
    }
}