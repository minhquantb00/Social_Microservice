using CQRS_Core.Commands;

namespace POST_CMD_API.Commands
{
    public class AddCommentCommand : BaseCommand
    {
        public string Comment { get; set; }
        public string Username { get; set; }
    }
}
