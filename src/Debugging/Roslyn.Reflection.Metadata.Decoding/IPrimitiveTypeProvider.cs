// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if SRM
namespace System.Reflection.Metadata.Decoding
#else
namespace Roslyn.Reflection.Metadata.Decoding
#endif
{
#if SRM && FUTURE
    public
#endif
    interface IPrimitiveTypeProvider<TType>
    {
        /// <summary>
        /// Gets the type symbol for a primitive type.
        /// </summary>
        TType GetPrimitiveType(PrimitiveTypeCode typeCode);
    }
}
