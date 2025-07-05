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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetailedRolePerm : AbstractModel
    {
        
        /// <summary>
        /// 权限对应的资源
        /// 可以是主题名称，从 [DescribeTopicList](https://cloud.tencent.com/document/api/1493/96030) 接口返回的 [TopicItem](https://cloud.tencent.com/document/api/1493/96031#TopicItem) 或控制台获得。
        /// 可以是消费组名称，从 [DescribeConsumerGroupList](https://cloud.tencent.com/document/api/1493/101535) 接口返回的 [ConsumeGroupItem](https://cloud.tencent.com/document/api/1493/96031#ConsumeGroupItem) 或控制台获得。
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 是否开启生产权限
        /// </summary>
        [JsonProperty("PermWrite")]
        public bool? PermWrite{ get; set; }

        /// <summary>
        /// 是否开启消费权限
        /// </summary>
        [JsonProperty("PermRead")]
        public bool? PermRead{ get; set; }

        /// <summary>
        /// 授权资源类型（Topic:主题; Group:消费组）
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 资源备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "PermWrite", this.PermWrite);
            this.SetParamSimple(map, prefix + "PermRead", this.PermRead);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

