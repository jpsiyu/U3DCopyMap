using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CopyMapView : MonoBehaviour {



    private List<Vector3> posList;
    private Dictionary<int, GameObject> iconDict;
    private string iconPrefabPath;
    private bool isSetPos = false;


    void Awake() {

    }

	// Use this for initialization
	void Start () {
        iconPrefabPath = "Assets/Prefabs/CopyMapIcon.prefab";
        posList = new List<Vector3>();
        iconDict = new Dictionary<int, GameObject>();

        InitPosList();
        InitIconList();
	}
	
	// Update is called once per frame
	void Update () {
        if(!isSetPos)
            UpdateIconPos();
	}

    private void InitPosList() {
        posList.Add(new Vector3(-200, 0, 0));
        posList.Add(new Vector3(-100, 0, 0));
        posList.Add(new Vector3(0, 0, 0));
        posList.Add(new Vector3(100, 0, 0));
        posList.Add(new Vector3(200, 0, 0));
    }

    private void InitIconList() {
        foreach (Vector3 pos in posList)
        {
            GameObject go = ViewUtility.LoadRes(iconPrefabPath);
            ViewIcon view = go.AddComponent<ViewIcon>();
            go.transform.position = pos;
            view.Id = posList.IndexOf(pos);
            iconDict.Add(view.Id, go);
        }
    }

    private void UpdateIconPos() {
        foreach (KeyValuePair<int, GameObject> icon in iconDict)
        {
            Vector3 v = posList[icon.Key];
            icon.Value.transform.localPosition = v;
        }
        isSetPos = true;
    }


}
