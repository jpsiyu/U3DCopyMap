using UnityEngine;
using System.Collections;

public class ViewUtility  {

    public static GameObject LoadRes(string path) { 
        GameObject go = Resources.LoadAssetAtPath(path, typeof(GameObject)) as GameObject;
        return GameObject.Instantiate(go) as GameObject;
    }
}
