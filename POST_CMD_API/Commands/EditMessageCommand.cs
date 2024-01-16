using CQRS_Core.Commands;

namespace POST_CMD_API.Commands
{
    public class EditMessageCommand : BaseCommand
    {
        public string Message { get; set; }
    }
}
