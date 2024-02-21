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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedDomainInfo : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        [JsonProperty("RegTime")]
        public string RegTime{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 续费时间结束
        /// </summary>
        [JsonProperty("RenewEndTime")]
        public string RenewEndTime{ get; set; }

        /// <summary>
        /// 赎回结束时间
        /// </summary>
        [JsonProperty("RestoreEndTime")]
        public string RestoreEndTime{ get; set; }

        /// <summary>
        /// 域名预约结束时间
        /// </summary>
        [JsonProperty("ReservedEndTime")]
        public string ReservedEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "RegTime", this.RegTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "RenewEndTime", this.RenewEndTime);
            this.SetParamSimple(map, prefix + "RestoreEndTime", this.RestoreEndTime);
            this.SetParamSimple(map, prefix + "ReservedEndTime", this.ReservedEndTime);
        }
    }
}

