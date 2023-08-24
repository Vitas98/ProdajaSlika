namespace ProdajaSlika.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int CanvasTypeId { get; set; }
        public CanvasType? CanvasType { get; set; }
        public int FrameTypeId { get; set; }
        public FrameType? FrameType { get; set; }
        public int PictureHeight { get; set; }
        public int PictureWidth { get; set; }
        public bool IsSpecialOffer { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string? Description { get; set; }
    }
}
