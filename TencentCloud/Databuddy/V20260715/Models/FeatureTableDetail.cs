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
        /// 特征表主键字段列表
        /// </summary>
        [JsonProperty("PrimaryKeys")]
        public string[] PrimaryKeys{ get; set; }

        /// <summary>
        /// 特征表时间戳字段名称
        /// </summary>
        [JsonProperty("TimestampField")]
        public string TimestampField{ get; set; }

        /// <summary>
        /// 在线特征表对应的来源表名称（离线表）
        /// </summary>
        [JsonProperty("SourceTableName")]
        public string SourceTableName{ get; set; }

        /// <summary>
        /// 在线特征表关联的工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 离线特征表对应生成的在线特征表名称
        /// </summary>
        [JsonProperty("OnlineTableName")]
        public string OnlineTableName{ get; set; }


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
        }
    }
}

