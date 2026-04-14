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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRocketMQMigrationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>任务类型：<br>0，集群迁移<br>1，导入到指定命名空间</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>待导入的主题列表</p>
        /// </summary>
        [JsonProperty("Topics")]
        public RocketMQTopicConfig[] Topics{ get; set; }

        /// <summary>
        /// <p>待导入的消费组列表</p>
        /// </summary>
        [JsonProperty("Groups")]
        public RocketMQGroupConfig[] Groups{ get; set; }

        /// <summary>
        /// <p>待导入的角色列表</p>
        /// </summary>
        [JsonProperty("Roles")]
        public RocketMQRoleConfig[] Roles{ get; set; }

        /// <summary>
        /// <p>指定导入的命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Topics.", this.Topics);
            this.SetParamArrayObj(map, prefix + "Groups.", this.Groups);
            this.SetParamArrayObj(map, prefix + "Roles.", this.Roles);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
        }
    }
}

