using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMovement : MonoBehaviour
{


    [SerializeField] public Transform[] points; // массив точек, к которым будет двигаться объект
    [SerializeField] public float speed = 5f; // скорость движения объекта

    private int currentPointIndex = 0; // индекс текущей точки, к которой движется объект

    void Update()
    {
        // вычисляем направление движения к текущей точке
        Vector3 direction = points[currentPointIndex].position - transform.position;

        // перемещаем объект в направлении текущей точки со скоростью speed
        transform.position += direction.normalized * speed * Time.deltaTime;

        // если объект достиг текущей точки, переключаемся на следующую точку
        if (direction.magnitude < 0.1f)
        {
            currentPointIndex++;
            if (currentPointIndex >= points.Length)
            {
                currentPointIndex = 0;
            }
        }
    }

}