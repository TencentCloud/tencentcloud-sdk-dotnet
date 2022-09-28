/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLoadBalancingRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 负载均衡ID。
        /// </summary>
        [JsonProperty("LoadBalancingId")]
        public string LoadBalancingId{ get; set; }

        /// <summary>
        /// 代理模式，取值有：
        /// <li>dns_only：仅DNS；</li>
        /// <li>proxied：开启代理。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 主源站源站组ID。
        /// </summary>
        [JsonProperty("OriginGroupId")]
        public string OriginGroupId{ get; set; }

        /// <summary>
        /// 备用源站源站组ID，当Type=proxied时可以填写，为空表示不使用备用源站。
        /// </summary>
        [JsonProperty("BackupOriginGroupId")]
        public string BackupOriginGroupId{ get; set; }

        /// <summary>
        /// 当Type=dns_only时，指解析记录在DNS服务器缓存的生存时间。
        /// 取值范围60-86400，单位：秒，不填写使用默认值：600。
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }

        /// <summary>
        /// 回源类型，取值有：
        /// <li>normal：主备回源；</li>
        /// <li>advanced：高级回源配置（仅当Type=proxied时可以使用）。</li>不填写表示使用主备回源。
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 高级回源配置，当OriginType=advanced时有效。
        /// 不填写表示不使用高级回源配置。
        /// </summary>
        [JsonProperty("AdvancedOriginGroups")]
        public AdvancedOriginGroup[] AdvancedOriginGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "LoadBalancingId", this.LoadBalancingId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "OriginGroupId", this.OriginGroupId);
            this.SetParamSimple(map, prefix + "BackupOriginGroupId", this.BackupOriginGroupId);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArrayObj(map, prefix + "AdvancedOriginGroups.", this.AdvancedOriginGroups);
        }
    }
}

