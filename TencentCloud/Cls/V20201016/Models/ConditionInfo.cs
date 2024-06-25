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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConditionInfo : AbstractModel
    {
        
        /// <summary>
        /// 条件属性，目前只支持VpcID
        /// </summary>
        [JsonProperty("Attributes")]
        public string Attributes{ get; set; }

        /// <summary>
        /// 条件规则，1:等于，2:不等于
        /// </summary>
        [JsonProperty("Rule")]
        public ulong? Rule{ get; set; }

        /// <summary>
        /// 对应条件属性的值
        /// </summary>
        [JsonProperty("ConditionValue")]
        public string ConditionValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Attributes", this.Attributes);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "ConditionValue", this.ConditionValue);
        }
    }
}

