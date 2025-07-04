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

    public class StatisticalFilter : AbstractModel
    {
        
        /// <summary>
        /// 0:不基于统计检测
        /// 1:发生次数高于固定值
        /// 2:发生次数高于周期平均值的百分之
        /// 3:发生次数高于用户平均值的百分之
        /// </summary>
        [JsonProperty("OperatorType")]
        public long? OperatorType{ get; set; }

        /// <summary>
        /// 统计值
        /// </summary>
        [JsonProperty("Value")]
        public float? Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperatorType", this.OperatorType);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

