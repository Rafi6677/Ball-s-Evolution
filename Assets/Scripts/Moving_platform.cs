using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_platform : MonoBehaviour
{
    public Vector3 delta;
    Vector3 start_position;

    void Start ()
    {
        start_position = transform.position;
	}
	
	
	void Update ()
    {
        float velocity = 50f / delta.sqrMagnitude;
        float change = ((Mathf.Sin(Time.timeSinceLevelLoad * velocity))+1f)/2f;

        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        rigidbody.position = Vector3.Lerp(start_position, start_position + delta, change);

	}

    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;

        if(UnityEditor.Selection.activeTransform == transform)
        {
            Gizmos.color = Color.yellow;
        }

        Vector3 ghost_position = transform.position + delta;
        Vector3 ghost_size = transform.rotation * transform.localScale * 2f;

        Gizmos.DrawWireCube(ghost_position, ghost_size);
    }
    #endif
}
