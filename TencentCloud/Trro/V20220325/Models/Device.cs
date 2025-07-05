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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Device : AbstractModel
    {
        
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 已经绑定license数量
        /// </summary>
        [JsonProperty("LicenseCount")]
        public long? LicenseCount{ get; set; }

        /// <summary>
        /// 剩余天数：天
        /// </summary>
        [JsonProperty("RemainDay")]
        public long? RemainDay{ get; set; }

        /// <summary>
        /// 过期时间：s
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 服务时长：s
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// 已经绑定licenseId列表
        /// </summary>
        [JsonProperty("LicenseIds")]
        public string[] LicenseIds{ get; set; }

        /// <summary>
        /// 每月license的限定时长
        /// </summary>
        [JsonProperty("MonthlyRemainTime")]
        public long? MonthlyRemainTime{ get; set; }

        /// <summary>
        /// 月封顶时长（分钟)
        /// </summary>
        [JsonProperty("LimitedTime")]
        public long? LimitedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "LicenseCount", this.LicenseCount);
            this.SetParamSimple(map, prefix + "RemainDay", this.RemainDay);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArraySimple(map, prefix + "LicenseIds.", this.LicenseIds);
            this.SetParamSimple(map, prefix + "MonthlyRemainTime", this.MonthlyRemainTime);
            this.SetParamSimple(map, prefix + "LimitedTime", this.LimitedTime);
        }
    }
}

