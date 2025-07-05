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

namespace TencentCloud.Ims.V20200713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Device : AbstractModel
    {
        
        /// <summary>
        /// 发表消息设备IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Mac地址
        /// </summary>
        [JsonProperty("Mac")]
        public string Mac{ get; set; }

        /// <summary>
        /// 设备指纹Token
        /// </summary>
        [JsonProperty("TokenId")]
        public string TokenId{ get; set; }

        /// <summary>
        /// 设备指纹ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [JsonProperty("IMEI")]
        public string IMEI{ get; set; }

        /// <summary>
        /// IOS设备，Identifier For Advertising（广告标识符）
        /// </summary>
        [JsonProperty("IDFA")]
        public string IDFA{ get; set; }

        /// <summary>
        /// IOS设备，IDFV - Identifier For Vendor（应用开发商标识符）
        /// </summary>
        [JsonProperty("IDFV")]
        public string IDFV{ get; set; }

        /// <summary>
        /// IP地址类型 0 代表ipv4 1 代表ipv6
        /// </summary>
        [JsonProperty("IpType")]
        public ulong? IpType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Mac", this.Mac);
            this.SetParamSimple(map, prefix + "TokenId", this.TokenId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "IMEI", this.IMEI);
            this.SetParamSimple(map, prefix + "IDFA", this.IDFA);
            this.SetParamSimple(map, prefix + "IDFV", this.IDFV);
            this.SetParamSimple(map, prefix + "IpType", this.IpType);
        }
    }
}

