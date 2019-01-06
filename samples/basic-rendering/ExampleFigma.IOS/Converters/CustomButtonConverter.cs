﻿
using UIKit;
using FigmaSharp;

namespace ExampleFigma.IOS
{
    public class CustomButtonConverter : CustomViewConverter
    {
        public override bool CanConvert(FigmaNode currentNode)
        {
            return (currentNode.name == "button" || currentNode.name == "button default") && currentNode is IFigmaDocumentContainer;
        }

        public override IViewWrapper ConvertTo(FigmaNode currentNode, ProcessedNode parent)
        {
            var button = new UIButton();
            button.SetTitle("test", UIControlState.Normal);
            return new ViewWrapper(button);
        }
    }
}