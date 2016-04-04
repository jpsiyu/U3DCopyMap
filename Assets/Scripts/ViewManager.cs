using UnityEngine;
using System.Collections;

public class ViewManager : MonoBehaviour {

    private GameObject copyMapPrefab;

    void Awake() {
        GameObject copyMapGO = ViewUtility.LoadRes("Assets/Prefabs/CopyMap.prefa");
        copyMapGO.AddComponent<CopyMapView>();
    }

	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
