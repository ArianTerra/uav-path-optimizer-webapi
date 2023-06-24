﻿using ErrorOr;

namespace UavPathOptimization.Domain.Common.Errors;

public static partial class Errors
{
    public static class OptimizePath
    {
        public static readonly Error SolutionError = Error.Validation(
            code: "OptimizePath.SolutionError",
            description: "Solution error."
        );
    }
}