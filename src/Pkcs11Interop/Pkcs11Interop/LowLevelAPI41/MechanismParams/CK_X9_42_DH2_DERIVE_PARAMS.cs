﻿/*
 *  Copyright 2012-2019 The Pkcs11Interop Project
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
using System.Runtime.InteropServices;

namespace Net.Pkcs11Interop.LowLevelAPI41.MechanismParams
{
    /// <summary>
    /// Structure that provides the parameters to the CKM_X9_42_DH_HYBRID_DERIVE and CKM_X9_42_MQV_DERIVE key derivation mechanisms
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct CK_X9_42_DH2_DERIVE_PARAMS
    {
        /// <summary>
        /// Key derivation function used on the shared secret value (CKD)
        /// </summary>
        public uint Kdf;

        /// <summary>
        /// The length in bytes of the other info
        /// </summary>
        public uint OtherInfoLen;

        /// <summary>
        /// Some data shared between the two parties
        /// </summary>
        public IntPtr OtherInfo;

        /// <summary>
        /// The length in bytes of the other party's first X9.42 Diffie-Hellman public key
        /// </summary>
        public uint PublicDataLen;

        /// <summary>
        /// Pointer to other party's first X9.42 Diffie-Hellman public key value
        /// </summary>
        public IntPtr PublicData;

        /// <summary>
        /// The length in bytes of the second X9.42 Diffie-Hellman private key
        /// </summary>
        public uint PrivateDataLen;

        /// <summary>
        /// Key handle for second X9.42 Diffie-Hellman private key value
        /// </summary>
        public uint PrivateData;

        /// <summary>
        /// The length in bytes of the other party's second X9.42 Diffie-Hellman public key
        /// </summary>
        public uint PublicDataLen2;

        /// <summary>
        /// Pointer to other party's second X9.42 Diffie-Hellman public key value
        /// </summary>
        public IntPtr PublicData2;
    }
}
