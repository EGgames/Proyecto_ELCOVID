using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AccesoMenuPrincipal : MonoBehaviour
{

    public GameObject pauseMnu;
    public bool isPause;
    public bool dead;

    public Vida m;

    void Start()
    {
        pauseMnu.SetActive(false);
    }

    void Update()
    {
        UnityEngine.GameObject x = UnityEngine.GameObject.Find("Player");
        m = x.GetComponent<Vida>();
        if (m.vida == 0)
        {
            dead = true;
            Cursor.visible = true;

        }



        if (Input.GetKeyDown("escape"))
        {
            isPause = true;
        }


        if (isPause == true && dead == false)
        {
            Time.timeScale = 0.0f;
            Cursor.visible = true;
            pauseMnu.SetActive(true);

        }

        if (isPause == false && dead== false)
        {
            Time.timeScale = 1.0f;
            pauseMnu.SetActive(false);
            Cursor.visible = false;

        }
    }
}
