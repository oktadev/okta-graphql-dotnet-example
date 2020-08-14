using HotChocolate.Types;
using TimeGraphServer.Models;

namespace TimeGraphServer.GraphQL
{
    public class ProjectType : ObjectType<Project>
    {
    }

    public class TimeLogType : ObjectType<TimeLog>
    {
        protected override void Configure(IObjectTypeDescriptor<TimeLog> descriptor)
        {
            descriptor.Authorize();
        }
    }
}
