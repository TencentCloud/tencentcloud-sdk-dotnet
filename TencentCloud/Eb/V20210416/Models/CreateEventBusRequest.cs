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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEventBusRequest : AbstractModel
    {
        
        /// <summary>
        /// 事件集名称，只能包含字母、中文、数字、下划线、连字符，以字母/中文开头，以数字、字母或中文结尾，2~60个字符
        /// </summary>
        [JsonProperty("EventBusName")]
        public string EventBusName{ get; set; }

        /// <summary>
        /// 事件集描述，只能包含数字、中英文及常用标点符号，不超过200个字符
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// EB存储时长
        /// </summary>
        [JsonProperty("SaveDays")]
        public long? SaveDays{ get; set; }

        /// <summary>
        /// EB是否开启存储
        /// </summary>
        [JsonProperty("EnableStore")]
        public bool? EnableStore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventBusName", this.EventBusName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SaveDays", this.SaveDays);
            this.SetParamSimple(map, prefix + "EnableStore", this.EnableStore);
        }
    }
}

