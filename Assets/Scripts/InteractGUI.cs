using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractGUI : MonoBehaviour
{
    public float distancia = 2.0f;
    public GameObject text1;
    GameObject ultimoReconocido;
    public HandleKey hk;

    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        DeselectObj();
        if (hk.key)
        {

        }
        else
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distancia))
            {

                DeselectObj();

                if (hit.collider.tag == "PuertaBloqueada")
                {

                    SelectedObj(hit.transform);
                }
                else
                {
                    DeselectObj();
                }

            }


        }

    }


    void SelectedObj(Transform transform)
    {
        ultimoReconocido = transform.gameObject;
    }

    void DeselectObj()
    {
        if (ultimoReconocido)
        {
            ultimoReconocido = null;
        }
    }

    void OnGUI()
    {
        if (ultimoReconocido)
        {
            text1.SetActive(true);
        }
        else
        {
            text1.SetActive(false);
        }
    }
}
