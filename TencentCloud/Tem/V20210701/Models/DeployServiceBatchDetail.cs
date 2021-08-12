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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployServiceBatchDetail : AbstractModel
    {
        
        /// <summary>
        /// 旧实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldPodList")]
        public DeployServicePodDetail OldPodList{ get; set; }

        /// <summary>
        /// 新实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewPodList")]
        public DeployServicePodDetail NewPodList{ get; set; }

        /// <summary>
        /// 当前批次状态："WaitForTimeExceed", "WaitForResume", "Deploying", "Finish", "NotStart"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchStatus")]
        public string BatchStatus{ get; set; }

        /// <summary>
        /// 该批次预计旧实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodNum")]
        public long? PodNum{ get; set; }

        /// <summary>
        /// 批次id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchIndex")]
        public long? BatchIndex{ get; set; }

        /// <summary>
        /// 旧实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldPods")]
        public DeployServicePodDetail[] OldPods{ get; set; }

        /// <summary>
        /// 新实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewPods")]
        public DeployServicePodDetail[] NewPods{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "OldPodList.", this.OldPodList);
            this.SetParamObj(map, prefix + "NewPodList.", this.NewPodList);
            this.SetParamSimple(map, prefix + "BatchStatus", this.BatchStatus);
            this.SetParamSimple(map, prefix + "PodNum", this.PodNum);
            this.SetParamSimple(map, prefix + "BatchIndex", this.BatchIndex);
            this.SetParamArrayObj(map, prefix + "OldPods.", this.OldPods);
            this.SetParamArrayObj(map, prefix + "NewPods.", this.NewPods);
        }
    }
}

