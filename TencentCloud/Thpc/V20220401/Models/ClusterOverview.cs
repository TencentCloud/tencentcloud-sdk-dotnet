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

namespace TencentCloud.Thpc.V20220401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterOverview : AbstractModel
    {
        
        /// <summary>
        /// 集群ID。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群状态。取值范围：<br><li>PENDING：创建中<br><li>INITING：初始化中<br><li>INIT_FAILED：初始化失败<br><li>RUNNING：运行中<br><li>TERMINATING：销毁中
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// 集群名称。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群位置信息。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 集群创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 集群调度器。
        /// </summary>
        [JsonProperty("SchedulerType")]
        public string SchedulerType{ get; set; }

        /// <summary>
        /// 计算节点数量。
        /// </summary>
        [JsonProperty("ComputeNodeCount")]
        public long? ComputeNodeCount{ get; set; }

        /// <summary>
        /// 计算节点概览。
        /// </summary>
        [JsonProperty("ComputeNodeSet")]
        public ComputeNodeOverview[] ComputeNodeSet{ get; set; }

        /// <summary>
        /// 管控节点数量。
        /// </summary>
        [JsonProperty("ManagerNodeCount")]
        public long? ManagerNodeCount{ get; set; }

        /// <summary>
        /// 管控节点概览。
        /// </summary>
        [JsonProperty("ManagerNodeSet")]
        public ManagerNodeOverview[] ManagerNodeSet{ get; set; }

        /// <summary>
        /// 登录节点概览。
        /// </summary>
        [JsonProperty("LoginNodeSet")]
        public LoginNodeOverview[] LoginNodeSet{ get; set; }

        /// <summary>
        /// 登录节点数量。
        /// </summary>
        [JsonProperty("LoginNodeCount")]
        public long? LoginNodeCount{ get; set; }

        /// <summary>
        /// 集群所属私有网络ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SchedulerType", this.SchedulerType);
            this.SetParamSimple(map, prefix + "ComputeNodeCount", this.ComputeNodeCount);
            this.SetParamArrayObj(map, prefix + "ComputeNodeSet.", this.ComputeNodeSet);
            this.SetParamSimple(map, prefix + "ManagerNodeCount", this.ManagerNodeCount);
            this.SetParamArrayObj(map, prefix + "ManagerNodeSet.", this.ManagerNodeSet);
            this.SetParamArrayObj(map, prefix + "LoginNodeSet.", this.LoginNodeSet);
            this.SetParamSimple(map, prefix + "LoginNodeCount", this.LoginNodeCount);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

