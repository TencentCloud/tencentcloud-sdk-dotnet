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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResetInstanceBlueprint : AbstractModel
    {
        
        /// <summary>
        /// 镜像详细信息
        /// </summary>
        [JsonProperty("BlueprintInfo")]
        public Blueprint BlueprintInfo{ get; set; }

        /// <summary>
        /// 实例镜像是否可重置为目标镜像。
        /// 取值：
        /// true（允许）
        /// false（不允许）
        /// </summary>
        [JsonProperty("IsResettable")]
        public bool? IsResettable{ get; set; }

        /// <summary>
        /// 不可重置信息.当镜像可重置时为""
        /// </summary>
        [JsonProperty("NonResettableMessage")]
        public string NonResettableMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BlueprintInfo.", this.BlueprintInfo);
            this.SetParamSimple(map, prefix + "IsResettable", this.IsResettable);
            this.SetParamSimple(map, prefix + "NonResettableMessage", this.NonResettableMessage);
        }
    }
}

