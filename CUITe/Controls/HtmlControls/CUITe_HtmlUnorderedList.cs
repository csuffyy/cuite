﻿using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlUnorderedList : CUITe_HtmlCustom
    {
        private const string _tagName = "ul";

        public CUITe_HtmlUnorderedList()
            : base(_tagName)
        {
        }

        public CUITe_HtmlUnorderedList(string searchParameters)
            : base(_tagName, searchParameters)
        {
        }
    }
}