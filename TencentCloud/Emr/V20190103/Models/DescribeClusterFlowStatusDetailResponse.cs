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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterFlowStatusDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务步骤详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StageDetails")]
        public StageInfoDetail[] StageDetails{ get; set; }

        /// <summary>
        /// 任务参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowDesc")]
        public FlowParamsDesc[] FlowDesc{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 总任务流程进度：
        /// 例如：0.8
        /// </summary>
        [JsonProperty("FlowTotalProgress")]
        public float? FlowTotalProgress{ get; set; }

        /// <summary>
        /// 定义流程总状态：
        /// 0:初始化，
        /// 1:运行中，
        /// 2:完成，
        /// 3:完成（存在跳过步骤），
        /// -1:失败，
        /// -3:阻塞，
        /// </summary>
        [JsonProperty("FlowTotalStatus")]
        public long? FlowTotalStatus{ get; set; }

        /// <summary>
        /// 流程额外信息
        /// NeedExtraDetail为true时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowExtraDetail")]
        public FlowExtraDetail[] FlowExtraDetail{ get; set; }

        /// <summary>
        /// 流程描述
        /// </summary>
        [JsonProperty("FlowInfo")]
        public string FlowInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "StageDetails.", this.StageDetails);
            this.SetParamArrayObj(map, prefix + "FlowDesc.", this.FlowDesc);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "FlowTotalProgress", this.FlowTotalProgress);
            this.SetParamSimple(map, prefix + "FlowTotalStatus", this.FlowTotalStatus);
            this.SetParamArrayObj(map, prefix + "FlowExtraDetail.", this.FlowExtraDetail);
            this.SetParamSimple(map, prefix + "FlowInfo", this.FlowInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

