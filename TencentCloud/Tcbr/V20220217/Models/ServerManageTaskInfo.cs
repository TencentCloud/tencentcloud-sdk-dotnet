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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerManageTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 环境Id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [JsonProperty("ChangeType")]
        public string ChangeType{ get; set; }

        /// <summary>
        /// 发布类型
        /// </summary>
        [JsonProperty("ReleaseType")]
        public string ReleaseType{ get; set; }

        /// <summary>
        /// 部署类型
        /// </summary>
        [JsonProperty("DeployType")]
        public string DeployType{ get; set; }

        /// <summary>
        /// 上一个版本名
        /// </summary>
        [JsonProperty("PreVersionName")]
        public string PreVersionName{ get; set; }

        /// <summary>
        /// 版本名
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 流水线Id
        /// </summary>
        [JsonProperty("PipelineId")]
        public long? PipelineId{ get; set; }

        /// <summary>
        /// 流水线任务Id
        /// </summary>
        [JsonProperty("PipelineTaskId")]
        public long? PipelineTaskId{ get; set; }

        /// <summary>
        /// 发布单Id
        /// </summary>
        [JsonProperty("ReleaseId")]
        public long? ReleaseId{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 步骤信息
        /// </summary>
        [JsonProperty("Steps")]
        public TaskStepInfo[] Steps{ get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 操作标识
        /// </summary>
        [JsonProperty("OperatorRemark")]
        public string OperatorRemark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ChangeType", this.ChangeType);
            this.SetParamSimple(map, prefix + "ReleaseType", this.ReleaseType);
            this.SetParamSimple(map, prefix + "DeployType", this.DeployType);
            this.SetParamSimple(map, prefix + "PreVersionName", this.PreVersionName);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "PipelineId", this.PipelineId);
            this.SetParamSimple(map, prefix + "PipelineTaskId", this.PipelineTaskId);
            this.SetParamSimple(map, prefix + "ReleaseId", this.ReleaseId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Steps.", this.Steps);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "OperatorRemark", this.OperatorRemark);
        }
    }
}

