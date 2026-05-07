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

    public class UpdateAIModelRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>环境id</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>分组名</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>模型地址</p><p>枚举值：</p><ul><li>http://default.tcb： 默认模型地址，custom模型切换为builtin模型时使用</li></ul>
        /// </summary>
        [JsonProperty("BaseUrl")]
        public string BaseUrl{ get; set; }

        /// <summary>
        /// <p>模型名列表</p><p>Models 列表更新采用全量替换</p>
        /// </summary>
        [JsonProperty("Models")]
        public AIModel[] Models{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>模型状态, 1: 开启, 2: 关闭</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>模型密钥</p>
        /// </summary>
        [JsonProperty("Secret")]
        public AIModelSecret Secret{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "BaseUrl", this.BaseUrl);
            this.SetParamArrayObj(map, prefix + "Models.", this.Models);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Secret.", this.Secret);
        }
    }
}

