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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SSLConfig : AbstractModel
    {
        
        /// <summary>
        /// SSL加密状态，
        /// enable-已开启
        /// disable-未开启
        /// enable_doing-开启中
        /// disable_doing-关闭中
        /// renew_doing-更新中
        /// wait_doing-等待维护时间内执行
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }

        /// <summary>
        /// SSL证书有效期，时间格式 YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("SSLValidityPeriod")]
        public string SSLValidityPeriod{ get; set; }

        /// <summary>
        /// SSL证书有效性，0-无效，1-有效
        /// </summary>
        [JsonProperty("SSLValidity")]
        public ulong? SSLValidity{ get; set; }

        /// <summary>
        /// 是否是KMS的CMK证书
        /// </summary>
        [JsonProperty("IsKMS")]
        public long? IsKMS{ get; set; }

        /// <summary>
        /// KMS中购买的用户主密钥ID（CMK）
        /// </summary>
        [JsonProperty("CMKId")]
        public string CMKId{ get; set; }

        /// <summary>
        /// CMK所属的地域，不同地域的CMK数据不互通
        /// </summary>
        [JsonProperty("CMKRegion")]
        public string CMKRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "SSLValidityPeriod", this.SSLValidityPeriod);
            this.SetParamSimple(map, prefix + "SSLValidity", this.SSLValidity);
            this.SetParamSimple(map, prefix + "IsKMS", this.IsKMS);
            this.SetParamSimple(map, prefix + "CMKId", this.CMKId);
            this.SetParamSimple(map, prefix + "CMKRegion", this.CMKRegion);
        }
    }
}

