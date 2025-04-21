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

    public class DescAcItem : AbstractModel
    {
        
        /// <summary>
        /// 访问源
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// 访问目的
        /// </summary>
        [JsonProperty("TargetContent")]
        public string TargetContent{ get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 访问控制策略中设置的流量通过云防火墙的方式。取值： accept：放行 drop：拒绝 log：观察
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 命中次数
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 执行顺序
        /// </summary>
        [JsonProperty("OrderIndex")]
        public ulong? OrderIndex{ get; set; }

        /// <summary>
        /// 访问源类型：入向规则时类型可以为 ip,net,template,location；出向规则时可以为 ip,net,template,instance,group,tag
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 访问目的类型：入向规则时类型可以为ip,net,template,instance,group,tag；出向规则时可以为 ip,net,domain,template,location,dnsparse
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// 规则对应的唯一id
        /// </summary>
        [JsonProperty("Uuid")]
        public ulong? Uuid{ get; set; }

        /// <summary>
        /// 规则有效性
        /// </summary>
        [JsonProperty("Invalid")]
        public ulong? Invalid{ get; set; }

        /// <summary>
        /// 0为正常规则,1为地域规则
        /// </summary>
        [JsonProperty("IsRegion")]
        public ulong? IsRegion{ get; set; }

        /// <summary>
        /// 国家id
        /// </summary>
        [JsonProperty("CountryCode")]
        public ulong? CountryCode{ get; set; }

        /// <summary>
        /// 城市id
        /// </summary>
        [JsonProperty("CityCode")]
        public ulong? CityCode{ get; set; }

        /// <summary>
        /// 国家名称
        /// </summary>
        [JsonProperty("CountryName")]
        public string CountryName{ get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [JsonProperty("CityName")]
        public string CityName{ get; set; }

        /// <summary>
        /// 云厂商code
        /// </summary>
        [JsonProperty("CloudCode")]
        public string CloudCode{ get; set; }

        /// <summary>
        /// 0为正常规则,1为云厂商规则
        /// </summary>
        [JsonProperty("IsCloud")]
        public ulong? IsCloud{ get; set; }

        /// <summary>
        /// 规则状态，true表示启用，false表示禁用
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// 规则方向：1，入向；0，出向
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 内部使用的uuid，一般情况下不会使用到该字段
        /// </summary>
        [JsonProperty("InternalUuid")]
        public long? InternalUuid{ get; set; }

        /// <summary>
        /// 规则状态，查询规则命中详情时该字段有效，0：新增，1: 已删除, 2: 编辑删除
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 关联任务详情
        /// </summary>
        [JsonProperty("BetaList")]
        public BetaInfoByACL[] BetaList{ get; set; }

        /// <summary>
        /// （1）互联网边界防火墙，生效范围：serial，串行；side，旁路；all，全局；
        /// （2）NAT边界防火墙：ALL，全局生效；ap-guangzhou，生效的地域；cfwnat-xxx，生效基于实例维度
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// 生效范围描述
        /// </summary>
        [JsonProperty("ScopeDesc")]
        public string ScopeDesc{ get; set; }

        /// <summary>
        /// 互联网边界防火墙使用的内部规则id
        /// </summary>
        [JsonProperty("InternetBorderUuid")]
        public string InternetBorderUuid{ get; set; }

        /// <summary>
        /// 协议端口组名称
        /// </summary>
        [JsonProperty("ParamTemplateName")]
        public string ParamTemplateName{ get; set; }

        /// <summary>
        /// 协议端口组ID
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }

        /// <summary>
        /// 访问源名称
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 访问目的名称
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// 规则最近命中时间
        /// </summary>
        [JsonProperty("LastHitTime")]
        public string LastHitTime{ get; set; }

        /// <summary>
        /// 地区简称
        /// </summary>
        [JsonProperty("CountryKey")]
        public string CountryKey{ get; set; }

        /// <summary>
        /// 省份、城市简称
        /// </summary>
        [JsonProperty("CityKey")]
        public string CityKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "TargetContent", this.TargetContent);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Invalid", this.Invalid);
            this.SetParamSimple(map, prefix + "IsRegion", this.IsRegion);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "CityCode", this.CityCode);
            this.SetParamSimple(map, prefix + "CountryName", this.CountryName);
            this.SetParamSimple(map, prefix + "CityName", this.CityName);
            this.SetParamSimple(map, prefix + "CloudCode", this.CloudCode);
            this.SetParamSimple(map, prefix + "IsCloud", this.IsCloud);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InternalUuid", this.InternalUuid);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "BetaList.", this.BetaList);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "ScopeDesc", this.ScopeDesc);
            this.SetParamSimple(map, prefix + "InternetBorderUuid", this.InternetBorderUuid);
            this.SetParamSimple(map, prefix + "ParamTemplateName", this.ParamTemplateName);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "LastHitTime", this.LastHitTime);
            this.SetParamSimple(map, prefix + "CountryKey", this.CountryKey);
            this.SetParamSimple(map, prefix + "CityKey", this.CityKey);
        }
    }
}

