using UnityEngine;
using System.Collections;

public class slingshot : MonoBehaviour {
	public GameObject launchPoint;
	void Awake(){
		Transform launchPointTrans = transform.Find("launchPoint");
		launchPoint = launchPointTrans.gameObject;
		launchPoint.SetActive (false);


	void OnMouseEnter(){


			launchPoint.SetActive (true);


	}
void OnMouseExit(){

			launchPoint.SetActive (false);
	
	}

	
	

}
