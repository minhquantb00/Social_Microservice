using CQRS_Core.Commands;

namespace POST_CMD_API.Commands
{
    public class NewPostCommand : BaseCommand
    {
        public string Author { get; set; }
        public string Message { get; set; }
    }
}
