using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace ASPNetDay1Intro.Helpers
{
    public static class ShowPriceHelper
    {
        public static MvcHtmlString ShowPrice<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression)
        {
            var name = ExpressionHelper.GetExpressionText(expression);

            var metaData = ModelMetadata.FromLambdaExpression(expression, helper.ViewData);

            var text = string.Format("{0} is {1:c}", name, metaData.Model);
            return MvcHtmlString.Create(text);
        }
    }
}