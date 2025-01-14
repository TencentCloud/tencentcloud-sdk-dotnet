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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CoolDownBackend : AbstractModel
    {
        
        /// <summary>
        /// 字段：Host
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 字段：DataUsedCapacity
        /// </summary>
        [JsonProperty("DataUsedCapacity")]
        public string DataUsedCapacity{ get; set; }

        /// <summary>
        /// 字段：TotalCapacity
        /// </summary>
        [JsonProperty("TotalCapacity")]
        public string TotalCapacity{ get; set; }

        /// <summary>
        /// 字段：RemoteUsedCapacity
        /// </summary>
        [JsonProperty("RemoteUsedCapacity")]
        public string RemoteUsedCapacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "DataUsedCapacity", this.DataUsedCapacity);
            this.SetParamSimple(map, prefix + "TotalCapacity", this.TotalCapacity);
            this.SetParamSimple(map, prefix + "RemoteUsedCapacity", this.RemoteUsedCapacity);
        }
    }
}

