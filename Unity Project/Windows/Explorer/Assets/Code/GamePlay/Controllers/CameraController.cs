using UnityEngine;

using System.Collections;

public class CameraController : MonoBehaviour
{
    # region Drag Properties

    bool DragMoving;

    Vector2 Delta , DeltaSpeed;

    Vector2 CurrentMouse, OldMouse;

    # endregion

    # region Zoom Properties

    float InSpeed , OutSpeed , MaxZoom , MinZoom;

    Button ZoomInButton, ZoomOutButton;

    # endregion

    // Use this for initialization
	void Start ()
    {
        # region Drag

        DragMoving = false;

        Delta = new Vector2();
        DeltaSpeed = new Vector2();

        CurrentMouse = new Vector2();
        OldMouse = new Vector2();

        # endregion

        # region Zoom

        MaxZoom = -5;
        MinZoom = -20;

        InSpeed = 0.2f;
        OutSpeed = -0.2f;

        ZoomInButton = new Button("Buttons/ZoomIn" , new Vector2(Screen.width - 138 , Screen.height - 100));
        ZoomOutButton = new Button("Buttons/ZoomOut" , new Vector2(50 , Screen.height - 100));

        # endregion
    }
	
	// Update is called once per frame
	void Update ()
    {
        # region Drag

        if (SpaceController.CurrentState == GamePlayState.Space)
        {
            # region Mobile

            //if (Input.touchCount > 0)
            //{
            //    Touch CurrentTouch = Input.GetTouch(0);

            //    Delta = CurrentTouch.deltaPosition;

            //    Delta = -Delta;

            //    Delta.x = Mathf.Clamp(Delta.x, -0.25f, 0.25f);
            //    Delta.y = Mathf.Clamp(Delta.y, -0.25f, 0.25f);

            //    DeltaSpeed = Delta;

            //    DragMoving = true;
            //}
            //else
            //{
            //    DragMoving = false;
            //}

            # endregion

            # region PC & Web

            if (Input.GetMouseButton(0))
            {
                CurrentMouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

                Delta = OldMouse - CurrentMouse;

                Delta.x = Mathf.Clamp(Delta.x, -0.2f, 0.2f);
                Delta.y = Mathf.Clamp(Delta.y, -0.2f, 0.2f);

                DeltaSpeed = Delta;

                DragMoving = true;
            }
            else
            {
                DragMoving = false;
            }

            OldMouse = CurrentMouse;

            # endregion

            if (DragMoving)
            {
                Drag();

                DragMoving = false;
            }
        }

        # endregion

        # region Zoom

        # region Mobile

        //if (Input.touchCount == 2)
        //{
        //    Vector2 NewFirstTouch = Input.GetTouch(0).position;
        //    Vector2 NewSecondTouch = Input.GetTouch(1).position;

        //    Vector2 OldFirstTouch = NewFirstTouch - Input.GetTouch(0).deltaPosition;
        //    Vector2 OldSecondTouch = NewSecondTouch - Input.GetTouch(1).deltaPosition;

        //    float OldDistance = (OldFirstTouch - OldSecondTouch).magnitude;
        //    float NewDistance = (NewFirstTouch - NewSecondTouch).magnitude;

        //    float Distance = OldDistance - NewDistance;

        //    if (Distance > 0)
        //    {
        //        Zoom(InSpeed);
        //    }
        //    else if (Distance < 0)
        //    {
        //        Zoom(OutSpeed);
        //    }
        //}

        # endregion

        # region PC & Web

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            Zoom(InSpeed);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Zoom(OutSpeed);
        }

        # endregion

        # endregion
    }

    void OnGUI ()
    {
        # region Zoom

        ZoomInButton.DrawRepeat(GUIStyle.none);

        if (ZoomInButton.Clicked)
        {
            Zoom(InSpeed);
        }

        ZoomOutButton.DrawRepeat(GUIStyle.none);

        if (ZoomOutButton.Clicked)
        {
            Zoom(OutSpeed);
        }

        # endregion
    }

    void Drag ()
    {
        Vector3 NextPosition = transform.position + new Vector3(DeltaSpeed.x, DeltaSpeed.y, 0);

        //NextPosition.x = Mathf.Clamp(NextPosition.x, -17, 17);
        //NextPosition.y = Mathf.Clamp(NextPosition.y, -10, 10);

        transform.position = NextPosition;
    }

    void Zoom (float Speed)
    {
        Vector3 NextPosition = transform.position + new Vector3(0 , 0 , Speed);

        NextPosition.z = Mathf.Clamp(NextPosition.z , MinZoom , MaxZoom);

        transform.position = NextPosition;
    }
}