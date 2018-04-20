using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ball;
    
    /**Obiekt gracza.*/
    protected Transform gracz;
    /**Aktualna pozycja gracza.*/
    private Vector3 pozycjaGraczaXYZ;
    /**Zawiera obrót rakiety.*/
    private Quaternion rotacjaPocisku;

    /**Obiekt gracza.*/
    protected GameObject graczObiekt;

    /** 
     * Kąt określający pole widzenia, po przekroczeniu tej wartości uznawane jest, że
     * gracz jest widoczny i można oddać strzał.
     */
    public float katWidzenia = 160f;

    /*Pobranie pozycji obiektu, na który patrzy przeciwnik.*/
    protected Vector3 hitPoint;

    void Start ()
    {
        //graczObiekt = GameObject.FindWithTag("sphere");
        graczObiekt = ball;
        //Pobranie obiektu gracza.
        gracz = graczObiekt.transform;
    }

    /**
     * Funkcja odpowiedzialna za namierzanie gracza.
     * Jeżeli gracz znajduje się w polu widzenia to zwraca 'true' w przeciwnym razie 'false'.
     * Jeżeli gracz znajduje się w polu widzenia to można oddać strzał.
     */
    protected bool namierzanie()
    {
        if (gracz != null)
        {
            //Pobranie aktualnego konta obrotu wroga w stosunku do gracza.
            float angle = Quaternion.Angle(gracz.rotation, transform.rotation);
            //Debug.Log (angle);
            //Sprawdzenie czy gracz jest już widoczny podczas obrotu wroga.
            if (angle >= katWidzenia)
            {
                return true;
            }
        }
        return false;
    }

    /**
     * Metoda na podstawie pozycji gracza zwraca Quaternion pozwalającego na ustalenie/ukierunkowanie pozycji
     * do której ma zmierzać.
     */
    public Quaternion getRotacjaPocisku()
    {
        //Pobranie pozycji gracza.
        pozycjaGraczaXYZ = new Vector3(gracz.position.x, gracz.position.y, gracz.position.z);

        //Quaternion.LookRotation - zwraca quaternion na podstawie werktora kierunku/pozycji. 
        //Potrzebujemy go aby obrócić wroga w stronę gracza.
        rotacjaPocisku = Quaternion.LookRotation(pozycjaGraczaXYZ - transform.position);
        return rotacjaPocisku;
    }

    void Update ()
    {
		
	}
}
