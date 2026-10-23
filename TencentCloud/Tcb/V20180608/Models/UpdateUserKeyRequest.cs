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

    public class UpdateUserKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>环境ID</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>用户密钥名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>用户密钥对标识，前半部分用户填写，后半部分平台按照一定规则生成</p>
        /// </summary>
        [JsonProperty("KeyID")]
        public string KeyID{ get; set; }

        /// <summary>
        /// <p>密钥对描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>授权类型code</p>
        /// </summary>
        [JsonProperty("AuthTypeCode")]
        public string AuthTypeCode{ get; set; }

        /// <summary>
        /// <p>根据授权类型的不同，ext会有不同的子结构</p>
        /// </summary>
        [JsonProperty("Ext")]
        public string Ext{ get; set; }

        /// <summary>
        /// <p>业务类型，integration：从集成中心来的，默认为空，表示是从授权管理中心来的</p>
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// <p>创建集成时创建对应的示例代码云函数需要的参数</p>
        /// </summary>
        [JsonProperty("RuntimeConfig")]
        public AgentRuntimeConfig RuntimeConfig{ get; set; }

        /// <summary>
        /// <p>创建集成时创建对应的示例代码云函数需要的函数名</p>
        /// </summary>
        [JsonProperty("DemoCodeFunctionName")]
        public string DemoCodeFunctionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "KeyID", this.KeyID);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AuthTypeCode", this.AuthTypeCode);
            this.SetParamSimple(map, prefix + "Ext", this.Ext);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamObj(map, prefix + "RuntimeConfig.", this.RuntimeConfig);
            this.SetParamSimple(map, prefix + "DemoCodeFunctionName", this.DemoCodeFunctionName);
        }
    }
}

