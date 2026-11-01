
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3[] positions =
    {
        new Vector3(-3.71f, -2.53f, 0),
        new Vector3(-0.48f, -2.53f, 0),
        new Vector3(1.94f, 0.75f, 0),
        new Vector3(4.61f, -2.53f, 0)
    };

    public float speed = 4f;
    public float jumpDuration = 2f;

    bool isMoving = false;
    bool isJumping = false;

    float jumpProgress = 0f;

    Vector3 jumpStart;
    Vector3 jumpEnd;

    void Start()
    {
        transform.position = positions[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            if (transform.position == positions[3])
            {
                transform.position = positions[0];
            }

            isMoving = true;
        }

        if (!isMoving)
            return;

        // 第一階段：沿道路走到起跳點
        if (!isJumping)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                positions[1],
                speed * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, positions[1]) < 0.01f)
            {
                transform.position = positions[1];

                jumpStart = positions[1];
                jumpEnd = positions[3];

                jumpProgress = 0f;
                isJumping = true;
            }

            return;
        }

        // 第二階段：沿拋物線跳躍一次
        jumpProgress += Time.deltaTime / jumpDuration;

        float t = Mathf.Clamp01(jumpProgress);

        float x = Mathf.Lerp(jumpStart.x, jumpEnd.x, t);

        float baseY = Mathf.Lerp(jumpStart.y, jumpEnd.y, t);

        float height = positions[2].y - baseY;

        float y = baseY + 4f * height * t * (1f - t);

        transform.position = new Vector3(x, y, 0);

        // 抵達終點
        if (t >= 1f)
        {
            transform.position = positions[3];

            isJumping = false;
            isMoving = false;
        }
    }
}
