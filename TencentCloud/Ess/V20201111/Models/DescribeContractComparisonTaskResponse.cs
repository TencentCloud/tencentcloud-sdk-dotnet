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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeContractComparisonTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 合同对比任务ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 合同对比任务状态。
        /// 状态如下：
        /// <ul><li> **0**：待创建（未执行）</li>
        /// <li> **1**：对比中</li>
        /// <li> **2**：对比成功</li>
        /// <li> **3**：对比失败</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 对比失败的具体原因描述，仅当状态为失败时返回此字段。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 原版文件ID，对比基准的旧版本文件唯一标识。
        /// </summary>
        [JsonProperty("OriginalFileResourceId")]
        public string OriginalFileResourceId{ get; set; }

        /// <summary>
        /// 新版文件ID，与旧版进行对比的新版本文件唯一标识。
        /// </summary>
        [JsonProperty("DiffFileResourceId")]
        public string DiffFileResourceId{ get; set; }

        /// <summary>
        /// 对比任务备注，长度不能超过50个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 合同对比差异点总数。
        /// </summary>
        [JsonProperty("TotalDiffCount")]
        public long? TotalDiffCount{ get; set; }

        /// <summary>
        /// 合同对比新增点数量。
        /// </summary>
        [JsonProperty("AddDiffCount")]
        public long? AddDiffCount{ get; set; }

        /// <summary>
        /// 合同对比修改点数量。
        /// </summary>
        [JsonProperty("ChangeDiffCount")]
        public long? ChangeDiffCount{ get; set; }

        /// <summary>
        /// 合同对比删除点数量。
        /// </summary>
        [JsonProperty("DeleteDiffCount")]
        public long? DeleteDiffCount{ get; set; }

        /// <summary>
        /// 提交人，提交此任务或请求的用户唯一标识。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 合同对比任务创建时间，时间戳。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 对比差异详情，请求参数ShowDetail为true时返回。
        /// </summary>
        [JsonProperty("ComparisonDetail")]
        public ComparisonDetail[] ComparisonDetail{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "OriginalFileResourceId", this.OriginalFileResourceId);
            this.SetParamSimple(map, prefix + "DiffFileResourceId", this.DiffFileResourceId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "TotalDiffCount", this.TotalDiffCount);
            this.SetParamSimple(map, prefix + "AddDiffCount", this.AddDiffCount);
            this.SetParamSimple(map, prefix + "ChangeDiffCount", this.ChangeDiffCount);
            this.SetParamSimple(map, prefix + "DeleteDiffCount", this.DeleteDiffCount);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "ComparisonDetail.", this.ComparisonDetail);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

