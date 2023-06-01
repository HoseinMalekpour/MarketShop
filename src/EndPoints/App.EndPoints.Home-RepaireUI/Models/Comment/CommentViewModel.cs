namespace App.EndPoints.Home_RepaireUI.Models.Comment
{

    public class CommentViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public int BoothId { get; set; }
        public string BoothName { get; set; }
        public int OrderId { get; set; }
        public bool IsCreated { get; set; }
        public bool IsDeleted { get; set; }

    }
}
