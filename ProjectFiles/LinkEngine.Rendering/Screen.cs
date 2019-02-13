﻿using System.Drawing;
using System.Windows.Forms;

namespace LinkEngine.Rendering
{
    public class Screen
    {
        public Form GameForm;
        public Panel MapPane;

        public int Width, Height;
        public int pWidth, pHeight;

        Bitmap[,] Tiles;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_width"></param>
        /// <param name="_height"></param>
        /// <param name="_pwidth"></param>
        /// <param name="_pheight"></param>
        public Screen (int _width, int _height, int  _pwidth, int _pheight)
        {
            // set values
            Width = _width;
            Height = _height;
            pWidth = _pwidth;
            pHeight = _pheight;

            // create a new game form
            GameForm = new Form
            {
                BackColor = Color.White,
                Size = new Size(Width * pWidth, Height * pHeight),
                FormBorderStyle = FormBorderStyle.None,
            };

            // create new map pane
            MapPane = new Panel
            {
                Size = new Size(Width * pWidth, Height * pHeight),
                Name = "MapPane"
            };
            MapPane.Location = new Point((GameForm.Width / 2) - (MapPane.Width / 2), (GameForm.Height / 2) - (MapPane.Height / 2));

            GameForm.Controls.Add(MapPane);

            // Initialize a new array
            Tiles = new Bitmap[Height, Width];
        }

        /// <summary>
        /// Takes a given bitmap and sets it as the Image for the PictureBox at the given x and y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="bitmap"></param>
        public void Draw (int x, int y, Bitmap bitmap)
        {
            // set the image of the tile to the given bitmap
            Tiles[y, x] = bitmap;
            redraw();
        }

        void redraw ()
        {
            //int i = 0;
            //foreach (PictureBox pb in Tiles)
            //{
            //    ((PictureBox)MapPane.Controls[i]).Image = pb.Image;
            //    i++;
            //}
        }
    }

    
}
