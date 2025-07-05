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

namespace TencentCloud.Pds.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserInfos : AbstractModel
    {
        
        /// <summary>
        /// 用户的手机号
        /// </summary>
        [JsonProperty("PhoneNum")]
        public string PhoneNum{ get; set; }

        /// <summary>
        /// 用户的微信OpenID
        /// </summary>
        [JsonProperty("Openid")]
        public string Openid{ get; set; }

        /// <summary>
        /// 用户移动设备的客户端IP
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 用户WiFi的BSSID
        /// </summary>
        [JsonProperty("WiFiBssid")]
        public string WiFiBssid{ get; set; }

        /// <summary>
        /// 用户Android设备的IMEI
        /// </summary>
        [JsonProperty("IMEI")]
        public string IMEI{ get; set; }

        /// <summary>
        /// 用户Android设备的OAID
        /// </summary>
        [JsonProperty("OAID")]
        public string OAID{ get; set; }

        /// <summary>
        /// 用户iOS设备的IDFA
        /// </summary>
        [JsonProperty("IDFA")]
        public string IDFA{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
            this.SetParamSimple(map, prefix + "Openid", this.Openid);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "WiFiBssid", this.WiFiBssid);
            this.SetParamSimple(map, prefix + "IMEI", this.IMEI);
            this.SetParamSimple(map, prefix + "OAID", this.OAID);
            this.SetParamSimple(map, prefix + "IDFA", this.IDFA);
        }
    }
}

