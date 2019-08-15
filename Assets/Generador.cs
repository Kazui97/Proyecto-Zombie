using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    GameObject ZombieMesh;
    CosasZombie datoZombi;
    

    void Start()
    {



        int numZombi = Random.Range(9, 20);
        for (int i = 0; i < numZombi; i++)
        {
            ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            ZombieMesh.AddComponent<ZombieOp>();
            datoZombi = ZombieMesh.GetComponent<ZombieOp>().datosZombi;
            switch (datoZombi.colorEs)
            {
                case CosasZombie.ColorZombie.magenta:
                    ZombieMesh.GetComponent<Renderer>().material.color = Color.magenta;

                    break;
                case CosasZombie.ColorZombie.green:
                    ZombieMesh.GetComponent<Renderer>().material.color = Color.green;

                    break;
                case CosasZombie.ColorZombie.cyan:
                    ZombieMesh.GetComponent<Renderer>().material.color = Color.cyan;

                    break;
            }
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            ZombieMesh.transform.position = pos;
            ZombieMesh.AddComponent<Rigidbody>();

        }
       

    }

    
    void Update()
    {
        
    }
}
