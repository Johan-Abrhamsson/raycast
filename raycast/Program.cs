﻿using System;
using Raylib_cs;

namespace Kuddkrig
{
    class Program
    {
        public class player
        {
            float playerY = 0;
            float playerX = 0;
            float playerA = 0;
        }
        public class block
        {
            int blockid = 0;
            int blockX = 0;
            int blockY = 0;
        }

        public enum mapSelect
        {
            map0,
            map1,
            map2,
            map3
        }

        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "");

            int mapTarget = 0;
            int mapDisplay = 1;
            char[,] mapP1 = {
                {'B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B'},
                {'B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ','E',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','E',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ',' ',' ',' ','P',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ','E',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B'},
                };
            char[] mapP1D1 = { 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', 'B', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', 'B', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', 'B', ' ', 'E', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'E', ' ', ' ', 'B', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', 'B', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', 'B', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'P', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', 'B', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', 'B', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', 'B', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', 'B', 'B', 'B', ' ', ' ', ' ', 'E', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', ' ', 'B', 'B', ' ', ' ', ' ', ' ', 'B', 'B', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B' };
            char[,] mapP2 = {
                {'B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B'},
                {'B','P',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ','B',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ','B',' ','B',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ','E',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ','E','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ','B','E',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ','B'},
                {'B',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B'},
                {'B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B','B'},
                };

            //Ska jag värkligen göra en raycasting och inte bara top down?
            float playerY = 5;
            float playerX = 5;
            float playerA = 0;
            float playerASpeed = 0.05f;
            int mapScale = 10;
            float screenWidth = 800;
            float screenHeight = 600;
            float fov = 3.14159f / 4.0f;
            float depth = 2.0f;

            float[,] playerPos = {
            { playerY},
            { playerX},
            };
            float playerXSpeed = 0f;
            float playerYSpeed = 0f;
            float playerSpeedIncr = 0.0001f;
            float playerSpeedDecr = 0.0001f;
            bool playerLock = false;
            int playerStill = 0;
            mapSelect map = mapSelect.map0;
            while (!Raylib.WindowShouldClose())
            {
                //Map selector
                if (mapTarget == 0)
                {
                    switch (mapDisplay)
                    {
                        case 1:
                            map = mapSelect.map1;

                            break;
                        case 2:
                            map = mapSelect.map2;
                            break;
                        default:
                            Raylib.DrawText("Text Not found.", 200, 100, 50, Color.RED);
                            break;
                    }
                    mapDisplay++;
                    mapTarget = 1;
                }
                //Drawing begins
                Raylib.BeginDrawing();


                Raylib.ClearBackground(Color.BLACK);

                int offsetX = 50;
                int offsetY = 50;

                //map writeing
                for (int y = 0; y < mapP1.GetLength(0); y++)
                {
                    for (int x = 0; x < mapP1.GetLength(1); x++)
                    {
                        int yLook = -15;
                        int offset = 15;
                        int collumnNumber = 0;
                        //antalet strålar som vi skickar ut är ett konstant värde
                        //i forloopen går vi mellan -15 och 15 med ett steg av 0.1 vilket betyder att vi kommer att skicka ut 30 / 0.1 strålar
                        int numberOfRays = 300;

                        for (float xLook = -offset; xLook <= offset; xLook += 0.1f)
                        {
                            //för att veta vart du ska placera varje kollumn håller du koll på varje stråles ordning
                            //sen ritar du kollumnerna i den ordning de kom
                            collumnNumber += 1;
                            //vi räknar ut lutningen av linjen (strålen) som formas av de två punkterna (0, 0) och (x, y)
                            //vi vill dock ha lutningen relativ till y, så istället för y = kx + m vill vi ha x = ky + m
                            //(m för varje linje (stråle) kommer vara noll btw så vi ingnorerar m)
                            //anledningen till det här är för att linjen som bildas när punkterna (playerX, playerY) och (x, y) har samma x-koordinat inte kommer
                            //att ha 'oändlig' lutning relativ till x eftersom den går rakt upp. Det här ger oss ett problem, vilket är varför vi vill ha lutningen
                            //relativ till y

                            float gradient = xLook / yLook; //detta är samma sak som (x - 0) / (y - 0) vanligtvis skulle vi använda (y2 - y1) / (x2 - x1) men vi vill ha lutningen
                                                            //relativ till y så vi gör (x2 - x1) / (y2 - y1)

                            bool collision = false;
                            //om strålen kolliderar med något sätter vi denna till true
                            float y2Look = 0;

                            while (collision == false && y2Look >= yLook)
                            {
                                y2Look -= 0.01f;

                                float x2Look = y2Look * gradient;
                                //x = ky + m, där m = 0

                                //nu när vi har både x2 och y2 vill vi rotera dem med playerAngle runt origo
                                float rotatedX = 0;
                                float rotatedY = 0;

                                rotatedX = (float)Math.Cos(playerA) * y2Look - (float)Math.Sin(playerA) * x2Look;
                                rotatedY = (float)Math.Sin(playerA) * y2Look + (float)Math.Cos(playerA) * x2Look;

                                try
                                {
                                    //jag har detta i ett try block eftersom det kan hända att vi försöker kolla i ett index som inte finns med i 2D arrayen för mappen
                                    //vilket skulle ge oss ArrayIndexOutOfBoundsException
                                    if (map == mapSelect.map1)
                                    {
                                        if (mapP1[(int)(rotatedY + playerY), (int)(rotatedX + playerX)] == 'B')
                                        {
                                            collision = true;
                                            float rayLength = Math.Abs(y2Look);
                                            //fill bestämmer färgen som kommer att användas när vi ritar något på skärmen
                                            //för att göra det lite enklare att förstå hur långt borta föremål är så kan vi göra så att föremål som är längre bort också är mörkare
                                            if (rayLength > 0 || rayLength > depth)
                                            {
                                                float fill = 255.0f / rayLength;
                                                Color fillcolor = new Color((int)fill, (int)fill, (int)fill, 255);
                                                //tjockleken på varje kollumn kommer vara en konstant. För att få kollumnerna att täcka hela skärmen gör vi tjockleken
                                                //till antal strålar (vilket också är antal kollumner) delat på tjockleken av fönstret
                                                Raylib.DrawRectangle(((int)(collumnNumber * (screenWidth / numberOfRays))), (int)((screenHeight / 2) - (screenHeight / rayLength) * 0.5), (int)(screenWidth / numberOfRays), (int)(screenHeight / rayLength), fillcolor);
                                                //rect tar start position för x, start position för y, bredd, höjd
                                                //du får implementera din egen funktion för att rita rektanglar
                                                //det är viktigt att de ritas utåt från mitten
                                            }
                                        }
                                    }
                                }
                                catch
                                {
                                    //att fortsätta kolla efter kollisioner för detta tillfälle är onödigt så vi bryter ut ur while-loopen
                                    break;
                                }
                            }
                        }
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                    {
                        playerX += (float)Math.Cos(playerA) * playerASpeed;
                        playerY -= (float)Math.Sin(playerA) * playerASpeed;

                    }
                    else if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                    {
                        playerX -= (float)Math.Cos(playerA) * playerASpeed;
                        playerY += (float)Math.Sin(playerA) * playerASpeed;

                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                    {
                        playerX += (float)Math.Cos(playerA) * playerASpeed;
                        playerY += (float)Math.Sin(playerA) * playerASpeed;

                    }
                    else if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                    {
                        playerX -= (float)Math.Cos(playerA) * playerASpeed;
                        playerY -= (float)Math.Sin(playerA) * playerASpeed;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    {
                        playerA = playerA - playerASpeed;

                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                    {
                        playerA = playerA + playerASpeed;

                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
                    {
                        mapTarget = 0;
                        playerLock = false;
                        playerXSpeed = 0;
                        playerYSpeed = 0;
                        playerX = 0;
                        playerY = 0;
                    }


                    Raylib.EndDrawing();
                }
            }
        }
    }
}
