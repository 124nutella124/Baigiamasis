using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Sceaneman : MonoBehaviour
{
    private bool hasCollided = false;
    public AudioSource AudioPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball") && !hasCollided)
        {
            hasCollided = true;
            StartCoroutine(LoadSceneAfterDelay(3f));
            AudioPlayer.Play();
        }
    }

    private System.Collections.IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
}

