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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLogTopicTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 日志集所属地区。
        /// </summary>
        [JsonProperty("LogSetRegion")]
        public string LogSetRegion{ get; set; }

        /// <summary>
        /// 日志集ID。
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// 日志主题ID。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 数据推送类型，可选的类型有：
        /// <li>domain：七层代理日志；</li>
        /// <li>application：四层代理日志；</li>
        /// <li>web-rateLiming：速率限制日志；</li>
        /// <li>web-attack：Web攻击防护日志；</li>
        /// <li>web-rule：自定义规则日志；</li>
        /// <li>web-bot：Bot管理日志。</li>
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// 推送任务名。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 待更新的主题名称，不填表示不更新主题名称。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 更新后的日志集名称。
        /// </summary>
        [JsonProperty("LogSetName")]
        public string LogSetName{ get; set; }

        /// <summary>
        /// 更新后的日志集保存时间。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 待添加的推送任务实体列表。
        /// </summary>
        [JsonProperty("DropEntityList")]
        public string[] DropEntityList{ get; set; }

        /// <summary>
        /// 待删除的推送任务实例列表。
        /// </summary>
        [JsonProperty("AddedEntityList")]
        public string[] AddedEntityList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "LogSetRegion", this.LogSetRegion);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "EntityType", this.EntityType);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "LogSetName", this.LogSetName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "DropEntityList.", this.DropEntityList);
            this.SetParamArraySimple(map, prefix + "AddedEntityList.", this.AddedEntityList);
        }
    }
}

