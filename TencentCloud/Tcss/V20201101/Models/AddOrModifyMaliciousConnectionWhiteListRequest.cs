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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddOrModifyMaliciousConnectionWhiteListRequest : AbstractModel
    {
        
        /// <summary>
        /// 枚举
        /// IP: IP
        /// 域名：DOMAIN
        /// </summary>
        [JsonProperty("RequestType")]
        public string RequestType{ get; set; }

        /// <summary>
        /// 白名单域名
        /// </summary>
        [JsonProperty("WhiteDomainList")]
        public string[] WhiteDomainList{ get; set; }

        /// <summary>
        /// 白名单IP
        /// </summary>
        [JsonProperty("WhiteIPList")]
        public string[] WhiteIPList{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 白名单记录id，只有修改时需要
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
            this.SetParamArraySimple(map, prefix + "WhiteDomainList.", this.WhiteDomainList);
            this.SetParamArraySimple(map, prefix + "WhiteIPList.", this.WhiteIPList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ID", this.ID);
        }
    }
}

