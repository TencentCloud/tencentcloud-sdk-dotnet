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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselinePolicy : AbstractModel
    {
        
        /// <summary>
        /// 策略名称,长度不超过128英文字符
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 检测间隔[1:1天|3:3天|5:5天|7:7天]
        /// </summary>
        [JsonProperty("DetectInterval")]
        public long? DetectInterval{ get; set; }

        /// <summary>
        /// 检测时间
        /// </summary>
        [JsonProperty("DetectTime")]
        public string DetectTime{ get; set; }

        /// <summary>
        /// 是否开启[0:未开启|1:开启]
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// 资产类型[0:所有专业版旗舰版|1:id|2:ip]
        /// </summary>
        [JsonProperty("AssetType")]
        public long? AssetType{ get; set; }

        /// <summary>
        /// 策略Id
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// 关联基线项数目
        /// </summary>
        [JsonProperty("RuleCount")]
        public long? RuleCount{ get; set; }

        /// <summary>
        /// 关联基线项数目
        /// </summary>
        [JsonProperty("ItemCount")]
        public long? ItemCount{ get; set; }

        /// <summary>
        /// 关联基线主机数目
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// 规则Id
        /// </summary>
        [JsonProperty("RuleIds")]
        public long?[] RuleIds{ get; set; }

        /// <summary>
        /// 主机Id
        /// </summary>
        [JsonProperty("HostIds")]
        public string[] HostIds{ get; set; }

        /// <summary>
        /// 主机Ip
        /// </summary>
        [JsonProperty("HostIps")]
        public string[] HostIps{ get; set; }

        /// <summary>
        /// 是否是系统默认
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "DetectInterval", this.DetectInterval);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "RuleCount", this.RuleCount);
            this.SetParamSimple(map, prefix + "ItemCount", this.ItemCount);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamArraySimple(map, prefix + "RuleIds.", this.RuleIds);
            this.SetParamArraySimple(map, prefix + "HostIds.", this.HostIds);
            this.SetParamArraySimple(map, prefix + "HostIps.", this.HostIps);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
        }
    }
}

