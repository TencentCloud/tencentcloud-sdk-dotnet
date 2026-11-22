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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAIGWLLMModelAPIIPRestrictionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关实例id</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>模型 API ID</p>
        /// </summary>
        [JsonProperty("ModelAPIId")]
        public string ModelAPIId{ get; set; }

        /// <summary>
        /// <p>是否启用 IP 黑白名单</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>限制类型</p><p>枚举值：</p><ul><li>whiteList： 白名单</li><li>blackList： 黑名单</li></ul>
        /// </summary>
        [JsonProperty("RestrictionType")]
        public string RestrictionType{ get; set; }

        /// <summary>
        /// <p>IP 或 CIDR 列表，每项须为合法 IP/CIDR（支持 IPv4/IPv6），长度 [1,400]</p>
        /// </summary>
        [JsonProperty("AddressList")]
        public string[] AddressList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "ModelAPIId", this.ModelAPIId);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "RestrictionType", this.RestrictionType);
            this.SetParamArraySimple(map, prefix + "AddressList.", this.AddressList);
        }
    }
}

