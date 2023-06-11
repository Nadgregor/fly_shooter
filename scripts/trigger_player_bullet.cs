using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger_player_bullet : MonoBehaviour
{
    public GameObject bullet;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(bullet);
        if (other.tag == "eneme")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }

}
