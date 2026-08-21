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

    public class BaselineSubTask : AbstractModel
    {
        
        /// <summary>
        /// <p>子任务 ID。</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>所属主任务 ID（对应 BaselineMainTask.ID）。</p>
        /// </summary>
        [JsonProperty("TaskID")]
        public ulong? TaskID{ get; set; }

        /// <summary>
        /// <p>子任务执行结果。取值：</p><ul><li>SUCCESS：成功</li><li>FAILED：失败</li><li>USER_CANCELED：用户取消</li><li>CHECKING：检测中</li><li>UNKNOWN：未知状态</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>子任务所属租户 Appid。</p>
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// <p>子任务开始执行时间。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>子任务结束时间，未结束时为空。</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>检测资产大类，区分主机基线与容器集群基线。取值：</p><ul><li>HOST：主机</li><li>CLUSTER：容器集群</li></ul>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string CheckAssetType{ get; set; }

        /// <summary>
        /// <p>CheckAssetType=HOST 时返回的主机资产信息，CLUSTER 时为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostAsset")]
        public BaselineHostAsset HostAsset{ get; set; }

        /// <summary>
        /// <p>状态码：失败时返回失败码（如 AGENT_OFFLINE、SCAN_TIMEOUT、CLIENT_SCAN_FAILED 等），检测中时返回检测状态，成功或用户取消时为空。</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>失败时的详细原因描述，成功、用户取消或检测中时为空。</p>
        /// </summary>
        [JsonProperty("ErrMessage")]
        public string ErrMessage{ get; set; }

        /// <summary>
        /// <p>失败时的解决方案建议，成功、用户取消或检测中时为空。</p>
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// <p>CheckAssetType=CLUSTER 时返回的集群资产信息，HOST 时为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterAsset")]
        public BaselineClusterAsset ClusterAsset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "CheckAssetType", this.CheckAssetType);
            this.SetParamObj(map, prefix + "HostAsset.", this.HostAsset);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMessage", this.ErrMessage);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamObj(map, prefix + "ClusterAsset.", this.ClusterAsset);
        }
    }
}

