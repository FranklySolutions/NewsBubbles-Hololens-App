using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExpantionController : MonoBehaviour
{
    public Vector3 endPosition, endposModified;
    private float startTime;
    public float totalTime;
    private Vector3 startPosition;
    bool hasmoved;
    private Coroutine movement = null;

    public Vector3 startScale, endScale;

    private void Start()
    {
        startPosition = transform.position;
        startScale = transform.localScale;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(endPosition, Vector3.one);
    }

    public void OnTap()
    {
        if (movement != null)
            StopCoroutine(movement);

        startTime = Time.time;
        endposModified = endPosition + transform.parent.position;
        movement = StartCoroutine(Expand(hasmoved));

        hasmoved = !hasmoved;
    }

    IEnumerator Expand(bool hasmoved)
    {
        while (true)
        {
            float amountTraveled = (Time.time - startTime);
            float t = amountTraveled / totalTime;

            var material = GetComponent<MeshRenderer>().material;

            if (!hasmoved)
            {
                gameObject.transform.position = Vector3.Lerp(startPosition, endposModified, t);
                gameObject.transform.localScale = Vector3.Lerp(startScale, endScale, t);
                material.color = new Color(material.color.r, material.color.g, material.color.b, t);
            }
            else
            {
                gameObject.transform.position = Vector3.Lerp(endposModified, startPosition, t);
                gameObject.transform.localScale = Vector3.Lerp(endScale, startScale, t);
                material.color = new Color(material.color.r, material.color.g, material.color.b, 1f - t);
            }



            if (gameObject.transform.position.y == endPosition.y)
            {
                StopCoroutine(movement);
            }

            yield return new WaitForSeconds(0.01f);
        }
    }
}