using UnityEngine;
using System.Collections;

public class ContinuarBtn : MonoBehaviour
{
  
   // int nivelAnterior;
    int parser;
    public AcumuladorNiveles prefab;
    public void Start()
    {


    }
    public void ContinuarEvento()
    {
        
        AcumuladorNiveles nivelAnterior = prefab.GetComponent<AcumuladorNiveles>();
        nivelAnterior.nivel = nivelAnterior.nivel+ 1;
        Application.LoadLevel(nivelAnterior.nivel++);
     //   print(nivelAnterior.nivel);
    }
}