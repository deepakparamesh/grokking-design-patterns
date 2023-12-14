﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.strategy.CompressorStrategy
{
    public class PNGCompressor : ICompressorStrategy
    {
        public void compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
