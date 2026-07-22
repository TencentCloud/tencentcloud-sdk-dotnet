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

    public class SecurityGroupSimplifyRule : AbstractModel
    {
        
        /// <summary>
        /// 写入规则的描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 访问目的示例：
        /// net：IP/CIDR(192.168.0.2)
        /// template：参数模板(ipm-dyodhpby)
        /// instance：资产实例(ins-123456)
        /// resourcegroup：资产分组(/全部分组/分组1/子分组1)
        /// tag：资源标签({"Key":"标签key值","Value":"标签Value值"})
        /// region：地域(ap-gaungzhou)
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// 写入规则的协议。普通 IPv4 规则返回 ANY、TCP、UDP 或 ICMP；使用服务模板时，Protocol 可省略或留空，此时返回空字符串；若仍显式填写 Protocol，则只接受 ANY 并返回 ANY。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 服务端写入后生成或采用的规则数据库 ID。
        /// </summary>
        [JsonProperty("RuleUuid")]
        public long? RuleUuid{ get; set; }

        /// <summary>
        /// 写入后的规则生效范围；SG 表示安全组，LH 表示轻量应用服务器，组合范围以逗号分隔。
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// 服务端写入后的实际规则顺序。
        /// </summary>
        [JsonProperty("Sequence")]
        public long? Sequence{ get; set; }

        /// <summary>
        /// 访问源示例：
        /// net：IP/CIDR(192.168.0.2)
        /// template：参数模板(ipm-dyodhpby)
        /// instance：资产实例(ins-123456)
        /// resourcegroup：资产分组(/全部分组/分组1/子分组1)
        /// tag：资源标签({"Key":"标签key值","Value":"标签Value值"})
        /// region：地域(ap-gaungzhou)
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleUuid", this.RuleUuid);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Sequence", this.Sequence);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
        }
    }
}

