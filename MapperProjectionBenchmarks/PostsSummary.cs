public class PostsSummary
{
    public Guid Id { get; set; }
    public long TotalViews { get; set; }
    public long TotalLikes { get; set; }
    public long TotalCommentsReceived { get; set; }
    public long TotalMinutesWatched { get; set; }
    public long VideosCreated { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}