﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopNTouch2.Model
{
    public class SheetMusic
    {
        public List<Note> Notes { get; set; }
        public List<IBonus> Bonuses { get; set; }

        public SheetMusic()
        {
            this.Notes = new List<Note>();
            this.Bonuses = new List<IBonus>();
        }
    }
}
