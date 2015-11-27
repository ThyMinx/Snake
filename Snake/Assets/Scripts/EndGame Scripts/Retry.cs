using UnityEngine;
using System.Collections;

public class Retry : MonoBehaviour {

    public void Example()
    {
        Application.LoadLevel(Application.loadedLevel - 1);
    }
}
