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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessRule : AbstractModel
    {
        
        /// <summary>
        /// <p>模块</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>功能权限点</p>
        /// </summary>
        [JsonProperty("ActionType")]
        public string[] ActionType{ get; set; }

        /// <summary>
        /// <p>数据权限点</p>
        /// </summary>
        [JsonProperty("DataActionType")]
        public string[] DataActionType{ get; set; }

        /// <summary>
        /// <p>功能权限点名称</p>
        /// </summary>
        [JsonProperty("ActionTypeName")]
        public string[] ActionTypeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamArraySimple(map, prefix + "ActionType.", this.ActionType);
            this.SetParamArraySimple(map, prefix + "DataActionType.", this.DataActionType);
            this.SetParamArraySimple(map, prefix + "ActionTypeName.", this.ActionTypeName);
        }
    }
}

