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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Application : AbstractModel
    {
        
        /// <summary>
        /// <p>应用ID</p>
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>类型</p><p>枚举值：</p><ul><li>WDL： WDL</li><li>NEXTFLOW： NEXTFLOW</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>代码入口</p>
        /// </summary>
        [JsonProperty("Entrypoint")]
        public string Entrypoint{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>创建人</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>创建人ID</p>
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// <p>版本数量</p>
        /// </summary>
        [JsonProperty("VersionCount")]
        public long? VersionCount{ get; set; }

        /// <summary>
        /// <p>版本列表</p>
        /// </summary>
        [JsonProperty("Versions")]
        public ApplicationVersion[] Versions{ get; set; }

        /// <summary>
        /// <p>GIT信息</p>
        /// </summary>
        [JsonProperty("GitSource")]
        public GitInfo GitSource{ get; set; }

        /// <summary>
        /// <p>运行限制</p>
        /// </summary>
        [JsonProperty("RunConstraints")]
        public RunConstraints RunConstraints{ get; set; }

        /// <summary>
        /// <p>应用COS文件信息</p>
        /// </summary>
        [JsonProperty("CosSource")]
        public CosFileInfo CosSource{ get; set; }

        /// <summary>
        /// <p>排序顺序</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public long? SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Entrypoint", this.Entrypoint);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "VersionCount", this.VersionCount);
            this.SetParamArrayObj(map, prefix + "Versions.", this.Versions);
            this.SetParamObj(map, prefix + "GitSource.", this.GitSource);
            this.SetParamObj(map, prefix + "RunConstraints.", this.RunConstraints);
            this.SetParamObj(map, prefix + "CosSource.", this.CosSource);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}

