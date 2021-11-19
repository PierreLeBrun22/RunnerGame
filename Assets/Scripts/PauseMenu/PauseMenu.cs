
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    Transform UIPanel;

    [SerializeField] KeyCode keyPause;

	void Start () {
            hidePaused();
	}

	void Update () {

		if(Input.GetKeyDown(keyPause))
		{
			if(Time.timeScale == 1f)
			{
				Time.timeScale = 0f;
				showPaused();
			} else if (Time.timeScale == 0f){
				Time.timeScale = 1f;
				hidePaused();
			}
		}
	}

	public void showPaused(){
		 UIPanel.gameObject.SetActive(true);
	}

	public void hidePaused(){
         UIPanel.gameObject.SetActive(false);
	}

}