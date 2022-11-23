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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DCNReplicaConfig : AbstractModel
    {
        
        /// <summary>
        /// DCN 运行状态，START为正常运行，STOP为暂停
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoReplicationMode")]
        public string RoReplicationMode{ get; set; }

        /// <summary>
        /// 延迟复制的类型，DEFAULT为正常，DUE_TIME为指定时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayReplicationType")]
        public string DelayReplicationType{ get; set; }

        /// <summary>
        /// 延迟复制的指定时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DueTime")]
        public string DueTime{ get; set; }

        /// <summary>
        /// 延迟复制时的延迟秒数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicationDelay")]
        public long? ReplicationDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoReplicationMode", this.RoReplicationMode);
            this.SetParamSimple(map, prefix + "DelayReplicationType", this.DelayReplicationType);
            this.SetParamSimple(map, prefix + "DueTime", this.DueTime);
            this.SetParamSimple(map, prefix + "ReplicationDelay", this.ReplicationDelay);
        }
    }
}

