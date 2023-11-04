using UnityEngine;
using System.Collections;
/**
* A script to reproduce the effect of the scrolling text in Star Wars
* By: Liv Erickson
* http://livierickson.com 
**/
namespace QDS.MushWars
{
    public class IntroScreen : Screen
    {
        private bool isScrolling; // We'll use this for debugging
        private float rotation;   // Default 55deg, but read in from canvas
                                  // Start the scrolling effect on load
        void Start()
        {
            Setup();
        }

        // Set up the initial variables
        void Setup()
        {
            _cameraSystem.SwitchOrthographic(false);
            isScrolling = true;
            rotation = gameObject.GetComponentInParent<Transform>().eulerAngles.x;
        }

        // Update is called once per frame
        void Update()
        {
            // If we are scrolling, perform update action
            if (isScrolling)
            {
                // Get the current transform position of the panel
                Vector3 _currentUIPosition = gameObject.transform.position;
                // Increment the Y value of the panel 
                Vector3 _incrementYPosition =
                 new Vector3(_currentUIPosition.x,
                             _currentUIPosition.y + .03f * Mathf.Sin(Mathf.Deg2Rad * rotation),
                             _currentUIPosition.z + .03f * Mathf.Cos(Mathf.Deg2Rad * rotation));
                // Change the transform position to the new one            
                gameObject.transform.position = _incrementYPosition;
            }
            if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
            {
                isScrolling = false;
            }

            if (!isScrolling)
            {
                _cameraSystem.SwitchOrthographic(true);                
                _screenSystem.ShowScreen(GameScreens.SelectMission, true);
            }
        }
    }
}