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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PhoneVerificationCUCCRequest : AbstractModel
    {
        
        /// <summary>
        /// 身份证号。
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 姓名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 手机号。
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 敏感数据加密信息。
        /// - 对传入信息（姓名、身份证号、手机号）有加密需求的用户可使用此参数，详情请点击左侧链接。
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
        }
    }
}

