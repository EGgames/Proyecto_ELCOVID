using UnityEngine;
using System.Collections;

public class DisparoFPS : MonoBehaviour {

    float largoDelRayo = 5.5f;
    public LayerMask layers;
    public GameObject fire;
    public Transform fireU;
    float time;
    public float daño;
    public AudioSource disparo;


    void Fire()
    {
        time += time * Time.deltaTime;
        Instantiate(fire, fireU.position, fireU.rotation);
        disparo.Play();
        if (time >= 0.8f)
        {
            Destroy(fire);
            disparo.Stop();
        }
    }

	void Update () {
        RaycastHit hit;

        if (Input.GetButtonDown("Fire1"))
        {
            disparo.Play();

            bool choco = Physics.Raycast(transform.position, transform.forward,out hit, largoDelRayo, layers);
            if (choco)
            {
                Instantiate(fire, hit.point, Quaternion.LookRotation(hit.normal));
                Debug.DrawLine(hit.point, hit.point + hit.normal * 2, Color.red ,2);
                print(hit.collider);
                print(hit.collider.gameObject);
                print(hit.collider.gameObject.name);
                print(hit.point);
                print(hit.distance);
                hit.collider.gameObject.GetComponent<ZonaDanio>().recibirDaño(10);

            }
        }
    }
}
