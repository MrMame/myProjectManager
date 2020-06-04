using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace myProjectManager.Model
{
    public interface IContentFolder
    {
        //List<IContent> Contents { get; set; }

        void AddContent(IContent item);
        void RemoveContent(IContent item);
        ReadOnlyCollection<IContent> ReadOnlyContentsList{ get; }


    }
}
