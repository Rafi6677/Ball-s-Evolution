using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_double : MonoBehaviour {
    bool active = false;
    MeshRenderer komponent;
    MeshRenderer komponent_2;

    public Rigidbody door;
    public GameObject platform;
    public GameObject platform_2;

    Vector3 doorStartPosition;

    void Start()
    {
        doorStartPosition = door.position;
        komponent = platform.GetComponent<MeshRenderer>();
        komponent_2 = platform.GetComponent<MeshRenderer>();
    }


    void Update()
    {
        Vector3 doorNewPosition;
        if (active)
        {
            doorNewPosition = doorStartPosition - Vector3.up * 2.5f;
            komponent.material.color = Color.green;
        }
        else
        {
            doorNewPosition = doorStartPosition;
            komponent.material.color = Color.red;
        }
        door.position = Vector3.Lerp(door.position, doorNewPosition, Time.deltaTime * 5f);
    }

    void FixedUpdate()
    {
        active = false;
    }

    void OnTriggerStay(Collider collider)
    {
        active = true;
    }

#if UNITY_EDITOR
    void OnDrawGizmosSelected()
    {
        if (!door)
        {
            return;
        }

        Gizmos.color = Color.yellow;

        Vector3 ghostSize = door.rotation * door.transform.localScale /* * 2f*/;
        Gizmos.DrawWireCube(door.position, ghostSize);
    }
#endif

}
