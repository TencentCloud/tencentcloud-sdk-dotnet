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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceHAConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 主从同步方式：
        /// <li>Semi-sync：半同步
        /// <li>Async：异步
        /// </summary>
        [JsonProperty("SyncMode")]
        public string SyncMode{ get; set; }

        /// <summary>
        /// 高可用备机最大延迟数据量。备节点延迟数据量小于等于该值，且备节点延迟时间小于等于MaxStandbyLag时，可以切换为主节点。
        /// <li>单位：byte
        /// <li>参数范围：[1073741824, 322122547200]
        /// </summary>
        [JsonProperty("MaxStandbyLatency")]
        public ulong? MaxStandbyLatency{ get; set; }

        /// <summary>
        /// 高可用备机最大延迟时间。备节点延迟时间小于等于该值，且备节点延迟数据量小于等于MaxStandbyLatency时，可以切换为主节点。
        /// <li>单位：s
        /// <li>参数范围：[5, 10]
        /// </summary>
        [JsonProperty("MaxStandbyLag")]
        public ulong? MaxStandbyLag{ get; set; }

        /// <summary>
        /// 同步备机最大延迟数据量。备机延迟数据量小于等于该值，且该备机延迟时间小于等于MaxSyncStandbyLag时，则该备机采用同步复制；否则，采用异步复制。
        /// 该参数值针对SyncMode设置为Semi-sync的实例有效。
        /// 半同步实例禁止退化为异步复制时，不设置MaxSyncStandbyLatency、MaxSyncStandbyLag。
        /// 半同步实例允许退化异步复制时，PostgreSQL 9版本的实例须设置MaxSyncStandbyLatency且不设置MaxSyncStandbyLag，PostgreSQL 10及以上版本的实例须设置MaxSyncStandbyLatency、MaxSyncStandbyLag。
        /// </summary>
        [JsonProperty("MaxSyncStandbyLatency")]
        public ulong? MaxSyncStandbyLatency{ get; set; }

        /// <summary>
        /// 同步备机最大延迟时间。备机延迟时间小于等于该值，且该备机延迟数据量小于等于MaxSyncStandbyLatency时，则该备机采用同步复制；否则，采用异步复制。
        /// 该参数值针对SyncMode设置为Semi-sync的实例有效。
        /// 半同步实例禁止退化为异步复制时，不设置MaxSyncStandbyLatency、MaxSyncStandbyLag。
        /// 半同步实例允许退化异步复制时，PostgreSQL 9版本的实例须设置MaxSyncStandbyLatency且不设置MaxSyncStandbyLag，PostgreSQL 10及以上版本的实例须设置MaxSyncStandbyLatency、MaxSyncStandbyLag，
        /// </summary>
        [JsonProperty("MaxSyncStandbyLag")]
        public ulong? MaxSyncStandbyLag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "MaxStandbyLatency", this.MaxStandbyLatency);
            this.SetParamSimple(map, prefix + "MaxStandbyLag", this.MaxStandbyLag);
            this.SetParamSimple(map, prefix + "MaxSyncStandbyLatency", this.MaxSyncStandbyLatency);
            this.SetParamSimple(map, prefix + "MaxSyncStandbyLag", this.MaxSyncStandbyLag);
        }
    }
}

