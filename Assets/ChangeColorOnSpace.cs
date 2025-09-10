using UnityEngine;

public class ChangeColorOnSpace : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        // 자기 자신 또는 자식 오브젝트에서 Renderer 찾기
        rend = GetComponentInChildren<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rend != null)
            {
                rend.material.color = new Color(Random.value, Random.value, Random.value);
            }
            else
            {
                Debug.LogWarning("Renderer를 찾을 수 없습니다!");
            }
        }
    }
}
