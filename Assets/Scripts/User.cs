public class User {
    public string username;
    public string email;
    public string password;
    public int points;
    public string characterId;

    public User() {
    }

    public User(string username, string email, string password, int points, string characterId) {
        this.username = username;
        this.password = password;
        this.email = email;
        this.points = points;
        this.characterId = characterId;
    }
}