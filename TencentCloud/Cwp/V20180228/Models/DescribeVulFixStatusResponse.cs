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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulFixStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 开始修复时间
        /// </summary>
        [JsonProperty("FixStartTime")]
        public string FixStartTime{ get; set; }

        /// <summary>
        /// 修复结束时间，为空表示还没结束
        /// </summary>
        [JsonProperty("FixEndTime")]
        public string FixEndTime{ get; set; }

        /// <summary>
        /// 修复成功的主机数
        /// </summary>
        [JsonProperty("FixSuccessCnt")]
        public ulong? FixSuccessCnt{ get; set; }

        /// <summary>
        /// 修复失败的主机数
        /// </summary>
        [JsonProperty("FixFailCnt")]
        public ulong? FixFailCnt{ get; set; }

        /// <summary>
        /// 主机总数
        /// </summary>
        [JsonProperty("HostCnt")]
        public ulong? HostCnt{ get; set; }

        /// <summary>
        /// 修复的任务id
        /// </summary>
        [JsonProperty("FixId")]
        public ulong? FixId{ get; set; }

        /// <summary>
        /// 修复快照状态列表
        /// </summary>
        [JsonProperty("SnapshotList")]
        public VulFixStatusSnapshotInfo[] SnapshotList{ get; set; }

        /// <summary>
        /// 修复漏洞详情列表
        /// </summary>
        [JsonProperty("VulFixList")]
        public VulFixStatusInfo[] VulFixList{ get; set; }

        /// <summary>
        /// 快照创建进度0-100
        /// </summary>
        [JsonProperty("SnapshotProgress")]
        public ulong? SnapshotProgress{ get; set; }

        /// <summary>
        /// 修复进度 0-100
        /// </summary>
        [JsonProperty("FixProgress")]
        public ulong? FixProgress{ get; set; }

        /// <summary>
        /// 预计剩余时间（单位秒）
        /// </summary>
        [JsonProperty("RemainingTime")]
        public ulong? RemainingTime{ get; set; }

        /// <summary>
        /// 快照是否是重试状态 0=非重试  1=重试
        /// </summary>
        [JsonProperty("IsRetrySnapshot")]
        public ulong? IsRetrySnapshot{ get; set; }

        /// <summary>
        /// 快照创建失败数
        /// </summary>
        [JsonProperty("SnapshotFailCnt")]
        public ulong? SnapshotFailCnt{ get; set; }

        /// <summary>
        /// 是否允许重试 0:不允许 1：允许
        /// </summary>
        [JsonProperty("IsAllowRetry")]
        public ulong? IsAllowRetry{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FixStartTime", this.FixStartTime);
            this.SetParamSimple(map, prefix + "FixEndTime", this.FixEndTime);
            this.SetParamSimple(map, prefix + "FixSuccessCnt", this.FixSuccessCnt);
            this.SetParamSimple(map, prefix + "FixFailCnt", this.FixFailCnt);
            this.SetParamSimple(map, prefix + "HostCnt", this.HostCnt);
            this.SetParamSimple(map, prefix + "FixId", this.FixId);
            this.SetParamArrayObj(map, prefix + "SnapshotList.", this.SnapshotList);
            this.SetParamArrayObj(map, prefix + "VulFixList.", this.VulFixList);
            this.SetParamSimple(map, prefix + "SnapshotProgress", this.SnapshotProgress);
            this.SetParamSimple(map, prefix + "FixProgress", this.FixProgress);
            this.SetParamSimple(map, prefix + "RemainingTime", this.RemainingTime);
            this.SetParamSimple(map, prefix + "IsRetrySnapshot", this.IsRetrySnapshot);
            this.SetParamSimple(map, prefix + "SnapshotFailCnt", this.SnapshotFailCnt);
            this.SetParamSimple(map, prefix + "IsAllowRetry", this.IsAllowRetry);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

