using UnityEngine;
using System.Collections;

public class Barrel_spawner : MonoBehaviour
{
    public bool across = true;

    public GameObject prefab;
    public float interval;
    public float prefabLivetime;

    Vector3 vector = new Vector3(0f, 0f, 90f);
    Vector3 vector2 = new Vector3(90f, 0f, 0f);

    void Start ()
    {
        StartCoroutine("spawn");
	}

    IEnumerator spawn()
    {
        while(true)
        {
            GameObject newObject = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
            if(across)
            {
                newObject.transform.Rotate(vector);
            }
            else
            {
                newObject.transform.Rotate(vector2);
            }
            Destroy(newObject, prefabLivetime);

            yield return new WaitForSeconds(interval);
        }
    }
}
