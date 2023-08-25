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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDSPAComplianceGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 合规组ID
        /// </summary>
        [JsonProperty("ComplianceGroupId")]
        public long? ComplianceGroupId{ get; set; }

        /// <summary>
        /// 合规组名称，1-60个字符，仅允许输入中文、英文字母、数字、'_'、'-'，并且开头和结尾需为中文、英文字母或者数字，Name不可重复
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 合规组描述，最大长度为1024个字符
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 合规组规则配置（参数已废弃，请传空数组）
        /// </summary>
        [JsonProperty("ComplianceGroupRules")]
        public ComplianceGroupRuleIdInfo[] ComplianceGroupRules{ get; set; }

        /// <summary>
        /// 分级组ID，新增参数，可选参数，默认值为1
        /// </summary>
        [JsonProperty("LevelGroupId")]
        public ulong? LevelGroupId{ get; set; }

        /// <summary>
        /// 是否开启别名
        /// </summary>
        [JsonProperty("RuleAlias")]
        public bool? RuleAlias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "ComplianceGroupId", this.ComplianceGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "ComplianceGroupRules.", this.ComplianceGroupRules);
            this.SetParamSimple(map, prefix + "LevelGroupId", this.LevelGroupId);
            this.SetParamSimple(map, prefix + "RuleAlias", this.RuleAlias);
        }
    }
}

