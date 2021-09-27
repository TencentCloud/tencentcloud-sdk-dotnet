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

    public class AddAcRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// -1表示优先级最低，1表示优先级最高
        /// </summary>
        [JsonProperty("OrderIndex")]
        public string OrderIndex{ get; set; }

        /// <summary>
        /// 访问控制策略中设置的流量通过云防火墙的方式。取值：
        /// accept：放行
        /// drop：拒绝
        /// log：观察
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 访问控制策略的流量方向。取值：
        /// in：外对内流量访问控制
        /// out：内对外流量访问控制
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 访问控制策略的描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 访问控制策略中的源地址类型。取值：
        /// net：源IP或网段（IP或者CIDR）
        /// location：源区域
        /// template：云防火墙地址模板
        /// instance：实例id
        /// vendor：云厂商
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 访问控制策略中的源地址。取值：
        /// 当SourceType为net时，SourceContent为源IP地址或者CIDR地址。
        /// 例如：1.1.1.0/24
        /// 
        /// 当SourceType为template时，SourceContent为源地址模板名称。
        /// 
        /// 当SourceType为location时，SourceContent为源区域。
        /// 例如["BJ11", "ZB"]
        /// 
        /// 当SourceType为instance时，SourceContent为该实例id对应的公网ip。
        /// 例如ins-xxxxx
        /// 
        /// 当SourceType为vendor时，SourceContent为所选择厂商的公网ip列表。
        /// 例如：aws,huawei,tencent,aliyun,azure,all代表以上五个
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// 访问控制策略中的目的地址类型。取值：
        /// net：目的IP或者网段（IP或者CIDR）
        /// location：源区域
        /// template：云防火墙地址模板
        /// instance：实例id
        /// vendor：云厂商
        /// domain: 域名或者ip
        /// </summary>
        [JsonProperty("DestType")]
        public string DestType{ get; set; }

        /// <summary>
        /// 访问控制策略中的目的地址。取值：
        /// 当DestType为net时，DestContent为源IP地址或者CIDR地址。
        /// 例如：1.1.1.0/24
        /// 
        /// 当DestType为template时，DestContent为源地址模板名称。
        /// 
        /// 当DestType为location时，DestContent为源区域。
        /// 例如["BJ11", "ZB"]
        /// 
        /// 当DestType为instance时，DestContent为该实例id对应的公网ip。
        /// 例如ins-xxxxx
        /// 
        /// 当DestType为domain时，DestContent为该实例id对应的域名规则。
        /// 例如*.qq.com
        /// 
        /// 当DestType为vendor时，DestContent为所选择厂商的公网ip列表。
        /// 例如：aws,huawei,tencent,aliyun,azure,all代表以上五个
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// 访问控制策略的端口。取值：
        /// -1/-1：全部端口
        /// 80,443：80或者443
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 访问控制策略中流量访问的协议类型。取值：TCP，目前互联网边界规则只能支持TCP，不传参数默认就是TCP
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 七层协议，取值：
        /// HTTP/HTTPS
        /// TLS/SSL
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 是否启用规则，默认为启用，取值：
        /// true为启用，false为不启用
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

