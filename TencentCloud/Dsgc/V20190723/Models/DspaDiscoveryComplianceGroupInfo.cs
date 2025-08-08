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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaDiscoveryComplianceGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 合规组ID
        /// </summary>
        [JsonProperty("ComplianceGroupId")]
        public long? ComplianceGroupId{ get; set; }

        /// <summary>
        /// 合规组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 合规组描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 合规组类型；0 默认合规组，1 系统合规组（除默认合规组外）, 2 自定义合规组
        /// </summary>
        [JsonProperty("ComplianceGroupType")]
        public long? ComplianceGroupType{ get; set; }

        /// <summary>
        /// 合规组对应的规则项
        /// </summary>
        [JsonProperty("ComplianceGroupRules")]
        public DspaDiscoveryComplianceGroupRule[] ComplianceGroupRules{ get; set; }

        /// <summary>
        /// 合规组对应的分级组ID
        /// </summary>
        [JsonProperty("LevelGroupId")]
        public ulong? LevelGroupId{ get; set; }

        /// <summary>
        /// 是否禁止使用（true，禁止使用，false，可以使用）
        /// </summary>
        [JsonProperty("Disabled")]
        public bool? Disabled{ get; set; }

        /// <summary>
        /// 是否别名
        /// </summary>
        [JsonProperty("IsAlias")]
        public bool? IsAlias{ get; set; }

        /// <summary>
        /// 1代表模板开启，0代表模板关闭
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 模板最后修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComplianceGroupId", this.ComplianceGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ComplianceGroupType", this.ComplianceGroupType);
            this.SetParamArrayObj(map, prefix + "ComplianceGroupRules.", this.ComplianceGroupRules);
            this.SetParamSimple(map, prefix + "LevelGroupId", this.LevelGroupId);
            this.SetParamSimple(map, prefix + "Disabled", this.Disabled);
            this.SetParamSimple(map, prefix + "IsAlias", this.IsAlias);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

