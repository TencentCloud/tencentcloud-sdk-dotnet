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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplicationObject : AbstractModel
    {
        
        /// <summary>
        /// 源端实例类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcInstanceType")]
        public string SrcInstanceType{ get; set; }

        /// <summary>
        /// 源端集群Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcClusterId")]
        public string SrcClusterId{ get; set; }

        /// <summary>
        /// 源端实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// 复制任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicationJobId")]
        public string ReplicationJobId{ get; set; }

        /// <summary>
        /// 同步对象详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MigrateObjects")]
        public MigrateOpt MigrateObjects{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceType", this.SrcInstanceType);
            this.SetParamSimple(map, prefix + "SrcClusterId", this.SrcClusterId);
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "ReplicationJobId", this.ReplicationJobId);
            this.SetParamObj(map, prefix + "MigrateObjects.", this.MigrateObjects);
        }
    }
}

