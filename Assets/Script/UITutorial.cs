using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITutorial : MonoBehaviour
{
    public GameObject panel1; // Panel pertama
    public GameObject panel2; // Panel kedua

    void Start()
    {
        // Pastikan Panel 1 aktif dan Panel 2 tidak saat awal game
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void ShowPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    public void ShowPanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void CloseTutorial()
    {
        gameObject.SetActive(false); // Menyembunyikan seluruh UI Tutorial
    }
}