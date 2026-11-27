namespace ScrumMate.Application.Common.Models;

/// <summary>Respuesta paginada estándar: { items, page, pageSize, total }.</summary>
public sealed record PaginaResultado<T>(IReadOnlyList<T> Items, int Page, int PageSize, int Total);
