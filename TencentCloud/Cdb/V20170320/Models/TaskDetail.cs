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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskDetail : AbstractModel
    {
        
        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 实例任务 ID。
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// 实例任务进度。
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 实例任务状态，可能的值包括：
        /// "UNDEFINED" - 未定义；
        /// "INITIAL" - 初始化；
        /// "RUNNING" - 运行中；
        /// "SUCCEED" - 执行成功；
        /// "FAILED" - 执行失败；
        /// "KILLED" - 已终止；
        /// "REMOVED" - 已删除；
        /// "PAUSED" - 已暂停。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 实例任务类型，可能的值包括：
        /// "ROLLBACK" - 数据库回档；
        /// "SQL OPERATION" - SQL操作；
        /// "IMPORT DATA" - 数据导入；
        /// "MODIFY PARAM" - 参数设置；
        /// "INITIAL" - 初始化云数据库实例；
        /// "REBOOT" - 重启云数据库实例；
        /// "OPEN GTID" - 开启云数据库实例GTID；
        /// "UPGRADE RO" - 只读实例升级；
        /// "BATCH ROLLBACK" - 数据库批量回档；
        /// "UPGRADE MASTER" - 主实例升级；
        /// "DROP TABLES" - 删除云数据库库表；
        /// "SWITCH DR TO MASTER" - 灾备实例提升为主。
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 实例任务开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 实例任务结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务关联的实例 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 异步任务的请求 ID。
        /// </summary>
        [JsonProperty("AsyncRequestId")]
        public string AsyncRequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "AsyncRequestId", this.AsyncRequestId);
        }
    }
}

