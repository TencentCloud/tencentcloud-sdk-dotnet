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

    public class ListTWeSeeTasksRequest : AbstractModel
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
        /// 算法类目。可选值：
        /// - `COMPREHENSION`：视觉理解
        /// - `HIGHLIGHT`：视频浓缩
        /// </summary>
        [JsonProperty("ServiceCategory")]
        public string ServiceCategory{ get; set; }

        /// <summary>
        /// 分页拉取数量
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 分页拉取偏移
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 算法类型。
        /// 
        /// 当 ServiceCategory 为 `COMPREHENSION` 时，可选值包括：
        /// - `VID_COMP`：视频理解
        /// - `IMG_COMP`：图片理解
        /// - `CONT_PERSON_MOTIONLESS`：静姿检测
        /// 
        /// 当 ServiceCategory 为 `HIGHLIGHT` 时，可选值包括：
        /// - `COMP_HIGHLIGHT`：视频浓缩
        /// </summary>
        [JsonProperty("ServiceTypes")]
        public string[] ServiceTypes{ get; set; }

        /// <summary>
        /// 通道 ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 查询任务时间范围的起始时间（毫秒级 UNIX 时间戳）。不传则不生效时间范围条件。
        /// </summary>
        [JsonProperty("StartTimeMs")]
        public long? StartTimeMs{ get; set; }

        /// <summary>
        /// 查询任务时间范围的结束时间（毫秒级 UNIX 时间戳）。不传则不生效时间范围条件。
        /// </summary>
        [JsonProperty("EndTimeMs")]
        public long? EndTimeMs{ get; set; }

        /// <summary>
        /// 要查询的任务的状态条件。不传则不按照状态过滤，可选值：
        /// 
        /// - `1`：失败
        /// - `2`：空结果
        /// - `3`：有效结果
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 下载 URL 的过期时间（秒级 UNIX 时间戳）。若传入该参数，则响应中将包含所有文件的下载 URL
        /// </summary>
        [JsonProperty("FileURLExpireTime")]
        public long? FileURLExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ServiceCategory", this.ServiceCategory);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "ServiceTypes.", this.ServiceTypes);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "StartTimeMs", this.StartTimeMs);
            this.SetParamSimple(map, prefix + "EndTimeMs", this.EndTimeMs);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FileURLExpireTime", this.FileURLExpireTime);
        }
    }
}

