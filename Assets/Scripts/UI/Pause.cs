using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public AccesoMenuPrincipal mnupause;

    public void Continue()
    {
        UnityEngine.GameObject x = UnityEngine.GameObject.Find("PrincipalUI");
        mnupause = x.GetComponent<AccesoMenuPrincipal>();
        mnupause.isPause = false;
        Cursor.visible = false;

    }
}
