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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIAgentCredential : AbstractModel
    {
        
        /// <summary>
        /// <p>凭据 ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>凭据名称</p>
        /// </summary>
        [JsonProperty("CredName")]
        public string CredName{ get; set; }

        /// <summary>
        /// <p>凭据类型</p><p>枚举值：</p><ul><li>OAUTH： oauth 类型凭据</li><li>API_TOKEN： token 类型凭据</li><li>CLOUD_AK： aksk 类型凭据</li></ul>
        /// </summary>
        [JsonProperty("CredType")]
        public string CredType{ get; set; }

        /// <summary>
        /// <p>凭据所在位置标识</p>
        /// </summary>
        [JsonProperty("Locations")]
        public AIAgentCredentialLocation[] Locations{ get; set; }

        /// <summary>
        /// <p>最近扫描发现时间</p>
        /// </summary>
        [JsonProperty("DetectTime")]
        public string DetectTime{ get; set; }

        /// <summary>
        /// <p>该凭据的泄露位置总数</p>
        /// </summary>
        [JsonProperty("HitCount")]
        public long? HitCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "CredName", this.CredName);
            this.SetParamSimple(map, prefix + "CredType", this.CredType);
            this.SetParamArrayObj(map, prefix + "Locations.", this.Locations);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
            this.SetParamSimple(map, prefix + "HitCount", this.HitCount);
        }
    }
}

