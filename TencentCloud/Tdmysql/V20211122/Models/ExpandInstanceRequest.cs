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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExpandInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>存储节点扩容至多少个节点，如果没有变化，传当前节点数</p>
        /// </summary>
        [JsonProperty("StorageNodeNum")]
        public long? StorageNodeNum{ get; set; }

        /// <summary>
        /// <p>可用区列表</p>
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>az模式，1: 单AZ 2: 多AZ非主AZ模式 3: 多AZ主AZ模式</p>
        /// </summary>
        [JsonProperty("AZMode")]
        public long? AZMode{ get; set; }

        /// <summary>
        /// <p>AZMode传3时，表示主AZ</p>
        /// </summary>
        [JsonProperty("PrimaryAZ")]
        public string PrimaryAZ{ get; set; }

        /// <summary>
        /// <p>全能型副本数，取值范围包括1-3</p>
        /// </summary>
        [JsonProperty("FullReplications")]
        public long? FullReplications{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StorageNodeNum", this.StorageNodeNum);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "AZMode", this.AZMode);
            this.SetParamSimple(map, prefix + "PrimaryAZ", this.PrimaryAZ);
            this.SetParamSimple(map, prefix + "FullReplications", this.FullReplications);
        }
    }
}

