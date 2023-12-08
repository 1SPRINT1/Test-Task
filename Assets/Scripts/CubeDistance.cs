using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CubeDistance : MonoBehaviour
{
   // ссылки на трансформы кубов
   [Header("CubeTransforms")] 
  private Transform cube1;
  private Transform cube2;
  public GameObject allSphere;

  [Header("TextDistance")]
    public Text distanceText;
   // вычисление расстояния между центрами кубов
   private void Start()
   {
       cube1 = GameObject.Find("Cube1").transform;
       cube2 = GameObject.Find("Cube2").transform; 
   }

   private void Update()
   {
       
       float distance = Vector3.Distance(cube1.position, cube2.position);
       distanceText.text = distance.ToString("##");
       if (distance < 1)
       {
           SceneManager.LoadScene("Scene2");
       }

       if (distance < 2)
       {
           allSphere.SetActive(true);
       }
       else
       {
           allSphere.SetActive(false);
       }
   }
}
