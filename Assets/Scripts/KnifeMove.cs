using UnityEngine;

public class KnifeMove : MonoBehaviour
{
    public float speed = 5f;
    private void Update()
    {
        if (StartGame.isStart)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);
            if (transform.position.x <= -6.5f)
                Destroy(gameObject);
        }
    }
}
