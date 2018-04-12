using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    static public PlatformMovement instance;
    private float t = 0f;
    [SerializeField]
    private int currentPoint = 0;

    public Transform cube;
    public bool pingpong;

    public float speed = 1f;

    public bool activate;

    public List<Transform> points = new List<Transform>();

    // Use this for initialization
    void Start()
    {
        cube.position =points[0].position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (activate == true) {
            Vector3 start = points[currentPoint].position; // Te saca el punto de inicio que cambia segun se mueve la plataforma
            Vector3 end = points[currentPoint + 1].position; // Te saca el punto final que cambia segun se mueve la plataforma
            cube.position = Vector3.Lerp(start, end, t); // Lerp entre puntos con tiempo
            cube.right = -(start - end);// El lado derecho del cubo miarara siempre para la linea (Si no te importalo quitalo o si quieres cambai de rotacion pon otra cosa a parte de right)

            t += Time.deltaTime / Vector3.Distance(start, end) * speed;
            if (t >= 1)
        {
            t = 0;

            currentPoint++;
            if (currentPoint >= points.Count - 1) // Si es que llega al ultimo punto, el punto de inicio regresa al ultimo de la lista;
            {
                currentPoint = 0;
                if (pingpong)
                    points.Reverse(); // te revierte la lista haciendo que vayas alreves
            }

        }
        }

    }
}

