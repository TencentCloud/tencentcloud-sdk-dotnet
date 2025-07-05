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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonServiceBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 机房名称
        /// </summary>
        [JsonProperty("IdcName")]
        public string IdcName{ get; set; }

        /// <summary>
        /// 业务联系人
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName{ get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("ContactPhone")]
        public string ContactPhone{ get; set; }

        /// <summary>
        /// 操作说明
        /// </summary>
        [JsonProperty("Instructions")]
        public string Instructions{ get; set; }

        /// <summary>
        /// 1 、2 、3 分别代表 L1、L2、L3
        /// </summary>
        [JsonProperty("ServiceLevel")]
        public ulong? ServiceLevel{ get; set; }

        /// <summary>
        /// 操作预授权
        /// </summary>
        [JsonProperty("PreAuthorization")]
        public bool? PreAuthorization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdcName", this.IdcName);
            this.SetParamSimple(map, prefix + "ContactName", this.ContactName);
            this.SetParamSimple(map, prefix + "ContactPhone", this.ContactPhone);
            this.SetParamSimple(map, prefix + "Instructions", this.Instructions);
            this.SetParamSimple(map, prefix + "ServiceLevel", this.ServiceLevel);
            this.SetParamSimple(map, prefix + "PreAuthorization", this.PreAuthorization);
        }
    }
}

