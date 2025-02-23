namespace Qel.Api.Storage.Abstractions;

public interface IStorageRepository
{
    public Task UploadFile(Stream fileStream, CancellationToken cancellationToken = default);
    public Task<Stream> DownloadFileStream(string filePath, CancellationToken cancellationToken = default);
    public Task DeleteFile(string filePath, CancellationToken cancellationToken = default);
}
