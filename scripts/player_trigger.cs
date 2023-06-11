using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_trigger : MonoBehaviour
{
    public GameObject player;

    public void OnTriggerEnter(Collider other)
    {
        Destroy(player);
        SceneManager.LoadScene("SampleScene");
    }
}
