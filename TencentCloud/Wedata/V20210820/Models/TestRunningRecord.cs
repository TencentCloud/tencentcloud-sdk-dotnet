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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TestRunningRecord : AbstractModel
    {
        
        /// <summary>
        /// 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 试运行记录id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordId")]
        public long? RecordId{ get; set; }

        /// <summary>
        /// 开发侧提交的jobid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// 执行平台jobid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionJobId")]
        public string ExecutionJobId{ get; set; }

        /// <summary>
        /// 试运行记录名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordName")]
        public string RecordName{ get; set; }

        /// <summary>
        /// 脚本内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptContent")]
        public string ScriptContent{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 耗时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeCost")]
        public long? TimeCost{ get; set; }

        /// <summary>
        /// 用户uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// 主账户uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 子记录信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubRecordList")]
        public TestRunningSubRecord[] SubRecordList{ get; set; }

        /// <summary>
        /// 结果或日志地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 结果或日志桶名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "ExecutionJobId", this.ExecutionJobId);
            this.SetParamSimple(map, prefix + "RecordName", this.RecordName);
            this.SetParamSimple(map, prefix + "ScriptContent", this.ScriptContent);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TimeCost", this.TimeCost);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamArrayObj(map, prefix + "SubRecordList.", this.SubRecordList);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
        }
    }
}

