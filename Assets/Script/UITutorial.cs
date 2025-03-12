using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITutorial : MonoBehaviour
{
    public GameObject panel1; 
    public GameObject panel2; 

    void Start()
    {
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
        gameObject.SetActive(false); 
    }
}