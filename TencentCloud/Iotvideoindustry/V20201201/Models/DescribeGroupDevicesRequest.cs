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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGroupDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 偏移量，默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 限制值，默认200
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 设备名称，根据设备名称模糊匹配时必填
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 过滤不可录制设备
        /// </summary>
        [JsonProperty("Recordable")]
        public long? Recordable{ get; set; }

        /// <summary>
        /// 当Group是普通组的时候，支持根据DeviceTypes筛选类型，
        ///  设备类型，1：国标VMS设备(公有云不支持此类型)，2：国标IPC设备，3：国标NVR设备，9：智能告警设备(公有云不支持此类型)
        /// </summary>
        [JsonProperty("DeviceTypes")]
        public long?[] DeviceTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Recordable", this.Recordable);
            this.SetParamArraySimple(map, prefix + "DeviceTypes.", this.DeviceTypes);
        }
    }
}

