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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupSimplifyRule : AbstractModel
    {
        
        /// <summary>
        /// 访问源示例：
        /// net：IP/CIDR(192.168.0.2)
        /// template：参数模板(ipm-dyodhpby)
        /// instance：资产实例(ins-123456)
        /// resourcegroup：资产分组(/全部分组/分组1/子分组1)
        /// tag：资源标签({"Key":"标签key值","Value":"标签Value值"})
        /// region：地域(ap-gaungzhou)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// 访问目的示例：
        /// net：IP/CIDR(192.168.0.2)
        /// template：参数模板(ipm-dyodhpby)
        /// instance：资产实例(ins-123456)
        /// resourcegroup：资产分组(/全部分组/分组1/子分组1)
        /// tag：资源标签({"Key":"标签key值","Value":"标签Value值"})
        /// region：地域(ap-gaungzhou)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// 协议；TCP/UDP/ICMP/ANY
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 规则对应的唯一id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleUuid")]
        public long? RuleUuid{ get; set; }

        /// <summary>
        /// 规则序号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sequence")]
        public long? Sequence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RuleUuid", this.RuleUuid);
            this.SetParamSimple(map, prefix + "Sequence", this.Sequence);
        }
    }
}

