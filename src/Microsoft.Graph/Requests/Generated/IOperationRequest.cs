// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IOperationRequest.
    /// </summary>
    public partial interface IOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Operation using PUT.
        /// </summary>
        /// <param name="operationToCreate">The Operation to create.</param>
        /// <returns>The created Operation.</returns>
        System.Threading.Tasks.Task<Operation> CreateAsync(Operation operationToCreate);        /// <summary>
        /// Creates the specified Operation using PUT.
        /// </summary>
        /// <param name="operationToCreate">The Operation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Operation.</returns>
        System.Threading.Tasks.Task<Operation> CreateAsync(Operation operationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Operation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Operation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Operation.
        /// </summary>
        /// <returns>The Operation.</returns>
        System.Threading.Tasks.Task<Operation> GetAsync();

        /// <summary>
        /// Gets the specified Operation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Operation.</returns>
        System.Threading.Tasks.Task<Operation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Operation using PATCH.
        /// </summary>
        /// <param name="operationToUpdate">The Operation to update.</param>
        /// <returns>The updated Operation.</returns>
        System.Threading.Tasks.Task<Operation> UpdateAsync(Operation operationToUpdate);

        /// <summary>
        /// Updates the specified Operation using PATCH.
        /// </summary>
        /// <param name="operationToUpdate">The Operation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Operation.</returns>
        System.Threading.Tasks.Task<Operation> UpdateAsync(Operation operationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOperationRequest Expand(Expression<Func<Operation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOperationRequest Select(Expression<Func<Operation, object>> selectExpression);

    }
}