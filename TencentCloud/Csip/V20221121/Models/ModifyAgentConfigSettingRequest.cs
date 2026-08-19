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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAgentConfigSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>日志采集类型列表，可选值：tcp_src_port/tcp_ingress/http_egress/http_ingress/app_access</p>
        /// </summary>
        [JsonProperty("LogCollectSettings")]
        public string[] LogCollectSettings{ get; set; }

        /// <summary>
        /// <p>资产选择方式：all-全部付费资产，tag-按标签选择，direct-直接选择</p>
        /// </summary>
        [JsonProperty("AssetSelectionType")]
        public string AssetSelectionType{ get; set; }

        /// <summary>
        /// <p>按标签选择时的标签ID数组（AssetSelectionType=tag时使用）</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public string[] TagIds{ get; set; }

        /// <summary>
        /// <p>直接选择的主机instance_id列表（AssetSelectionType=direct时使用）</p>
        /// </summary>
        [JsonProperty("InstanceIDs")]
        public string[] InstanceIDs{ get; set; }

        /// <summary>
        /// <p>排除的主机instance_id列表（AssetSelectionType=all时使用）</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDs")]
        public string[] ExcludeInstanceIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "LogCollectSettings.", this.LogCollectSettings);
            this.SetParamSimple(map, prefix + "AssetSelectionType", this.AssetSelectionType);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArraySimple(map, prefix + "InstanceIDs.", this.InstanceIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIDs.", this.ExcludeInstanceIDs);
        }
    }
}

