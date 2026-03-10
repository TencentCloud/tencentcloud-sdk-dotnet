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

    public class DataTransformResouceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>日志主题ID</p><ul><li>通过<a href="https://cloud.tencent.com/document/product/614/56454">获取日志主题列表</a>获取日志主题Id。</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>别名<br>限制：不能包含字符 |。</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>是否是跨账号主题，false不是跨账号主题，true是跨账号主题</p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("IsCrossAccount")]
        public bool? IsCrossAccount{ get; set; }

        /// <summary>
        /// <p>跨账号场景下，被投递账号给投递账号创建的角色ARN值，在被投递账号的角色里查找</p>
        /// </summary>
        [JsonProperty("RoleARN")]
        public string RoleARN{ get; set; }

        /// <summary>
        /// <p>外部ID值，可以在被投递账号的角色-载体里找到该值</p>
        /// </summary>
        [JsonProperty("ExternalId")]
        public string ExternalId{ get; set; }

        /// <summary>
        /// <p>topic名称</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>日志集的名称</p>
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "IsCrossAccount", this.IsCrossAccount);
            this.SetParamSimple(map, prefix + "RoleARN", this.RoleARN);
            this.SetParamSimple(map, prefix + "ExternalId", this.ExternalId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
        }
    }
}

