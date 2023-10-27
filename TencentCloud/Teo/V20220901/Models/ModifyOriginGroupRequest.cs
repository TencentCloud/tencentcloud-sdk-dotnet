/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyOriginGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 源站组 ID，此参数必填。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 源站组名称，不填保持原有配置，可输入1 - 200个字符，允许的字符为 a - z, A - Z, 0 - 9, _, - 。	
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 源站组类型，取值有：
        /// <li>GENERAL：通用型源站组，仅支持添加 IP/域名 源站，可以被域名服务、规则引擎、四层代理、通用型负载均衡引用；</li>
        /// <li>HTTP： HTTP专用型源站组，支持添加 IP/域名、对象存储源站，无法被四层代理引用。</li>不填保持原有配置。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 源站记录信息，不填保持原有配置。
        /// </summary>
        [JsonProperty("Records")]
        public OriginRecord[] Records{ get; set; }

        /// <summary>
        /// 回源 Host Header，仅 Type = HTTP 时生效， 不填或者填空表示不配置回源Host，规则引擎修改 Host Header 配置优先级高于源站组的 Host Header。
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Records.", this.Records);
            this.SetParamSimple(map, prefix + "HostHeader", this.HostHeader);
        }
    }
}

