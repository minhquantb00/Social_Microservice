using CQRS_Core.Commands;

namespace POST_CMD_API.Commands
{
    public class DeletePostCommand : BaseCommand
    {
        public string Username { get; set; }
    }
}
