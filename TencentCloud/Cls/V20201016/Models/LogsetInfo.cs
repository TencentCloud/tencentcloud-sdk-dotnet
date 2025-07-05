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

    public class LogsetInfo : AbstractModel
    {
        
        /// <summary>
        /// 日志集ID
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 日志集名称
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 云产品标识，日志集由其它云产品创建时，该字段会显示云产品名称，例如CDN、TKE
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// 日志集绑定的标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 日志集下日志主题的数目
        /// </summary>
        [JsonProperty("TopicCount")]
        public long? TopicCount{ get; set; }

        /// <summary>
        /// 若AssumerName非空，则表示创建该日志集的服务方角色
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TopicCount", this.TopicCount);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
        }
    }
}

