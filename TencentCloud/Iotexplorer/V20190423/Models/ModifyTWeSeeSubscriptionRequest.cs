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

    public class ModifyTWeSeeSubscriptionRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品 ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 算法类型。可选值：
        /// 
        /// - `VID_COMP`：视频理解
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 通道 ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 功能开关。`true` 为开启，`false` 为关闭；不传表示不修改
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 视觉理解配置（适用于视频理解、图片理解），不传则不修改
        /// </summary>
        [JsonProperty("ComprehensionConfig")]
        public SeeComprehensionConfig ComprehensionConfig{ get; set; }

        /// <summary>
        /// 视频语义浓缩配置（适用于视频语义浓缩），不传则不修改
        /// </summary>
        [JsonProperty("CompHighlightConfig")]
        public SeeCompHighlightConfig CompHighlightConfig{ get; set; }

        /// <summary>
        /// 云存事件 ID 过滤规则配置，不传则不修改
        /// </summary>
        [JsonProperty("EventIdFilterConfig")]
        public SeeEventIdFilterConfig EventIdFilterConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "ComprehensionConfig.", this.ComprehensionConfig);
            this.SetParamObj(map, prefix + "CompHighlightConfig.", this.CompHighlightConfig);
            this.SetParamObj(map, prefix + "EventIdFilterConfig.", this.EventIdFilterConfig);
        }
    }
}

