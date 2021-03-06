﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePos(int position);
        public abstract string DisplayElements();
        public abstract Node GetElement(int position);
        public abstract void InsertFirst(Koltuk value);
        public abstract void InsertLast(Koltuk value);
        public abstract void InsertPos(int position, Koltuk value);

    }
}
