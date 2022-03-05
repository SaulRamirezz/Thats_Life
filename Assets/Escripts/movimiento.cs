using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movimiento : MonoBehaviour
{

    NavMeshAgent player;
    public Transform puerta;
    public Transform cama;
    public Transform escritorio;
    public Transform escritorioremake;
    public Transform librero;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<NavMeshAgent>();
        //player.SetDestination(doorpoint.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.gameObject.name);
                interactuable variable = hit.transform.GetComponent<interactuable>();

                if (variable != null)
                {
                    switch (hit.transform.GetComponent<interactuable>().type)
                    {
                        case Interactibletype.puerta:
                            player.SetDestination(puerta.position);
                            hit.transform.GetComponent<interactuable>().use();
                            break;
                        case Interactibletype.escritorio:
                            player.SetDestination(escritorio.position);
                            hit.transform.GetComponent<interactuable>().use();
                            break;
                        case Interactibletype.librero:
                            player.SetDestination(librero.position);
                            hit.transform.GetComponent<interactuable>().use();
                            break;
                        case Interactibletype.cama:
                            player.SetDestination(cama.position);
                            hit.transform.GetComponent<interactuable>().use();
                            break;
                        case Interactibletype.escritorioremake:
                            player.SetDestination(escritorioremake.position);
                            hit.transform.GetComponent<interactuable>().use();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
