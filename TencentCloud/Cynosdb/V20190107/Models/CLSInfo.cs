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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CLSInfo : AbstractModel
    {
        
        /// <summary>
        /// 日志主题操作：可选create,reuse。
        /// create:新增日志主题，使用TopicName创建日志主题。
        /// reuse:使用已有日志主题，使用TopicId指定日志主题。
        /// 不允许使用已有日志主题且新建日志集的组合。
        /// </summary>
        [JsonProperty("TopicOperation")]
        public string TopicOperation{ get; set; }

        /// <summary>
        /// 日志集操作：可选create,reuse。
        /// create:新增日志集，使用GroupName创建日志集。
        /// reuse:使用已有日志集，使用GroupId指定日志集。
        /// 不允许使用已有日志主题且新建日志集的组合。
        /// </summary>
        [JsonProperty("GroupOperation")]
        public string GroupOperation{ get; set; }

        /// <summary>
        /// 日志投递地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 日志主题id
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 日志主题name
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 日志集id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 日志集name
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicOperation", this.TopicOperation);
            this.SetParamSimple(map, prefix + "GroupOperation", this.GroupOperation);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
        }
    }
}

