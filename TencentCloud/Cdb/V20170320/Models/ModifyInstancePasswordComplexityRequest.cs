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
        /// 要修改密码复杂度的实例 ID。
        /// 说明：支持输入多个实例 ID 进行修改。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 要修改的密码复杂度的选项。每一个选项是以组合形式写入的，一个组合包括 Name 和 CurrentValue，其中 Name 表示对应选项的参数名，CurrentValue 表示参数值。例如：[{"Name": "validate_password.length", "CurrentValue": "10"}]，表示将密码的最小字符数修改为10。
        /// 说明：不同数据库版本的实例，支持修改的密码复杂度的选项如下。
        /// 1. MySQL 8.0：
        /// 选项 validate_password.policy，表示密码复杂度的开关，值为 LOW 时表示关闭；值为 MEDIUM 时表示开启。温馨提示：如需修改具体的密码策略，此选项的值需为 MEDIUM。
        /// 选项 validate_password.length，表示密码总长度的最小字符数。
        /// 选项 validate_password.mixed_case_count，表示小写和大写字母的最小字符数。
        /// 选项 validate_password.number_count，表示数字的最小字符数。
        /// 选项 validate_password.special_char_count，表示特殊字符的最小字符数。
        /// 2. MySQL 5.6、MySQL 5.7：
        /// 选项 validate_password_policy，表示密码复杂度的开关，值为 LOW 时表示关闭；值为 MEDIUM 时表示开启。温馨提示：如需修改具体的密码策略，此选项的值需为 MEDIUM。
        /// 选项 validate_password_length，表示密码总长度的最小字符数。
        /// 选项 validate_password_mixed_case_count，表示小写和大写字母的最小字符数。
        /// 选项 validate_password_number_count，表示数字的最小字符数。
        /// 选项 validate_password_special_char_count，表示特殊字符的最小字符数。
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

