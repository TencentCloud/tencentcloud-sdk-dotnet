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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplayConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>主键Id</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>地址</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>站点标题</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>状态码</p>
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// <p>响应长度</p>
        /// </summary>
        [JsonProperty("ContentLength")]
        public long? ContentLength{ get; set; }

        /// <summary>
        /// <p>公共字段</p>
        /// </summary>
        [JsonProperty("DisplayToolCommon")]
        public DisplayToolCommon DisplayToolCommon{ get; set; }

        /// <summary>
        /// <p>Ip数据</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>AI评分</p>
        /// </summary>
        [JsonProperty("AIRating")]
        public long? AIRating{ get; set; }

        /// <summary>
        /// <p>AI分析</p>
        /// </summary>
        [JsonProperty("AIAnalysis")]
        public string AIAnalysis{ get; set; }

        /// <summary>
        /// <p>风险等级: 1-低危, 2-中危, 3-高危, 4-危级, 5-误报</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// <p>建议</p>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// <p>是否为云资产</p>
        /// </summary>
        [JsonProperty("IsCloudAsset")]
        public long? IsCloudAsset{ get; set; }

        /// <summary>
        /// <p>云资产状态，-1为下线</p>
        /// </summary>
        [JsonProperty("CloudAssetStatus")]
        public long? CloudAssetStatus{ get; set; }

        /// <summary>
        /// <p>聚合视角下该组真实子项总数；非聚合视角为 0</p>
        /// </summary>
        [JsonProperty("AggregationCount")]
        public long? AggregationCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "ContentLength", this.ContentLength);
            this.SetParamObj(map, prefix + "DisplayToolCommon.", this.DisplayToolCommon);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "AIRating", this.AIRating);
            this.SetParamSimple(map, prefix + "AIAnalysis", this.AIAnalysis);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "IsCloudAsset", this.IsCloudAsset);
            this.SetParamSimple(map, prefix + "CloudAssetStatus", this.CloudAssetStatus);
            this.SetParamSimple(map, prefix + "AggregationCount", this.AggregationCount);
        }
    }
}

