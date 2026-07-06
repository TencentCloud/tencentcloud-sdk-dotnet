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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SgRuleResp : AbstractModel
    {
        
        /// <summary>
        /// 规则Id
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("Sequence")]
        public long? Sequence{ get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// ip类型
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// 源内容
        /// </summary>
        [JsonProperty("SrcContent")]
        public string SrcContent{ get; set; }

        /// <summary>
        /// 源类型
        /// </summary>
        [JsonProperty("SrcType")]
        public string SrcType{ get; set; }

        /// <summary>
        /// 目的内容
        /// </summary>
        [JsonProperty("DstContent")]
        public string DstContent{ get; set; }

        /// <summary>
        /// 目的类型
        /// </summary>
        [JsonProperty("DstType")]
        public string DstType{ get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 协议端口参数模板
        /// </summary>
        [JsonProperty("ProtocolPortType")]
        public long? ProtocolPortType{ get; set; }

        /// <summary>
        /// 协议端口参数模板id
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// 端口段,支持单端口,多端口和端口段
        /// </summary>
        [JsonProperty("DstPort")]
        public string DstPort{ get; set; }

        /// <summary>
        /// 策略，1阻断，2放行
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 规则来源，0为用户控制台添加
        /// </summary>
        [JsonProperty("RuleSource")]
        public string RuleSource{ get; set; }

        /// <summary>
        /// 生效范围,字节位,1:SG 企业安全组,2:LH 轻量服务器
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Sequence", this.Sequence);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "SrcContent", this.SrcContent);
            this.SetParamSimple(map, prefix + "SrcType", this.SrcType);
            this.SetParamSimple(map, prefix + "DstContent", this.DstContent);
            this.SetParamSimple(map, prefix + "DstType", this.DstType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ProtocolPortType", this.ProtocolPortType);
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "RuleSource", this.RuleSource);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
        }
    }
}

