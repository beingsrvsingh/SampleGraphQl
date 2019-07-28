using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleGraphQl.Type
{
    public class EmployeeSchema : Schema
    {
        public EmployeeSchema(IDependencyResolver resolver) : base(resolver)
        {
            // To test this just go to project properties Debug-launchbrowser-ui/playground
            Query = resolver.Resolve<EmployeeQuery>();
        }
    }
}
