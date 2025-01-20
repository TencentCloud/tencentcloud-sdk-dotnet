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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScoreInfo : AbstractModel
    {
        
        /// <summary>
        /// duration
        /// </summary>
        [JsonProperty("StaticDuration")]
        public string StaticDuration{ get; set; }

        /// <summary>
        /// pv
        /// </summary>
        [JsonProperty("PagePv")]
        public string PagePv{ get; set; }

        /// <summary>
        /// 失败
        /// </summary>
        [JsonProperty("ApiFail")]
        public string ApiFail{ get; set; }

        /// <summary>
        /// 请求
        /// </summary>
        [JsonProperty("ApiNum")]
        public string ApiNum{ get; set; }

        /// <summary>
        /// fail
        /// </summary>
        [JsonProperty("StaticFail")]
        public string StaticFail{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// uv
        /// </summary>
        [JsonProperty("PageUv")]
        public string PageUv{ get; set; }

        /// <summary>
        /// 请求次数
        /// </summary>
        [JsonProperty("ApiDuration")]
        public string ApiDuration{ get; set; }

        /// <summary>
        /// 项目总分
        /// </summary>
        [JsonProperty("Score")]
        public string Score{ get; set; }

        /// <summary>
        /// error
        /// </summary>
        [JsonProperty("PageError")]
        public string PageError{ get; set; }

        /// <summary>
        /// num
        /// </summary>
        [JsonProperty("StaticNum")]
        public string StaticNum{ get; set; }

        /// <summary>
        /// num
        /// </summary>
        [JsonProperty("RecordNum")]
        public long? RecordNum{ get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        [JsonProperty("PageDuration")]
        public string PageDuration{ get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 页面性能评分
        /// </summary>
        [JsonProperty("PagePerformanceScore")]
        public string PagePerformanceScore{ get; set; }

        /// <summary>
        /// js错误评分
        /// </summary>
        [JsonProperty("JsErrorScore")]
        public string JsErrorScore{ get; set; }

        /// <summary>
        /// API性能评分
        /// </summary>
        [JsonProperty("ApiPerformanceScore")]
        public string ApiPerformanceScore{ get; set; }

        /// <summary>
        /// API可用性评分
        /// </summary>
        [JsonProperty("ApiAvaliableScore")]
        public string ApiAvaliableScore{ get; set; }

        /// <summary>
        /// 静态资源性能评分
        /// </summary>
        [JsonProperty("StaticPerformanceScore")]
        public string StaticPerformanceScore{ get; set; }

        /// <summary>
        /// 静态资源可用性评分
        /// </summary>
        [JsonProperty("StaticAvaliableScore")]
        public string StaticAvaliableScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StaticDuration", this.StaticDuration);
            this.SetParamSimple(map, prefix + "PagePv", this.PagePv);
            this.SetParamSimple(map, prefix + "ApiFail", this.ApiFail);
            this.SetParamSimple(map, prefix + "ApiNum", this.ApiNum);
            this.SetParamSimple(map, prefix + "StaticFail", this.StaticFail);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "PageUv", this.PageUv);
            this.SetParamSimple(map, prefix + "ApiDuration", this.ApiDuration);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "PageError", this.PageError);
            this.SetParamSimple(map, prefix + "StaticNum", this.StaticNum);
            this.SetParamSimple(map, prefix + "RecordNum", this.RecordNum);
            this.SetParamSimple(map, prefix + "PageDuration", this.PageDuration);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PagePerformanceScore", this.PagePerformanceScore);
            this.SetParamSimple(map, prefix + "JsErrorScore", this.JsErrorScore);
            this.SetParamSimple(map, prefix + "ApiPerformanceScore", this.ApiPerformanceScore);
            this.SetParamSimple(map, prefix + "ApiAvaliableScore", this.ApiAvaliableScore);
            this.SetParamSimple(map, prefix + "StaticPerformanceScore", this.StaticPerformanceScore);
            this.SetParamSimple(map, prefix + "StaticAvaliableScore", this.StaticAvaliableScore);
        }
    }
}

