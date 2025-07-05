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

    public class TargetInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频唯一ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

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
        /// 视频起始时间（毫秒级Unix时间戳）
        /// </summary>
        [JsonProperty("StartTimeMs")]
        public long? StartTimeMs{ get; set; }

        /// <summary>
        /// 视频结束时间（毫秒级Unix时间戳）
        /// </summary>
        [JsonProperty("EndTimeMs")]
        public long? EndTimeMs{ get; set; }

        /// <summary>
        /// 用户自定义事件ID，后续扩展使用
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 视频内容摘要
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// 通道ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 缩略图路径
        /// </summary>
        [JsonProperty("Thumbnail")]
        public string Thumbnail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "StartTimeMs", this.StartTimeMs);
            this.SetParamSimple(map, prefix + "EndTimeMs", this.EndTimeMs);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "Thumbnail", this.Thumbnail);
        }
    }
}

