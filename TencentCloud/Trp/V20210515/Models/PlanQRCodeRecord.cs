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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PlanQRCodeRecord : AbstractModel
    {
        
        /// <summary>
        /// 二维码
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// OpenID
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 扫码时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// IP 地址
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
        }
    }
}

