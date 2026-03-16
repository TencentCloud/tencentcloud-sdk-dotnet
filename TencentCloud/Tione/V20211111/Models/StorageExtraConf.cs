/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageExtraConf : AbstractModel
    {
        
        /// <summary>
        /// cfs的存储类型
        ///   // HP:通用性能型
        ///   // SD:通用标准型
        ///   // TP:turbo性能型
        ///   // TB:turbo标准型
        ///   // THP:吞吐型
        /// </summary>
        [JsonProperty("CFSStorageType")]
        public string CFSStorageType{ get; set; }

        /// <summary>
        /// cfs的协议
        /// </summary>
        [JsonProperty("CFSProtocol")]
        public string CFSProtocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CFSStorageType", this.CFSStorageType);
            this.SetParamSimple(map, prefix + "CFSProtocol", this.CFSProtocol);
        }
    }
}

