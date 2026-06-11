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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewStats : AbstractModel
    {
        
        /// <summary>
        /// 应用节点状态
        /// </summary>
        [JsonProperty("ServiceStats")]
        public TopologyNodeStats ServiceStats{ get; set; }

        /// <summary>
        /// 数据库节点状态
        /// </summary>
        [JsonProperty("DatabaseStats")]
        public TopologyNodeStats DatabaseStats{ get; set; }

        /// <summary>
        /// 消息队列节点状态
        /// </summary>
        [JsonProperty("MQStats")]
        public TopologyNodeStats MQStats{ get; set; }

        /// <summary>
        /// 节点总数
        /// </summary>
        [JsonProperty("TotalNodes")]
        public long? TotalNodes{ get; set; }

        /// <summary>
        /// 健康节点总数
        /// </summary>
        [JsonProperty("HealthyNodes")]
        public long? HealthyNodes{ get; set; }

        /// <summary>
        /// 警告节点总数
        /// </summary>
        [JsonProperty("WarningNodes")]
        public long? WarningNodes{ get; set; }

        /// <summary>
        /// 错误节点总数
        /// </summary>
        [JsonProperty("ErrorNodes")]
        public long? ErrorNodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ServiceStats.", this.ServiceStats);
            this.SetParamObj(map, prefix + "DatabaseStats.", this.DatabaseStats);
            this.SetParamObj(map, prefix + "MQStats.", this.MQStats);
            this.SetParamSimple(map, prefix + "TotalNodes", this.TotalNodes);
            this.SetParamSimple(map, prefix + "HealthyNodes", this.HealthyNodes);
            this.SetParamSimple(map, prefix + "WarningNodes", this.WarningNodes);
            this.SetParamSimple(map, prefix + "ErrorNodes", this.ErrorNodes);
        }
    }
}

