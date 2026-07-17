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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApmServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用ID</p>
        /// </summary>
        [JsonProperty("ServiceID")]
        public string ServiceID{ get; set; }

        /// <summary>
        /// <p>应用描述</p>
        /// </summary>
        [JsonProperty("ServiceDescription")]
        public string ServiceDescription{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceID", this.ServiceID);
            this.SetParamSimple(map, prefix + "ServiceDescription", this.ServiceDescription);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

