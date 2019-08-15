using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieOp : MonoBehaviour
{
    

    // public string [] Gustos;
    public CosasZombie datosZombi;



    void Awake()
    {




        //ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        //Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        //ZombieMesh.transform.position = pos;
        //ZombieMesh.AddComponent<Rigidbody>();


        datosZombi.colorEs = (CosasZombie.ColorZombie)Random.Range(0, 3);

    }

    
    void Update()
    {
        
    }

   


}



public struct CosasZombie
{
    public enum Gustos 
    {
        Brazos,
        Piernas,
        Huesitos,
        Ojito,
        corazoncito
    };
    public Gustos sabroso;

    public enum Estados
    {
        Idle,
        Moving
    };
    public Estados condicion;

    public enum ColorZombie
    {
        magenta,
        green, 
        cyan
    };
    public ColorZombie colorEs;
}