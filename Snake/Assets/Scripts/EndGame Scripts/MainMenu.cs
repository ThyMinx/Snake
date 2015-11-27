using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    public void Example()
    {
        Application.LoadLevel(Application.loadedLevel - 2);
    }
}