using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneOn : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject sceneCam;

    private void OnTriggerEnter(Collider other)
    {
        sceneCam.SetActive(true);
        mainPlayer.SetActive(false);

    }



}
