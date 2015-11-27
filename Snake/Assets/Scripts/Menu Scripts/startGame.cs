using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour
{

    // Use this for initialization
    public void Example()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}