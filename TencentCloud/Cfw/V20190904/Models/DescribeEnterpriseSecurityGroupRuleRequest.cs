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

    public class DescribeEnterpriseSecurityGroupRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页查询时，显示的当前页的页码。
        /// 
        /// 默认值为1。
        /// </summary>
        [JsonProperty("PageNo")]
        public string PageNo{ get; set; }

        /// <summary>
        /// 分页查询时，显示的每页数据的最大条数。
        /// 
        /// 可设置值最大为50。
        /// </summary>
        [JsonProperty("PageSize")]
        public string PageSize{ get; set; }

        /// <summary>
        /// 访问源示例：
        /// net：IP/CIDR(192.168.0.2)
        /// template：参数模板(ipm-dyodhpby)
        /// instance：资产实例(ins-123456)
        /// resourcegroup：资产分组(/全部分组/分组1/子分组1)
        /// tag：资源标签({"Key":"标签key值","Value":"标签Value值"})
        /// region：地域(ap-gaungzhou)
        /// 支持通配
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
        /// 支持通配
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// 规则描述，支持通配
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 访问控制策略中设置的流量通过云防火墙的方式。取值：
        /// accept：放行
        /// drop：拒绝
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 是否启用规则，默认为启用，取值：
        /// true为启用，false为不启用
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// 访问控制策略的端口。取值：
        /// -1/-1：全部端口
        /// 80：80端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 协议；TCP/UDP/ICMP/ANY
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口协议类型参数模板id；协议端口模板id；与Protocol,Port互斥
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// 规则的uuid
        /// </summary>
        [JsonProperty("RuleUuid")]
        public long? RuleUuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
            this.SetParamSimple(map, prefix + "RuleUuid", this.RuleUuid);
        }
    }
}

