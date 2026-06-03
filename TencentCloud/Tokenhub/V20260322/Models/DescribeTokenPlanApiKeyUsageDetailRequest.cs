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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTokenPlanApiKeyUsageDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 套餐 ID。可通过DescribeTokenPlanList接口获取。
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// 起始时间，RFC3339 格式。不传默认为结束时间前 15 分钟。
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 结束时间，RFC3339 格式。不传默认为当前时间。
        /// </summary>
        [JsonProperty("To")]
        public string To{ get; set; }

        /// <summary>
        /// 排序方式。取值：asc（升序）、desc（降序），默认为 desc。
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 返回条数，默认为 20，最大值为 100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 翻页上下文，首次查询不传，后续传入上次返回的 Context，直到 ListOver 为 true。
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 按 API Key ID 精确过滤。最大 128 字符。与 ApiKeyName 至少需传入其一，都传时以 ApiKeyId 为准。可通过 DescribeTokenPlanApiKeyList 接口获取。
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// 按 API Key 名称模糊过滤。最大 64 字符。与 ApiKeyId 至少需传入其一，都传时以 ApiKeyId 为准。
        /// </summary>
        [JsonProperty("ApiKeyName")]
        public string ApiKeyName{ get; set; }

        /// <summary>
        /// 按模型 ID (Model ID) 精确过滤。需要按模型名称过滤时传入该字段。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "ApiKeyId", this.ApiKeyId);
            this.SetParamSimple(map, prefix + "ApiKeyName", this.ApiKeyName);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
        }
    }
}

