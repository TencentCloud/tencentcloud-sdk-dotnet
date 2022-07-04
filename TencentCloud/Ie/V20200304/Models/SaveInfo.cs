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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaveInfo : AbstractModel
    {
        
        /// <summary>
        /// 存储类型，可选值： 
        /// 1：CosInfo。
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Cos形式存储信息，当Type等于1时必选。
        /// </summary>
        [JsonProperty("CosInfo")]
        public CosInfo CosInfo{ get; set; }

        /// <summary>
        /// 存储信息ID标记，用于多个输出场景。部分任务支持多输出时，一般要求必选。
        /// ID只能包含字母、数字、下划线、中划线，长读不能超过128。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "CosInfo.", this.CosInfo);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

