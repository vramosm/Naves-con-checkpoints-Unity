using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float Temp;
    public float Speed;
    public float SpeedRot;
    public float ContadorCheckpoint;


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("¡PASA POR LOS 4 AROS Y LLEGA HASTA LA CAPSULA PARA FINALIZAR LA CARRERA!");
    }

    // Update is called once per frame
    void Update()
    {

            transform.Translate(new Vector3(0, 0, 2) * Speed * Time.deltaTime, Space.Self);

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(new Vector3(0, -20, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 20, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(new Vector3(-30, 0, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(new Vector3(30, 0, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }
            
    }

   
}
