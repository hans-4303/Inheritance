using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hp = 50;

    public int gold = 1000;

    private Rigidbody2D m_rigidbody;

    private readonly float speed = 3f;
    private readonly float jumpSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentVelocity = m_rigidbody.velocity;
        float horizontal = Input.GetAxis("Horizontal");
        currentVelocity.x = horizontal * speed;

        if (Input.GetButtonDown("Jump"))
        {
            currentVelocity.y = jumpSpeed;
        }

        m_rigidbody.velocity = currentVelocity;
    }

    /// <summary>
    /// <para>
    ///     인터페이스 외의 구현된 내용은 못 다루지만
    ///     인터페이스가 강제하는 메서드는 호출할 수 있음
    /// </para>
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D (Collider2D collision)
    {
        IItem item = collision.GetComponent<IItem>();
        item?.Use();

    }
}
