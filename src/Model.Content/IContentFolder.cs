﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public interface IContentFolder
    {
        List<IContent> Contents { get; set; } 
    }
}