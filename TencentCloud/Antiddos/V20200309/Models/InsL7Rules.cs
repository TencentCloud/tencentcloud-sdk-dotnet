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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InsL7Rules : AbstractModel
    {
        
        /// <summary>
        /// 规则在中间状态不可修改，只可在（0， 2， 8）状态可编辑。
        /// 规则状态，0: 正常运行中, 1: 配置规则中(配置生效中), 2: 配置规则失败（配置生效失败）, 3: 删除规则中(删除生效中), 5: 删除规则失败(删除失败), 6: 等待添加规则, 7: 等待删除规则, 8: 等待上传证书, 9: 规则对应的资源不存在，被隔离, 10:等待修改规则, 11:配置修改中
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InsId")]
        public string InsId{ get; set; }

        /// <summary>
        /// 用户AppID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 高防端口
        /// </summary>
        [JsonProperty("VirtualPort")]
        public string VirtualPort{ get; set; }

        /// <summary>
        /// 证书ID
        /// </summary>
        [JsonProperty("SSLId")]
        public string SSLId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "InsId", this.InsId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "VirtualPort", this.VirtualPort);
            this.SetParamSimple(map, prefix + "SSLId", this.SSLId);
        }
    }
}

