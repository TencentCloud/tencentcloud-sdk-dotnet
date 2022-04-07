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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataTransformTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据加工任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数据加工任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务启用状态，默认为1，正常开启,  2关闭
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// 加工任务类型，1： DSL， 2：SQL
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 源日志主题
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// 当前加工任务状态（1准备中/2运行中/3停止中/4已停止）
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 加工任务创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 最后启用时间，如果需要重建集群，修改该时间
        /// </summary>
        [JsonProperty("LastEnableTime")]
        public string LastEnableTime{ get; set; }

        /// <summary>
        /// 日志主题名称
        /// </summary>
        [JsonProperty("SrcTopicName")]
        public string SrcTopicName{ get; set; }

        /// <summary>
        /// 日志集id
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 加工任务目的topic_id以及别名
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }

        /// <summary>
        /// 加工逻辑函数
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastEnableTime", this.LastEnableTime);
            this.SetParamSimple(map, prefix + "SrcTopicName", this.SrcTopicName);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
        }
    }
}

