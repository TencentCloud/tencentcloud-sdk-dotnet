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

namespace TencentCloud.Iotvideo.V20211125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudStorageRequest : AbstractModel
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
        /// 云存套餐ID：
        /// yc1m3d ： 全时3天存储月套餐。
        /// yc1m7d ： 全时7天存储月套餐。
        /// yc1m30d ：全时30天存储月套餐。
        /// yc1y3d ：全时3天存储年套餐。
        /// yc1y7d ：全时7天存储年套餐。
        /// yc1y30d ：全时30天存储年套餐。
        /// ye1m3d ：事件3天存储月套餐。
        /// ye1m7d ：事件7天存储月套餐。
        /// ye1m30d ：事件30天存储月套餐 。
        /// ye1y3d ：事件3天存储年套餐。
        /// ye1y7d ：事件7天存储年套餐。
        /// ye1y30d ：事件30天存储年套餐。
        /// yc1w7d : 全时7天存储周套餐。
        /// ye1w7d : 事件7天存储周套餐。
        /// lye1m3d：低功耗事件3天月套餐。
        /// lye1m7d：低功耗事件7天月套餐。
        /// lye1m30d：低功耗事件30天月套餐。
        /// lye1y3d：低功耗事件3天年套餐。
        /// lye1y7d：低功耗事件7天年套餐。
        /// lye1y30d：低功耗事件30天年套餐。
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 如果当前设备已开启云存套餐，Override=1会使用新套餐覆盖原有套餐。不传此参数则默认为0。
        /// </summary>
        [JsonProperty("Override")]
        public ulong? Override{ get; set; }

        /// <summary>
        /// 套餐列表顺序：PackageQueue=front会立即使用新购买的套餐，新购套餐结束后，列表中下一个未过期的套餐继续生效；PackageQueue=end会等设备当前所有已购买套餐过期后才会生效新购套餐。与Override参数不能同时使用。
        /// </summary>
        [JsonProperty("PackageQueue")]
        public string PackageQueue{ get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 通道ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 云存视频存储区域，国内默认为ap-guangzhou。海外默认为东南亚ap-singapore，可选美东na-ashburn、欧洲eu-frankfurt。
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "Override", this.Override);
            this.SetParamSimple(map, prefix + "PackageQueue", this.PackageQueue);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
        }
    }
}

