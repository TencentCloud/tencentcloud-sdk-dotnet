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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceVirtualDeviceGroupsDetail : AbstractModel
    {
        
        /// <summary>
        /// 终端自定义分组id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 自定义分组名称
        /// </summary>
        [JsonProperty("DeviceVirtualGroupName")]
        public string DeviceVirtualGroupName{ get; set; }

        /// <summary>
        /// 设备数
        /// </summary>
        [JsonProperty("DeviceCount")]
        public long? DeviceCount{ get; set; }

        /// <summary>
        /// 系统类型（0: win，1：linux，2: mac，4：android，5：ios  ）
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("Itime")]
        public string Itime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("Utime")]
        public string Utime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DeviceVirtualGroupName", this.DeviceVirtualGroupName);
            this.SetParamSimple(map, prefix + "DeviceCount", this.DeviceCount);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "Itime", this.Itime);
            this.SetParamSimple(map, prefix + "Utime", this.Utime);
        }
    }
}

