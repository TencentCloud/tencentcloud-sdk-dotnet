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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务 ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务状态。可能取值：
        /// 
        /// - `1`：失败
        /// - `2`：空结果
        /// - `3`：有效结果
        /// - `4`：处理中
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 任务元数据
        /// </summary>
        [JsonProperty("Metadata")]
        public SeeTaskMetadata Metadata{ get; set; }

        /// <summary>
        /// 算法类目。可能取值：
        /// 
        /// - `COMPREHENSION`：视觉理解
        /// - `HIGHLIGHT`：视频浓缩
        /// </summary>
        [JsonProperty("ServiceCategory")]
        public string ServiceCategory{ get; set; }

        /// <summary>
        /// 算法类型。可能取值：
        /// 
        /// - `VID_COMP`：视频理解
        /// - `IMG_COMP`：图片理解
        /// - `COMP_HIGHLIGHT`：视频浓缩
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 套餐规格。可能取值：
        /// 
        /// - `POSTPAID`：后付费（适用于视频理解、图片理解）
        /// - `BASIC`：包年包月基础版（适用于视频理解）
        /// </summary>
        [JsonProperty("ServiceTier")]
        public string ServiceTier{ get; set; }

        /// <summary>
        /// 视觉理解结果（适用于视频理解、图片理解）
        /// </summary>
        [JsonProperty("ComprehensionResult")]
        public SeeComprehensionResult ComprehensionResult{ get; set; }

        /// <summary>
        /// 视频语义浓缩结果（适用于视频语义浓缩）
        /// </summary>
        [JsonProperty("CompHighlightResult")]
        public SeeCompHighlightResult CompHighlightResult{ get; set; }

        /// <summary>
        /// 标签持续检测结果
        /// </summary>
        [JsonProperty("DetectContinuousResult")]
        public SeeDetectContinuousResult DetectContinuousResult{ get; set; }

        /// <summary>
        /// 完成该任务所消耗的基础能力额度
        /// </summary>
        [JsonProperty("CostBasic")]
        public long? CostBasic{ get; set; }

        /// <summary>
        /// 完成该任务所消耗的高级能力额度
        /// </summary>
        [JsonProperty("CostAdvanced")]
        public long? CostAdvanced{ get; set; }

        /// <summary>
        /// 输出文件名列表
        /// </summary>
        [JsonProperty("Files")]
        public string[] Files{ get; set; }

        /// <summary>
        /// 输出文件详情列表
        /// </summary>
        [JsonProperty("FilesInfo")]
        public CloudStorageAIServiceTaskFileInfo[] FilesInfo{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamSimple(map, prefix + "ServiceCategory", this.ServiceCategory);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ServiceTier", this.ServiceTier);
            this.SetParamObj(map, prefix + "ComprehensionResult.", this.ComprehensionResult);
            this.SetParamObj(map, prefix + "CompHighlightResult.", this.CompHighlightResult);
            this.SetParamObj(map, prefix + "DetectContinuousResult.", this.DetectContinuousResult);
            this.SetParamSimple(map, prefix + "CostBasic", this.CostBasic);
            this.SetParamSimple(map, prefix + "CostAdvanced", this.CostAdvanced);
            this.SetParamArraySimple(map, prefix + "Files.", this.Files);
            this.SetParamArrayObj(map, prefix + "FilesInfo.", this.FilesInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

