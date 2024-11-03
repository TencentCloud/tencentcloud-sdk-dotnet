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

    public class BlockIgnoreRule : AbstractModel
    {
        
        /// <summary>
        /// 规则类型，取值：1 封禁，2外部IP，3域名，4情报，5assets，6自定义策略，7入侵防御规则id （2-7属于白名单类型）
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// 规则ip或白名单内容
        /// </summary>
        [JsonProperty("Ioc")]
        public string Ioc{ get; set; }

        /// <summary>
        /// 资产实例名称、自定义策略名称等
        /// </summary>
        [JsonProperty("IocName")]
        public string IocName{ get; set; }

        /// <summary>
        /// 白名单信息
        /// </summary>
        [JsonProperty("IocInfo")]
        public string IocInfo{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 危险等级
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 来源事件名称
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// 方向：1入站，0出站
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// 所有方向聚合成字符串
        /// </summary>
        [JsonProperty("DirectionList")]
        public string DirectionList{ get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 地理位置
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 规则类型：1封禁，2放通
        /// </summary>
        [JsonProperty("Action")]
        public long? Action{ get; set; }

        /// <summary>
        /// 规则生效开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 规则生效结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 忽略原因
        /// </summary>
        [JsonProperty("IgnoreReason")]
        public string IgnoreReason{ get; set; }

        /// <summary>
        /// 安全事件来源
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("UniqueId")]
        public string UniqueId{ get; set; }

        /// <summary>
        /// 规则命中次数
        /// </summary>
        [JsonProperty("MatchTimes")]
        public long? MatchTimes{ get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 上次命中时间
        /// </summary>
        [JsonProperty("LastHitTime")]
        public string LastHitTime{ get; set; }

        /// <summary>
        /// 自定义规则细节
        /// </summary>
        [JsonProperty("CustomRule")]
        public CustomWhiteRule CustomRule{ get; set; }

        /// <summary>
        /// 1 border 2 nat 4 vpc 8 border-serial
        /// </summary>
        [JsonProperty("FwType")]
        public long? FwType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Ioc", this.Ioc);
            this.SetParamSimple(map, prefix + "IocName", this.IocName);
            this.SetParamSimple(map, prefix + "IocInfo", this.IocInfo);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "DirectionList", this.DirectionList);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "IgnoreReason", this.IgnoreReason);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "UniqueId", this.UniqueId);
            this.SetParamSimple(map, prefix + "MatchTimes", this.MatchTimes);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "LastHitTime", this.LastHitTime);
            this.SetParamObj(map, prefix + "CustomRule.", this.CustomRule);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
        }
    }
}

