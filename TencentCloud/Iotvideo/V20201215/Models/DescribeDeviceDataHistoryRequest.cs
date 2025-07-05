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

namespace TencentCloud.Iotvideo.V20201215.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceDataHistoryRequest : AbstractModel
    {
        
        /// <summary>
        /// 区间开始时间（Unix 时间戳，毫秒级）
        /// </summary>
        [JsonProperty("MinTime")]
        public ulong? MinTime{ get; set; }

        /// <summary>
        /// 区间结束时间（Unix 时间戳，毫秒级）
        /// </summary>
        [JsonProperty("MaxTime")]
        public ulong? MaxTime{ get; set; }

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
        /// 属性字段名称，对应数据模板中功能属性的标识符
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// 返回条数
        /// </summary>
        [JsonProperty("Limit")]
        public ulong?[] Limit{ get; set; }

        /// <summary>
        /// 检索上下文
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinTime", this.MinTime);
            this.SetParamSimple(map, prefix + "MaxTime", this.MaxTime);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamArraySimple(map, prefix + "Limit.", this.Limit);
            this.SetParamSimple(map, prefix + "Context", this.Context);
        }
    }
}

