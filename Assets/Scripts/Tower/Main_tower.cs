using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_tower : MonoBehaviour
{
    private Transform target;

    [Header("Attributes")]
    public float range = 15f;
    public float turn_speed = 10f;
    public float fire_rate = 1f;

    [Header("Bullet")]
    public GameObject bullet_prefab;
    public float speed = 10f;

    [Header("Others")]
    public string player_tag = "Enemy";
    public Transform part_to_rotate;
    private float fire_countdown = 0f;
    public Transform fire_point;

	void Start ()
    {
        InvokeRepeating("update_target", 0f, 0.5f);
	}

    void update_target()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag(player_tag);
        float distanece_to_enemy = Vector3.Distance(transform.position, enemy.transform.position);

        if(enemy != null && distanece_to_enemy <= range)
        {
            target = enemy.transform;
        }
        else
        {
            target = null;
        }
    }
	
	
	void Update ()
    {
		if(target == null)
        {
            Destroy(bullet_prefab);
            return;
        }

        Vector3 dir = target.position - transform.position;
        Quaternion look_rotation = Quaternion.LookRotation(dir);

        //Vector3 rotation = look_rotation.eulerAngles;
        Vector3 rotation = Quaternion.Lerp(part_to_rotate.rotation, look_rotation, Time.deltaTime * turn_speed).eulerAngles;
        part_to_rotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if(fire_countdown <= 0f)
        {
            shoot();
            fire_countdown = 1f / fire_rate;
        }

        fire_countdown -= Time.deltaTime;
    }

    void shoot()
    {
        /*GameObject bulletGO = (GameObject)Instantiate(bullet_prefab, fire_point.position, fire_point.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if(bullet != null)
        {
            bullet.Seek(target);
        }*/

        
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
