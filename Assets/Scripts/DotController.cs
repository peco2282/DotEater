using UnityEngine;

public class DotController : MonoBehaviour
{
  public float top, bottom;
  private bool _toUp = true;


  private GameObject[] _objects;

  public int GetChildLength()
  {
    return _objects.Length;
  }

  private void Start()
  {
    _objects = new GameObject[transform.childCount];

    for (int i = 0; i < transform.childCount; i++)
    {
      _objects[i] = transform.GetChild(i).gameObject;
    }
  }

  // Update is called once per frame
  void Update()
  {
    if (transform.position.y > top)
    {
      _toUp = false;
    }

    if (transform.position.y < bottom)
    {
      _toUp = true;
    }

    transform.position += new Vector3(0, (float)((_toUp ? 1 : -1) * 0.02), 0);
    // transform.Translate(transform.position.x, transform.position.y + (float)((_toUp ? 1 : -1) * 0.2), transform.position.z);
  }
}