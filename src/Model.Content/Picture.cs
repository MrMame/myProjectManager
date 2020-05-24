using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public class Picture : IPicture
    {
        #region "IPicture"
        public string PictureFilename { get; set; }
        #endregion

        #region "Factorymethods"
        public static Picture GetPicture(string Filename) { return new Picture(Filename); }
        #endregion


        #region "Private Constructors"
        private Picture(string Filename)
        {
            this.PictureFilename = Filename;
        }
        #endregion



    }
}
