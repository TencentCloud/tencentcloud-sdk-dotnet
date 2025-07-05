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

    public class RestoreClusterSnapshotRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群实例Id，格式：es-xxxx
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("RepositoryName")]
        public string RepositoryName{ get; set; }

        /// <summary>
        /// 集群快照名称
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 目标集群实例Id，格式：es-xxxx，如果是恢复到本地，则和InstanceId一致
        /// </summary>
        [JsonProperty("TargetInstanceId")]
        public string TargetInstanceId{ get; set; }

        /// <summary>
        /// elastic用户名对应的密码信息
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 要在所有恢复的索引中添加或更改的设置的逗号分隔列表。使用此参数可以在恢复快照时覆盖索引设置。
        /// </summary>
        [JsonProperty("IndexSettings")]
        public string IndexSettings{ get; set; }

        /// <summary>
        /// 不应从快照还原的以逗号分隔的索引设置列表。
        /// </summary>
        [JsonProperty("IncludeGlobalState")]
        public string[] IncludeGlobalState{ get; set; }

        /// <summary>
        /// 需要恢复的索引名称，非必填，为空则表示恢复所有
        /// 
        /// 支持传多个索引名称
        /// </summary>
        [JsonProperty("Indices")]
        public string Indices{ get; set; }

        /// <summary>
        /// 如果为 false，则如果快照中包含的一个或多个索引没有所有主分片可用，则整个恢复操作将失败。默认为 false,
        /// 
        /// 如果为 true，则允许恢复具有不可用分片的索引的部分快照。只有成功包含在快照中的分片才会被恢复。所有丢失的碎片将被重新创建为空
        /// </summary>
        [JsonProperty("Partial")]
        public string Partial{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RepositoryName", this.RepositoryName);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "TargetInstanceId", this.TargetInstanceId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "IndexSettings", this.IndexSettings);
            this.SetParamArraySimple(map, prefix + "IncludeGlobalState.", this.IncludeGlobalState);
            this.SetParamSimple(map, prefix + "Indices", this.Indices);
            this.SetParamSimple(map, prefix + "Partial", this.Partial);
        }
    }
}

