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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeliverSummary : AbstractModel
    {
        
        /// <summary>
        /// 投递类型，store（存储类），mq（消息通道）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliverType")]
        public string DeliverType{ get; set; }

        /// <summary>
        /// 投递子类型：cls，ckafka。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliverSubType")]
        public string DeliverSubType{ get; set; }

        /// <summary>
        /// 投递订阅者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliverConsumer")]
        public string DeliverConsumer{ get; set; }

        /// <summary>
        /// 投递订阅者名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliverConsumerName")]
        public string DeliverConsumerName{ get; set; }

        /// <summary>
        /// 投递
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliverError")]
        public string DeliverError{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeliverType", this.DeliverType);
            this.SetParamSimple(map, prefix + "DeliverSubType", this.DeliverSubType);
            this.SetParamSimple(map, prefix + "DeliverConsumer", this.DeliverConsumer);
            this.SetParamSimple(map, prefix + "DeliverConsumerName", this.DeliverConsumerName);
            this.SetParamSimple(map, prefix + "DeliverError", this.DeliverError);
        }
    }
}

