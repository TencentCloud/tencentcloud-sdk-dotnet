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

    public class NextOriginACL : AbstractModel
    {
        
        /// <summary>
        /// 版本号。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 版本生效时间，时间是北京时间 UTC+8， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("PlannedActiveTime")]
        public string PlannedActiveTime{ get; set; }

        /// <summary>
        /// 回源 IP 网段详情。
        /// </summary>
        [JsonProperty("EntireAddresses")]
        public Addresses EntireAddresses{ get; set; }

        /// <summary>
        /// 最新回源 IP 网段相较于 CurrentOrginACL 中回源 IP 网段新增的部分。
        /// </summary>
        [JsonProperty("AddedAddresses")]
        public Addresses AddedAddresses{ get; set; }

        /// <summary>
        /// 最新回源 IP 网段相较于 CurrentOrginACL 中回源 IP 网段删减的部分。
        /// </summary>
        [JsonProperty("RemovedAddresses")]
        public Addresses RemovedAddresses{ get; set; }

        /// <summary>
        /// 最新回源 IP 网段相较于 CurrentOrginACL 中回源 IP 网段无变化的部分。
        /// </summary>
        [JsonProperty("NoChangeAddresses")]
        public Addresses NoChangeAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "PlannedActiveTime", this.PlannedActiveTime);
            this.SetParamObj(map, prefix + "EntireAddresses.", this.EntireAddresses);
            this.SetParamObj(map, prefix + "AddedAddresses.", this.AddedAddresses);
            this.SetParamObj(map, prefix + "RemovedAddresses.", this.RemovedAddresses);
            this.SetParamObj(map, prefix + "NoChangeAddresses.", this.NoChangeAddresses);
        }
    }
}

