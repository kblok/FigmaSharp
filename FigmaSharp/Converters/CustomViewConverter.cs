﻿/* 
 * FigmaViewExtensions.cs - Extension methods for NSViews
 * 
 * Author:
 *   Jose Medrano <josmed@microsoft.com>
 *
 * Copyright (C) 2018 Microsoft, Corp
 *
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the
 * following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
 * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
 * NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
 * USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System.Collections.Generic;

namespace FigmaSharp
{
    public abstract class FigmaViewConverter : CustomViewConverter
    {
    }

    public abstract class CustomViewConverter
    {
        Dictionary<string, string> GetKeyValues (FigmaNode currentNode)
        {
            Dictionary<string, string> ids = new Dictionary<string, string>();


            return ids;
        }
     
        string GetValue (string identifier, string parameter)
        {
            var index = identifier.IndexOf($"{parameter}=", System.StringComparison.InvariantCultureIgnoreCase);
            if (index == -1)
            {
               
                var resto = identifier.Substring(index + $"{parameter}=".Length);
                var end = resto.IndexOf(" ", System.StringComparison.InvariantCultureIgnoreCase);

                string value;
                if (end == -1)
                {
                    return resto;
                }
                return resto.Substring(0, end);
            } else
            {
                return identifier;
            }
        }

        protected bool ContainsIdentifier (FigmaNode currentNode, string name)
        {
            if (currentNode.name.Length == 0)
            {
                return false;
            }
         

        }

        public abstract bool CanConvert(FigmaNode currentNode);

        public abstract IViewWrapper ConvertTo(FigmaNode currentNode, ProcessedNode parent);

        public abstract string ConvertToCode(FigmaNode currentNode, ProcessedNode parent);
    }
}
