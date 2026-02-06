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

namespace TencentCloud.Cloudapp.V20220530.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IssueLicenseRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>云应用实例 ID</p>
        /// </summary>
        [JsonProperty("CloudappId")]
        public string CloudappId{ get; set; }

        /// <summary>
        /// <p>云应用颁发的 License 授权 ID。系统中唯一，伙伴可通过 License 颁发的订阅接口中获取</p>
        /// </summary>
        [JsonProperty("LicenseId")]
        public string LicenseId{ get; set; }

        /// <summary>
        /// <p>License 的详细数据</p>
        /// </summary>
        [JsonProperty("LicenseData")]
        public PartnerLicenseData LicenseData{ get; set; }

        /// <summary>
        /// <p>License 的激活模式</p>枚举值：<ul><li> immediate ： 立即激活</li><li> scheduled： 指定时间激活</li></ul>
        /// </summary>
        [JsonProperty("ActivateMode")]
        public string ActivateMode{ get; set; }

        /// <summary>
        /// <p>激活时间，指定时间激活时需要传该字段</p>
        /// </summary>
        [JsonProperty("ActivateAt")]
        public string ActivateAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CloudappId", this.CloudappId);
            this.SetParamSimple(map, prefix + "LicenseId", this.LicenseId);
            this.SetParamObj(map, prefix + "LicenseData.", this.LicenseData);
            this.SetParamSimple(map, prefix + "ActivateMode", this.ActivateMode);
            this.SetParamSimple(map, prefix + "ActivateAt", this.ActivateAt);
        }
    }
}

