using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model
{
    public class Tag
    {
        public string TagString { get; set; }

        #region "Factory Methods"
        public static Tag GetTag()
        {
            return new Tag();
        }
        public static Tag GetTag(string TagString)
        {
            return new Tag(TagString);
        }
        #endregion


        #region "PrivateConstructors"
        private Tag()
        {
            this.TagString = "";
        }
        private Tag(string TagString)
        {
            this.TagString = TagString;
        }
        #endregion



    }
}
