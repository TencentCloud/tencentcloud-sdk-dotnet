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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IssueInfo : AbstractModel
    {
        
        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("CertNumber")]
        public string CertNumber{ get; set; }

        /// <summary>
        /// 签发机构
        /// </summary>
        [JsonProperty("IssuedAuthority")]
        public string IssuedAuthority{ get; set; }

        /// <summary>
        /// 签发日期
        /// </summary>
        [JsonProperty("IssuedDate")]
        public string IssuedDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertNumber", this.CertNumber);
            this.SetParamSimple(map, prefix + "IssuedAuthority", this.IssuedAuthority);
            this.SetParamSimple(map, prefix + "IssuedDate", this.IssuedDate);
        }
    }
}

