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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEnterpriseSecurityGroupRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则的uuid，可通过查询规则列表获取
        /// </summary>
        [JsonProperty("RuleUuid")]
        public ulong? RuleUuid{ get; set; }

        /// <summary>
        /// 修改类型，0：修改规则内容；1：修改单条规则开关状态；2：修改所有规则开关状态
        /// </summary>
        [JsonProperty("ModifyType")]
        public ulong? ModifyType{ get; set; }

        /// <summary>
        /// 编辑后的企业安全组规则数据；修改规则状态不用填该字段
        /// </summary>
        [JsonProperty("Data")]
        public SecurityGroupRule Data{ get; set; }

        /// <summary>
        /// 0是关闭,1是开启
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleUuid", this.RuleUuid);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

