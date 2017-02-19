using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Connect ();
	}
	
	void Connect(){
		Debug.Log ("Connect");
		PhotonNetwork.ConnectUsingSettings ("prototype v1.0");
		//PhotonNetwork.ConnectToMaster("localhost", 13306, "5eaa723-97d8-4adc-955f-4547bc8ee4fc", "v1");
		//PhotonNetwork.offlineMode = true;
	}

	//get rid of this method
	void OnGUI(){
		Debug.Log ("OnGUI");
		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString());
	}

	void OnJoinedLobby(){
		Debug.Log ("OnJoinedLobby");
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed(){
		Debug.Log ("OnPhotonRandomJoinFailed");
		PhotonNetwork.CreateRoom (null);
	}

	void OnJoinedRoom(){
		Debug.Log ("OnJoinedRoom");
		SpawnMyPlayer ();
	}

	void SpawnMyPlayer(){
		Debug.Log ("SpawnMyPlayer");
		PhotonNetwork.Instantiate ("Airplane", Vector3.zero, Quaternion.identity, 0);
	}

}
