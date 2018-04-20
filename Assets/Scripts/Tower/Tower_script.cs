using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_script : MonoBehaviour
{
    public Transform ball;

    private Vector3 pozycjaGraczaXYZ;
    private Quaternion rotacjaPocisku;
    public float katWidzenia = 160f;


    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        
	}

    /*
    public Quaternion rotacja()
    {
        //Pobranie pozycji gracza.
        pozycjaGraczaXYZ = new Vector3(ball.position.x, ball.position.y, ball.position.z);

        //Quaternion.LookRotation - zwraca quaternion na podstawie werktora kierunku/pozycji. 
        //Potrzebujemy go aby obrócić wroga w stronę gracza.
        rotacjaPocisku = Quaternion.LookRotation(pozycjaGraczaXYZ - transform.position);
        return rotacjaPocisku;
    }
    */

    protected bool namierzanie()
    {
        if (ball != null)
        {
            //Pobranie aktualnego konta obrotu wroga w stosunku do gracza.
            float angle = Quaternion.Angle(ball.rotation, transform.rotation);
            //Debug.Log (angle);
            //Sprawdzenie czy gracz jest już widoczny podczas obrotu wroga.
            if (angle >= katWidzenia)
            {
                return true;
            }
        }
        return false;
    }
}
