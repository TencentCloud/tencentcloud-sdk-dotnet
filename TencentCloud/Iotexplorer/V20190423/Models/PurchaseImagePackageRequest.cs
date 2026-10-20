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

    public class PurchaseImagePackageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>存储天数</p><p>枚举值：</p><ul><li>3： 存储3天</li><li>7： 存储7天</li><li>15： 存储15天</li><li>30： 存储30天</li></ul>
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }

        /// <summary>
        /// <p>产品 ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>设备名</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>卡有效期类型：monthly_card=月卡（12 个月有效期），annual_card=年卡（24 个月有效期）</p>
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// <p>图片档位：每日可上传的图片张数上限，&quot;300&quot;=300 张/日，&quot;1000&quot;=1000 张/日</p>
        /// </summary>
        [JsonProperty("ImageCapacity")]
        public string ImageCapacity{ get; set; }

        /// <summary>
        /// <p>同规格资源包个数（默认 1）</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// <p>通道 ID</p>
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// <p>套餐生效策略：&quot;&quot;=默认语义，front=插队生效，end=排队末尾</p>
        /// </summary>
        [JsonProperty("PackageQueue")]
        public string PackageQueue{ get; set; }

        /// <summary>
        /// <p>覆盖当前生效套餐：0=否，1=是</p>
        /// </summary>
        [JsonProperty("Override")]
        public ulong? Override{ get; set; }

        /// <summary>
        /// <p>订单id</p>
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ValidityPeriod", this.ValidityPeriod);
            this.SetParamSimple(map, prefix + "ImageCapacity", this.ImageCapacity);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "PackageQueue", this.PackageQueue);
            this.SetParamSimple(map, prefix + "Override", this.Override);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
        }
    }
}

