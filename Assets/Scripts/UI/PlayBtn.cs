using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBtn : MonoBehaviour
{
    public int level;
    public void Play()
    {
        Application.LoadLevel(level);
    }
}
