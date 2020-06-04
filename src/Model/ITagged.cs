using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model
{
    public interface ITagged
    {
        List<Tag> Tags { get; set; }
    }
}
