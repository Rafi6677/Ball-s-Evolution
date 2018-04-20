using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moj : MonoBehaviour {

    private Transform target;

    [Header("Attributes")]
    public float range = 15f;
    public float turn_speed = 10f;

    [Header("Bullet")]
    public GameObject bullet_prefab;
    public float speed = 10f;
    public float fire_rate = 1f;
    public float bullet_lifetime = 10;

    [Header("Others")]
    public string player_tag = "Enemy";
    public Transform part_to_rotate;
    private float fire_countdown = 0f;
    public Transform fire_point;
    public bool sphere = false;

    void Start()
    {
        InvokeRepeating("update_target", 0f, 0.5f);
    }

    void update_target()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag(player_tag);
        float distanece_to_enemy = Vector3.Distance(transform.position, enemy.transform.position);

        if (enemy != null && distanece_to_enemy <= range)
        {
            target = enemy.transform;
        }
        else
        {
            target = null;
        }
    }


    void Update()
    {
        if (target == null)
        {
            //Destroy(bullet_prefab);
            return;
        }

        Vector3 dir = target.position - transform.position;
        Quaternion look_rotation = Quaternion.LookRotation(dir);

        Vector3 rotation = Quaternion.Lerp(part_to_rotate.rotation, look_rotation, Time.deltaTime * turn_speed).eulerAngles;

        if(sphere)
        {
            part_to_rotate.rotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);
        }
        else
        {
            part_to_rotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
        }


        if (fire_countdown <= 0f)
        {
            shoot();
            
            fire_countdown = 1f / fire_rate;
        }

        fire_countdown -= Time.deltaTime;
    }

    void shoot()
    {
        GameObject new_bullet = Instantiate(bullet_prefab, fire_point.position, part_to_rotate.rotation) as GameObject;
        new_bullet.GetComponent<Rigidbody>().velocity = fire_point.forward * speed * Time.deltaTime;

        Destroy(new_bullet, bullet_lifetime);
    }

    #if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.gray;

        if (UnityEditor.Selection.activeTransform == transform)
        {
            Gizmos.color = Color.red;
        }
        Gizmos.DrawWireSphere(transform.position, range);
    }
    #endif
}
