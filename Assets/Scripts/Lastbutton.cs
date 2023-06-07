using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lastbutton : MonoBehaviour
{
    public void Changesceane(string sceaneName)
    {
        SceneManager.LoadScene(sceaneName);
    }
}
