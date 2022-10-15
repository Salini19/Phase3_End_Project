using System;
using System.Reflection;

namespace EMS_Full_Stack_App_Requirement.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}