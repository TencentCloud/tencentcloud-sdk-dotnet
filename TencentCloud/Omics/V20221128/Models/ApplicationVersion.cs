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

    public class ApplicationVersion : AbstractModel
    {
        
        /// <summary>
        /// 版本类型。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 版本ID。
        /// </summary>
        [JsonProperty("ApplicationVersionId")]
        public string ApplicationVersionId{ get; set; }

        /// <summary>
        /// 发布名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 发布描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 入口文件。
        /// </summary>
        [JsonProperty("Entrypoint")]
        public string Entrypoint{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 创建者名称。
        /// </summary>
        [JsonProperty("CreatorName")]
        public string CreatorName{ get; set; }

        /// <summary>
        /// 创建者ID。
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// Git信息。
        /// </summary>
        [JsonProperty("GitInfo")]
        [System.Obsolete]
        public string GitInfo{ get; set; }

        /// <summary>
        /// Git信息。
        /// </summary>
        [JsonProperty("GitSource")]
        public GitInfo GitSource{ get; set; }

        /// <summary>
        /// COS信息。
        /// </summary>
        [JsonProperty("CosSource")]
        public CosFileInfo CosSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ApplicationVersionId", this.ApplicationVersionId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Entrypoint", this.Entrypoint);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CreatorName", this.CreatorName);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "GitInfo", this.GitInfo);
            this.SetParamObj(map, prefix + "GitSource.", this.GitSource);
            this.SetParamObj(map, prefix + "CosSource.", this.CosSource);
        }
    }
}

