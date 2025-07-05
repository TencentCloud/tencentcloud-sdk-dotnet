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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskDealedTrendItem : AbstractModel
    {
        
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 未解决数量
        /// </summary>
        [JsonProperty("Unhandled")]
        public ulong? Unhandled{ get; set; }

        /// <summary>
        /// 已解决数量
        /// </summary>
        [JsonProperty("Handled")]
        public ulong? Handled{ get; set; }

        /// <summary>
        /// 新发现
        /// </summary>
        [JsonProperty("NewDiscoveryHandled")]
        public ulong? NewDiscoveryHandled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Unhandled", this.Unhandled);
            this.SetParamSimple(map, prefix + "Handled", this.Handled);
            this.SetParamSimple(map, prefix + "NewDiscoveryHandled", this.NewDiscoveryHandled);
        }
    }
}

