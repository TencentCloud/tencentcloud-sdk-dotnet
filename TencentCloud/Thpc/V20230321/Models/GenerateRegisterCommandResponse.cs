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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenerateRegisterCommandResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>渲染好的节点注册命令，可直接在IDC机器上以root身份执行。</p>
        /// </summary>
        [JsonProperty("RegisterCommand")]
        public string RegisterCommand{ get; set; }

        /// <summary>
        /// <p>节点注册码。作为不透明凭证使用，请妥善保管，仅在节点注册纳管时传入。</p>
        /// </summary>
        [JsonProperty("RegisterCode")]
        public string RegisterCode{ get; set; }

        /// <summary>
        /// <p>注册码到期的Unix时间戳，单位：秒。</p>
        /// </summary>
        [JsonProperty("ExpireAt")]
        public long? ExpireAt{ get; set; }

        /// <summary>
        /// <p>回显本次是否走内网专线代理。</p>
        /// </summary>
        [JsonProperty("Proxy")]
        public bool? Proxy{ get; set; }

        /// <summary>
        /// <p>代理终端节点VIP地址。当<code>Proxy=true</code>且终端节点就绪时非空。</p>
        /// </summary>
        [JsonProperty("EndPointVip")]
        public string EndPointVip{ get; set; }

        /// <summary>
        /// <p>终端节点状态。取值范围：</p><li>ACTIVE：已激活</li><li>BINDCHANGE：变更中</li><li>BINDINGCREATE：创建中</li><li>BINDINGDELETE：删除中</li><p></p>
        /// </summary>
        [JsonProperty("EndPointStatus")]
        public string EndPointStatus{ get; set; }

        /// <summary>
        /// <p>回显集群ID。</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegisterCommand", this.RegisterCommand);
            this.SetParamSimple(map, prefix + "RegisterCode", this.RegisterCode);
            this.SetParamSimple(map, prefix + "ExpireAt", this.ExpireAt);
            this.SetParamSimple(map, prefix + "Proxy", this.Proxy);
            this.SetParamSimple(map, prefix + "EndPointVip", this.EndPointVip);
            this.SetParamSimple(map, prefix + "EndPointStatus", this.EndPointStatus);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

