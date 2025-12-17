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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComponentLogConfig : AbstractModel
    {
        
        /// <summary>
        /// 组件名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 日志级别，对于支持动态调整日志级别的组件，开启日志时可指定该参数
        /// </summary>
        [JsonProperty("LogLevel")]
        public long? LogLevel{ get; set; }

        /// <summary>
        /// 日志集ID。如果不指定，则自动创建
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// 日志主题ID。如果不指定，则自动创建
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// topic 所属region。 该参数可实现日志跨地域投递
        /// </summary>
        [JsonProperty("TopicRegion")]
        public string TopicRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicRegion", this.TopicRegion);
        }
    }
}

