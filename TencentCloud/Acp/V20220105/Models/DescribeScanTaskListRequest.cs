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

namespace TencentCloud.Acp.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScanTaskListRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务来源, -1:所有, 0:小程序诊断, 1:预留字段(暂未使用), 2:app诊断(android), 3:app漏洞扫描;
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 应用平台, 0:android, 1:ios, 2:小程序
        /// </summary>
        [JsonProperty("Platform")]
        public long? Platform{ get; set; }

        /// <summary>
        /// 任务状态,可多值查询,例如:"1,2,3" 0:默认值(待检测/待咨询), 1.检测中, 2:待评估, 3:评估中, 4:任务完成/咨询完成, 5:任务失败, 6:咨询中;
        /// </summary>
        [JsonProperty("TaskStatuses")]
        public string TaskStatuses{ get; set; }

        /// <summary>
        /// 任务类型,可多值查询,采用逗号分隔,例如:"0,1" 0:基础版, 1:专家版, 2:本地化
        /// </summary>
        [JsonProperty("TaskTypes")]
        public string TaskTypes{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// 页码大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 应用名称或小程序名称(可选参数)
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 查询时间范围, 查询开始时间(2021-09-30 或 2021-09-30 10:57:34)
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询时间范围, 查询结束时间(2021-09-30 或 2021-09-30 10:57:34)
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "TaskStatuses", this.TaskStatuses);
            this.SetParamSimple(map, prefix + "TaskTypes", this.TaskTypes);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

