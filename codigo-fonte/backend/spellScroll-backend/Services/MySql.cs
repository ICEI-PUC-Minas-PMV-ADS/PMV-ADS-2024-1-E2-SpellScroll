using MySqlConnector;

namespace spellScroll_backend;

public class MySql
{

    // Carece conexão com o bando de dados cloud
    private static readonly MySqlConnection connection = new(new MySqlConnectionStringBuilder
    {
        Server = "serverhost",
        UserID = "userId",
        Password = "pass",
        SslMode = MySqlSslMode.Required,
    }.ConnectionString);

    public MySqlConnection GetConnection()
    {
        return connection;
    }
}
