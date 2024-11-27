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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranslationAclRule : AbstractModel
    {
        
        /// <summary>
        /// ACL协议类型，可选值:"ALL","TCP","UDP"
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 源端口。
        /// </summary>
        [JsonProperty("SourcePort")]
        public string SourcePort{ get; set; }

        /// <summary>
        /// 源地址。支持`ip`或`cidr`格式"xxx.xxx.xxx.000/xx"
        /// </summary>
        [JsonProperty("SourceCidr")]
        public string SourceCidr{ get; set; }

        /// <summary>
        /// 目的端口。
        /// </summary>
        [JsonProperty("DestinationPort")]
        public string DestinationPort{ get; set; }

        /// <summary>
        /// 目的地址。
        /// </summary>
        [JsonProperty("DestinationCidr")]
        public string DestinationCidr{ get; set; }

        /// <summary>
        /// ACL规则`ID`。
        /// </summary>
        [JsonProperty("AclRuleId")]
        public ulong? AclRuleId{ get; set; }

        /// <summary>
        /// 是否匹配。
        /// </summary>
        [JsonProperty("Action")]
        public ulong? Action{ get; set; }

        /// <summary>
        /// ACL规则描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SourcePort", this.SourcePort);
            this.SetParamSimple(map, prefix + "SourceCidr", this.SourceCidr);
            this.SetParamSimple(map, prefix + "DestinationPort", this.DestinationPort);
            this.SetParamSimple(map, prefix + "DestinationCidr", this.DestinationCidr);
            this.SetParamSimple(map, prefix + "AclRuleId", this.AclRuleId);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

