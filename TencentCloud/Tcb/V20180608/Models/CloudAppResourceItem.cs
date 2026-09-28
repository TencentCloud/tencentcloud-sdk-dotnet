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

    public class CloudAppResourceItem : AbstractModel
    {
        
        /// <summary>
        /// <p>服务名称</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>服务类型</p><p>枚举值：</p><ul><li>http-function： HTTP 云函数</li><li>function： 普通云函数</li><li>static-hosting： 静态托管</li></ul>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>服务部署版本</p>
        /// </summary>
        [JsonProperty("DeployedRef")]
        public string DeployedRef{ get; set; }

        /// <summary>
        /// <p>服务动作</p>
        /// </summary>
        [JsonProperty("DiffCategory")]
        public string DiffCategory{ get; set; }

        /// <summary>
        /// <p>服务状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "DeployedRef", this.DeployedRef);
            this.SetParamSimple(map, prefix + "DiffCategory", this.DiffCategory);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

