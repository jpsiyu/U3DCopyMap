using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ViewManager : MonoBehaviour {

    private GameObject copyMapGO;

    void Awake() {
        copyMapGO = ViewUtility.LoadRes("Assets/Prefabs/CopyMap.prefab");
        copyMapGO.AddComponent<CopyMapView>();
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
