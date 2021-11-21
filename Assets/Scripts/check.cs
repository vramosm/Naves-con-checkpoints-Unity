using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class check : MonoBehaviour
{

    public float ContadorCheckpoint;
    public GameObject Nave;
    private int CheckP;
    private Rigidbody rb;
    public Image congrats;
    public Text pts;


    private void Awake()
    {
        CheckP = 0;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        actualizarPts();
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "checkpoint")
        {
            ContadorCheckpoint++;
            CheckP++;
            actualizarPts();
            Debug.Log("Checkpoints pasados: " + ContadorCheckpoint);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "obstaculo")
        {
            Destroy(Nave);
            SceneManager.LoadScene("Game Over");
        }
        if ((this.GetComponent<check>().ContadorCheckpoint == 4) && (other.gameObject.tag == "meta"))
        {

            End();
        }
    }
    void actualizarPts()
    {
        pts.text = CheckP.ToString();
    }
    void End()
    {
        //se crea este apartado para que salga en la consola, poniendo el destroy para que solo salga una vez el mensaje
        Debug.Log("¡Mision Completada!");
        Destroy(this);
    }
}
