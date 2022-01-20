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

    public class DescribeRecordStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备Id
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 流失效时间，UNIX时间戳，30天内
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 录像文件ID
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 录像流开始时间，当录像文件ID为空时有效，UNIX时间戳
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 录像流结束时间，当录像文件iD为空时有效，UNIX时间戳
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 通道唯一标识（此接口升级为必填字段）
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
        }
    }
}

