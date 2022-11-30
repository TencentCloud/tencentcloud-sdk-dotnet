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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstancePasswordComplexityRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例短 ID 列表。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 要修改的参数列表。每一个元素是Name和CurrentValue的组合。Name是参数名，CurrentValue是要修改成的值。8.0版本Name支持范围：["validate_password.policy","validate_password.length","validate_password.mixed_case_count","validate_password.number_count","validate_password.special_char_count"],5.6和5.7版本支持范围：["validate_password_policy","validate_password_length","validate_password_mixed_case_count","validate_password_number_count","validate_password_special_char_count"]
        /// </summary>
        [JsonProperty("ParamList")]
        public Parameter[] ParamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
        }
    }
}

