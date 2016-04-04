using UnityEngine;
using System.Collections;
using System;

public class ViewUtility  {

    public static GameObject LoadRes(string path) { 
        GameObject go = Resources.LoadAssetAtPath(path, typeof(GameObject)) as GameObject;
        return GameObject.Instantiate(go) as GameObject;
    }

    public static void SetClickEvent(GameObject button, UIEventListener.VoidDelegate callback) {
        UIEventListener.Get(button).onClick = callback;
    }
}
