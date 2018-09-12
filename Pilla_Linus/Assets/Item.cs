using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Food[] mat;
    Random r = new Random();
    void Start()
    {
        mat[0].enabled = false;
        mat[1].enabled = false;
        mat[2].enabled = false;
        mat[3].enabled = false;

    }
    void Item3()
    {
        Debug.Log("Your item is:");
        Debug.Log("Hamburger");
        Debug.Log("1");
        Debug.Log("250g");
    }
    void item2()
    {
        Debug.Log("Your item is:");
        Debug.Log("pasta");
        Debug.Log("1 Plate");
        Debug.Log("500g");
    }
    void Item1()
    {
        Debug.Log("Your item is:");
        Debug.Log("Pizza");
        Debug.Log("8 peices");
        Debug.Log("100g/p");
    }
    void Item0()
    {
        Debug.Log("Your Item is:");
        Debug.Log("Bröd");
        Debug.Log("1st");
        Debug.Log("200g");
    }
    // Update is called once per frame
    int MyItem = Random.Range(0,4);
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            mat[MyItem].Print();
        }
    }
}
