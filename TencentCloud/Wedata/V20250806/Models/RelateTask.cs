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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RelateTask : AbstractModel
    {
        
        /// <summary>
        /// 任务类型
        /// 
        /// - OfflineIntegration --- 离线集成任务
        /// - RealtimeIntegration --- 实时集成任务
        /// - DataDevelopment --- 数据开发任务
        /// - DataQuality --- 数据质量任务
        /// - DataService --- 数据服务任务
        /// - MetadataCollection --- 元数据采集任务
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 任务数量
        /// </summary>
        [JsonProperty("TaskNum")]
        public long? TaskNum{ get; set; }

        /// <summary>
        /// 任务详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskList")]
        public BriefTask[] TaskList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskNum", this.TaskNum);
            this.SetParamArrayObj(map, prefix + "TaskList.", this.TaskList);
        }
    }
}

