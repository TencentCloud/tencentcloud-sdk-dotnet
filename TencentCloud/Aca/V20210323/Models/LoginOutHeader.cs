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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginOutHeader : AbstractModel
    {
        
        /// <summary>
        /// 合作方ID
        /// </summary>
        [JsonProperty("PartnerId")]
        public string PartnerId{ get; set; }

        /// <summary>
        /// 时间戳毫秒数
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 签名值
        /// </summary>
        [JsonProperty("Signature")]
        public string Signature{ get; set; }

        /// <summary>
        /// 医院ID 单院版传这个
        /// </summary>
        [JsonProperty("HospitalId")]
        public string HospitalId{ get; set; }

        /// <summary>
        /// 平台ID 平台版传这个
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartnerId", this.PartnerId);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Signature", this.Signature);
            this.SetParamSimple(map, prefix + "HospitalId", this.HospitalId);
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
        }
    }
}

