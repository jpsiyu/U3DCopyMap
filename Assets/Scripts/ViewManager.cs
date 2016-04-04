using UnityEngine;
using System.Collections;

public class ViewManager : MonoBehaviour {

    private GameObject copyMapPrefab;

    void Awake() {

    }

	// Use this for initialization
	void Start () {
        copyMapPrefab = Resources.LoadAssetAtPath("Assets/Prefabs/CopyMap.prefab", typeof(GameObject)) as GameObject;
        GameObject copyMapGO = GameObject.Instantiate(copyMapPrefab) as GameObject;
        copyMapGO.AddComponent<CopyMapView>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
