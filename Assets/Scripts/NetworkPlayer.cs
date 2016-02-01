using UnityEngine;
using UnityEngine.Networking;

public class NetworkPlayer : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;

    // Use this for initialization
    void Start()
    {
        if (!isLocalPlayer)
        {
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        }
        else
        {
            GetComponentInChildren<AudioListener>().enabled = true;
            GetComponentInChildren<GUILayer>().enabled = true;
            GetComponentInChildren<FlareLayer>().enabled = true;
        }
    }
}
