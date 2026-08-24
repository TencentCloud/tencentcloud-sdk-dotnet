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

    public class ListTWeSeePersonsRequest : AbstractModel
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
        /// 分页拉取数量，取值范围为 1 到 100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 分页拉取偏移，默认值为 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 通道 ID，默认值为 0
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 每个人员返回的代表人脸数量，取值范围为 1 到 5，默认值为 1
        /// </summary>
        [JsonProperty("FaceLimit")]
        public ulong? FaceLimit{ get; set; }

        /// <summary>
        /// 人员记忆状态。true：仅查询持久记忆人员；false：仅查询非持久记忆人员；不传时查询全部人员
        /// </summary>
        [JsonProperty("IsRemembered")]
        public bool? IsRemembered{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "FaceLimit", this.FaceLimit);
            this.SetParamSimple(map, prefix + "IsRemembered", this.IsRemembered);
        }
    }
}

