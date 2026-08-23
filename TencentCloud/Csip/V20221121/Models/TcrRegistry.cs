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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TcrRegistry : AbstractModel
    {
        
        /// <summary>
        /// <p>仓库实例id</p>
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// <p>仓库名</p>
        /// </summary>
        [JsonProperty("RegistryName")]
        public string RegistryName{ get; set; }

        /// <summary>
        /// <p>仓库域名</p>
        /// </summary>
        [JsonProperty("PublicDomain")]
        public string PublicDomain{ get; set; }

        /// <summary>
        /// <p>仓库所在region</p>
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// <p>仓库id</p>
        /// </summary>
        [JsonProperty("RegistryRegionId")]
        public ulong? RegistryRegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "RegistryName", this.RegistryName);
            this.SetParamSimple(map, prefix + "PublicDomain", this.PublicDomain);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "RegistryRegionId", this.RegistryRegionId);
        }
    }
}

