using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PhotonPlayer : MonoBehaviour
{
    private PhotonView PV;

    public GameObject myAvatar;
    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();
        int spawnPicker = Random.Range(0, GameSetup.GS.SpawnPoints.Length);
        if(PV.IsMine)
        {
            myAvatar = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerAvatar"),GameSetup.GS.SpawnPoints[spawnPicker].position, GameSetup.GS.SpawnPoints[spawnPicker].rotation,0 );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
