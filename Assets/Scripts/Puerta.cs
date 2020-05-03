using UnityEngine;
using System.Collections;

public class Puerta : MonoBehaviour {

    public GameObject puerta;
    public Transform movimiento;
    private float valorMovimiento;
    bool flag = false;

	void Start () {
	}

    public void Update()
    {
        valorMovimiento = valorMovimiento + 1.5f;

    }
    public void Reactivar()
    {
        movimiento.Translate(0, 0, -100 * Time.deltaTime);
    }

    void OnTriggerEnter() {
                UnityEngine.AI.NavMeshObstacle obstaculo = puerta.GetComponent<UnityEngine.AI.NavMeshObstacle>();

        if (flag == false)
        {
            //obstaculo.carvingMoveThreshold=1000;
            //obstaculo.carvingTimeToStationary = 0;
            movimiento.Translate(0,0,80 * Time.deltaTime);
            flag = true;
        }
        else
        {
            valorMovimiento = 0;
            flag = false;
        }
    }

    void OnTriggerExit()
    {
        Invoke("Reactivar", 2.0f);
    }

}