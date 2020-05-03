using UnityEngine;
using System.Collections;

public class EstadoAtacar : MonoBehaviour
{


    public MonoBehaviour enemigoFueraDeRango;
    public MonoBehaviour enemigoMuerto;
    public float daño;
    public MonoBehaviour enemigoPerdido;
    Agente agent;
    public GameObject fire;
    float time;
    public LayerMask layers;
    float largoDelRayo = 20f;

    void Start()
    {
        agent = GetComponent<Agente>();


    }

    void Disparo()
    {
        time += Time.deltaTime;
        Vida vidadelobjeto = agent.enemigoActual.GetComponent<Vida>();
        RaycastHit hit;
        if (time > 0.5f)
        {
            bool dispara = Physics.Raycast(transform.position, transform.forward, out hit, largoDelRayo, layers);
            if (dispara)
            {
                Instantiate(fire, hit.point, Quaternion.LookRotation(hit.normal));
                vidadelobjeto.vida = vidadelobjeto.vida - daño;
                print("lo revente vieja");

            }
            else
            {
                print("lo perdi vieja");

            }
            time = 0;
        }
    }

    void Update()
    {
        Collider[] area = Physics.OverlapSphere(transform.position, 15, layers);

        foreach (Collider item in area)
        {
            if (item.tag.Equals("Player"))
            {
                Vector3 vectorAPj = item.GetComponent<Transform>().position - transform.position;
                vectorAPj.Normalize();
                float dot = Vector3.Dot(transform.forward, vectorAPj);
                if (dot > 0.1f)
                {
                   Disparo();

                }
                else
                {
                    enemigoFueraDeRango.enabled = true;
                    this.enabled = false;
                }
            }

            if (agent.enemigoActual == null)
            {
                enemigoMuerto.enabled = true;
                this.enabled = false;

            }

        }
    }
}