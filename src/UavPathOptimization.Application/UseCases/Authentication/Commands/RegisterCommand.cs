﻿using ErrorOr;
using MediatR;
using UavPathOptimization.Domain.Entities;

namespace UavPathOptimization.Application.UseCases.Authentication.Commands;

public record RegisterCommand(
    string UserName,
    string Email,
    string Password
) : IRequest<ErrorOr<AuthenticationResult>>;