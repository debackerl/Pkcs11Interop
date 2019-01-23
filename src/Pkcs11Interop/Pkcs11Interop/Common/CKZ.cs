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

namespace Net.Pkcs11Interop.Common
{
    /// <summary>
    /// Salt/Encoding parameter sources
    /// </summary>
    public static class CKZ
    {
        /// <summary>
        /// PKCS #1 RSA OAEP: Encoding parameter specified
        /// </summary>
        public const uint CKZ_DATA_SPECIFIED = 0x00000001;

        /// <summary>
        /// PKCS #5 PBKDF2 Key Generation: Salt specified
        /// </summary>
        public const uint CKZ_SALT_SPECIFIED = 0x00000001;
    }
}
