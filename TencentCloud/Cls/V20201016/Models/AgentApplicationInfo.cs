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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentApplicationInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>应用id</p>
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// <p>应用名称</p>
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// <p>接入类型</p><p>枚举值：</p><ul><li>Langfuse：  Langfuse 是一款开源的 LLM（大语言模型）工程与可观测性平台（LLMOps Tool）</li></ul>
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// <p>应用下资源所属地域</p><p>例如：ap-guangzhou</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>日志主题列表</p>
        /// </summary>
        [JsonProperty("LogTopics")]
        public AgentTopicInfo[] LogTopics{ get; set; }

        /// <summary>
        /// <p>指标主题列表</p>
        /// </summary>
        [JsonProperty("MetricsTopics")]
        public AgentTopicInfo[] MetricsTopics{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>单位：秒</p><p>秒级时间戳</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p><p>单位：秒</p><p>秒级时间戳</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>日志集id</p>
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// <p>服务方名称</p>
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// <p>服务方子名称</p>
        /// </summary>
        [JsonProperty("SubAssumerName")]
        public string SubAssumerName{ get; set; }

        /// <summary>
        /// <p>服务方Uin</p>
        /// </summary>
        [JsonProperty("AssumerUin")]
        public ulong? AssumerUin{ get; set; }

        /// <summary>
        /// <p>服务方使用的角色</p>
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "LogTopics.", this.LogTopics);
            this.SetParamArrayObj(map, prefix + "MetricsTopics.", this.MetricsTopics);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamSimple(map, prefix + "SubAssumerName", this.SubAssumerName);
            this.SetParamSimple(map, prefix + "AssumerUin", this.AssumerUin);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
        }
    }
}

