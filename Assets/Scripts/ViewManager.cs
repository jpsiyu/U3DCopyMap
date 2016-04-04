using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ViewManager : MonoBehaviour {

    private GameObject copyMapPrefab;

    void Awake() {
        GameObject copyMapGO = ViewUtility.LoadRes("Assets/Prefabs/CopyMap.prefab");
        copyMapGO.AddComponent<CopyMapView>();
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
