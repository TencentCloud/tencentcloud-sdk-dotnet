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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfwAnalysisDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>分析场景。必填。full_traffic 表示全流量深度分析；east_west 表示东西向流量分析；alert_comprehensive 表示告警综合分析；asset_exposure 表示资产暴露面分析；access_troubleshoot 表示访问阻断排障分析。</p>
        /// </summary>
        [JsonProperty("Scenario")]
        public string Scenario{ get; set; }

        /// <summary>
        /// <p>查询开始时间。可选，格式 YYYY-MM-DD HH:MM:SS；不传时默认查询最近 7 天。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询结束时间。可选，格式 YYYY-MM-DD HH:MM:SS；不传时默认当前时间。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>分析对象类型。可选，默认 user；user 表示租户全局，asset 表示单个资产，vpc 表示 VPC，domain 表示域名。</p>
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// <p>分析对象标识。ObjectType 为 asset、vpc 或 domain 时按需传入，可填写 IP、实例 ID、VPC ID 或域名。</p>
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// <p>排障目标。可选，主要用于 access_troubleshoot 场景，可填写 IP 或域名。</p>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// <p>需要跳过的分析段名称列表。可选；不传时执行该场景全部分析段。</p>
        /// </summary>
        [JsonProperty("SkipSections")]
        public string[] SkipSections{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scenario", this.Scenario);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamArraySimple(map, prefix + "SkipSections.", this.SkipSections);
        }
    }
}

