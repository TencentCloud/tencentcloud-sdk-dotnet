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

namespace TencentCloud.Cws.V20180312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SitesVerification : AbstractModel
    {
        
        /// <summary>
        /// 根域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// txt解析域名验证的name。
        /// </summary>
        [JsonProperty("TxtName")]
        public string TxtName{ get; set; }

        /// <summary>
        /// txt解析域名验证的text。
        /// </summary>
        [JsonProperty("TxtText")]
        public string TxtText{ get; set; }

        /// <summary>
        /// 验证有效期，在此之前有效。
        /// </summary>
        [JsonProperty("ValidTo")]
        public string ValidTo{ get; set; }

        /// <summary>
        /// 验证状态：0-未验证；1-已验证；2-验证失效，待重新验证。
        /// </summary>
        [JsonProperty("VerifyStatus")]
        public ulong? VerifyStatus{ get; set; }

        /// <summary>
        /// CreatedAt。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// UpdatedAt。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// ID。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 云用户appid
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// 用于验证站点的url，即访问该url获取验证数据。
        /// </summary>
        [JsonProperty("VerifyUrl")]
        public string VerifyUrl{ get; set; }

        /// <summary>
        /// 获取验证验证文件的url。
        /// </summary>
        [JsonProperty("VerifyFileUrl")]
        public string VerifyFileUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "TxtName", this.TxtName);
            this.SetParamSimple(map, prefix + "TxtText", this.TxtText);
            this.SetParamSimple(map, prefix + "ValidTo", this.ValidTo);
            this.SetParamSimple(map, prefix + "VerifyStatus", this.VerifyStatus);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "VerifyUrl", this.VerifyUrl);
            this.SetParamSimple(map, prefix + "VerifyFileUrl", this.VerifyFileUrl);
        }
    }
}

