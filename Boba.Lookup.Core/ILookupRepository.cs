namespace BID.Application.Interfaces.Repositories;

public interface ILookupRepository
{
    /// <summary>
    /// Get all look entities
    /// </summary>
    /// <param name="entityType"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>IEnumerable<object></returns>
    Task<IEnumerable<object>> GetAllAsync(Type entityType, CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves a specific entity by its ID asynchronously.
    /// </summary>
    /// <param name="entityType">The type of the entity.</param>
    /// <param name="id">The ID of the entity.</param>
    /// <param name="cancellationToken">The token to cancel the operation.</param>
    /// <returns>An object representing the entity.</returns>
    Task<object> GetByIdAsync(Type entityType, int id, CancellationToken cancellationToken);

    /// <summary>
    /// Adds a new entity asynchronously.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    /// <param name="cancellationToken">The token to cancel the operation.</param>
    /// <returns>The ID of the newly added entity.</returns>
    Task<int> AddAsync(object entity, CancellationToken cancellationToken);

    /// <summary>
    /// Updates an existing entity asynchronously.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    /// <param name="cancellationToken">The token to cancel the operation.</param>
    Task UpdateAsync(object entity, CancellationToken cancellationToken);

    /// <summary>
    /// Deletes an existing entity asynchronously.
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    /// <param name="cancellationToken">The token to cancel the operation.</param>
    Task DeleteAsync(object entity, CancellationToken cancellationToken);
}
