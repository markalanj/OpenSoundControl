﻿/*
 * Copyright (C) Mark Alan Jones 2010
 * This code is published under the Microsoft Public License (Ms-Pl)
 * A copy of the Ms-Pl license is included with the source and 
 * binary distributions or online at
 * http://www.microsoft.com/opensource/licenses.mspx#Ms-PL
 */
namespace OpenSoundControl
{
    public class OscTrue : IOscDataType
    {
        #region IOscDataType Members

        public OscDataType DataType
        {
            get { return OscDataType.True; }
        }


        public bool HasArgumentData
        {
            get { return false; }
        }

        #endregion

        public override string ToString()
        {
            return "OscTrue";
        }
    }
}
