namespace ChatMalta.Domain.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
    }
}
