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

    public class AnalysisSgRuleInfoResp : AbstractModel
    {
        
        /// <summary>
        /// <p>规则id  等同RuleUuid</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>规则Id</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>排序</p>
        /// </summary>
        [JsonProperty("OrderIndex")]
        public long? OrderIndex{ get; set; }

        /// <summary>
        /// <p>云防排序</p>
        /// </summary>
        [JsonProperty("CfwOrderIndex")]
        public long? CfwOrderIndex{ get; set; }

        /// <summary>
        /// <p>源规则内容</p>
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// <p>源规则类型<br>取值范围 0/1/2/3/4/5/6/7/8/9<br>0表示ip(net),<br>1表示VPC实例(instance)<br>2表示子网实例(instance)<br>3表示CVM实例(instance)<br>4表示CLB实例(instance)<br>5表示ENI实例(instance)<br>6表示数据库实例(instance)<br>7表示模板(template)<br>8表示标签(tag)<br>9表示地域(region)</p><p>枚举值：</p><ul><li>0： IP / CIDR</li><li>1： VPC 实例</li><li>2： 子网 </li><li>3： CVM 实例</li><li>4： CLB 实例</li><li>5： ENI（弹性网卡）实例</li><li>6： CDB（云数据库）实例</li><li>7： 参数模板</li><li>8： 标签</li><li>9： 地域</li></ul>
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// <p>目的规则内容</p>
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }

        /// <summary>
        /// <p>目的规则类型<br>取值范围 0/1/2/3/4/5/6/7/8/9/100<br>0表示ip(net),<br>1表示VPC实例(instance)<br>2表示子网实例(instance)<br>3表示CVM实例(instance)<br>4表示CLB实例(instance)<br>5表示ENI实例(instance)<br>6表示数据库实例(instance)<br>7表示模板(template)<br>8表示标签(tag)<br>9表示地域(region)<br>100表示资产分组(resourcegroup)</p><p>枚举值：</p><ul><li>0： IP / CIDR</li><li>1： VPC 实例</li><li>2： 子网 </li><li>3： CVM 实例</li><li>4： CLB 实例</li><li>5： ENI（弹性网卡）实例</li><li>6： CDB（云数据库）实例</li><li>7： 参数模板</li><li>8： 标签</li><li>9： 地域</li></ul>
        /// </summary>
        [JsonProperty("TargetType")]
        public long? TargetType{ get; set; }

        /// <summary>
        /// <p>协议名称<br>取值范围:TCP/ANY/ICMP/UDP<br>ANY:表示所有</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>端口</p>
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// <p>规则策略<br>取值范围:1/2<br>1:阻断<br>2:放行</p>
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>服务模板id</p>
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// <p>源资产名称</p>
        /// </summary>
        [JsonProperty("SouInstanceName")]
        public string SouInstanceName{ get; set; }

        /// <summary>
        /// <p>源资产公网ip</p>
        /// </summary>
        [JsonProperty("SouPublicIp")]
        public string SouPublicIp{ get; set; }

        /// <summary>
        /// <p>源资产内网ip</p>
        /// </summary>
        [JsonProperty("SouPrivateIp")]
        public string SouPrivateIp{ get; set; }

        /// <summary>
        /// <p>源资产网段信息</p>
        /// </summary>
        [JsonProperty("SouCidr")]
        public string SouCidr{ get; set; }

        /// <summary>
        /// <p>源模板名称</p>
        /// </summary>
        [JsonProperty("SouParameterName")]
        public string SouParameterName{ get; set; }

        /// <summary>
        /// <p>目的资产名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>目的资产公网ip</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>目的资产内网ip</p>
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// <p>目的资产网段信息</p>
        /// </summary>
        [JsonProperty("Cidr")]
        public string Cidr{ get; set; }

        /// <summary>
        /// <p>目的模板名称</p>
        /// </summary>
        [JsonProperty("ParameterName")]
        public string ParameterName{ get; set; }

        /// <summary>
        /// <p>端口模板名称</p>
        /// </summary>
        [JsonProperty("ProtocolPortName")]
        public string ProtocolPortName{ get; set; }

        /// <summary>
        /// <p>域名解析的IP统计</p>
        /// </summary>
        [JsonProperty("DnsParseCount")]
        public SgDnsParseCount DnsParseCount{ get; set; }

        /// <summary>
        /// <p>规则生效范围</p>
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// <p>分区：<br>1防火墙管理最前分区<br>2是云防规则<br>3防火墙管理最后分区</p>
        /// </summary>
        [JsonProperty("RulePartition")]
        public long? RulePartition{ get; set; }

        /// <summary>
        /// <p>规则组Id</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>规则组名称</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>规则组内规则id</p>
        /// </summary>
        [JsonProperty("GroupRuleId")]
        public string GroupRuleId{ get; set; }

        /// <summary>
        /// <p>策略Id</p>
        /// </summary>
        [JsonProperty("StrategyId")]
        public string StrategyId{ get; set; }

        /// <summary>
        /// <p>ip类型</p>
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// <p>成员信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BelongMember")]
        public MemberInfo BelongMember{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "CfwOrderIndex", this.CfwOrderIndex);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Region", this.Region);
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
            this.SetParamObj(map, prefix + "DnsParseCount.", this.DnsParseCount);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "RulePartition", this.RulePartition);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupRuleId", this.GroupRuleId);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamObj(map, prefix + "BelongMember.", this.BelongMember);
        }
    }
}

