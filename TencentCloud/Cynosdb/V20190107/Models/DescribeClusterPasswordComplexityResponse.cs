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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterPasswordComplexityResponse : AbstractModel
    {
        
        /// <summary>
        /// 数据字典参数
        /// </summary>
        [JsonProperty("ValidatePasswordDictionary")]
        public ParamInfo ValidatePasswordDictionary{ get; set; }

        /// <summary>
        /// 密码长度
        /// </summary>
        [JsonProperty("ValidatePasswordLength")]
        public ParamInfo ValidatePasswordLength{ get; set; }

        /// <summary>
        /// 大小写敏感字符个数
        /// </summary>
        [JsonProperty("ValidatePasswordMixedCaseCount")]
        public ParamInfo ValidatePasswordMixedCaseCount{ get; set; }

        /// <summary>
        /// 数字个数
        /// </summary>
        [JsonProperty("ValidatePasswordNumberCount")]
        public ParamInfo ValidatePasswordNumberCount{ get; set; }

        /// <summary>
        /// 密码等级
        /// </summary>
        [JsonProperty("ValidatePasswordPolicy")]
        public ParamInfo ValidatePasswordPolicy{ get; set; }

        /// <summary>
        /// 特殊字符个数
        /// </summary>
        [JsonProperty("ValidatePasswordSpecialCharCount")]
        public ParamInfo ValidatePasswordSpecialCharCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ValidatePasswordDictionary.", this.ValidatePasswordDictionary);
            this.SetParamObj(map, prefix + "ValidatePasswordLength.", this.ValidatePasswordLength);
            this.SetParamObj(map, prefix + "ValidatePasswordMixedCaseCount.", this.ValidatePasswordMixedCaseCount);
            this.SetParamObj(map, prefix + "ValidatePasswordNumberCount.", this.ValidatePasswordNumberCount);
            this.SetParamObj(map, prefix + "ValidatePasswordPolicy.", this.ValidatePasswordPolicy);
            this.SetParamObj(map, prefix + "ValidatePasswordSpecialCharCount.", this.ValidatePasswordSpecialCharCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

