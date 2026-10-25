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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FeatureTableDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>特征表主键字段列表</p>
        /// </summary>
        [JsonProperty("PrimaryKeys")]
        public string[] PrimaryKeys{ get; set; }

        /// <summary>
        /// <p>特征表时间戳字段名称</p>
        /// </summary>
        [JsonProperty("TimestampField")]
        public string TimestampField{ get; set; }

        /// <summary>
        /// <p>在线特征表对应的来源表名称（离线表）</p>
        /// </summary>
        [JsonProperty("SourceTableName")]
        public string SourceTableName{ get; set; }

        /// <summary>
        /// <p>在线特征表关联的工作流ID</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>离线特征表对应生成的在线特征表名称</p>
        /// </summary>
        [JsonProperty("OnlineTableName")]
        public string OnlineTableName{ get; set; }

        /// <summary>
        /// <p>离线特征表对应生成的在线特征表类型，取值：TENCENT_POSTGRESQL | REDIS），缺省 TENCENT_POSTGRESQL</p>
        /// </summary>
        [JsonProperty("OnlineTableType")]
        public string OnlineTableType{ get; set; }

        /// <summary>
        /// <p>离线特征表对应生成的在线特征表ConnectionId</p>
        /// </summary>
        [JsonProperty("ConnectionId")]
        public string ConnectionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PrimaryKeys.", this.PrimaryKeys);
            this.SetParamSimple(map, prefix + "TimestampField", this.TimestampField);
            this.SetParamSimple(map, prefix + "SourceTableName", this.SourceTableName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "OnlineTableName", this.OnlineTableName);
            this.SetParamSimple(map, prefix + "OnlineTableType", this.OnlineTableType);
            this.SetParamSimple(map, prefix + "ConnectionId", this.ConnectionId);
        }
    }
}

