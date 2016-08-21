using System;

namespace TaskClient
{
    public class TodoItem
    {
        public DateTimeOffset? CreatedAt { get; set; }
        public bool Deleted { get; set; }
        public string Id { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public byte[] Version { get; set; }
        public string Text { get; set; }
        public bool Complete { get; set; }
    }
}
