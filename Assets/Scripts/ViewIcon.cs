using UnityEngine;
using System.Collections;

public class ViewIcon : MonoBehaviour{
    private GameObject iconBody;
    private UITexture iconUp;


    private int id;
    private bool focus;

    public bool Focus
    {
        get { return focus; }
        set { focus = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    void Awake() {
        BindElement();
        BindEvent();
    }

    void Update() {
        ShowIconUp();
    }

    private void ShowIconUp() {
        iconUp.gameObject.SetActive(Focus);
    }

    private void BindElement()
    {
        iconBody = transform.Find("offset/IconBody").gameObject;
        iconUp = iconBody.transform.Find("IconUp").GetComponent<UITexture>();
    }

    private void BindEvent() {
        ViewUtility.SetClickEvent(iconBody, delegate { OnButtonClick(); });
    }

    public void OnButtonClick() {
        Debug.Log(string.Format("icon {0} click!", Id));
    }
}
