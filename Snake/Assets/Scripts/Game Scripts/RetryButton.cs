using UnityEngine;
using System.Collections;

public class RetryButton : MonoBehaviour {

    public void OnButtonPress()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
