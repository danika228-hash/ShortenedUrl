﻿namespace Application.Responses;

public class BaseResponse<T>
{
    public T? Data { get; set; }
    public string? Error { get; set; }
}