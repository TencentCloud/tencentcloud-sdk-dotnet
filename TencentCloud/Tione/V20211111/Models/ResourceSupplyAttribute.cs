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

    public class ResourceSupplyAttribute : AbstractModel
    {
        
        /// <summary>
        /// <p>资源供应类型。TIDE:潮汐;SPOT:竞价;空:常规按量后付费</p>
        /// </summary>
        [JsonProperty("SupplyType")]
        public string SupplyType{ get; set; }

        /// <summary>
        /// <p>集群类型</p><p>枚举值：</p><ul><li>DEFAULT： 默认集群</li><li>THIRD： 第三方集群</li></ul><p>默认值：DEFAULT</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SupplyType", this.SupplyType);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
        }
    }
}

