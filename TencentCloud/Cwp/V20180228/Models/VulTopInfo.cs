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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulTopInfo : AbstractModel
    {
        
        /// <summary>
        /// 漏洞 名
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 危害等级：1-低危；2-中危；3-高危；4-严重
        /// </summary>
        [JsonProperty("VulLevel")]
        public ulong? VulLevel{ get; set; }

        /// <summary>
        /// 漏洞数量
        /// </summary>
        [JsonProperty("VulCount")]
        public ulong? VulCount{ get; set; }

        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulLevel", this.VulLevel);
            this.SetParamSimple(map, prefix + "VulCount", this.VulCount);
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
        }
    }
}

