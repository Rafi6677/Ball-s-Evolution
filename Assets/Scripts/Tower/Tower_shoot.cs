using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_shoot : Shoot
{

    //Co ile mozna wykonac strzal
    public float czekaj = 2f;
    //Odliczanie do kolejnego strzalu.
    public float odliczanieDoStrzalu = 0f;

    //Obiekt kamienia.
    public GameObject kamienPrefab;
    public float predkosc = 50;

    /**
     * Metoda wykonująca strzał.
     */
    public void strzal()
    {
        //Zmniejszanie licznika do kolejnego strzalu/odliczanie do strzalu.
        odliczanieDoStrzalu -= Time.deltaTime;

        //Strzal nastepuje jezeli odliczanie
        //do kolejnego strzalu jest rowne zero(można strzelać).
        if (odliczanieDoStrzalu <= 0 && namierzanie())
        {
            odliczanieDoStrzalu = czekaj;

            GameObject kamien;
            //Utworzenie instatncji poocisku, pocisk/kamień nie potrzebuje specjalnego zwrotu więc Quaternion.identity.
            kamien = (GameObject)Instantiate(kamienPrefab, transform.position + transform.forward, Quaternion.identity);
            //Wprawienie pocisku w ruch za pomocą oddziaływania na niego siłą (na Rigidbody).
            kamien.GetComponent<Rigidbody>().AddForce(transform.forward * predkosc, ForceMode.Impulse);

        }

    }
}
