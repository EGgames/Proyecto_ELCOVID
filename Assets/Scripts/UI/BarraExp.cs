using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraExp : MonoBehaviour
{

    public Image barra;
     // public float x;
    public GameManager mgr;

    void Update()
    {
        UnityEngine.GameObject x = UnityEngine.GameObject.Find("Managers");
        mgr = x.GetComponent<GameManager>();
        barra.fillAmount = mgr.exp_cont/3000;
    }
}
