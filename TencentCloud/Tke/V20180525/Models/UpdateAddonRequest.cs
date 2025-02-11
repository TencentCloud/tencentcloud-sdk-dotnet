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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAddonRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// addon名称
        /// </summary>
        [JsonProperty("AddonName")]
        public string AddonName{ get; set; }

        /// <summary>
        /// addon版本（不传默认不更新，不传AddonVersion时RawValues必传）
        /// </summary>
        [JsonProperty("AddonVersion")]
        public string AddonVersion{ get; set; }

        /// <summary>
        /// addon的参数，是一个json格式的base64转码后的字符串（addon参数由DescribeAddonValues获取，不传RawValues时AddonVersion必传））
        /// </summary>
        [JsonProperty("RawValues")]
        public string RawValues{ get; set; }

        /// <summary>
        /// addon参数的更新策略，支持replace和merge两种策略，默认值为merge，兼容旧版本API。replace：使用新RawValues全量替换addon原RawValues，merge：根据新RawValues新增或更新addon原RawValues中对应参数。
        /// </summary>
        [JsonProperty("UpdateStrategy")]
        public string UpdateStrategy{ get; set; }

        /// <summary>
        /// 是否仅做更新检查，设置为true时仅做检查，不会更新组件
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AddonName", this.AddonName);
            this.SetParamSimple(map, prefix + "AddonVersion", this.AddonVersion);
            this.SetParamSimple(map, prefix + "RawValues", this.RawValues);
            this.SetParamSimple(map, prefix + "UpdateStrategy", this.UpdateStrategy);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

