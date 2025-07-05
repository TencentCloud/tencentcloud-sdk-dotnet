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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiffDetailItem : AbstractModel
    {
        
        /// <summary>
        /// 属性
        /// </summary>
        [JsonProperty("Attribute")]
        public string Attribute{ get; set; }

        /// <summary>
        /// 当前生效
        /// </summary>
        [JsonProperty("InEffect")]
        public string InEffect{ get; set; }

        /// <summary>
        /// 待生效
        /// </summary>
        [JsonProperty("PendingEffectiveness")]
        public string PendingEffectiveness{ get; set; }

        /// <summary>
        /// 操作
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 队列
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// 配置集
        /// </summary>
        [JsonProperty("ConfigSet")]
        public string ConfigSet{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// 当前所在位置
        /// </summary>
        [JsonProperty("InEffectIndex")]
        public string InEffectIndex{ get; set; }

        /// <summary>
        /// 待生效的位置
        /// </summary>
        [JsonProperty("PendingEffectIndex")]
        public string PendingEffectIndex{ get; set; }

        /// <summary>
        /// 计划模式名称
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 放置规则
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Attribute", this.Attribute);
            this.SetParamSimple(map, prefix + "InEffect", this.InEffect);
            this.SetParamSimple(map, prefix + "PendingEffectiveness", this.PendingEffectiveness);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "ConfigSet", this.ConfigSet);
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamSimple(map, prefix + "InEffectIndex", this.InEffectIndex);
            this.SetParamSimple(map, prefix + "PendingEffectIndex", this.PendingEffectIndex);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
        }
    }
}

