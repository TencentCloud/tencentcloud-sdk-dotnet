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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

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
        /// 任务输入JSON。需要进行base64编码。
        /// </summary>
        [JsonProperty("InputBase64")]
        public string InputBase64{ get; set; }

        /// <summary>
        /// 任务缓存清理时间（小时）。不填表示不清理。
        /// </summary>
        [JsonProperty("CacheClearDelay")]
        public ulong? CacheClearDelay{ get; set; }

        /// <summary>
        /// 运行选项。
        /// </summary>
        [JsonProperty("Option")]
        public RunOption Option{ get; set; }

        /// <summary>
        /// 任务批次描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 批量投递表格ID，不填表示单例投递。
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 批量投递表格行UUID。不填表示表格全部行。
        /// </summary>
        [JsonProperty("TableRowUuids")]
        public string[] TableRowUuids{ get; set; }

        /// <summary>
        /// 应用版本ID。不填表示使用当前最新版本。
        /// </summary>
        [JsonProperty("ApplicationVersionId")]
        public string ApplicationVersionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "InputBase64", this.InputBase64);
            this.SetParamSimple(map, prefix + "CacheClearDelay", this.CacheClearDelay);
            this.SetParamObj(map, prefix + "Option.", this.Option);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamArraySimple(map, prefix + "TableRowUuids.", this.TableRowUuids);
            this.SetParamSimple(map, prefix + "ApplicationVersionId", this.ApplicationVersionId);
        }
    }
}

