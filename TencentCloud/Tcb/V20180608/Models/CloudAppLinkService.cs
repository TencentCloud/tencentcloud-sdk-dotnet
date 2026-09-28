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

    public class CloudAppLinkService : AbstractModel
    {
        
        /// <summary>
        /// <p>服务类型</p><p>枚举值：</p><ul><li>http-function： HTTP 云函数</li><li>function： 普通云函数</li><li>static-hosting： 静态托管</li></ul>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>服务名称</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>服务身份</p>
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// <p>服务动作</p>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>服务构建命令</p>
        /// </summary>
        [JsonProperty("Command")]
        public BuildCommands Command{ get; set; }

        /// <summary>
        /// <p>服务构建部署上下文</p>
        /// </summary>
        [JsonProperty("BuildContext")]
        public BuildContext BuildContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamObj(map, prefix + "Command.", this.Command);
            this.SetParamObj(map, prefix + "BuildContext.", this.BuildContext);
        }
    }
}

