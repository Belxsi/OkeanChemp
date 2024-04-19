using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFunc : MonoBehaviour
{
    public static bool IsLoad;
    Dictionary<string, GameObject> prefabs;
    public static void AllLoadPrefab()
    {
        if (!IsLoad)
        {
            IsLoad = true;

        }
    }
}
