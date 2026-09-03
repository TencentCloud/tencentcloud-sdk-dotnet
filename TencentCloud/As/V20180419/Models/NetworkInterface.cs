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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkInterface : AbstractModel
    {
        
        /// <summary>
        /// <p>网卡类型。本字段在每个网卡项的请求中必填。</p><p>枚举值：</p><ul><li>PRIMARY： 主网卡</li><li>SECONDARY： 辅助网卡</li></ul><p>配置上层 NetworkInterfaces 时，数组必须显式包含且只能包含一个 PRIMARY，AS 不自动补齐主网卡。</p>
        /// </summary>
        [JsonProperty("InterfaceType")]
        public string InterfaceType{ get; set; }

        /// <summary>
        /// <p>网卡请求分配的内网 IPv4 地址总数，包含主 IP。</p><p>取值范围：[1, 40]</p><p>SECONDARY 网卡请求时必填；PRIMARY 网卡请求时可选，未填写时仅在实际扩容构造 CVM 请求副本时按 1 处理，不写回启动配置。显式传入的值由 AS 透传给 CVM，最终由 CVM/VPC 校验。</p>
        /// </summary>
        [JsonProperty("PrivateIpv4AddressCount")]
        public long? PrivateIpv4AddressCount{ get; set; }

        /// <summary>
        /// <p>弹性网卡绑定的安全组 ID 列表。</p><p>入参限制：最多 10 个。</p><p>对于 PRIMARY，网卡中显式配置的非空列表优先于启动配置中的 SecurityGroupIds 参数；网卡中未配置时使用启动配置中的 SecurityGroupIds 参数，两处均未配置时 AS 不指定安全组，继续按 CVM 缺省规则处理。对于 SECONDARY，仅透传网卡中显式配置的非空列表，不继承启动配置中的 SecurityGroupIds 参数。</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>实例销毁时是否保留辅助网卡，仅对 SECONDARY 有效。</p><p>枚举值：</p><ul><li>false： 不保留辅助网卡，辅助网卡随实例销毁</li><li>true： 保留辅助网卡</li></ul><p>默认值：false</p><p>PRIMARY 不允许配置 true。</p>
        /// </summary>
        [JsonProperty("IsKeepENI")]
        public bool? IsKeepENI{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InterfaceType", this.InterfaceType);
            this.SetParamSimple(map, prefix + "PrivateIpv4AddressCount", this.PrivateIpv4AddressCount);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "IsKeepENI", this.IsKeepENI);
        }
    }
}

