// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
**
** Purpose: The arrays are of different primitive types.
**
**
=============================================================================*/

namespace System {
    
    using System;
    using System.Runtime.Serialization;
    // The ArrayMismatchException is thrown when an attempt to store
    // an object of the wrong type within an array occurs.
    // 
    [System.Runtime.InteropServices.ComVisible(true)]
#if FEATURE_SERIALIZATION
    [Serializable]
#endif
    public class ArrayTypeMismatchException : SystemException {
        
        // Creates a new ArrayMismatchException with its message string set to
        // the empty string, its HRESULT set to COR_E_ARRAYTYPEMISMATCH, 
        // and its ExceptionInfo reference set to null. 
        public ArrayTypeMismatchException() 
            : base(Environment.GetResourceString("Arg_ArrayTypeMismatchException")) {
            SetErrorCode(__HResults.COR_E_ARRAYTYPEMISMATCH);
        }
        
        // Creates a new ArrayMismatchException with its message string set to
        // message, its HRESULT set to COR_E_ARRAYTYPEMISMATCH, 
        // and its ExceptionInfo reference set to null. 
        // 
        public ArrayTypeMismatchException(String message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_ARRAYTYPEMISMATCH);
        }
        
        public ArrayTypeMismatchException(String message, Exception innerException) 
            : base(message, innerException) {
            SetErrorCode(__HResults.COR_E_ARRAYTYPEMISMATCH);
        }

        protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }

    }

}
