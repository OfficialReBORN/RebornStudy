using UnityEngine;

public class SizeChange : MonoBehaviour
{
   public void ChangeSize()
    {
        float newSize = Random.Range(10f, 100f);
        GameObject.Find("Cube").transform.localScale
            = new Vector3(newSize, newSize, newSize);
    }
}