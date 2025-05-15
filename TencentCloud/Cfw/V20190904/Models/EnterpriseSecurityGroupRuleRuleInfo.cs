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

    public class EnterpriseSecurityGroupRuleRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 排序
        /// </summary>
        [JsonProperty("OrderIndex")]
        public long? OrderIndex{ get; set; }

        /// <summary>
        /// 主键id
        /// </summary>
        [JsonProperty("RuleUuid")]
        public ulong? RuleUuid{ get; set; }

        /// <summary>
        /// 规则uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 源规则内容
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// 源规则类型 
        /// 取值范围 0/1/2/3/4/5/6/7/8/9/100
        /// 0表示ip(net),
        /// 1表示VPC实例(instance)
        /// 2表示子网实例(instance)
        /// 3表示CVM实例(instance)
        /// 4表示CLB实例(instance)
        /// 5表示ENI实例(instance)
        /// 6表示数据库实例(instance)
        /// 7表示模版(template)
        /// 8表示标签(tag)
        /// 9表示地域(region)
        /// 100表示资产分组(resourcegroup)
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// 目的规则内容
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }

        /// <summary>
        /// 目的规则类型 
        /// 取值范围 0/1/2/3/4/5/6/7/8/9/100
        /// 0表示ip(net),
        /// 1表示VPC实例(instance)
        /// 2表示子网实例(instance)
        /// 3表示CVM实例(instance)
        /// 4表示CLB实例(instance)
        /// 5表示ENI实例(instance)
        /// 6表示数据库实例(instance)
        /// 7表示模版(template)
        /// 8表示标签(tag)
        /// 9表示地域(region)
        /// 100表示资产分组(resourcegroup)
        /// </summary>
        [JsonProperty("TargetType")]
        public long? TargetType{ get; set; }

        /// <summary>
        /// 协议名称
        /// 取值范围:TCP/ANY/ICMP/UDP
        /// ANY:表示所有
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 规则策略
        /// 取值范围:1/2
        /// 1:阻断
        /// 2:放行
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// 规则启用状态 
        /// 取值范围： 0/1
        /// 0:未开启
        /// 1:开启
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("AclTags")]
        public string AclTags{ get; set; }

        /// <summary>
        /// 规则最新一次是否有改动
        /// 取值范围：0/1
        /// 0:否
        /// 1:是
        /// </summary>
        [JsonProperty("IsNew")]
        public long? IsNew{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 是否延迟下发规则 
        /// 取值范围：0/1
        /// 0:立即下发 1:延迟下发
        /// </summary>
        [JsonProperty("IsDelay")]
        public long? IsDelay{ get; set; }

        /// <summary>
        /// 服务模板id
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// 源资产名称
        /// </summary>
        [JsonProperty("SouInstanceName")]
        public string SouInstanceName{ get; set; }

        /// <summary>
        /// 源资产公网ip
        /// </summary>
        [JsonProperty("SouPublicIp")]
        public string SouPublicIp{ get; set; }

        /// <summary>
        /// 源资产内网ip
        /// </summary>
        [JsonProperty("SouPrivateIp")]
        public string SouPrivateIp{ get; set; }

        /// <summary>
        /// 源资产网段信息
        /// </summary>
        [JsonProperty("SouCidr")]
        public string SouCidr{ get; set; }

        /// <summary>
        /// 源模板名称
        /// </summary>
        [JsonProperty("SouParameterName")]
        public string SouParameterName{ get; set; }

        /// <summary>
        /// 目的资产名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 目的资产公网ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 目的资产内网ip
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 目的资产网段信息
        /// </summary>
        [JsonProperty("Cidr")]
        public string Cidr{ get; set; }

        /// <summary>
        /// 目的模板名称
        /// </summary>
        [JsonProperty("ParameterName")]
        public string ParameterName{ get; set; }

        /// <summary>
        /// 端口模板名称
        /// </summary>
        [JsonProperty("ProtocolPortName")]
        public string ProtocolPortName{ get; set; }

        /// <summary>
        /// 自动化任务信息
        /// </summary>
        [JsonProperty("BetaList")]
        public EnterpriseSecurityGroupRuleBetaInfo[] BetaList{ get; set; }

        /// <summary>
        /// 规则id  等同RuleUuid
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 域名解析的IP统计
        /// </summary>
        [JsonProperty("DnsParseCount")]
        public SgDnsParseCount DnsParseCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "RuleUuid", this.RuleUuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "AclTags", this.AclTags);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IsDelay", this.IsDelay);
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
            this.SetParamSimple(map, prefix + "SouInstanceName", this.SouInstanceName);
            this.SetParamSimple(map, prefix + "SouPublicIp", this.SouPublicIp);
            this.SetParamSimple(map, prefix + "SouPrivateIp", this.SouPrivateIp);
            this.SetParamSimple(map, prefix + "SouCidr", this.SouCidr);
            this.SetParamSimple(map, prefix + "SouParameterName", this.SouParameterName);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "Cidr", this.Cidr);
            this.SetParamSimple(map, prefix + "ParameterName", this.ParameterName);
            this.SetParamSimple(map, prefix + "ProtocolPortName", this.ProtocolPortName);
            this.SetParamArrayObj(map, prefix + "BetaList.", this.BetaList);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "DnsParseCount.", this.DnsParseCount);
        }
    }
}

