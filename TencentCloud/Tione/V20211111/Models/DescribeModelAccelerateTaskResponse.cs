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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModelAccelerateTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 模型加速任务详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelAccelerateTask")]
        public ModelAccelerateTask ModelAccelerateTask{ get; set; }

        /// <summary>
        /// 模型加速时长，单位s
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelAccRuntimeInSecond")]
        public ulong? ModelAccRuntimeInSecond{ get; set; }

        /// <summary>
        /// 模型加速任务开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelAccStartTime")]
        public string ModelAccStartTime{ get; set; }

        /// <summary>
        /// 模型加速任务结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelAccEndTime")]
        public string ModelAccEndTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ModelAccelerateTask.", this.ModelAccelerateTask);
            this.SetParamSimple(map, prefix + "ModelAccRuntimeInSecond", this.ModelAccRuntimeInSecond);
            this.SetParamSimple(map, prefix + "ModelAccStartTime", this.ModelAccStartTime);
            this.SetParamSimple(map, prefix + "ModelAccEndTime", this.ModelAccEndTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

