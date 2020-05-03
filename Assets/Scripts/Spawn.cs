using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    GameManager mgr;

    public GameObject papel;
    public GameObject botella;
    public bool isPapel = false;
    public bool isBotella = false;
    void Start()
    {
        if (isPapel == true)
        {
            Instantiate(papel, transform.position, transform.rotation);
        }
        if(isBotella == true)
        {
            Instantiate(botella, transform.position, transform.rotation);
        }
    }

    public void SpawnBotella()
    {
        Instantiate(botella, transform.position, transform.rotation);
    }


    private void Update()
    {
        UnityEngine.GameObject mgr = UnityEngine.GameObject.Find("Managers");
        GameManager m = mgr.GetComponent<GameManager>();
    }




}
