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
  private AudioSource _source;

  private void Start()
  {
    _text          = textObject.GetComponent<TextMeshProUGUI>();
    _dotController = dotObject.GetComponent<DotController>();
    _source        = GetComponent<AudioSource>();
    _source.volume = 0.3F;
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Dot"))
    {
      Destroy(other.gameObject);
      _point++;
      _text.text = "Score: " + _point;
      _source.Play();
    }
    if (other.CompareTag("Enemy"))
    {
      SceneManager.LoadScene("Lose");
    }

    if (_point == _dotController.GetChildLength())
    {
      _source.Play();
      SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }
  }
}
