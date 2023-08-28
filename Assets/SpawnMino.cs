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
            Instantiate(Minos[i], new Vector3(12, 16-i*3, 0), Quaternion.identity);
        }
    }
}