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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvokeAISearchServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 自然语言查询
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 搜索结果总结的语言类型，支持的类型有：en-US、zh-CN、id-ID、th-TH
        /// </summary>
        [JsonProperty("SummaryLang")]
        public string SummaryLang{ get; set; }

        /// <summary>
        /// 通道ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 是否需要返回总结，默认为True；  开启后会加大接口响应时长
        /// </summary>
        [JsonProperty("EnableSummary")]
        public bool? EnableSummary{ get; set; }

        /// <summary>
        /// 开始时间。
        /// 
        /// 注：
        /// 1. 单位为毫秒（ms）
        /// 2. 如果同时指定了StartTimeMs与EndTimeMs，时间区间不能大于7天；如果只指定其中一个（例如只指定StartTimeMs，则查询自StartTimeMs后7天内的数据， 反之EndTimeMs也一样）
        /// 3. 只要指定了其中一个参数，接口则会忽略Query参数中关于时间的描述；（例如Query为"过去三天关于猫咪的视频"， 则会将"过去三天忽略"）
        /// </summary>
        [JsonProperty("StartTimeMs")]
        public long? StartTimeMs{ get; set; }

        /// <summary>
        /// 结束时间。
        /// 
        /// 注：
        /// 1. 单位为毫秒（ms）
        /// 2. 如果同时指定了StartTimeMs与EndTimeMs，时间区间不能大于7天；如果只指定其中一个（例如只指定StartTimeMs，则查询自StartTimeMs后7天内的数据， 反之EndTimeMs也一样）
        /// 3. 只要指定了其中一个参数，接口则会忽略Query参数中关于时间的描述；（例如Query为"过去三天关于猫咪的视频"， 则会将"过去三天忽略"）
        /// </summary>
        [JsonProperty("EndTimeMs")]
        public long? EndTimeMs{ get; set; }

        /// <summary>
        /// 时区。默认值：Asia/Shanghai
        /// 
        /// 注：
        /// 符合iana标准 https://www.iana.org/time-zones，例如Asia/Shanghai、Asia/Bangkok
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// 取值为1表示高级搜索，取值为2表示简单搜索，默认为1
        /// </summary>
        [JsonProperty("SearchMode")]
        public long? SearchMode{ get; set; }

        /// <summary>
        /// 最终输出的条数；仅当SearchMode为2时支持自定义设置，默认为50
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 向量搜索的相似度搜索半径，取值范围[-1, 1]；仅当SearchMode为2时支持自定义设置，默认为0.5
        /// </summary>
        [JsonProperty("VectorSearchRadius")]
        public float? VectorSearchRadius{ get; set; }

        /// <summary>
        /// 指定向量搜索最相似的 Top K；仅当SearchMode为2时支持自定义设置，默认为100
        /// </summary>
        [JsonProperty("VectorSearchTopK")]
        public long? VectorSearchTopK{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "SummaryLang", this.SummaryLang);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "EnableSummary", this.EnableSummary);
            this.SetParamSimple(map, prefix + "StartTimeMs", this.StartTimeMs);
            this.SetParamSimple(map, prefix + "EndTimeMs", this.EndTimeMs);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "SearchMode", this.SearchMode);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "VectorSearchRadius", this.VectorSearchRadius);
            this.SetParamSimple(map, prefix + "VectorSearchTopK", this.VectorSearchTopK);
        }
    }
}

