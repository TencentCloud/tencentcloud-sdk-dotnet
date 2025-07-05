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

    public class RunWorkflowRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务批次名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 投递环境ID。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 工作流Git仓库信息。
        /// </summary>
        [JsonProperty("GitSource")]
        public GitInfo GitSource{ get; set; }

        /// <summary>
        /// 工作流类型。
        /// 
        /// 支持类型：
        /// - NEXTFLOW
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Nextflow选项。
        /// </summary>
        [JsonProperty("NFOption")]
        public NFOption NFOption{ get; set; }

        /// <summary>
        /// 项目ID。
        /// （不填使用指定地域下的默认项目）
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务批次描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 任务输入JSON。需要进行base64编码。
        /// （InputBase64和InputCosUri必选其一）
        /// </summary>
        [JsonProperty("InputBase64")]
        public string InputBase64{ get; set; }

        /// <summary>
        /// 任务输入COS地址。
        /// （InputBase64和InputCosUri必选其一）
        /// </summary>
        [JsonProperty("InputCosUri")]
        public string InputCosUri{ get; set; }

        /// <summary>
        /// 任务缓存清理时间（小时）。不填或0表示不清理。
        /// </summary>
        [JsonProperty("CacheClearDelay")]
        public ulong? CacheClearDelay{ get; set; }

        /// <summary>
        /// 工作目录，可填写指定缓存卷内的绝对路径，不填使用默认缓存卷内的默认路径，暂时仅支持Nextflow。
        /// </summary>
        [JsonProperty("WorkDir")]
        public string WorkDir{ get; set; }

        /// <summary>
        /// 缓存卷ID，不填使用默认缓存卷，暂时仅支持Nextflow。
        /// </summary>
        [JsonProperty("VolumeIds")]
        public string[] VolumeIds{ get; set; }

        /// <summary>
        /// 工作流入口文件，不填使用默认入口文件。
        /// </summary>
        [JsonProperty("Entrypoint")]
        public string Entrypoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamObj(map, prefix + "GitSource.", this.GitSource);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "NFOption.", this.NFOption);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InputBase64", this.InputBase64);
            this.SetParamSimple(map, prefix + "InputCosUri", this.InputCosUri);
            this.SetParamSimple(map, prefix + "CacheClearDelay", this.CacheClearDelay);
            this.SetParamSimple(map, prefix + "WorkDir", this.WorkDir);
            this.SetParamArraySimple(map, prefix + "VolumeIds.", this.VolumeIds);
            this.SetParamSimple(map, prefix + "Entrypoint", this.Entrypoint);
        }
    }
}

