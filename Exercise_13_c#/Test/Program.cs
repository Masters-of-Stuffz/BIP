﻿using Linklaget;
using Transportlaget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
			var transport = new Transport (1000);
			var buffer = new Byte[1000];

			buffer = Encoding.ASCII.GetBytes("Kage");
			transport.send(buffer, buffer.Length);
        }
    }
}
