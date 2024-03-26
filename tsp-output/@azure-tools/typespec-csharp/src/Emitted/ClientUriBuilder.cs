﻿// <auto-generated/>

#nullable enable

using System;
using System.Text;
namespace OpenAI.Emitted;

internal class ClientUriBuilder
{
    private UriBuilder? _uriBuilder;
    private StringBuilder? _pathBuilder;
    private StringBuilder? _queryBuilder;

    private UriBuilder UriBuilder => _uriBuilder ??= new();
    private StringBuilder PathBuilder => _pathBuilder ??= new(UriBuilder.Path);
    private StringBuilder QueryBuilder => _queryBuilder ??= new(UriBuilder.Query);

    public ClientUriBuilder()
    {
    }

    public void Reset(Uri uri)
    {
        _uriBuilder = new(uri);
        _pathBuilder = new(_uriBuilder.Path);
        _queryBuilder = new(_uriBuilder.Query);
    }

    public void AppendPath(string value, bool escape)
    {
        Argument.AssertNotNullOrWhiteSpace(value, nameof(value));

        if (escape)
        {
            value = Uri.EscapeDataString(value);
        }

        PathBuilder.Append(value);
        UriBuilder.Path = PathBuilder.ToString();
    }

    public void AppendQuery(string name, string value, bool escape)
    {
        Argument.AssertNotNullOrWhiteSpace(name, nameof(name));
        Argument.AssertNotNullOrWhiteSpace(value, nameof(value));

        if (QueryBuilder.Length is 0)
        {
            QueryBuilder.Append('?');
        }
        else
        {
            QueryBuilder.Append('&');
        }

        if (escape)
        {
            value = Uri.EscapeDataString(value);
        }

        QueryBuilder.Append(name);
        QueryBuilder.Append('=');
        QueryBuilder.Append(value);
    }

    public Uri ToUri()
    {
        if (_pathBuilder is not null)
        {
            UriBuilder.Path = _pathBuilder.ToString();
        }

        if (_queryBuilder is not null)
        {
            UriBuilder.Query = _queryBuilder.ToString();
        }

        return UriBuilder.Uri;
    }
}