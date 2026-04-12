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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLaneRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>灰度发布规则ID。该参数可以通过调用 <a href="https://cloud.tencent.com/document/product/649/44505">DescribeLaneRules</a> 的返回值中的 RuleId 字段来获取或通过登录<a href="https://console.cloud.tencent.com/tse/tsf-consul?tab=grayscale&amp;subTab=lanerule">控制台</a>查看；也可以调用<a href="https://cloud.tencent.com/document/product/649/44507">CreateLaneRule</a>创建新的灰度发布规则。</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>灰度发布规则名称，最多支持60个字符，支持中英文字符。</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>灰度发布规则备注，最多支持200个字符。</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>灰度发布规则标签列表。</p>
        /// </summary>
        [JsonProperty("RuleTagList")]
        public LaneRuleTag[] RuleTagList{ get; set; }

        /// <summary>
        /// <p>泳道配置ID。该参数可以通过调用 <a href="https://cloud.tencent.com/document/product/649/44504">DescribeLanes</a> 的返回值中的 LaneId 字段来获取或通过登录<a href="https://console.cloud.tencent.com/tse/tsf-consul?tab=grayscale&amp;subTab=lane">控制台</a>查看；也可以调用<a href="https://cloud.tencent.com/document/product/649/44508">CreateLane</a>创建新的泳道配置。</p>
        /// </summary>
        [JsonProperty("LaneId")]
        public string LaneId{ get; set; }

        /// <summary>
        /// <p>开启状态。</p><ul><li>true：开启</li><li>false：关闭</li></ul>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>灰度发布规则标签关系。- RELEATION_AND：与- RELEATION_OR：或</p>
        /// </summary>
        [JsonProperty("RuleTagRelationship")]
        public string RuleTagRelationship{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "RuleTagList.", this.RuleTagList);
            this.SetParamSimple(map, prefix + "LaneId", this.LaneId);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "RuleTagRelationship", this.RuleTagRelationship);
        }
    }
}

