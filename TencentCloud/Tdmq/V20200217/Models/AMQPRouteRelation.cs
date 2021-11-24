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

    public class AMQPRouteRelation : AbstractModel
    {
        
        /// <summary>
        /// 路由关系ID
        /// </summary>
        [JsonProperty("RouteRelationId")]
        public string RouteRelationId{ get; set; }

        /// <summary>
        /// 源Exchange
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
        /// 绑定key
        /// </summary>
        [JsonProperty("RoutingKey")]
        public string RoutingKey{ get; set; }

        /// <summary>
        /// 源路由类型:Direct|Topic|Fanout
        /// </summary>
        [JsonProperty("SourceExchangeType")]
        public string SourceExchangeType{ get; set; }

        /// <summary>
        /// 创建时间，以毫秒为单位
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 修改时间，以毫秒为单位
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 说明信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteRelationId", this.RouteRelationId);
            this.SetParamSimple(map, prefix + "SourceExchange", this.SourceExchange);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "DestValue", this.DestValue);
            this.SetParamSimple(map, prefix + "RoutingKey", this.RoutingKey);
            this.SetParamSimple(map, prefix + "SourceExchangeType", this.SourceExchangeType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

