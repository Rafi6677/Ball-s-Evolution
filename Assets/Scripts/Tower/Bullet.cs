using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 10f;

    public void Seek(Transform _target)
    {
        target = _target;
    }


    void Update ()
    {
		if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distance_this_frame = speed * Time.deltaTime;

        if(dir.magnitude <= distance_this_frame)
        {
            hit_target();
            return;
        }

        transform.Translate(dir.normalized * distance_this_frame, Space.World);

	}

    void hit_target()
    {
        Debug.Log("HITTTTTTTTTTTT");
        Destroy(gameObject);
    }
}
