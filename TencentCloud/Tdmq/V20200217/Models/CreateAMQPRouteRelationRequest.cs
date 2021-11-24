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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAMQPRouteRelationRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 交换机所在的vhost
        /// </summary>
        [JsonProperty("VHostId")]
        public string VHostId{ get; set; }

        /// <summary>
        /// 源Exchange名称
        /// </summary>
        [JsonProperty("SourceExchange")]
        public string SourceExchange{ get; set; }

        /// <summary>
        /// 目标类型:Queue|Exchange
        /// </summary>
        [JsonProperty("DestType")]
        public string DestType{ get; set; }

        /// <summary>
        /// 目标值
        /// </summary>
        [JsonProperty("DestValue")]
        public string DestValue{ get; set; }

        /// <summary>
        /// 交换机说明，最大128个字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 绑定key,缺省值为default
        /// </summary>
        [JsonProperty("RoutingKey")]
        public string RoutingKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "VHostId", this.VHostId);
            this.SetParamSimple(map, prefix + "SourceExchange", this.SourceExchange);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "DestValue", this.DestValue);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "RoutingKey", this.RoutingKey);
        }
    }
}

