using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpManager : MonoBehaviour
{
    public float tiempo;

    public float exp;


    void Start()
    {
        
    }

    void Update()
    {
        tiempo -= Time.deltaTime;
    }
}
