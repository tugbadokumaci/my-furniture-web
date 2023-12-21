using FurnitureWebAPI.Model;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Data.Common;

namespace FurnitureApi;


public class ProductRepository
{
    //private readonly ProductDbContext _context;

    //public ProductRepository(ProductDbContext context)
    //{
    //    _context = context;
    //    _context.
    //}



    //readonly MySqlDataSource database = new MySqlDataSource("Server=154.56.47.12; Database=u574456636_furniture_web; User=u574456636_tugba_web; Password=T96531533d*;");

    //public async Task<Product?> FindOneAsync(int ProductID)
    //{
    //    using var connection = await database.OpenConnectionAsync();
    //    using var command = connection.CreateCommand();
    //    command.CommandText = @"SELECT `ProductID`, `ProductName`, `ProductDescription` FROM `Product` WHERE `ProductID' = @ProductID";
    //    command.Parameters.AddWithValue("@ProductID", ProductID);
    //    var result = await ReadAllAsync(await command.ExecuteReaderAsync());
    //    return result.FirstOrDefault();
    //}

    //public async Task<IReadOnlyList<Product>> LatestPostsAsync()
    //{
    //    using var connection = await database.OpenConnectionAsync();
    //    using var command = connection.CreateCommand();
    //    command.CommandText = @"SELECT `ProductID`, `ProductName`, `ProductDescription`  ORDER BY `ProductID` DESC LIMIT 10;";
    //    return await ReadAllAsync(await command.ExecuteReaderAsync());
    //}

    //public async Task DeleteAllAsync()
    //{
    //    using var connection = await database.OpenConnectionAsync();
    //    using var command = connection.CreateCommand();
    //    command.CommandText = @"DELETE FROM `Product`";
    //    await command.ExecuteNonQueryAsync();
    //}

    //public async Task InsertAsync(Product product)
    //{
    //    using var connection = await database.OpenConnectionAsync();
    //    using var command = connection.CreateCommand();
    //    command.CommandText = @"INSERT INTO `Product` (`ProductName`, `ProductDescription`) VALUES (@ProductName, @ProductDescription);";
    //    BindParams(command, product);
    //    await command.ExecuteNonQueryAsync();
    //    product.ProductID = (int)command.LastInsertedId;
    //}

    //public async Task UpdateAsync(Product product)
    //{
    //    using var connection = await database.OpenConnectionAsync();
    //    using var command = connection.CreateCommand();
    //    command.CommandText = @"UPDATE `Product` SET `ProductName` = @ProductName, `ProductDescription` = @ProductDescription WHERE `ProductID` = @ProductID;";
    //    BindParams(command, product);
    //    BindId(command, product);
    //    await command.ExecuteNonQueryAsync();
    //}

    //public async Task DeleteAsync(Product product)
    //{
    //    using var connection = await database.OpenConnectionAsync();
    //    using var command = connection.CreateCommand();
    //    command.CommandText = @"DELETE FROM `Product` WHERE `ProductID` = @ProductID;";
    //    BindId(command, product);
    //    await command.ExecuteNonQueryAsync();
    //}

    //private async Task<IReadOnlyList<Product>> ReadAllAsync(DbDataReader reader)
    //{
    //    var posts = new List<Product>();
    //    using (reader)
    //    {
    //        while (await reader.ReadAsync())
    //        {
    //            var post = new Product
    //            {
    //                ProductID = reader.GetInt32(0),
    //                ProductName = reader.GetString(1),
    //                ProductDescription = reader.GetString(2),
    //                ProductStatus = reader.GetBoolean(0),
    //                ProductPrice = reader.GetDouble(3),

    //            };
    //            posts.Add(post);
    //        }
    //    }
    //    return posts;
    //}

    //private static void BindId(MySqlCommand cmd, Product product)
    //{
    //    cmd.Parameters.AddWithValue("@id", product.ProductID);
    //}

    //private static void BindParams(MySqlCommand cmd, Product product)
    //{
    //    cmd.Parameters.AddWithValue("@title", product.ProductName);
    //    cmd.Parameters.AddWithValue("@content", product.ProductDescription);
    //}

    //public void Dispose()
    //{
    //    throw new NotImplementedException();
    //}
}

