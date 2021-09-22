using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace
{
    class Player
    {
        Vector2 positionPlayer1 = new Vector2();
        float diameter1 = 2;
        float initialSpeedP1 = 4f;
        float changingSpeedP1;
        float maxSpeed = 35;
        float acceleration = 8f;
        float deceleration = 22f;
        int velocityInputX;
        int velocityInputY;

        private void InputBehaviour()
        {
            if (Input.GetAxisRaw("Horizontal") == 1)
            {
                velocityInputX = 1;
                if (changingSpeedP1 < initialSpeedP1)
                {
                    changingSpeedP1 = initialSpeedP1;
                }
                changingSpeedP1 = changingSpeedP1 + acceleration * Time.deltaTime;
                if (Input.GetAxis("Vertical") == 0)
                {
                    velocityInputY = 0;
                }
            }
            else if (Input.GetAxisRaw("Horizontal") == -1)
            {
                velocityInputX = -1;
                if (changingSpeedP1 < initialSpeedP1)
                {
                    changingSpeedP1 = initialSpeedP1;
                }
                changingSpeedP1 = changingSpeedP1 + acceleration * Time.deltaTime;
                if (Input.GetAxisRaw("Vertical") == 0)
                {
                    velocityInputY = 0;
                }
            }
            if (Input.GetAxisRaw("Vertical") == 1)
            {
                velocityInputY = 1;
                if (changingSpeedP1 < initialSpeedP1)
                {
                    changingSpeedP1 = initialSpeedP1;
                }
                changingSpeedP1 = changingSpeedP1 + acceleration * Time.deltaTime;
                if (Input.GetAxisRaw("Horizontal") == 0)
                {
                    velocityInputX = 0;
                }
            }
            else if (Input.GetAxisRaw("Vertical") == -1)
            {
                velocityInputY = -1;
                if (changingSpeedP1 < initialSpeedP1)
                {
                    changingSpeedP1 = initialSpeedP1;
                }
                changingSpeedP1 = changingSpeedP1 + acceleration * Time.deltaTime;
                if (Input.GetAxisRaw("Horizontal") == 0)
                {
                    velocityInputX = 0;
                }
            }
            if (Input.GetAxisRaw("Vertical") == 0 && Input.GetAxisRaw("Horizontal") == 0 && changingSpeedP1 > 0)
            {
                changingSpeedP1 = changingSpeedP1 - deceleration * Time.deltaTime;

            }
        }
        private void MovementPlayers()
        {
            positionPlayer1.x = positionPlayer1.x + velocityInputX * Time.deltaTime * changingSpeedP1;// accelerating, yellow
            positionPlayer1.y = positionPlayer1.y + velocityInputY * Time.deltaTime * changingSpeedP1;

            float horizontalNormalize = Input.GetAxis("Horizontal");
            float verticalNormalize = Input.GetAxis("Vertical");
            Vector2 normalizeDiagonal = new Vector2(horizontalNormalize, verticalNormalize);
            normalizeDiagonal.Normalize();
        }
    }
}
