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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulFixTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 修复任务主键ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// 修复状态
        /// 枚举值：
        /// 0：初始化
        /// 1：修复中
        /// 2：修复成功
        /// 3：部分修复失败
        /// 4：全部修复失败
        /// 5：停止修复
        /// </summary>
        [JsonProperty("FixStatus")]
        public long? FixStatus{ get; set; }

        /// <summary>
        /// 修复资产总数
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// 修复成功数
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// 修复失败数
        /// </summary>
        [JsonProperty("FailCount")]
        public long? FailCount{ get; set; }

        /// <summary>
        /// 修复中数量
        /// </summary>
        [JsonProperty("FixingCount")]
        public long? FixingCount{ get; set; }

        /// <summary>
        /// 排队中数量（等待下发或等待快照创建）
        /// </summary>
        [JsonProperty("QueueCount")]
        public long? QueueCount{ get; set; }

        /// <summary>
        /// 修复进度百分比
        /// 取值范围：[0, 100]
        /// 补充说明：计算方式为(SuccessCount+FailCount)/AssetCount×100
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 修复成功的漏洞数
        /// </summary>
        [JsonProperty("SuccessVulCount")]
        public long? SuccessVulCount{ get; set; }

        /// <summary>
        /// 修复失败的漏洞数
        /// </summary>
        [JsonProperty("FailVulCount")]
        public long? FailVulCount{ get; set; }

        /// <summary>
        /// 修复的漏洞名称列表
        /// </summary>
        [JsonProperty("VulNames")]
        public string[] VulNames{ get; set; }

        /// <summary>
        /// 修复启动时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 修复结束时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 漏洞维度修复状态列表，每个漏洞的修复状态详情
        /// </summary>
        [JsonProperty("VulFixStatusList")]
        public VulFixStatusItem[] VulFixStatusList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailCount", this.FailCount);
            this.SetParamSimple(map, prefix + "FixingCount", this.FixingCount);
            this.SetParamSimple(map, prefix + "QueueCount", this.QueueCount);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "SuccessVulCount", this.SuccessVulCount);
            this.SetParamSimple(map, prefix + "FailVulCount", this.FailVulCount);
            this.SetParamArraySimple(map, prefix + "VulNames.", this.VulNames);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "VulFixStatusList.", this.VulFixStatusList);
        }
    }
}

