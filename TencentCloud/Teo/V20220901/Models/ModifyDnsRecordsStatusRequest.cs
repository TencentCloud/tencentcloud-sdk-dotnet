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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDnsRecordsStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 待启用的 DNS 记录 ID 列表，上限：200。<br>注意：同个 DNS 记录 ID 不能同时存在于 RecordsToEnable 和 RecordsToDisable。
        /// </summary>
        [JsonProperty("RecordsToEnable")]
        public string[] RecordsToEnable{ get; set; }

        /// <summary>
        /// 待停用的 DNS 记录 ID 列表，上限：200。<br>注意：同个 DNS 记录 ID 不能同时存在于 RecordsToEnable 和 RecordsToDisable。
        /// </summary>
        [JsonProperty("RecordsToDisable")]
        public string[] RecordsToDisable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "RecordsToEnable.", this.RecordsToEnable);
            this.SetParamArraySimple(map, prefix + "RecordsToDisable.", this.RecordsToDisable);
        }
    }
}

