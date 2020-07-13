using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabInstance : MonoBehaviour
{
    public void InstantiateSnowman()
    {
        GameObject prefab = (GameObject)Resources.Load("Prefabs/Snowman");
        Vector3 position = new Vector3(1f, 0f, 0f);
        Quaternion rotation = Quaternion.Euler(45,45,0);

        GameObject snowman = Instantiate(prefab, position, rotation);
    }

}
