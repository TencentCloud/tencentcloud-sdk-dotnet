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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePublishSubscribeRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID，形如mssql-j8kv137v
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 订阅/发布实例ID，与InstanceId是发布实例还是订阅实例有关；当InstanceId为发布实例时，本字段按照订阅实例ID做筛选；当InstanceId为订阅实例时，本字段按照发布实例ID做筛选；
        /// </summary>
        [JsonProperty("PubOrSubInstanceId")]
        public string PubOrSubInstanceId{ get; set; }

        /// <summary>
        /// 订阅/发布实例内网IP，与InstanceId是发布实例还是订阅实例有关；当InstanceId为发布实例时，本字段按照订阅实例内网IP做筛选；当InstanceId为订阅实例时，本字段按照发布实例内网IP做筛选；
        /// </summary>
        [JsonProperty("PubOrSubInstanceIp")]
        public string PubOrSubInstanceIp{ get; set; }

        /// <summary>
        /// 订阅发布ID，用于筛选
        /// </summary>
        [JsonProperty("PublishSubscribeId")]
        public ulong? PublishSubscribeId{ get; set; }

        /// <summary>
        /// 订阅发布名字，用于筛选
        /// </summary>
        [JsonProperty("PublishSubscribeName")]
        public string PublishSubscribeName{ get; set; }

        /// <summary>
        /// 发布库名字，用于筛选
        /// </summary>
        [JsonProperty("PublishDBName")]
        public string PublishDBName{ get; set; }

        /// <summary>
        /// 订阅库名字，用于筛选
        /// </summary>
        [JsonProperty("SubscribeDBName")]
        public string SubscribeDBName{ get; set; }

        /// <summary>
        /// 分页，页数
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页，页大小
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PubOrSubInstanceId", this.PubOrSubInstanceId);
            this.SetParamSimple(map, prefix + "PubOrSubInstanceIp", this.PubOrSubInstanceIp);
            this.SetParamSimple(map, prefix + "PublishSubscribeId", this.PublishSubscribeId);
            this.SetParamSimple(map, prefix + "PublishSubscribeName", this.PublishSubscribeName);
            this.SetParamSimple(map, prefix + "PublishDBName", this.PublishDBName);
            this.SetParamSimple(map, prefix + "SubscribeDBName", this.SubscribeDBName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

