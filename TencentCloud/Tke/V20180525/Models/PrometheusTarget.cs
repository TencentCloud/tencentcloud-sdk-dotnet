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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusTarget : AbstractModel
    {
        
        /// <summary>
        /// 抓取目标的URL
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// target当前状态,当前支持
        /// up = 健康
        /// down = 不健康
        /// unknown = 未知
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// target的元label
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// 上一次抓取的时间
        /// </summary>
        [JsonProperty("LastScrape")]
        public string LastScrape{ get; set; }

        /// <summary>
        /// 上一次抓取的耗时，单位是s
        /// </summary>
        [JsonProperty("ScrapeDuration")]
        public float? ScrapeDuration{ get; set; }

        /// <summary>
        /// 上一次抓取如果错误，该字段存储错误信息
        /// </summary>
        [JsonProperty("Error")]
        public string Error{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "LastScrape", this.LastScrape);
            this.SetParamSimple(map, prefix + "ScrapeDuration", this.ScrapeDuration);
            this.SetParamSimple(map, prefix + "Error", this.Error);
        }
    }
}

