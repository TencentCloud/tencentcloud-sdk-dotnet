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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EdrAlertItem : AbstractModel
    {
        
        /// <summary>
        /// <p>告警表id</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>APPID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>告警ID</p>
        /// </summary>
        [JsonProperty("AlertId")]
        public string AlertId{ get; set; }

        /// <summary>
        /// <p>告警大类</p>
        /// </summary>
        [JsonProperty("AlertCategory")]
        public string AlertCategory{ get; set; }

        /// <summary>
        /// <p>告警子类</p>
        /// </summary>
        [JsonProperty("AlertSubType")]
        public string AlertSubType{ get; set; }

        /// <summary>
        /// <p>策略ID</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// <p>告警等级</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>告警状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>攻击阶段</p>
        /// </summary>
        [JsonProperty("AttackStage")]
        public string AttackStage{ get; set; }

        /// <summary>
        /// <p>检测模式</p>
        /// </summary>
        [JsonProperty("DetectMode")]
        public string DetectMode{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>QUUID</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>是否付费</p>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public long? IsProVersion{ get; set; }

        /// <summary>
        /// <p>告警来源</p>
        /// </summary>
        [JsonProperty("AlertSource")]
        public string AlertSource{ get; set; }

        /// <summary>
        /// <p>镜像ID</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>容器id</p>
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>告警数量</p>
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// <p>最初发现时间</p>
        /// </summary>
        [JsonProperty("FirstDetectTime")]
        public string FirstDetectTime{ get; set; }

        /// <summary>
        /// <p>最近发现时间</p>
        /// </summary>
        [JsonProperty("LatestDetectTime")]
        public string LatestDetectTime{ get; set; }

        /// <summary>
        /// <p>规则名</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>实例名</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>公共IP</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>内网IP</p>
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// <p>该机器是否开启应用防护</p>
        /// </summary>
        [JsonProperty("RaspOpen")]
        public bool? RaspOpen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AlertId", this.AlertId);
            this.SetParamSimple(map, prefix + "AlertCategory", this.AlertCategory);
            this.SetParamSimple(map, prefix + "AlertSubType", this.AlertSubType);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AttackStage", this.AttackStage);
            this.SetParamSimple(map, prefix + "DetectMode", this.DetectMode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "AlertSource", this.AlertSource);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "FirstDetectTime", this.FirstDetectTime);
            this.SetParamSimple(map, prefix + "LatestDetectTime", this.LatestDetectTime);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "RaspOpen", this.RaspOpen);
        }
    }
}

