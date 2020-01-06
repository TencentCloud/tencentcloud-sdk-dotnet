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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CaptchaOperDataRes : AbstractModel
    {
        
        /// <summary>
        /// 验证码加载耗时数据返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperDataLoadTimeUnitArray")]
        public CaptchaOperDataLoadTimeUnit[] OperDataLoadTimeUnitArray{ get; set; }

        /// <summary>
        /// 验证码拦截情况数据返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperDataInterceptUnitArray")]
        public CaptchaOperDataInterceptUnit[] OperDataInterceptUnitArray{ get; set; }

        /// <summary>
        /// 验证码尝试次数数据返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperDataTryTimesUnitArray")]
        public CaptchaOperDataTryTimesUnit[] OperDataTryTimesUnitArray{ get; set; }

        /// <summary>
        /// 验证码尝试次数分布数据返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperDataTryTimesDistributeUnitArray")]
        public CaptchaOperDataTryTimesDistributeUnit[] OperDataTryTimesDistributeUnitArray{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "OperDataLoadTimeUnitArray.", this.OperDataLoadTimeUnitArray);
            this.SetParamArrayObj(map, prefix + "OperDataInterceptUnitArray.", this.OperDataInterceptUnitArray);
            this.SetParamArrayObj(map, prefix + "OperDataTryTimesUnitArray.", this.OperDataTryTimesUnitArray);
            this.SetParamArrayObj(map, prefix + "OperDataTryTimesDistributeUnitArray.", this.OperDataTryTimesDistributeUnitArray);
        }
    }
}

