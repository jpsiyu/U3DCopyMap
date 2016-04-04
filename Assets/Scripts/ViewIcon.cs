using UnityEngine;
using System.Collections;

public class ViewIcon : MonoBehaviour{
    private GameObject iconBody;
    private UITexture iconUp;
    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    void Awake() {
        BindElement();
    }

    public void BindElement()
    {
        iconBody = transform.Find("offset/IconBody").gameObject;
        iconUp = iconBody.transform.Find("IconUp").GetComponent<UITexture>();
    }


}
