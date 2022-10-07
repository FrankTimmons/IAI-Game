using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;
using ExitGames.Client.Photon;

public class MatchManager : MonoBehaviourPunCallbacks, IOnEventCallback
{
  public static MatchManager instance;

  private void Awake()
  {
    instance = this;
  }



  // Start is called before the first frame update
  void Start()
  {
    if (!PhotonNetwork.IsConnected)
    {
      SceneManager.LoadScene(0);
    }
  }

  // Update is called once per frame
  void Update()
  {
    
  }

  public void OnEvent(EventData photonEvent)
  {

  }

  public override void OnEnable()
  {
    PhotonNetwork.AddCallbackTarget(this);
  }

  public override void OnDisable()
  {
    PhotonNetwork.RemoveCallbackTarget(this);
  }
}
