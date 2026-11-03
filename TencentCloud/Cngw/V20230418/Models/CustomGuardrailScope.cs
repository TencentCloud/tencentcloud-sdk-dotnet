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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomGuardrailScope : AbstractModel
    {
        
        /// <summary>
        /// <p>绑定方式：resource 显式指定业务资源；global 覆盖网关中当前支持的业务资源，由平台关联到其 Kong Route，并随受支持的资源变更协调绑定。不是创建一个独立的 Kong global 插件。相同 Route 不能同时被多个自定义护栏策略占用。</p>
        /// </summary>
        [JsonProperty("BindType")]
        public string BindType{ get; set; }

        /// <summary>
        /// <p>BindType=resource 时必填，1～200 个资源，ResourceType/ResourceId 组合不得重复；global 时不应填写资源或传 []。Modify 传入 Scope 时替换整个范围，不是增量追加。暂不纳入 Dify/Custom Agent 和 Legacy SSE MCP。</p>
        /// </summary>
        [JsonProperty("Resources")]
        public CustomGuardrailResourceRef[] Resources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
        }
    }
}

