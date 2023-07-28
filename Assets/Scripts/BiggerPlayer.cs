using UnityEngine;
using UnityEngine.SceneManagement;

public class BiggerPlayer : MonoBehaviour
{
  private int point = 0;
  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Dot"))
    {
      Destroy(other.gameObject);
      point++;
    }
    if (other.CompareTag("Enemy"))
    {
      SceneManager.LoadScene("Lose");
    }
    Debug.Log(point);
    if (Input.GetKey(KeyCode.I))
    {
      
    }
  }
}
