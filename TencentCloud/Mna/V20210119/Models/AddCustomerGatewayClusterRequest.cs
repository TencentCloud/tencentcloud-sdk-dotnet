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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddCustomerGatewayClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群名称。最大 64 字符，支持字母、数字、中划线、下划线、点及中文。</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>部署大区标识。最大 32 字符。例如 CN 表示中国大陆。</p>
        /// </summary>
        [JsonProperty("BigArea")]
        public string BigArea{ get; set; }

        /// <summary>
        /// <p>地域标识。最大 32 字符。例如 ap-guangzhou。</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "BigArea", this.BigArea);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
        }
    }
}

