using UnityEngine;
using System.Collections;

public class CopyMapView : MonoBehaviour {


    private GameObject iconPrefab;
    private GameObject iconBody;
    private UITexture iconUp;

    void Awake() {
        BindElement();
        GameObject.Instantiate(iconPrefab);

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void BindElement() {
        iconPrefab = Resources.LoadAssetAtPath("Assets/Prefabs/CopyMapIcon.prefab", typeof(GameObject)) as GameObject;
        iconBody = iconPrefab.transform.Find("offset/IconBody").gameObject;
        iconUp = iconBody.transform.Find("IconUp").GetComponent<UITexture>();
    }
}
