using System;

namespace Limiting_WebApiThrottle.Areas.HelpPage.ModelDescriptions
{
    public class ParameterAnnotation
    {
        public Attribute AnnotationAttribute { get; set; }

        public string Documentation { get; set; }
    }
}