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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStructCompareDataResponse : AbstractModel
    {
        
        /// <summary>
        /// 保单号
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 主任务号
        /// </summary>
        [JsonProperty("MainTaskId")]
        public string MainTaskId{ get; set; }

        /// <summary>
        /// 客户号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomerId")]
        public string CustomerId{ get; set; }

        /// <summary>
        /// 客户姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// 复核时间
        /// </summary>
        [JsonProperty("ReviewTime")]
        public string ReviewTime{ get; set; }

        /// <summary>
        /// 算法识别结果
        /// </summary>
        [JsonProperty("MachineResult")]
        public string MachineResult{ get; set; }

        /// <summary>
        /// 人工复核结果
        /// </summary>
        [JsonProperty("ManualResult")]
        public string ManualResult{ get; set; }

        /// <summary>
        /// 结构化对比指标数据
        /// </summary>
        [JsonProperty("Metrics")]
        public CompareMetricsData Metrics{ get; set; }

        /// <summary>
        /// 新增项
        /// </summary>
        [JsonProperty("NewItems")]
        public string NewItems{ get; set; }

        /// <summary>
        /// 修改项
        /// </summary>
        [JsonProperty("ModifyItems")]
        public string ModifyItems{ get; set; }

        /// <summary>
        /// 子任务号
        /// </summary>
        [JsonProperty("SubTaskId")]
        public string SubTaskId{ get; set; }

        /// <summary>
        /// 所有的子任务
        /// </summary>
        [JsonProperty("AllTasks")]
        public ReviewDataTaskInfo[] AllTasks{ get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

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
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "MainTaskId", this.MainTaskId);
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "ReviewTime", this.ReviewTime);
            this.SetParamSimple(map, prefix + "MachineResult", this.MachineResult);
            this.SetParamSimple(map, prefix + "ManualResult", this.ManualResult);
            this.SetParamObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "NewItems", this.NewItems);
            this.SetParamSimple(map, prefix + "ModifyItems", this.ModifyItems);
            this.SetParamSimple(map, prefix + "SubTaskId", this.SubTaskId);
            this.SetParamArrayObj(map, prefix + "AllTasks.", this.AllTasks);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

