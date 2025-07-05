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

    public class PackageInfo : AbstractModel
    {
        
        /// <summary>
        /// 云存开启状态，0为未开启，2为正在生效，1为已过期
        /// 注：这里只返回状态为0的数据
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 云存类型，1为全时云存，2为事件云存
        /// </summary>
        [JsonProperty("CSType")]
        public ulong? CSType{ get; set; }

        /// <summary>
        /// 云存回看时长
        /// </summary>
        [JsonProperty("CSShiftDuration")]
        public ulong? CSShiftDuration{ get; set; }

        /// <summary>
        /// 云存套餐过期时间
        /// </summary>
        [JsonProperty("CSExpiredTime")]
        public long? CSExpiredTime{ get; set; }

        /// <summary>
        /// 云存套餐创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public long? CreatedAt{ get; set; }

        /// <summary>
        /// 云存套餐更新时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public long? UpdatedAt{ get; set; }

        /// <summary>
        /// 套餐id
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 通道id
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("CSUserId")]
        public string CSUserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CSType", this.CSType);
            this.SetParamSimple(map, prefix + "CSShiftDuration", this.CSShiftDuration);
            this.SetParamSimple(map, prefix + "CSExpiredTime", this.CSExpiredTime);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "CSUserId", this.CSUserId);
        }
    }
}

