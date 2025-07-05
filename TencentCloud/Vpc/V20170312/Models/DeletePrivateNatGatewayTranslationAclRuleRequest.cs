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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeletePrivateNatGatewayTranslationAclRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 私网网关唯一`ID`，形如：`intranat-xxxxxxxx`。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// 转换规则目标，可选值"LOCAL"。
        /// </summary>
        [JsonProperty("TranslationDirection")]
        public string TranslationDirection{ get; set; }

        /// <summary>
        /// 转换规则类型，可选值"NETWORK_LAYER","TRANSPORT_LAYER"。
        /// </summary>
        [JsonProperty("TranslationType")]
        public string TranslationType{ get; set; }

        /// <summary>
        /// 转换`IP`,当转换规则类型为四层时为`IP`池
        /// </summary>
        [JsonProperty("TranslationIp")]
        public string TranslationIp{ get; set; }

        /// <summary>
        /// 访问控制规则对应`ID`
        /// </summary>
        [JsonProperty("AclRuleIds")]
        public ulong?[] AclRuleIds{ get; set; }

        /// <summary>
        /// 源`IP`,当转换规则类型为三层时有效
        /// </summary>
        [JsonProperty("OriginalIp")]
        public string OriginalIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "TranslationDirection", this.TranslationDirection);
            this.SetParamSimple(map, prefix + "TranslationType", this.TranslationType);
            this.SetParamSimple(map, prefix + "TranslationIp", this.TranslationIp);
            this.SetParamArraySimple(map, prefix + "AclRuleIds.", this.AclRuleIds);
            this.SetParamSimple(map, prefix + "OriginalIp", this.OriginalIp);
        }
    }
}

