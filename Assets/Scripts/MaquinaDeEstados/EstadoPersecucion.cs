using UnityEngine;
using System.Collections;

public class EstadoPersecucion : MonoBehaviour {

    public Color ColorEstado = Color.red;

    private MaquinaDeEstados maquinaDeEstados;
    private ControladorNavMesh controladorNavMesh;
    private ControladorVision controladorVision;

	void Awake () {
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
        controladorNavMesh = GetComponent<ControladorNavMesh>();
        controladorVision = GetComponent<ControladorVision>();
	}


	
	void Update () {
        RaycastHit hit;
        if(!controladorVision.PuedeVerAlJugador(out hit, true))
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAlerta);
            return;
        }

        controladorNavMesh.ActualizarPuntoDestinoNavMeshAgent();    
	}
}
