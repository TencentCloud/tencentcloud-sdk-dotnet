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

namespace TencentCloud.Taf.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManageDeviceRiskInput : AbstractModel
    {
        
        /// <summary>
        /// 设备操作平台  1：android
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 设备类型  6: oaid_md5(32位小写)
        /// </summary>
        [JsonProperty("DeviceType")]
        public long? DeviceType{ get; set; }

        /// <summary>
        /// 根据 DeviceType 填写设备标识
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 用户ip，只支持ipv4
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
        }
    }
}

