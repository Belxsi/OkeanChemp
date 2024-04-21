using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class BaseFunc : MonoBehaviour
{
    public static bool IsLoad;
    public static Dictionary<string, GameObject> prefabs = new();
   
    public static void AddPrefab(string nam)
    {
        prefabs.Add(nam, (GameObject)PrefabLoader.Load("Prefabs", nam));
    }
    public static Vector2 GetForMouseDir(Vector2 pos)
    {
       Vector2 posmos =Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return (posmos - pos).normalized;

    }
    public static void AllLoadPrefab()
    {
        if (!IsLoad)
        {

            IsLoad = true;
            AddPrefab("Item");
            AddPrefab("Slot");
            AddPrefab("Bullet");
            AddPrefab("ItemInterface");
        }
    }
}
