using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour {

	public static int point;

	private GameObject pointText;

	// Use this for initialization
	void Start () {

		point = 0;

		this.pointText = GameObject.Find("PointText");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {
		//scoreを表示する
		this.pointText.GetComponent<Text> ().text = point.ToString();

	}
}