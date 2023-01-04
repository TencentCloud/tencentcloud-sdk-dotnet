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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpFilter : AbstractModel
    {
        
        /// <summary>
        /// IP 黑白名单配置开关
        /// on：开启
        /// off：关闭
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// IP 黑白名单类型
        /// whitelist：白名单
        /// blacklist：黑名单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }

        /// <summary>
        /// IP 黑白名单列表
        /// 支持 X.X.X.X 形式 IP，或 /8、 /16、/24 形式网段
        /// 最多可填充 50 个白名单或 50 个黑名单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }

        /// <summary>
        /// IP 黑白名单分路径配置，白名单功能
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterRules")]
        public IpFilterPathRule[] FilterRules{ get; set; }

        /// <summary>
        /// IP 黑白名单验证失败时返回的 code（即将下线）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReturnCode")]
        public long? ReturnCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "FilterRules.", this.FilterRules);
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
        }
    }
}

