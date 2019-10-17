﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RoverTransmitter
{
    public class Bounds
    {
        public Bounds(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; protected set; }
        public int Height { get; protected set; }
    }
}