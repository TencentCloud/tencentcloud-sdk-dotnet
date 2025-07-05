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

    public class CreateNatRuleItem : AbstractModel
    {
        
        /// <summary>
        /// 访问源示例： net：IP/CIDR(192.168.0.2)
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// 访问源类型：入向规则时类型可以为 ip,net,template,location；出向规则时可以为 ip,net,template,instance,group,tag
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 访问目的示例： net：IP/CIDR(192.168.0.2) domain：域名规则，例如*.qq.com
        /// </summary>
        [JsonProperty("TargetContent")]
        public string TargetContent{ get; set; }

        /// <summary>
        /// 访问目的类型：入向规则时类型可以为ip,net,template,instance,group,tag；出向规则时可以为  ip,net,domain,template,location
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// 协议，可选的值： TCP UDP ICMP ANY HTTP HTTPS HTTP/HTTPS SMTP SMTPS SMTP/SMTPS FTP DNS
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 访问控制策略中设置的流量通过云防火墙的方式。取值： accept：放行 drop：拒绝 log：观察
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 访问控制策略的端口。取值： -1/-1：全部端口 80：80端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 规则方向：1，入站；0，出站
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }

        /// <summary>
        /// 规则序号
        /// </summary>
        [JsonProperty("OrderIndex")]
        public long? OrderIndex{ get; set; }

        /// <summary>
        /// 规则状态，true表示启用，false表示禁用
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// 规则对应的唯一id，创建规则时无需填写
        /// </summary>
        [JsonProperty("Uuid")]
        public long? Uuid{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 端口协议组ID
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }

        /// <summary>
        /// 内部id
        /// </summary>
        [JsonProperty("InternalUuid")]
        public long? InternalUuid{ get; set; }

        /// <summary>
        /// 规则生效的范围：ALL，全局生效；ap-guangzhou，生效的地域；cfwnat-xxx，生效基于实例维度
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "TargetContent", this.TargetContent);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "InternalUuid", this.InternalUuid);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
        }
    }
}

