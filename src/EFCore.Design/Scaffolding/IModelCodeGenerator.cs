﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Microsoft.EntityFrameworkCore.Scaffolding
{
    /// <summary>
    ///     Used to generate code for a model.
    /// </summary>
    public interface IModelCodeGenerator : ILanguageBasedService
    {
        /// <summary>
        ///     Generates code for a model.
        /// </summary>
        /// <param name="model"> The model. </param>
        /// <param name="namespace"> The namespace. </param>
        /// <param name="contextDir"> The directory of the <see cref="DbContext"/>. </param>
        /// <param name="contextName"> The name of the <see cref="DbContext"/>. </param>
        /// <param name="connectionString"> The connection string. </param>
        /// <param name="dataAnnotations"> A value indicating whether to use data annotations. </param>
        /// <returns> The generated model. </returns>
        ScaffoldedModel GenerateModel(
            [NotNull] IModel model,
            [NotNull] string @namespace,
            [NotNull] string contextDir,
            [NotNull] string contextName,
            [NotNull] string connectionString,
            bool dataAnnotations);
    }
}
