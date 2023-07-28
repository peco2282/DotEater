using System.Diagnostics.CodeAnalysis;
using UnityEngine;

[SuppressMessage("ReSharper", "Unity.InefficientPropertyAccess")]
public class Player : MonoBehaviour
{
  public float moveSpeed = 3F;

  public float rotationSpeed = 360F;

  private CharacterController _characterController;

  private Animator _animator;

  private GameObject[] _gameObjects;

  private static readonly int Speed = Animator.StringToHash("Speed");
  // private static readonly int Speed = Animator.StringToHash("Speed");

  // Start is called before the first frame update
  private void Awake()
  {
    _gameObjects = GameObject.FindGameObjectsWithTag("Dot");
  }

  void Start()
  {
    _characterController = GetComponent<CharacterController>();
    _animator            = GetComponentInChildren<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
    Vector3 direction = new Vector3(
      Input.GetAxis("Horizontal"),
      0,
      Input.GetAxis("Vertical")
    );

    if (direction.sqrMagnitude > 0.01F)
    {
      var forward = Vector3.Slerp(
        transform.forward,
        direction,
        rotationSpeed * Time.deltaTime / Vector3.Angle(
          transform.forward,
          direction
        )
      );

      transform.LookAt(transform.position + forward);
    }

    _characterController.Move(direction * (moveSpeed * Time.deltaTime));

    _animator.SetFloat(Speed, _characterController.velocity.magnitude);
/*
    if (_gameObjects.Length == 0)
    {
      Application.LoadLevel("Win");
    }*/
  }
/*
  private void OnTriggerEnter(Collider other)
  {
    switch (other.tag)
    {
      case "Dot":
        Destroy(other.gameObject);
        break;
      case "Enemy":
        Application.LoadLevel("Lose");
        break;
    }
  }
  */
}