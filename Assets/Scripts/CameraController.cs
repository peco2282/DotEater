using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
  private PlayerInput _input;
  void Start()
  {
    _input = GetComponent<PlayerInput>();
    Debug.Log(GetComponent<StarterAssetsInputs>().look = new Vector2(10, 10));
  }

}