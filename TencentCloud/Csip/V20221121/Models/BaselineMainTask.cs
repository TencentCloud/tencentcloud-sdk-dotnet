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

    public class BaselineMainTask : AbstractModel
    {
        
        /// <summary>
        /// <p>主任务对应的全局任务 ID。</p>
        /// </summary>
        [JsonProperty("JobID")]
        public string JobID{ get; set; }

        /// <summary>
        /// <p>主任务 ID。</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>主任务状态。取值：</p><ul><li>INIT：初始化</li><li>SUBTASK_CREATING：子任务创建中</li><li>SCANNING：扫描中</li><li>TIMEOUT：超时</li><li>USER_CANCELED：用户取消</li><li>ALL_FAILED：全部失败</li><li>SUCCESS：成功</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>主任务所属租户 Appid。</p>
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// <p>主任务类型。取值：</p><ul><li>ONE_SHOT：一键策略扫描（手动触发）</li><li>PERIODIC：周期扫描（按 CycleScanConf 自动触发）</li><li>OTHER：其他分散扫描（资产维度等触发）</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>主任务开始执行时间。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>主任务结束时间，未结束时为空。</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>检测资产大类，区分主机基线与容器集群基线。取值：</p><ul><li>HOST：主机</li><li>CLUSTER：容器集群</li></ul>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string CheckAssetType{ get; set; }

        /// <summary>
        /// <p>失败错误码，成功时为空。</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>失败原因，成功时为空。</p>
        /// </summary>
        [JsonProperty("ErrMessage")]
        public string ErrMessage{ get; set; }

        /// <summary>
        /// <p>解决方案（根据 ErrCode 映射，成功时为空）</p>
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// <p>扫描成功的资产数量。</p>
        /// </summary>
        [JsonProperty("ScanSuccessCount")]
        public ulong? ScanSuccessCount{ get; set; }

        /// <summary>
        /// <p>扫描失败的资产数量。</p>
        /// </summary>
        [JsonProperty("ScanFailedCount")]
        public ulong? ScanFailedCount{ get; set; }

        /// <summary>
        /// <p>子任务总数</p>
        /// </summary>
        [JsonProperty("ScanTotalCount")]
        public ulong? ScanTotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobID", this.JobID);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "CheckAssetType", this.CheckAssetType);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMessage", this.ErrMessage);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "ScanSuccessCount", this.ScanSuccessCount);
            this.SetParamSimple(map, prefix + "ScanFailedCount", this.ScanFailedCount);
            this.SetParamSimple(map, prefix + "ScanTotalCount", this.ScanTotalCount);
        }
    }
}

