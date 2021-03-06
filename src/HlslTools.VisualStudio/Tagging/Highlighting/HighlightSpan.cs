﻿using HlslTools.Text;

namespace HlslTools.VisualStudio.Tagging.Highlighting
{
    internal struct HighlightSpan
    {
        public TextSpan Span;
        public bool IsDefinition;

        public HighlightSpan(TextSpan span, bool isDefinition)
        {
            Span = span;
            IsDefinition = isDefinition;
        }
    }
}