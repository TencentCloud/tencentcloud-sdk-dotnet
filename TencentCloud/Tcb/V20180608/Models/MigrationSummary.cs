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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrationSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>migration 版本号</p><p>参数格式：纯数字，14位时间格式</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>migration 版本名</p><p>参数格式：仅允许小写字母和下划线</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>migration query sql 语句checksum，服务端自动生成，同版本不同checksum会拒绝执行</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("Checksum")]
        public string Checksum{ get; set; }

        /// <summary>
        /// <p>应用时间</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("AppliedAt")]
        public string AppliedAt{ get; set; }

        /// <summary>
        /// <p>请求来源</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>migration 创建时间</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Checksum", this.Checksum);
            this.SetParamSimple(map, prefix + "AppliedAt", this.AppliedAt);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
        }
    }
}

