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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DefaultAction : AbstractModel
    {
        
        /// <summary>
        /// 转发目标组配置。创建监听器时转发动作中的目标组配置仅支持单个目标组。
        /// </summary>
        [JsonProperty("TargetGroupConfig")]
        public TargetGroupConfig TargetGroupConfig{ get; set; }

        /// <summary>
        /// 转发动作类型。创建监听器时，默认转发动作类型仅支持转发至目标组。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TargetGroupConfig.", this.TargetGroupConfig);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

