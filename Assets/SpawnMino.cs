using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMino : MonoBehaviour
{
    public GameObject[] Minos;
    // Start is called before the first frame update
    void Start()
    {
        NewMino();
    }

    public void NewMino()
    {   
        for(int i = 0; i < Minos.Length; i++)
        {
            if (i % 2 == 0)
            {
                Instantiate(Minos[i], new Vector3(-5, 16 - (i/2) * 5, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(Minos[i], new Vector3(12, 16 - (i/2) * 5, 0), Quaternion.identity);
            }
        }
    }
}