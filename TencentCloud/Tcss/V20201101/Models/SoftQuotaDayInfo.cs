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

    public class SoftQuotaDayInfo : AbstractModel
    {
        
        /// <summary>
        /// 扣费时间
        /// </summary>
        [JsonProperty("PayTime")]
        public string PayTime{ get; set; }

        /// <summary>
        /// 计费核数(已废弃)
        /// </summary>
        [JsonProperty("CoresCnt")]
        public ulong? CoresCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayTime", this.PayTime);
            this.SetParamSimple(map, prefix + "CoresCnt", this.CoresCnt);
        }
    }
}

