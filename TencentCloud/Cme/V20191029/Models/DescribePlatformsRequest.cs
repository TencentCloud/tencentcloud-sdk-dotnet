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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePlatformsRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id 列表。如果不填，则不按平台 Id 进行过滤。
        /// </summary>
        [JsonProperty("Platforms")]
        public string[] Platforms{ get; set; }

        /// <summary>
        /// 平台绑定的 License Id 列表。如果不填，则不按平台绑定的 License Id 进行过滤。
        /// </summary>
        [JsonProperty("LicenseIds")]
        public string[] LicenseIds{ get; set; }

        /// <summary>
        /// 分页返回的起始偏移量，默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页返回的记录条数，默认值：10，最大值：20。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Platforms.", this.Platforms);
            this.SetParamArraySimple(map, prefix + "LicenseIds.", this.LicenseIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

