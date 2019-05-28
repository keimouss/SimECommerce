﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimECommerce.Web.TagHelpers
{
    [HtmlTargetElement(input, Attributes = ValidationAttributeName)]
    public class ValidationClassTagHelper : TagHelper
    {
        private const string ValidationAttributeName = "bootstrap-validation";
        private const string input = "input";
        private const string aspFor = "asp-for";
        private const string isInvalid = "is-invalid";
        private const string isValid = "is-valid";

        public ViewContext ViewContext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //base.Process(context, output);
            ViewContext.ViewData.ModelState.TryGetValue(GetTargetName(), out var entry);
            if (entry == null) return;
            switch (entry.ValidationState)
            {
                case ModelValidationState.Invalid:
                    SetClass(isInvalid);
                    return;
                case ModelValidationState.Valid:
                    SetClass(isInvalid);
                    return;
            }

            void SetClass(string cssClass)
            {
                var tagBuilder = new TagBuilder(input);
                tagBuilder.AddCssClass(cssClass);
                output.MergeAttributes(tagBuilder);
            }

            string GetTargetName() =>
            ((ModelExpression)context.AllAttributes[aspFor].Value).Name;
        }


    }
}
