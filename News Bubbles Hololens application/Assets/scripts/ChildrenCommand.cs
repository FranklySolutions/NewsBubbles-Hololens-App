/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChildrenCommand : MonoBehaviour
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
    // Called by GazeGestureManager when the user performs a Select gesture
    private void OnSelect()
    {
        Debug.Log("Select Called");
        // If the sphere has no Rigidbody component, add one to enable physics.
        if (!this.GetComponent<Rigidbody>())
        {
            
        }

        if (movement != null)
            StopCoroutine(movement);

        startTime = Time.time;
        endposModified = endPosition + transform.parent.position;
        Debug.Log("this is endposModified: ",endposModified);
        movement = StartCoroutine(Expand(hasmoved));

        hasmoved = !hasmoved;
    }

    IEnumerator Expand(bool hasmoved)
    {
        while (true)
        {
            float amountTraveled = (Time.time - startTime);
            float t = amountTraveled / totalTime;

            Material[] material = GetComponent<MeshRenderer>().materials;

            if (!hasmoved)
            {
                gameObject.transform.position = Vector3.Lerp(startPosition, endposModified, t);
                gameObject.transform.localScale = Vector3.Lerp(startScale, endScale, t);
                foreach (var mat in material)
                {
                    mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, t);
                }
            }
            else
            {
                gameObject.transform.position = Vector3.Lerp(endposModified, startPosition, t);
                gameObject.transform.localScale = Vector3.Lerp(endScale, startScale, t);
                foreach (var mat in material)
                {
                    mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, 1f- t);
                }
            }



            if (gameObject.transform.position.y == endPosition.y)
            {
                StopCoroutine(movement);
            }

            yield return new WaitForSeconds(0.01f);
        }
    }
}
*/