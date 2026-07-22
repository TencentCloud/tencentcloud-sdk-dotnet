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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomWhiteRule : AbstractModel
    {
        
        /// <summary>
        /// 自定义规则的目的地址。SrcIP、DstIP 至少一项必须是具体 IP；本字段仅在 SrcIP 为具体 IP 时可省略或使用与 SrcIP 同版本的通配网段。两项均为具体 IP 时，源 IPv6、目的 IPv4 会被拒绝，源 IPv4、目的 IPv6 当前不受该版本检查限制。私网 IPv4 和任意 IPv6 直接通过资产判定，公网 IPv4 必须存在于当前账号 cfw_public_ip；是否要求通过资产判定由两侧地址与实际 FwType 联动决定。
        /// </summary>
        [JsonProperty("DstIP")]
        public string DstIP{ get; set; }

        /// <summary>
        /// 自定义规则关联的入侵防御规则 ID；必须是可转换为整数且在入侵防御规则模板中存在的 ID。
        /// </summary>
        [JsonProperty("IdsRuleId")]
        public string IdsRuleId{ get; set; }

        /// <summary>
        /// 自定义规则名称；处理器不对内容做额外校验。
        /// </summary>
        [JsonProperty("IdsRuleName")]
        public string IdsRuleName{ get; set; }

        /// <summary>
        /// 自定义规则的源地址。SrcIP、DstIP 至少一项必须是具体 IP；本字段仅在 DstIP 为具体 IP 时可省略或使用与 DstIP 同版本的通配网段。两项均为具体 IP 时，源 IPv6、目的 IPv4 会被拒绝，源 IPv4、目的 IPv6 当前不受该版本检查限制。私网 IPv4 和任意 IPv6 直接通过资产判定，公网 IPv4 必须存在于当前账号 cfw_public_ip；是否要求通过资产判定由两侧地址与实际 FwType 联动决定。
        /// </summary>
        [JsonProperty("SrcIP")]
        public string SrcIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DstIP", this.DstIP);
            this.SetParamSimple(map, prefix + "IdsRuleId", this.IdsRuleId);
            this.SetParamSimple(map, prefix + "IdsRuleName", this.IdsRuleName);
            this.SetParamSimple(map, prefix + "SrcIP", this.SrcIP);
        }
    }
}

