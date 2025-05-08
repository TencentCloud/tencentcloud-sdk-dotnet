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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceField : AbstractModel
    {
        
        /// <summary>
        /// 跟踪事件所属产品（支持全部产品或单个产品，如：cam，全部：*）
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 跟踪事件类型（读：Read；写：Write；全部：*）
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 跟踪事件接口名列表（ResourceType为 * 时，EventNames必须为全部：[""]；指定ResourceType时，支持全部接口：[""]；支持部分接口：["cos", "cls"]，接口列表上限10个）
        /// </summary>
        [JsonProperty("EventNames")]
        public string[] EventNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamArraySimple(map, prefix + "EventNames.", this.EventNames);
        }
    }
}

