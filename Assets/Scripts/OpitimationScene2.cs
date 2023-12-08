using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class OpitimationScene2 : MonoBehaviour
{
    public GameObject prefab; // префаб объекта
    public float sphereRadius = 5f; // радиус сферы
    public int objectsCount = 1000000; // количество объектов
    public float speed = 3f; // скорость движения

    private List<GameObject> objectsList = new List<GameObject>(); // список созданных объектов

    void Start()
    {
        for (int i = 0; i < objectsCount; i++)
        {
            Vector3 position = Random.insideUnitSphere * sphereRadius; // случайная позиция внутри сферы
            GameObject
                obj = Instantiate(prefab, position,
                    Quaternion.identity); // создание объекта из префаба на случайной позиции
            objectsList.Add(obj); // добавление объекта в список
        }
    }

    void Update()
    {
        foreach (GameObject obj in objectsList)
        {
            Vector3 position = obj.transform.position; // текущая позиция объекта
            Vector3 direction = Random.insideUnitSphere; // случайное направление движения
            position += direction * speed * Time.deltaTime; // перемещение объекта по направлению со скоростью
            if (position.magnitude > sphereRadius
            ) // если объект выходит за пределы сферы, отражаем его от поверхности сферы
            {
                position = position.normalized * sphereRadius * 2 - position;
            }

            obj.transform.position = position; // обновление позиции объекта
        }
    }
}
