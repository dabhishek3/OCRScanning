namespace OCR.Text
{
    public class Block
    {
        public string Text { get; set; }
        public BoundingBox BoundingBox { get; set; }
        public int Lines { get; set; }
    }
}