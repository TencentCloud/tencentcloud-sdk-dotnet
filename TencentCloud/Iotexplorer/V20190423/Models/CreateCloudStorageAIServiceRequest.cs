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

    public class CreateCloudStorageAIServiceRequest : AbstractModel
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
        /// 云存 AI 套餐 ID。可选值：
        /// 
        /// - `1m_low_od`：低功耗目标检测月套餐
        /// - `1y_low_od`：低功耗目标检测年套餐
        /// - `1m_ev_od`：事件目标检测月套餐
        /// - `1y_ev_od`：事件目标检测年套餐
        /// - `1m_ft_od`：全时目标检测月套餐
        /// - `1y_ft_od`：全时目标检测年套餐
        /// - `1m_low_hl`：低功耗视频浓缩月套餐
        /// - `1y_low_hl`：低功耗视频浓缩年套餐
        /// - `1m_ev_hl`：事件视频浓缩月套餐
        /// - `1y_ev_hl`：事件视频浓缩年套餐
        /// - `1m_ft_hl`：全时视频浓缩月套餐
        /// - `1y_ft_hl`：全时视频浓缩年套餐
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 通道 ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 订单 ID
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
        }
    }
}

