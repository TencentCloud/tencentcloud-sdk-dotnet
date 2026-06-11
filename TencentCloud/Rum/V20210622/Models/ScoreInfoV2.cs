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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScoreInfoV2 : AbstractModel
    {
        
        /// <summary>
        /// <p>项目id</p>
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// <p>项目总分</p>
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// <p>API性能评分</p>
        /// </summary>
        [JsonProperty("ApiPerformanceScore")]
        public float? ApiPerformanceScore{ get; set; }

        /// <summary>
        /// <p>API可用性评分</p>
        /// </summary>
        [JsonProperty("ApiAvailableScore")]
        public float? ApiAvailableScore{ get; set; }

        /// <summary>
        /// <p>API调用总数</p>
        /// </summary>
        [JsonProperty("ApiNum")]
        public long? ApiNum{ get; set; }

        /// <summary>
        /// <p>API失败次数</p>
        /// </summary>
        [JsonProperty("ApiFail")]
        public long? ApiFail{ get; set; }

        /// <summary>
        /// <p>API平均持续时间</p>
        /// </summary>
        [JsonProperty("ApiDuration")]
        public float? ApiDuration{ get; set; }

        /// <summary>
        /// <p>页面性能评分</p>
        /// </summary>
        [JsonProperty("PagePerformanceScore")]
        public float? PagePerformanceScore{ get; set; }

        /// <summary>
        /// <p>页面浏览量</p>
        /// </summary>
        [JsonProperty("PagePv")]
        public long? PagePv{ get; set; }

        /// <summary>
        /// <p>独立访客数</p>
        /// </summary>
        [JsonProperty("PageUv")]
        public long? PageUv{ get; set; }

        /// <summary>
        /// <p>页面错误数</p>
        /// </summary>
        [JsonProperty("PageError")]
        public long? PageError{ get; set; }

        /// <summary>
        /// <p>首屏时间</p>
        /// </summary>
        [JsonProperty("PageDuration")]
        public float? PageDuration{ get; set; }

        /// <summary>
        /// <p>平均 LCP</p>
        /// </summary>
        [JsonProperty("PageLCP")]
        public float? PageLCP{ get; set; }

        /// <summary>
        /// <p>平均 FID</p>
        /// </summary>
        [JsonProperty("PageFID")]
        public float? PageFID{ get; set; }

        /// <summary>
        /// <p>平均 CLS</p>
        /// </summary>
        [JsonProperty("PageCLS")]
        public float? PageCLS{ get; set; }

        /// <summary>
        /// <p>平均 FCP</p>
        /// </summary>
        [JsonProperty("PageFCP")]
        public float? PageFCP{ get; set; }

        /// <summary>
        /// <p>平均 INP</p>
        /// </summary>
        [JsonProperty("PageINP")]
        public float? PageINP{ get; set; }

        /// <summary>
        /// <p>JavaScript错误评分</p>
        /// </summary>
        [JsonProperty("JsErrorScore")]
        public float? JsErrorScore{ get; set; }

        /// <summary>
        /// <p>静态资源可用性评分</p>
        /// </summary>
        [JsonProperty("StaticAvailableScore")]
        public float? StaticAvailableScore{ get; set; }

        /// <summary>
        /// <p>静态资源性能评分</p>
        /// </summary>
        [JsonProperty("StaticPerformanceScore")]
        public float? StaticPerformanceScore{ get; set; }

        /// <summary>
        /// <p>静态资源请求总数</p>
        /// </summary>
        [JsonProperty("StaticNum")]
        public long? StaticNum{ get; set; }

        /// <summary>
        /// <p>静态资源加载失败数</p>
        /// </summary>
        [JsonProperty("StaticFail")]
        public long? StaticFail{ get; set; }

        /// <summary>
        /// <p>静态资源加载时间</p>
        /// </summary>
        [JsonProperty("StaticDuration")]
        public float? StaticDuration{ get; set; }

        /// <summary>
        /// <p>忽略的配置项</p>
        /// </summary>
        [JsonProperty("Exclusion")]
        public string Exclusion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "ApiPerformanceScore", this.ApiPerformanceScore);
            this.SetParamSimple(map, prefix + "ApiAvailableScore", this.ApiAvailableScore);
            this.SetParamSimple(map, prefix + "ApiNum", this.ApiNum);
            this.SetParamSimple(map, prefix + "ApiFail", this.ApiFail);
            this.SetParamSimple(map, prefix + "ApiDuration", this.ApiDuration);
            this.SetParamSimple(map, prefix + "PagePerformanceScore", this.PagePerformanceScore);
            this.SetParamSimple(map, prefix + "PagePv", this.PagePv);
            this.SetParamSimple(map, prefix + "PageUv", this.PageUv);
            this.SetParamSimple(map, prefix + "PageError", this.PageError);
            this.SetParamSimple(map, prefix + "PageDuration", this.PageDuration);
            this.SetParamSimple(map, prefix + "PageLCP", this.PageLCP);
            this.SetParamSimple(map, prefix + "PageFID", this.PageFID);
            this.SetParamSimple(map, prefix + "PageCLS", this.PageCLS);
            this.SetParamSimple(map, prefix + "PageFCP", this.PageFCP);
            this.SetParamSimple(map, prefix + "PageINP", this.PageINP);
            this.SetParamSimple(map, prefix + "JsErrorScore", this.JsErrorScore);
            this.SetParamSimple(map, prefix + "StaticAvailableScore", this.StaticAvailableScore);
            this.SetParamSimple(map, prefix + "StaticPerformanceScore", this.StaticPerformanceScore);
            this.SetParamSimple(map, prefix + "StaticNum", this.StaticNum);
            this.SetParamSimple(map, prefix + "StaticFail", this.StaticFail);
            this.SetParamSimple(map, prefix + "StaticDuration", this.StaticDuration);
            this.SetParamSimple(map, prefix + "Exclusion", this.Exclusion);
        }
    }
}

