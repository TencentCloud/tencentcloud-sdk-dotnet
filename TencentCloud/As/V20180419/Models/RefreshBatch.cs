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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefreshBatch : AbstractModel
    {
        
        /// <summary>
        /// 刷新批次序号。例如，2 表示当前批次实例会在第二批次进行实例刷新。
        /// </summary>
        [JsonProperty("RefreshBatchNum")]
        public ulong? RefreshBatchNum{ get; set; }

        /// <summary>
        /// 刷新批次状态。取值如下：<li>WAITING：待刷新</li><li>INIT：初始化中</li><li>RUNNING：刷新中</li><li>FAILED:  刷新失败</li><li>PARTIALLY_SUCCESSFUL：批次部分成功</li><li>CANCELLED：已取消</li><li>SUCCESSFUL：刷新成功</li>
        /// </summary>
        [JsonProperty("RefreshBatchStatus")]
        public string RefreshBatchStatus{ get; set; }

        /// <summary>
        /// 刷新批次关联实例列表。
        /// </summary>
        [JsonProperty("RefreshBatchRelatedInstanceSet")]
        public RefreshBatchRelatedInstance[] RefreshBatchRelatedInstanceSet{ get; set; }

        /// <summary>
        /// 刷新批次开始时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 刷新批次结束时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RefreshBatchNum", this.RefreshBatchNum);
            this.SetParamSimple(map, prefix + "RefreshBatchStatus", this.RefreshBatchStatus);
            this.SetParamArrayObj(map, prefix + "RefreshBatchRelatedInstanceSet.", this.RefreshBatchRelatedInstanceSet);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

