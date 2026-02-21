namespace Core.DTO
{
    public class UserCredentialsDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Algo { get; set; }
        public int Iterations { get; set; }
        public string SaltB64 { get; set; }
        public int DkLen { get; set; }
        public string HashB64 { get; set; }
    }
}
