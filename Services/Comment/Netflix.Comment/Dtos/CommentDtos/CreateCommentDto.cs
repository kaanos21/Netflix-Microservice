namespace Netflix.Comment.Dtos.CommentDtos
{
    public class CreateCommentDto
    {
        public int ContentId { get; set; }
        public string Name { get; set; }
        public string CommentText { get; set; }
        public DateTime Date { get; set; }
    }
}
