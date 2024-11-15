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

namespace TencentCloud.Cloudstudio.V20230508.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkspaceStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 工作空间 ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 工作空间名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 工作空间标识
        /// </summary>
        [JsonProperty("SpaceKey")]
        public string SpaceKey{ get; set; }

        /// <summary>
        /// 工作空间状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// CPU数量
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 工作空间图标
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// 工作空间状态, 异常原因
        /// </summary>
        [JsonProperty("StatusReason")]
        public string StatusReason{ get; set; }

        /// <summary>
        /// 工作空间描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 工作空间类型
        /// </summary>
        [JsonProperty("WorkspaceType")]
        public string WorkspaceType{ get; set; }

        /// <summary>
        /// Git 仓库 HTTPS 地址
        /// </summary>
        [JsonProperty("VersionControlUrl")]
        public string VersionControlUrl{ get; set; }

        /// <summary>
        /// Git 仓库引用。指定分支使用 /refs/heads/{分支名}, 指定 Tag 用 /refs/tags/{Tag名}
        /// </summary>
        [JsonProperty("VersionControlRef")]
        public string VersionControlRef{ get; set; }

        /// <summary>
        /// 最后操作时间
        /// </summary>
        [JsonProperty("LastOpsDate")]
        public string LastOpsDate{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateDate")]
        public string CreateDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SpaceKey", this.SpaceKey);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamSimple(map, prefix + "StatusReason", this.StatusReason);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "WorkspaceType", this.WorkspaceType);
            this.SetParamSimple(map, prefix + "VersionControlUrl", this.VersionControlUrl);
            this.SetParamSimple(map, prefix + "VersionControlRef", this.VersionControlRef);
            this.SetParamSimple(map, prefix + "LastOpsDate", this.LastOpsDate);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
        }
    }
}

