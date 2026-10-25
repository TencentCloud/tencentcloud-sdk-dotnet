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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateModelVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>目录名称，必填</p>
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// <p>模式名称，必填</p>
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>模型名称，必填</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>模型版本号，必填</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public long? ModelVersion{ get; set; }

        /// <summary>
        /// <p>调用时所在workspace唯一id，必填</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>要添加的别名，可选</p>
        /// </summary>
        [JsonProperty("AddedAliases")]
        public string[] AddedAliases{ get; set; }

        /// <summary>
        /// <p>要移除的别名，可选</p>
        /// </summary>
        [JsonProperty("RemovedAliases")]
        public string[] RemovedAliases{ get; set; }

        /// <summary>
        /// <p>新注释，可选，为空表示不修改注释</p>
        /// </summary>
        [JsonProperty("NewComment")]
        public string NewComment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamArraySimple(map, prefix + "AddedAliases.", this.AddedAliases);
            this.SetParamArraySimple(map, prefix + "RemovedAliases.", this.RemovedAliases);
            this.SetParamSimple(map, prefix + "NewComment", this.NewComment);
        }
    }
}

