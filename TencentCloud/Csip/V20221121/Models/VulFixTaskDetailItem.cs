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

    public class VulFixTaskDetailItem : AbstractModel
    {
        
        /// <summary>
        /// <p>明细记录ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>关联的修复任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// <p>修复的漏洞ID</p>
        /// </summary>
        [JsonProperty("VulId")]
        public long? VulId{ get; set; }

        /// <summary>
        /// <p>修复的KB补丁ID</p>
        /// </summary>
        [JsonProperty("KBId")]
        public long? KBId{ get; set; }

        /// <summary>
        /// <p>主机实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>主机名称</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>主机内网IP</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>漏洞名称</p>
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// <p>执行状态<br>枚举值：<br>0：初始状态<br>1：已下发任务<br>11：客户端已确认<br>2：修复完成<br>3：客户端离线<br>4：超时<br>5：失败<br>6：不支持<br>9：等待快照创建完成中<br>10：快照创建失败</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>修复结果</p><p>枚举值：</p><ul><li>0： 初始状态</li><li>1： 修复成功</li><li>2： 修复失败</li><li>3： 修复中</li></ul>
        /// </summary>
        [JsonProperty("FixStatus")]
        public long? FixStatus{ get; set; }

        /// <summary>
        /// <p>快照状态<br>枚举值：<br>-1：无需创建快照<br>0：未开始<br>1：进行中<br>2：已完成<br>3：创建失败</p>
        /// </summary>
        [JsonProperty("SnapshotStatus")]
        public long? SnapshotStatus{ get; set; }

        /// <summary>
        /// <p>异常提示信息</p>
        /// </summary>
        [JsonProperty("ExceptionMessage")]
        public string ExceptionMessage{ get; set; }

        /// <summary>
        /// <p>修复启动时间<br>参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>修复结束时间<br>参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>快照创建时间<br>参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）</p>
        /// </summary>
        [JsonProperty("SnapshotCreateTime")]
        public string SnapshotCreateTime{ get; set; }

        /// <summary>
        /// <p>快照到期时间<br>参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）</p>
        /// </summary>
        [JsonProperty("SnapshotExpireTime")]
        public string SnapshotExpireTime{ get; set; }

        /// <summary>
        /// <p>快照创建失败原因（当 SnapshotStatus=3 时有值）</p>
        /// </summary>
        [JsonProperty("SnapshotFailReason")]
        public string SnapshotFailReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "KBId", this.KBId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "SnapshotStatus", this.SnapshotStatus);
            this.SetParamSimple(map, prefix + "ExceptionMessage", this.ExceptionMessage);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SnapshotCreateTime", this.SnapshotCreateTime);
            this.SetParamSimple(map, prefix + "SnapshotExpireTime", this.SnapshotExpireTime);
            this.SetParamSimple(map, prefix + "SnapshotFailReason", this.SnapshotFailReason);
        }
    }
}

