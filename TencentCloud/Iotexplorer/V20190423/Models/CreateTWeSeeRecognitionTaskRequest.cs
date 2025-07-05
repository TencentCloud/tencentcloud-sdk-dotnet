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

    public class CreateTWeSeeRecognitionTaskRequest : AbstractModel
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
        /// 输入视频 / 图片的 URL
        /// </summary>
        [JsonProperty("InputURL")]
        public string InputURL{ get; set; }

        /// <summary>
        /// 自定义事件 ID
        /// </summary>
        [JsonProperty("CustomId")]
        public string CustomId{ get; set; }

        /// <summary>
        /// 是否保存该事件使其可被搜索
        /// </summary>
        [JsonProperty("EnableSearch")]
        public bool? EnableSearch{ get; set; }

        /// <summary>
        /// 事件起始时间事件起始时间（毫秒级 UNIX 时间戳，若不传则默认为接口调用时间）
        /// </summary>
        [JsonProperty("StartTimeMs")]
        public ulong? StartTimeMs{ get; set; }

        /// <summary>
        /// 事件结束时间事件起始时间（毫秒级 UNIX 时间戳，若不传则默认为接口调用时间）
        /// </summary>
        [JsonProperty("EndTimeMs")]
        public ulong? EndTimeMs{ get; set; }

        /// <summary>
        /// 算法配置
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 是否自定义设备，为 true 时不检查设备存在性，默认为 false
        /// </summary>
        [JsonProperty("IsCustomDevice")]
        public bool? IsCustomDevice{ get; set; }

        /// <summary>
        /// 输入类型。可选值：
        /// 
        /// - `video`：视频（默认值）
        /// - `image`：图片
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 摘要服务质量。可选值：
        /// 
        /// - `minutely`：分钟级（默认值）
        /// - `immediate`：立即
        /// </summary>
        [JsonProperty("SummaryQOS")]
        public string SummaryQOS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "InputURL", this.InputURL);
            this.SetParamSimple(map, prefix + "CustomId", this.CustomId);
            this.SetParamSimple(map, prefix + "EnableSearch", this.EnableSearch);
            this.SetParamSimple(map, prefix + "StartTimeMs", this.StartTimeMs);
            this.SetParamSimple(map, prefix + "EndTimeMs", this.EndTimeMs);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "IsCustomDevice", this.IsCustomDevice);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "SummaryQOS", this.SummaryQOS);
        }
    }
}

