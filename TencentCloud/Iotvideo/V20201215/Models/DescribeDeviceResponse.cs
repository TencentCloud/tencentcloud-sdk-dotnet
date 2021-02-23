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

namespace TencentCloud.Iotvideo.V20201215.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceResponse : AbstractModel
    {
        
        /// <summary>
        /// 设备名
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 设备是否在线，0不在线，1在线，2获取失败，3未激活
        /// </summary>
        [JsonProperty("Online")]
        public ulong? Online{ get; set; }

        /// <summary>
        /// 设备最后上线时间
        /// </summary>
        [JsonProperty("LoginTime")]
        public ulong? LoginTime{ get; set; }

        /// <summary>
        /// 设备密钥
        /// </summary>
        [JsonProperty("DevicePsk")]
        public string DevicePsk{ get; set; }

        /// <summary>
        /// 设备启用状态
        /// </summary>
        [JsonProperty("EnableState")]
        public ulong? EnableState{ get; set; }

        /// <summary>
        /// 设备过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Online", this.Online);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "DevicePsk", this.DevicePsk);
            this.SetParamSimple(map, prefix + "EnableState", this.EnableState);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

