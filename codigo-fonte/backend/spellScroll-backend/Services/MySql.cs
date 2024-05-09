using MySqlConnector;

namespace spellScroll_backend;

public class MySql
{

    private static readonly MySqlConnection connection = new(new MySqlConnectionStringBuilder
    {
        Server = "spellscrollpuc.mysql.database.azure.com",
        UserID = "spellscroll",
        Password = "Pucm1n@s",
        SslMode = MySqlSslMode.Required,
    }.ConnectionString);

    public MySqlConnection GetConnection()
    {
        return connection;
    }
}
