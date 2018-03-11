/*
 *  Copyright 2012-2017 The Pkcs11Interop Project
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

/*
 *  Written for the Pkcs11Interop project by:
 *  Jaroslav IMRICH <jimrich@jimrich.sk>
 */

using System;
using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.LowLevelAPI80.MechanismParams;
using NativeULong = System.UInt64;

namespace Net.Pkcs11Interop.HighLevelAPI80.MechanismParams
{
    /// <summary>
    /// Parameters for the CKM_AES_CTR mechanism
    /// </summary>
    public class CkAesCtrParams : IMechanismParams
    {
        /// <summary>
        /// Low level mechanism parameters
        /// </summary>
        private CK_AES_CTR_PARAMS _lowLevelStruct = new CK_AES_CTR_PARAMS();

        /// <summary>
        /// Initializes a new instance of the CkAesCtrParams class.
        /// </summary>
        /// <param name='counterBits'>The number of bits in the counter block (cb) that shall be incremented</param>
        /// <param name='cb'>Specifies the counter block (16 bytes)</param>
        public CkAesCtrParams(NativeULong counterBits, byte[] cb)
        {
            _lowLevelStruct.CounterBits = 0;
            _lowLevelStruct.Cb = new byte[16];

            _lowLevelStruct.CounterBits = counterBits;

            if (cb == null)
                throw new ArgumentNullException("cb");
            
            if (cb.Length != 16)
                throw new ArgumentOutOfRangeException("cb", "Array has to be 16 bytes long");

            Array.Copy(cb, _lowLevelStruct.Cb, cb.Length);
        }
        
        #region IMechanismParams
        
        /// <summary>
        /// Returns managed object that can be marshaled to an unmanaged block of memory
        /// </summary>
        /// <returns>A managed object holding the data to be marshaled. This object must be an instance of a formatted class.</returns>
        public object ToMarshalableStructure()
        {
            return _lowLevelStruct;
        }
        
        #endregion
    }
}
