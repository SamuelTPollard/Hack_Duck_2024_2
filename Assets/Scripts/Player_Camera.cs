using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Camera : MonoBehaviour
{
    Mouse mouse;
    public float hsens, vsens;
    Quaternion a;
    void Start()
    {
        mouse = Mouse.current;
    }

    void Update()
    {
        transform.Rotate(-mouse.delta.ReadValue().y * hsens * Time.deltaTime, mouse.delta.ReadValue().x * vsens * Time.deltaTime, 0);
        a = transform.rotation;
        a.eulerAngles = new Vector3(a.eulerAngles.x, a.eulerAngles.y, 0);
        transform.rotation = a;
    }
}
