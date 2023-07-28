using UnityEngine;

public class CameraController : MonoBehaviour
{
  [SerializeField] private GameObject player;

  // Update is called once per frame
  void Update()
  {
    var position = player.transform.position;
    transform.position = new Vector3(
      position.x,
      position.y + 10,
      position.z
    );
  }
}