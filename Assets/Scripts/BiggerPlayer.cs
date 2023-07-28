using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BiggerPlayer : MonoBehaviour
{
  private int _point = 0;
  public GameObject textObject;
  public GameObject dotObject;
  private TextMeshProUGUI _text;
  private DotController _dotController;

  private void Start()
  {
    _text          = textObject.GetComponent<TextMeshProUGUI>();
    _dotController = dotObject.GetComponent<DotController>();
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Dot"))
    {
      Destroy(other.gameObject);
      _point++;
      _text.text = "Score: " + _point;
    }
    if (other.CompareTag("Enemy"))
    {
      SceneManager.LoadScene("Lose");
    }

    if (_point == _dotController.GetChildLength())
    {
      SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }
  }
}
