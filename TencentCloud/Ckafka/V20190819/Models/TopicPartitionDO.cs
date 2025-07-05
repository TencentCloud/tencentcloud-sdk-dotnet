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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicPartitionDO : AbstractModel
    {
        
        /// <summary>
        /// Partition 分区ID
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }

        /// <summary>
        /// Leader 运行状态
        /// </summary>
        [JsonProperty("LeaderStatus")]
        public long? LeaderStatus{ get; set; }

        /// <summary>
        /// ISR 个数
        /// </summary>
        [JsonProperty("IsrNum")]
        public long? IsrNum{ get; set; }

        /// <summary>
        /// 副本个数
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public long? ReplicaNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamSimple(map, prefix + "LeaderStatus", this.LeaderStatus);
            this.SetParamSimple(map, prefix + "IsrNum", this.IsrNum);
            this.SetParamSimple(map, prefix + "ReplicaNum", this.ReplicaNum);
        }
    }
}

