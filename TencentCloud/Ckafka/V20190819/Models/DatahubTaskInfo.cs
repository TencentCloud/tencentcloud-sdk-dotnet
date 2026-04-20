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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DatahubTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>任务Id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务类型，SOURCE数据接入，SINK数据流出</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>状态，-1创建失败，0创建中，1运行中，2删除中，3已删除，4删除失败，5暂停中，6已暂停，7暂停失败，8恢复中，9恢复失败</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>数据源</p>
        /// </summary>
        [JsonProperty("SourceResource")]
        public DatahubResource SourceResource{ get; set; }

        /// <summary>
        /// <p>数据目标</p>
        /// </summary>
        [JsonProperty("TargetResource")]
        public DatahubResource TargetResource{ get; set; }

        /// <summary>
        /// <p>任务创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>异常信息</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>创建进度百分比</p>
        /// </summary>
        [JsonProperty("TaskProgress")]
        public float? TaskProgress{ get; set; }

        /// <summary>
        /// <p>任务当前处于的步骤</p>
        /// </summary>
        [JsonProperty("TaskCurrentStep")]
        public string TaskCurrentStep{ get; set; }

        /// <summary>
        /// <p>Datahub转储Id</p>
        /// </summary>
        [JsonProperty("DatahubId")]
        public string DatahubId{ get; set; }

        /// <summary>
        /// <p>步骤列表</p>
        /// </summary>
        [JsonProperty("StepList")]
        public string[] StepList{ get; set; }

        /// <summary>
        /// <p>任务描述信息</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>任务并发数</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("TaskMax")]
        public long? TaskMax{ get; set; }

        /// <summary>
        /// <p>任务同步限流值,单位MB/s</p><p>默认值：20MB/s</p>
        /// </summary>
        [JsonProperty("SyncThrottleLimit")]
        public long? SyncThrottleLimit{ get; set; }

        /// <summary>
        /// <p>任务是否自动扩容标识</p><p>枚举值：</p><ul><li>true： 自动扩容</li><li>false： 手动扩容</li></ul><p>默认值：true</p>
        /// </summary>
        [JsonProperty("AutoExpandFlag")]
        public bool? AutoExpandFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "SourceResource.", this.SourceResource);
            this.SetParamObj(map, prefix + "TargetResource.", this.TargetResource);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "TaskProgress", this.TaskProgress);
            this.SetParamSimple(map, prefix + "TaskCurrentStep", this.TaskCurrentStep);
            this.SetParamSimple(map, prefix + "DatahubId", this.DatahubId);
            this.SetParamArraySimple(map, prefix + "StepList.", this.StepList);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TaskMax", this.TaskMax);
            this.SetParamSimple(map, prefix + "SyncThrottleLimit", this.SyncThrottleLimit);
            this.SetParamSimple(map, prefix + "AutoExpandFlag", this.AutoExpandFlag);
        }
    }
}

