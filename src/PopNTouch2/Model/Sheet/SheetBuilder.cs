﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopNTouch2.Model
{
    public class SheetBuilder
    {
        public Song Song
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Difficulty Difficulty
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Instrument Instrument
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public NoteFactory NoteFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public SheetMusic buildSheet(Song song, Instrument instr, Difficulty diff)
        {
            SheetMusic sheetMusic = new SheetMusic();
            return sheetMusic;
        }
    }
}