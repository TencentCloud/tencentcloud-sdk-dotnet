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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DistributeAccreditTlinxRequest : AbstractModel
    {
        
        /// <summary>
        /// 使用门店OpenId
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 使用门店OpenKey
        /// </summary>
        [JsonProperty("OpenKey")]
        public string OpenKey{ get; set; }

        /// <summary>
        /// 验证方式，传1手机验证(验证码时效60S)传2结算卡验证(时效6小时)，多种方式用逗号隔开
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// 分账比例（500=5%）不传默认百分之10
        /// </summary>
        [JsonProperty("Percent")]
        public string Percent{ get; set; }

        /// <summary>
        /// 营业执照商户全称
        /// </summary>
        [JsonProperty("FullName")]
        public string FullName{ get; set; }

        /// <summary>
        /// 沙箱环境填sandbox，正式环境不填
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "OpenKey", this.OpenKey);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "FullName", this.FullName);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

