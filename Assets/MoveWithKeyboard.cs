using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float moveSpeed = 5f;  // 이동 속도

    void Update()
    {
        Vector3 moveDir = Vector3.zero;

        // 앞뒤 이동 (Z축)
        if (Input.GetKey(KeyCode.W))
        {
            moveDir += Vector3.forward; // 앞으로
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDir += Vector3.back;    // 뒤로
        }

        // 좌우 이동 (X축)
        if (Input.GetKey(KeyCode.A))
        {
            moveDir += Vector3.left;    // 왼쪽
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir += Vector3.right;   // 오른쪽
        }

        // 실제 이동 (Y축은 0으로 고정)
        transform.position += moveDir.normalized * moveSpeed * Time.deltaTime;
    }
}

