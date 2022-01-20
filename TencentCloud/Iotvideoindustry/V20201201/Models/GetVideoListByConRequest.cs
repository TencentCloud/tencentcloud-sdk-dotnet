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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetVideoListByConRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 偏移量，默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 限制量，默认200
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 通道唯一标识，对于NVR设备，多通道IPC设备，设备编码与通道编码不一致的IPC设备，此字段为必填
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// 0：查询指定日期的录像；1：查询最近一天的录像；默认0
        /// </summary>
        [JsonProperty("LatestDay")]
        public long? LatestDay{ get; set; }

        /// <summary>
        /// 指定某天。取值【YYYY-MM-DD】
        /// 为空时默认查询最近一天的记录
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 1: 云端录制 2: 本地录制
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "LatestDay", this.LatestDay);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

