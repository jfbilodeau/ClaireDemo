public enum ChatResponseType
{
    Unknown = 1,
    Command,
    File,
    Explain,
}

public class ChatResponse
{
    public ChatResponseType Type { get; set; }
    public string? Response { get; set; }
    public string? FileName { get; set; }

}
