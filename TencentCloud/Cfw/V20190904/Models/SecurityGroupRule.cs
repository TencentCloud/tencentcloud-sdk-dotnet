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

    public class SecurityGroupRule : AbstractModel
    {
        
        /// <summary>
        /// 访问源示例：
        /// net：IP/CIDR(192.168.0.2)
        /// template：参数模板id(ipm-dyodhpby)
        /// instance：资产实例id(ins-123456)
        /// resourcegroup：资产分组id(cfwrg-xxxx)
        /// tag：资源标签({\"Key\":\"标签key值\",\"Value\":\"标签Value值\"})
        /// region：地域(ap-gaungzhou)
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// 访问源类型，类型可以为以下6种：net|template|instance|resourcegroup|tag|region
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 访问目的示例：
        /// net：IP/CIDR(192.168.0.2)
        /// template：参数模板id(ipm-dyodhpby)
        /// instance：资产实例id(ins-123456)
        /// resourcegroup：资产分组id(cfwrg-xxxx)
        /// tag：资源标签({\"Key\":\"标签key值\",\"Value\":\"标签Value值\"})
        /// region：地域(ap-gaungzhou)
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// 访问目的类型，类型可以为以下6种：net|template|instance|resourcegroup|tag|region
        /// </summary>
        [JsonProperty("DestType")]
        public string DestType{ get; set; }

        /// <summary>
        /// 访问控制策略中设置的流量通过云防火墙的方式。取值：
        /// accept：放行
        /// drop：拒绝
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 规则顺序，-1表示最低，1表示最高，请勿和外层Type冲突（和外层的Type配合使用，当中间插入时，指定添加位置）
        /// </summary>
        [JsonProperty("OrderIndex")]
        public string OrderIndex{ get; set; }

        /// <summary>
        /// 协议；TCP/UDP/ICMP/ANY
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 访问控制策略的端口。取值：
        /// -1/-1：全部端口
        /// 80：80端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 端口协议类型参数模板id；协议端口模板id；与Protocol,Port互斥
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// （入参时无需填写，自动生成）规则对应的唯一id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// （入参时、Enable已弃用；由通用配置中新增规则启用状态控制）
        /// 规则状态，true表示启用，false表示禁用
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// 规则对应的唯一内部id
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
        }
    }
}

