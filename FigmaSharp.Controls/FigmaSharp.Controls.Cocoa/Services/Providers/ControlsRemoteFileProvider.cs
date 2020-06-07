﻿// Authors:
//   jmedrano <josmed@microsoft.com>
//
// Copyright (C) 2020 Microsoft, Corp
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to permit
// persons to whom the Software is furnished to do so, subject to the
// following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
// NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
// USE OR OTHER DEALINGS IN THE SOFTWARE.
using FigmaSharp.Models;
using FigmaSharp.Services;

namespace FigmaSharp.Controls.Services
{
	public class ControlsRemoteFileProvider : RemoteNodeProvider
	{
		public ControlsRemoteFileProvider()
		{
		}

		public override IImageNodeRequest CreateEmptyImageNodeRequest(FigmaNode node)
			=> new ControlImageNodeRequest(node);

		public override bool SearchImageChildren(FigmaNode figmaNode)
			=> !(figmaNode.IsSingleImageViewNode() || (figmaNode.Parent?.HasNodeImageName() ?? false));

		public override bool RendersAsImage(FigmaNode figmaNode)
		{
			if (figmaNode.IsImageViewNode())
				return true;

			if (base.RendersAsImage(figmaNode))
				return true;

			return false;
		}
	}
}
