using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour { 

    public float exp_obtenida;
    public float exp_cont;
    public float tiempo;


    public GameObject gameOver;
    public GameObject player;
    public AccesoMenuPrincipal pause;
         
    public int contador; 
    public int saqueos = 0;
    public int papelCount = 0;


    void Start()
    {
        Cursor.visible = false;
        Time.timeScale = 1.0f;
        saqueos = 1;
        gameOver.SetActive(false);

    }

    void Update()
    {
        UnityEngine.GameObject spawn = UnityEngine.GameObject.Find("Spawn_enemigo");
        UnityEngine.GameObject p = UnityEngine.GameObject.Find("PruncipalUI");

        Spawn s = spawn.GetComponent<Spawn>();

        tiempo -= Time.deltaTime;
        Vida vida = player.GetComponent<Vida>();
        if (vida.vida <= 0)
        {
            gameOver.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0.0f;

        }

        if (exp_cont >= 3000 )
        {
            //SAQUEO + 1
            saqueos++;
            s.SpawnBotella();
            exp_cont = 0;
           
        }

    }
    
}
