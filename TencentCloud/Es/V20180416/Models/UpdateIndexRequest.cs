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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateIndexRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ES集群ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>更新的索引类型。auto：自治索引；normal：普通索引</p>
        /// </summary>
        [JsonProperty("IndexType")]
        public string IndexType{ get; set; }

        /// <summary>
        /// <p>更新的索引名</p>
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// <p>更新的索引元数据JSON，如mappings、settings</p>
        /// </summary>
        [JsonProperty("UpdateMetaJson")]
        public string UpdateMetaJson{ get; set; }

        /// <summary>
        /// <p>集群访问用户名</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>集群访问密码</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>是否滚动后备索引</p>
        /// </summary>
        [JsonProperty("RolloverBackingIndex")]
        public bool? RolloverBackingIndex{ get; set; }

        /// <summary>
        /// <p>是否为取回完全卸载索引</p>
        /// </summary>
        [JsonProperty("MountIndex")]
        public bool? MountIndex{ get; set; }

        /// <summary>
        /// <p>索引Uuid</p>
        /// </summary>
        [JsonProperty("IndexUuid")]
        public string IndexUuid{ get; set; }

        /// <summary>
        /// <p>后备索引名</p>
        /// </summary>
        [JsonProperty("BackingIndexName")]
        public string BackingIndexName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "IndexType", this.IndexType);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "UpdateMetaJson", this.UpdateMetaJson);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "RolloverBackingIndex", this.RolloverBackingIndex);
            this.SetParamSimple(map, prefix + "MountIndex", this.MountIndex);
            this.SetParamSimple(map, prefix + "IndexUuid", this.IndexUuid);
            this.SetParamSimple(map, prefix + "BackingIndexName", this.BackingIndexName);
        }
    }
}

