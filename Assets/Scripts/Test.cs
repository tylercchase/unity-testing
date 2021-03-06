using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Declare stuff for getting bounding stuff
    public GameObject m_MyObject, m_NewObject;
    Collider m_Collider, m_Collider2;

    [SerializeField]
    public bool[,] CollisionSpaces = new bool[100,100];
    // Start is called before the first frame update
    void Start()
    {
        if (m_MyObject != null)
            m_Collider = m_MyObject.GetComponent<Collider>();
        if (m_NewObject != null)
            m_Collider2 = m_NewObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, Time.deltaTime, 0, Space.World);
        if (m_Collider.bounds.Intersects(m_Collider2.bounds))
        {
            Vector3 relativeIntersection = (transform.position - m_NewObject.transform.position);
            Debug.Log(relativeIntersection);

            int xIndex = (int)(relativeIntersection.x + 5 * 10);
            int yIndex = (int)(relativeIntersection.y + 5 * 10);

            CollisionSpaces[xIndex,yIndex] = true;
        }
    }
}
