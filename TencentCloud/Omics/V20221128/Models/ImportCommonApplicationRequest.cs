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

    public class ImportCommonApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>公共应用ID</p>
        /// </summary>
        [JsonProperty("CommonAppUuid")]
        public string CommonAppUuid{ get; set; }

        /// <summary>
        /// <p>公共应用重命名</p>
        /// </summary>
        [JsonProperty("CommonAppNewName")]
        public string CommonAppNewName{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>公共应用类型</p><p>枚举值：</p><ul><li>WDL： WDL</li><li>NEXTFLOW： NEXTFLOW</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>NEXTFLOW版本</p>
        /// </summary>
        [JsonProperty("NextflowVersion")]
        public string NextflowVersion{ get; set; }

        /// <summary>
        /// <p>是否内部应用</p>
        /// </summary>
        [JsonProperty("Internal")]
        public bool? Internal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommonAppUuid", this.CommonAppUuid);
            this.SetParamSimple(map, prefix + "CommonAppNewName", this.CommonAppNewName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "NextflowVersion", this.NextflowVersion);
            this.SetParamSimple(map, prefix + "Internal", this.Internal);
        }
    }
}

