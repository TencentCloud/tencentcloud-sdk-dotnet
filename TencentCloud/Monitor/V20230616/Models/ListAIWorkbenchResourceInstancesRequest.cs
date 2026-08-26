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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListAIWorkbenchResourceInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源地图 ID</p>
        /// </summary>
        [JsonProperty("ResourceMapId")]
        public string ResourceMapId{ get; set; }

        /// <summary>
        /// <p>分页参数</p>
        /// </summary>
        [JsonProperty("PageParams")]
        public PageByNumParams PageParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceMapId", this.ResourceMapId);
            this.SetParamObj(map, prefix + "PageParams.", this.PageParams);
        }
    }
}

