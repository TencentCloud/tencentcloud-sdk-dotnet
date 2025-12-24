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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MakePlanTaskOpsDto : AbstractModel
    {
        
        /// <summary>
        /// 任务基本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskBaseInfo")]
        public TaskOpsDto TaskBaseInfo{ get; set; }

        /// <summary>
        /// 补录该任务当前已生成的实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// 补录任务实例完成百分数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompletePercent")]
        public long? CompletePercent{ get; set; }

        /// <summary>
        /// 补录任务实例成功百分数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessPercent")]
        public long? SuccessPercent{ get; set; }

        /// <summary>
        /// 预计生成的总实例个数，由于是异步生成，-1代表实例还未完全生成
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceTotalCount")]
        public long? InstanceTotalCount{ get; set; }

        /// <summary>
        /// 补录任务实例失败百分数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailurePercent")]
        public long? FailurePercent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TaskBaseInfo.", this.TaskBaseInfo);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "CompletePercent", this.CompletePercent);
            this.SetParamSimple(map, prefix + "SuccessPercent", this.SuccessPercent);
            this.SetParamSimple(map, prefix + "InstanceTotalCount", this.InstanceTotalCount);
            this.SetParamSimple(map, prefix + "FailurePercent", this.FailurePercent);
        }
    }
}

