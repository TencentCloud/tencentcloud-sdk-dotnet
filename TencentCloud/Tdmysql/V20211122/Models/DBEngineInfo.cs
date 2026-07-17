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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DBEngineInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>引擎类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>引擎版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>引擎名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>引擎描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>是否最新版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("New")]
        public bool? New{ get; set; }

        /// <summary>
        /// <p>支持的兼容的模式，以,分隔</p>
        /// </summary>
        [JsonProperty("SQLMode")]
        public string[] SQLMode{ get; set; }

        /// <summary>
        /// <p>是否支持参数模板</p>
        /// </summary>
        [JsonProperty("IsSupportParamTemplate")]
        public bool? IsSupportParamTemplate{ get; set; }

        /// <summary>
        /// <p>是否支持Serverless模式</p>
        /// </summary>
        [JsonProperty("IsSupportServerless")]
        public bool? IsSupportServerless{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "New", this.New);
            this.SetParamArraySimple(map, prefix + "SQLMode.", this.SQLMode);
            this.SetParamSimple(map, prefix + "IsSupportParamTemplate", this.IsSupportParamTemplate);
            this.SetParamSimple(map, prefix + "IsSupportServerless", this.IsSupportServerless);
        }
    }
}

