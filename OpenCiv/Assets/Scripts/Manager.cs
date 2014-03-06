using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Handles nearly everything, core of everything
/// </summary>

public class Manager : Photon.MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Connect");
    }

    IEnumerator Connect()
    {
        while (true)
        {

        }
    }

    void OnFailedToConnectToPhoton(DisconnectCause cause)
    {

    }
}
